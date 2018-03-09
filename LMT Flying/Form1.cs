using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Input;
using HtmlAgilityPack;
using MetroFramework;
using YoutubeExtractor;

namespace LMT_Flying
{
    public partial class Form1 : MetroFramework.Forms.MetroForm
    {

        public Form1()
        {
            InitializeComponent();
            
            timer.Tick += Timer_Tick;
            notifyIcon.Visible = false;
            number = sliderNumber.Value;
            sliderNumber.Visible = false;
            workerGetLink.DoWork += WorkerGetLink_DoWork;
            workerGetLink.RunWorkerCompleted += WorkerGetLink_RunWorkerCompleted;
        }
        #region getLink video
        private void WorkerGetLink_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            isVideo = true;
            if (isAlive)
            {
                btnFile.Enabled = false;
                sliderNumber.Visible = true;
                sliderNumber.Value = 1;
                sliderNumber.Maximum = 5;
                sliderNumber.Minimum = 0;
                labelNumber.Text = "Độ mờ video: 10%";
                btnStartStop.Text = "Dừng lại!!!";
                btnStartStop.Enabled = true;
                btnPause.Enabled = true;
                btnPause.Text = "Tạm dừng";
                video.SetOpacity(opacity);
                video.Show();
                video.Play(path);
                checkStart = true;
                isYoutube = false;
            }
            else
            {
                ThongBao tb = new ThongBao();
                tb.TB =
                    "Hiện không thể phát video này!\r\nBạn có thể tải video về và phát lại nó bằng\r\nphần mềm này!";
                tb.ShowDialog();
                btnStartStop.Text = "Bắt đầu!!!";
                btnStartStop.Enabled = true;
            }
        }

        private void WorkerGetLink_DoWork(object sender, DoWorkEventArgs e)
        {
            if (txbImage.Text.Contains("youtube.com") || txbImage.Text.Contains("youtu.be"))
            {
                try
                {

                    #region GetLink youtube
                    IEnumerable<VideoInfo> videoInfos = DownloadUrlResolver.GetDownloadUrls(txbImage.Text);

                    try
                    {
                        VideoInfo video = videoInfos
                            .First(info => info.VideoType == VideoType.Mp4 && info.Resolution == 720);
                        path = video.DownloadUrl;
                    }
                    catch (Exception)
                    {
                        try
                        {
                            VideoInfo video = videoInfos
                                .First(info => info.VideoType == VideoType.Mp4 && info.Resolution == 720);
                            path = video.DownloadUrl;
                        }
                        catch (Exception)
                        {
                            try
                            {
                                VideoInfo video = videoInfos
                                    .First(info => info.VideoType == VideoType.Mp4 && info.Resolution == 480);
                                path = video.DownloadUrl;
                            }
                            catch (Exception)
                            {
                                try
                                {
                                    VideoInfo video = videoInfos
                                        .First(info => info.VideoType == VideoType.Mp4 && info.Resolution == 360);
                                    path = video.DownloadUrl;
                                }
                                catch (Exception)
                                {

                                }
                            }
                        }
                    }

                    #endregion

                }
                catch (Exception)
                {
                    isAlive = false;
                    return;
                }
            }
            else
            {
                
                try
                {
                    HtmlWeb web = new HtmlWeb();
                    HtmlAgilityPack.HtmlDocument doc = web.Load(txbImage.Text);
                    string sr = doc.DocumentNode.OuterHtml;
                    MatchCollection linkdownload = Regex.Matches(sr, "(?i)\\s*hd_src:\".\\s*\\s*(\"([^\"]*\")|'[^']*'|([^'\">]+))");
                    path = linkdownload[0].ToString().Replace("hd_src:\"", "");
                }
                catch (Exception)
                {
                    isAlive = false;
                    return;
                }

            }
            isAlive = CheckLinkAlive(path);

        }
        #endregion

       
        #region Var
        private double number;
        private double opacity=0.1;
        private Point[] locations;
        private Point[] velocities;
        private Bitmap blankBitmap;
        private Bitmap iKuta;
        private Mask mask;
        private string path;
        private bool checkStart = false;
        private bool isVideo = false;
        private bool isYoutube = false;
        private bool isAlive = false;
        BackgroundWorker workerGetLink=new BackgroundWorker();
        VideoForm video=new VideoForm();

