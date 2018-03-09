namespace LMT_Flying
{
    partial class VideoForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(VideoForm));
            this.MediaPlayer1 = new AxWMPLib.AxWindowsMediaPlayer();
            ((System.ComponentModel.ISupportInitialize)(this.MediaPlayer1)).BeginInit();
            this.SuspendLayout();
            // 
            // MediaPlayer1
            // 
            this.MediaPlayer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MediaPlayer1.Enabled = true;
            this.MediaPlayer1.Location = new System.Drawing.Point(0, 0);
            this.MediaPlayer1.Name = "MediaPlayer1";
            this.MediaPlayer1.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("MediaPlayer1.OcxState")));
            this.MediaPlayer1.Size = new System.Drawing.Size(408, 350);
            this.MediaPlayer1.TabIndex = 0;
            // 
            // VideoForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(408, 350);
            this.Controls.Add(this.MediaPlayer1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "VideoForm";
            this.Opacity = 0D;
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.Text = "Video";
            this.TopMost = true;
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.VideoForm_FormClosing);
            this.Load += new System.EventHandler(this.VideoForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.MediaPlayer1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private AxWMPLib.AxWindowsMediaPlayer MediaPlayer1;
    }
}