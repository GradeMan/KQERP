using COM.Service;
using ERP.Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Util.Webs;

namespace ERP.Web.Controllers
{
    public class AccountController : QueryControllerBase
    {
        //
        // GET: /Account/
        private Itb_Sys_UserService userService = Unity.Instance.GetService<Itb_Sys_UserService>();
        public ActionResult Index()
        {
            return View();
        }
        /// <summary>
        /// 查询
        /// </summary>
        /// <param name="query">查询对象</param>
        [HttpPost]
        [AjaxOnly]
        public ActionResult Query()
        {
            SetPage();

            var result = userService.Gettb_Sys_UserList(PageModel);
           
            //var result = from a in entity.UserInfoes
            //    join b in entity.CompanyInfoes on a.CompCode equals b.CompCode
            //    select
            //        new UserInfoDto()
            //        {
            //            CompCode = b.Name,
            //            UserCode = a.UserCode,
            //            UserName = a.UserName,
            //            Position = a.Position,
            //            Phone = a.Phone,
            //            Mail = a.Mail,
            //            BirthDay = a.BirthDay,
            //            Remarks = a.Remarks,
            //            CreateDt = a.CreateDt,
            //            CreateUser = a.CreateUser

            //        };
            //result = result.OrderBy(a => a.CreateDt).Skip((MyPage.Page - 1)*MyPage.PageSize).Take(MyPage.PageSize);
            return ToDataGridResult(result, PageModel.ItemCount);
        }
    }
}
