using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace COM.Service
{
    public class AppCacheService : ICacheServiceBase
    {

        public AppCacheService()
        {
            AppCache = new Dictionary<string, object>();
        }
        private Dictionary<string, object> AppCache {  get;  set; }

        public void AddItem(string key, object value)
        {
            if (AppCache.ContainsKey(key))
            {
                AppCache.Remove(key);
            }
            AppCache.Add(key, value);
        }

        public object GetItem(string key)
        {
            if (AppCache.ContainsKey(key))
                return AppCache[key];
            else
                return null;
        }

        public void Clear()
        {
            AppCache.Clear();
           // AppCache = new Dictionary<string, object>();
        }
    }
}
