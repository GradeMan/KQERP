using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace System.Linq
{
    public static class LinqPagingExtensions
    {
        public static IQueryable<T> Paging<T>(this IQueryable<T> q, COM.Data.PagingModel pagingModel)
        {
            pagingModel.ItemCount = q.Count();
            pagingModel.PageIndex = pagingModel.PageIndex < 1 ? 1 : pagingModel.PageIndex;
            var skipCount = pagingModel.PageSize * (pagingModel.PageIndex - 1);
            return q.Skip(skipCount).Take(pagingModel.PageSize);
        }
    }
}