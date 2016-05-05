using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;
using System.Security.Principal;
using System.Xml.Linq;
using System.Web.Mvc;
using COM.Service;
using COM.Data;

namespace COM.Web
{
    /// <summary>
    /// 此为单例服务,启动时初始化一次,仅依赖获取应用程序路径的AppPathService服务
    /// </summary>
    public interface IWebConfigService : IConfigService
    {
        List<WebAppInterfaceUser> UserList { get; }
    }

    public class ConfigService : IWebConfigService
    {
        private IAppPathService appPath;
        public ConfigService(IAppPathService appPath)
        {
            this.appPath = appPath;
        }

        private bool? isDebug = null;
        public bool IsDebug
        {
            get
            {
                if (isDebug == null)
                {
                    isDebug = System.IO.File.Exists(System.IO.Path.Combine(this.appPath.AppDataPath, "IsDebug.txt"));
                }
                return isDebug.Value;
            }
        }

        private Dictionary<string, XElement> dictOption = new Dictionary<string, XElement>();
        public XElement GetConfig(string optionKey)
        {
            if (!dictOption.Keys.Contains(optionKey))
            {
                var path = System.IO.Path.Combine(this.appPath.AppDataPath, optionKey + ".xml");
                var appConfig = XElement.Load(path);
                dictOption.Add(optionKey, appConfig);
            }
            return dictOption[optionKey];
        }

        public List<WebAppInterfaceUser> UserList
        {
            get
            {
                var config = this.GetConfig("AppConfig");
                return config.Element("Login").Elements("User")
                    .Select(e => new WebAppInterfaceUser()
                            {
                                WebAppName = e.Attribute("Name").Value,
                                WebAppPassword = e.Attribute("Password").Value,
                                InterfaceRole = e.Attribute("Role").Value,
                            })
                    .ToList();
            }
        }

        /// <summary>
        /// 配置文件中指定服务器,端口和虚拟目录名
        /// 可用于对自己发起一个请求
        /// 或者用于判断是本部署的应用的用途
        /// 不能用于重定向客户端请求Redirect()
        /// 需用WebSiteName来重定向
        /// </summary>
        public string DeployHostName
        {
            get
            {
                var config = this.GetConfig("AppConfig");
                return config.Element("DeployHostName").Attribute("Value").Value;
            }
        }


    }


}



