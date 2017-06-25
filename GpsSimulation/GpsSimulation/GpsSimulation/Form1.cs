using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO.Ports;
using System.IO;
using System.Collections;

namespace GpsSimulation
{
    public partial class Form1 : Form
    {

        private SerialPort cSerial;

        private Timer frequencyTimer;

        /// <summary>
        /// 保存预录的GPS模拟数据
        /// </summary>
        private Queue<String> GPSContent = new Queue<String>();

        public Form1()
        {
            InitializeComponent();

            frequencyTimer = new Timer();
            frequencyTimer.Enabled = false;
            frequencyTimer.Interval = 5000;//默认计时器5秒一次循环
            frequencyTimer.Tick += new EventHandler(frequencyTimer_Tick);

            MsgShow.Text += "操作步骤：选择加载的GPS模拟数据文件，待加载成功后，打开串口，设定传输频率，点击开始，GO.....\r\n";

        }

        /// <summary>
        /// 打开串口
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void OpenSerialBtn_Click(object sender, EventArgs e)
        {
            try
            {
                if (this.cbSerialSelect.SelectedItem == null)
                {
                    this.MsgShow.Text += "*************请先选择串口*************\r\n";
                    return;
                }

                if (cSerial == null)
                {
                    cSerial = new SerialPort(this.cbSerialSelect.SelectedItem.ToString(), 4800, System.IO.Ports.Parity.None, 8, StopBits.One);
                    cSerial.DtrEnable = false;
                    cSerial.RtsEnable = false;
                    cSerial.Open();
                    cSerial.ReadTimeout = 100;
                }
                else if (!cSerial.IsOpen)
                {
                    cSerial.Close();
                    cSerial = new SerialPort(this.cbSerialSelect.SelectedItem.ToString(), 4800, System.IO.Ports.Parity.None, 8, StopBits.One);
                    cSerial.DtrEnable = false;
                    cSerial.RtsEnable = false;
                    cSerial.Open();
                    cSerial.ReadTimeout = 100;
                }

                this.MsgShow.Text += "打开串口成功\r\n";
            }
            catch (Exception ex)//(System.IO.IOException ex)
            {
                this.MsgShow.Text += "*************打开串口失败*************\r\n";
                cSerial.Close();
                cSerial.Dispose();
                cSerial = null;
            }
        }

        /// <summary>
        /// 修改发送频率
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Modifyfrebtn_Click(object sender, EventArgs e)
        {
            bool isOpenSuccess = true;
            if (this.frequencyTimer.Enabled == true)
            {
                frequencyTimer.Enabled = false;
            }
            try
            {
                frequencyTimer.Interval = Convert.ToInt32(this.tbFrequency.Text);
            }
            catch (Exception ex)
            {
                MsgShow.Text += "*************修改失败，请重新设置**************";
                MsgShow.Text += "\r\n";
                isOpenSuccess = false;
            }

            if (isOpenSuccess)
            {
                MsgShow.Text += "修改成功，频率为： " + frequencyTimer.Interval * 1f / 1000 + "秒";
                MsgShow.Text += "\r\n";
            }
        }

        private void beginbtn_Click(object sender, EventArgs e)
        {
            if (this.cSerial != null)
            {
                if (this.frequencyTimer.Enabled == false)
                {
                    frequencyTimer.Enabled = true;
                }
            }
            else
            {
                MsgShow.Text += "*************启动失败，请先打开串口**************";
                MsgShow.Text += "\r\n";
            }
        }

        private void stopbtn_Click(object sender, EventArgs e)
        {
            if (this.frequencyTimer.Enabled == true)
            {
                frequencyTimer.Enabled = false;
            }
        }

        private void loadbtn_Click(object sender, EventArgs e)
        {
            readGpsDoc();
        }

        /// <summary>
        /// //发送数据
        /// </summary>
        private bool Senddata(String str)
        {
            if (cSerial != null)
            {
                //byte[] bytes = Encoding.Unicode.GetBytes(str);
                //cSerial.Write(bytes, 0, bytes.Length);
                String trmp = str + "\r\n";
                cSerial.Write(trmp);
                if (MsgShow.Text.Length > 2000)
                {
                    MsgShow.Clear();
                }
                MsgShow.AppendText(trmp);
                return true;
            }
            else
            {
                MsgShow.Text += "请先打开串口";
                MsgShow.Text += "\r\n";
                if (this.frequencyTimer.Enabled == true)
                {
                    this.frequencyTimer.Enabled = false;
                }
                return false;
            }
        }

        private void frequencyTimer_Tick(object sender, EventArgs e)
        {
            if (this.GPSContent != null && GPSContent.Count != 0)
            {
                Senddata(GPSContent.Dequeue());
            }
            else
            {
                MsgShow.Text += "数据已发完(或未加载)..";
                MsgShow.Text += "\r\n";
                this.frequencyTimer.Enabled = false;
            }

        }

        /// <summary>
        /// GPS模拟数据读取到内存中
        /// </summary>
        private void readGpsDoc()
        {
            OpenFileDialog dlg = new OpenFileDialog();
            dlg.Title = "Open GPS data file";
            //dlg.InitialDirectory  = @"C:\";
            dlg.Filter = "txt files(*.txt)|*.txt|All files(*.*)|*.*";
            if (dlg.ShowDialog() == DialogResult.OK)
            {
                MsgShow.Text += "加载中....";
                MsgShow.Text += "\r\n";

                if (GPSContent != null && GPSContent.Count != 0)
                {
                    GPSContent.Clear();
                }
                FileStream fs = new FileStream(dlg.FileName, FileMode.Open, FileAccess.Read);
                StreamReader sr = new StreamReader(fs, Encoding.Default);
                string str;
                while ((str = sr.ReadLine()) != null)
                {
                    if (str != "")
                    {
                        GPSContent.Enqueue(str);
                    }
                }
                fs.Close();
                sr.Close();
                MsgShow.Text += "GPS数据载入成功";
                MsgShow.Text += "\r\n";

            }

        }

        private void MsgShow_TextChanged(object sender, EventArgs e)
        {
            //MsgShow.SelectionStart = MsgShow.Text.Length;
            //MsgShow.ScrollToCaret();
        }
    }
}
