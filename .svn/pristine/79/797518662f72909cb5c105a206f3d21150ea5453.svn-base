using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Xml.Linq;
using COM.Service;
using COM.Data;

namespace COM.Web
{

    public interface IUserPrincipalFactory
    {
        //IPermissionUserPrincipal CreateEmployeePrincipal(string userCode, string userName, string deptCode);
        IPermissionUserPrincipal CreateUserPrincipal(XElement userDataXML);
        IPermissionUserPrincipal CreateWebInterfacePrincipal(string appName);
        IPermissionUserPrincipal WebAnonymousPrincipal { get; }
        IPermissionUserPrincipal WpfAnonymousPrincipal { get; }
    }

    /// <summary>
    /// 此为单例服务,不依赖别的服务
    /// 当负责正在登录的用户创建相应的角色
    /// 也负责给已登录的用户反序列化角色
    /// 包括用户名,角色信息,鉴权参数
    /// </summary>
    public partial class UserPrincipalFactory : IUserPrincipalFactory
    {
        private IPermissionRoleListService permissionRoleListService;
        public UserPrincipalFactory(IPermissionRoleListService permissionRoleListService)
        {
            this.permissionRoleListService = permissionRoleListService;
        }

        public IPermissionUserPrincipal CreateUserPrincipal(XElement userDataXML)
        {
            var roleList = userDataXML.Elements("r").Select(x =>
            {
                var role = this.CreatePermissionRoleByType(x.Value);
                role.ParseXml(x);
                return role;
            }).ToList();

            var userCode = userDataXML.Attribute("u").Value;
            var userName = userDataXML.Attribute("n").Value;
            return new PermissionUserPrincipal(userCode, userName, roleList);
        }

        private PermissionRole CreatePermissionRoleByType(string enumRoleType)
        {
            if (string.Compare(enumRoleType, "_Any", true) == 0)
                return AnyPermissionRole.Instance;
            else if (string.Compare(enumRoleType, "_WebAnonymous", true) == 0)
                return WebAnonymousPermissionRole.Instance;
            else if (string.Compare(enumRoleType, "_WpfAnonymous", true) == 0)
                return WpfAnonymousPermissionRole.Instance;
            else if (string.Compare(enumRoleType, "_WebUser", true) == 0)
                return WebUserPermissionRole.Instance;
            else if (string.Compare(enumRoleType, "_Administrator", true) == 0)
                return AdminPermissionRole.Instance;
            else if (string.Compare(enumRoleType, "_WpfUser", true) == 0)
                return WpfUserPermissionRole.Instance;
            else if (string.Compare(enumRoleType, "_Dev", true) == 0)
                return DevPermissionRole.Instance;
            else
            {
                var roleType = this.permissionRoleListService.GetRoleTypeByName(enumRoleType);
                return roleType == null ? WebAnonymousPermissionRole.Instance : Activator.CreateInstance(roleType) as PermissionRole;
            }

        }
    }

}