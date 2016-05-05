using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using COM.Domain;
using System.Xml.Linq;
using COM.Data;
using COM.Service;
using ERP.Data;
using Util;
using System.Threading.Tasks;

namespace ERP.Service
{
    public interface IAppLoginService
    {
        void LoginAsERPUser(string userCode, string password, string CompCode, string CompName);
        void LoginAsAdmin(string userCode, string password);
    }
    public class AppLoginService:IAppLoginService
    {
        private Itb_Sys_UserService sysUserService;
        private Itb_Sys_RolesService sysRolesService;
        private Itb_Sys_MenuService sysMenuService;
        private Itb_Sys_ButtonService sysButtonService;
        private ICacheServiceBase appCacheService = Unity.Instance.GetService<ICacheServiceBase>();
        private ISupplierService supplierService;
        private ICustomerService customerService;
        private ICompanyService companyService;
        Task task1;
        public AppLoginService(IDatabaseFactory dbfactory)
        {
            this.sysUserService = new tb_Sys_UserService(dbfactory);
            this.sysRolesService = new tb_Sys_RolesService(dbfactory);
            this.sysMenuService = new tb_Sys_MenuService(dbfactory);
            this.sysButtonService = new tb_Sys_ButtonService(dbfactory);
            this.supplierService = new SupplierService(dbfactory);
            this.customerService = new CustomerService(dbfactory);
            this.companyService = new CompanyService(dbfactory);
        }
        public void LoginAsERPUser(string userCode, string password, string CompCode, string CompName)
        {
            //检查公司
            if (string.IsNullOrWhiteSpace(CompCode))
                throw new AppException("请选择公司");
            appCacheService.AddItem("Company", CompCode);
            appCacheService.AddItem("CompName", CompName);
            //1.0检查用户名密码
            sysUserService.CheckUserPassword(userCode, password);
            var user = sysUserService.GetUserByUserCode(userCode);
            //XElement userDataXml = XElementService.Instance.GetXElement("u", user);
            var roles = sysRolesService.GetRolesByUserId(user.Id).FirstOrDefault();
            //XElement rolesDataXml = XElementService.Instance.GetXElement("r", roles);
            var menus =  sysMenuService.GetMenusByUserId(user.Id);

            var company = companyService.GetList().Where(a => a.CompCode == user.CompCode).FirstOrDefault();
            XElement menusDataXml = XElementService.Instance.GetXElement("m", menus);

            var dd = (from m in menusDataXml.Descendants("m")
                      where m.Element("ParentMenuId").Value == ""
                      select new { name = m.Element("MenuName").Value, id = m.Element("Id").Value, ParentMenuId = m.Element("ParentMenuId").Value }).ToList();
            appCacheService.AddItem("user", user);
            appCacheService.AddItem("roles", roles);
            appCacheService.AddItem("menus", menus);
            appCacheService.AddItem("company", menus);
            // XElement roleDataXml = XElement
            //PermissionUser per = new PermissionUser();
            if (task1 != null && !task1.IsCompleted)
                return;
            task1 = new Task(() =>
            {
                try
                {
                    var supplierList = supplierService.GetSupplierData();
                    appCacheService.AddItem("Supplier", supplierList);
                    var customerList = customerService.GetCustomerInputData();
                    appCacheService.AddItem("Customer", customerList);
                }
                catch (Exception ef)
                {
                    
                }
                finally
                {
                    
                }
            });
            task1.Start();
        }

        public void LoginAsAdmin(string userCode, string password)
        {
            throw new NotImplementedException();
        }
    }
}
