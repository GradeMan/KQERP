using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;
using System.Security.Principal;
using System.Xml.Linq;

namespace COM.Service
{
    public class FileLogService
    {
        private static FileLogService instance;
        public static FileLogService Instance
        {
            get
            {
                return instance ?? (instance = new FileLogService());
            }
        }

        private string logFilePath;
        private string LogFilePath
        {
            get
            {
                if(string.IsNullOrEmpty(this.logFilePath))
                    this.logFilePath = System.IO.Path.Combine(@"d:\WebLogFile.txt");
                return this.logFilePath;
            }
        }

        public void ClearLog()
        {
            if (IsLog)
            {
                if (System.IO.File.Exists(this.LogUnityPath))
                    System.IO.File.Delete(this.LogUnityPath);

                if (System.IO.File.Exists(this.LogFilePath))
                    System.IO.File.Delete(this.LogFilePath);
            }
        }

        private bool? isLog = null;
        public bool IsLog
        {
            private get
            {
                if (isLog == null)
                    isLog = System.IO.File.Exists(System.IO.Path.Combine(@"d:\FileLogService.txt"));
                return isLog.Value;
            }
            set
            {
                isLog = value;
            }
        }


        private static object syncObject = new object();

        public void Log(string info)
        {
            this.LogFile(this.LogFilePath,info);
        }


        private string logUnityPath;
        private string LogUnityPath
        {
            get
            {
                if (string.IsNullOrEmpty(this.logUnityPath))
                    this.logUnityPath = System.IO.Path.Combine(@"d:\UnityLogFile.txt");
                return this.logUnityPath;
            }
        }
        public void LogUnity(string info)
        {
            this.LogFile(this.LogUnityPath, info);
        }


        public void LogFile(string fileName,string info)
        {
            if (!this.IsLog)
                return;

            //写入日志
            lock (syncObject)
            {
                //文件不存在就创建,true表示追加
                var file = new System.IO.FileInfo(fileName);
                using (var writer = new System.IO.StreamWriter(file.FullName, true))
                {
                    writer.WriteLine(string.Format("{0} {1}", DateTime.Now, info));
                }
            }
        }

    }


}


