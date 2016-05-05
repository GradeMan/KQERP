using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Security;
using Microsoft.Practices.Unity;
using COM.Service;
using COM.Data;

namespace COM.Web
{
    public class WebStartService
    {
        private static WebStartService instance;
        public static WebStartService Instance
        {
            get
            {
                return instance ?? (instance = new WebStartService());
            }
        }

        public void Start()
        {
            this.RegisterWebServices();
            this.RegisterRole();
            this.RegisterRolePermission();
            this.RegisterRoleFile();
        }

        /// <summary>
        /// 不要让单例服务依赖于会话服务
        /// </summary>
        private void RegisterWebServices()
        {
            var unity = COM.Web.Unity.Instance;
            unity
                .RegisterSingleton<COM.Data.IAppPathService, WebAppPathService>()
                .RegisterSingleton<IWebAppPathService, WebAppPathService>()
                .RegisterSingleton<IConfigService, ConfigService>()
                .RegisterSingleton<IWebConfigService, ConfigService>()
                .RegisterSingleton<IScheduleService, ScheduleService>()

                .RegisterSingleton<IPermissionRoleListService, PermissionRoleListService>()
                .RegisterSingleton<IRolePermissionDataService, RolePermissionDataService>()
                .RegisterSingleton<IRoleActionDataService, RoleActionDataService>()
                .RegisterSingleton<IRoleFileDataService, RoleFileDataService>()


                .Register<IDropDownListCache, DropDownListCache>()
                .Register<IHttpRequestService, HttpRequestService>()

                .Register<IUserPrincipalFactory, UserPrincipalFactory>()

                .Register<IPrincipalService, WebPrincipalService>()
                .Register<IWebPrincipalService, WebPrincipalService>()
                .Register<ISaltHashService, SaltHashService>()
                .Register<ILoginService, LoginService>()
                .Register<IMessageService, MessageService>()


                .Register<IPermissionItemService, PermissionService>()
                .Register<IPermissionService, WebPermissionService>()
                .Register<IWebPermissionServiceAction, WebPermissionServiceAction>()
                .Register<IWebPermissionServiceFile, WebPermissionServiceFile>()
                .Register<IWebPermissionService, WebPermissionService>()

                //.Register<ILoginUserAccountService, LoginUserAccountService>();
                //.Register<ILogService, DbLogService>();
                //.Register<COM.Service.IPermissionService, AppPermissionService>();
                ;
        }

        /// <summary>
        /// 注册系统支持的角色
        /// </summary>
        private void RegisterRole()
        {
            var permissionRoleListService = COM.Web.Unity.Instance.GetService<IPermissionRoleListService>();
            permissionRoleListService
                .RegisterRoleType<AnyPermissionRole>()
                .RegisterRoleType<AdminPermissionRole>()
                .RegisterRoleType<WebAnonymousPermissionRole>()
                .RegisterRoleType<WebUserPermissionRole>()
                .RegisterRoleType<WpfAnonymousPermissionRole>()
                .RegisterRoleType<WpfUserPermissionRole>()
                .RegisterRoleType<WebInterfacePermissionRole>()
                .RegisterRoleType<DevPermissionRole>()
                ;
        }

        private void RegisterRolePermission()
        {
            var rolePermissionDataService = COM.Web.Unity.Instance.GetService<IRolePermissionDataService>();
            rolePermissionDataService.EventReload += (sender, e) =>
            {
                rolePermissionDataService.AddRolePermission<WebAnonymousPermissionRole>(new List<string>()
                    {
                            EnumWebPermissionName.LoginAsWebAppInterfaceUser,
                            EnumWebPermissionName.LoginAsWpfAnonymous,
                    })

                .AddRolePermission<WebUserPermissionRole>(new List<string>()
                    {
                            EnumWebPermissionName.SignOut,
                    })


                .AddRolePermission<WpfAnonymousPermissionRole>(new List<string>()
                    {
                            EnumWebPermissionName.SignOut,
                            EnumWebPermissionName.LoginAsWpfUser,
                    })

                .AddRolePermission<WpfUserPermissionRole>(new List<string>()
                    {
                            EnumWebPermissionName.SignOut,
                    })
                .AddRolePermission<DevPermissionRole>(new List<string>()
                    {
                            EnumWebPermissionName.LoginAsWebAppInterfaceUser,
                            EnumWebPermissionName.SignOut,
                    })
                .AddRolePermission<WebInterfacePermissionRole>(new List<string>()
                    {
                            EnumWebPermissionName.SignOut,
                    });
            };
        }

        private void RegisterRoleFile()
        {
            var roleFileDataService = COM.Web.Unity.Instance.GetService<IRoleFileDataService>();
            roleFileDataService.EventReload += (sender, e) =>
            {
                roleFileDataService.AddRoleFile<AnyPermissionRole>(new List<FilePermission>()
                    {
                           new FilePermission()
                           {
                               HttpMethod="*",
                               FileName = EnumWebPermissionName.SystemWcfServiceFile
                           },
                           new FilePermission()
                           {
                               HttpMethod="*",
                               FileName = EnumWebPermissionName.UserWcfServiceFile
                           },

                    });

                roleFileDataService.AddRoleFile<DevPermissionRole>(new List<FilePermission>()
                    {
                           new FilePermission()
                           {
                               HttpMethod="*",
                               FileName = "*.svc",
                           },
                    });

            };
        }

    }
}