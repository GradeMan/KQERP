using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;
using System.Security.Principal;
using System.Web.Mvc;
using COM.Service;

namespace COM.Web
{
    public class PermissionHttpModule : IHttpModule
    {
        public void Dispose()
        {
        }

        public void Init(HttpApplication context)
        {
            context.AuthenticateRequest += new EventHandler(context_AuthenticateRequest);
            context.PreRequestHandlerExecute += new EventHandler(context_PreRequestHandlerExecute);
        }

        void context_AuthenticateRequest(object sender, EventArgs e)
        {
            var principalService = Unity.Instance.GetService<IWebPrincipalService>();
            principalService.AuthenticateHttpRequest();
        }

        void context_PreRequestHandlerExecute(object sender, EventArgs e)
        {
            var permissionService = Unity.Instance.GetService<IWebPermissionService>();
            if (!permissionService.AllowFile(HttpContext.Current.Request.HttpMethod, HttpContext.Current.Request.FilePath))
                throw new COM.Data.PermissionException() { PermissionName = HttpContext.Current.Request.RawUrl };
        }


    }

}

