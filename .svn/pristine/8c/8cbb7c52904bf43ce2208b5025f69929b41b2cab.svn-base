using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Microsoft.Practices.Unity;

namespace COM.Winform
{
    public class HttpContextLifetimeManager<T> : LifetimeManager, IDisposable
    {
        public override object GetValue()
        {
            //FileLogService.Instance.LogUnity(string.Format("HttpContext.GetValue<{0}>()", typeof(T).FullName));
            return HttpContext.Current.Items[typeof(T).AssemblyQualifiedName];
        }

        public override void RemoveValue()
        {
            HttpContext.Current.Items.Remove(typeof(T).AssemblyQualifiedName);
        }

        public override void SetValue(object newValue)
        {
            HttpContext.Current.Items[typeof(T).AssemblyQualifiedName] = newValue;
        }

        public void Dispose()
        {
            RemoveValue();
        }
    }


}