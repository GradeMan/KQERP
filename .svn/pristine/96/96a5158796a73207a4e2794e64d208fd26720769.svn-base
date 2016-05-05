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
    public class ActionPermission
    {
        public ActionPermission()
        {
            this.EnumIfHasNoPermissionThen = COM.Web.EnumIfHasNoPermissionThen.Exception;
        }

        public string HttpMethod { get; set; }
        public string Namespace { get; set; }
        public string Controller { get; set; }
        public string Action { get; set; }
        public string EnumIfHasNoPermissionThen { get; set; }
    }

    public class EnumIfHasNoPermissionThen
    {
        public static readonly string Exception = "Exception";
        public static readonly string Login = "Login";
    }


    public interface IRoleActionDataService : ICacheServiceBase
    {
        string GetEnumCheckActionPermissionResult(string ns, string controller, string action);
        bool HasRegisted(string httpMethod, string ns, string controller, string action);
        bool HasAction(string roleName,string httpMethod, string ns, string controller, string action);
        IRoleActionDataService AddRoleAction(string roleName, List<ActionPermission> permissionList);
        IRoleActionDataService AddRoleAction<T>(List<ActionPermission> permissionList) where T : PermissionRole;
    }

    public class RoleActionDataService : IRoleActionDataService
    {
        private IPermissionRoleListService permissionRoleListService;
        public RoleActionDataService(IPermissionRoleListService permissionRoleListService)
        {
            this.permissionRoleListService = permissionRoleListService;
        }

        private Dictionary<string, List<ActionPermission>> roleActionList;
        private Dictionary<string, List<ActionPermission>> RoleActionList
        {
            get
            {
                if(this.roleActionList == null)
                {
                    this.roleActionList = new Dictionary<string,List<ActionPermission>>();
                    if (this.EventReload != null)
                        this.EventReload(this, EventArgs.Empty);
                }
                return this.roleActionList;
            }
        }

        public bool HasRegisted(string httpMethod, string ns, string controller, string action)
        {
            //Todo:可以优化,把已注册的Action存为静态变量
            //如果从未注册过的Action,谁都可以调用
            var allAction = this.RoleActionList.SelectMany(i => i.Value).ToList();
            return allAction.Any(i => this.IsAction(i, httpMethod, ns, controller, action));
        }


        public bool HasAction(string roleName, string httpMethod, string ns, string controller, string action)
        {
            if (this.RoleActionList.ContainsKey(roleName))
                if (this.RoleActionList[roleName].Any(i => this.IsAction(i, httpMethod, ns, controller, action)))
                    return true;
            return false;
        }

        private bool IsAction(ActionPermission actionPermission, string httpMethod, string ns, string controller, string action)
        {
            if (!(actionPermission.HttpMethod == "*" || string.Compare(actionPermission.HttpMethod, httpMethod, true) == 0))
                return false;

            if (!(actionPermission.Namespace == "*" || string.Compare(actionPermission.Namespace, ns, true) == 0))
                return false;

            if (!(actionPermission.Controller == "*" || string.Compare(actionPermission.Controller, controller, true) == 0))
                return false;

            if (!(actionPermission.Action == "*" || string.Compare(actionPermission.Action, action, true) == 0))
                return false;

            return true;
        }


        public IRoleActionDataService AddRoleAction<T>(List<ActionPermission> actionPermissionList) where T : PermissionRole
        {
            return this.AddRoleAction(this.permissionRoleListService.GetRoleNameByType<T>(), actionPermissionList);
        }

        public IRoleActionDataService AddRoleAction(string roleName, List<ActionPermission> actionPermissionList)
        {
            if (!this.RoleActionList.ContainsKey(roleName))
                this.RoleActionList.Add(roleName, new List<ActionPermission>());
            this.RoleActionList[roleName].AddRange(actionPermissionList);
            return this;
        }

        public void Reload()
        {
            this.roleActionList = null;
        }


        public event EventHandler EventReload;

        public string GetEnumCheckActionPermissionResult(string ns, string controller, string action)
        {
            var allAction = this.RoleActionList.SelectMany(i => i.Value).ToList();
            var registedList = allAction.Where(i => this.IsAction(i, "Get", ns, controller, action)).ToList();
            if (registedList.Count == 0)
                return string.Empty;

            if (registedList.Any(i => i.EnumIfHasNoPermissionThen == EnumIfHasNoPermissionThen.Login))
                return EnumIfHasNoPermissionThen.Login;
            else
                return EnumIfHasNoPermissionThen.Exception;
        }
    }

}


