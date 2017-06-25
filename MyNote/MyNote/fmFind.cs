using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyNote
{
    public partial class fmFind : Form
    {
        public string FindString = "";
        public bool isUpper = false;
        public bool isDown = true;
        public bool isAllowClose = true;

        public fmNote FmNote { get; internal set; }

        public fmFind()
        {
            InitializeComponent();
            this.bFind.Click += BFind_Click;
            this.bCancel.Click += BCancel_Click;
            this.FormClosing += FmFind_FormClosing;
        }

        private void FmFind_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (!this.isAllowClose)
            {
                e.Cancel = true;
                this.Hide();
            }            
        }

        private void BCancel_Click(object sender, EventArgs e)
        {
            this.isAllowClose = true;
            this.DialogResult = DialogResult.Cancel;
        }

        private void BFind_Click(object sender, EventArgs e)
        {
            this.FindString = this.tFind.Text;
            this.isUpper = this.chkUpper.Checked;
            this.isDown = this.rdoDown.Checked;
            if (this.FindString != "")
                this.DialogResult = DialogResult.OK;
            if (!this.isAllowClose)
            {
                this.FmNote.Search(this.FindString, this.isUpper, this.isDown);
            }
        }
    }
}
