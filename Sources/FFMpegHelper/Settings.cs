using System;
using System.Collections.Generic;
using System.IO;

namespace FFMpegHelper
{
    public class Settings
    {
        public const string SomeErrorExtension = ".dup";
        public const int ByteInMegabyte = 1048576;
        private readonly List<string> _fullFileNames = new List<string>();

        public static string[] SupportedExtensions = {
            "*.avi",
            "*.mkv",
            "*.mts",
            "*.mpg",
            "*.jpg",
            "*.jpeg",
        };

        public bool IsStop { get; set; }
        public bool IsSaveBest { get; set; }
        public string PathToFFMpeg { get; set; }
        public string PathToTepm { get; set; }
        public string PathToSourceDirectory { get; set; }

        public double TotalFileSize { get; set; }

        public double ConvertedFileSize { get; set; }

        public string CodecAudio { get; set; }

        public List<string> FullFileNames { get { return _fullFileNames; } }

        public bool InitFileList(ICollection<string> searshPatterns)
        {
            _fullFileNames.Clear();
            if (!string.IsNullOrEmpty(PathToSourceDirectory)
                && !string.IsNullOrEmpty(PathToFFMpeg)
                && searshPatterns.Count > 0
                && Directory.Exists(PathToSourceDirectory)
                && File.Exists(PathToFFMpeg))
            {
                foreach (var ptrn in searshPatterns)
                {
                    _fullFileNames.AddRange(Directory.EnumerateFiles(PathToSourceDirectory, ptrn, SearchOption.AllDirectories));
                }
            }
            CalculateTotalFileSize();
            return searshPatterns.Count > 0;
        }

        public static string GetOutputeExtension(string filePath)
        {
            var ext = Path.GetExtension(filePath);
            if (ext.Equals(".avi", StringComparison.InvariantCultureIgnoreCase) ||
                ext.Equals(".mts", StringComparison.InvariantCultureIgnoreCase) ||
                ext.Equals(".mpg", StringComparison.InvariantCultureIgnoreCase) ||
                ext.Equals(".mkv", StringComparison.InvariantCultureIgnoreCase))
            {
                return ".mp4";
            }
            return ext;
        }

        public DateTime StartTime { get; set; }

        public void UpdateConvertedFileSize(string convertedFilePath)
        {
            FileInfo fi = new FileInfo(convertedFilePath);
            ConvertedFileSize += (double)fi.Length / ByteInMegabyte;
        }
        private void CalculateTotalFileSize()
        {
            TotalFileSize = 0;
            foreach (var file in _fullFileNames)
            {
                FileInfo fi = new FileInfo(file);
                TotalFileSize += (double)fi.Length / ByteInMegabyte;
            }
        }
    }
}
