using System;
using System.Linq;
using System.Linq.Expressions;

namespace COM.Data
{
    /// <summary>
    /// 查询扩展
    /// </summary>
    public static class Extensions {
        /// <summary>
        /// 过滤
        /// </summary>
        /// <typeparam name="T">实体类型</typeparam>
        /// <param name="queryable">查询对象</param>
        /// <param name="predicate">谓词</param>
        public static IQueryable<T> Filter<T>( this IQueryable<T> queryable, Expression<Func<T, bool>> predicate ) {
            predicate = QueryHelper.ValidatePredicate( predicate );
            if ( predicate == null )
                return queryable;
            return queryable.Where( predicate );
        }
    }
}