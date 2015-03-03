using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using FFMpegHelper.Properties;
using NLog;

namespace FFMpegHelper
{
    public partial class Form1 : Form
    {
        private readonly Logger _log;
        private readonly Settings _settings;

        public Form1()
        {
            InitializeComponent();
            _log = LogManager.GetCurrentClassLogger();
            _settings = new Settings();
            CreateCheckBoxes();
        }

        private void CreateCheckBoxes()
        {
            foreach (var name in Settings.SupportedExtensions)
            {
                checkedListBox.Items.Add(name);
            }
            for (int i = 0; i < checkedListBox.Items.Count; i++)
            {
                checkedListBox.SetItemChecked(i, true);
            }
        }
        private bool InitSettings()
        {
            _settings.IsStop = false;
            _settings.PathToSourceDirectory = tbDirPath.Text;
            _settings.PathToFFMpeg = tbffMpegPath.Text;
            _settings.PathToTepm = tbTemp.Text;
            _settings.IsSaveBest = cbSaveBest.Checked;
            _settings.CodecAudio = tbCodecAudio.Text;

            var ptrns = CreatePattern();
            var loaded = _settings.InitFileList(ptrns);
            return loaded;
        }
        private void btnStart_Click(object sender, EventArgs e)
        {
            State.Text = Resources.PreparingToWork;
            var loaded = InitSettings();

            if (loaded)
            {
                RunConvertAsynk();
            }
        }
        private List<string> CreatePattern()
        {
            var template = new List<string>();

            foreach (var control in checkedListBox.CheckedItems)
            {
                template.Add(control.ToString());
            }
            return template;
        }

        private async void RunConvertAsynk()
        {
            decimal totalZip = 0;
            int index = 0;
            _settings.ConvertedFileSize = 0;
            _settings.StartTime = DateTime.Now;
            foreach (var file in _settings.FullFileNames)
            {
                var ttlm = (DateTime.Now - _settings.StartTime).TotalMinutes;
                var ttlw = (_settings.TotalFileSize / _settings.ConvertedFileSize) * (_settings.ConvertedFileSize / ttlm);
                State.Text = string.Format(Resources.StateMessage1, Environment.NewLine, file, index, _settings.FullFileNames.Count,
                    _settings.ConvertedFileSize, _settings.TotalFileSize, ttlm, totalZip / Settings.ByteInMegabyte,   ttlw);
                _settings.UpdateConvertedFileSize(file);
                long result = await ConvertFilesAsync(file, PrintLog);
                totalZip += result;
                index++;
                if (_settings.IsStop)
                    break;
            }
            State.Text = string.Format(Resources.StateMessage2, Environment.NewLine, index, _settings.FullFileNames.Count,
                _settings.ConvertedFileSize, _settings.TotalFileSize, totalZip / Settings.ByteInMegabyte,   
                (DateTime.Now - _settings.StartTime).TotalMinutes);
        }

        private void PrintLog(string filepath, string message)
        {
            LogBox.Invoke((Action)(() => LogBox.Text = string.Format("{0}{1}{2}", filepath, Environment.NewLine, message)));
        }

        public Task<long> ConvertFilesAsync(string filePath, Action<string, string> callback = null)
        {
            return Task.Run((() => ConvertFiles(filePath, callback)));
        }

        private void RunConvertProcess(string tempFilename, string outExtension, Action<string, string> callback, string sourceFileName)
        {
            ProcessStartInfo startInfo = new ProcessStartInfo
            {
                CreateNoWindow = true,
                UseShellExecute = false,
                RedirectStandardOutput = true,
                RedirectStandardError = true,
                FileName = _settings.PathToFFMpeg,
                WindowStyle = ProcessWindowStyle.Normal,
                Arguments = string.Format("-i \"{0}\" {2} \"{0}{1}\"", tempFilename, outExtension, _settings.CodecAudio)
            };

            using (Process p = Process.Start(startInfo))
            {
                if (callback != null)
                    while (p != null && !p.HasExited)
                    {
                        while (!p.StandardError.EndOfStream)
                        {
                            string message = p.StandardError.ReadLine();
                            if (!string.IsNullOrEmpty(message))
                            {
                                callback(sourceFileName, message);
                            }
                        }

                        while (!p.StandardOutput.EndOfStream)
                        {
                            string message = p.StandardOutput.ReadToEnd();
                            if (!string.IsNullOrEmpty(message))
                            {
                                callback(sourceFileName, message);
                            }
                        }
                    }

                if (p != null)
                {
                    p.WaitForExit();
                    p.Close();
                }
            }
        }

