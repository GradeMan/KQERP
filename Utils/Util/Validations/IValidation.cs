using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Util
{
    /// <summary>
    /// 验证操作
    /// </summary>
    public interface IValidation
    {
        /// <summary>
        /// y验证
        /// </summary>
        /// <param name="target">验证目标</param>
        /// <returns></returns>
        ValidationResultCollection Validate(object target);
    }
}
