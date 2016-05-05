using System;
using System.Linq.Expressions;

namespace Util {
    /// <summary>
    /// 表达式扩展
    /// </summary>
    public static partial class Extensions {

        #region Value(获取lambda表达式的值)

        /// <summary>
        /// 获取lambda表达式的值
        /// </summary>
        /// <typeparam name="T">对象类型</typeparam>
        public static object Value<T>( this Expression<Func<T, bool>> expression ) {
            return Lambda.GetValue( expression );
        }

        #endregion
    }
}
