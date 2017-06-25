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
    public partial class fmGPSAnalysis : Form
    {
        private string CurFile = "";
        private Thread T;
        private List<GPSPoint> gpslst = new List<GPSPoint>();

        public fmGPSAnalysis()
        {
            InitializeComponent();
            this.bOpen.Click += BOpen_Click;
            this.FormClosing += FmGPSAnalysis_FormClosing;
        }

        private void FmGPSAnalysis_FormClosing(object sender, FormClosingEventArgs e)
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
                this.gpslst.Clear();
                T = new Thread(new ThreadStart(this.AnaysisGPSFile));
                T.Start();
            }
        }

        private void AnaysisGPSFile()
        {
            StreamReader sr = new StreamReader(this.CurFile);
            string gpsdata = sr.ReadToEnd();            

            gpslst = GPSPoint.Analysis(gpsdata);            

            string excel = "时间,经度,纬度,速度,距离";
            for(int i = 0; i < gpslst.Count; i++)
            {
                excel += $"\r\n{gpslst[i].Date.ToString("yyyy-MM-dd HH:mm:ss")}" +
                    $",{gpslst[i].Lng},{gpslst[i].Lat},{gpslst[i].Speed}" +
                    $",{gpslst[i].Distance}";
            }

            StreamWriter sw = new StreamWriter(
                $"{Application.StartupPath}\\123.csv", false, Encoding.UTF8);            
            sw.Write(excel);
            sw.Close();
        }

        private void Log(string log)
        {
            this.Txt.AppendText($"[{DateTime.Now.ToString("HH:mm:ss")}] {log}\r\n");
            this.Txt.SelectionStart = this.Txt.Text.Length;
            this.Txt.ScrollToCaret();
        }
    }
}
