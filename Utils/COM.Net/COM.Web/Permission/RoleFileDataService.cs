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
    public class FilePermission
    {
        public string HttpMethod { get; set; }
        public string FileName { get; set; }
    }

    public interface IRoleFileDataService:ICacheServiceBase
    {
        bool HasRegisted(string httpMethod, string fileName);
        bool HasFile(string roleName, string httpMethod, string fileName);
        IRoleFileDataService AddRoleFile(string roleName, List<FilePermission> permissionList);
        IRoleFileDataService AddRoleFile<T>(List<FilePermission> permissionList) where T : PermissionRole;
    }

    public class RoleFileDataService : IRoleFileDataService
    {
        private IPermissionRoleListService permissionRoleListService;
        public RoleFileDataService(IPermissionRoleListService permissionRoleListService)
        {
            this.permissionRoleListService = permissionRoleListService;
        }

        private Dictionary<string, List<FilePermission>> roleFileList;
        private Dictionary<string, List<FilePermission>> RoleFileList
        {
            get
            {
                if (this.roleFileList == null)
                {
                    this.roleFileList = new Dictionary<string, List<FilePermission>>();
                    if (this.EventReload != null)
                        this.EventReload(this, EventArgs.Empty);
                }
                return this.roleFileList;
            }
        }

        public bool HasRegisted(string httpMethod, string fileName)
        {
            //wcf.svc文件,认为是注册过的,不必注册,没有权限也不得调用
            if (fileName.EndsWith(".svc", StringComparison.OrdinalIgnoreCase))
                return true;

            //如果从未注册过的File,谁都可以调用
            var allFile = this.RoleFileList.SelectMany(i => i.Value).ToList();
            if (allFile.Any(i => this.IsFile(i, httpMethod, fileName)))
                return true;

            return false;
        }


        public bool HasFile(string roleName, string httpMethod, string fileName)
        {
            if (this.RoleFileList.ContainsKey(roleName))
                if (this.RoleFileList[roleName].Any(i => this.IsFile(i, httpMethod, fileName)))
                    return true;
            return false;
        }

        private bool IsFile(FilePermission filePermission, string httpMethod, string fileName)
        {
            if (!(filePermission.HttpMethod == "*" || string.Compare(filePermission.HttpMethod, httpMethod, true) == 0))
                return false;

            var request = fileName.Trim('/');

            if (string.Compare("*" + System.IO.Path.GetExtension(request), filePermission.FileName, true) == 0)
                return true;

            request = string.Format("/{0}/", request);
            var permission = string.Format("/{0}/", filePermission.FileName.Trim('/'));

            if (!(request.EndsWith(permission, StringComparison.OrdinalIgnoreCase)))
                return false;

            return true;
        }


        public IRoleFileDataService AddRoleFile<T>(List<FilePermission> actionPermissionList) where T : PermissionRole
        {
            return this.AddRoleFile(this.permissionRoleListService.GetRoleNameByType<T>(), actionPermissionList);
        }

        public IRoleFileDataService AddRoleFile(string roleName, List<FilePermission> actionPermissionList)
        {
            if (!this.RoleFileList.ContainsKey(roleName))
                this.RoleFileList.Add(roleName, new List<FilePermission>());
            this.RoleFileList[roleName].AddRange(actionPermissionList);
            return this;
        }

        public void Reload()
        {
            this.roleFileList = null;
        }

        public event EventHandler EventReload;

    }

}


