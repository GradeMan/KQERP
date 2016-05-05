using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using COM.Service;
using System.Linq.Expressions;
using COM.Domain;
using System.Collections;

namespace COM.Web
{
    /// <summary>
    /// 单一实例,用于缓存下拉列表常用数据
    /// </summary>
    public interface IDropDownListCache : ICacheServiceBase
    {
        Dictionary<string, TDict> GetKeyValueDict<TDict, TKey>(List<TDict> keyValueList, Expression<Func<TDict, TKey>> keyProperty) where TDict : class;
    }

    public class DropDownListCache : IDropDownListCache
    {

        private Dictionary<string, Dictionary<string, object>> keyValueCacheDict = null;
        public Dictionary<string, Dictionary<string, object>> KeyValueCacheDict
        {
            get
            {
                if (this.keyValueCacheDict == null)
                {
                    this.keyValueCacheDict = new Dictionary<string, Dictionary<string, object>>();
                    if (this.EventReload != null)
                        this.EventReload(this, EventArgs.Empty);
                }
                return this.keyValueCacheDict;
            }
        }

        public Dictionary<string, TDict> GetKeyValueDict<TDict, TKey>(List<TDict> keyValueList, Expression<Func<TDict, TKey>> keyProperty) where TDict : class
        {
            var dict = this.GetKeyValueDictSync(keyValueList, keyProperty);
            return dict.ToDictionary((i) => (i.Key), (v) => v.Value as TDict);
        }

        private static object syncObj = new object();
        private Dictionary<string, object> GetKeyValueDictSync<TDict, TKey>(List<TDict> keyValueList, Expression<Func<TDict, TKey>> keyProperty)
        {
            var keyPropertyName = PropertyLambda.For(keyProperty);
            var keyPropertyInfo = typeof(TDict).GetProperty(keyPropertyName);
            var cacheKey = string.Format("{0}.{1}", typeof(TDict).FullName, keyPropertyName);
            if (!this.KeyValueCacheDict.ContainsKey(cacheKey))
            {
                lock (syncObj)
                {
                    if (!this.KeyValueCacheDict.ContainsKey(cacheKey))
                    {
                        Dictionary<string, object> keyValueDict = new Dictionary<string, object>();
                        foreach (var item in keyValueList)
                        {
                            var keyItem = keyPropertyInfo.GetValue(item, null);
                            var keyString = keyItem == null ? string.Empty : keyItem.ToString().TrimOrEmpty();
                            if (!keyValueDict.ContainsKey(keyString))
                                keyValueDict.Add(keyString, item);
                        }
                        this.KeyValueCacheDict.Add(cacheKey, keyValueDict);
                    }
                }
            }
            return this.KeyValueCacheDict[cacheKey];
        }


        public void Reload()
        {
            this.keyValueCacheDict = null;
        }

        public event EventHandler EventReload;


    }


}
