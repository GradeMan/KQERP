using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;
using System.Security.Principal;
using System.Xml.Linq;
using COM.Service;

namespace COM.Web
{
    public interface IWebPermissionServiceFile
    {
        bool TryTestAllowFile(string httpMethod, string fileName);
        bool AllowFile(string httpMethod, string fileName);
        bool AllowFileOrLogin(string httpMethod, string fileName, string callbackUrl = null);
    }

    public class WebPermissionServiceFile : IWebPermissionServiceFile
    {
        private IHttpRequestService httpRequestService;
        private IPrincipalService principalService;
        private IRoleFileDataService roleFileDataService;
        public WebPermissionServiceFile(IPrincipalService principalService, IHttpRequestService httpRequestService, IRoleFileDataService roleFileDataService)
        {
            this.httpRequestService = httpRequestService;
            this.roleFileDataService = roleFileDataService;
            this.principalService = principalService;
        }

        public bool AllowFile(string httpMethod, string fileName)
        {
            if (!this.TryTestAllowFile(httpMethod, fileName))
                throw new COM.Data.PermissionException() { PermissionName = string.Format("File:[{0}]{1}", httpMethod, fileName) };
            return true;
        }

        public bool TryTestAllowFile(string httpMethod, string fileName)
        {
            //如果从未注册过的File,谁都可以调用
            if (!this.roleFileDataService.HasRegisted(httpMethod, fileName))
                return true;

            //注册过的,如果一致才允许调用
            foreach (var item in this.principalService.CurrentUser.RoleNameList)
            {
                if(this.roleFileDataService.HasFile(item,httpMethod,fileName))
                    return true;
            }

            return false;
        }


        /// <summary>
        /// 打不开文件则自动转向登录
        /// </summary>
        /// <param name="httpMethod"></param>
        /// <param name="ns"></param>
        /// <param name="controller"></param>
        /// <param name="action"></param>
        /// <param name="callbackUrl">如果为空值,返回验证失败的页面</param>
        /// <returns></returns>
        public bool AllowFileOrLogin(string httpMethod, string fileName, string callbackUrl = null)
        {
            if (!this.TryTestAllowFile(httpMethod, fileName))
                throw new WebUserLoginException()
                {
                    PermissionName = string.Format("File:[{0}]{1}", httpMethod, fileName),
                    LoginUrl = string.Format("http://{0}/{1}", this.httpRequestService.WebSiteName, @"Default/Account/LogOn"),
                    CallbackUrl = string.IsNullOrEmpty(callbackUrl) ? HttpContext.Current.Request.RawUrl
                                    : string.Format("http://{0}/{1}", this.httpRequestService.WebSiteName, callbackUrl.Trim('/'))
                };
            return true;
        }


    }

}


