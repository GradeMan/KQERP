using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;
using System.Security.Principal;
using System.Xml.Linq;
using COM.Service;
using COM.Data;

namespace COM.Service
{
    /// <summary>
    /// 此为单例服务,启动时初始化一次,仅依赖获取应用程序路径的AppPathService服务
    /// 也有一个单例实例,用于减少依赖
    /// </summary>
    public interface IConfigService
    {
        bool IsDebug { get; }
        string DeployHostName { get; }
    }

}
