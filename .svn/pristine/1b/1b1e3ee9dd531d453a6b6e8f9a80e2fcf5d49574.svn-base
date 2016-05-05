using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace System
{
    static public class StringExtension
    {
        [System.Diagnostics.DebuggerStepThrough]
        static public string TrimOrEmpty(this string stringValue)
        {
            return stringValue == null ? string.Empty : stringValue.TrimEnd();
        }
    }
}

namespace System.Web
{
    static public class StringExtension
    {
        /// <summary>
        ///格式化字符串长度，超出部分显示省略号,区分汉字跟字母。汉字2个字节，字母数字一个字节
        /// </summary>
        /// <param name="stringValue"></param>
        /// <param name="length"></param>
        /// <returns></returns>
        [System.Diagnostics.DebuggerStepThrough]
        static public string TrimOrDot(this string stringValue,int length)
        {
            if (stringValue.TrimOrEmpty().Length > length)
                return stringValue.TrimOrEmpty().Substring(0, length) + "...";
            else
                return stringValue.TrimOrEmpty();
        }

    }

}
