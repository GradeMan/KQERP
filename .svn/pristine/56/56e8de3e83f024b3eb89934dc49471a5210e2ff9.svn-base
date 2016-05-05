using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Net;
using System.IO;

namespace ERP.Winform
{
   public class HttpRequstCommand
    {
        /// <summary>
        /// GET模拟请求
        /// </summary>
        /// <param name="Url">URL路径</param>
        /// <param name="postDataStr">参数</param>
        /// <returns>返回请求信息</returns>
        public static string HttpGet(string Url, string postDataStr)
        {
            HttpWebRequest request = (HttpWebRequest)WebRequest.Create(Url + (postDataStr == "" ? "" : "?") + postDataStr);
            request.AllowAutoRedirect = true;
            request.Method = "GET";
            request.ContentType = "text/html;charset=UTF-8";
            System.Net.CookieContainer c = new System.Net.CookieContainer();
            request.CookieContainer = c;
            HttpWebResponse response = (HttpWebResponse)request.GetResponse();
            Stream myResponseStream = response.GetResponseStream();
            StreamReader myStreamReader = new StreamReader(myResponseStream, Encoding.GetEncoding("utf-8"));
            string retString = myStreamReader.ReadToEnd();
            myStreamReader.Close();
            myResponseStream.Close();
            return retString;
        }
    }
}
