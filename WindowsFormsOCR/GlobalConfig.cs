using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsOCR
{
    public static class GlobalConfig
    {
        private static String configPath = Application.StartupPath + "\\Resources\\Setting.json";

        public static class Common
        {
            public static OcrProvideEnum defaultOcrProvide;
            public static TranslateProvideEnum defaultTranslateProvide;
            public static String defaultOcrType = "";
            public static bool autoStart = false;
        }
        public static class Local
        {
        }
        public static class BaiduCloud
        {
            public static String access_token = "";
            public static DateTime access_token_expires_time;
            public static String client_id = "";
            public static String client_secret = "";
            public enum OcrTypeEnum
            {
                general_basic,
                accurate_basic,
                handwriting
            }

        }
        public static class BaiduAI
        {
            public static String app_id = "";
            public static String app_secret = "";
        }
        public static class TencentCloud
        {
            public static String secret_id = "";
            public static String secret_key = "";
            public enum OcrTypeEnum
            {
                GeneralBasicOCR,
                GeneralAccurateOCR,
                GeneralHandwritingOCR
            }

        }
        public static class TencentCloudTranslate
        {
            public static String secret_id = "";
            public static String secret_key = "";
        }

        public enum OcrProvideEnum
        {
            BaiduCloud,
            TencentCloud
        }

        public enum TranslateProvideEnum
        {
            BaiduAI,
            TencentCloud
        }

        public static void GetConfig()
        {
            string jsonStr;
            try
            {
                using (StreamReader sr = new StreamReader(configPath, false))
                {
                    jsonStr = sr.ReadToEnd().ToString();
                }
                JObject jsonObj = JObject.Parse(jsonStr);
                
                Common.defaultOcrProvide = (OcrProvideEnum)Enum.Parse(typeof(OcrProvideEnum), jsonObj["Common"]["defaultOcrProvide"].ToString()); ;
                Common.defaultTranslateProvide = (TranslateProvideEnum)Enum.Parse(typeof(TranslateProvideEnum), jsonObj["Common"]["defaultTranslateProvide"].ToString());
                Common.defaultOcrType = jsonObj["Common"]["defaultOcrType"].ToString();
                Common.autoStart = Boolean.Parse(jsonObj["Common"]["autoStart"].ToString());

                BaiduCloud.access_token = jsonObj["BaiduCloud"]["access_token"].ToString();
                BaiduCloud.access_token_expires_time = DateTime.Parse(jsonObj["BaiduCloud"]["access_token_expires_time"].ToString());
                BaiduCloud.client_id = jsonObj["BaiduCloud"]["client_id"].ToString();
                BaiduCloud.client_secret = jsonObj["BaiduCloud"]["client_secret"].ToString();

                BaiduAI.app_id = jsonObj["BaiduAI"]["app_id"].ToString();
                BaiduAI.app_secret = jsonObj["BaiduAI"]["app_secret"].ToString();

                TencentCloud.secret_id = jsonObj["TencentCloud"]["secret_id"].ToString();
                TencentCloud.secret_key = jsonObj["TencentCloud"]["secret_key"].ToString();

                TencentCloudTranslate.secret_id = jsonObj["TencentCloudTranslate"]["secret_id"].ToString();
                TencentCloudTranslate.secret_key = jsonObj["TencentCloudTranslate"]["secret_key"].ToString();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
        public static void SaveConfig()
        {
            JObject jsonObj = new JObject();

            jsonObj["Common"] = new JObject();
            jsonObj["Common"]["defaultOcrProvide"] = Common.defaultOcrProvide.ToString();
            jsonObj["Common"]["defaultTranslateProvide"] = Common.defaultTranslateProvide.ToString();
            jsonObj["Common"]["defaultOcrType"] = Common.defaultOcrType;
            jsonObj["Common"]["autoStart"] = Common.autoStart;

            jsonObj["BaiduCloud"] = new JObject();
            jsonObj["BaiduCloud"]["access_token"] = BaiduCloud.access_token;
            jsonObj["BaiduCloud"]["access_token_expires_time"] = BaiduCloud.access_token_expires_time.ToString();
            jsonObj["BaiduCloud"]["client_id"] = BaiduCloud.client_id;
            jsonObj["BaiduCloud"]["client_secret"] = BaiduCloud.client_secret;

            jsonObj["BaiduAI"] = new JObject();
            jsonObj["BaiduAI"]["app_id"] = BaiduAI.app_id;
            jsonObj["BaiduAI"]["app_secret"] = BaiduAI.app_secret;

            jsonObj["TencentCloud"] = new JObject();
            jsonObj["TencentCloud"]["secret_id"] = TencentCloud.secret_id;
            jsonObj["TencentCloud"]["secret_key"] = TencentCloud.secret_key;

            jsonObj["TencentCloudTranslate"] = new JObject();
            jsonObj["TencentCloudTranslate"]["secret_id"] = TencentCloudTranslate.secret_id;
            jsonObj["TencentCloudTranslate"]["secret_key"] = TencentCloudTranslate.secret_key;

            String jsonStr = jsonObj.ToString();
            using (StreamWriter sw = new StreamWriter(configPath))
            {
                sw.WriteLine(jsonStr);
            }
        }

    }
}