        #endregion

        #region Ham hinh anh
        /// <summary>
        /// Ve hinh sau moi 0.1 s
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Timer_Tick(object sender, EventArgs e)
        {
            //mask.TopMost = true;
            MoveMouses();
            DrawMouses();
        }

        private void Run()
        {
            blankBitmap = ImageProcess.BlankBitmap(Desktop.GetWidth(), Desktop.GetHeight());
            mask = new Mask(blankBitmap);
            mask.AllowTransparency = true;
            mask.TransparencyKey = Color.White;
            mask.pictureBox.BackColor = Color.Transparent;
            WindowsAPI.EnableMouseTransparency(mask.Handle);
            iKuta.MakeTransparent(Color.Transparent);
            SpawnMouses();
            InitializeVelocities();
        }

        private void SpawnMouses()
        {
            locations = new Point[(int)number];
            Random r = new Random();
            for (int i = 0; i < number; i++)
            {
                locations[i] = new Point(r.Next(Desktop.GetWidth()), r.Next(Desktop.GetHeight()));
            }
        }

        private void InitializeVelocities()
        {
            velocities = new Point[(int)number];
            Random r = new Random();
            for (int i = 0; i < number; i++)
            {
                int x = r.Next(5, 10);
                int y = r.Next(5, 10);
                if (r.Next(2) == 0)
                    x *= -1;
                if (r.Next(2) == 0)
                    y *= -1;
                velocities[i] = new Point(x, y);
            }
        }

        private void MoveMouses()
        {
            Random r = new Random();
            for (int i = 0; i < locations.Length; i++)
            {
                locations[i].X += velocities[i].X;
                locations[i].Y += velocities[i].Y;
                if (locations[i].X > Desktop.GetWidth() || locations[i].X < 0)
                    locations[i] = new Point(r.Next(Desktop.GetWidth()), r.Next(Desktop.GetHeight()));
                if (locations[i].Y > Desktop.GetHeight() || locations[i].Y < 0)
                    locations[i] = new Point(r.Next(Desktop.GetWidth()), r.Next(Desktop.GetHeight()));

            }
        }

        private void DrawMouses()
        {

            using (var temp = new Bitmap(blankBitmap))
            {
                foreach (Point p in locations)
                {
                    ImageProcess.Copy(temp, iKuta, p.X, p.Y);
                }
                mask.pictureBox.Image = temp;
                mask.pictureBox.Update();
                temp.Dispose();
            }
        }


        #endregion

        

        /// <summary>
        /// Mo file png
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnFile_Click(object sender, EventArgs e)
        {
            OpenFileDialog dlg= new OpenFileDialog();
            dlg.Multiselect = false;
            dlg.Filter = "All files (*.mp4, *.avi, *.png) | *.mp4; *.avi; *.png";
            if (dlg.ShowDialog() == DialogResult.OK)
            {
                sliderNumber.Visible = true;
                sliderNumber.Value = 1;
                path = dlg.FileName;
                txbImage.Text = path;
                if (Path.GetExtension(path).ToLower() != ".png")
                {
                    isVideo = true;
                    sliderNumber.Maximum = 5;
                    sliderNumber.Minimum = 0;
                    labelNumber.Text = "Độ mờ video: 10%";
                }
                else
                {
                    isVideo = false;
                    sliderNumber.Maximum = 10;
                    sliderNumber.Minimum = 1;
                    labelNumber.Text = "Số ảnh sẽ \"bay\": 1";
                }
            }
        }

       
        
        /// <summary>
        /// Link about
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void linkAbout_Click(object sender, EventArgs e)
        {
            Process.Start("https://xn--lminhthnh-w1a7h.vn/");
        }
        /// <summary>
        /// Link copy
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>

        private void sliderNumber_ValueChanged(object sender, EventArgs e)
        {
            if (!isVideo)
            {
                labelNumber.Text = "Số ảnh sẽ \"bay\": " + sliderNumber.Value;
                number = sliderNumber.Value;
            }
            else
            {
                labelNumber.Text = "Độ mờ video: " + (double)sliderNumber.Value * 10 + " %";
                opacity = (double)sliderNumber.Value / 10;
                video.SetOpacity(opacity);
            }
        }

