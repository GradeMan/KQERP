using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;
using System.Security.Principal;
using System.Xml.Linq;
using Microsoft.Practices.Unity;
using COM.Service;

namespace COM.Web
{

    public interface IWebPermissionServiceAction
    {
        bool TryTestAllowAction(string httpMethod, string ns, string controller, string action);
        //bool AllowAction(string httpMethod, string ns, string controller, string action);
        bool AllowActionOrLogin(string httpMethod, string ns, string controller, string action);
    }

    /// <summary>
    /// 角色/功能的绑定
    /// </summary>
    public class WebPermissionServiceAction : IWebPermissionServiceAction
    {
        private IHttpRequestService httpRequestService;
        private IPrincipalService principalService;
        private IRoleActionDataService roleActionDataService;
        public WebPermissionServiceAction(IPrincipalService principalService, IHttpRequestService httpRequestService, IRoleActionDataService roleActionDataService)
        {
            this.httpRequestService = httpRequestService;
            this.roleActionDataService = roleActionDataService;
            this.principalService = principalService;
        }


        public bool TryTestAllowAction(string httpMethod, string ns, string controller, string action)
        {
            if (!this.roleActionDataService.HasRegisted(httpMethod, ns, controller, action))
                return true;

            //注册过的,如果一致才允许调用
            foreach (var item in this.principalService.CurrentUser.RoleNameList)
            {
                if (this.roleActionDataService.HasAction(item, httpMethod, ns, controller, action))
                    return true;
            }

            return false;
        }


        /// <summary>
        /// 
        /// </summary>
        /// <param name="httpMethod"></param>
        /// <param name="ns"></param>
        /// <param name="controller"></param>
        /// <param name="action"></param>
        /// <param name="callbackUrl">如果为空值,返回验证失败的页面</param>
        /// <returns>返回false,应该停止继续执行,已请求已重定向</returns>
        public bool AllowActionOrLogin(string httpMethod, string ns, string controller, string action)
        {
            if (this.TryTestAllowAction(httpMethod, ns, controller, action))
            {
                return true;
            }
            else
            {
                if (string.Compare(httpMethod, "Get", true) == 0)
                {
                    string enumIfHasNoPermissionThen = this.roleActionDataService.GetEnumCheckActionPermissionResult(ns, controller, action);
                    if (enumIfHasNoPermissionThen == EnumIfHasNoPermissionThen.Exception)
                    {
                        throw new COM.Data.PermissionException() { PermissionName = string.Format("Action:[{0}]{1}/{2}/{3}", httpMethod, ns, controller, action) };
                    }
                    else if (enumIfHasNoPermissionThen == EnumIfHasNoPermissionThen.Login)
                    {
                        return false;
                    }
                    else
                    {
                        throw new COM.Data.PermissionException() { PermissionName = string.Format("Action:[{0}]{1}/{2}/{3}", httpMethod, ns, controller, action) };
                    }

                }
                else
                {
                    throw new COM.Data.PermissionException() { PermissionName = string.Format("Action:[{0}]{1}/{2}/{3}", httpMethod, ns, controller, action) };
                }

            }
        }

        public bool AllowAction(string httpMethod, string ns, string controller, string action)
        {
            if (!this.TryTestAllowAction(httpMethod, ns, controller, action))
                throw new COM.Data.PermissionException() { PermissionName = string.Format("Action:[{0}]{1}/{2}/{3}", httpMethod, ns, controller, action) };
            return true;
        }


    }

}