        private void TryMove(string from, string to, Action<string, string> callback)
        {
            if (File.Exists(from))
            {
                var dirPath = Path.GetDirectoryName(to);
                if (!string.IsNullOrEmpty(dirPath) && !Directory.Exists(dirPath))
                {
                    Directory.CreateDirectory(to);
                }

                if (File.Exists(to))
                {
                    var res = MessageBox.Show(string.Format(Resources.ErrorFileMoveTryContinue, to),
                        string.Empty, MessageBoxButtons.YesNo, MessageBoxIcon.Error);
                    if (res != DialogResult.Yes)
                    {
                        return;
                    }
                }

                int lim = 10;
                while (lim > 0)
                {
                    try
                    {
                        if (callback != null)
                            callback(from, string.Format(Resources.FileMove, from, to));
                        File.Move(from, to);
                        return;
                    }
                    catch (Exception)
                    {
                        if (callback != null)
                            callback(from, string.Format(Resources.ErrorFileMove, from, to));
                        GC.Collect();
                        GC.WaitForPendingFinalizers();
                        lim--;
                    }
                    Thread.Sleep(50);
                }
                throw new Exception(string.Format(Resources.ErrorFileMoveLimit, to));
            }
            MessageBox.Show(string.Format(Resources.ErrorFileMoveFileNotFound, @from), string.Empty, MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void TryDelete(string file, Action<string, string> callback)
        {
            if (File.Exists(file))
            {
                int lim = 10;
                while (lim > 0)
                {
                    try
                    {
                        if (callback != null)
                            callback(file, string.Format(Resources.FileDelete, file));
                        File.Delete(file);
                        return;
                    }
                    catch (Exception)
                    {
                        if (callback != null)
                            callback(file, string.Format(Resources.ErrorFileDelete, file));
                        GC.Collect();
                        GC.WaitForPendingFinalizers();
                        lim--;
                    }
                    Thread.Sleep(50);
                }
                throw new Exception(string.Format(Resources.ErrorFileDeleteLimit, file));
            }
        }

        private long ConvertFiles(string filePath, Action<string, string> callback)
        {
            long resultZip = 0;
            var fileName = Path.GetFileName(filePath) ?? string.Empty;
            var tempfile = Path.Combine(_settings.PathToTepm, fileName);
            var ext = Settings.GetOutputeExtension(filePath);

            try
            {
                TryMove(filePath, tempfile, callback);
                RunConvertProcess(tempfile, ext, callback, filePath);

                if (File.Exists(tempfile + ext))
                {
                    var fiOld = new FileInfo(tempfile);
                    var fiNew = new FileInfo(tempfile + ext);
                    var path = Path.Combine(Path.GetDirectoryName(filePath) ?? string.Empty, Path.GetFileNameWithoutExtension(filePath) ?? string.Empty);

                    if ((fiNew.Length > 0 && fiNew.Length < fiOld.Length) || (!_settings.IsSaveBest && fiOld.Extension != fiNew.Extension))
                    {
                        resultZip = fiOld.Length - fiNew.Length;
                        TryMove(tempfile + ext, path + ext, callback);
                        TryDelete(tempfile, callback);
                    }
                    else
                    {
                        TryMove(tempfile, filePath, callback);
                        TryMove(tempfile + ext, path + ext + Settings.SomeErrorExtension, callback);
                    }
                }
                else
                {
                    TryMove(tempfile, filePath, callback);
                }
            }
            catch (Exception ex)
            {
                _log.ErrorException(ex.Message, ex);
                try
                {
                    if (File.Exists(tempfile + ext))
                        TryMove(tempfile + ext, filePath + ext + Settings.SomeErrorExtension, callback);

                    if (File.Exists(tempfile))
                        TryMove(tempfile, filePath + Settings.SomeErrorExtension, callback);
                }
                catch (Exception exf)
                {
                    MessageBox.Show(exf.Message, Resources.ErrorCritical, MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            return resultZip;
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            _settings.IsStop = checkBox1.Checked;
        }
    }
}
