using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;
using System.Security.Principal;
using System.Xml.Linq;
using COM.Service;
using COM.Data;

namespace COM.Web
{

    /// <summary>
    /// 没有扩展鉴权参数
    /// </summary>
    public class AdminPermissionRole : PermissionRole
    {
        private static AdminPermissionRole instance;
        public static AdminPermissionRole Instance
        {
            get
            {
                return instance ?? (instance = new AdminPermissionRole());
            }
        }

        public override string EnumRoleName
        {
            get
            {
                return "_Administrator";
            }
        }

    }


    /// <summary>
    /// 未登录的Web用户
    /// </summary>
    public class WebAnonymousPermissionRole : PermissionRole
    {

        public override bool IsAuthenticated
        {
            get
            {
                return false;
            }
        }

        private static WebAnonymousPermissionRole instance;
        public static WebAnonymousPermissionRole Instance
        {
            get
            {
                return instance ?? (instance = new WebAnonymousPermissionRole());
            }
        }

        public override string EnumRoleName
        {
            get
            {
                return "_WebAnonymous";
            }
        }

        public string UserCode 
        {
            get
            {
                return "_WebAnonymous";
            }
        }

    }

    public class WpfAnonymousPermissionRole : PermissionRole
    {
        public override bool IsAuthenticated
        {
            get
            {
                return false;
            }
        }

        private static WpfAnonymousPermissionRole instance;
        public static WpfAnonymousPermissionRole Instance
        {
            get
            {
                return instance ?? (instance = new WpfAnonymousPermissionRole());
            }
        }

        public override string EnumRoleName
        {
            get
            {
                return "_WpfAnonymous";
            }
        }

        public string UserCode
        {
            get
            {
                return "_WpfAnonymous";
            }
        }
    }

    /// <summary>
    /// 已登录的Web用户,通常用户还会映射到一个资源角色:职员或供应商或客户
    /// 所有已验证的用户
    /// </summary>
    public class WebUserPermissionRole : PermissionRole
    {
        private static WebUserPermissionRole instance;
        public static WebUserPermissionRole Instance
        {
            get
            {
                return instance ?? (instance = new WebUserPermissionRole());
            }
        }

        public override string EnumRoleName
        {
            get
            {
                return "_WebUser";
            }
        }

        public string UserCode
        {
            get
            {
                return "_WebUser";
            }
        }

    }

    /// <summary>
    /// Web应用接口鉴权用
    /// </summary>
    public class WebInterfacePermissionRole : PermissionRole
    {
        private static WebInterfacePermissionRole instance;
        public static WebInterfacePermissionRole Instance
        {
            get
            {
                return instance ?? (instance = new WebInterfacePermissionRole());
            }
        }

        public override string EnumRoleName
        {
            get
            {
                return "_WebInterface";
            }
        }

        public string UserCode
        {
            get
            {
                return "_WebInterface";
            }
        }
 
    }

    public class WpfUserPermissionRole : PermissionRole
    {
        private static WpfUserPermissionRole instance;
        public static WpfUserPermissionRole Instance
        {
            get
            {
                return instance ?? (instance = new WpfUserPermissionRole());
            }
        }

        public override string EnumRoleName
        {
            get
            {
                return "_WpfUser";
            }
        }
    }



    /// <summary>
    /// 开发人员内置账号,可以读取WCF发布的声明文件
    /// </summary>
    public class DevPermissionRole : PermissionRole
    {
        private static DevPermissionRole instance;
        public static DevPermissionRole Instance
        {
            get
            {
                return instance ?? (instance = new DevPermissionRole());
            }
        }

        public override string EnumRoleName
        {
            get
            {
                return "_Dev";
            }
        }
    }


}


