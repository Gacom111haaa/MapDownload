namespace MapDownloader
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
            this.components = new System.ComponentModel.Container();
            this.textBox_url = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox_lat_min = new System.Windows.Forms.TextBox();
            this.textBox_lat_max = new System.Windows.Forms.TextBox();
            this.textBox_lon_min = new System.Windows.Forms.TextBox();
            this.textBox_lon_max = new System.Windows.Forms.TextBox();
            this.textBox_path = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.textBoxZoom = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.checkBoxoverWrite = new System.Windows.Forms.CheckBox();
            this.checkBox_localComputer = new System.Windows.Forms.CheckBox();
            this.textBox_threads = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // textBox_url
            // 
            this.textBox_url.Location = new System.Drawing.Point(76, 15);
            this.textBox_url.Name = "textBox_url";
            this.textBox_url.Size = new System.Drawing.Size(260, 20);
            this.textBox_url.TabIndex = 0;
            this.textBox_url.Text = "https://b.tile.thunderforest.com/cycle/<z>/<x>/<y>.png";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(38, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(32, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "URL:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(31, 74);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Lat range:";
            this.label2.Click += new System.EventHandler(this.label1_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(31, 106);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 13);
            this.label3.TabIndex = 1;
            this.label3.Text = "Lon range:";
            this.label3.Click += new System.EventHandler(this.label1_Click);
            // 
            // textBox_lat_min
            // 
            this.textBox_lat_min.Location = new System.Drawing.Point(92, 71);
            this.textBox_lat_min.Name = "textBox_lat_min";
            this.textBox_lat_min.Size = new System.Drawing.Size(62, 20);
            this.textBox_lat_min.TabIndex = 0;
            this.textBox_lat_min.Text = "7.5";
            // 
            // textBox_lat_max
            // 
            this.textBox_lat_max.Location = new System.Drawing.Point(171, 71);
            this.textBox_lat_max.Name = "textBox_lat_max";
            this.textBox_lat_max.Size = new System.Drawing.Size(62, 20);
            this.textBox_lat_max.TabIndex = 0;
            this.textBox_lat_max.Text = "23.3";
            // 
            // textBox_lon_min
            // 
            this.textBox_lon_min.Location = new System.Drawing.Point(92, 103);
            this.textBox_lon_min.Name = "textBox_lon_min";
            this.textBox_lon_min.Size = new System.Drawing.Size(62, 20);
            this.textBox_lon_min.TabIndex = 0;
            this.textBox_lon_min.Text = "101";
            // 
            // textBox_lon_max
            // 
            this.textBox_lon_max.Location = new System.Drawing.Point(171, 103);
            this.textBox_lon_max.Name = "textBox_lon_max";
            this.textBox_lon_max.Size = new System.Drawing.Size(62, 20);
            this.textBox_lon_max.TabIndex = 0;
            this.textBox_lon_max.Text = "115";
            // 
            // textBox_path
            // 
            this.textBox_path.Location = new System.Drawing.Point(76, 170);
            this.textBox_path.Name = "textBox_path";
            this.textBox_path.Size = new System.Drawing.Size(260, 20);
            this.textBox_path.TabIndex = 0;
            this.textBox_path.Text = "D:\\DOWN\\MapData\\OpenStreetMap\\<z>\\<x>\\<y>.png";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(25, 173);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(47, 13);
            this.label4.TabIndex = 1;
            this.label4.Text = "Save to:";
            this.label4.Click += new System.EventHandler(this.label1_Click);
            // 
            // textBoxZoom
            // 
            this.textBoxZoom.Location = new System.Drawing.Point(92, 129);
            this.textBoxZoom.Name = "textBoxZoom";
            this.textBoxZoom.Size = new System.Drawing.Size(62, 20);
            this.textBoxZoom.TabIndex = 0;
            this.textBoxZoom.Text = "10";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(38, 132);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(34, 13);
            this.label5.TabIndex = 1;
            this.label5.Text = "Zoom";
            this.label5.Click += new System.EventHandler(this.label1_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(239, 71);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(97, 52);
            this.button1.TabIndex = 2;
            this.button1.Text = "Download";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(28, 236);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(325, 76);
            this.richTextBox1.TabIndex = 3;
            this.richTextBox1.Text = "https://b.tile.thunderforest.com/cycle/<z>/<x>/<y>.png\nhttp://tile.openstreetmap." +
    "org/<z>/<x>/<y>.png\nC:\\Downloads\\newtask\\gs_<x>_<y>_<z>.jpg\n";
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(171, 129);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(165, 23);
            this.progressBar1.TabIndex = 4;
            this.progressBar1.Click += new System.EventHandler(this.progressBar1_Click);
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 200;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // checkBoxoverWrite
            // 
            this.checkBoxoverWrite.AutoSize = true;
            this.checkBoxoverWrite.Location = new System.Drawing.Point(76, 196);
            this.checkBoxoverWrite.Name = "checkBoxoverWrite";
            this.checkBoxoverWrite.Size = new System.Drawing.Size(130, 17);
            this.checkBoxoverWrite.TabIndex = 5;
            this.checkBoxoverWrite.Text = "Overwrite existing files";
            this.checkBoxoverWrite.UseVisualStyleBackColor = true;
            // 
            // checkBox_localComputer
            // 
            this.checkBox_localComputer.AutoSize = true;
            this.checkBox_localComputer.Location = new System.Drawing.Point(76, 41);
            this.checkBox_localComputer.Name = "checkBox_localComputer";
            this.checkBox_localComputer.Size = new System.Drawing.Size(99, 17);
            this.checkBox_localComputer.TabIndex = 5;
            this.checkBox_localComputer.Text = "Local computer";
            this.checkBox_localComputer.UseVisualStyleBackColor = true;
            this.checkBox_localComputer.CheckedChanged += new System.EventHandler(this.checkBox_localComputer_CheckedChanged);
            // 
            // textBox_threads
            // 
            this.textBox_threads.Location = new System.Drawing.Point(239, 41);
            this.textBox_threads.Name = "textBox_threads";
            this.textBox_threads.Size = new System.Drawing.Size(62, 20);
            this.textBox_threads.TabIndex = 0;
            this.textBox_threads.Text = "0";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(380, 339);
            this.Controls.Add(this.checkBox_localComputer);
            this.Controls.Add(this.checkBoxoverWrite);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox_lat_max);
            this.Controls.Add(this.textBox_lon_max);
            this.Controls.Add(this.textBox_threads);
            this.Controls.Add(this.textBoxZoom);
            this.Controls.Add(this.textBox_lon_min);
            this.Controls.Add(this.textBox_lat_min);
            this.Controls.Add(this.textBox_path);
            this.Controls.Add(this.textBox_url);
            this.Name = "Form1";
            this.Text = "Map downloader";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox_url;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox_lat_min;
        private System.Windows.Forms.TextBox textBox_lat_max;
        private System.Windows.Forms.TextBox textBox_lon_min;
        private System.Windows.Forms.TextBox textBox_lon_max;
        private System.Windows.Forms.TextBox textBox_path;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBoxZoom;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.CheckBox checkBoxoverWrite;
        private System.Windows.Forms.CheckBox checkBox_localComputer;
        private System.Windows.Forms.TextBox textBox_threads;

    }
}

