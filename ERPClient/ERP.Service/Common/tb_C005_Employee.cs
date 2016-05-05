using System;
using System.Linq;
using System.Collections.Generic;
using COM.Data;
using ERP.Data;
using ERP.Domain;
using COM.Service;
namespace ERP.Service
{
	public interface IEmployeeService
	{
        ERP_C005_Employee Gettb_C005_EmployeeById(Guid Id);
        List<ERP_C005_Employee> GetList();
        List<ERP_C005_Employee> GetList(PagingModel pagingModel, DateTime? beginDate, DateTime? endDate);
        void Create(ERP_C005_Employee tb_C005_Employee);
        void Update(ERP_C005_Employee tb_C005_Employee);
        void Delete(Guid Id);
	}
    public class tb_C005_EmployeeService : IEmployeeService
	{
        private IDatabaseFactory dbfactory;
		private Itb_C005_EmployeeRepository tb_C005_EmployeeRepository;
		private IUnitOfWork runtimeService;
        private ICacheServiceBase appCacheService = Unity.Instance.GetService<ICacheServiceBase>(); 
		public tb_C005_EmployeeService(IDatabaseFactory dbfactory)
		{
            this.dbfactory = dbfactory;
			this.runtimeService = new UnitOfWork(dbfactory);
			this.tb_C005_EmployeeRepository = new tb_C005_EmployeeRepository(dbfactory);
		}

        public List<ERP_C005_Employee> GetList()
        {
            var q = this.tb_C005_EmployeeRepository.GetMany(i => true);
            return q.ToList();
        }

        public ERP_C005_Employee Gettb_C005_EmployeeById(Guid Id)
        {
            return this.tb_C005_EmployeeRepository.GetByID(Id);
        }

        public void Create(ERP_C005_Employee tb_C005_Employee)
        {
            tb_C005_Employee.CreateDt = DateTime.Now;
            tb_Sys_User tempUser = appCacheService.GetItem("user") as tb_Sys_User;
            tb_C005_Employee.CreateUser = tempUser.UserName;
            tb_C005_Employee.CompCode = tempUser.CompCode;
            tb_C005_Employee.Validate();
			this.tb_C005_EmployeeRepository.Add(tb_C005_Employee);
            this.runtimeService.Commit();
        }

        public void Delete(Guid Id)
        {
            var existstb_Sys_Menu = this.Gettb_C005_EmployeeById(Id);
            this.tb_C005_EmployeeRepository.Delete(existstb_Sys_Menu);
            this.runtimeService.Commit();
        }

        public void Update(ERP_C005_Employee tb_C005_Employee)
        {
            tb_C005_Employee.ModifyDt = DateTime.Now;
            tb_Sys_User tempUser = appCacheService.GetItem("user") as tb_Sys_User;
            tb_C005_Employee.ModifyUser = tempUser.UserName;
            tb_C005_Employee.Validate();
            var existstb_Sys_Menu = this.Gettb_C005_EmployeeById(tb_C005_Employee.Id);
            this.tb_C005_EmployeeRepository.SetValues(tb_C005_Employee, existstb_Sys_Menu);
            this.runtimeService.Commit();
        }

        public List<ERP_C005_Employee> GetList(PagingModel pagingModel, DateTime? beginDate, DateTime? endDate)
        {
            var q = this.tb_C005_EmployeeRepository.GetMany(i => true);
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
	}
}