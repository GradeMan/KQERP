using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ERP.Web
{
    /// <summary>
    /// 表示当前Action请求为一个具体的功能页面
    /// </summary>
    [AttributeUsage(AttributeTargets.Method)]
    public class ViewPageAttribute : Attribute
    {
    }
}