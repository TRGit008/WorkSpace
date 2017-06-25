namespace GPSApp
{
    partial class fmGPSAnalysis
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fmGPSAnalysis));
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.bOpen = new System.Windows.Forms.ToolStripButton();
            this.psb = new System.Windows.Forms.ProgressBar();
            this.Txt = new System.Windows.Forms.TextBox();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bOpen});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(974, 27);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // bOpen
            // 
            this.bOpen.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.bOpen.Image = ((System.Drawing.Image)(resources.GetObject("bOpen.Image")));
            this.bOpen.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.bOpen.Name = "bOpen";
            this.bOpen.Size = new System.Drawing.Size(53, 24);
            this.bOpen.Text = "Open";
            // 
            // psb
            // 
            this.psb.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.psb.Location = new System.Drawing.Point(0, 595);
            this.psb.Name = "psb";
            this.psb.Size = new System.Drawing.Size(974, 23);
            this.psb.TabIndex = 2;
            this.psb.Value = 50;
            // 
            // Txt
            // 
            this.Txt.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Txt.Location = new System.Drawing.Point(0, 27);
            this.Txt.Multiline = true;
            this.Txt.Name = "Txt";
            this.Txt.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.Txt.Size = new System.Drawing.Size(974, 568);
            this.Txt.TabIndex = 3;
            // 
            // fmGPSAnalysis
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(974, 618);
            this.Controls.Add(this.Txt);
            this.Controls.Add(this.psb);
            this.Controls.Add(this.toolStrip1);
            this.Name = "fmGPSAnalysis";
            this.Text = "fmGPSAnalysis";
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton bOpen;
        private System.Windows.Forms.ProgressBar psb;
        private System.Windows.Forms.TextBox Txt;
    }
}