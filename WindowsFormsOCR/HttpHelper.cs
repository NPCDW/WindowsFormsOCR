using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsOCR
{
    public class HttpHelper
    {
        public static string HttpPost(string url, string body)
        {
            try
            {
                HttpWebRequest request = (HttpWebRequest)WebRequest.Create(url);
                request.Method = "POST";
                request.ContentType = "application/json";

                byte[] buffer = Encoding.UTF8.GetBytes(body);
                request.ContentLength = buffer.Length;
                request.GetRequestStream().Write(buffer, 0, buffer.Length);
                HttpWebResponse response = (HttpWebResponse)request.GetResponse();
                using (StreamReader reader = new StreamReader(response.GetResponseStream(), Encoding.UTF8))
                {
                    return reader.ReadToEnd();
                }
            }
            catch (WebException ex)
            {

                HttpWebResponse response = (HttpWebResponse)ex.Response;
                if (response != null)
                {
                    Console.WriteLine("Error code: {0}", response.StatusCode);

                    using (StreamReader reader = new StreamReader(response.GetResponseStream(), System.Text.Encoding.Default))
                    {
                        string text = reader.ReadToEnd();

                        int start = text.IndexOf("System.Exception:");
                        string s = text.Substring(start, 2000);
                        throw new Exception("XX" + s);
                    }
                }
                else
                {
                    throw new Exception("XX" + ex.Message);
                }
            }
        }
    }
}
