using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LMT_Flying
{
    public partial class VideoForm : Form
    {
        public VideoForm()
        {
            InitializeComponent();
        }
        [DllImport("user32.dll", SetLastError = true)]
        static extern int GetWindowLong(IntPtr hWnd, int nIndex);
        [DllImport("user32.dll", SetLastError = true)]
        static extern int SetWindowLong(IntPtr hWnd, int nIndex, int dwNewLong);

        private const int GWL_EXSTYLE = -20;
        private const int WS_EX_TRANSPARENT = 0x20;
        private bool isPause = false;

        private void VideoForm_Load(object sender, EventArgs e)
        {
            int exstyle = GetWindowLong(this.Handle, GWL_EXSTYLE);
            exstyle |= WS_EX_TRANSPARENT;
            SetWindowLong(this.Handle, GWL_EXSTYLE, exstyle);
            MediaPlayer1.uiMode = "none";
            MediaPlayer1.settings.volume = 200;
            MediaPlayer1.stretchToFit = true;
            MediaPlayer1.settings.playCount = 999;
        }

        public void SetOpacity(double a)
        {
            Opacity = a;
        }

        public void Play(string path)
        {
            MediaPlayer1.URL = path;
        }

        public void Stop()
        {
            MediaPlayer1.URL = "";
        }

        private void VideoForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            Hide();
            e.Cancel = true;
        }

        public void Pause(double _opacity)
        {
            WMPLib.IWMPControls3 controls = (WMPLib.IWMPControls3)MediaPlayer1.Ctlcontrols;

            if (controls.get_isAvailable("pause"))
            {
                controls.pause();
                isPause = true;
            }
            else
            {
                if (isPause)
                {
                    isPause = false;
                    this.Opacity = _opacity;
                    controls.play();
                }
            }

            controls = null;
        }
    }
}
