namespace MyNote
{
    partial class fmNote
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
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mNew = new System.Windows.Forms.ToolStripMenuItem();
            this.mOpen = new System.Windows.Forms.ToolStripMenuItem();
            this.mSave = new System.Windows.Forms.ToolStripMenuItem();
            this.mSaveAs = new System.Windows.Forms.ToolStripMenuItem();
            this.mExit = new System.Windows.Forms.ToolStripMenuItem();
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mCopy = new System.Windows.Forms.ToolStripMenuItem();
            this.mCut = new System.Windows.Forms.ToolStripMenuItem();
            this.mPaste = new System.Windows.Forms.ToolStripMenuItem();
            this.toolToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mFind = new System.Windows.Forms.ToolStripMenuItem();
            this.mFindNext = new System.Windows.Forms.ToolStripMenuItem();
            this.mReplace = new System.Windows.Forms.ToolStripMenuItem();
            this.mReplaceNext = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.lCursor = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel3 = new System.Windows.Forms.ToolStripStatusLabel();
            this.lCount = new System.Windows.Forms.ToolStripStatusLabel();
            this.tContent = new System.Windows.Forms.TextBox();
            this.mFind2 = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.editToolStripMenuItem,
            this.toolToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(668, 25);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mNew,
            this.mOpen,
            this.mSave,
            this.mSaveAs,
            this.mExit});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(39, 21);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // mNew
            // 
            this.mNew.Name = "mNew";
            this.mNew.Size = new System.Drawing.Size(117, 22);
            this.mNew.Text = "New";
            // 
            // mOpen
            // 
            this.mOpen.Name = "mOpen";
            this.mOpen.Size = new System.Drawing.Size(117, 22);
            this.mOpen.Text = "Open";
            // 
            // mSave
            // 
            this.mSave.Name = "mSave";
            this.mSave.Size = new System.Drawing.Size(117, 22);
            this.mSave.Text = "Save";
            // 
            // mSaveAs
            // 
            this.mSaveAs.Name = "mSaveAs";
            this.mSaveAs.Size = new System.Drawing.Size(117, 22);
            this.mSaveAs.Text = "SaveAs";
            // 
            // mExit
            // 
            this.mExit.Name = "mExit";
            this.mExit.Size = new System.Drawing.Size(117, 22);
            this.mExit.Text = "Exit";
            // 
            // editToolStripMenuItem
            // 
            this.editToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mCopy,
            this.mCut,
            this.mPaste});
            this.editToolStripMenuItem.Name = "editToolStripMenuItem";
            this.editToolStripMenuItem.Size = new System.Drawing.Size(42, 21);
            this.editToolStripMenuItem.Text = "Edit";
            // 
            // mCopy
            // 
            this.mCopy.Name = "mCopy";
            this.mCopy.Size = new System.Drawing.Size(107, 22);
            this.mCopy.Text = "Copy";
            // 
            // mCut
            // 
            this.mCut.Name = "mCut";
            this.mCut.Size = new System.Drawing.Size(107, 22);
            this.mCut.Text = "Cut";
            // 
            // mPaste
            // 
            this.mPaste.Name = "mPaste";
            this.mPaste.Size = new System.Drawing.Size(107, 22);
            this.mPaste.Text = "Paste";
            // 
            // toolToolStripMenuItem
            // 
            this.toolToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mFind,
            this.mFindNext,
            this.mReplace,
            this.mReplaceNext,
            this.mFind2});
            this.toolToolStripMenuItem.Name = "toolToolStripMenuItem";
            this.toolToolStripMenuItem.Size = new System.Drawing.Size(46, 21);
            this.toolToolStripMenuItem.Text = "Tool";
            // 
            // mFind
            // 
            this.mFind.Name = "mFind";
            this.mFind.Size = new System.Drawing.Size(152, 22);
            this.mFind.Text = "Find";
            // 
            // mFindNext
            // 
            this.mFindNext.Name = "mFindNext";
            this.mFindNext.Size = new System.Drawing.Size(152, 22);
            this.mFindNext.Text = "FindNext";
            // 
            // mReplace
            // 
            this.mReplace.Name = "mReplace";
            this.mReplace.Size = new System.Drawing.Size(152, 22);
            this.mReplace.Text = "Replace";
            // 
            // mReplaceNext
            // 
            this.mReplaceNext.Name = "mReplaceNext";
            this.mReplaceNext.Size = new System.Drawing.Size(152, 22);
            this.mReplaceNext.Text = "ReplaceNext";
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1,
            this.lCursor,
            this.toolStripStatusLabel3,
            this.lCount});
            this.statusStrip1.Location = new System.Drawing.Point(0, 419);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(668, 22);
            this.statusStrip1.TabIndex = 1;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(64, 17);
            this.toolStripStatusLabel1.Text = "Curssor : ";
            // 
            // lCursor
            // 
            this.lCursor.Name = "lCursor";
            this.lCursor.Size = new System.Drawing.Size(15, 17);
            this.lCursor.Text = "0";
            // 
            // toolStripStatusLabel3
            // 
            this.toolStripStatusLabel3.Name = "toolStripStatusLabel3";
            this.toolStripStatusLabel3.Size = new System.Drawing.Size(53, 17);
            this.toolStripStatusLabel3.Text = "Count : ";
            // 
            // lCount
            // 
            this.lCount.Name = "lCount";
            this.lCount.Size = new System.Drawing.Size(15, 17);
            this.lCount.Text = "0";
            // 
            // tContent
            // 
            this.tContent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tContent.Font = new System.Drawing.Font("宋体", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tContent.HideSelection = false;
            this.tContent.Location = new System.Drawing.Point(0, 25);
            this.tContent.Multiline = true;
            this.tContent.Name = "tContent";
            this.tContent.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.tContent.Size = new System.Drawing.Size(668, 394);
            this.tContent.TabIndex = 2;
            // 
            // mFind2
            // 
            this.mFind2.Name = "mFind2";
            this.mFind2.Size = new System.Drawing.Size(152, 22);
            this.mFind2.Text = "Find2";
            // 
            // fmNote
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(668, 441);
            this.Controls.Add(this.tContent);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "fmNote";
            this.Text = "MyNote";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mNew;
        private System.Windows.Forms.ToolStripMenuItem mOpen;
        private System.Windows.Forms.ToolStripMenuItem mSave;
        private System.Windows.Forms.ToolStripMenuItem mSaveAs;
        private System.Windows.Forms.ToolStripMenuItem mExit;
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mCopy;
        private System.Windows.Forms.ToolStripMenuItem mCut;
        private System.Windows.Forms.ToolStripMenuItem mPaste;
        private System.Windows.Forms.ToolStripMenuItem toolToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mFind;
        private System.Windows.Forms.ToolStripMenuItem mFindNext;
        private System.Windows.Forms.ToolStripMenuItem mReplace;
        private System.Windows.Forms.ToolStripMenuItem mReplaceNext;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.ToolStripStatusLabel lCursor;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel3;
        private System.Windows.Forms.ToolStripStatusLabel lCount;
        private System.Windows.Forms.TextBox tContent;
        private System.Windows.Forms.ToolStripMenuItem mFind2;
    }
}

