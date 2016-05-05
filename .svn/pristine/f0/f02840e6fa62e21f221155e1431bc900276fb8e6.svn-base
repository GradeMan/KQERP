using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.Practices.Unity;
using Util;
using ERP.Service;
using COM.Service;
namespace ERP.Winform.Service
{
    public class AppStartService
    {
        private static AppStartService instance;
        public static AppStartService Instance
        {
            get
            {
                return instance ?? (instance = new AppStartService());
            }
        }

        public void Start()
        {
           Unity.Instance.RegisterERPService();
            //注册缓存单例服务
           Unity.Instance.RegisterSingleton<ICacheServiceBase, AppCacheService>();
           // var permissionRegister = Unity.Instance.GetService<IAppPermissionRegister>();
           // permissionRegister.RegisterRoleActionList();
           // permissionRegister.RegisterRoleFileList();
        }

        
    }
}