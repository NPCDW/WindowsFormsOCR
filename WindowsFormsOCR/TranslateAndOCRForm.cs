using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static WindowsFormsOCR.GlobalConfig;

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
                if (text.Split('#')[1].Equals(GlobalConfig.Common.defaultOcrProvide.ToString()))
                {
                    defaultOcrProvideComboBox.Text = text;
                    break;
                }
            }

            foreach (String text in this.defaultTranslateProvideComboBox.Items)
            {
                if (text.Split('#')[1].Equals(GlobalConfig.Common.defaultTranslateProvide.ToString()))
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

            foreach (String text in this.sourceLanguageComboBox.Items)
            {
                if (text.Split('#')[1].Equals(GlobalConfig.Common.defaultTranslateSourceLanguage.ToString()))
                {
                    sourceLanguageComboBox.Text = text;
                    break;
                }
            }

            foreach (String text in this.targetLanguageComboBox.Items)
            {
                if (text.Split('#')[1].Equals(GlobalConfig.Common.defaultTranslateTargetLanguage.ToString()))
                {
                    targetLanguageComboBox.Text = text;
                    break;
                }
            }
        }

        public void translate(String translateProvideStr = null)
        {
            TranslateProvideEnum translateProvide;
            if (string.IsNullOrWhiteSpace(translateProvideStr))
            {
                translateProvide = GlobalConfig.Common.defaultTranslateProvide;
            }
            else
            {
                translateProvide = (TranslateProvideEnum)Enum.Parse(typeof(TranslateProvideEnum), translateProvideStr);
            }
            if (translateProvide == TranslateProvideEnum.TencentCloud)
            {
                if (string.IsNullOrEmpty(GlobalConfig.TencentCloudTranslate.secret_id) || string.IsNullOrEmpty(GlobalConfig.TencentCloudTranslate.secret_key))
                {
                    MessageBox.Show("请先设置云服务商提供的秘钥信息，可以到设置中点击链接免费领取");
                    return;
                }
                translateTextBox.Text = "翻译中，请稍等。。。";

                translateTextBox.Text = TencentCloudHelper.translate(ocrTextBox.Text);
            }
            else if (translateProvide == TranslateProvideEnum.BaiduAI)
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

        public void ocr(Bitmap bmp, String ocrProvideStr = null, String ocrType = null)
        {
            this.bmp = bmp;
            OcrProvideEnum ocrProvide;
            if (string.IsNullOrWhiteSpace(ocrProvideStr))
            {
                ocrProvide = GlobalConfig.Common.defaultOcrProvide;
            }
            else
            {
                ocrProvide = (OcrProvideEnum)Enum.Parse(typeof(OcrProvideEnum), ocrProvideStr);
            }
            if (string.IsNullOrWhiteSpace(ocrType))
            {
                ocrType = GlobalConfig.Common.defaultOcrType;
            }
            if (ocrProvide == OcrProvideEnum.TencentCloud)
            {
                if (string.IsNullOrEmpty(GlobalConfig.TencentCloud.secret_id) || string.IsNullOrEmpty(GlobalConfig.TencentCloud.secret_key))
                {
                    MessageBox.Show("请先设置云服务商提供的秘钥信息，可以到设置中点击链接免费领取");
                    return;
                }
                ocrTextBox.Text = "识别中，请稍等。。。";

                ocrTextBox.Text = TencentCloudHelper.ocr(bmp, ocrType);
            }
            else if (ocrProvide == OcrProvideEnum.BaiduCloud)
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
            if (GlobalConfig.Common.defaultTranslateProvide == GlobalConfig.TranslateProvideEnum.BaiduAI)
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
            else if (GlobalConfig.Common.defaultTranslateProvide == GlobalConfig.TranslateProvideEnum.TencentCloud)
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
            if (defaultOcrProvideComboBox.SelectedIndex == (int)OcrProvideEnum.BaiduCloud)
            {
                defaultOcrTypeComboBox.Items.Clear();
                defaultOcrTypeComboBox.Items.Add("通用#" + GlobalConfig.BaiduCloud.OcrTypeEnum.general_basic.ToString());
                defaultOcrTypeComboBox.Items.Add("高精度#" + GlobalConfig.BaiduCloud.OcrTypeEnum.accurate_basic.ToString());
                defaultOcrTypeComboBox.Items.Add("手写体#" + GlobalConfig.BaiduCloud.OcrTypeEnum.handwriting.ToString());
                defaultOcrTypeComboBox.SelectedIndex = 0;
            }
            else if (defaultOcrProvideComboBox.SelectedIndex == (int)OcrProvideEnum.TencentCloud)
            {
                defaultOcrTypeComboBox.Items.Clear();
                defaultOcrTypeComboBox.Items.Add("通用#" + GlobalConfig.TencentCloud.OcrTypeEnum.GeneralBasicOCR.ToString());
                defaultOcrTypeComboBox.Items.Add("高精度#" + GlobalConfig.TencentCloud.OcrTypeEnum.GeneralAccurateOCR.ToString());
                defaultOcrTypeComboBox.Items.Add("手写体#" + GlobalConfig.TencentCloud.OcrTypeEnum.GeneralHandwritingOCR.ToString());
                defaultOcrTypeComboBox.SelectedIndex = 0;
            }
        }

        private void defaultOcrTypeComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (defaultOcrProvideComboBox.Text.Split('#')[1].Equals(GlobalConfig.Common.defaultOcrProvide.ToString())
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
            // TODO 翻译下拉框切换，修改源语言和目标语言下拉框
            // 这两个下拉框绑定事件，如果切换，判定是否需要将默认按钮设置
            // 设置中也添加这两个下拉框
            // 划词翻译和截图翻译 事件也需要修改

            string translateProvide = defaultTranslateProvideComboBox.Text.Split('#')[1];
            if (translateProvide.Equals(GlobalConfig.TranslateProvideEnum.BaiduAI.ToString()))
            {
                sourceLanguageComboBox.Items.Clear();
                targetLanguageComboBox.Items.Clear();
                foreach (TranslateLanguageAttribute item in TranslateLanguageExtension.TranslateLanguageAttributeList)
                {
                    if (!string.IsNullOrWhiteSpace(item.getBaiduAiCode()))
                    {
                        sourceLanguageComboBox.Items.Add(item.getName() + "#" + item.getBaiduAiCode());
                        targetLanguageComboBox.Items.Add(item.getName() + "#" + item.getBaiduAiCode());
                    }
                }
                targetLanguageComboBox.Items.RemoveAt(0);
                sourceLanguageComboBox.SelectedIndex = 0;
                targetLanguageComboBox.SelectedIndex = 0;
            }
            else if (translateProvide.Equals(GlobalConfig.TranslateProvideEnum.TencentCloud.ToString()))
            {
                sourceLanguageComboBox.Items.Clear();
                targetLanguageComboBox.Items.Clear();
                foreach (TranslateLanguageAttribute item in TranslateLanguageExtension.TranslateLanguageAttributeList)
                {
                    if (!string.IsNullOrWhiteSpace(item.getTencentCloudCode()))
                    {
                        sourceLanguageComboBox.Items.Add(item.getName() + "#" + item.getTencentCloudCode());
                        targetLanguageComboBox.Items.Add(item.getName() + "#" + item.getTencentCloudCode());
                    }
                }
                targetLanguageComboBox.Items.RemoveAt(0);
                sourceLanguageComboBox.SelectedIndex = 0;
                targetLanguageComboBox.SelectedIndex = 0;
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
                GlobalConfig.Common.defaultOcrProvide = (OcrProvideEnum)Enum.Parse(typeof(OcrProvideEnum), defaultOcrProvideComboBox.Text.Split('#')[1]);
                GlobalConfig.Common.defaultOcrType = defaultOcrTypeComboBox.Text.Split('#')[1];
                GlobalConfig.SaveConfig();
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
                GlobalConfig.Common.defaultTranslateProvide = (TranslateProvideEnum)Enum.Parse(typeof(TranslateProvideEnum), defaultTranslateProvideComboBox.Text.Split('#')[1]);
                GlobalConfig.Common.defaultTranslateSourceLanguage = sourceLanguageComboBox.Text.Split('#')[1];
                GlobalConfig.Common.defaultTranslateTargetLanguage = targetLanguageComboBox.Text.Split('#')[1];
                GlobalConfig.SaveConfig();
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

        private void translateDefaultCheck_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (defaultTranslateProvideComboBox.Text.Split('#')[1].Equals(GlobalConfig.Common.defaultTranslateProvide.ToString())
                && sourceLanguageComboBox.Text.Contains("#")
                && targetLanguageComboBox.Text.Contains("#")
                && sourceLanguageComboBox.Text.Split('#')[1].Equals(GlobalConfig.Common.defaultTranslateSourceLanguage)
                && targetLanguageComboBox.Text.Split('#')[1].Equals(GlobalConfig.Common.defaultTranslateTargetLanguage))
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

    }
}
