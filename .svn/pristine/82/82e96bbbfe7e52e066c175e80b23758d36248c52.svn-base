using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;
using System.Web.Script.Serialization;

namespace ERP.Winform
{
    public static class JsonCommon
    {
        public static string ToJson(object obj)
        {
            JavaScriptSerializer serializer = new JavaScriptSerializer();
            return HttpUtility.HtmlDecode(serializer.Serialize(obj));
        }
        public static string ToJson(object obj, int recursion)
        {
            JavaScriptSerializer serializer = new JavaScriptSerializer();
            serializer.RecursionLimit = recursion;
            return HttpUtility.HtmlDecode(serializer.Serialize(obj));
        }
        /// <summary>
        /// 返回指定JSON转成的字典
        /// </summary>
        /// <param name="json">JSON</param>
        /// <returns>Dictionary`[string, object]</returns>
        public static Dictionary<string, object> SelectDictionary(string json)
        {
            JavaScriptSerializer serializer = new JavaScriptSerializer();
            return serializer.Deserialize<Dictionary<string, object>>(json);
        }
    }
}
