using System;
using System.Linq.Expressions;
using Util;

namespace COM.Data
{
    /// <summary>
    /// 查询操作
    /// </summary>
    internal class QueryHelper {
        /// <summary>
        /// 验证谓词，无效返回null
        /// </summary>
        /// <typeparam name="T">实体类型</typeparam>
        /// <param name="predicate">谓词</param>
        public static Expression<Func<T, bool>> ValidatePredicate<T>( Expression<Func<T, bool>> predicate ) {
            predicate.CheckNull( "predicate" );
            if ( Lambda.GetCriteriaCount( predicate ) > 1 )
                throw new InvalidOperationException( String.Format( "仅允许添加一个条件,条件：{0}", predicate ) );
            if ( predicate.Value() == null )
                return null;
            if ( string.IsNullOrWhiteSpace( predicate.Value().ToString() ) )
                return null;
            return predicate;
            
        }
    }
}
