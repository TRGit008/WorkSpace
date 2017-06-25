namespace MyNote
{
    partial class fmFind
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
            this.label1 = new System.Windows.Forms.Label();
            this.tFind = new System.Windows.Forms.TextBox();
            this.chkUpper = new System.Windows.Forms.CheckBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rdoDown = new System.Windows.Forms.RadioButton();
            this.rdoUP = new System.Windows.Forms.RadioButton();
            this.bFind = new System.Windows.Forms.Button();
            this.bCancel = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(62, 64);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(134, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "Find String : ";
            // 
            // tFind
            // 
            this.tFind.Location = new System.Drawing.Point(204, 60);
            this.tFind.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tFind.Name = "tFind";
            this.tFind.Size = new System.Drawing.Size(308, 28);
            this.tFind.TabIndex = 1;
            // 
            // chkUpper
            // 
            this.chkUpper.AutoSize = true;
            this.chkUpper.Location = new System.Drawing.Point(64, 117);
            this.chkUpper.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.chkUpper.Name = "chkUpper";
            this.chkUpper.Size = new System.Drawing.Size(142, 22);
            this.chkUpper.TabIndex = 2;
            this.chkUpper.Text = "不区分大小写";
            this.chkUpper.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rdoDown);
            this.groupBox1.Controls.Add(this.rdoUP);
            this.groupBox1.Location = new System.Drawing.Point(218, 100);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox1.Size = new System.Drawing.Size(298, 56);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            // 
            // rdoDown
            // 
            this.rdoDown.AutoSize = true;
            this.rdoDown.Checked = true;
            this.rdoDown.Dock = System.Windows.Forms.DockStyle.Left;
            this.rdoDown.Location = new System.Drawing.Point(55, 25);
            this.rdoDown.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.rdoDown.Name = "rdoDown";
            this.rdoDown.Size = new System.Drawing.Size(69, 27);
            this.rdoDown.TabIndex = 1;
            this.rdoDown.TabStop = true;
            this.rdoDown.Text = "Down";
            this.rdoDown.UseVisualStyleBackColor = true;
            // 
            // rdoUP
            // 
            this.rdoUP.AutoSize = true;
            this.rdoUP.Dock = System.Windows.Forms.DockStyle.Left;
            this.rdoUP.Location = new System.Drawing.Point(4, 25);
            this.rdoUP.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.rdoUP.Name = "rdoUP";
            this.rdoUP.Size = new System.Drawing.Size(51, 27);
            this.rdoUP.TabIndex = 0;
            this.rdoUP.Text = "UP";
            this.rdoUP.UseVisualStyleBackColor = true;
            // 
            // bFind
            // 
            this.bFind.Location = new System.Drawing.Point(622, 60);
            this.bFind.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.bFind.Name = "bFind";
            this.bFind.Size = new System.Drawing.Size(112, 34);
            this.bFind.TabIndex = 4;
            this.bFind.Text = "Find";
            this.bFind.UseVisualStyleBackColor = true;
            // 
            // bCancel
            // 
            this.bCancel.Location = new System.Drawing.Point(622, 111);
            this.bCancel.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.bCancel.Name = "bCancel";
            this.bCancel.Size = new System.Drawing.Size(112, 34);
            this.bCancel.TabIndex = 4;
            this.bCancel.Text = "Cancel";
            this.bCancel.UseVisualStyleBackColor = true;
            // 
            // fmFind
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(770, 222);
            this.Controls.Add(this.bCancel);
            this.Controls.Add(this.bFind);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.chkUpper);
            this.Controls.Add(this.tFind);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "fmFind";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Find";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tFind;
        private System.Windows.Forms.CheckBox chkUpper;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rdoDown;
        private System.Windows.Forms.RadioButton rdoUP;
        private System.Windows.Forms.Button bFind;
        private System.Windows.Forms.Button bCancel;
    }
}