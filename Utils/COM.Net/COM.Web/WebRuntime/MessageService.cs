using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Security;
using Microsoft.Practices.Unity;
using COM.Service;

namespace COM.Web
{
    public interface IMessageService
    {
        void SendSysMsgToUser(string userTo, string content);
        void SendSysMsgToDev(string content);
    }

    public class MessageService : IMessageService
    {
        private IConfigService configService;
        private ILogErrorService logErrorService;
        public MessageService(ILogErrorService logErrorService,IConfigService configService)
        {
            this.logErrorService = logErrorService;
            this.configService = configService;
        }

        private void SendUserMsgByOA(string userNameFrom, string userNameTo, string content)
        {

            var userNameFromEncode = this.Encode(userNameFrom);
            var userNameToEncode = this.Encode(userNameTo);
            var contenEncode = this.Encode(content);
            var time = DateTime.Now.ToString("yyyy-MM-dd hh:mm:ss");
            var timeEncode = this.Encode(time);
            var url = @"http://192.168.0.11/general/xiaohe1/submit.php";
            var msgFormat = @"TO_NAME={0}&SEND_TIME={3}&FROM_NAME={1}&CONTENT={2}&SMS_ID_REPLAY=";
            //TO_NAME=%BA%CE%D7%D3%CB%B6&SEND_TIME=2012-09-11+12%3A13%3A56&CONTENT=%C0%F1%C6%B7%D2%D1%C8%EB%BF%E212mh1232%A3%AC%C7%EB%C8%CF%B6%A8%CE%AA%C0%F1%C6%B7.%B4%F7%D3%B1&FROM_NAME=%C1%F5%CE%B0&SMS_ID_REPLAY=
            var msg = string.Format(msgFormat, userNameToEncode, userNameFromEncode, contenEncode, timeEncode);
            var request = (System.Net.HttpWebRequest)System.Net.WebRequest.Create(url);
            request.CookieContainer = new System.Net.CookieContainer();
            request.Method = "POST";
            request.Accept = "*/*";
            request.ContentType = "application/x-www-form-urlencoded";
            var buffer = System.Text.Encoding.UTF8.GetBytes(msg);
            request.ContentLength = buffer.Length;
            using (var stream = request.GetRequestStream())
            {
                stream.Write(buffer, 0, buffer.Length);
            }

            var response = (System.Net.HttpWebResponse)request.GetResponse();
            using (var reader = new System.IO.StreamReader(response.GetResponseStream(), System.Text.Encoding.Default))
            {
                var respHtml = reader.ReadToEnd();
                //foreach (System.Net.Cookie ck in response.Cookies)
                //{
                //    this.cookie += ck.Name + "=" + ck.Value + ";";
                //}
                //if (!respHtml.Contains("提醒已发送"))
                    //this.logErrorService.LogInfo(string.Format("OA消息发送失败!{0}->{1}:{2}", userNameFrom, userNameTo, content));
            }
        }

        private string Encode(string p)
        {
            byte[] encodeByte = System.Text.Encoding.Default.GetBytes(p);
            var contentEncode = System.Web.HttpUtility.UrlEncode(encodeByte);
            return contentEncode;
        }

        public void SendSysMsgToDev(string content)
        {
            var user = "NULL";
            if(HttpContext.Current != null && HttpContext.Current.User != null && HttpContext.Current.User.Identity != null)
                user = HttpContext.Current.User.Identity.Name;

            this.SendUserMsgByOA("admin", "俞凯", string.Format("[{0} User={1}]{2}", this.configService.DeployHostName, user, content));
        }


        public void SendSysMsgToUser(string userTo, string content)
        {
            if (this.configService.DeployHostName.Contains("localhost"))
                return;

            this.SendUserMsgByOA("admin", userTo.TrimOrEmpty(), content);
        }


    }



}