using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using System.Xml.Linq;
using System.Web.Mvc;

namespace COM.Web
{
    public abstract class NameSpaceAreaRegistration : AreaRegistration
    {
        private string appNamespace;
        public NameSpaceAreaRegistration(string appNamespace)
        {
            this.appNamespace = appNamespace;
        }

        public override void RegisterArea(AreaRegistrationContext context)
        {
            var mvcUrl = string.Format("{0}/{{controller}}/{{action}}/{{id}}", this.AreaName);
            var defaultMvcParm = new { area = this.AreaName, controller = "Home", action = "Index", id = UrlParameter.Optional };
            var route = new MvcRouter(mvcUrl, new MvcRouteHandler())
                                     {
                                         Defaults = new System.Web.Routing.RouteValueDictionary(defaultMvcParm),
                                         DataTokens = new System.Web.Routing.RouteValueDictionary(new { area = this.AreaName, namespaces = new[] { string.Format("{0}.{1}.Controllers",this.appNamespace,this.AreaName) } })
                                     };
            context.Routes.Add(string.Format("{0}_default", this.AreaName),route);
         }

       
    }
}
