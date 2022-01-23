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
        public TranslateAndOcrForm()
        {
            InitializeComponent();
        }

        public void translate()
        {
            if (GlobalConfig.Common.defaultTranslateProvide.Equals("TencentCloud"))
            {
                if (string.IsNullOrEmpty(GlobalConfig.TencentCloud.secret_id) || string.IsNullOrEmpty(GlobalConfig.TencentCloud.secret_key))
                {
                    MessageBox.Show("请先设置云服务商提供的秘钥信息，可以到设置中点击链接免费领取");
                    return;
                }
                translateTextBox.Text = "翻译中，请稍等。。。";

                translateTextBox.Text = TencentCloudHelper.translate(ocrTextBox.Text);
            }
            else if (GlobalConfig.Common.defaultTranslateProvide.Equals("BaiduAI"))
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

        public void ocr(Bitmap bmp)
        {
            if (GlobalConfig.Common.defaultOcrProvide.Equals("TencentCloud"))
            {
                if (string.IsNullOrEmpty(GlobalConfig.TencentCloud.secret_id) || string.IsNullOrEmpty(GlobalConfig.TencentCloud.secret_key))
                {
                    MessageBox.Show("请先设置云服务商提供的秘钥信息，可以到设置中点击链接免费领取");
                    return;
                }
                if (string.IsNullOrEmpty(GlobalConfig.TencentCloud.ocr_type))
                {
                    MessageBox.Show("请先设置云服务商默认识别类型");
                    return;
                }
                ocrTextBox.Text = "识别中，请稍等。。。";

                ocrTextBox.Text = TencentCloudHelper.ocr(bmp);
            }
            else if (GlobalConfig.Common.defaultOcrProvide.Equals("BaiduCloud"))
            {
                if (string.IsNullOrEmpty(GlobalConfig.BaiduCloud.client_id) || string.IsNullOrEmpty(GlobalConfig.BaiduCloud.client_secret))
                {
                    MessageBox.Show("请先设置云服务商提供的秘钥信息，可以到设置中点击链接免费领取");
                    return;
                }
                if (string.IsNullOrEmpty(GlobalConfig.BaiduCloud.ocr_type))
                {
                    MessageBox.Show("请先设置云服务商默认识别类型");
                    return;
                }
                ocrTextBox.Text = "识别中，请稍等。。。";

                ocrTextBox.Text = BaiduCloudHelper.ocr(bmp);
            }
        }

        public void screenshotTranslate(Bitmap bmp)
        {
            if (GlobalConfig.Common.defaultTranslateProvide.Equals("TencentCloud"))
            {
                if (string.IsNullOrEmpty(GlobalConfig.TencentCloud.secret_id) || string.IsNullOrEmpty(GlobalConfig.TencentCloud.secret_key))
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

    }
}
