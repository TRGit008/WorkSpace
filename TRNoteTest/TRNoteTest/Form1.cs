using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TRNoteTest

{

    public partial class Form1 : Form
    {
        //查找需要的变量
        public string FindString = "";
        public bool isUpper = false;
        public bool isDown = true;
        public FindWord FmFind = null;


        string filepath = "";//文件路径
        bool save = false;//当前文件保存状态
        public Form1()
        {
            InitializeComponent();
            this.MFind.Click += MFind_Click;
            this.TMToolShow.Click += TMToolShow_Click;
            Console.WriteLine("正在启动程序");
           
        }

        private void TMToolShow_Click(object sender, EventArgs e)
        {
            // throw new NotImplementedException();
            if (toolStrip1.Visible == true&&toolStrip2.Visible==true&&toolStrip3.Visible==true)
            {
                toolStrip1.Visible = false;
                toolStrip2.Visible = false;
                toolStrip3.Visible = false;
                TMToolShow.Checked = false;
            }
            else
            {
                toolStrip1.Visible = true;
                toolStrip2.Visible = true;
                toolStrip3.Visible = true;
                TMToolShow.Checked = true;
            }

        }

        private void MFind_Click(object sender, EventArgs e)
        {
            //throw new NotImplementedException();
            
                FindWord fm = new FindWord();
                fm.isAllowClose = true;
                if (fm.ShowDialog() == DialogResult.OK)
                {
                    this.FindString = fm.FindString;
                    this.isUpper = fm.isUpper;
                    this.isDown = fm.isDown;
                Console.WriteLine("正在调用启动的方法");
                    Search();
                }
            
        }

        internal void Search(string findString, bool isUpper, bool isDown)
        {
            this.FindString = findString;
            this.isUpper = isUpper;
            this.isDown = isDown;
            this.Search();
        }
        
        public void Search()
        {
            if (FindString != null) {
               // string start = richTextBox1.Text;//获取编写面板里面的string
                //int cartIndex = this.richTextBox1.SelectionStart;//取得光标位置
                int start = this.richTextBox1.Text.IndexOf(
                    this.FindString, this.richTextBox1.SelectionStart);//save 第一个查询到的值

                if (start == this.richTextBox1.SelectionStart
                    && this.FindString == this.richTextBox1.Text.Substring(this.richTextBox1.SelectionStart, this.richTextBox1.SelectionLength))
                {
                    start = this.richTextBox1.Text.IndexOf(
                        this.FindString, this.richTextBox1.SelectionStart + 1);
                }
                Console.WriteLine("正在查找判断");

                if (start < 0)
                {
                    MessageBox.Show("没找到！", "Error"
                        , MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    this.richTextBox1.SelectionStart = start;
                    this.richTextBox1.SelectionLength = this.FindString.Length;
                    this.richTextBox1.ScrollToCaret();
                }
    }

}

        private void 退出XToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
        //新建文本
        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            if (save == false)//未保存
            {
                if (richTextBox1.Text != "")//文件里面已写了内容
                {
                    if (MessageBox.Show("有未保存的内容，是否保存？", "警告", MessageBoxButtons.OKCancel) == DialogResult.OK)
                    {
                        SaveFile();
                    }
                
                            }
            }
            //所有东西全部置为初始值
            richTextBox1.Text = "";
            this.Text = "TR记事本";
            save = true;
            filepath = "";
        }
        //打开一个记事本OpenSaveDialog
        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            if(openFileDialog1.ShowDialog()==DialogResult.OK)
            {
                filepath = openFileDialog1.FileName;//记录打开的文件名
                StreamReader sr = new StreamReader(filepath,Encoding.Default);
                richTextBox1.Text = sr.ReadToEnd();//字符写进文本框并关闭字节流
                sr.Close();

                this.Text = "TR记事本"+filepath;//窗体标题
                save = true;
            }
        }
        //保存文本SaveFileDialog
        private void toolStripButton3_Click(object sender, EventArgs e)
        {
            SaveFile();
            //if (filepath == "")//未保存过的文档
            //{
            //    if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            //    {
            //        filepath = saveFileDialog1.FileName;

            //        StreamWriter sw = new StreamWriter(filepath,false,Encoding.Default);
            //        sw.WriteLine(richTextBox1.Text);//从文本框得到内容
            //        sw.Flush();
            //        sw.Close();

            //        save = true;
            //        this.Text = "TR记事本" + filepath;//窗体标题

            //    }
            //}
            //else//之前保存过的文档
            //{
            //    StreamWriter sw = new StreamWriter(filepath, false, Encoding.Default);
            //    sw.WriteLine(richTextBox1.Text);//从文本框得到内容
            //    sw.Flush();
            //    sw.Close();

            //    save = true;
            //}
        }
        //保存文档
        private bool SaveFile()
        {
            if (filepath == "")//未保存过的文档
            {
                if (saveFileDialog1.ShowDialog() == DialogResult.OK)
                {
                    filepath = saveFileDialog1.FileName;

                    StreamWriter sw = new StreamWriter(filepath, false, Encoding.Default);
                    sw.WriteLine(richTextBox1.Text);//从文本框得到内容
                    sw.Flush();
                    sw.Close();

                    save = true;
                    this.Text = "TR记事本" + filepath;//窗体标题
                    return true;//保存成功

                }
                else
                {
                    return false;
                }
            }
            else//之前保存过的文档
            {
                StreamWriter sw = new StreamWriter(filepath, false, Encoding.Default);
                sw.WriteLine(richTextBox1.Text);//从文本框得到内容
                sw.Flush();
                sw.Close();

                save = true;
                return true;//保存成功
            }
        }
        //另存为
        private void 另存为AToolStripMenuItem_Click(object sender, EventArgs e)
        {
            filepath = "";//值为空之后，则变成未保存过的文档，就会另存为
            SaveFile();
        }
        //剪切
        private void toolStripButton4_Click(object sender, EventArgs e)
        {
            richTextBox1.Cut();
            save = false;
        }
        //复制
        private void toolStripButton5_Click(object sender, EventArgs e)
        {
            richTextBox1.Copy();
        }
        //粘贴
        private void toolStripButton6_Click(object sender, EventArgs e)
        {
            richTextBox1.Paste();
            save = false;
        }
        //全选
        private void 全选AToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.SelectAll();
        }
        //字体设置
        private void 字体设置ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fontDialog1.Font = richTextBox1.Font;
            fontDialog1.Color = richTextBox1.ForeColor;

            if (fontDialog1.ShowDialog() == DialogResult.OK)
            {
                richTextBox1.Font = fontDialog1.Font;
                richTextBox1.ForeColor = fontDialog1.Color;
            }
            save = false;
        }

        //自动换行
        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            if (richTextBox1.WordWrap == false)
            {
                richTextBox1.WordWrap = true;
                toolStripMenuItem1.Checked = true;
            }
            else
            { richTextBox1.WordWrap = false;
                toolStripMenuItem1.Checked = false;
            }
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {
            tsslb_num.Text = richTextBox1.Text.Length.ToString();
            save = false;
               
        }
        //帮助
        private void 在线帮助ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("http://www.baidu.com");
        }
        //退出
        private void 退出XToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            if (save == false)

            {
                if (MessageBox.Show("内容不为空，且未保存过，是否保存？", "警告", MessageBoxButtons.OKCancel) == DialogResult.OK)
                {
                    if(SaveFile())
                        Application.Exit();
                }
            }
            else
            {
                Application.Exit();
    }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.toolStripStatusLabel3.Text = "系统当前时间：" + DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");

            this.timer1.Interval = 1000;

            this.timer1.Start();
        }
        //点击大叉关闭时判断
        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (save == false)//内容发生改变
            {
                if (richTextBox1.Text != "")
                {
                    string msg = "当前文本不为空，是否保存？";

                    if (save == false && filepath != "")
                    {
                        msg = "内容已经变化，是否保存";
                    }
                    switch (MessageBox.Show(msg, "警告", MessageBoxButtons.YesNoCancel))
                    {
                        case DialogResult.Yes:
                            if (SaveFile())
                            {
                                Application.Exit();
                            }
                            break;
                        case DialogResult.No:
                            e.Cancel = false;
                            break;
                        case DialogResult.Cancel:
                            e.Cancel = true;
                            break;

                    }
                }
            }
        }

        private void toolStripTextBox1_Click(object sender, EventArgs e)
        {

        }
        //查找实现
        private void toolStripButton8_Click(object sender, EventArgs e)
        {
            richTextBox1.Find(tb_key.Text.Trim(), 0, RichTextBoxFinds.MatchCase);
        }
        //关于
        private void 关于ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AboutBox1 ab = new AboutBox1();
            //ab.Text = "温馨提示：/n1：想用工具栏时可在“查看”中打开！/n2：想关闭状态栏时也可在“查看”中关闭";
            ab.Show();
        }

        private void toolStripContainer1_TopToolStripPanel_Click(object sender, EventArgs e)
        {

        }

        /*private void toolStripStatusLabel3_Click(object sender, EventArgs e)
        {
            this.toolStripStatusLabel3.Text = "登录时间：" + DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");

        }*/

        private void timer1_Tick(object sender, EventArgs e)
        {
            this.toolStripStatusLabel3.Text = "系统当前时间：" + DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");
        }

        private void 查看VToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
        
        private void toolStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void toolStrip2_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void 状态栏ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (toolStrip1.Visible == true&&toolStrip2.Visible==true&&toolStrip3.Visible==true)
            {
                toolStrip1.Visible = false;
                toolStrip2.Visible = false;
                toolStrip3.Visible = false;
                状态栏ToolStripMenuItem.Checked = false;

            }
            else
            {
                toolStrip1.Visible = true;
                toolStrip2.Visible = true;
                toolStrip3.Visible = true;
                状态栏ToolStripMenuItem.Checked = true;
            }
        }
    }
}
