using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Util.Webs.EasyUi;

namespace ERP.Web
{
    public abstract class PermissionControllerBase : EasyUiControllerBase
    {
        //public UserInfo UserInfoMsg { get; set; }
        /// <summary>
        /// 重写基类在Action之前执行的方法
        /// </summary>
        /// <param name="filterContext"></param>
        protected override void OnActionExecuting(ActionExecutingContext filterContext)
        {
            if (filterContext == null)
            {
                throw new ArgumentNullException("filterContext");
            }
            var path = filterContext.HttpContext.Request.Path.ToLower();
            if (path == "/" || path == "/system/account/login".ToLower())
                return;//忽略对Login登录页的权限判定
            object[] attrs = filterContext.ActionDescriptor.GetCustomAttributes(typeof(ViewPageAttribute), true);
            var isViewPage = attrs.Length == 1;//当前Action请求是否为具体的功能页
            //if (this.AuthorizeCore(filterContext, isViewPage) == false)//根据验证判断进行处理
            //{
            //    Response.Redirect("/system/account/login");
            //}
        }

        //权限判断业务逻辑
        protected virtual bool AuthorizeCore(ActionExecutingContext filterContext,bool isViewPage)
        {
            if (filterContext.HttpContext == null)
            {
                throw new ArgumentNullException("httpContext");
            }

            if (!filterContext.HttpContext.User.Identity.IsAuthenticated)
            {
                return false;//判定用户是否登录
            }
           // SchoolAppEntities entity = new SchoolAppEntities();

           // if (User.Identity.Name.ToLower() == "yukiadmin")
           // {
           //     UserInfoMsg = new UserInfo { CompCode = "K20", UserName = "yukiadmin" };
           //     return true;
           // }
           // UserInfoMsg = entity.UserInfoes.Where(a => a.UserCode == User.Identity.Name).FirstOrDefault();

           //// var areas = filterContext.RouteData.Values["AreaName"].ToString();
           // var controllerName = filterContext.RouteData.Values["controller"].ToString().ToLower();
           // var actionName = filterContext.RouteData.Values["action"].ToString().ToLower();
           // var menus = (from a in entity.MenuInfoes
           //     join b in entity.UserMenuInfoes on a.Id equals b.MenuId
           //              where b.UserId == UserInfoMsg.Id
           //     select a).ToList();

            //if (isViewPage && controllerName != "syshome") //如果当前Action请求为具体的功能页并且不是MasterPage页
            //{
            //    if (menus.Count(m => m.ControllerName == controllerName && m.ActionName == actionName) == 0)
            //        return false;
            //}

            return true;
        }
    }
}