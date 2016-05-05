using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;
using System.Security.Principal;
using System.Xml.Linq;
using COM.Service;
using COM.Data;

namespace COM.Web
{
    public class WebPrincipalService : IWebPrincipalService
    {
        private IConfigService configService;
        private IUserPrincipalFactory userPrincipalFactory;
        public WebPrincipalService(IPermissionRoleListService permissionRoleListService, IUserPrincipalFactory userPrincipalFactory, IConfigService configService)
        {
            this.userPrincipalFactory = userPrincipalFactory;
            this.configService = configService;
        }

        public IPermissionUserPrincipal CurrentUser
        {
            get
            {
                var user = HttpContext.Current.User as IPermissionUserPrincipal;
                if (!user.IsRole<AnyPermissionRole>())
                    user.RoleList.Add(AnyPermissionRole.Instance);

                if (this.configService.IsDebug)
                {
                    if (user.IsRole<WebAnonymousPermissionRole>())
                    {
                        //调试模式下,自动登录为开发人员角色
                        user.RoleList.Remove(WebAnonymousPermissionRole.Instance);

                        if (!user.IsRole<DevPermissionRole>())
                            user.RoleList.Add(new DevPermissionRole());
                    }
                }
                return user;
            }
        }

        public void SignIn(IPermissionUserPrincipal permissionPrincipal)
        {
            var userPrincipal = permissionPrincipal as COM.Service.PermissionUserPrincipal;
            this.SignInUser(userPrincipal.Identity.Name, userPrincipal.UserDataXML.ToString(), false);
            HttpContext.Current.User = userPrincipal;
        }

        private void SignInUser(string userName, string userData, bool createPersistentCookie)
        {
            //保存到Cookie
            //FormsAuthentication.SetAuthCookie(userName, createPersistentCookie);
            var ticket = new System.Web.Security.FormsAuthenticationTicket(1, userName, DateTime.Now, DateTime.Now.AddYears(5), false, userData);
            string encryptedTicket = System.Web.Security.FormsAuthentication.Encrypt(ticket);
            var authCookie = new System.Web.HttpCookie(System.Web.Security.FormsAuthentication.FormsCookieName, encryptedTicket);
            authCookie.HttpOnly = true;
            System.Web.HttpContext.Current.Response.Cookies.Set(authCookie);
            //string url = FormsAuthentication.GetRedirectUrl("username", false);
            //Response.Redirect(url);
        }

        public void SignOut()
        {
            System.Web.Security.FormsAuthentication.SignOut();
            var cookieName = System.Web.Security.FormsAuthentication.FormsCookieName;
            var authCookie = HttpContext.Current.Request.Cookies[cookieName];
            if (authCookie != null)
            {
                authCookie.Expires = DateTime.Now.AddHours(-48);
                HttpContext.Current.Response.Cookies.Set(authCookie);
            }
            HttpContext.Current.User = this.userPrincipalFactory.WebAnonymousPrincipal;
        }

        public void AuthenticateHttpRequest()
        {
            var context = HttpContext.Current;
            HttpCookie authCookie = context.Request.Cookies[System.Web.Security.FormsAuthentication.FormsCookieName];
            if (authCookie == null || string.IsNullOrEmpty(authCookie.Value))
            {
                context.User = this.userPrincipalFactory.WebAnonymousPrincipal;
                return;
            }
            try
            {
                //从Cookie读取用户名和角色,验证通过
                var authTicket = System.Web.Security.FormsAuthentication.Decrypt(authCookie.Value);
                var xml = XElement.Parse(authTicket.UserData);
                context.User = this.userPrincipalFactory.CreateUserPrincipal(xml);
                return;
            }
            catch(Exception e)
            {
                if (this.configService.IsDebug)
                    throw e;
                context.User = this.userPrincipalFactory.WebAnonymousPrincipal;
                return;
            }

            //throw new ApplicationException("验证用户身份出错!");
            //System.Threading.Thread.CurrentPrincipal = p;
            //System.ServiceModel.OperationContext.Current.InstanceContext.
        }


    }


}


