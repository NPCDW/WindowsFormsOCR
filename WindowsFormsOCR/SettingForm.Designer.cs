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
            this.defaultTranslateProvide = new System.Windows.Forms.GroupBox();
            this.radioButton9 = new System.Windows.Forms.RadioButton();
            this.radioButton10 = new System.Windows.Forms.RadioButton();
            this.defaultOcrProvideGroupBox = new System.Windows.Forms.GroupBox();
            this.radioButton8 = new System.Windows.Forms.RadioButton();
            this.radioButton7 = new System.Windows.Forms.RadioButton();
            this.autoStartButton = new System.Windows.Forms.CheckBox();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.tencentOcrGroupBox = new System.Windows.Forms.GroupBox();
            this.label9 = new System.Windows.Forms.Label();
            this.radioButton6 = new System.Windows.Forms.RadioButton();
            this.radioButton4 = new System.Windows.Forms.RadioButton();
            this.TencentCloud_SecretKeyPasswordShow = new System.Windows.Forms.CheckBox();
            this.radioButton5 = new System.Windows.Forms.RadioButton();
            this.TencentCloud_SecretKeyInput = new System.Windows.Forms.TextBox();
            this.TencentCloud_SecretIdInput = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.linkLabel5 = new System.Windows.Forms.LinkLabel();
            this.linkLabel6 = new System.Windows.Forms.LinkLabel();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.BaiduAI_APPSecretPasswordShowCheckbox = new System.Windows.Forms.CheckBox();
            this.BaiduAI_APPIDInput = new System.Windows.Forms.TextBox();
            this.BaiduAI_APPSecretInput = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.baiduOcrGroupBox = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.radioButton3 = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.BaiduCloud_SecretKeyPasswordShowCheckbox = new System.Windows.Forms.CheckBox();
            this.BaiduCloud_APIKeyInput = new System.Windows.Forms.TextBox();
            this.BaiduCloud_SecretKeyInput = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.linkLabel4 = new System.Windows.Forms.LinkLabel();
            this.linkLabel3 = new System.Windows.Forms.LinkLabel();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.linkLabel2 = new System.Windows.Forms.LinkLabel();
            this.label4 = new System.Windows.Forms.Label();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tabControl1.SuspendLayout();
            this.tabPage5.SuspendLayout();
            this.defaultTranslateProvide.SuspendLayout();
            this.defaultOcrProvideGroupBox.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.tencentOcrGroupBox.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.baiduOcrGroupBox.SuspendLayout();
            this.tabPage4.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage5);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage4);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
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
            // defaultTranslateProvide
            // 
            this.defaultTranslateProvide.Controls.Add(this.radioButton9);
            this.defaultTranslateProvide.Controls.Add(this.radioButton10);
            this.defaultTranslateProvide.Location = new System.Drawing.Point(6, 115);
            this.defaultTranslateProvide.Name = "defaultTranslateProvide";
            this.defaultTranslateProvide.Size = new System.Drawing.Size(459, 57);
            this.defaultTranslateProvide.TabIndex = 3;
            this.defaultTranslateProvide.TabStop = false;
            this.defaultTranslateProvide.Text = "默认翻译";
            // 
            // radioButton9
            // 
            this.radioButton9.AutoSize = true;
            this.radioButton9.Location = new System.Drawing.Point(119, 22);
            this.radioButton9.Name = "radioButton9";
            this.radioButton9.Size = new System.Drawing.Size(62, 21);
            this.radioButton9.TabIndex = 1;
            this.radioButton9.TabStop = true;
            this.radioButton9.Tag = "TencentCloud";
            this.radioButton9.Text = "腾讯云";
            this.radioButton9.UseVisualStyleBackColor = true;
            this.radioButton9.CheckedChanged += new System.EventHandler(this.commonDefaultTranslateProvideType_CheckedChanged);
            // 
            // radioButton10
            // 
            this.radioButton10.AutoSize = true;
            this.radioButton10.Location = new System.Drawing.Point(11, 23);
            this.radioButton10.Name = "radioButton10";
            this.radioButton10.Size = new System.Drawing.Size(74, 21);
            this.radioButton10.TabIndex = 0;
            this.radioButton10.TabStop = true;
            this.radioButton10.Tag = "BaiduAI";
            this.radioButton10.Text = "百度大脑";
            this.radioButton10.UseVisualStyleBackColor = true;
            this.radioButton10.CheckedChanged += new System.EventHandler(this.commonDefaultTranslateProvideType_CheckedChanged);
            // 
            // defaultOcrProvideGroupBox
            // 
            this.defaultOcrProvideGroupBox.Controls.Add(this.radioButton8);
            this.defaultOcrProvideGroupBox.Controls.Add(this.radioButton7);
            this.defaultOcrProvideGroupBox.Location = new System.Drawing.Point(6, 52);
            this.defaultOcrProvideGroupBox.Name = "defaultOcrProvideGroupBox";
            this.defaultOcrProvideGroupBox.Size = new System.Drawing.Size(459, 57);
            this.defaultOcrProvideGroupBox.TabIndex = 2;
            this.defaultOcrProvideGroupBox.TabStop = false;
            this.defaultOcrProvideGroupBox.Text = "默认OCR";
            // 
            // radioButton8
            // 
            this.radioButton8.AutoSize = true;
            this.radioButton8.Location = new System.Drawing.Point(119, 22);
            this.radioButton8.Name = "radioButton8";
            this.radioButton8.Size = new System.Drawing.Size(62, 21);
            this.radioButton8.TabIndex = 1;
            this.radioButton8.TabStop = true;
            this.radioButton8.Tag = "TencentCloud";
            this.radioButton8.Text = "腾讯云";
            this.radioButton8.UseVisualStyleBackColor = true;
            this.radioButton8.CheckedChanged += new System.EventHandler(this.commonDefaultOcrProvideType_CheckedChanged);
            // 
            // radioButton7
            // 
            this.radioButton7.AutoSize = true;
            this.radioButton7.Location = new System.Drawing.Point(11, 23);
            this.radioButton7.Name = "radioButton7";
            this.radioButton7.Size = new System.Drawing.Size(62, 21);
            this.radioButton7.TabIndex = 0;
            this.radioButton7.TabStop = true;
            this.radioButton7.Tag = "BaiduCloud";
            this.radioButton7.Text = "百度云";
            this.radioButton7.UseVisualStyleBackColor = true;
            this.radioButton7.CheckedChanged += new System.EventHandler(this.commonDefaultOcrProvideType_CheckedChanged);
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
            this.tabPage3.Controls.Add(this.tencentOcrGroupBox);
            this.tabPage3.Controls.Add(this.linkLabel5);
            this.tabPage3.Controls.Add(this.linkLabel6);
            this.tabPage3.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tabPage3.Location = new System.Drawing.Point(4, 26);
            this.tabPage3.Margin = new System.Windows.Forms.Padding(4);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(4);
            this.tabPage3.Size = new System.Drawing.Size(471, 423);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "腾讯云";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // tencentOcrGroupBox
            // 
            this.tencentOcrGroupBox.Controls.Add(this.label9);
            this.tencentOcrGroupBox.Controls.Add(this.radioButton6);
            this.tencentOcrGroupBox.Controls.Add(this.radioButton4);
            this.tencentOcrGroupBox.Controls.Add(this.TencentCloud_SecretKeyPasswordShow);
            this.tencentOcrGroupBox.Controls.Add(this.radioButton5);
            this.tencentOcrGroupBox.Controls.Add(this.TencentCloud_SecretKeyInput);
            this.tencentOcrGroupBox.Controls.Add(this.TencentCloud_SecretIdInput);
            this.tencentOcrGroupBox.Controls.Add(this.label11);
            this.tencentOcrGroupBox.Controls.Add(this.label10);
            this.tencentOcrGroupBox.Location = new System.Drawing.Point(7, 7);
            this.tencentOcrGroupBox.Name = "tencentOcrGroupBox";
            this.tencentOcrGroupBox.Size = new System.Drawing.Size(457, 162);
            this.tencentOcrGroupBox.TabIndex = 22;
            this.tencentOcrGroupBox.TabStop = false;
            this.tencentOcrGroupBox.Text = "腾讯云 - 免费OCR/免费翻译";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(49, 30);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(58, 17);
            this.label9.TabIndex = 0;
            this.label9.Text = "OCR类型";
            // 
            // radioButton6
            // 
            this.radioButton6.AutoSize = true;
            this.radioButton6.Location = new System.Drawing.Point(268, 28);
            this.radioButton6.Margin = new System.Windows.Forms.Padding(4);
            this.radioButton6.Name = "radioButton6";
            this.radioButton6.Size = new System.Drawing.Size(62, 21);
            this.radioButton6.TabIndex = 3;
            this.radioButton6.TabStop = true;
            this.radioButton6.Tag = "GeneralHandwritingOCR";
            this.radioButton6.Text = "手写体";
            this.radioButton6.UseVisualStyleBackColor = true;
            this.radioButton6.CheckedChanged += new System.EventHandler(this.TencentCloudType_CheckedChanged);
            // 
            // radioButton4
            // 
            this.radioButton4.AutoSize = true;
            this.radioButton4.Location = new System.Drawing.Point(124, 28);
            this.radioButton4.Margin = new System.Windows.Forms.Padding(4);
            this.radioButton4.Name = "radioButton4";
            this.radioButton4.Size = new System.Drawing.Size(50, 21);
            this.radioButton4.TabIndex = 1;
            this.radioButton4.TabStop = true;
            this.radioButton4.Tag = "GeneralBasicOCR";
            this.radioButton4.Text = "通用";
            this.radioButton4.UseVisualStyleBackColor = true;
            this.radioButton4.CheckedChanged += new System.EventHandler(this.TencentCloudType_CheckedChanged);
            // 
            // TencentCloud_SecretKeyPasswordShow
            // 
            this.TencentCloud_SecretKeyPasswordShow.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TencentCloud_SecretKeyPasswordShow.AutoSize = true;
            this.TencentCloud_SecretKeyPasswordShow.Location = new System.Drawing.Point(425, 118);
            this.TencentCloud_SecretKeyPasswordShow.Margin = new System.Windows.Forms.Padding(4);
            this.TencentCloud_SecretKeyPasswordShow.Name = "TencentCloud_SecretKeyPasswordShow";
            this.TencentCloud_SecretKeyPasswordShow.Size = new System.Drawing.Size(15, 14);
            this.TencentCloud_SecretKeyPasswordShow.TabIndex = 19;
            this.TencentCloud_SecretKeyPasswordShow.UseVisualStyleBackColor = true;
            this.TencentCloud_SecretKeyPasswordShow.CheckedChanged += new System.EventHandler(this.TencentCloud_SecretKeyPasswordShow_CheckedChanged);
            // 
            // radioButton5
            // 
            this.radioButton5.AutoSize = true;
            this.radioButton5.Location = new System.Drawing.Point(189, 28);
            this.radioButton5.Margin = new System.Windows.Forms.Padding(4);
            this.radioButton5.Name = "radioButton5";
            this.radioButton5.Size = new System.Drawing.Size(62, 21);
            this.radioButton5.TabIndex = 2;
            this.radioButton5.TabStop = true;
            this.radioButton5.Tag = "GeneralAccurateOCR";
            this.radioButton5.Text = "高精度";
            this.radioButton5.UseVisualStyleBackColor = true;
            this.radioButton5.CheckedChanged += new System.EventHandler(this.TencentCloudType_CheckedChanged);
            // 
            // TencentCloud_SecretKeyInput
            // 
            this.TencentCloud_SecretKeyInput.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TencentCloud_SecretKeyInput.Location = new System.Drawing.Point(124, 114);
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
            this.TencentCloud_SecretIdInput.Location = new System.Drawing.Point(124, 67);
            this.TencentCloud_SecretIdInput.Margin = new System.Windows.Forms.Padding(4);
            this.TencentCloud_SecretIdInput.Name = "TencentCloud_SecretIdInput";
            this.TencentCloud_SecretIdInput.Size = new System.Drawing.Size(320, 23);
            this.TencentCloud_SecretIdInput.TabIndex = 17;
            this.TencentCloud_SecretIdInput.TextChanged += new System.EventHandler(this.TencentCloud_SecretIdInput_TextChanged);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(47, 70);
            this.label11.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(60, 17);
            this.label11.TabIndex = 15;
            this.label11.Text = "Secret Id";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(38, 117);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(69, 17);
            this.label10.TabIndex = 16;
            this.label10.Text = "Secret Key";
            // 
            // linkLabel5
            // 
            this.linkLabel5.AutoSize = true;
            this.linkLabel5.Location = new System.Drawing.Point(283, 373);
            this.linkLabel5.Name = "linkLabel5";
            this.linkLabel5.Size = new System.Drawing.Size(140, 17);
            this.linkLabel5.TabIndex = 21;
            this.linkLabel5.TabStop = true;
            this.linkLabel5.Tag = "https://cloud.tencent.com/document/product/551/35017";
            this.linkLabel5.Text = "领取腾讯云免费翻译额度";
            this.linkLabel5.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.LinkClicked);
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
            this.tabPage2.Controls.Add(this.groupBox2);
            this.tabPage2.Controls.Add(this.baiduOcrGroupBox);
            this.tabPage2.Controls.Add(this.linkLabel4);
            this.tabPage2.Controls.Add(this.linkLabel3);
            this.tabPage2.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tabPage2.Location = new System.Drawing.Point(4, 26);
            this.tabPage2.Margin = new System.Windows.Forms.Padding(4);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(4);
            this.tabPage2.Size = new System.Drawing.Size(471, 423);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "百度云";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.BaiduAI_APPSecretPasswordShowCheckbox);
            this.groupBox2.Controls.Add(this.BaiduAI_APPIDInput);
            this.groupBox2.Controls.Add(this.BaiduAI_APPSecretInput);
            this.groupBox2.Controls.Add(this.label12);
            this.groupBox2.Controls.Add(this.label13);
            this.groupBox2.Location = new System.Drawing.Point(7, 175);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(457, 130);
            this.groupBox2.TabIndex = 17;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "百度大脑 - 免费翻译";
            // 
            // BaiduAI_APPSecretPasswordShowCheckbox
            // 
            this.BaiduAI_APPSecretPasswordShowCheckbox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.BaiduAI_APPSecretPasswordShowCheckbox.AutoSize = true;
            this.BaiduAI_APPSecretPasswordShowCheckbox.Location = new System.Drawing.Point(424, 83);
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
            this.BaiduAI_APPIDInput.Location = new System.Drawing.Point(124, 31);
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
            this.BaiduAI_APPSecretInput.Location = new System.Drawing.Point(124, 78);
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
            this.label12.Location = new System.Drawing.Point(63, 34);
            this.label12.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(44, 17);
            this.label12.TabIndex = 6;
            this.label12.Text = "API ID";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(75, 81);
            this.label13.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(32, 17);
            this.label13.TabIndex = 7;
            this.label13.Text = "密钥";
            // 
            // baiduOcrGroupBox
            // 
            this.baiduOcrGroupBox.Controls.Add(this.label5);
            this.baiduOcrGroupBox.Controls.Add(this.radioButton1);
            this.baiduOcrGroupBox.Controls.Add(this.radioButton3);
            this.baiduOcrGroupBox.Controls.Add(this.radioButton2);
            this.baiduOcrGroupBox.Controls.Add(this.BaiduCloud_SecretKeyPasswordShowCheckbox);
            this.baiduOcrGroupBox.Controls.Add(this.BaiduCloud_APIKeyInput);
            this.baiduOcrGroupBox.Controls.Add(this.BaiduCloud_SecretKeyInput);
            this.baiduOcrGroupBox.Controls.Add(this.label7);
            this.baiduOcrGroupBox.Controls.Add(this.label8);
            this.baiduOcrGroupBox.Location = new System.Drawing.Point(7, 7);
            this.baiduOcrGroupBox.Name = "baiduOcrGroupBox";
            this.baiduOcrGroupBox.Size = new System.Drawing.Size(457, 162);
            this.baiduOcrGroupBox.TabIndex = 16;
            this.baiduOcrGroupBox.TabStop = false;
            this.baiduOcrGroupBox.Text = "百度云 - 免费OCR";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(49, 30);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(58, 17);
            this.label5.TabIndex = 0;
            this.label5.Text = "OCR类型";
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Location = new System.Drawing.Point(124, 28);
            this.radioButton1.Margin = new System.Windows.Forms.Padding(4);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(50, 21);
            this.radioButton1.TabIndex = 1;
            this.radioButton1.TabStop = true;
            this.radioButton1.Tag = "general_basic";
            this.radioButton1.Text = "通用";
            this.radioButton1.UseVisualStyleBackColor = true;
            this.radioButton1.CheckedChanged += new System.EventHandler(this.baiduCloudType_CheckedChanged);
            // 
            // radioButton3
            // 
            this.radioButton3.AutoSize = true;
            this.radioButton3.Location = new System.Drawing.Point(268, 28);
            this.radioButton3.Margin = new System.Windows.Forms.Padding(4);
            this.radioButton3.Name = "radioButton3";
            this.radioButton3.Size = new System.Drawing.Size(62, 21);
            this.radioButton3.TabIndex = 3;
            this.radioButton3.TabStop = true;
            this.radioButton3.Tag = "handwriting";
            this.radioButton3.Text = "手写体";
            this.radioButton3.UseVisualStyleBackColor = true;
            this.radioButton3.CheckedChanged += new System.EventHandler(this.baiduCloudType_CheckedChanged);
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(189, 28);
            this.radioButton2.Margin = new System.Windows.Forms.Padding(4);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(62, 21);
            this.radioButton2.TabIndex = 2;
            this.radioButton2.TabStop = true;
            this.radioButton2.Tag = "accurate_basic";
            this.radioButton2.Text = "高精度";
            this.radioButton2.UseVisualStyleBackColor = true;
            this.radioButton2.CheckedChanged += new System.EventHandler(this.baiduCloudType_CheckedChanged);
            // 
            // BaiduCloud_SecretKeyPasswordShowCheckbox
            // 
            this.BaiduCloud_SecretKeyPasswordShowCheckbox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.BaiduCloud_SecretKeyPasswordShowCheckbox.AutoSize = true;
            this.BaiduCloud_SecretKeyPasswordShowCheckbox.Location = new System.Drawing.Point(424, 119);
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
            this.BaiduCloud_APIKeyInput.Location = new System.Drawing.Point(124, 67);
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
            this.BaiduCloud_SecretKeyInput.Location = new System.Drawing.Point(124, 114);
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
            this.label7.Location = new System.Drawing.Point(55, 70);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(52, 17);
            this.label7.TabIndex = 6;
            this.label7.Text = "API Key";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(38, 117);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(69, 17);
            this.label8.TabIndex = 7;
            this.label8.Text = "Secret Key";
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
            // linkLabel3
            // 
            this.linkLabel3.AutoSize = true;
            this.linkLabel3.Location = new System.Drawing.Point(45, 373);
            this.linkLabel3.Name = "linkLabel3";
            this.linkLabel3.Size = new System.Drawing.Size(142, 17);
            this.linkLabel3.TabIndex = 14;
            this.linkLabel3.TabStop = true;
            this.linkLabel3.Tag = "https://cloud.baidu.com/doc/OCR/s/fk3h7xu7h";
            this.linkLabel3.Text = "领取百度云免费OCR额度";
            this.linkLabel3.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.LinkClicked);
            // 
            // tabPage4
            // 
            this.tabPage4.Controls.Add(this.linkLabel2);
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
            // linkLabel2
            // 
            this.linkLabel2.AutoSize = true;
            this.linkLabel2.Location = new System.Drawing.Point(68, 154);
            this.linkLabel2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.linkLabel2.Name = "linkLabel2";
            this.linkLabel2.Size = new System.Drawing.Size(154, 17);
            this.linkLabel2.TabIndex = 5;
            this.linkLabel2.TabStop = true;
            this.linkLabel2.Text = "chenyongli0520@qq.com";
            this.linkLabel2.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel2_LinkClicked);
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
            this.label1.Size = new System.Drawing.Size(130, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "版本 1.0.0 (2022.1.16)";
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
            this.defaultTranslateProvide.ResumeLayout(false);
            this.defaultTranslateProvide.PerformLayout();
            this.defaultOcrProvideGroupBox.ResumeLayout(false);
            this.defaultOcrProvideGroupBox.PerformLayout();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            this.tencentOcrGroupBox.ResumeLayout(false);
            this.tencentOcrGroupBox.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.baiduOcrGroupBox.ResumeLayout(false);
            this.baiduOcrGroupBox.PerformLayout();
            this.tabPage4.ResumeLayout(false);
            this.tabPage4.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.TextBox BaiduCloud_APIKeyInput;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.RadioButton radioButton3;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.LinkLabel linkLabel2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox BaiduCloud_SecretKeyPasswordShowCheckbox;
        private System.Windows.Forms.TextBox BaiduCloud_SecretKeyInput;
        private System.Windows.Forms.CheckBox TencentCloud_SecretKeyPasswordShow;
        private System.Windows.Forms.TextBox TencentCloud_SecretKeyInput;
        private System.Windows.Forms.TextBox TencentCloud_SecretIdInput;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.RadioButton radioButton4;
        private System.Windows.Forms.RadioButton radioButton5;
        private System.Windows.Forms.RadioButton radioButton6;
        private System.Windows.Forms.TabPage tabPage5;
        private System.Windows.Forms.CheckBox autoStartButton;
        private System.Windows.Forms.LinkLabel linkLabel5;
        private System.Windows.Forms.LinkLabel linkLabel6;
        private System.Windows.Forms.LinkLabel linkLabel4;
        private System.Windows.Forms.LinkLabel linkLabel3;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.CheckBox BaiduAI_APPSecretPasswordShowCheckbox;
        private System.Windows.Forms.TextBox BaiduAI_APPIDInput;
        private System.Windows.Forms.TextBox BaiduAI_APPSecretInput;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.GroupBox baiduOcrGroupBox;
        private System.Windows.Forms.GroupBox tencentOcrGroupBox;
        private System.Windows.Forms.GroupBox defaultTranslateProvide;
        private System.Windows.Forms.RadioButton radioButton9;
        private System.Windows.Forms.RadioButton radioButton10;
        private System.Windows.Forms.GroupBox defaultOcrProvideGroupBox;
        private System.Windows.Forms.RadioButton radioButton8;
        private System.Windows.Forms.RadioButton radioButton7;
    }
}