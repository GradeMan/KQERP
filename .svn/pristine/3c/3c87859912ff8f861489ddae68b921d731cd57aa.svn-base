using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Xml.Linq;
using COM.Service;
using COM.Data;

namespace COM.Web
{
    public partial class UserPrincipalFactory : IUserPrincipalFactory
    {
        //Todo:视所有未登录的用户都是同一个账号,不是好办法,待改进,应临时分配一个随机账号,角色实例为同一个
        static private IPermissionUserPrincipal webAnonymousPrincipal;
        public IPermissionUserPrincipal WebAnonymousPrincipal
        {
            get
            {
                if (webAnonymousPrincipal == null)
                {
                    webAnonymousPrincipal = new PermissionUserPrincipal(WebAnonymousPermissionRole.Instance.UserCode,
                                                           string.Empty,
                                                           new List<PermissionRole> { WebAnonymousPermissionRole.Instance }
                                                          );
                }
                return webAnonymousPrincipal;
            }
        }

        //Todo:视所有未登录的用户都是同一个账号,不是好办法,待改进,应临时分配一个随机账号,角色实例为同一个
        static private IPermissionUserPrincipal wpfAnonymousPrincipal;
        public IPermissionUserPrincipal WpfAnonymousPrincipal
        {
            get
            {
                if (wpfAnonymousPrincipal == null)
                {
                    wpfAnonymousPrincipal = new PermissionUserPrincipal(WpfAnonymousPermissionRole.Instance.UserCode,
                                                            string.Empty,
                                                            new List<PermissionRole> { WpfAnonymousPermissionRole.Instance }
                                                           );
                }
                return wpfAnonymousPrincipal;
            }
        }

        public IPermissionUserPrincipal CreateWebInterfacePrincipal(string webInterfaceAppName)
        {
            var user = new PermissionUserPrincipal(webInterfaceAppName,
                                                   webInterfaceAppName,
                                                   new List<PermissionRole> 
                                                        { 
                                                            WebInterfacePermissionRole.Instance,
                                                            this.CreatePermissionRoleByType(webInterfaceAppName),
                                                        }
                                                   );
            return user;
        }

        public virtual IPermissionUserPrincipal CreateEmployeePrincipal(string userCode, string userName, string deptCode)
        {
            //var user = new PermissionUserPrincipal(userCode,
            //                                      userName,
            //                                      new List<PermissionRole> 
            //                                            { 
            //                                                WebUserPermissionRole.Instance,
            //                                                new EmployeePermissionRole(userCode,userName,deptCode:string.Empty) 
            //                                            }
            //                                      );
            //return user;
            throw new NotImplementedException();
        }

       
    }
}