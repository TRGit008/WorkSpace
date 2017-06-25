namespace TRNoteTest
{
    partial class FindWord
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
            this.tbinput = new System.Windows.Forms.TextBox();
            this.lFind = new System.Windows.Forms.Label();
            this.btFind = new System.Windows.Forms.Button();
            this.btCancle = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rdoDown = new System.Windows.Forms.RadioButton();
            this.rdoUP = new System.Windows.Forms.RadioButton();
            this.chkUpper = new System.Windows.Forms.CheckBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tbinput
            // 
            this.tbinput.Location = new System.Drawing.Point(224, 68);
            this.tbinput.Multiline = true;
            this.tbinput.Name = "tbinput";
            this.tbinput.Size = new System.Drawing.Size(187, 38);
            this.tbinput.TabIndex = 0;
            this.tbinput.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // lFind
            // 
            this.lFind.AutoSize = true;
            this.lFind.Location = new System.Drawing.Point(48, 78);
            this.lFind.Name = "lFind";
            this.lFind.Size = new System.Drawing.Size(134, 18);
            this.lFind.TabIndex = 1;
            this.lFind.Text = "查找内容（N）:";
            // 
            // btFind
            // 
            this.btFind.Location = new System.Drawing.Point(452, 68);
            this.btFind.Name = "btFind";
            this.btFind.Size = new System.Drawing.Size(130, 38);
            this.btFind.TabIndex = 2;
            this.btFind.Text = "查找下一个";
            this.btFind.UseVisualStyleBackColor = true;
            // 
            // btCancle
            // 
            this.btCancle.Location = new System.Drawing.Point(452, 133);
            this.btCancle.Name = "btCancle";
            this.btCancle.Size = new System.Drawing.Size(130, 38);
            this.btCancle.TabIndex = 3;
            this.btCancle.Text = "取消";
            this.btCancle.UseVisualStyleBackColor = true;
            this.btCancle.Click += new System.EventHandler(this.button2_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rdoDown);
            this.groupBox1.Controls.Add(this.rdoUP);
            this.groupBox1.Location = new System.Drawing.Point(211, 133);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 100);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "方向";
            // 
            // rdoDown
            // 
            this.rdoDown.AutoSize = true;
            this.rdoDown.Checked = true;
            this.rdoDown.Location = new System.Drawing.Point(125, 53);
            this.rdoDown.Name = "rdoDown";
            this.rdoDown.Size = new System.Drawing.Size(69, 22);
            this.rdoDown.TabIndex = 1;
            this.rdoDown.TabStop = true;
            this.rdoDown.Text = "向下";
            this.rdoDown.UseVisualStyleBackColor = true;
            // 
            // rdoUP
            // 
            this.rdoUP.AutoSize = true;
            this.rdoUP.Location = new System.Drawing.Point(7, 53);
            this.rdoUP.Name = "rdoUP";
            this.rdoUP.Size = new System.Drawing.Size(69, 22);
            this.rdoUP.TabIndex = 0;
            this.rdoUP.Text = "向上";
            this.rdoUP.UseVisualStyleBackColor = true;
            // 
            // chkUpper
            // 
            this.chkUpper.AutoSize = true;
            this.chkUpper.Location = new System.Drawing.Point(13, 186);
            this.chkUpper.Name = "chkUpper";
            this.chkUpper.Size = new System.Drawing.Size(169, 22);
            this.chkUpper.TabIndex = 5;
            this.chkUpper.Text = "区分大小写（C）";
            this.chkUpper.UseVisualStyleBackColor = true;
            // 
            // FindWord
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(647, 245);
            this.Controls.Add(this.chkUpper);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btCancle);
            this.Controls.Add(this.btFind);
            this.Controls.Add(this.lFind);
            this.Controls.Add(this.tbinput);
            this.Name = "FindWord";
            this.Text = "查找";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbinput;
        private System.Windows.Forms.Label lFind;
        private System.Windows.Forms.Button btFind;
        private System.Windows.Forms.Button btCancle;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rdoDown;
        private System.Windows.Forms.RadioButton rdoUP;
        private System.Windows.Forms.CheckBox chkUpper;
    }
}