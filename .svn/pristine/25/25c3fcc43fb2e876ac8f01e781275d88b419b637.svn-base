using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace COM.Web
{
    public class MvcRouter : Route
    {
        public MvcRouter(string url, IRouteHandler routeHandler)
            : base(url, routeHandler)
        {
        }

        public override RouteData GetRouteData(HttpContextBase httpContext)
        {
            var routeData = base.GetRouteData(httpContext);
            if (routeData == null)
                return null;

            //var permissionService = UnityService.Instance.GetService<IWebPermissionService>();
            //permissionService.AllowAction(httpContext.Request.HttpMethod, routeData.Values["area"].ToString(), routeData.Values["controller"].ToString(), routeData.Values["action"].ToString());
            return routeData;
        }
    }
}