namespace LMT_Flying
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.linkAbout = new System.Windows.Forms.LinkLabel();
            this.labelNumber = new System.Windows.Forms.Label();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.notifyIcon = new System.Windows.Forms.NotifyIcon(this.components);
            this.sliderNumber = new System.Windows.Forms.TrackBar();
            this.btnFile = new Bunifu.Framework.UI.BunifuImageButton();
            this.txbImage = new MetroFramework.Controls.MetroTextBox();
            this.btnStartStop = new MetroFramework.Controls.MetroButton();
            this.metroButton1 = new MetroFramework.Controls.MetroButton();
            this.btnPause = new MetroFramework.Controls.MetroButton();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sliderNumber)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnFile)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(79, 67);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(175, 173);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // linkAbout
            // 
            this.linkAbout.AutoSize = true;
            this.linkAbout.Font = new System.Drawing.Font("Segoe UI Emoji", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkAbout.LinkColor = System.Drawing.Color.Black;
            this.linkAbout.Location = new System.Drawing.Point(129, 523);
            this.linkAbout.Name = "linkAbout";
            this.linkAbout.Size = new System.Drawing.Size(68, 17);
            this.linkAbout.TabIndex = 6;
            this.linkAbout.TabStop = true;
            this.linkAbout.Text = "Về tác giả";
            this.linkAbout.Click += new System.EventHandler(this.linkAbout_Click);
            // 
            // labelNumber
            // 
            this.labelNumber.AutoSize = true;
            this.labelNumber.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNumber.ForeColor = System.Drawing.Color.Black;
            this.labelNumber.Location = new System.Drawing.Point(93, 352);
            this.labelNumber.Name = "labelNumber";
            this.labelNumber.Size = new System.Drawing.Size(0, 20);
            this.labelNumber.TabIndex = 9;
            // 
            // notifyIcon
            // 
            this.notifyIcon.Icon = ((System.Drawing.Icon)(resources.GetObject("notifyIcon.Icon")));
            this.notifyIcon.Text = "LMT Bay Lung Tung";
            this.notifyIcon.Visible = true;
            this.notifyIcon.Click += new System.EventHandler(this.notifyIcon_Click);
            // 
            // sliderNumber
            // 
            this.sliderNumber.Location = new System.Drawing.Point(40, 305);
            this.sliderNumber.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.sliderNumber.Name = "sliderNumber";
            this.sliderNumber.Size = new System.Drawing.Size(255, 45);
            this.sliderNumber.TabIndex = 12;
            this.sliderNumber.ValueChanged += new System.EventHandler(this.sliderNumber_ValueChanged);
            // 
            // btnFile
            // 
            this.btnFile.BackColor = System.Drawing.Color.Transparent;
            this.btnFile.Image = ((System.Drawing.Image)(resources.GetObject("btnFile.Image")));
            this.btnFile.ImageActive = null;
            this.btnFile.Location = new System.Drawing.Point(10, 265);
            this.btnFile.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.btnFile.Name = "btnFile";
            this.btnFile.Size = new System.Drawing.Size(30, 28);
            this.btnFile.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnFile.TabIndex = 8;
            this.btnFile.TabStop = false;
            this.btnFile.Zoom = 10;
            this.btnFile.Click += new System.EventHandler(this.btnFile_Click);
            // 
            // txbImage
            // 
            this.txbImage.FontSize = MetroFramework.MetroTextBoxSize.Medium;
            this.txbImage.Location = new System.Drawing.Point(44, 268);
            this.txbImage.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.txbImage.Name = "txbImage";
            this.txbImage.Size = new System.Drawing.Size(252, 25);
            this.txbImage.TabIndex = 13;
            this.txbImage.UseStyleColors = true;
            // 
            // btnStartStop
            // 
            this.btnStartStop.Location = new System.Drawing.Point(61, 384);
            this.btnStartStop.Name = "btnStartStop";
            this.btnStartStop.Size = new System.Drawing.Size(212, 34);
            this.btnStartStop.TabIndex = 14;
            this.btnStartStop.Text = "Bắt đầu!!!";
            this.btnStartStop.Click += new System.EventHandler(this.btnStartStop_Click);
            // 
            // metroButton1
            // 
            this.metroButton1.Location = new System.Drawing.Point(61, 481);
            this.metroButton1.Name = "metroButton1";
            this.metroButton1.Size = new System.Drawing.Size(212, 34);
            this.metroButton1.TabIndex = 15;
            this.metroButton1.Text = "Ẩn";
            this.metroButton1.Click += new System.EventHandler(this.metroButton1_Click);
            // 
            // btnPause
            // 
            this.btnPause.Location = new System.Drawing.Point(61, 433);
            this.btnPause.Name = "btnPause";
            this.btnPause.Size = new System.Drawing.Size(212, 34);
            this.btnPause.TabIndex = 16;
            this.btnPause.Text = "Tạm dừng";
            this.btnPause.Click += new System.EventHandler(this.btnPause_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(329, 547);
            this.Controls.Add(this.btnPause);
            this.Controls.Add(this.metroButton1);
            this.Controls.Add(this.btnStartStop);
            this.Controls.Add(this.txbImage);
            this.Controls.Add(this.sliderNumber);
            this.Controls.Add(this.labelNumber);
            this.Controls.Add(this.btnFile);
            this.Controls.Add(this.linkAbout);
            this.Controls.Add(this.pictureBox1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Padding = new System.Windows.Forms.Padding(23, 68, 23, 23);
            this.Resizable = false;
            this.Text = "LMT Bay Lung Tung beta 3";
            this.Theme = MetroFramework.MetroThemeStyle.Light;
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sliderNumber)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnFile)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.LinkLabel linkAbout;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label labelNumber;
        private System.Windows.Forms.Timer timer;
        private System.Windows.Forms.NotifyIcon notifyIcon;
        private System.Windows.Forms.TrackBar sliderNumber;
        private Bunifu.Framework.UI.BunifuThinButton2 btnHide;
        private Bunifu.Framework.UI.BunifuImageButton btnFile;
        private MetroFramework.Controls.MetroTextBox txbImage;
        private MetroFramework.Controls.MetroButton metroButton1;
        private MetroFramework.Controls.MetroButton btnStartStop;
        private MetroFramework.Controls.MetroButton btnPause;
    }
}

