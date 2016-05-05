using System;
using System.Linq;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Web;
using System.Web.Mvc;
using COM.Domain;
using COM.Web;
using System.Web.Mvc.Html;
using COM.Data;

namespace System.Web.Helpers
{
    public static class ModelPropertyExtensions
    {
        public static string PropertyName<TModel, TProperty>(this HtmlHelper<TModel> helper, Expression<Func<TModel, TProperty>> expression)
        {
            return PropertyLambda.For(expression);
        }

       
    }

}
