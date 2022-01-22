using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TencentCloud.Common;
using TencentCloud.Common.Profile;
using TencentCloud.Ocr.V20181119;
using TencentCloud.Ocr.V20181119.Models;
using TencentCloud.Tmt.V20180321;
using TencentCloud.Tmt.V20180321.Models;

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
            try
            {
                if (string.IsNullOrEmpty(GlobalConfig.TencentCloud.secret_id) || string.IsNullOrEmpty(GlobalConfig.TencentCloud.secret_key))
                {
                    MessageBox.Show("请先设置云服务商提供的秘钥信息");
                    return;
                }
                translateTextBox.Text = "翻译中，请稍等。。。";

                Credential cred = new Credential
                {
                    SecretId = GlobalConfig.TencentCloud.secret_id,
                    SecretKey = GlobalConfig.TencentCloud.secret_key
                };

                ClientProfile clientProfile = new ClientProfile();
                HttpProfile httpProfile = new HttpProfile();
                httpProfile.Endpoint = ("tmt.tencentcloudapi.com");
                clientProfile.HttpProfile = httpProfile;

                TmtClient client = new TmtClient(cred, "ap-beijing", clientProfile);
                TextTranslateRequest req = new TextTranslateRequest();
                req.SourceText = ocrTextBox.Text;
                req.Source = "auto";
                req.Target = "zh";
                req.ProjectId = 0;

                TextTranslateResponse resp = client.TextTranslateSync(req);
                String jsonStr = AbstractModel.ToJsonString(resp);
                JObject jsonObj = JObject.Parse(jsonStr);
                translateTextBox.Text = jsonObj["TargetText"].ToString();
            }
            catch (Exception e)
            {
                translateTextBox.Text = e.ToString();
            }
        }

        public void ocr(Bitmap bmp)
        {
            try
            {
                if (string.IsNullOrEmpty(GlobalConfig.TencentCloud.secret_id) || string.IsNullOrEmpty(GlobalConfig.TencentCloud.secret_key))
                {
                    MessageBox.Show("请先设置云服务商提供的秘钥信息");
                    return;
                }
                if (string.IsNullOrEmpty(GlobalConfig.TencentCloud.type))
                {
                    MessageBox.Show("请先设置云服务商默认识别类型");
                    return;
                }
                ocrTextBox.Text = "识别中，请稍等。。。";

                Credential cred = new Credential
                {
                    SecretId = GlobalConfig.TencentCloud.secret_id,
                    SecretKey = GlobalConfig.TencentCloud.secret_key
                };

                ClientProfile clientProfile = new ClientProfile();
                HttpProfile httpProfile = new HttpProfile();
                httpProfile.Endpoint = ("ocr.tencentcloudapi.com");
                clientProfile.HttpProfile = httpProfile;

                OcrClient client = new OcrClient(cred, "ap-beijing", clientProfile);
                String jsonStr = "{}";
                String base64 = Utils.BitmapToBase64String(bmp);
                if ("GeneralBasicOCR".Equals(GlobalConfig.TencentCloud.type))
                {
                    GeneralBasicOCRRequest req = new GeneralBasicOCRRequest();
                    req.ImageBase64 = base64;
                    GeneralBasicOCRResponse resp = client.GeneralBasicOCRSync(req);
                    jsonStr = AbstractModel.ToJsonString(resp);
                }
                else if ("GeneralAccurateOCR".Equals(GlobalConfig.TencentCloud.type))
                {
                    GeneralAccurateOCRRequest req = new GeneralAccurateOCRRequest();
                    req.ImageBase64 = base64;
                    GeneralAccurateOCRResponse resp = client.GeneralAccurateOCRSync(req);
                    jsonStr = AbstractModel.ToJsonString(resp);
                }
                else if ("GeneralHandwritingOCR".Equals(GlobalConfig.TencentCloud.type))
                {
                    GeneralHandwritingOCRRequest req = new GeneralHandwritingOCRRequest();
                    req.ImageBase64 = base64;
                    GeneralHandwritingOCRResponse resp = client.GeneralHandwritingOCRSync(req);
                    jsonStr = AbstractModel.ToJsonString(resp);
                }
                JObject jsonObj = JObject.Parse(jsonStr);
                JToken[] jArray = jsonObj["TextDetections"].ToArray();
                ocrTextBox.Text = "";
                foreach (JToken jToken in jArray)
                {
                    ocrTextBox.Text += jToken["DetectedText"].ToString() + System.Environment.NewLine;
                }
            }
            catch (Exception e)
            {
                ocrTextBox.Text = e.ToString();
            }
        }

        public void screenshotTranslate(Bitmap bmp)
        {
            try
            {
                if (string.IsNullOrEmpty(GlobalConfig.TencentCloud.secret_id) || string.IsNullOrEmpty(GlobalConfig.TencentCloud.secret_key))
                {
                    MessageBox.Show("请先设置云服务商提供的秘钥信息");
                    return;
                }
                ocrTextBox.Text = "识别中，请稍等。。。";
                translateTextBox.Text = "翻译中，请稍等。。。";

                Credential cred = new Credential
                {
                    SecretId = GlobalConfig.TencentCloud.secret_id,
                    SecretKey = GlobalConfig.TencentCloud.secret_key
                };

                ClientProfile clientProfile = new ClientProfile();
                HttpProfile httpProfile = new HttpProfile();
                httpProfile.Endpoint = ("tmt.tencentcloudapi.com");
                clientProfile.HttpProfile = httpProfile;

                TmtClient client = new TmtClient(cred, "ap-beijing", clientProfile);
                ImageTranslateRequest req = new ImageTranslateRequest();
                req.Data = Utils.BitmapToBase64String(bmp);
                req.SessionUuid = System.Guid.NewGuid().ToString();
                req.Scene = "doc";
                req.Source = "auto";
                req.Target = "zh";
                req.ProjectId = 0;
                ImageTranslateResponse resp = client.ImageTranslateSync(req);
                String jsonStr = AbstractModel.ToJsonString(resp);
                translateTextBox.Text = jsonStr;
                JObject jsonObj = JObject.Parse(jsonStr);
                JToken[] jArray = jsonObj["ImageRecord"]["Value"].ToArray();
                ocrTextBox.Text = "";
                translateTextBox.Text = "";
                foreach (JToken jToken in jArray)
                {
                    ocrTextBox.Text += jToken["SourceText"].ToString() + System.Environment.NewLine;
                    translateTextBox.Text += jToken["TargetText"].ToString() + System.Environment.NewLine;
                }
            }
            catch (Exception e)
            {
                translateTextBox.Text = e.ToString();
            }
        }

    }
}
