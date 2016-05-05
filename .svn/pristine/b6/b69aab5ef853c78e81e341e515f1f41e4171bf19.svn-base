using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web.Mvc;
using COM.Service;
using Microsoft.Practices.Unity;
using COM.Data;

namespace COM.Web
{
    public interface ILoginService
    {
        //bool LoginAsEmployee(string userCode, string password);
        //bool LoginAsWebUser(string userCode, string password);
        bool LoginAsAdministrator(string userCode, string password);
        bool LoginAsWebInterfaceUser(string userCode, string password);
        void LogOut();
    }

    public class LoginService : ILoginService
    {
        private IWebPrincipalService webPrincipalService;
        private IWebConfigService configService;
        private IUserPrincipalFactory userPrincipalFactory;
        public LoginService(IUserPrincipalFactory userPrincipalFactory, IWebConfigService configService, IWebPrincipalService webPrincipalService)
        {
            this.webPrincipalService = webPrincipalService;
            this.configService = configService;
            this.userPrincipalFactory = userPrincipalFactory;
        }

        public bool LoginAsWpfAnonymous()
        {
            //Web匿名用户可以登录
            this.webPrincipalService.SignIn(this.userPrincipalFactory.WpfAnonymousPrincipal);
            return true;
        }

        public bool LoginAsWpfUser(string userCode, string password)
        {
            //Wpf匿名用户可以登录
            throw new ApplicationException("未实现Wpf应用客户端登录时的验证功能");
            //if (this.CheckUserAndPassword(userName, password))
            //    this.principalService.SignIn(PermissionUserPrincipal.Create(userName, new List<string>() { EnumPermissionRole.WpfUser }, userName, string.Empty));
            //return true;
        }

        public bool LoginAsWebAnonymous()
        {
            this.webPrincipalService.SignIn(this.userPrincipalFactory.WebAnonymousPrincipal);
            return true;
        }


        /// <summary>
        /// 已经通过了用户名密码检测
        /// </summary>
        /// <param name="userName"></param>
        /// <param name="password"></param>
        /// <returns></returns>
        public bool LoginAsAdministrator(string userCode, string password)
        {
            if (userCode.ToUpper() == "Admin".ToUpper() && password == "mhadmin")
            {
                var p = new COM.Service.PermissionUserPrincipal("Admin", "Admin",
                                                   new List<PermissionRole> 
                                                        { 
                                                            AdminPermissionRole.Instance,
                                                            WebUserPermissionRole.Instance,
                                                        }
                                                   );
                this.webPrincipalService.SignIn(p);
                return true;
            }
            return false;
        }
        
        /// <summary>
        /// 根据配置文件检测接口用户
        /// </summary>
        /// <param name="userCode"></param>
        /// <param name="password"></param>
        /// <returns></returns>
        public bool LoginAsWebInterfaceUser(string userCode, string password)
        {
            var q = from u in this.configService.UserList
                    where u.WebAppName == userCode && u.WebAppPassword == password
                    select u;
            var isCheckOk = (q.Count() > 0);

            if (isCheckOk)
            {
                var appInterfaceUser = this.configService.UserList.Where(u => u.WebAppName == userCode).Single();
                var p = this.userPrincipalFactory.CreateWebInterfacePrincipal(appInterfaceUser.InterfaceRole);
                this.webPrincipalService.SignIn(p);
                return true;
            }
            return false;
        }

        public void LogOut()
        {
            this.webPrincipalService.SignOut();
        }



        public virtual bool LoginAsWebUser(string userCode, string password)
        {
            //if(this.loginUserAccountService.CheckUserPassword(userCode,password))
            //{
            //var p = new PermissionUserPrincipal(userCode, userCode,
            //                                       new List<COM.Service.PermissionRole> 
            //                                            { 
            //                                                WebUserPermissionRole.Instance,
            //                                            }
            //                                       );
            //this.webPrincipalService.SignIn(p);
            //return true;
            //}
            //return false;
            throw new NotImplementedException();
        }


        //Todo:登录为职员
        public virtual bool LoginAsEmployee(string userCode, string password)
        {
            throw new NotImplementedException();
            //if(this.loginUserAccountService.CheckUserPassword(userCode,password))
            //{
            //    //var user = userService.GetUser(userCode);
            //    string userName = string.Empty; //user.Name
            //    var p = this.userPrincipalFactory.CreateEmployeePrincipal(userCode,userName, deptCode:string.Empty);
            //    this.webPrincipalService.SignIn(p);
            //    return true;
            //}
            //return false;
        }

    }
}
