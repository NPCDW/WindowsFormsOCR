using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsOCR
{
    public partial class TranslateAndOcrForm : Form
    {
        private Bitmap bmp = null;

        public TranslateAndOcrForm()
        {
            InitializeComponent();
        }

        private void TranslateAndOcrForm_Load(object sender, EventArgs e)
        {
            foreach (String text in this.defaultOcrProvideComboBox.Items)
            {
                if (text.Split('#')[1].Equals(GlobalConfig.Common.defaultOcrProvide))
                {
                    defaultOcrProvideComboBox.Text = text;
                    break;
                }
            }


            foreach (String text in this.defaultTranslateProvideComboBox.Items)
            {
                if (text.Split('#')[1].Equals(GlobalConfig.Common.defaultTranslateProvide))
                {
                    defaultTranslateProvideComboBox.Text = text;
                    break;
                }
            }

            foreach (String text in this.defaultOcrTypeComboBox.Items)
            {
                if (text.Split('#')[1].Equals(GlobalConfig.Common.defaultOcrType))
                {
                    defaultOcrTypeComboBox.Text = text;
                    break;
                }
            }
        }

        public void translate(String translateProvide = null)
        {
            if (string.IsNullOrWhiteSpace(translateProvide))
            {
                translateProvide = GlobalConfig.Common.defaultTranslateProvide;
            }
            if (translateProvide.Equals("TencentCloud"))
            {
                if (string.IsNullOrEmpty(GlobalConfig.TencentCloudTranslate.secret_id) || string.IsNullOrEmpty(GlobalConfig.TencentCloudTranslate.secret_key))
                {
                    MessageBox.Show("请先设置云服务商提供的秘钥信息，可以到设置中点击链接免费领取");
                    return;
                }
                translateTextBox.Text = "翻译中，请稍等。。。";

                translateTextBox.Text = TencentCloudHelper.translate(ocrTextBox.Text);
            }
            else if (translateProvide.Equals("BaiduAI"))
            {
                if (string.IsNullOrEmpty(GlobalConfig.BaiduAI.app_id) || string.IsNullOrEmpty(GlobalConfig.BaiduAI.app_secret))
                {
                    MessageBox.Show("请先设置云服务商提供的秘钥信息，可以到设置中点击链接免费领取");
                    return;
                }
                translateTextBox.Text = "识别中，请稍等。。。";

                translateTextBox.Text = BaiduAIHelper.translate(ocrTextBox.Text);
            }
        }

        public void ocr(Bitmap bmp, String ocrProvide = null, String ocrType = null)
        {
            this.bmp = bmp;
            if (string.IsNullOrWhiteSpace(ocrProvide))
            {
                ocrProvide = GlobalConfig.Common.defaultOcrProvide;
            }
            if (string.IsNullOrWhiteSpace(ocrType))
            {
                ocrType = GlobalConfig.Common.defaultOcrType;
            }
            if (ocrProvide.Equals("TencentCloud"))
            {
                if (string.IsNullOrEmpty(GlobalConfig.TencentCloud.secret_id) || string.IsNullOrEmpty(GlobalConfig.TencentCloud.secret_key))
                {
                    MessageBox.Show("请先设置云服务商提供的秘钥信息，可以到设置中点击链接免费领取");
                    return;
                }
                ocrTextBox.Text = "识别中，请稍等。。。";

                ocrTextBox.Text = TencentCloudHelper.ocr(bmp, ocrType);
            }
            else if (ocrProvide.Equals("BaiduCloud"))
            {
                if (string.IsNullOrEmpty(GlobalConfig.BaiduCloud.client_id) || string.IsNullOrEmpty(GlobalConfig.BaiduCloud.client_secret))
                {
                    MessageBox.Show("请先设置云服务商提供的秘钥信息，可以到设置中点击链接免费领取");
                    return;
                }
                ocrTextBox.Text = "识别中，请稍等。。。";

                ocrTextBox.Text = BaiduCloudHelper.ocr(bmp, ocrType);
            }
        }

        public void screenshotTranslate(Bitmap bmp)
        {
            this.bmp = bmp;
            if (GlobalConfig.Common.defaultTranslateProvide.Equals("TencentCloud"))
            {
                if (string.IsNullOrEmpty(GlobalConfig.TencentCloudTranslate.secret_id) || string.IsNullOrEmpty(GlobalConfig.TencentCloudTranslate.secret_key))
                {
                    MessageBox.Show("请先设置云服务商提供的秘钥信息，可以到设置中点击链接免费领取");
                    return;
                }
                ocrTextBox.Text = "识别中，请稍等。。。";
                translateTextBox.Text = "翻译中，请稍等。。。";

                Dictionary<String, String> keyValues = TencentCloudHelper.screenshotTranslate(bmp);
                ocrTextBox.Text = keyValues["ocrText"];
                translateTextBox.Text = keyValues["translateText"];
            }
            else if (GlobalConfig.Common.defaultTranslateProvide.Equals("BaiduAI"))
            {
                if (string.IsNullOrEmpty(GlobalConfig.BaiduAI.app_id) || string.IsNullOrEmpty(GlobalConfig.BaiduAI.app_secret))
                {
                    MessageBox.Show("请先设置云服务商提供的秘钥信息，可以到设置中点击链接免费领取");
                    return;
                }
                ocrTextBox.Text = "识别中，请稍等。。。";
                translateTextBox.Text = "翻译中，请稍等。。。";

                Dictionary<String, String> keyValues = BaiduAIHelper.screenshotTranslate(bmp);
                ocrTextBox.Text = keyValues["ocrText"];
                translateTextBox.Text = keyValues["translateText"];
            }
        }

        private void translateButton_Click(object sender, EventArgs e)
        {
            this.translate(defaultTranslateProvideComboBox.Text.Split('#')[1]);
        }

        private void defaultOcrProvideComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (defaultOcrProvideComboBox.SelectedIndex == 0)
            {
                defaultOcrTypeComboBox.Items.Clear();
                defaultOcrTypeComboBox.Items.Add("通用#general_basic");
                defaultOcrTypeComboBox.Items.Add("高精度#accurate_basic");
                defaultOcrTypeComboBox.Items.Add("手写体#handwriting");
                defaultOcrTypeComboBox.SelectedIndex = 0;
            }
            else if (defaultOcrProvideComboBox.SelectedIndex == 1)
            {
                defaultOcrTypeComboBox.Items.Clear();
                defaultOcrTypeComboBox.Items.Add("通用#GeneralBasicOCR");
                defaultOcrTypeComboBox.Items.Add("高精度#GeneralAccurateOCR");
                defaultOcrTypeComboBox.Items.Add("手写体#GeneralHandwritingOCR");
                defaultOcrTypeComboBox.SelectedIndex = 0;
            }
        }

        private void defaultOcrTypeComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (defaultOcrProvideComboBox.Text.Split('#')[1].Equals(GlobalConfig.Common.defaultOcrProvide)
                && defaultOcrTypeComboBox.Text.Split('#')[1].Equals(GlobalConfig.Common.defaultOcrType))
            {
                defaultOcrSettingCheck.Checked = true;
                defaultOcrSettingCheck.Enabled = false;
            }
            else
            {
                defaultOcrSettingCheck.Checked = false;
                defaultOcrSettingCheck.Enabled = true;
            }
        }

        private void defaultTranslateProvideComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (defaultTranslateProvideComboBox.Text.Split('#')[1].Equals(GlobalConfig.Common.defaultTranslateProvide))
            {
                defaultTranslateSettingCheck.Checked = true;
                defaultTranslateSettingCheck.Enabled = false;
            }
            else
            {
                defaultTranslateSettingCheck.Checked = false;
                defaultTranslateSettingCheck.Enabled = true;
            }
        }

        private void defaultOcrSettingCheck_CheckedChanged(object sender, EventArgs e)
        {
            if (!defaultOcrSettingCheck.Checked)
            {
                defaultOcrSettingCheck.Enabled = true;
                return;
            }
            else
            {
                defaultOcrSettingCheck.Enabled = false;
                GlobalConfig.Common.defaultOcrProvide = defaultOcrProvideComboBox.Text.Split('#')[1];
                GlobalConfig.Common.defaultOcrType = defaultOcrTypeComboBox.Text.Split('#')[1];
            }
        }

        private void defaultTranslateSettingCheck_CheckedChanged(object sender, EventArgs e)
        {
            if (!defaultTranslateSettingCheck.Checked)
            {
                defaultTranslateSettingCheck.Enabled = true;
                return;
            }
            else
            {
                defaultTranslateSettingCheck.Enabled = false;
                GlobalConfig.Common.defaultTranslateProvide = defaultTranslateProvideComboBox.Text.Split('#')[1];
            }
        }

        private void ocrButton_Click(object sender, EventArgs e)
        {
            if (this.bmp == null)
            {
                MessageBox.Show("未发现截图");
                return;
            }
            this.ocr(this.bmp, defaultOcrProvideComboBox.Text.Split('#')[1], defaultOcrTypeComboBox.Text.Split('#')[1]);
        }
    }
}
