using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LMT_Flying
{
    public partial class Mask : Form
    {
        bool mouseDown = false;
        Point clickPoint = new Point(0, 0);
        bool movementEnabled = true;
        public Mask()
        {
            InitializeComponent();
        }

        public Mask(Bitmap bmp)
        {
            InitializeComponent();
            OverlayWindow(bmp);
        }
        public void OverlayWindow(Bitmap bmp)
        {
            Show();
            Location = new Point(0, 0);
            Size = Screen.PrimaryScreen.Bounds.Size;
            TopMost = true;
            pictureBox.Image = bmp;
            Refresh();
        }

        private void pictureBox_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right) Application.Exit();
        }

        private void pictureBox_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                mouseDown = true;
                clickPoint = new Point(Location.X - Cursor.Position.X, Location.Y - Cursor.Position.Y);
            }
        }

        private void pictureBox_MouseMove(object sender, MouseEventArgs e)
        {
            if (mouseDown && movementEnabled)
            {
                Location = new Point(Cursor.Position.X + clickPoint.X, Cursor.Position.Y + clickPoint.Y);
            }
        }

        private void pictureBox_MouseUp(object sender, MouseEventArgs e)
        {
            mouseDown = false;
        }
    }
}
