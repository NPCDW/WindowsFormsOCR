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

        public void ocr()
        {
            ocrTextBox.Text = "文本识别结果";
        }

    }
}
