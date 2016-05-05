using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web.Mvc;
using System.Web;

namespace COM.Web
{
    public class LogErrorAttribute : FilterAttribute, IExceptionFilter
    {
        public void OnException(ExceptionContext filterContext)
        {
            if (filterContext.Exception is WebUserLoginException)
            {
                var loginException = (WebUserLoginException)filterContext.Exception;
                string url = string.Format("{0}?returnUrl={1}", loginException.LoginUrl, HttpUtility.UrlEncode(loginException.CallbackUrl));
                System.Web.HttpContext.Current.Response.Redirect(url);
                filterContext.ExceptionHandled = true; //不会显示错误页面,也不会在系统日志中记录错误
                return;
            }

            //更多权限错误信息,如果是未登录用户引发的,都忽略
            if (filterContext.Exception is COM.Data.PermissionException)
            {
                var request = filterContext.RequestContext.HttpContext.Request;
                if (request != null && string.Compare(request.HttpMethod,"Get",true) == 0)
                {
                    var user = filterContext.RequestContext.HttpContext.User;
                    if (user.Identity.Name == WebAnonymousPermissionRole.Instance.UserCode)
                    {
                        LogException(filterContext); //记录错误,但不引发异常,保护服务器,通常是莫名其妙的浏览器Get引发的异常.
                        filterContext.ExceptionHandled = true; //不会显示错误页面,也不会再次引发WebApp异常
                        return;
                    }
                }
            }

            //会重定向到自定义错误页面,并再次引发WebApp异常
            this.LogException(filterContext);
        }

        private void LogException(ExceptionContext filterContext)
        {
            var exception = filterContext.Exception;
            var url = filterContext.RequestContext.HttpContext.Request.Url;
            var method = filterContext.RequestContext.HttpContext.Request.HttpMethod;
            string format = "MvcError:{0}={1}\r\n{2}.Message:{3}\r\nStack:{4}\r\n";
            string errorInfo = string.Format(format,method, url, exception.GetType().Name, exception.Message, exception.StackTrace);
            var logErrorService = Unity.Instance.GetService<COM.Service.ILogErrorService>();
            logErrorService.LogMvcError(errorInfo);
        }
    }
}
