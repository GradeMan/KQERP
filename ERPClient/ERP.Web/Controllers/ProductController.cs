using COM.Service;
using ERP.Domain;
using ERP.Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Util.Webs;

namespace ERP.Web.Controllers
{
    public class ProductController : QueryControllerBase
    {
        //
        // GET: /Product/
        private IProductService productService = Unity.Instance.GetService<IProductService>();
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
        public ActionResult Query(ERP_M001_Product model)
        {
            SetPage();

            var result = productService.GetList(PageModel);

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
