namespace WindowsFormsOCR
{
    partial class SettingForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SettingForm));
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage5 = new System.Windows.Forms.TabPage();
            this.label18 = new System.Windows.Forms.Label();
            this.wordSelectionIntervalBox = new System.Windows.Forms.NumericUpDown();
            this.label17 = new System.Windows.Forms.Label();
            this.defaultTranslateProvide = new System.Windows.Forms.GroupBox();
            this.targetLanguageComboBox = new System.Windows.Forms.ComboBox();
            this.sourceLanguageComboBox = new System.Windows.Forms.ComboBox();
            this.defaultTranslateTencentCloudRadio = new System.Windows.Forms.RadioButton();
            this.defaultTranslateBaiduAIRadio = new System.Windows.Forms.RadioButton();
            this.defaultOcrProvideGroupBox = new System.Windows.Forms.GroupBox();
            this.defaultOcrTypeComboBox = new System.Windows.Forms.ComboBox();
            this.defaultOcrTencentCloudRadio = new System.Windows.Forms.RadioButton();
            this.defaultOcrBaiduCloudRadio = new System.Windows.Forms.RadioButton();
            this.autoStartButton = new System.Windows.Forms.CheckBox();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.linkLabel3 = new System.Windows.Forms.LinkLabel();
            this.baiduOcrGroupBox = new System.Windows.Forms.GroupBox();
            this.BaiduCloud_SecretKeyPasswordShowCheckbox = new System.Windows.Forms.CheckBox();
            this.BaiduCloud_APIKeyInput = new System.Windows.Forms.TextBox();
            this.BaiduCloud_SecretKeyInput = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.tencentOcrGroupBox = new System.Windows.Forms.GroupBox();
            this.TencentCloud_SecretKeyPasswordShow = new System.Windows.Forms.CheckBox();
            this.TencentCloud_SecretKeyInput = new System.Windows.Forms.TextBox();
            this.TencentCloud_SecretIdInput = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.linkLabel6 = new System.Windows.Forms.LinkLabel();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.linkLabel5 = new System.Windows.Forms.LinkLabel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.TencentCloudTranslate_SecretKeyPasswordShow = new System.Windows.Forms.CheckBox();
            this.TencentCloudTranslate_SecretKeyInput = new System.Windows.Forms.TextBox();
            this.TencentCloudTranslate_SecretIdInput = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.BaiduAI_APPSecretPasswordShowCheckbox = new System.Windows.Forms.CheckBox();
            this.BaiduAI_APPIDInput = new System.Windows.Forms.TextBox();
            this.BaiduAI_APPSecretInput = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.linkLabel4 = new System.Windows.Forms.LinkLabel();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.label16 = new System.Windows.Forms.Label();
            this.defaultHotKeysButton = new System.Windows.Forms.Button();
            this.ScreenshotTranslateHotKeyTextBox = new System.Windows.Forms.TextBox();
            this.GetWordsTranslateHotKeyTextBox = new System.Windows.Forms.TextBox();
            this.ocrHotKeyTextBox = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.emailLink = new System.Windows.Forms.LinkLabel();
            this.label4 = new System.Windows.Forms.Label();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tabControl1.SuspendLayout();
            this.tabPage5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.wordSelectionIntervalBox)).BeginInit();
            this.defaultTranslateProvide.SuspendLayout();
            this.defaultOcrProvideGroupBox.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.baiduOcrGroupBox.SuspendLayout();
            this.tencentOcrGroupBox.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage4.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage5);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage4);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tabControl1.ItemSize = new System.Drawing.Size(66, 22);
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(4);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(479, 453);
            this.tabControl1.SizeMode = System.Windows.Forms.TabSizeMode.Fixed;
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage5
            // 
            this.tabPage5.Controls.Add(this.label18);
            this.tabPage5.Controls.Add(this.wordSelectionIntervalBox);
            this.tabPage5.Controls.Add(this.label17);
            this.tabPage5.Controls.Add(this.defaultTranslateProvide);
            this.tabPage5.Controls.Add(this.defaultOcrProvideGroupBox);
            this.tabPage5.Controls.Add(this.autoStartButton);
            this.tabPage5.Location = new System.Drawing.Point(4, 26);
            this.tabPage5.Name = "tabPage5";
            this.tabPage5.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage5.Size = new System.Drawing.Size(471, 423);
            this.tabPage5.TabIndex = 4;
            this.tabPage5.Text = "常规";
            this.tabPage5.UseVisualStyleBackColor = true;
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(133, 190);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(25, 17);
            this.label18.TabIndex = 6;
            this.label18.Text = "ms";
            // 
            // wordSelectionIntervalBox
            // 
            this.wordSelectionIntervalBox.Increment = new decimal(new int[] {
            200,
            0,
            0,
            0});
            this.wordSelectionIntervalBox.Location = new System.Drawing.Point(76, 188);
            this.wordSelectionIntervalBox.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.wordSelectionIntervalBox.Minimum = new decimal(new int[] {
            200,
            0,
            0,
            0});
            this.wordSelectionIntervalBox.Name = "wordSelectionIntervalBox";
            this.wordSelectionIntervalBox.Size = new System.Drawing.Size(51, 23);
            this.wordSelectionIntervalBox.TabIndex = 5;
            this.wordSelectionIntervalBox.Value = new decimal(new int[] {
            200,
            0,
            0,
            0});
            this.wordSelectionIntervalBox.ValueChanged += new System.EventHandler(this.wordSelectionIntervalBox_ValueChanged);
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(14, 190);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(56, 17);
            this.label17.TabIndex = 4;
            this.label17.Text = "取词间隔";
            // 
            // defaultTranslateProvide
            // 
            this.defaultTranslateProvide.Controls.Add(this.targetLanguageComboBox);
            this.defaultTranslateProvide.Controls.Add(this.sourceLanguageComboBox);
            this.defaultTranslateProvide.Controls.Add(this.defaultTranslateTencentCloudRadio);
            this.defaultTranslateProvide.Controls.Add(this.defaultTranslateBaiduAIRadio);
            this.defaultTranslateProvide.Location = new System.Drawing.Point(6, 115);
            this.defaultTranslateProvide.Name = "defaultTranslateProvide";
            this.defaultTranslateProvide.Size = new System.Drawing.Size(459, 57);
            this.defaultTranslateProvide.TabIndex = 3;
            this.defaultTranslateProvide.TabStop = false;
            this.defaultTranslateProvide.Text = "默认翻译";
            // 
            // targetLanguageComboBox
            // 
            this.targetLanguageComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.targetLanguageComboBox.FormattingEnabled = true;
            this.targetLanguageComboBox.Location = new System.Drawing.Point(286, 22);
            this.targetLanguageComboBox.Name = "targetLanguageComboBox";
            this.targetLanguageComboBox.Size = new System.Drawing.Size(121, 25);
            this.targetLanguageComboBox.TabIndex = 4;
            this.targetLanguageComboBox.SelectedIndexChanged += new System.EventHandler(this.targetLanguageComboBox_SelectedIndexChanged);
            // 
            // sourceLanguageComboBox
            // 
            this.sourceLanguageComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.sourceLanguageComboBox.FormattingEnabled = true;
            this.sourceLanguageComboBox.Location = new System.Drawing.Point(159, 22);
            this.sourceLanguageComboBox.Name = "sourceLanguageComboBox";
            this.sourceLanguageComboBox.Size = new System.Drawing.Size(121, 25);
            this.sourceLanguageComboBox.TabIndex = 4;
            this.sourceLanguageComboBox.SelectedIndexChanged += new System.EventHandler(this.sourceLanguageComboBox_SelectedIndexChanged);
            // 
            // defaultTranslateTencentCloudRadio
            // 
            this.defaultTranslateTencentCloudRadio.AutoSize = true;
            this.defaultTranslateTencentCloudRadio.Location = new System.Drawing.Point(91, 23);
            this.defaultTranslateTencentCloudRadio.Name = "defaultTranslateTencentCloudRadio";
            this.defaultTranslateTencentCloudRadio.Size = new System.Drawing.Size(62, 21);
            this.defaultTranslateTencentCloudRadio.TabIndex = 1;
            this.defaultTranslateTencentCloudRadio.TabStop = true;
            this.defaultTranslateTencentCloudRadio.Tag = "TencentCloud";
            this.defaultTranslateTencentCloudRadio.Text = "腾讯云";
            this.defaultTranslateTencentCloudRadio.UseVisualStyleBackColor = true;
            this.defaultTranslateTencentCloudRadio.CheckedChanged += new System.EventHandler(this.commonDefaultTranslateProvideType_CheckedChanged);
            // 
            // defaultTranslateBaiduAIRadio
            // 
            this.defaultTranslateBaiduAIRadio.AutoSize = true;
            this.defaultTranslateBaiduAIRadio.Location = new System.Drawing.Point(11, 23);
            this.defaultTranslateBaiduAIRadio.Name = "defaultTranslateBaiduAIRadio";
            this.defaultTranslateBaiduAIRadio.Size = new System.Drawing.Size(74, 21);
            this.defaultTranslateBaiduAIRadio.TabIndex = 0;
            this.defaultTranslateBaiduAIRadio.TabStop = true;
            this.defaultTranslateBaiduAIRadio.Tag = "BaiduAI";
            this.defaultTranslateBaiduAIRadio.Text = "百度大脑";
            this.defaultTranslateBaiduAIRadio.UseVisualStyleBackColor = true;
            this.defaultTranslateBaiduAIRadio.CheckedChanged += new System.EventHandler(this.commonDefaultTranslateProvideType_CheckedChanged);
            // 
            // defaultOcrProvideGroupBox
            // 
            this.defaultOcrProvideGroupBox.Controls.Add(this.defaultOcrTypeComboBox);
            this.defaultOcrProvideGroupBox.Controls.Add(this.defaultOcrTencentCloudRadio);
            this.defaultOcrProvideGroupBox.Controls.Add(this.defaultOcrBaiduCloudRadio);
            this.defaultOcrProvideGroupBox.Location = new System.Drawing.Point(6, 52);
            this.defaultOcrProvideGroupBox.Name = "defaultOcrProvideGroupBox";
            this.defaultOcrProvideGroupBox.Size = new System.Drawing.Size(459, 57);
            this.defaultOcrProvideGroupBox.TabIndex = 2;
            this.defaultOcrProvideGroupBox.TabStop = false;
            this.defaultOcrProvideGroupBox.Text = "默认OCR";
            // 
            // defaultOcrTypeComboBox
            // 
            this.defaultOcrTypeComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.defaultOcrTypeComboBox.FormattingEnabled = true;
            this.defaultOcrTypeComboBox.Location = new System.Drawing.Point(159, 22);
            this.defaultOcrTypeComboBox.Name = "defaultOcrTypeComboBox";
            this.defaultOcrTypeComboBox.Size = new System.Drawing.Size(294, 25);
            this.defaultOcrTypeComboBox.TabIndex = 4;
            this.defaultOcrTypeComboBox.SelectedIndexChanged += new System.EventHandler(this.defaultOcrType_SelectedIndexChanged);
            // 
            // defaultOcrTencentCloudRadio
            // 
            this.defaultOcrTencentCloudRadio.AutoSize = true;
            this.defaultOcrTencentCloudRadio.Location = new System.Drawing.Point(91, 23);
            this.defaultOcrTencentCloudRadio.Name = "defaultOcrTencentCloudRadio";
            this.defaultOcrTencentCloudRadio.Size = new System.Drawing.Size(62, 21);
            this.defaultOcrTencentCloudRadio.TabIndex = 1;
            this.defaultOcrTencentCloudRadio.TabStop = true;
            this.defaultOcrTencentCloudRadio.Tag = "TencentCloud";
            this.defaultOcrTencentCloudRadio.Text = "腾讯云";
            this.defaultOcrTencentCloudRadio.UseVisualStyleBackColor = true;
            this.defaultOcrTencentCloudRadio.CheckedChanged += new System.EventHandler(this.commonDefaultOcrProvideType_CheckedChanged);
            // 
            // defaultOcrBaiduCloudRadio
            // 
            this.defaultOcrBaiduCloudRadio.AutoSize = true;
            this.defaultOcrBaiduCloudRadio.Location = new System.Drawing.Point(11, 23);
            this.defaultOcrBaiduCloudRadio.Name = "defaultOcrBaiduCloudRadio";
            this.defaultOcrBaiduCloudRadio.Size = new System.Drawing.Size(62, 21);
            this.defaultOcrBaiduCloudRadio.TabIndex = 0;
            this.defaultOcrBaiduCloudRadio.TabStop = true;
            this.defaultOcrBaiduCloudRadio.Tag = "BaiduCloud";
            this.defaultOcrBaiduCloudRadio.Text = "百度云";
            this.defaultOcrBaiduCloudRadio.UseVisualStyleBackColor = true;
            this.defaultOcrBaiduCloudRadio.CheckedChanged += new System.EventHandler(this.commonDefaultOcrProvideType_CheckedChanged);
            // 
            // autoStartButton
            // 
            this.autoStartButton.AutoSize = true;
            this.autoStartButton.Location = new System.Drawing.Point(17, 16);
            this.autoStartButton.Name = "autoStartButton";
            this.autoStartButton.Size = new System.Drawing.Size(75, 21);
            this.autoStartButton.TabIndex = 1;
            this.autoStartButton.Text = "开机启动";
            this.autoStartButton.UseVisualStyleBackColor = true;
            this.autoStartButton.CheckedChanged += new System.EventHandler(this.AutoStart_CheckedChanged);
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.linkLabel3);
            this.tabPage3.Controls.Add(this.baiduOcrGroupBox);
            this.tabPage3.Controls.Add(this.tencentOcrGroupBox);
            this.tabPage3.Controls.Add(this.linkLabel6);
            this.tabPage3.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tabPage3.Location = new System.Drawing.Point(4, 26);
            this.tabPage3.Margin = new System.Windows.Forms.Padding(4);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(4);
            this.tabPage3.Size = new System.Drawing.Size(471, 423);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "文字识别";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // linkLabel3
            // 
            this.linkLabel3.AutoSize = true;
            this.linkLabel3.Location = new System.Drawing.Point(272, 373);
            this.linkLabel3.Name = "linkLabel3";
            this.linkLabel3.Size = new System.Drawing.Size(142, 17);
            this.linkLabel3.TabIndex = 24;
            this.linkLabel3.TabStop = true;
            this.linkLabel3.Tag = "https://cloud.baidu.com/doc/OCR/s/fk3h7xu7h";
            this.linkLabel3.Text = "领取百度云免费OCR额度";
            this.linkLabel3.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.LinkClicked);
            // 
            // baiduOcrGroupBox
            // 
            this.baiduOcrGroupBox.Controls.Add(this.BaiduCloud_SecretKeyPasswordShowCheckbox);
            this.baiduOcrGroupBox.Controls.Add(this.BaiduCloud_APIKeyInput);
            this.baiduOcrGroupBox.Controls.Add(this.BaiduCloud_SecretKeyInput);
            this.baiduOcrGroupBox.Controls.Add(this.label7);
            this.baiduOcrGroupBox.Controls.Add(this.label8);
            this.baiduOcrGroupBox.Location = new System.Drawing.Point(7, 109);
            this.baiduOcrGroupBox.Name = "baiduOcrGroupBox";
            this.baiduOcrGroupBox.Size = new System.Drawing.Size(457, 96);
            this.baiduOcrGroupBox.TabIndex = 23;
            this.baiduOcrGroupBox.TabStop = false;
            this.baiduOcrGroupBox.Text = "百度云";
            // 
            // BaiduCloud_SecretKeyPasswordShowCheckbox
            // 
            this.BaiduCloud_SecretKeyPasswordShowCheckbox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.BaiduCloud_SecretKeyPasswordShowCheckbox.AutoSize = true;
            this.BaiduCloud_SecretKeyPasswordShowCheckbox.Location = new System.Drawing.Point(431, 59);
            this.BaiduCloud_SecretKeyPasswordShowCheckbox.Margin = new System.Windows.Forms.Padding(4);
            this.BaiduCloud_SecretKeyPasswordShowCheckbox.Name = "BaiduCloud_SecretKeyPasswordShowCheckbox";
            this.BaiduCloud_SecretKeyPasswordShowCheckbox.Size = new System.Drawing.Size(15, 14);
            this.BaiduCloud_SecretKeyPasswordShowCheckbox.TabIndex = 12;
            this.BaiduCloud_SecretKeyPasswordShowCheckbox.UseVisualStyleBackColor = true;
            this.BaiduCloud_SecretKeyPasswordShowCheckbox.CheckedChanged += new System.EventHandler(this.BaiduCloud_SecretKeyPasswordShowCheckbox_CheckedChanged);
            // 
            // BaiduCloud_APIKeyInput
            // 
            this.BaiduCloud_APIKeyInput.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.BaiduCloud_APIKeyInput.Location = new System.Drawing.Point(131, 23);
            this.BaiduCloud_APIKeyInput.Margin = new System.Windows.Forms.Padding(4);
            this.BaiduCloud_APIKeyInput.Name = "BaiduCloud_APIKeyInput";
            this.BaiduCloud_APIKeyInput.Size = new System.Drawing.Size(319, 23);
            this.BaiduCloud_APIKeyInput.TabIndex = 8;
            this.BaiduCloud_APIKeyInput.TextChanged += new System.EventHandler(this.BaiduCloud_APIKeyInput_TextChanged);
            // 
            // BaiduCloud_SecretKeyInput
            // 
            this.BaiduCloud_SecretKeyInput.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.BaiduCloud_SecretKeyInput.Location = new System.Drawing.Point(131, 54);
            this.BaiduCloud_SecretKeyInput.Margin = new System.Windows.Forms.Padding(4);
            this.BaiduCloud_SecretKeyInput.Name = "BaiduCloud_SecretKeyInput";
            this.BaiduCloud_SecretKeyInput.PasswordChar = '*';
            this.BaiduCloud_SecretKeyInput.Size = new System.Drawing.Size(319, 23);
            this.BaiduCloud_SecretKeyInput.TabIndex = 10;
            this.BaiduCloud_SecretKeyInput.TextChanged += new System.EventHandler(this.BaiduCloud_SecretKeyInput_TextChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(62, 26);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(52, 17);
            this.label7.TabIndex = 6;
            this.label7.Text = "API Key";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(45, 57);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(69, 17);
            this.label8.TabIndex = 7;
            this.label8.Text = "Secret Key";
            // 
            // tencentOcrGroupBox
            // 
            this.tencentOcrGroupBox.Controls.Add(this.TencentCloud_SecretKeyPasswordShow);
            this.tencentOcrGroupBox.Controls.Add(this.TencentCloud_SecretKeyInput);
            this.tencentOcrGroupBox.Controls.Add(this.TencentCloud_SecretIdInput);
            this.tencentOcrGroupBox.Controls.Add(this.label11);
            this.tencentOcrGroupBox.Controls.Add(this.label10);
            this.tencentOcrGroupBox.Location = new System.Drawing.Point(7, 7);
            this.tencentOcrGroupBox.Name = "tencentOcrGroupBox";
            this.tencentOcrGroupBox.Size = new System.Drawing.Size(457, 96);
            this.tencentOcrGroupBox.TabIndex = 22;
            this.tencentOcrGroupBox.TabStop = false;
            this.tencentOcrGroupBox.Text = "腾讯云";
            // 
            // TencentCloud_SecretKeyPasswordShow
            // 
            this.TencentCloud_SecretKeyPasswordShow.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TencentCloud_SecretKeyPasswordShow.AutoSize = true;
            this.TencentCloud_SecretKeyPasswordShow.Location = new System.Drawing.Point(431, 59);
            this.TencentCloud_SecretKeyPasswordShow.Margin = new System.Windows.Forms.Padding(4);
            this.TencentCloud_SecretKeyPasswordShow.Name = "TencentCloud_SecretKeyPasswordShow";
            this.TencentCloud_SecretKeyPasswordShow.Size = new System.Drawing.Size(15, 14);
            this.TencentCloud_SecretKeyPasswordShow.TabIndex = 19;
            this.TencentCloud_SecretKeyPasswordShow.UseVisualStyleBackColor = true;
            this.TencentCloud_SecretKeyPasswordShow.CheckedChanged += new System.EventHandler(this.TencentCloud_SecretKeyPasswordShow_CheckedChanged);
            // 
            // TencentCloud_SecretKeyInput
            // 
            this.TencentCloud_SecretKeyInput.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TencentCloud_SecretKeyInput.Location = new System.Drawing.Point(130, 54);
            this.TencentCloud_SecretKeyInput.Margin = new System.Windows.Forms.Padding(4);
            this.TencentCloud_SecretKeyInput.Name = "TencentCloud_SecretKeyInput";
            this.TencentCloud_SecretKeyInput.PasswordChar = '*';
            this.TencentCloud_SecretKeyInput.Size = new System.Drawing.Size(320, 23);
            this.TencentCloud_SecretKeyInput.TabIndex = 18;
            this.TencentCloud_SecretKeyInput.TextChanged += new System.EventHandler(this.TencentCloud_SecretKeyInput_TextChanged);
            // 
            // TencentCloud_SecretIdInput
            // 
            this.TencentCloud_SecretIdInput.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TencentCloud_SecretIdInput.Location = new System.Drawing.Point(130, 23);
            this.TencentCloud_SecretIdInput.Margin = new System.Windows.Forms.Padding(4);
            this.TencentCloud_SecretIdInput.Name = "TencentCloud_SecretIdInput";
            this.TencentCloud_SecretIdInput.Size = new System.Drawing.Size(320, 23);
            this.TencentCloud_SecretIdInput.TabIndex = 17;
            this.TencentCloud_SecretIdInput.TextChanged += new System.EventHandler(this.TencentCloud_SecretIdInput_TextChanged);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(53, 26);
            this.label11.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(60, 17);
            this.label11.TabIndex = 15;
            this.label11.Text = "Secret Id";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(44, 57);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(69, 17);
            this.label10.TabIndex = 16;
            this.label10.Text = "Secret Key";
            // 
            // linkLabel6
            // 
            this.linkLabel6.AutoSize = true;
            this.linkLabel6.Location = new System.Drawing.Point(45, 373);
            this.linkLabel6.Name = "linkLabel6";
            this.linkLabel6.Size = new System.Drawing.Size(142, 17);
            this.linkLabel6.TabIndex = 20;
            this.linkLabel6.TabStop = true;
            this.linkLabel6.Tag = "https://cloud.tencent.com/document/product/866/35945";
            this.linkLabel6.Text = "领取腾讯云免费OCR额度";
            this.linkLabel6.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.LinkClicked);
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.linkLabel5);
            this.tabPage2.Controls.Add(this.groupBox1);
            this.tabPage2.Controls.Add(this.groupBox2);
            this.tabPage2.Controls.Add(this.linkLabel4);
            this.tabPage2.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tabPage2.Location = new System.Drawing.Point(4, 26);
            this.tabPage2.Margin = new System.Windows.Forms.Padding(4);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(4);
            this.tabPage2.Size = new System.Drawing.Size(471, 423);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "机器翻译";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // linkLabel5
            // 
            this.linkLabel5.AutoSize = true;
            this.linkLabel5.Location = new System.Drawing.Point(45, 373);
            this.linkLabel5.Name = "linkLabel5";
            this.linkLabel5.Size = new System.Drawing.Size(140, 17);
            this.linkLabel5.TabIndex = 24;
            this.linkLabel5.TabStop = true;
            this.linkLabel5.Tag = "https://cloud.tencent.com/document/product/551/35017";
            this.linkLabel5.Text = "领取腾讯云免费翻译额度";
            this.linkLabel5.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.LinkClicked);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.TencentCloudTranslate_SecretKeyPasswordShow);
            this.groupBox1.Controls.Add(this.TencentCloudTranslate_SecretKeyInput);
            this.groupBox1.Controls.Add(this.TencentCloudTranslate_SecretIdInput);
            this.groupBox1.Controls.Add(this.label14);
            this.groupBox1.Controls.Add(this.label15);
            this.groupBox1.Location = new System.Drawing.Point(7, 7);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(457, 96);
            this.groupBox1.TabIndex = 23;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "腾讯云";
            // 
            // TencentCloudTranslate_SecretKeyPasswordShow
            // 
            this.TencentCloudTranslate_SecretKeyPasswordShow.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TencentCloudTranslate_SecretKeyPasswordShow.AutoSize = true;
            this.TencentCloudTranslate_SecretKeyPasswordShow.Location = new System.Drawing.Point(431, 59);
            this.TencentCloudTranslate_SecretKeyPasswordShow.Margin = new System.Windows.Forms.Padding(4);
            this.TencentCloudTranslate_SecretKeyPasswordShow.Name = "TencentCloudTranslate_SecretKeyPasswordShow";
            this.TencentCloudTranslate_SecretKeyPasswordShow.Size = new System.Drawing.Size(15, 14);
            this.TencentCloudTranslate_SecretKeyPasswordShow.TabIndex = 19;
            this.TencentCloudTranslate_SecretKeyPasswordShow.UseVisualStyleBackColor = true;
            this.TencentCloudTranslate_SecretKeyPasswordShow.CheckedChanged += new System.EventHandler(this.TencentCloudTranslate_SecretKeyPasswordShow_CheckedChanged);
            // 
            // TencentCloudTranslate_SecretKeyInput
            // 
            this.TencentCloudTranslate_SecretKeyInput.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TencentCloudTranslate_SecretKeyInput.Location = new System.Drawing.Point(130, 54);
            this.TencentCloudTranslate_SecretKeyInput.Margin = new System.Windows.Forms.Padding(4);
            this.TencentCloudTranslate_SecretKeyInput.Name = "TencentCloudTranslate_SecretKeyInput";
            this.TencentCloudTranslate_SecretKeyInput.PasswordChar = '*';
            this.TencentCloudTranslate_SecretKeyInput.Size = new System.Drawing.Size(320, 23);
            this.TencentCloudTranslate_SecretKeyInput.TabIndex = 18;
            this.TencentCloudTranslate_SecretKeyInput.TextChanged += new System.EventHandler(this.TencentCloudTranslate_SecretKeyInput_TextChanged);
            // 
            // TencentCloudTranslate_SecretIdInput
            // 
            this.TencentCloudTranslate_SecretIdInput.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TencentCloudTranslate_SecretIdInput.Location = new System.Drawing.Point(130, 23);
            this.TencentCloudTranslate_SecretIdInput.Margin = new System.Windows.Forms.Padding(4);
            this.TencentCloudTranslate_SecretIdInput.Name = "TencentCloudTranslate_SecretIdInput";
            this.TencentCloudTranslate_SecretIdInput.Size = new System.Drawing.Size(320, 23);
            this.TencentCloudTranslate_SecretIdInput.TabIndex = 17;
            this.TencentCloudTranslate_SecretIdInput.TextChanged += new System.EventHandler(this.TencentCloudTranslate_SecretIdInput_TextChanged);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(53, 26);
            this.label14.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(60, 17);
            this.label14.TabIndex = 15;
            this.label14.Text = "Secret Id";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(44, 57);
            this.label15.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(69, 17);
            this.label15.TabIndex = 16;
            this.label15.Text = "Secret Key";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.BaiduAI_APPSecretPasswordShowCheckbox);
            this.groupBox2.Controls.Add(this.BaiduAI_APPIDInput);
            this.groupBox2.Controls.Add(this.BaiduAI_APPSecretInput);
            this.groupBox2.Controls.Add(this.label12);
            this.groupBox2.Controls.Add(this.label13);
            this.groupBox2.Location = new System.Drawing.Point(7, 109);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(457, 96);
            this.groupBox2.TabIndex = 17;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "百度翻译开放平台";
            // 
            // BaiduAI_APPSecretPasswordShowCheckbox
            // 
            this.BaiduAI_APPSecretPasswordShowCheckbox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.BaiduAI_APPSecretPasswordShowCheckbox.AutoSize = true;
            this.BaiduAI_APPSecretPasswordShowCheckbox.Location = new System.Drawing.Point(431, 59);
            this.BaiduAI_APPSecretPasswordShowCheckbox.Margin = new System.Windows.Forms.Padding(4);
            this.BaiduAI_APPSecretPasswordShowCheckbox.Name = "BaiduAI_APPSecretPasswordShowCheckbox";
            this.BaiduAI_APPSecretPasswordShowCheckbox.Size = new System.Drawing.Size(15, 14);
            this.BaiduAI_APPSecretPasswordShowCheckbox.TabIndex = 12;
            this.BaiduAI_APPSecretPasswordShowCheckbox.UseVisualStyleBackColor = true;
            this.BaiduAI_APPSecretPasswordShowCheckbox.CheckedChanged += new System.EventHandler(this.BaiduAI_APPSecretPasswordShowCheckbox_CheckedChanged);
            // 
            // BaiduAI_APPIDInput
            // 
            this.BaiduAI_APPIDInput.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.BaiduAI_APPIDInput.Location = new System.Drawing.Point(131, 23);
            this.BaiduAI_APPIDInput.Margin = new System.Windows.Forms.Padding(4);
            this.BaiduAI_APPIDInput.Name = "BaiduAI_APPIDInput";
            this.BaiduAI_APPIDInput.Size = new System.Drawing.Size(319, 23);
            this.BaiduAI_APPIDInput.TabIndex = 8;
            this.BaiduAI_APPIDInput.TextChanged += new System.EventHandler(this.BaiduAI_APPIDInput_TextChanged);
            // 
            // BaiduAI_APPSecretInput
            // 
            this.BaiduAI_APPSecretInput.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.BaiduAI_APPSecretInput.Location = new System.Drawing.Point(131, 54);
            this.BaiduAI_APPSecretInput.Margin = new System.Windows.Forms.Padding(4);
            this.BaiduAI_APPSecretInput.Name = "BaiduAI_APPSecretInput";
            this.BaiduAI_APPSecretInput.PasswordChar = '*';
            this.BaiduAI_APPSecretInput.Size = new System.Drawing.Size(319, 23);
            this.BaiduAI_APPSecretInput.TabIndex = 10;
            this.BaiduAI_APPSecretInput.TextChanged += new System.EventHandler(this.BaiduAI_APPSecretInput_TextChanged);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(70, 26);
            this.label12.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(44, 17);
            this.label12.TabIndex = 6;
            this.label12.Text = "API ID";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(82, 57);
            this.label13.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(32, 17);
            this.label13.TabIndex = 7;
            this.label13.Text = "密钥";
            // 
            // linkLabel4
            // 
            this.linkLabel4.AutoSize = true;
            this.linkLabel4.Location = new System.Drawing.Point(272, 373);
            this.linkLabel4.Name = "linkLabel4";
            this.linkLabel4.Size = new System.Drawing.Size(152, 17);
            this.linkLabel4.TabIndex = 15;
            this.linkLabel4.TabStop = true;
            this.linkLabel4.Tag = "https://fanyi-api.baidu.com/product/113";
            this.linkLabel4.Text = "领取百度大脑免费翻译额度";
            this.linkLabel4.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.LinkClicked);
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.label16);
            this.tabPage1.Controls.Add(this.defaultHotKeysButton);
            this.tabPage1.Controls.Add(this.ScreenshotTranslateHotKeyTextBox);
            this.tabPage1.Controls.Add(this.GetWordsTranslateHotKeyTextBox);
            this.tabPage1.Controls.Add(this.ocrHotKeyTextBox);
            this.tabPage1.Controls.Add(this.label9);
            this.tabPage1.Controls.Add(this.label6);
            this.tabPage1.Controls.Add(this.label5);
            this.tabPage1.Location = new System.Drawing.Point(4, 26);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Size = new System.Drawing.Size(471, 423);
            this.tabPage1.TabIndex = 5;
            this.tabPage1.Text = "热键";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.ForeColor = System.Drawing.Color.Red;
            this.label16.Location = new System.Drawing.Point(61, 375);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(143, 17);
            this.label16.TabIndex = 7;
            this.label16.Text = "*注：请不要使用 WIN 键";
            // 
            // defaultHotKeysButton
            // 
            this.defaultHotKeysButton.Location = new System.Drawing.Point(344, 375);
            this.defaultHotKeysButton.Name = "defaultHotKeysButton";
            this.defaultHotKeysButton.Size = new System.Drawing.Size(75, 23);
            this.defaultHotKeysButton.TabIndex = 6;
            this.defaultHotKeysButton.Text = "恢复默认";
            this.defaultHotKeysButton.UseVisualStyleBackColor = true;
            this.defaultHotKeysButton.Click += new System.EventHandler(this.defaultHotKeysButton_Click);
            // 
            // ScreenshotTranslateHotKeyTextBox
            // 
            this.ScreenshotTranslateHotKeyTextBox.BackColor = System.Drawing.Color.White;
            this.ScreenshotTranslateHotKeyTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ScreenshotTranslateHotKeyTextBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.ScreenshotTranslateHotKeyTextBox.Location = new System.Drawing.Point(123, 115);
            this.ScreenshotTranslateHotKeyTextBox.Name = "ScreenshotTranslateHotKeyTextBox";
            this.ScreenshotTranslateHotKeyTextBox.ReadOnly = true;
            this.ScreenshotTranslateHotKeyTextBox.Size = new System.Drawing.Size(296, 23);
            this.ScreenshotTranslateHotKeyTextBox.TabIndex = 5;
            this.ScreenshotTranslateHotKeyTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.ScreenshotTranslateHotKeyTextBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.HotKeyTextBox_KeyDown);
            this.ScreenshotTranslateHotKeyTextBox.KeyUp += new System.Windows.Forms.KeyEventHandler(this.ScreenshotTranslateHotKeyTextBox_KeyUp);
            // 
            // GetWordsTranslateHotKeyTextBox
            // 
            this.GetWordsTranslateHotKeyTextBox.BackColor = System.Drawing.Color.White;
            this.GetWordsTranslateHotKeyTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.GetWordsTranslateHotKeyTextBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.GetWordsTranslateHotKeyTextBox.Location = new System.Drawing.Point(123, 78);
            this.GetWordsTranslateHotKeyTextBox.Name = "GetWordsTranslateHotKeyTextBox";
            this.GetWordsTranslateHotKeyTextBox.ReadOnly = true;
            this.GetWordsTranslateHotKeyTextBox.Size = new System.Drawing.Size(296, 23);
            this.GetWordsTranslateHotKeyTextBox.TabIndex = 4;
            this.GetWordsTranslateHotKeyTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.GetWordsTranslateHotKeyTextBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.HotKeyTextBox_KeyDown);
            this.GetWordsTranslateHotKeyTextBox.KeyUp += new System.Windows.Forms.KeyEventHandler(this.GetWordsTranslateHotKeyTextBox_KeyUp);
            // 
            // ocrHotKeyTextBox
            // 
            this.ocrHotKeyTextBox.BackColor = System.Drawing.Color.White;
            this.ocrHotKeyTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ocrHotKeyTextBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.ocrHotKeyTextBox.Location = new System.Drawing.Point(123, 40);
            this.ocrHotKeyTextBox.Name = "ocrHotKeyTextBox";
            this.ocrHotKeyTextBox.ReadOnly = true;
            this.ocrHotKeyTextBox.Size = new System.Drawing.Size(296, 23);
            this.ocrHotKeyTextBox.TabIndex = 3;
            this.ocrHotKeyTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.ocrHotKeyTextBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.HotKeyTextBox_KeyDown);
            this.ocrHotKeyTextBox.KeyUp += new System.Windows.Forms.KeyEventHandler(this.ocrHotKeyTextBox_KeyUp);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(61, 117);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(56, 17);
            this.label9.TabIndex = 2;
            this.label9.Text = "截图翻译";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(61, 80);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(56, 17);
            this.label6.TabIndex = 1;
            this.label6.Text = "划词翻译";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(61, 42);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(56, 17);
            this.label5.TabIndex = 0;
            this.label5.Text = "文字识别";
            // 
            // tabPage4
            // 
            this.tabPage4.Controls.Add(this.emailLink);
            this.tabPage4.Controls.Add(this.label4);
            this.tabPage4.Controls.Add(this.linkLabel1);
            this.tabPage4.Controls.Add(this.label3);
            this.tabPage4.Controls.Add(this.label2);
            this.tabPage4.Controls.Add(this.label1);
            this.tabPage4.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tabPage4.Location = new System.Drawing.Point(4, 26);
            this.tabPage4.Margin = new System.Windows.Forms.Padding(4);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Padding = new System.Windows.Forms.Padding(4);
            this.tabPage4.Size = new System.Drawing.Size(471, 423);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "关于";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // emailLink
            // 
            this.emailLink.AutoSize = true;
            this.emailLink.Location = new System.Drawing.Point(68, 154);
            this.emailLink.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.emailLink.Name = "emailLink";
            this.emailLink.Size = new System.Drawing.Size(154, 17);
            this.emailLink.TabIndex = 5;
            this.emailLink.TabStop = true;
            this.emailLink.Text = "chenyongli0520@qq.com";
            this.emailLink.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.emailLink_LinkClicked);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(21, 154);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(45, 17);
            this.label4.TabIndex = 4;
            this.label4.Text = "反馈 - ";
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Location = new System.Drawing.Point(68, 113);
            this.linkLabel1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(286, 17);
            this.linkLabel1.TabIndex = 3;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Tag = "https://github.com/NPCDW/WindowsFormsOCR";
            this.linkLabel1.Text = "https://github.com/NPCDW/WindowsFormsOCR";
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.LinkClicked);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(21, 113);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(45, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "源码 - ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label2.Location = new System.Drawing.Point(21, 74);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(193, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "版权所有 © 2022-至今 0520.com";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point(21, 35);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(123, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "版本 1.3.1 (2022.4.9)";
            // 
            // SettingForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(479, 453);
            this.Controls.Add(this.tabControl1);
            this.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "SettingForm";
            this.Text = "设置";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.SettingForm_FormClosed);
            this.Load += new System.EventHandler(this.Setting_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage5.ResumeLayout(false);
            this.tabPage5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.wordSelectionIntervalBox)).EndInit();
            this.defaultTranslateProvide.ResumeLayout(false);
            this.defaultTranslateProvide.PerformLayout();
            this.defaultOcrProvideGroupBox.ResumeLayout(false);
            this.defaultOcrProvideGroupBox.PerformLayout();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            this.baiduOcrGroupBox.ResumeLayout(false);
            this.baiduOcrGroupBox.PerformLayout();
            this.tencentOcrGroupBox.ResumeLayout(false);
            this.tencentOcrGroupBox.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage4.ResumeLayout(false);
            this.tabPage4.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.LinkLabel emailLink;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox TencentCloud_SecretKeyPasswordShow;
        private System.Windows.Forms.TextBox TencentCloud_SecretKeyInput;
        private System.Windows.Forms.TextBox TencentCloud_SecretIdInput;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TabPage tabPage5;
        private System.Windows.Forms.CheckBox autoStartButton;
        private System.Windows.Forms.LinkLabel linkLabel6;
        private System.Windows.Forms.LinkLabel linkLabel4;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.CheckBox BaiduAI_APPSecretPasswordShowCheckbox;
        private System.Windows.Forms.TextBox BaiduAI_APPIDInput;
        private System.Windows.Forms.TextBox BaiduAI_APPSecretInput;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.GroupBox tencentOcrGroupBox;
        private System.Windows.Forms.GroupBox defaultTranslateProvide;
        private System.Windows.Forms.RadioButton defaultTranslateTencentCloudRadio;
        private System.Windows.Forms.RadioButton defaultTranslateBaiduAIRadio;
        private System.Windows.Forms.GroupBox defaultOcrProvideGroupBox;
        private System.Windows.Forms.RadioButton defaultOcrTencentCloudRadio;
        private System.Windows.Forms.RadioButton defaultOcrBaiduCloudRadio;
        private System.Windows.Forms.LinkLabel linkLabel3;
        private System.Windows.Forms.GroupBox baiduOcrGroupBox;
        private System.Windows.Forms.CheckBox BaiduCloud_SecretKeyPasswordShowCheckbox;
        private System.Windows.Forms.TextBox BaiduCloud_APIKeyInput;
        private System.Windows.Forms.TextBox BaiduCloud_SecretKeyInput;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.LinkLabel linkLabel5;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.CheckBox TencentCloudTranslate_SecretKeyPasswordShow;
        private System.Windows.Forms.TextBox TencentCloudTranslate_SecretKeyInput;
        private System.Windows.Forms.TextBox TencentCloudTranslate_SecretIdInput;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.ComboBox defaultOcrTypeComboBox;
        private System.Windows.Forms.ComboBox targetLanguageComboBox;
        private System.Windows.Forms.ComboBox sourceLanguageComboBox;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TextBox ocrHotKeyTextBox;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button defaultHotKeysButton;
        private System.Windows.Forms.TextBox ScreenshotTranslateHotKeyTextBox;
        private System.Windows.Forms.TextBox GetWordsTranslateHotKeyTextBox;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.NumericUpDown wordSelectionIntervalBox;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label18;
    }
}