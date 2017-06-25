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

namespace MyNote
{
    public partial class fmNote : Form
    {
        public string CurrentFile = "";
        public string OldText = "";
        public string CopyString = "";
        public string FindString = "";
        public bool isUpper = false;
        public bool isDown = true;
        public fmFind FmFind = null;

        public fmNote()
        {
            InitializeComponent();
            
            this.mNew.Click += MNew_Click;
            this.mOpen.Click += MOpen_Click;
            this.mSave.Click += MSave_Click;
            this.mSaveAs.Click += MSaveAs_Click;
            this.mExit.Click += MExit_Click;

            this.mCopy.Click += MCopy_Click;
            this.mCut.Click += MCut_Click;
            this.mPaste.Click += MPaste_Click;
            this.mFind.Click += MFind_Click;
            this.mFindNext.Click += MFindNext_Click;
            this.mFind2.Click += MFind2_Click;

            this.tContent.Click += TContent_Click;
            this.tContent.KeyUp += TContent_KeyUp;
            this.tContent.MouseUp += TContent_MouseUp;
            
        }

        private void TContent_MouseUp(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Middle)
            {
                int x = e.X;
                int y = e.Y;
            }

        }

        private void TContent_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Up)
            {

            }
        }

        private void TContent_Click(object sender, EventArgs e)
        {
            this.lCursor.Text = "";
        }

        private void MFind2_Click(object sender, EventArgs e)
        {
            if (this.FmFind == null)
            {
                this.FmFind = new fmFind();
                this.FmFind.isAllowClose = false;
                this.FmFind.FmNote = this;
                this.FmFind.TopMost = true;
            }
            this.FmFind.Show();
        }

        private void MFindNext_Click(object sender, EventArgs e)
        {
            Search();
        }

        private void MFind_Click(object sender, EventArgs e)
        {
            fmFind fm = new fmFind();
            fm.isAllowClose = true;
            if (fm.ShowDialog() == DialogResult.OK)
            {
                this.FindString = fm.FindString;
                this.isUpper = fm.isUpper;
                this.isDown = fm.isDown;
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
            if (this.FindString != "")
            {
                //int start = this.tContent.Text.IndexOf(this.FindString, 3);
                //start = this.tContent.Text.LastIndexOf(this.FindString,7);
                //start = this.tContent.Text.ToUpper().IndexOf(
                //        this.FindString.ToUpper(), 3);
                int start = this.tContent.Text.IndexOf(
                    this.FindString, this.tContent.SelectionStart);
                if (start == this.tContent.SelectionStart
                    && this.FindString == this.tContent.Text.Substring(this.tContent.SelectionStart, this.tContent.SelectionLength))
                {
                    start = this.tContent.Text.IndexOf(
                        this.FindString, this.tContent.SelectionStart+1);
                }
                if (start < 0)
                {
                    MessageBox.Show("没找到！", "Error"
                        , MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    this.tContent.SelectionStart = start;
                    this.tContent.SelectionLength = this.FindString.Length;
                    this.tContent.ScrollToCaret();
                }                
            }
        }

        private void MPaste_Click(object sender, EventArgs e)
        {
            int start = this.tContent.SelectionStart;
            int len = this.tContent.SelectionLength;
            this.tContent.Text =
                this.tContent.Text.Substring(0, start)
                + this.CopyString
                + this.tContent.Text.Substring(start + len);
        }

        private void MCut_Click(object sender, EventArgs e)
        {
            int start = this.tContent.SelectionStart;
            int len = this.tContent.SelectionLength;
            this.CopyString = this.tContent.Text.Substring(start, len);
            this.tContent.Text =
                this.tContent.Text.Substring(0, start)
                + this.tContent.Text.Substring(start + len);
        }

        private void MCopy_Click(object sender, EventArgs e)
        {
            int start = this.tContent.SelectionStart;
            int len = this.tContent.SelectionLength;
            this.CopyString = this.tContent.Text.Substring(start, len);
        }

        private void MNew_Click(object sender, EventArgs e)
        {
            if (this.OldText != this.tContent.Text)
            {
                DialogResult result =
                      MessageBox.Show("是否需要保存？", "提示"
                      , MessageBoxButtons.YesNoCancel
                      , MessageBoxIcon.Information);
                if (result == DialogResult.Yes)
                {
                    this.MSave_Click(null, null);
                }
                else if (result == DialogResult.Cancel)
                {
                    return;
                }
            }
            this.CurrentFile = "";
            this.Text = "MyNote";
            this.tContent.Text = "";
        }

        private void MExit_Click(object sender, EventArgs e)
        {
            this.Close();
            //Application.Exit();
        }

        private void MSaveAs_Click(object sender, EventArgs e)
        {
            SaveFileDialog sfd = new SaveFileDialog();
            sfd.Filter = "*.txt文本文件|*.txt";
            if (sfd.ShowDialog() == DialogResult.OK)
            {
                this.CurrentFile = sfd.FileName;
                this.Text = this.CurrentFile;
                SaveFile(this.CurrentFile);
            }
        }

        private void MSave_Click(object sender, EventArgs e)
        {
            if (this.CurrentFile == "")
            {
                SaveFileDialog sfd = new SaveFileDialog();
                sfd.Filter = "*.txt文本文件|*.txt";
                if (sfd.ShowDialog() == DialogResult.OK)
                {
                    this.CurrentFile = sfd.FileName;
                    this.Text = this.CurrentFile;
                }
            }
            //往currentfile存储内容
            if (this.CurrentFile != "")
            {
                SaveFile(this.CurrentFile);
            }
        }
        
        private void SaveFile(string currentFile)
        {
            StreamWriter sw = new StreamWriter(currentFile);
            sw.Write(this.tContent.Text);
            this.OldText = this.tContent.Text;
            sw.Close();
        }

        private void MOpen_Click(object sender, EventArgs e)
        {
            if (this.OldText != this.tContent.Text)
            {
                DialogResult result =
                      MessageBox.Show("是否需要保存？", "提示"
                      , MessageBoxButtons.YesNoCancel
                      , MessageBoxIcon.Information);
                if (result == DialogResult.Yes)
                {
                    this.MSave_Click(null, null);
                    OpenFileDialog ofd = new OpenFileDialog();
                    ofd.Filter = "*.txt文本文件|*.txt";
                    if (ofd.ShowDialog() == DialogResult.OK)
                    {
                        this.CurrentFile = ofd.FileName;
                        this.Text = this.CurrentFile;
                        StreamReader sr = new StreamReader(this.CurrentFile);
                        this.tContent.Text = sr.ReadToEnd();
                        this.OldText = this.tContent.Text;
                        sr.Close();

                    }
                }
                else if (result == DialogResult.No)
                {
                    OpenFileDialog ofd = new OpenFileDialog();
                    ofd.Filter = "*.txt文本文件|*.txt";
                    if (ofd.ShowDialog() == DialogResult.OK)
                    {
                        this.CurrentFile = ofd.FileName;
                        this.Text = this.CurrentFile;
                        StreamReader sr = new StreamReader(this.CurrentFile);
                        this.tContent.Text = sr.ReadToEnd();
                        this.OldText = this.tContent.Text;
                        sr.Close();

                    }
                }
            }
            else
            {
                OpenFileDialog ofd = new OpenFileDialog();
                ofd.Filter = "*.txt文本文件|*.txt";
                if (ofd.ShowDialog() == DialogResult.OK)
                {
                    this.CurrentFile = ofd.FileName;
                    this.Text = this.CurrentFile;
                    StreamReader sr = new StreamReader(this.CurrentFile);
                    this.tContent.Text = sr.ReadToEnd();
                    this.OldText = this.tContent.Text;
                    sr.Close();

                }
            }
            
        }
        
        
    }
}
