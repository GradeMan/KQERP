using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Util
{
    /// <summary>
    /// 默认验证处理器，直接抛出第一个异常
    /// </summary>
    public class ValidationHandler:IValidationHandler
    {
        /// <summary>
        /// 处理验证错误
        /// </summary>
        /// <param name="results"></param>
        public void Handle(ValidationResultCollection results)
        {
            if (results.IsValid)
                return;
            throw new AppException(results.First().ErrorMessage);
        }
    }
}