        /// <summary>
        /// Click notifyicon de hien lai giao dien
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void notifyIcon_Click(object sender, EventArgs e)
        {
            Show();
        }

       

        private bool CheckLinkAlive(string url)
        {
            Uri urlCheck = new Uri(url);
            HttpWebRequest request = (HttpWebRequest)WebRequest.Create(urlCheck);
            request.Timeout = 15000;
            HttpWebResponse response;
            try
            {
                response = (HttpWebResponse)request.GetResponse();
                response.Close();
                return true;
            }
            catch (Exception)
            {
                return false; 
            }
        }

        
        private void Form1_Load(object sender, EventArgs e)
        {
            btnPause.Enabled = false;
        }

        private void btnStartStop_Click(object sender, EventArgs e)
        {
            if (!checkStart)
            {
                if (!string.IsNullOrEmpty(txbImage.Text))
                {
                    if (txbImage.Text.Contains("youtube.com") || txbImage.Text.Contains("youtu.be") ||
                        txbImage.Text.Contains("facebook.com"))
                    {
                        btnStartStop.Enabled = false;
                        btnStartStop.Text = "Loading";
                        workerGetLink.RunWorkerAsync();
                        isVideo = true;
                        isYoutube = true;
                    }
                    if (!isVideo && !string.IsNullOrEmpty(path))
                    {
                        btnStartStop.Text = "Dừng lại!!!";
                        iKuta = new Bitmap(path);
                        if (iKuta.Height > 300)
                        {
                            ThongBao tb = new ThongBao();
                            tb.TB =
                                "Vì bạn tác giả cho rằng ảnh có chiều cao \r\nnhỏ hơn 300px bay mới đẹp nên bạn không\r\nthể chọn ảnh có chiều cao lớn hơn!\r\nNếu muốn có thể chọn ảnh to hơn thì\r\nbạn có thể click vào \"Góp ý\" để đóng\r\ngóp ý kiến!";
                            tb.ShowDialog();
                            return;
                        }
                        btnFile.Enabled = false;
                        Run();
                        timer.Start();
                        checkStart = true;
                        sliderNumber.Enabled = false;
                    }
                    else if (isVideo == true && isYoutube == false)
                    {
                        btnFile.Enabled = false;
                        btnStartStop.Text = "Dừng lại!!!";
                        btnPause.Enabled = true;
                        btnPause.Text = "Tạm dừng";
                        video.SetOpacity(opacity);
                        video.Show();
                        video.Play(path);
                        checkStart = true;
                    }
                }
                else
                {
                    ThongBao t = new ThongBao();
                    t.TB = "Bạn chưa chọn hình ảnh hoặc video";
                    t.ShowDialog();
                }
            }
            else
            {
                sliderNumber.Enabled = true;
                btnFile.Enabled = true;
                if (!isVideo)
                {
                    timer.Stop();
                    timer.Enabled = false;
                    notifyIcon.Visible = false;
                    btnStartStop.Text = "Bắt đầu!!!";
                    mask.Dispose();
                    iKuta.Dispose();
                    checkStart = false;
                }
                else
                {
                    video.Stop();
                    video.Close();
                    btnStartStop.Text = "Bắt đầu!!!";
                    checkStart = false;
                    btnPause.Enabled = false;
                }
            }
        }

        /// <summary>
        /// Click cai la an
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void metroButton1_Click(object sender, EventArgs e)
        {
            Hide();
            notifyIcon.Visible = true;
            notifyIcon.ShowBalloonTip(1100, "Thông báo!",
                "Để hiển thị lại giao diện hãy click vào biểu tượng của công cụ bên dưới khay hệ thống!",
                ToolTipIcon.Info);
        }

        
        private void btnPause_Click(object sender, EventArgs e)
        {
            video.Pause(opacity);
            if (btnPause.Text == "Tiếp tục")
                btnPause.Text = "Tạm dừng";
            else btnPause.Text = "Tiếp tục";
        }
    }
}
