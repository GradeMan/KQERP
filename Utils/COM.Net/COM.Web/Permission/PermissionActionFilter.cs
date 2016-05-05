using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace COM.Web
{
    [AttributeUsage(AttributeTargets.All, AllowMultiple = true)]
    public class PermissionActionFilterAttribute : ActionFilterAttribute
    {
        public override void OnActionExecuting(ActionExecutingContext filterContext)
        {
            base.OnActionExecuting(filterContext);
            var area = filterContext.Controller.ControllerContext.RouteData.Values["area"].ToString();
            var controller = filterContext.Controller.ControllerContext.RouteData.Values["controller"].ToString();
            var action = filterContext.Controller.ControllerContext.RouteData.Values["action"].ToString();

            var permissionService = Unity.Instance.GetService<IWebPermissionService>();
            var isAllow = permissionService.AllowActionOrLogin(filterContext.HttpContext.Request.HttpMethod, area, controller, action);
            if (isAllow)
            {
            }
            else
            {
                var loginUrl ="/Default/Account/LogOn";
                var callBackUrl = HttpContext.Current.Request.RawUrl.TrimEnd('/');
                string url = string.Format("{0}?returnUrl={1}", loginUrl, HttpUtility.UrlEncode(callBackUrl));
                filterContext.Result = new RedirectResult(url);
            }
        }

        public override void OnActionExecuted(ActionExecutedContext filterContext)
        {
            //this.SetActionOperate(filterContext);
            base.OnActionExecuted(filterContext);
        }

        private void NoCache(HttpResponseBase response)
        {
            response.Cache.SetNoStore();
            response.Cache.SetExpires(DateTime.MinValue);
            response.Cache.SetCacheability(HttpCacheability.NoCache);
            response.Cache.SetValidUntilExpires(false);
            response.CacheControl = "no-cache";
            response.Expires = -1;
            response.ExpiresAbsolute = DateTime.MinValue;
        }


        public override void OnResultExecuted(ResultExecutedContext filterContext)
        {
            base.OnResultExecuted(filterContext);
            //filterContext.HttpContext.Response.Write(@”<br />After ViewResult Excute” + “\t “ + Message);
        }


        public override void OnResultExecuting(ResultExecutingContext filterContext)
        {
            base.OnResultExecuting(filterContext);
            filterContext.HttpContext.Response.AddHeader("P3P", "CP=CAO PSA OUR");
            //filterContext.HttpContext.Response.AddHeader("P3P", "CP=CURa ADMa DEVa PSAo PSDo OUR BUS UNI PUR INT DEM STA PRE COM NAV OTC NOI DSP COR");
            
            this.NoCache(filterContext.HttpContext.Response);
            //filterContext.HttpContext.Response.Write(@”<br />Before ViewResult Excute” + “\t “ + Message);
        }


    }

}