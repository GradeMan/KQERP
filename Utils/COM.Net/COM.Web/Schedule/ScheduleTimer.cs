using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using COM.Domain;

namespace COM.Web
{
    public class ScheduleTimer : IDisposable
    {
        private System.Timers.Timer taskTimer;
        private List<KeyValueItem<DateTime, IScheduleTask>> taskList;

        public void AddSchedulTask(IScheduleTask taskItem)
        {
            this.taskList.Add(new KeyValueItem<DateTime, IScheduleTask>() { Key = taskItem.NextTaskDateTime.Value, Value = taskItem});
        }

        public void Start()
        {
            this.taskList = new List<KeyValueItem<DateTime, IScheduleTask>>();
            //this.taskList.Add(new DateTime(2010, 1, 1, 12, 0, 0), DownloadMsg.Instance.DownloadMsgLog);
            this.taskTimer = new System.Timers.Timer();
            this.taskTimer.Interval = 1000 * 1; //每1秒
            this.taskTimer.Elapsed += (s, e) => this.Execute();
            this.taskTimer.Start();
        }

        private void Execute()
        {
            var q = from item in this.taskList
                    where DateTime.Now >= item.Key
                    select item;

            var qItem = q.ToList();
            qItem.ForEach(item =>
                {
                    this.taskList.Remove(item);
                    System.Threading.Thread thread = new System.Threading.Thread(new System.Threading.ParameterizedThreadStart((arg) =>
                        {
                            try
                            {
                                var taskDateTime = item.Value.ExecuteTask();
                                if (taskDateTime != null)
                                    this.taskList.Add(new KeyValueItem<DateTime, IScheduleTask>() { Key = taskDateTime.Value, Value = item.Value});
                            }
                            catch (Exception error)
                            {
                                string errorString = string.Format("{4}\r\n{0}.Message:{1}\r\nInnerException:{2}\r\nStack:{3}", error.GetType().Name, error.Message, error.InnerException == null ? string.Empty : error.InnerException.ToString(), error.StackTrace,item.Value.GetType().Name);
                                var logService = Unity.Instance.GetService<COM.Service.ILogErrorService>();
                                logService.LogScheduleError(errorString);
                            }
                        }));
                    thread.Start(); //开个新线程调用
                });
        }

        public void Dispose()
        {
            this.Close();
        }

        public void Close()
        {
            if (this.taskList != null)
            {
                this.taskTimer.Stop();
                this.taskTimer.Close();
                this.taskList.Clear();
            }
        }

    }
}