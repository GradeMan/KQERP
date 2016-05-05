using System;
using System.Linq;
using System.Collections.Generic;
using COM.Data;
using ERP.Data;
using ERP.Domain;
using COM.Service;
using COM.Domain;
namespace ERP.Service
{
    public interface IEmployeeService
    {
        ERP_C005_Employee GetById(Guid Id);
        List<ERP_C005_Employee> GetList();
        List<ERP_C005_Employee> GetList(PagingModel pagingModel, DateTime? beginDate, DateTime? endDate);
        IQueryable<ERP_C005_Employee> GetEmployee();
        void Create(ERP_C005_Employee ERP_C005_Employee);
        void Update(ERP_C005_Employee ERP_C005_Employee);
        void Delete(Guid Id);
        List<InputItem> GetEmployeeData();
    }
    public class EmployeeService : IEmployeeService
    {
        private IDatabaseFactory dbfactory;
        private IERP_C005_EmployeeRepository ERP_C005_EmployeeRepository;
        private IUnitOfWork runtimeService;
        private ICacheServiceBase appCacheService = Unity.Instance.GetService<ICacheServiceBase>();
        public EmployeeService(IDatabaseFactory dbfactory)
        {
            this.dbfactory = dbfactory;
            this.runtimeService = new UnitOfWork(dbfactory);
            this.ERP_C005_EmployeeRepository = new ERP_C005_EmployeeRepository(dbfactory);
        }

        public List<ERP_C005_Employee> GetList()
        {
            var q = this.ERP_C005_EmployeeRepository.GetMany(i => true);
            return q.ToList();
        }
        public IQueryable<ERP_C005_Employee> GetEmployee()
        {
            var q = this.ERP_C005_EmployeeRepository.GetMany(i => true);
            return q;
        }

        public ERP_C005_Employee GetById(Guid Id)
        {
            return this.ERP_C005_EmployeeRepository.GetByID(Id);
        }

        public void Create(ERP_C005_Employee ERP_C005_Employee)
        {
            ERP_C005_Employee.CreateDt = DateTime.Now;
            tb_Sys_User tempUser = appCacheService.GetItem("user") as tb_Sys_User;
            ERP_C005_Employee.CreateUser = tempUser.UserName;
            ERP_C005_Employee.CompCode = tempUser.CompCode;
            ERP_C005_Employee.Validate();
            this.ERP_C005_EmployeeRepository.Add(ERP_C005_Employee);
            this.runtimeService.Commit();
        }

        public void Delete(Guid Id)
        {
            var existstb_Sys_Menu = this.GetById(Id);
            this.ERP_C005_EmployeeRepository.Delete(existstb_Sys_Menu);
            this.runtimeService.Commit();
        }

        public void Update(ERP_C005_Employee ERP_C005_Employee)
        {
            ERP_C005_Employee.ModifyDt = DateTime.Now;
            tb_Sys_User tempUser = appCacheService.GetItem("user") as tb_Sys_User;
            ERP_C005_Employee.ModifyUser = tempUser.UserName;
            ERP_C005_Employee.Validate();
            var existstb_Sys_Menu = this.GetById(ERP_C005_Employee.Id);
            this.ERP_C005_EmployeeRepository.SetValues(ERP_C005_Employee, existstb_Sys_Menu);
            this.runtimeService.Commit();
        }

        public List<ERP_C005_Employee> GetList(PagingModel pagingModel, DateTime? beginDate, DateTime? endDate)
        {
            var q = this.ERP_C005_EmployeeRepository.GetMany(i => true);
            if (beginDate.HasValue)
            {
                beginDate = beginDate.Value.Date;
                q = q.Where(p => p.CreateDt >= beginDate);
            }
            if (endDate.HasValue)
            {
                endDate = endDate.Value.Date.AddDays(1);
                q = q.Where(p => p.CreateDt < endDate);
            }

            q = q.OrderByDescending(i => i.CreateDt);
            q = q.Paging(pagingModel);
            return q.ToList();
        }


        public List<InputItem> GetEmployeeData()
        {
            var q = this.ERP_C005_EmployeeRepository.GetMany(i => true).ToList();
            var q2 = q.Select(i => new InputItem { DisPlayName = i.Name, Value = i.EmpNo, InputCode1 = i.EmpNo, InputCode2 = Util.PinYin.GetCodstring(i.Name) });
            return q2.ToList();
        }
    }
}