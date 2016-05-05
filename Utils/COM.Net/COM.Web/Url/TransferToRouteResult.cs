using System.Web.Mvc;
using System.Web.Routing;
using System.Web;
using System;

namespace COM.Web
{
    public class TransferToRouteResult : ActionResult
    {
        public string RouteName { get; set; }
        public object RouteValues { get; set; }

        private static string GetRouteURL(object routeValues)
        {
            UrlHelper url = new UrlHelper(new RequestContext(new HttpContextWrapper(HttpContext.Current), new RouteData()), RouteTable.Routes);
            return url.RouteUrl(routeValues);
        }

        public TransferToRouteResult(object routeValues)
            : this(null, routeValues)
        {
        }

        public TransferToRouteResult(string routeName, object routeValues)
        {
            this.RouteName = routeName ?? string.Empty;
            this.RouteValues = routeValues ?? new RouteValueDictionary();
        }

        public override void ExecuteResult(ControllerContext context)
        {
            if (context == null)
                throw new ArgumentNullException("context");

            var urlHelper = new UrlHelper(context.RequestContext);
            var url = urlHelper.RouteUrl(this.RouteName, this.RouteValues);

            var actualResult = new TransferResult(url);
            actualResult.ExecuteResult(context);
        }
    }


    /// <summary>
    /// Transfers execution to the supplied url.
    /// </summary>
    public class TransferResult : ActionResult
    {
        public string Url { get; private set; }

        public TransferResult(string url)
        {
            this.Url = url;
        }

        public override void ExecuteResult(ControllerContext context)
        {
            if (context == null)
                throw new ArgumentNullException("context");

            var httpContext = HttpContext.Current;

            // MVC 3 running on IIS 7+
            if (HttpRuntime.UsingIntegratedPipeline)
            {
                httpContext.Server.TransferRequest(this.Url, true);
            }
            else
            {
                // Pre MVC 3
                httpContext.RewritePath(this.Url, false);

                IHttpHandler httpHandler = new MvcHttpHandler();
                httpHandler.ProcessRequest(httpContext);
            }
        }
    }

    //public static class ControllerExtensions
    //{
    //    public static TransferToRouteResult TransferToAction(this Controller controller, ActionResult result)
    //    {
    //        return new TransferToRouteResult(result.GetRouteValueDictionary());
    //    }
    //}
}