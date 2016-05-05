using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Util.Webs.EasyUi.Results;
using Util.Webs.EasyUi.Trees;

namespace ERP.Web.Controllers
{
    public class HomeController : Controller
    {
        //
        // GET: /Home/

        public ActionResult Index()
        {
            return View();
        }
        public ActionResult GetSysTree()
        {
 
                var node = new TreeNode { Id = "1", Text = "系统模块" };
                var node2 = new TreeNode { Id = "3", Text = "功能模块" };
                var node10 = new TreeNode { Id = "20", ParentId = "1", Text = "账户管理", Attributes = new { url = "/account/index" }};
                var node11 = new TreeNode { Id = "21", ParentId = "1", Text = "产品管理", Attributes = new { url = "/product/index" } };
                //var node3 = new TreeNode { Id = "4", ParentId = "3", Text = "年级管理", Attributes = new { url = "/commons/grade" } };
                //var node4 = new TreeNode { Id = "5", ParentId = "3", Text = "班级管理", Attributes = new { url = "/commons/class" } };
                //var node123 = new TreeNode { Id = "123", ParentId = "3", Text = "课程管理", Attributes = new { url = "/commons/course" } };
                //var node7 = new TreeNode { Id = "8", ParentId = "3", Text = "教师管理", Attributes = new { url = "/commons/teacher" } };
                //var node8 = new TreeNode { Id = "9", ParentId = "3", Text = "通知管理", Attributes = new { url = "/commons/notice" } };
                //var node9 = new TreeNode { Id = "1222", ParentId = "3", Text = "学生管理", Attributes = new { url = "/commons/student" } };
                // node123, node3, node4, node7, node8,node9
                return Content(new TreeResult(new[] { node, node2, node10, node11 }).ToString());
            
        }
    }
}
