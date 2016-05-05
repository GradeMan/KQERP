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
    /// 扩展了最基础的鉴权规则,实对网站功能权限的鉴权
    /// </summary>
    public interface IWebPermissionService : IPermissionService
    {
        bool AllowUrl(string httpMethod, string url); //用于验证所有请求的入口
        bool AllowFile(string httpMethod, string fileName);
        bool AllowController(string httpMethod, string ns, string controller); //用于验证所有请求的Controller
        bool AllowOperateOrLogin(string enumPermissionName, string callbackUrl = null); //登录失败，自动转向到登录页面
        bool AllowActionOrLogin(string httpMethod, string ns, string controller, string action); //登录失败，自动转向到登录页面
        bool AllowFileOrLogin(string httpMethod, string fileName, string callbackUrl = null); //登录失败，自动转向到登录页面
    }

    public class WebPermissionService : IWebPermissionService
    {
        private IPermissionItemService permissionService;
        private IWebPermissionServiceAction webPermissionServiceAction;
        private IWebPermissionServiceFile webPermissionServiceFile;
        private IHttpRequestService httpRequestService;
        private IPrincipalService principalService;
        public WebPermissionService(IPrincipalService principalService,IHttpRequestService httpRequestService, IPermissionItemService permissionService, IWebPermissionServiceAction webPermissionServiceAction, IWebPermissionServiceFile webPermissionServiceFile)
        {
            this.principalService = principalService;
            this.httpRequestService = httpRequestService;
            this.permissionService = permissionService;
            this.webPermissionServiceAction = webPermissionServiceAction;
            this.webPermissionServiceFile = webPermissionServiceFile;
        }

        public bool AllowOperateOrLogin(string enumPermissionName, string callbackUrl = null)
        {
            if (!this.TryTestAllowPermissionItem(enumPermissionName))
                throw new WebUserLoginException()
                {
                    PermissionName = enumPermissionName,
                    LoginUrl = string.Format("http://{0}/{1}", this.httpRequestService.WebSiteName, @"Default/Account/LogOn"),
                    CallbackUrl = string.IsNullOrEmpty(callbackUrl) ? HttpContext.Current.Request.RawUrl
                                    : string.Format("http://{0}/{1}", this.httpRequestService.WebSiteName, callbackUrl.Trim('/'))
                };
            return true;
        }


        public bool AllowUrl(string httpMethod, string url)
        {
            throw new NotImplementedException();
        }

        public bool AllowController(string httpMethod, string ns, string controller)
        {
            throw new NotImplementedException();
        }

        public bool TryTestAllowPermissionItem(string enumPermissionName)
        {
            if (enumPermissionName.StartsWith("Action:", StringComparison.OrdinalIgnoreCase))
            {
                var actionUrl = enumPermissionName.Substring("Action:".Length);
                var mvc = actionUrl.Trim('/').Split('/');
                if (mvc.Length != 3)
                    throw new AppException("定义的Mvc.Action={0}错误", enumPermissionName);
                return this.webPermissionServiceAction.TryTestAllowAction("Get",ns:mvc[0],controller:mvc[1],action:mvc[2]);
            }
            else if (enumPermissionName.StartsWith("File:", StringComparison.OrdinalIgnoreCase))
            {
                return this.webPermissionServiceFile.TryTestAllowFile("Get", enumPermissionName.Substring("File:".Length));
            }
            else
            {
                return this.permissionService.TryTestAllowPermissionItem(enumPermissionName);
            }

            throw new ApplicationException();
        }


        public bool AllowFile(string httpMethod, string fileName)
        {
            return this.webPermissionServiceFile.AllowFile(httpMethod,fileName);
        }


        public bool AllowActionOrLogin(string httpMethod, string ns, string controller, string action)
        {
            return this.webPermissionServiceAction.AllowActionOrLogin(httpMethod, ns, controller, action);
        }

        public bool AllowFileOrLogin(string httpMethod, string fileName, string callbackUrl = null)
        {
            return this.webPermissionServiceFile.AllowFileOrLogin(httpMethod, fileName, callbackUrl);
        }

        public bool AllowPermissionItem(string enumPermissionName)
        {
            if (!this.TryTestAllowPermissionItem(enumPermissionName))
                throw new PermissionException() { PermissionName = enumPermissionName };
            return true;
        }

        public IPermissionUserPrincipal CurrentUser
        {
            get 
            {
                return this.principalService.CurrentUser;
            }
        }

    }


}


