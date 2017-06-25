namespace GPSApp
{
    partial class fmMain
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.bOpen = new System.Windows.Forms.ToolStripMenuItem();
            this.bSave = new System.Windows.Forms.ToolStripMenuItem();
            this.psb = new System.Windows.Forms.ProgressBar();
            this.Txt = new System.Windows.Forms.TextBox();
            this.bNewWin = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bOpen,
            this.bSave,
            this.bNewWin});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(797, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // bOpen
            // 
            this.bOpen.Name = "bOpen";
            this.bOpen.Size = new System.Drawing.Size(61, 24);
            this.bOpen.Text = "Open";
            // 
            // bSave
            // 
            this.bSave.Name = "bSave";
            this.bSave.Size = new System.Drawing.Size(117, 24);
            this.bSave.Text = "Save to excel";
            // 
            // psb
            // 
            this.psb.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.psb.Location = new System.Drawing.Point(0, 453);
            this.psb.Name = "psb";
            this.psb.Size = new System.Drawing.Size(797, 23);
            this.psb.TabIndex = 1;
            this.psb.Value = 50;
            // 
            // Txt
            // 
            this.Txt.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Txt.Location = new System.Drawing.Point(0, 28);
            this.Txt.Multiline = true;
            this.Txt.Name = "Txt";
            this.Txt.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.Txt.Size = new System.Drawing.Size(797, 425);
            this.Txt.TabIndex = 2;
            // 
            // bNewWin
            // 
            this.bNewWin.Name = "bNewWin";
            this.bNewWin.Size = new System.Drawing.Size(82, 24);
            this.bNewWin.Text = "NewWin";
            // 
            // fmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(797, 476);
            this.Controls.Add(this.Txt);
            this.Controls.Add(this.psb);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "fmMain";
            this.Text = "GPS";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem bOpen;
        private System.Windows.Forms.ToolStripMenuItem bSave;
        private System.Windows.Forms.ProgressBar psb;
        private System.Windows.Forms.TextBox Txt;
        private System.Windows.Forms.ToolStripMenuItem bNewWin;
    }
}

