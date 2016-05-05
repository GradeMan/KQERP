using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Util.Domains.Repositories;
using Util.Webs;
using COM.Data;

namespace ERP.Web
{
    /// <summary>
    /// 查询控制器
    /// </summary>
    /// <typeparam name="TQuery">查询实体类型</typeparam>
    public abstract class QueryControllerBase : PermissionControllerBase
    {
        public Pager MyPage { get; set; }
        public PagingModel PageModel { get; set; }
        protected QueryControllerBase()
        {
            PageModel = new PagingModel();
            //MyPage = new Pager();
            //SchoolAppEntities schoolentity = new SchoolAppEntities();
            //if (User!=null)
            //    UserInfoMsg = schoolentity.UserInfoes.Where(a => a.UserCode == User.Identity.Name).FirstOrDefault();
            //else
            //{
            //    UserInfoMsg = new UserInfo(){CompCode = "K30",UserCode = "customer",};
            //}
        }

        ///// <summary>
        ///// 查询
        ///// </summary>
        ///// <param name="query">查询对象</param>
        //[HttpPost]
        //[AjaxOnly]
        //public virtual ActionResult Query(TQuery query)
        //{
        //    SetPage(query);
        //    //var result = Service.Query(query);
        //    return ToDataGridResult(ConvertQueryResult(result).ToList(), result.TotalCount);
        //}

        /// <summary>
        /// 设置分页
        /// </summary>
        /// <param name="query">查询实体</param>
        protected void SetPage()
        {
           // MyPage.Page = 
            //MyPage.PageSize = GetPageSize();
           // MyPage.Order = GetOrder();
            PageModel.PageIndex = GetPageIndex();
            PageModel.PageSize = GetPageSize();
        }
    }
}