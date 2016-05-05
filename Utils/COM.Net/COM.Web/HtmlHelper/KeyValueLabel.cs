using System;
using System.Linq;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Web;
using System.Web.Mvc;
using COM.Domain;
using COM.Web;

namespace System.Web.Helpers
{
    public static class KeyValueLabelExtensions
    {
        private static object syncObj = new object();

        public static TDict KeyValueLabel<TDict, TKey>(this HtmlHelper helper, TKey modelValue, List<TDict> keyValueList, Expression<Func<TDict, TKey>> keyProperty) where TDict:class,new()
        {
            var modelValueString = modelValue == null?string.Empty:modelValue.ToString().TrimOrEmpty();
            var dropDownListCache = Unity.Instance.GetService<IDropDownListCache>();
            var dict = dropDownListCache.GetKeyValueDict(keyValueList, keyProperty);
            if (dict.ContainsKey(modelValueString))
                return dict[modelValueString];
            else
                return new TDict();

            throw new AppException("不该执行至此!");
        }

    }
}