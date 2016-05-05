using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using log4net;
using System.Reflection;

[assembly: log4net.Config.XmlConfigurator(ConfigFile = "./log4net.xml", ConfigFileExtension = "xml", Watch = true)]
namespace ERP.Winform.Service
{
    public class LogServive
    {
        private static LogServive instance;
        public static LogServive Instance
        {
            get
            {
                return instance ?? (instance = new LogServive());
            }
        }

        public ILog Log
        {
            get { return log4net.LogManager.GetLogger(this.GetType()); }
        }
    }
}
