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

        public static String defaultProvide = "";
        public static bool autoStart = false;
        public static class Local
        {
        }
        public static class BaiduCloud
        {
            public static String type = "";
            public static String access_token = "";
            public static DateTime access_token_expires_time;
            public static String client_id = "";
            public static String client_secret = "";
        }
        public static class TencentCloud
        {
            public static String type = "";
            public static String secret_id = "";
            public static String secret_key = "";
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

                defaultProvide = jsonObj["defaultProvide"].ToString();
                autoStart = Boolean.Parse(jsonObj["autoStart"].ToString());

                BaiduCloud.type = jsonObj["BaiduCloud"]["type"].ToString();
                BaiduCloud.access_token = jsonObj["BaiduCloud"]["access_token"].ToString();
                BaiduCloud.access_token_expires_time = DateTime.Parse(jsonObj["BaiduCloud"]["access_token_expires_time"].ToString());
                BaiduCloud.client_id = jsonObj["BaiduCloud"]["client_id"].ToString();
                BaiduCloud.client_secret = jsonObj["BaiduCloud"]["client_secret"].ToString();

                TencentCloud.type = jsonObj["TencentCloud"]["type"].ToString();
                TencentCloud.secret_id = jsonObj["TencentCloud"]["secret_id"].ToString();
                TencentCloud.secret_key = jsonObj["TencentCloud"]["secret_key"].ToString();

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
        public static void SaveConfig()
        {
            JObject jsonObj = new JObject();

            jsonObj["defaultProvide"] = defaultProvide;
            jsonObj["autoStart"] = autoStart;

            jsonObj["BaiduCloud"] = new JObject();
            jsonObj["BaiduCloud"]["type"] = BaiduCloud.type;
            jsonObj["BaiduCloud"]["access_token"] = BaiduCloud.access_token;
            jsonObj["BaiduCloud"]["access_token_expires_time"] = BaiduCloud.access_token_expires_time.ToString();
            jsonObj["BaiduCloud"]["client_id"] = BaiduCloud.client_id;
            jsonObj["BaiduCloud"]["client_secret"] = BaiduCloud.client_secret;

            jsonObj["TencentCloud"] = new JObject();
            jsonObj["TencentCloud"]["type"] = TencentCloud.type;
            jsonObj["TencentCloud"]["secret_id"] = TencentCloud.secret_id;
            jsonObj["TencentCloud"]["secret_key"] = TencentCloud.secret_key;

            String jsonStr = jsonObj.ToString();
            using (StreamWriter sw = new StreamWriter(configPath))
            {
                sw.WriteLine(jsonStr);
            }
        }

    }
}
