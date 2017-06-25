using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GPSApp
{
    public partial class fmMain : Form
    {
        private string CurFile = "";
        private Thread T;
        //private delegate void DLog(string log);
        private List<float> Lngs = new List<float>();
        private List<float> Lats = new List<float>();
        private List<float> Speeds = new List<float>();
        private List<DateTime> Dates = new List<DateTime>();
        private List<float> Distances = new List<float>();

        public fmMain()
        {
            InitializeComponent();
            Control.CheckForIllegalCrossThreadCalls = false;
            this.bOpen.Click += BOpen_Click;
            this.FormClosing += FmMain_FormClosing;
            this.bNewWin.Click += BNewWin_Click;
        }

        private void BNewWin_Click(object sender, EventArgs e)
        {
            fmGPSAnalysis fm = new fmGPSAnalysis();
            fm.Show();
        }

        private void FmMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            try { T.Abort(); } catch (Exception) { }
        }

        private void BOpen_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.FileName = "GpsData-000000000";
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                this.Log($"File[{ofd.FileName}] opened !");
                this.CurFile = ofd.FileName;
                this.Lngs.Clear(); this.Lats.Clear(); this.Speeds.Clear();
                this.Dates.Clear(); this.Distances.Clear();
                T = new Thread(new ThreadStart(this.AnaysisGPSFile));
                T.Start();               
            }
        }

        private void AnaysisGPSFile()
        {
            StreamReader sr = new StreamReader(this.CurFile);
            string gpsdata = sr.ReadToEnd();
            string[] gpsdatas = gpsdata.Split(new string[] { "\r\n" }, StringSplitOptions.RemoveEmptyEntries);
            sr.Close();
            int lastpsbvalue = 0;
            //以回车分隔的每一行数据数组：
            //$BDGSV,2,2,06,10,81,030,24,13,60,211,22*65
            //$GNRMC,214756.000,A,3048.8798,N,10410.8829,E,3.51,281.00,131016,,,A * 75
            //$GPPUL,1476424076,200,0,0,9797 * HH
            for (int i = 0; i < gpsdatas.Length; i++)
            {
                if (i > 1000) break;
                //this.Log($"{gpsdatas[i]}");
                int p = (i + 1) * 100 / gpsdatas.Length;
                if (p != lastpsbvalue)
                {
                    this.psb.Value = p;
                    lastpsbvalue = p;
                }

                string[] datas = gpsdatas[i].Split(new string[] { "," }, StringSplitOptions.None);
                //以逗号分隔出来的数组
                //$GNRMC
                //214756.000
                //A
                //3048.8798
                if (datas[0] == "$GNRMC" && datas[2] == "A")
                {
                    if (datas[2] == "A")
                    {
                        //todo:读取GPS数据值
                        //时间、经度、纬度、速度，然后计算距离
                        float lng =
                            (Convert.ToInt32(datas[5].Substring(0, 3))
                            + Convert.ToSingle(datas[5].Substring(3)) / 60)
                            * (datas[6] == "E" ? 1 : -1);
                        this.Lngs.Add(lng);
                        float lat =
                            (Convert.ToInt32(datas[3].Substring(0, 2))
                            + Convert.ToSingle(datas[3].Substring(2)) / 60)
                            * (datas[3] == "N" ? 1 : -1);
                        this.Lats.Add(lat);
                        //"yyyy-MM-dd HH:mm:ss"
                        //"ddMMyyHHmmss"
                        DateTime gpsdate =
                            DateTime.ParseExact(datas[9]
                            + datas[1].Substring(0, datas[1].IndexOf("."))
                            , "ddMMyyHHmmss", null);
                        this.Dates.Add(gpsdate);
                        float speed = Convert.ToSingle(datas[7]) * 1.852F;
                        this.Speeds.Add(speed);
                        float distance = 0;
                        if (i > 0)
                        {
                            float lat0 = this.Lats[this.Lats.Count - 1 - 1];
                            float lng0 = this.Lngs[this.Lngs.Count - 1 - 1];
                            distance = Convert.ToSingle(
                                GetDistance(lat, lng, lat0, lng0));
                        }
                        this.Distances.Add(distance);
                    }
                }                
            }

        }

        //private void _Log(string log)
        //{
        //    this.Invoke(new DLog(Log), new string[] { log });
        //}

        private void Log(string log)
        {
            this.Txt.AppendText($"[{DateTime.Now.ToString("HH:mm:ss")}] {log}\r\n");
            this.Txt.SelectionStart = this.Txt.Text.Length;
            this.Txt.ScrollToCaret();
        }

        private const double EARTH_RADIUS = 6378.137;//地球半径
        private double rad(double d)
        {
            return d * Math.PI / 180.0;
        }

        public double GetDistance(double lat1, double lng1, double lat2, double lng2)
        {
            double radLat1 = rad(lat1);
            double radLat2 = rad(lat2);
            double a = radLat1 - radLat2;
            double b = rad(lng1) - rad(lng2);

            double s = 2 * Math.Asin(Math.Sqrt(Math.Pow(Math.Sin(a / 2), 2) +
             Math.Cos(radLat1) * Math.Cos(radLat2) * Math.Pow(Math.Sin(b / 2), 2)));
            s = s * EARTH_RADIUS;
            s = Math.Round(s * 10000) / 10000;
            return s;
        }
    }
}
