namespace FFMpegHelper
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnStart = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.tbffMpegPath = new System.Windows.Forms.TextBox();
            this.tbDirPath = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tbTemp = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.State = new System.Windows.Forms.RichTextBox();
            this.LogBox = new System.Windows.Forms.RichTextBox();
            this.checkedListBox = new System.Windows.Forms.CheckedListBox();
            this.cbSaveBest = new System.Windows.Forms.CheckBox();
            this.tbCodecAudio = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // btnStart
            // 
            this.btnStart.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnStart.Location = new System.Drawing.Point(242, 334);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(75, 23);
            this.btnStart.TabIndex = 0;
            this.btnStart.Text = "Старт";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(5, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(96, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Путь к ffMpeg.exe";
            // 
            // tbffMpegPath
            // 
            this.tbffMpegPath.Location = new System.Drawing.Point(8, 25);
            this.tbffMpegPath.Name = "tbffMpegPath";
            this.tbffMpegPath.Size = new System.Drawing.Size(114, 20);
            this.tbffMpegPath.TabIndex = 4;
            this.tbffMpegPath.Text = "d:\\Install\\converters\\ffmpeg\\bin\\ffmpeg.exe";
            // 
            // tbDirPath
            // 
            this.tbDirPath.Location = new System.Drawing.Point(8, 74);
            this.tbDirPath.Name = "tbDirPath";
            this.tbDirPath.Size = new System.Drawing.Size(114, 20);
            this.tbDirPath.TabIndex = 7;
            this.tbDirPath.Text = "Z:\\Видео\\";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(5, 58);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(117, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Путь к рабочей папке";
            // 
            // tbTemp
            // 
            this.tbTemp.Location = new System.Drawing.Point(8, 113);
            this.tbTemp.Name = "tbTemp";
            this.tbTemp.Size = new System.Drawing.Size(114, 20);
            this.tbTemp.TabIndex = 14;
            this.tbTemp.Text = "D:\\ffmpegTemp";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(5, 97);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(99, 13);
            this.label3.TabIndex = 13;
            this.label3.Text = "Путь к temp папке";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(5, 142);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(44, 13);
            this.label4.TabIndex = 15;
            this.label4.Text = "Статус:";
            // 
            // State
            // 
            this.State.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.State.Location = new System.Drawing.Point(8, 158);
            this.State.Name = "State";
            this.State.Size = new System.Drawing.Size(475, 76);
            this.State.TabIndex = 17;
            this.State.Text = "";
            // 
            // LogBox
            // 
            this.LogBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.LogBox.Location = new System.Drawing.Point(8, 240);
            this.LogBox.Name = "LogBox";
            this.LogBox.Size = new System.Drawing.Size(475, 88);
            this.LogBox.TabIndex = 18;
            this.LogBox.Text = "";
            // 
            // checkedListBox
            // 
            this.checkedListBox.FormattingEnabled = true;
            this.checkedListBox.Location = new System.Drawing.Point(128, 9);
            this.checkedListBox.Name = "checkedListBox";
            this.checkedListBox.Size = new System.Drawing.Size(156, 124);
            this.checkedListBox.TabIndex = 19;
            // 
            // cbSaveBest
            // 
            this.cbSaveBest.AutoSize = true;
            this.cbSaveBest.Location = new System.Drawing.Point(297, 9);
            this.cbSaveBest.Name = "cbSaveBest";
            this.cbSaveBest.Size = new System.Drawing.Size(157, 17);
            this.cbSaveBest.TabIndex = 20;
            this.cbSaveBest.Text = "Оставлять только лучшие";
            this.cbSaveBest.UseVisualStyleBackColor = true;
            // 
            // tbCodecAudio
            // 
            this.tbCodecAudio.Location = new System.Drawing.Point(297, 48);
            this.tbCodecAudio.Name = "tbCodecAudio";
            this.tbCodecAudio.Size = new System.Drawing.Size(114, 20);
            this.tbCodecAudio.TabIndex = 22;
            this.tbCodecAudio.Text = "-acodec copy";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(294, 32);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(76, 13);
            this.label5.TabIndex = 21;
            this.label5.Text = "Аудио кодеки";
            // 
            // checkBox1
            // 
            this.checkBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(323, 340);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(160, 17);
            this.checkBox1.TabIndex = 23;
            this.checkBox1.Text = "Остановить на последнем";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(495, 369);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.tbCodecAudio);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.cbSaveBest);
            this.Controls.Add(this.checkedListBox);
            this.Controls.Add(this.LogBox);
            this.Controls.Add(this.State);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.tbTemp);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tbDirPath);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tbffMpegPath);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnStart);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbffMpegPath;
        private System.Windows.Forms.TextBox tbDirPath;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbTemp;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.RichTextBox State;
        private System.Windows.Forms.RichTextBox LogBox;
        private System.Windows.Forms.CheckedListBox checkedListBox;
        private System.Windows.Forms.CheckBox cbSaveBest;
        private System.Windows.Forms.TextBox tbCodecAudio;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.CheckBox checkBox1;
    }
}

