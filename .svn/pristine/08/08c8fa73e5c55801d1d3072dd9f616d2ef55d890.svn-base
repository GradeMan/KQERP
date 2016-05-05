using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web.Routing;
using System.Web;
using System.Web.Mvc;
using COM.Service;

namespace COM.Web
{
    public class MvcWebApplication : System.Web.HttpApplication
    {
        protected string defaultNamespace;
        public MvcWebApplication(string defaultNamespace)
        {
            this.defaultNamespace = defaultNamespace;
        }

        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new LogErrorAttribute());
            //filters.Add(new HandleErrorAttribute());
            filters.Add(new PermissionActionFilterAttribute());
        }

        public virtual void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{*allaxd}", new { allaxd = @".*\.axd(/.*)?" });
            routes.IgnoreRoute("{*allsvc}", new { allaxd = @".*\.svc(/.*)?" });
            routes.IgnoreRoute("{*allashx}", new { allaxd = @".*\.ashx(/.*)?" });
            routes.IgnoreRoute("{*favicon}", new { favicon = @"(.*/)?favicon.ico(/.*)?" });

            //这个表达式还用于Html.ActionLink()时反向生成Url
            routes.MapRoute("Default",
                            "{area}/{controller}/{action}/{id}", // URL with parameters
                            new { area = "Default", controller = "Home", action = "Index", id = UrlParameter.Optional },
                            new string[] { this.defaultNamespace }
                            );

        }

        protected virtual void Application_Start()
        {
            WebStartService.Instance.Start();
            RouteTable.Routes.RouteExistingFiles = false;
            AreaRegistration.RegisterAllAreas();
            RegisterRoutes(RouteTable.Routes);

            ViewEngines.Engines.Clear();
            ViewEngines.Engines.Add(new CustomerRazorViewEngine()); //注册自定义视图
            RegisterGlobalFilters(GlobalFilters.Filters);
            var configService = Unity.Instance.GetService<COM.Service.IConfigService>();
            if (!configService.DeployHostName.Contains("localhost"))
            {
                Unity.Instance.GetService<IScheduleService>().StartTask();
            }
        }

        protected virtual void Application_Error()
        {
            //这里无法捕获Wcf引发的异常
            //Server.GetLastError()为UnhandleException类型
            Exception exception = Server.GetLastError().GetBaseException();
            if (exception == null)
                exception = Server.GetLastError();

            if (exception is WebUserLoginException)
            {
                var loginException = (WebUserLoginException)exception;
                Server.ClearError(); //直接清除错误,不会显示错误页面,也不会在系统日志中记录错误
                string url = string.Format("{0}?returnUrl={1}", loginException.LoginUrl, Server.UrlEncode(loginException.CallbackUrl));
                HttpContext.Current.Response.Redirect(url, false);
                return;
            }

            string format = "WebAppError:{0}={1}\r\n{2}.Message:{3}\r\nStack:{4}\r\n";
            string errorInfo = string.Format(format,Request.HttpMethod, Request.Url, exception.GetType().Name, exception.Message, exception.StackTrace);
            var logErrorService = Unity.Instance.GetService<ILogErrorService>();
            logErrorService.LogWebAppError(errorInfo);
        }

        protected virtual void Application_End(object sender, EventArgs e)
        {
            Unity.Instance.GetService<IScheduleService>().Close();
        }
    }

}
