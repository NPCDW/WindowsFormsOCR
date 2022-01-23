﻿using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TencentCloud.Common;
using TencentCloud.Common.Profile;
using TencentCloud.Ocr.V20181119;
using TencentCloud.Ocr.V20181119.Models;
using TencentCloud.Tmt.V20180321;
using TencentCloud.Tmt.V20180321.Models;

namespace WindowsFormsOCR
{
    public class TencentCloudHelper
    {
        public static String translate(String text)
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
                req.SourceText = text;
                req.Source = "auto";
                req.Target = "zh";
                req.ProjectId = 0;

                TextTranslateResponse resp = client.TextTranslateSync(req);
                String jsonStr = AbstractModel.ToJsonString(resp);
                JObject jsonObj = JObject.Parse(jsonStr);
                return jsonObj["TargetText"].ToString();
            }
            catch (Exception e)
            {
                return e.ToString();
            }
        }

        public static String ocr(Bitmap bmp)
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
                httpProfile.Endpoint = ("ocr.tencentcloudapi.com");
                clientProfile.HttpProfile = httpProfile;

                OcrClient client = new OcrClient(cred, "ap-beijing", clientProfile);
                String jsonStr = "{}";
                String base64 = Utils.BitmapToBase64String(bmp);
                if ("GeneralBasicOCR".Equals(GlobalConfig.TencentCloud.ocr_type))
                {
                    GeneralBasicOCRRequest req = new GeneralBasicOCRRequest();
                    req.ImageBase64 = base64;
                    GeneralBasicOCRResponse resp = client.GeneralBasicOCRSync(req);
                    jsonStr = AbstractModel.ToJsonString(resp);
                }
                else if ("GeneralAccurateOCR".Equals(GlobalConfig.TencentCloud.ocr_type))
                {
                    GeneralAccurateOCRRequest req = new GeneralAccurateOCRRequest();
                    req.ImageBase64 = base64;
                    GeneralAccurateOCRResponse resp = client.GeneralAccurateOCRSync(req);
                    jsonStr = AbstractModel.ToJsonString(resp);
                }
                else if ("GeneralHandwritingOCR".Equals(GlobalConfig.TencentCloud.ocr_type))
                {
                    GeneralHandwritingOCRRequest req = new GeneralHandwritingOCRRequest();
                    req.ImageBase64 = base64;
                    GeneralHandwritingOCRResponse resp = client.GeneralHandwritingOCRSync(req);
                    jsonStr = AbstractModel.ToJsonString(resp);
                }
                JObject jsonObj = JObject.Parse(jsonStr);
                JToken[] jArray = jsonObj["TextDetections"].ToArray();
                String text = "";
                foreach (JToken jToken in jArray)
                {
                    text += jToken["DetectedText"].ToString() + System.Environment.NewLine;
                }
                return text;
            }
            catch (Exception e)
            {
                return e.ToString();
            }
        }

        public static Dictionary<String, String> screenshotTranslate(Bitmap bmp)
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
                ImageTranslateRequest req = new ImageTranslateRequest();
                req.Data = Utils.BitmapToBase64String(bmp);
                req.SessionUuid = System.Guid.NewGuid().ToString();
                req.Scene = "doc";
                req.Source = "auto";
                req.Target = "zh";
                req.ProjectId = 0;
                ImageTranslateResponse resp = client.ImageTranslateSync(req);
                String jsonStr = AbstractModel.ToJsonString(resp);
                JObject jsonObj = JObject.Parse(jsonStr);
                JToken[] jArray = jsonObj["ImageRecord"]["Value"].ToArray();
                String ocrText = "";
                String translateText = "";
                foreach (JToken jToken in jArray)
                {
                    ocrText += jToken["SourceText"].ToString() + System.Environment.NewLine;
                    translateText += jToken["TargetText"].ToString() + System.Environment.NewLine;
                }
                Dictionary<String, String> keyValues = new Dictionary<String, String>();
                keyValues.Add("ocrText", ocrText);
                keyValues.Add("translateText", translateText);
                return keyValues;
            }
            catch (Exception e)
            {
                Dictionary<String, String> keyValues = new Dictionary<String, String>();
                keyValues.Add("ocrText", e.ToString());
                keyValues.Add("translateText", "");
                return keyValues;
            }
        }

    }
}