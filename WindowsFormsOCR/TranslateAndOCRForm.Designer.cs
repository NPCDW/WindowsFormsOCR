namespace WindowsFormsOCR
{
    partial class TranslateAndOcrForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TranslateAndOcrForm));
            this.ocrTextBox = new System.Windows.Forms.TextBox();
            this.translateTextBox = new System.Windows.Forms.TextBox();
            this.translateButton = new System.Windows.Forms.Button();
            this.defaultOcrProvideComboBox = new System.Windows.Forms.ComboBox();
            this.defaultOcrTypeComboBox = new System.Windows.Forms.ComboBox();
            this.defaultOcrSettingCheck = new System.Windows.Forms.CheckBox();
            this.ocrButton = new System.Windows.Forms.Button();
            this.defaultTranslateProvideComboBox = new System.Windows.Forms.ComboBox();
            this.defaultTranslateSettingCheck = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // ocrTextBox
            // 
            this.ocrTextBox.AccessibleName = "";
            this.ocrTextBox.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.ocrTextBox.Location = new System.Drawing.Point(13, 44);
            this.ocrTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.ocrTextBox.Multiline = true;
            this.ocrTextBox.Name = "ocrTextBox";
            this.ocrTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.ocrTextBox.Size = new System.Drawing.Size(611, 211);
            this.ocrTextBox.TabIndex = 1;
            this.ocrTextBox.Text = "OCR 文字识别";
            // 
            // translateTextBox
            // 
            this.translateTextBox.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.translateTextBox.Location = new System.Drawing.Point(12, 294);
            this.translateTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.translateTextBox.Multiline = true;
            this.translateTextBox.Name = "translateTextBox";
            this.translateTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.translateTextBox.Size = new System.Drawing.Size(611, 211);
            this.translateTextBox.TabIndex = 2;
            this.translateTextBox.Text = "截图/划词翻译";
            // 
            // translateButton
            // 
            this.translateButton.Location = new System.Drawing.Point(548, 264);
            this.translateButton.Name = "translateButton";
            this.translateButton.Size = new System.Drawing.Size(75, 23);
            this.translateButton.TabIndex = 3;
            this.translateButton.Text = "翻译";
            this.translateButton.UseVisualStyleBackColor = true;
            this.translateButton.Click += new System.EventHandler(this.translateButton_Click);
            // 
            // defaultOcrProvideComboBox
            // 
            this.defaultOcrProvideComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.defaultOcrProvideComboBox.FormattingEnabled = true;
            this.defaultOcrProvideComboBox.Items.AddRange(new object[] {
            "百度云#BaiduCloud",
            "腾讯云#TencentCloud"});
            this.defaultOcrProvideComboBox.Location = new System.Drawing.Point(12, 12);
            this.defaultOcrProvideComboBox.Name = "defaultOcrProvideComboBox";
            this.defaultOcrProvideComboBox.Size = new System.Drawing.Size(121, 25);
            this.defaultOcrProvideComboBox.TabIndex = 4;
            this.defaultOcrProvideComboBox.SelectedIndexChanged += new System.EventHandler(this.defaultOcrProvideComboBox_SelectedIndexChanged);
            // 
            // defaultOcrTypeComboBox
            // 
            this.defaultOcrTypeComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.defaultOcrTypeComboBox.FormattingEnabled = true;
            this.defaultOcrTypeComboBox.Location = new System.Drawing.Point(139, 12);
            this.defaultOcrTypeComboBox.Name = "defaultOcrTypeComboBox";
            this.defaultOcrTypeComboBox.Size = new System.Drawing.Size(121, 25);
            this.defaultOcrTypeComboBox.TabIndex = 5;
            this.defaultOcrTypeComboBox.SelectedIndexChanged += new System.EventHandler(this.defaultOcrTypeComboBox_SelectedIndexChanged);
            // 
            // defaultOcrSettingCheck
            // 
            this.defaultOcrSettingCheck.AutoSize = true;
            this.defaultOcrSettingCheck.Checked = true;
            this.defaultOcrSettingCheck.CheckState = System.Windows.Forms.CheckState.Checked;
            this.defaultOcrSettingCheck.Enabled = false;
            this.defaultOcrSettingCheck.Location = new System.Drawing.Point(266, 14);
            this.defaultOcrSettingCheck.Name = "defaultOcrSettingCheck";
            this.defaultOcrSettingCheck.Size = new System.Drawing.Size(75, 21);
            this.defaultOcrSettingCheck.TabIndex = 6;
            this.defaultOcrSettingCheck.Text = "设为默认";
            this.defaultOcrSettingCheck.UseVisualStyleBackColor = true;
            this.defaultOcrSettingCheck.CheckedChanged += new System.EventHandler(this.defaultOcrSettingCheck_CheckedChanged);
            // 
            // ocrButton
            // 
            this.ocrButton.Location = new System.Drawing.Point(548, 12);
            this.ocrButton.Name = "ocrButton";
            this.ocrButton.Size = new System.Drawing.Size(75, 23);
            this.ocrButton.TabIndex = 7;
            this.ocrButton.Text = "重新识别";
            this.ocrButton.UseVisualStyleBackColor = true;
            this.ocrButton.Click += new System.EventHandler(this.ocrButton_Click);
            // 
            // defaultTranslateProvideComboBox
            // 
            this.defaultTranslateProvideComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.defaultTranslateProvideComboBox.FormattingEnabled = true;
            this.defaultTranslateProvideComboBox.Items.AddRange(new object[] {
            "百度翻译开放平台#BaiduAI",
            "腾讯云#TencentCloud"});
            this.defaultTranslateProvideComboBox.Location = new System.Drawing.Point(12, 262);
            this.defaultTranslateProvideComboBox.Name = "defaultTranslateProvideComboBox";
            this.defaultTranslateProvideComboBox.Size = new System.Drawing.Size(121, 25);
            this.defaultTranslateProvideComboBox.TabIndex = 8;
            this.defaultTranslateProvideComboBox.SelectedIndexChanged += new System.EventHandler(this.defaultTranslateProvideComboBox_SelectedIndexChanged);
            // 
            // defaultTranslateSettingCheck
            // 
            this.defaultTranslateSettingCheck.AutoSize = true;
            this.defaultTranslateSettingCheck.Checked = true;
            this.defaultTranslateSettingCheck.CheckState = System.Windows.Forms.CheckState.Checked;
            this.defaultTranslateSettingCheck.Enabled = false;
            this.defaultTranslateSettingCheck.Location = new System.Drawing.Point(139, 264);
            this.defaultTranslateSettingCheck.Name = "defaultTranslateSettingCheck";
            this.defaultTranslateSettingCheck.Size = new System.Drawing.Size(75, 21);
            this.defaultTranslateSettingCheck.TabIndex = 9;
            this.defaultTranslateSettingCheck.Text = "设为默认";
            this.defaultTranslateSettingCheck.UseVisualStyleBackColor = true;
            this.defaultTranslateSettingCheck.CheckedChanged += new System.EventHandler(this.defaultTranslateSettingCheck_CheckedChanged);
            // 
            // TranslateAndOcrForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(636, 516);
            this.Controls.Add(this.defaultTranslateSettingCheck);
            this.Controls.Add(this.defaultTranslateProvideComboBox);
            this.Controls.Add(this.ocrButton);
            this.Controls.Add(this.defaultOcrSettingCheck);
            this.Controls.Add(this.defaultOcrTypeComboBox);
            this.Controls.Add(this.defaultOcrProvideComboBox);
            this.Controls.Add(this.translateButton);
            this.Controls.Add(this.translateTextBox);
            this.Controls.Add(this.ocrTextBox);
            this.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "TranslateAndOcrForm";
            this.Text = "文字识别和翻译";
            this.Load += new System.EventHandler(this.TranslateAndOcrForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        public System.Windows.Forms.TextBox ocrTextBox;
        public System.Windows.Forms.TextBox translateTextBox;
        private System.Windows.Forms.Button translateButton;
        private System.Windows.Forms.ComboBox defaultOcrProvideComboBox;
        private System.Windows.Forms.ComboBox defaultOcrTypeComboBox;
        private System.Windows.Forms.CheckBox defaultOcrSettingCheck;
        private System.Windows.Forms.Button ocrButton;
        private System.Windows.Forms.ComboBox defaultTranslateProvideComboBox;
        private System.Windows.Forms.CheckBox defaultTranslateSettingCheck;
    }
}