using System;
using System.Linq;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Web;
using System.Web.Mvc;
using COM.Domain;
using COM.Web;
using COM.Data;

namespace System.Web.Helpers
{
    public static class TrimPropertyExtensions
    {
        public static void TrimProperty<TModel>(this HtmlHelper<TModel> helper, TModel model)
        {
            var type = typeof(TModel);
            var propList = EntityReflectService.Instance.GetTypePropertyInfo(type);

            var attribute = type.GetCustomAttributes(typeof(System.Data.Services.Common.DataServiceKeyAttribute), false).FirstOrDefault();
            string keyPropName = "ID";
            if (attribute != null)
            {
                var keyAttribute = attribute as System.Data.Services.Common.DataServiceKeyAttribute;
                keyPropName = keyAttribute.KeyNames[0];
            }

            foreach (var p in propList)
            {
                if (p.PropertyType == typeof(string))
                {
                    var propValue = p.GetValue(model, null) as string;
                    if (p.Name != keyPropName)
                        p.SetValue(model, propValue.TrimOrEmpty(), null);
                }
            }
        }

    }
}