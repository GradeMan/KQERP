using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace COM.Web
{
    public class HoureScheduleItem : IScheduleTask
    {
        private IWebConfigService configService = Unity.Instance.GetService<IWebConfigService>();

        public DateTime? NextTaskDateTime
        {
            get
            {
                return DateTime.Now.Add(new TimeSpan(1, 0, 0));
            }
        }

        public DateTime? ExecuteTask()
        {
            using (System.Net.WebClient client = new System.Net.WebClient())
            {
                var url = string.Format(@"http://{0}/Default/TimerCallback/{1}", configService.DeployHostName, this.GetType().Name);
                client.DownloadDataAsync(new Uri(url));
                return this.NextTaskDateTime;
            }
        }


    }
}