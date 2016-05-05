using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;
using System.Security.Principal;
using System.Xml.Linq;

namespace COM.Web
{
    public class EnumWebPermissionName
    {
        //系统规则
        public const string UserWcfServiceFile = "UserWcfService.svc"; //用于测试定义的EF字段是否与数据库表一致
        public const string SystemWcfServiceFile = "SystemWcfService.svc";//任何人可以查看服务器时间

        public const string ShowWcfServiceDefine = "ShowWcfServiceDefine"; //开发人员可以查看Wcf接口
        public const string LoginAsWebAppInterfaceUser = "WcfUserService.svc/LoginAsWebAppInterfaceUser";//未登录web用户可以尝试登录应用程序接口
        public const string SignOut = "WcfUserService.svc/SignOut"; //已登录的Wpf用户或Web用户或WebAppInterfaceUser用户可退出

        //暂时未用规则
        public const string LoginAsWpfAnonymous = "WcfUserService.svc/LoginAsWpfAnonymous";//未登录的Web用户自动登录Wpf用户
        public const string LoginAsWpfUser = "WcfUserService.svc/LoginAsWpfUser";//未登录的Wpf用户可以尝试登录
        public const string LoginAsWebUser = "LoginService/LoginAsWebUser";//未登录的匿名Web用户可以尝试登录为网站用户
    }


    public class EnumOperation
    {
        public const string List = "List";
        public const string ReadOnly = "ReadOnly";
        public const string Create = "Create";
        public const string Update = "Update";
        public const string Delete = "Delete";
    }

}


