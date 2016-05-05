using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace COM.Web
{
    public class TestTimeScheduleItem : IScheduleTask
    {
        private IWebConfigService configService = Unity.Instance.GetService<IWebConfigService>();

        public DateTime? NextTaskDateTime
        {
            get
            {
                DateTime taskTime = new DateTime(2012, 1, 1, 12, 0, 0); //中午
                return DateTime.Today.AddDays(1).Add(taskTime.TimeOfDay);
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