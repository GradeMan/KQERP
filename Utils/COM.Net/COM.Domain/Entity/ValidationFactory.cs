using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Util;
namespace COM.Domain
{
    /// <summary>
    /// 验证工厂
    /// </summary>
    public class ValidationFactory
    {
        public static IValidation Create()
        {
            return new Validation();
        }
    }
}
