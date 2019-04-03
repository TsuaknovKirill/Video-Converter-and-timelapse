namespace WindowsFormsApp1
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.button_audio = new System.Windows.Forms.Button();
            this.button_Openfile = new System.Windows.Forms.Button();
            this.OpenFileVideo = new System.Windows.Forms.OpenFileDialog();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.button_kadr = new System.Windows.Forms.Button();
            this.mesto = new System.Windows.Forms.Button();
            this.start = new System.Windows.Forms.Button();
            this.tbVideo = new System.Windows.Forms.TextBox();
            this.tboutdir = new System.Windows.Forms.TextBox();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.SuspendLayout();
            // 
            // button_audio
            // 
            this.button_audio.Location = new System.Drawing.Point(28, 147);
            this.button_audio.Name = "button_audio";
            this.button_audio.Size = new System.Drawing.Size(263, 96);
            this.button_audio.TabIndex = 0;
            this.button_audio.Text = "Извлечь аудио";
            this.button_audio.UseVisualStyleBackColor = true;
            this.button_audio.Click += new System.EventHandler(this.button_audio_Click);
            // 
            // button_Openfile
            // 
            this.button_Openfile.Location = new System.Drawing.Point(8, 42);
            this.button_Openfile.Name = "button_Openfile";
            this.button_Openfile.Size = new System.Drawing.Size(297, 59);
            this.button_Openfile.TabIndex = 1;
            this.button_Openfile.Text = "Открыть фаил";
            this.button_Openfile.UseVisualStyleBackColor = true;
            this.button_Openfile.Click += new System.EventHandler(this.button_Openfile_Click);
            // 
            // OpenFileVideo
            // 
            this.OpenFileVideo.FileName = "OpenFileVideo";
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(0, -2);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(324, 303);
            this.tabControl1.TabIndex = 2;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.button_audio);
            this.tabPage1.Controls.Add(this.button_Openfile);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(316, 277);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Video";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.tboutdir);
            this.tabPage2.Controls.Add(this.tbVideo);
            this.tabPage2.Controls.Add(this.start);
            this.tabPage2.Controls.Add(this.mesto);
            this.tabPage2.Controls.Add(this.button_kadr);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(316, 277);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Photo";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // button_kadr
            // 
            this.button_kadr.Location = new System.Drawing.Point(73, 29);
            this.button_kadr.Name = "button_kadr";
            this.button_kadr.Size = new System.Drawing.Size(175, 39);
            this.button_kadr.TabIndex = 0;
            this.button_kadr.Text = "Выбрать файил";
            this.button_kadr.UseVisualStyleBackColor = true;
            this.button_kadr.Click += new System.EventHandler(this.button_kadr_Click_1);
            // 
            // mesto
            // 
            this.mesto.Location = new System.Drawing.Point(73, 100);
            this.mesto.Name = "mesto";
            this.mesto.Size = new System.Drawing.Size(175, 41);
            this.mesto.TabIndex = 1;
            this.mesto.Text = "Указать место";
            this.mesto.UseVisualStyleBackColor = true;
            this.mesto.Click += new System.EventHandler(this.mesto_Click);
            // 
            // start
            // 
            this.start.Location = new System.Drawing.Point(6, 184);
            this.start.Name = "start";
            this.start.Size = new System.Drawing.Size(299, 75);
            this.start.TabIndex = 2;
            this.start.Text = "СТАРТ!";
            this.start.UseVisualStyleBackColor = true;
            this.start.Click += new System.EventHandler(this.start_Click);
            // 
            // tbVideo
            // 
            this.tbVideo.Location = new System.Drawing.Point(6, 74);
            this.tbVideo.Name = "tbVideo";
            this.tbVideo.Size = new System.Drawing.Size(299, 20);
            this.tbVideo.TabIndex = 10;
            this.tbVideo.TextChanged += new System.EventHandler(this.tbVideo_TextChanged);
            // 
            // tboutdir
            // 
            this.tboutdir.Location = new System.Drawing.Point(6, 158);
            this.tboutdir.Name = "tboutdir";
            this.tboutdir.Size = new System.Drawing.Size(299, 20);
            this.tboutdir.TabIndex = 11;
            this.tboutdir.TextChanged += new System.EventHandler(this.tboutdir_TextChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(321, 291);
            this.Controls.Add(this.tabControl1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button_audio;
        private System.Windows.Forms.Button button_Openfile;
        private System.Windows.Forms.OpenFileDialog OpenFileVideo;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Button button_kadr;
        private System.Windows.Forms.Button start;
        private System.Windows.Forms.Button mesto;
        private System.Windows.Forms.TextBox tbVideo;
        private System.Windows.Forms.TextBox tboutdir;
    }
}

