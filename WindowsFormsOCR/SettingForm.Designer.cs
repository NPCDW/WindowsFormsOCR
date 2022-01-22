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
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.baiduTypePanel = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.radioButton3 = new System.Windows.Forms.RadioButton();
            this.BaiduCloud_SecretKeyPasswordShowCheckbox = new System.Windows.Forms.CheckBox();
            this.BaiduCloud_AccessTokenPasswordShowCheckbox = new System.Windows.Forms.CheckBox();
            this.BaiduCloud_SecretKeyInput = new System.Windows.Forms.TextBox();
            this.BaiduCloud_AccessTokenInput = new System.Windows.Forms.TextBox();
            this.BaiduCloud_APIKeyInput = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.TencentCloud_SecretKeyPasswordShow = new System.Windows.Forms.CheckBox();
            this.TencentCloud_SecretKeyInput = new System.Windows.Forms.TextBox();
            this.TencentCloud_SecretIdInput = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.tencentTypePanel = new System.Windows.Forms.Panel();
            this.label9 = new System.Windows.Forms.Label();
            this.radioButton4 = new System.Windows.Forms.RadioButton();
            this.radioButton5 = new System.Windows.Forms.RadioButton();
            this.radioButton6 = new System.Windows.Forms.RadioButton();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.linkLabel2 = new System.Windows.Forms.LinkLabel();
            this.label4 = new System.Windows.Forms.Label();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tabControl1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.baiduTypePanel.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.tencentTypePanel.SuspendLayout();
            this.tabPage4.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
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
            // tabPage1
            // 
            this.tabPage1.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tabPage1.Location = new System.Drawing.Point(4, 26);
            this.tabPage1.Margin = new System.Windows.Forms.Padding(4);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(4);
            this.tabPage1.Size = new System.Drawing.Size(471, 423);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "本地识别";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.baiduTypePanel);
            this.tabPage2.Controls.Add(this.BaiduCloud_SecretKeyPasswordShowCheckbox);
            this.tabPage2.Controls.Add(this.BaiduCloud_AccessTokenPasswordShowCheckbox);
            this.tabPage2.Controls.Add(this.BaiduCloud_SecretKeyInput);
            this.tabPage2.Controls.Add(this.BaiduCloud_AccessTokenInput);
            this.tabPage2.Controls.Add(this.BaiduCloud_APIKeyInput);
            this.tabPage2.Controls.Add(this.label8);
            this.tabPage2.Controls.Add(this.label7);
            this.tabPage2.Controls.Add(this.label6);
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
            // baiduTypePanel
            // 
            this.baiduTypePanel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.baiduTypePanel.Controls.Add(this.label5);
            this.baiduTypePanel.Controls.Add(this.radioButton1);
            this.baiduTypePanel.Controls.Add(this.radioButton2);
            this.baiduTypePanel.Controls.Add(this.radioButton3);
            this.baiduTypePanel.Location = new System.Drawing.Point(8, 25);
            this.baiduTypePanel.Margin = new System.Windows.Forms.Padding(4);
            this.baiduTypePanel.Name = "baiduTypePanel";
            this.baiduTypePanel.Size = new System.Drawing.Size(453, 29);
            this.baiduTypePanel.TabIndex = 13;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(50, 7);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(56, 17);
            this.label5.TabIndex = 0;
            this.label5.Text = "识别类型";
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Location = new System.Drawing.Point(123, 4);
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
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(188, 4);
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
            // radioButton3
            // 
            this.radioButton3.AutoSize = true;
            this.radioButton3.Location = new System.Drawing.Point(267, 4);
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
            // BaiduCloud_SecretKeyPasswordShowCheckbox
            // 
            this.BaiduCloud_SecretKeyPasswordShowCheckbox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.BaiduCloud_SecretKeyPasswordShowCheckbox.AutoSize = true;
            this.BaiduCloud_SecretKeyPasswordShowCheckbox.Location = new System.Drawing.Point(431, 171);
            this.BaiduCloud_SecretKeyPasswordShowCheckbox.Margin = new System.Windows.Forms.Padding(4);
            this.BaiduCloud_SecretKeyPasswordShowCheckbox.Name = "BaiduCloud_SecretKeyPasswordShowCheckbox";
            this.BaiduCloud_SecretKeyPasswordShowCheckbox.Size = new System.Drawing.Size(15, 14);
            this.BaiduCloud_SecretKeyPasswordShowCheckbox.TabIndex = 12;
            this.BaiduCloud_SecretKeyPasswordShowCheckbox.UseVisualStyleBackColor = true;
            this.BaiduCloud_SecretKeyPasswordShowCheckbox.CheckedChanged += new System.EventHandler(this.BaiduCloud_SecretKeyPasswordShowCheckbox_CheckedChanged);
            // 
            // BaiduCloud_AccessTokenPasswordShowCheckbox
            // 
            this.BaiduCloud_AccessTokenPasswordShowCheckbox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.BaiduCloud_AccessTokenPasswordShowCheckbox.AutoSize = true;
            this.BaiduCloud_AccessTokenPasswordShowCheckbox.Location = new System.Drawing.Point(431, 80);
            this.BaiduCloud_AccessTokenPasswordShowCheckbox.Margin = new System.Windows.Forms.Padding(4);
            this.BaiduCloud_AccessTokenPasswordShowCheckbox.Name = "BaiduCloud_AccessTokenPasswordShowCheckbox";
            this.BaiduCloud_AccessTokenPasswordShowCheckbox.Size = new System.Drawing.Size(15, 14);
            this.BaiduCloud_AccessTokenPasswordShowCheckbox.TabIndex = 11;
            this.BaiduCloud_AccessTokenPasswordShowCheckbox.UseVisualStyleBackColor = true;
            this.BaiduCloud_AccessTokenPasswordShowCheckbox.CheckedChanged += new System.EventHandler(this.BaiduCloud_AccessTokenPasswordShowCheckbox_CheckedChanged);
            // 
            // BaiduCloud_SecretKeyInput
            // 
            this.BaiduCloud_SecretKeyInput.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.BaiduCloud_SecretKeyInput.Location = new System.Drawing.Point(131, 166);
            this.BaiduCloud_SecretKeyInput.Margin = new System.Windows.Forms.Padding(4);
            this.BaiduCloud_SecretKeyInput.Name = "BaiduCloud_SecretKeyInput";
            this.BaiduCloud_SecretKeyInput.PasswordChar = '*';
            this.BaiduCloud_SecretKeyInput.Size = new System.Drawing.Size(319, 23);
            this.BaiduCloud_SecretKeyInput.TabIndex = 10;
            this.BaiduCloud_SecretKeyInput.TextChanged += new System.EventHandler(this.BaiduCloud_SecretKeyInput_TextChanged);
            // 
            // BaiduCloud_AccessTokenInput
            // 
            this.BaiduCloud_AccessTokenInput.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.BaiduCloud_AccessTokenInput.Location = new System.Drawing.Point(131, 75);
            this.BaiduCloud_AccessTokenInput.Margin = new System.Windows.Forms.Padding(4);
            this.BaiduCloud_AccessTokenInput.Name = "BaiduCloud_AccessTokenInput";
            this.BaiduCloud_AccessTokenInput.PasswordChar = '*';
            this.BaiduCloud_AccessTokenInput.Size = new System.Drawing.Size(319, 23);
            this.BaiduCloud_AccessTokenInput.TabIndex = 9;
            this.BaiduCloud_AccessTokenInput.TextChanged += new System.EventHandler(this.BaiduCloud_AccessTokenInput_TextChanged);
            // 
            // BaiduCloud_APIKeyInput
            // 
            this.BaiduCloud_APIKeyInput.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.BaiduCloud_APIKeyInput.Location = new System.Drawing.Point(131, 119);
            this.BaiduCloud_APIKeyInput.Margin = new System.Windows.Forms.Padding(4);
            this.BaiduCloud_APIKeyInput.Name = "BaiduCloud_APIKeyInput";
            this.BaiduCloud_APIKeyInput.Size = new System.Drawing.Size(319, 23);
            this.BaiduCloud_APIKeyInput.TabIndex = 8;
            this.BaiduCloud_APIKeyInput.TextChanged += new System.EventHandler(this.BaiduCloud_APIKeyInput_TextChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(45, 168);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(69, 17);
            this.label8.TabIndex = 7;
            this.label8.Text = "Secret Key";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(62, 122);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(52, 17);
            this.label7.TabIndex = 6;
            this.label7.Text = "API Key";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(27, 78);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(87, 17);
            this.label6.TabIndex = 4;
            this.label6.Text = "Access Token";
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.TencentCloud_SecretKeyPasswordShow);
            this.tabPage3.Controls.Add(this.TencentCloud_SecretKeyInput);
            this.tabPage3.Controls.Add(this.TencentCloud_SecretIdInput);
            this.tabPage3.Controls.Add(this.label10);
            this.tabPage3.Controls.Add(this.label11);
            this.tabPage3.Controls.Add(this.tencentTypePanel);
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
            // TencentCloud_SecretKeyPasswordShow
            // 
            this.TencentCloud_SecretKeyPasswordShow.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TencentCloud_SecretKeyPasswordShow.AutoSize = true;
            this.TencentCloud_SecretKeyPasswordShow.Location = new System.Drawing.Point(431, 127);
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
            this.TencentCloud_SecretKeyInput.Location = new System.Drawing.Point(131, 122);
            this.TencentCloud_SecretKeyInput.Margin = new System.Windows.Forms.Padding(4);
            this.TencentCloud_SecretKeyInput.Name = "TencentCloud_SecretKeyInput";
            this.TencentCloud_SecretKeyInput.PasswordChar = '*';
            this.TencentCloud_SecretKeyInput.Size = new System.Drawing.Size(319, 23);
            this.TencentCloud_SecretKeyInput.TabIndex = 18;
            this.TencentCloud_SecretKeyInput.TextChanged += new System.EventHandler(this.TencentCloud_SecretKeyInput_TextChanged);
            // 
            // TencentCloud_SecretIdInput
            // 
            this.TencentCloud_SecretIdInput.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TencentCloud_SecretIdInput.Location = new System.Drawing.Point(131, 75);
            this.TencentCloud_SecretIdInput.Margin = new System.Windows.Forms.Padding(4);
            this.TencentCloud_SecretIdInput.Name = "TencentCloud_SecretIdInput";
            this.TencentCloud_SecretIdInput.Size = new System.Drawing.Size(319, 23);
            this.TencentCloud_SecretIdInput.TabIndex = 17;
            this.TencentCloud_SecretIdInput.TextChanged += new System.EventHandler(this.TencentCloud_SecretIdInput_TextChanged);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(45, 125);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(69, 17);
            this.label10.TabIndex = 16;
            this.label10.Text = "Secret Key";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(54, 78);
            this.label11.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(60, 17);
            this.label11.TabIndex = 15;
            this.label11.Text = "Secret Id";
            // 
            // tencentTypePanel
            // 
            this.tencentTypePanel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tencentTypePanel.Controls.Add(this.label9);
            this.tencentTypePanel.Controls.Add(this.radioButton4);
            this.tencentTypePanel.Controls.Add(this.radioButton5);
            this.tencentTypePanel.Controls.Add(this.radioButton6);
            this.tencentTypePanel.Location = new System.Drawing.Point(8, 25);
            this.tencentTypePanel.Margin = new System.Windows.Forms.Padding(4);
            this.tencentTypePanel.Name = "tencentTypePanel";
            this.tencentTypePanel.Size = new System.Drawing.Size(453, 29);
            this.tencentTypePanel.TabIndex = 14;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(50, 7);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(56, 17);
            this.label9.TabIndex = 0;
            this.label9.Text = "识别类型";
            // 
            // radioButton4
            // 
            this.radioButton4.AutoSize = true;
            this.radioButton4.Location = new System.Drawing.Point(123, 4);
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
            // radioButton5
            // 
            this.radioButton5.AutoSize = true;
            this.radioButton5.Location = new System.Drawing.Point(188, 4);
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
            // radioButton6
            // 
            this.radioButton6.AutoSize = true;
            this.radioButton6.Location = new System.Drawing.Point(267, 4);
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
            this.linkLabel1.Text = "https://github.com/NPCDW/WindowsFormsOCR";
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
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
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.baiduTypePanel.ResumeLayout(false);
            this.baiduTypePanel.PerformLayout();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            this.tencentTypePanel.ResumeLayout(false);
            this.tencentTypePanel.PerformLayout();
            this.tabPage4.ResumeLayout(false);
            this.tabPage4.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.TextBox BaiduCloud_APIKeyInput;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
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
        private System.Windows.Forms.CheckBox BaiduCloud_AccessTokenPasswordShowCheckbox;
        private System.Windows.Forms.TextBox BaiduCloud_SecretKeyInput;
        private System.Windows.Forms.TextBox BaiduCloud_AccessTokenInput;
        private System.Windows.Forms.Panel baiduTypePanel;
        private System.Windows.Forms.CheckBox TencentCloud_SecretKeyPasswordShow;
        private System.Windows.Forms.TextBox TencentCloud_SecretKeyInput;
        private System.Windows.Forms.TextBox TencentCloud_SecretIdInput;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Panel tencentTypePanel;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.RadioButton radioButton4;
        private System.Windows.Forms.RadioButton radioButton5;
        private System.Windows.Forms.RadioButton radioButton6;
    }
}