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
    public interface IWebPrincipalService : IPrincipalService
    {
        void SignIn(COM.Data.IPermissionUserPrincipal userPrincipal);
        void SignOut();
        void AuthenticateHttpRequest();
    }

}


