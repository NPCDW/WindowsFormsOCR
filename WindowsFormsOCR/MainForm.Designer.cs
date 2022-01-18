namespace WindowsFormsOCR
{
    partial class MainForm
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.notifyIcon = new System.Windows.Forms.NotifyIcon(this.components);
            this.contextMenuStrip = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.translateButton = new System.Windows.Forms.ToolStripMenuItem();
            this.ocrButton = new System.Windows.Forms.ToolStripMenuItem();
            this.settingButton = new System.Windows.Forms.ToolStripMenuItem();
            this.exitButton = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // notifyIcon
            // 
            this.notifyIcon.ContextMenuStrip = this.contextMenuStrip;
            this.notifyIcon.Icon = ((System.Drawing.Icon)(resources.GetObject("notifyIcon.Icon")));
            this.notifyIcon.Text = "OCR";
            this.notifyIcon.Visible = true;
            // 
            // contextMenuStrip
            // 
            this.contextMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.translateButton,
            this.ocrButton,
            this.settingButton,
            this.exitButton});
            this.contextMenuStrip.Name = "contextMenuStrip1";
            this.contextMenuStrip.Size = new System.Drawing.Size(175, 92);
            // 
            // translateButton
            // 
            this.translateButton.Name = "translateButton";
            this.translateButton.ShortcutKeyDisplayString = "F2";
            this.translateButton.Size = new System.Drawing.Size(174, 22);
            this.translateButton.Text = "划词/截图翻译";
            this.translateButton.Click += new System.EventHandler(this.Translate_Click);
            // 
            // ocrButton
            // 
            this.ocrButton.Name = "ocrButton";
            this.ocrButton.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.ocrButton.ShortcutKeyDisplayString = "F4";
            this.ocrButton.Size = new System.Drawing.Size(174, 22);
            this.ocrButton.Text = "截图文字识别";
            this.ocrButton.Click += new System.EventHandler(this.OcrButton_Click);
            // 
            // settingButton
            // 
            this.settingButton.Name = "settingButton";
            this.settingButton.Size = new System.Drawing.Size(174, 22);
            this.settingButton.Text = "设置";
            this.settingButton.Click += new System.EventHandler(this.Setting_Click);
            // 
            // exitButton
            // 
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(174, 22);
            this.exitButton.Text = "退出";
            this.exitButton.Click += new System.EventHandler(this.Exit_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(294, 271);
            this.ControlBox = false;
            this.Name = "MainForm";
            this.Opacity = 0D;
            this.ShowInTaskbar = false;
            this.Text = "Main";
            this.WindowState = System.Windows.Forms.FormWindowState.Minimized;
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.MainForm_FormClosed);
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.contextMenuStrip.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.NotifyIcon notifyIcon;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem settingButton;
        private System.Windows.Forms.ToolStripMenuItem ocrButton;
        private System.Windows.Forms.ToolStripMenuItem exitButton;
        private System.Windows.Forms.ToolStripMenuItem translateButton;
    }
}

