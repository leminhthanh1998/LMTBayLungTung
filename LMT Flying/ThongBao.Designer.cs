namespace LMT_Flying
{
    partial class ThongBao
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ThongBao));
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.labelThongBao = new System.Windows.Forms.Label();
            this.btnOK = new Bunifu.Framework.UI.BunifuThinButton2();
            this.bunifuDragControl1 = new Bunifu.Framework.UI.BunifuDragControl(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 5;
            this.bunifuElipse1.TargetControl = this;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(3, 5);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(185, 198);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Emoji", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(239, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(130, 28);
            this.label1.TabIndex = 1;
            this.label1.Text = "Thông báo!!!";
            // 
            // labelThongBao
            // 
            this.labelThongBao.AutoSize = true;
            this.labelThongBao.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelThongBao.Location = new System.Drawing.Point(180, 39);
            this.labelThongBao.Name = "labelThongBao";
            this.labelThongBao.Size = new System.Drawing.Size(280, 114);
            this.labelThongBao.TabIndex = 2;
            this.labelThongBao.Text = resources.GetString("labelThongBao.Text");
            // 
            // btnOK
            // 
            this.btnOK.ActiveBorderThickness = 1;
            this.btnOK.ActiveCornerRadius = 20;
            this.btnOK.ActiveFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(120)))), ((int)(((byte)(215)))));
            this.btnOK.ActiveForecolor = System.Drawing.Color.White;
            this.btnOK.ActiveLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(120)))), ((int)(((byte)(215)))));
            this.btnOK.BackColor = System.Drawing.Color.Gainsboro;
            this.btnOK.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnOK.BackgroundImage")));
            this.btnOK.ButtonText = "Ok";
            this.btnOK.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnOK.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOK.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(120)))), ((int)(((byte)(215)))));
            this.btnOK.IdleBorderThickness = 1;
            this.btnOK.IdleCornerRadius = 20;
            this.btnOK.IdleFillColor = System.Drawing.Color.Empty;
            this.btnOK.IdleForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(120)))), ((int)(((byte)(215)))));
            this.btnOK.IdleLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(120)))), ((int)(((byte)(215)))));
            this.btnOK.Location = new System.Drawing.Point(236, 158);
            this.btnOK.Margin = new System.Windows.Forms.Padding(5);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(128, 41);
            this.btnOK.TabIndex = 3;
            this.btnOK.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // bunifuDragControl1
            // 
            this.bunifuDragControl1.Fixed = true;
            this.bunifuDragControl1.Horizontal = true;
            this.bunifuDragControl1.TargetControl = this;
            this.bunifuDragControl1.Vertical = true;
            // 
            // ThongBao
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gainsboro;
            this.ClientSize = new System.Drawing.Size(458, 207);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.labelThongBao);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ThongBao";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Thông báo";
            this.Load += new System.EventHandler(this.ThongBao_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label labelThongBao;
        private System.Windows.Forms.Label label1;
        private Bunifu.Framework.UI.BunifuThinButton2 btnOK;
        private Bunifu.Framework.UI.BunifuDragControl bunifuDragControl1;
    }
}