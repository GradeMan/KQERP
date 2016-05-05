using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace COM.Service
{
    /// <summary>
    /// 缓存服务,都以单例方式置入容器
    /// </summary>
    public interface ICacheServiceBase
    {
        //Dictionary<string, object> AppCache { get; set; }
        void AddItem(string key, object value);
        object GetItem(string key);
        void Clear();
        //void Reload();
        //event EventHandler EventReload;
    }
}
