using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TRNoteTest
{
    public partial class FindWord : Form
    {
        public string FindString = "";//搜索的字段
        public bool isUpper = false;//向上查找
        public bool isDown = true;//向下查找
        public bool isAllowClose = false;//区分大小写

        public Form1 FmNote
        {
            get;
            internal set;
        }
      //  public Form1 FmNote = new Form1();

        public FindWord()
        {
            InitializeComponent();
            this.btFind.Click += btFind_Click;
            this.btCancle.Click += BtCancle_Click;
            this.FormClosing += FmFind_FormClosing;
            lFind.Height = 30;
        }

       private void FmFind_FormClosing(object sender, FormClosingEventArgs e)
        {
            //throw new NotImplementedException();
            if (!this.isAllowClose)
            {
                e.Cancel = true;//取消关闭
                this.Hide();
            }


        }

        private void BtCancle_Click(object sender, EventArgs e)
        {
            //   throw new NotImplementedException();
            this.Close();
        }

        private void btFind_Click(object sender, EventArgs e)
        {
            // throw new NotImplementedException();

            this.FindString = this.tbinput.Text;
            /* if (this.FindString =="") {
                 MessageBox.Show("您没有输入需要查找的数据！", "Error"
                                         , MessageBoxButtons.OK, MessageBoxIcon.Error);
                 return;
             }
            // this.FmNote.Search();

             if (!this.isAllowClose)
            {
                 Console.WriteLine("2222");
                 this.FmNote.Search(this.FindString, this.isUpper, this.isDown);
             }*/
            this.isUpper = this.chkUpper.Checked;
            this.isDown = this.rdoDown.Checked;
            if (this.FindString == "")
                MessageBox.Show("请输入你要查找的字符！", "提示"
                        , MessageBoxButtons.OK, MessageBoxIcon.Error);
            else
            this.DialogResult = DialogResult.OK;//获取查找到的结果！！！
            if (!this.isAllowClose)
            {
                this.FmNote.Search(this.FindString, this.isUpper, this.isDown);
                
            }      
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }
    }
}
