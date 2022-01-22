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
            if (string.IsNullOrEmpty(GlobalConfig.TencentCloud.secret_id) || string.IsNullOrEmpty(GlobalConfig.TencentCloud.secret_key))
            {
                MessageBox.Show("请先设置云服务商提供的秘钥信息，可以到设置中点击链接免费领取");
                return;
            }
            translateTextBox.Text = "翻译中，请稍等。。。";

            translateTextBox.Text = TencentCloudHelper.translate(ocrTextBox.Text);
        }

        public void ocr(Bitmap bmp)
        {
            if (string.IsNullOrEmpty(GlobalConfig.TencentCloud.secret_id) || string.IsNullOrEmpty(GlobalConfig.TencentCloud.secret_key))
            {
                MessageBox.Show("请先设置云服务商提供的秘钥信息，可以到设置中点击链接免费领取");
                return;
            }
            if (string.IsNullOrEmpty(GlobalConfig.TencentCloud.type))
            {
                MessageBox.Show("请先设置云服务商默认识别类型");
                return;
            }
            ocrTextBox.Text = "识别中，请稍等。。。";

            ocrTextBox.Text = TencentCloudHelper.ocr(bmp);
        }

        public void screenshotTranslate(Bitmap bmp)
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

    }
}
