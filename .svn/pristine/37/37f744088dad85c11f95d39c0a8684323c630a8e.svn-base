using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Microsoft.Practices.Unity;
using COM.Service;

namespace COM.Web
{
    public class UnityDependencyResolver : IDependencyResolver
    {
        public IUnityContainer Container{get;private set;}
        public UnityDependencyResolver(IUnityContainer container)
        {
            this.Container = container;
        }

        public object GetService(Type serviceType)
        {
            FileLogService.Instance.LogUnity(string.Format("Unity.GetService<{0}>()", serviceType.FullName));
            if (this.Container.IsRegistered(serviceType))
                return this.Container.Resolve(serviceType);
            else
                throw new ApplicationException(string.Format("Container中未注册服务:{0}", serviceType.FullName));
        }

        public IEnumerable<object> GetServices(Type serviceType)
        {
            return this.Container.ResolveAll(serviceType);
        }
    }
}