using System;
using System.Linq;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Web;
using System.Web.Mvc;
using COM.Domain;
using COM.Web;
using System.Web.Mvc.Html;

namespace System.Web.Helpers
{
    public static class DropDownListByEnumPropertyExtensions
    {
        public static MvcHtmlString DropDownListByEnumProperty<TModel, TProperty>(this HtmlHelper<TModel> helper, Expression<Func<TModel, TProperty>> expression, Type enumClassType, object htmlAttributes)
        {
            var itemList = enumClassType.GetFields().Select(p => p.GetValue(null).ToString());
            var selectItemList = itemList.Select(i => new SelectListItem() { Selected = false, Value = i, Text = i }).ToList();
            selectItemList.Insert(0, new SelectListItem() { Selected = false, Value = string.Empty, Text = "-" });
            return SelectExtensions.DropDownListFor(helper, expression, selectItemList, htmlAttributes);
        }

    }

}
