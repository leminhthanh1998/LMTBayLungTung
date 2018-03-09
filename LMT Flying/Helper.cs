using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LMT_Flying
{
    public static class Desktop
    {
        public static int GetWidth()
        {
            return Screen.PrimaryScreen.Bounds.Width;
        }
        public static int GetHeight()
        {
            return Screen.PrimaryScreen.Bounds.Height;
        }
    }

    public static class ImageProcess
    {
        public static void Copy(Bitmap target, Bitmap source, int x, int y)
        {
            using (Graphics g = Graphics.FromImage(target))
            { g.DrawImage(source, x, y); }
        }
        public static Bitmap BlankBitmap(int width, int height)
        {
            Bitmap bitmap = new Bitmap(width, height);
            using (Graphics g = Graphics.FromImage(bitmap))
            {
                Rectangle imageSize = new Rectangle(0, 0, width, height);
                g.FillRectangle(Brushes.White, imageSize);
            }
            return bitmap;
        }
    }
    public static class WindowsAPI
    {
        [DllImport("user32.dll")]
        internal static extern int SetWindowLong(IntPtr hWnd, int nIndex, int value);
        [DllImport("user32.dll")]
        internal static extern int GetWindowLong(IntPtr hWnd, int nIndex);
        public static void EnableMouseTransparency(IntPtr hWnd)
        {
            SetWindowLong(hWnd, -20, Convert.ToInt32(GetWindowLong(hWnd, -20) | 0x00080000 | 0x00000020L));
        }
    }
}
