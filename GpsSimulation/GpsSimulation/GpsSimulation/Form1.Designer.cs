namespace GpsSimulation
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.cbSerialSelect = new System.Windows.Forms.ComboBox();
            this.OpenSerialBtn = new System.Windows.Forms.Button();
            this.tbFrequency = new System.Windows.Forms.TextBox();
            this.Modifyfrebtn = new System.Windows.Forms.Button();
            this.MsgShow = new System.Windows.Forms.TextBox();
            this.loadbtn = new System.Windows.Forms.Button();
            this.beginbtn = new System.Windows.Forms.Button();
            this.stopbtn = new System.Windows.Forms.Button();
            this.Author = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // cbSerialSelect
            // 
            this.cbSerialSelect.FormattingEnabled = true;
            this.cbSerialSelect.Items.AddRange(new object[] {
            "COM1",
            "COM2",
            "COM3",
            "COM4",
            "COM5",
            "COM6",
            "COM7",
            "COM8",
            "COM9",
            "COM10",
            "COM11",
            "COM12",
            "COM13",
            "COM14",
            "COM15",
            "COM16"});
            this.cbSerialSelect.Location = new System.Drawing.Point(12, 12);
            this.cbSerialSelect.Name = "cbSerialSelect";
            this.cbSerialSelect.Size = new System.Drawing.Size(121, 20);
            this.cbSerialSelect.TabIndex = 0;
            // 
            // OpenSerialBtn
            // 
            this.OpenSerialBtn.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.OpenSerialBtn.Location = new System.Drawing.Point(152, 12);
            this.OpenSerialBtn.Name = "OpenSerialBtn";
            this.OpenSerialBtn.Size = new System.Drawing.Size(75, 23);
            this.OpenSerialBtn.TabIndex = 1;
            this.OpenSerialBtn.Text = "打开串口";
            this.OpenSerialBtn.UseVisualStyleBackColor = true;
            this.OpenSerialBtn.Click += new System.EventHandler(this.OpenSerialBtn_Click);
            // 
            // tbFrequency
            // 
            this.tbFrequency.Location = new System.Drawing.Point(12, 50);
            this.tbFrequency.Name = "tbFrequency";
            this.tbFrequency.Size = new System.Drawing.Size(121, 21);
            this.tbFrequency.TabIndex = 2;
            // 
            // Modifyfrebtn
            // 
            this.Modifyfrebtn.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Modifyfrebtn.Location = new System.Drawing.Point(152, 50);
            this.Modifyfrebtn.Name = "Modifyfrebtn";
            this.Modifyfrebtn.Size = new System.Drawing.Size(75, 23);
            this.Modifyfrebtn.TabIndex = 3;
            this.Modifyfrebtn.Text = "频率修改";
            this.Modifyfrebtn.UseVisualStyleBackColor = true;
            this.Modifyfrebtn.Click += new System.EventHandler(this.Modifyfrebtn_Click);
            // 
            // MsgShow
            // 
            this.MsgShow.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.MsgShow.Location = new System.Drawing.Point(12, 78);
            this.MsgShow.Multiline = true;
            this.MsgShow.Name = "MsgShow";
            this.MsgShow.Size = new System.Drawing.Size(430, 176);
            this.MsgShow.TabIndex = 0;
            this.MsgShow.TextChanged += new System.EventHandler(this.MsgShow_TextChanged);
            // 
            // loadbtn
            // 
            this.loadbtn.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.loadbtn.Location = new System.Drawing.Point(250, 12);
            this.loadbtn.Name = "loadbtn";
            this.loadbtn.Size = new System.Drawing.Size(89, 23);
            this.loadbtn.TabIndex = 4;
            this.loadbtn.Text = "加载数据文件";
            this.loadbtn.UseVisualStyleBackColor = true;
            this.loadbtn.Click += new System.EventHandler(this.loadbtn_Click);
            // 
            // beginbtn
            // 
            this.beginbtn.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.beginbtn.Location = new System.Drawing.Point(250, 50);
            this.beginbtn.Name = "beginbtn";
            this.beginbtn.Size = new System.Drawing.Size(75, 23);
            this.beginbtn.TabIndex = 5;
            this.beginbtn.Text = "开始";
            this.beginbtn.UseVisualStyleBackColor = true;
            this.beginbtn.Click += new System.EventHandler(this.beginbtn_Click);
            // 
            // stopbtn
            // 
            this.stopbtn.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.stopbtn.Location = new System.Drawing.Point(350, 50);
            this.stopbtn.Name = "stopbtn";
            this.stopbtn.Size = new System.Drawing.Size(75, 23);
            this.stopbtn.TabIndex = 6;
            this.stopbtn.Text = "暂停";
            this.stopbtn.UseVisualStyleBackColor = true;
            this.stopbtn.Click += new System.EventHandler(this.stopbtn_Click);
            // 
            // Author
            // 
            this.Author.AutoSize = true;
            this.Author.BackColor = System.Drawing.Color.Transparent;
            this.Author.Font = new System.Drawing.Font("SimSun", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Author.ForeColor = System.Drawing.Color.White;
            this.Author.Location = new System.Drawing.Point(353, 3);
            this.Author.Name = "Author";
            this.Author.Size = new System.Drawing.Size(98, 14);
            this.Author.TabIndex = 7;
            this.Author.Text = "作者：ST00632";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(454, 266);
            this.Controls.Add(this.Author);
            this.Controls.Add(this.stopbtn);
            this.Controls.Add(this.beginbtn);
            this.Controls.Add(this.loadbtn);
            this.Controls.Add(this.MsgShow);
            this.Controls.Add(this.Modifyfrebtn);
            this.Controls.Add(this.tbFrequency);
            this.Controls.Add(this.OpenSerialBtn);
            this.Controls.Add(this.cbSerialSelect);
            this.Name = "Form1";
            this.Text = "GPS模拟器";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cbSerialSelect;
        private System.Windows.Forms.Button OpenSerialBtn;
        private System.Windows.Forms.TextBox tbFrequency;
        private System.Windows.Forms.Button Modifyfrebtn;
        private System.Windows.Forms.TextBox MsgShow;
        private System.Windows.Forms.Button loadbtn;
        private System.Windows.Forms.Button beginbtn;
        private System.Windows.Forms.Button stopbtn;
        private System.Windows.Forms.Label Author;
    }
}

