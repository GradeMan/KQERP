using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Xml.Linq;
using System.Web.Mvc;
using System.Reflection;

namespace COM.Web
{
    public interface IHttpRequestService
    {
        /// <summary>
        /// localhost:20110
        /// </summary>
        string WebSiteName { get; }
        string ClientIP { get; }
        /// <summary>
        /// 从View回传的对象,试图更新回数据库之前
        /// 需要和数据库中的对象合并值后再更新
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="fromViewModel">页面中回传的对象,包括部分新值</param>
        /// <param name="toExistsEntity">数据库中存在的对象</param>
        /// <returns></returns>
        T Merge<T>(T fromViewModel, T toExistsEntity);
        T MergeViewModel<T>(object model, T toExistsEntity);
        bool IsPhone { get; }
    }

    public class HttpRequestService : IHttpRequestService
    {
        public string WebSiteName
        {
            get
            {
                var urlHelper = new UrlHelper(HttpContext.Current.Request.RequestContext);
                var webSite = string.Format("{0}/{1}", HttpContext.Current.Request.Url.Authority.Trim('/'), urlHelper.Content("~/").Trim('/'));
                return webSite.Trim('/');
            }
        }

        private IEnumerable<PropertyInfo> GetViewPropertyList(Type modelType)
        {
            //获取页面回传的属性参数
            string[] viewParams;
            if (string.Compare(HttpContext.Current.Request.HttpMethod, "post", true) == 0)
                viewParams = HttpContext.Current.Request.Form.AllKeys;
            else
                viewParams = HttpContext.Current.Request.Params.AllKeys;

            PropertyInfo[] propertyInfo = COM.Data.EntityReflectService.Instance.GetTypePropertyInfo(modelType);
            foreach (var property in propertyInfo)
            {
                if (property.PropertyType.IsSealed && property.PropertyType.IsSerializable)
                {
                    if (viewParams.Contains(property.Name, StringComparer.OrdinalIgnoreCase))
                        yield return property;
                }
            }
        }

        public T Merge<T>(T fromViewModel, T toExistsEntity)
        {
            var viewPropertyList = this.GetViewPropertyList(fromViewModel.GetType());
            foreach (var property in viewPropertyList)
            {
                var viewValue = property.GetValue(fromViewModel, null);
                if (property.GetSetMethod() != null)
                    property.SetValue(toExistsEntity, viewValue, null);
            }
            return toExistsEntity;
        }


        public T MergeViewModel<T>(object model, T toExistsEntity)
        {
            COM.Data.EntityReflectService.Instance.CopyEntityProperty(model, toExistsEntity);
            return toExistsEntity;
        }



        public string ClientIP
        {
            get
            {
                if (HttpContext.Current == null || HttpContext.Current.Request == null)
                    return string.Empty;

                return this.GetClientIP();
            }
        }

        private string GetClientIP()
        {
            string ip = string.Empty;
            if (string.IsNullOrEmpty(HttpContext.Current.Request.ServerVariables["HTTP_VIA"]))
            {
                //如果没有使用代理服务器或者得不到客户端的 ip  not using proxy or can't get the Client IP 
                //While it can't get the Client IP, it will return proxy IP.
                ip = HttpContext.Current.Request.ServerVariables["REMOTE_ADDR"].ToString();
            }
            else
            {
                //服务器 using proxy ,  Return real client IP. 
                ip = HttpContext.Current.Request.ServerVariables["HTTP_X_FORWARDED_FOR"].ToString();
            }
            return ip;
        }

        static string[] keywords = { "Android", "iPhone", "iPod", "iPad", "Windows Phone", "MQQBrowser" };
        /// <summary>
        /// 根据 Agent 判断是否是智能手机
        /// </summary>
        /// <returns></returns>
        public bool IsPhone
        {
            get
            {
                string agent = HttpContext.Current.Request.UserAgent;
                //排除Window 桌面系统 和 苹果桌面系统
                if (agent.Contains("Windows NT") || agent.Contains("Macintosh"))
                    return false;

                if (keywords.Any(i => agent.Contains(i)))
                    return true;

                return false;
            }
        }
    }

}
