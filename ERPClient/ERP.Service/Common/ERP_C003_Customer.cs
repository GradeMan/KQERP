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
	public interface ICustomerService
	{
		ERP_C003_Customer GetById(Guid Id);
        IQueryable<ERP_C003_Customer> GetList();
        IQueryable<ERP_C003_Customer> GetCustomer();
		List<ERP_C003_Customer> GetList(PagingModel pagingModel, DateTime? beginDate, DateTime? endDate);
        void Create(ERP_C003_Customer ERP_C003_Customer);
        void Update(ERP_C003_Customer ERP_C003_Customer);
        void Delete(Guid Id);
        List<InputItem> GetCustomerInputData();
  
	}
    public class CustomerService : ICustomerService
	{
		private IERP_C003_CustomerRepository ERP_C003_CustomerRepository;
		private IUnitOfWork runtimeService;
        private IDatabaseFactory dbfactory;
		private ICacheServiceBase appCacheService = Unity.Instance.GetService<ICacheServiceBase>();
        public CustomerService(IDatabaseFactory dbfactory)
		{
            this.dbfactory = dbfactory;
            this.runtimeService = new UnitOfWork(dbfactory);
            this.ERP_C003_CustomerRepository = new ERP_C003_CustomerRepository(dbfactory);
		}

        public IQueryable<ERP_C003_Customer> GetList()
        {
            var q = this.ERP_C003_CustomerRepository.GetMany(i => true);
            return q;
        }
        public IQueryable<ERP_C003_Customer> GetCustomer()
        {
            var q = this.ERP_C003_CustomerRepository.GetMany(i => true);
            return q;
        }

        public ERP_C003_Customer GetById(Guid Id)
        {
            return this.ERP_C003_CustomerRepository.GetByID(Id);
        }

        public void Create(ERP_C003_Customer ERP_C003_Customer)
        {
            ERP_C003_Customer.CreateDt = DateTime.Now;
            tb_Sys_User tempUser = appCacheService.GetItem("user") as tb_Sys_User;
            ERP_C003_Customer.CreateUser = tempUser.UserName;
            ERP_C003_Customer.CompCode = tempUser.CompCode;
            ERP_C003_Customer.Validate();
			this.ERP_C003_CustomerRepository.Add(ERP_C003_Customer);
            this.runtimeService.Commit();
        }

        public void Delete(Guid Id)
        {
            var existstb_Sys_Menu = this.GetById(Id);
            this.ERP_C003_CustomerRepository.Delete(existstb_Sys_Menu);
            this.runtimeService.Commit();
        }

        public void Update(ERP_C003_Customer ERP_C003_Customer)
        {
        	ERP_C003_Customer.ModifyDt = DateTime.Now;
            tb_Sys_User tempUser = appCacheService.GetItem("user") as tb_Sys_User;
            ERP_C003_Customer.ModifyUser = tempUser.UserName;
            ERP_C003_Customer.Validate();
            var existstb_Sys_Menu = this.GetById(ERP_C003_Customer.Id);
            this.ERP_C003_CustomerRepository.SetValues(ERP_C003_Customer, existstb_Sys_Menu);
            this.runtimeService.Commit();
        }

        public List<ERP_C003_Customer> GetList(PagingModel pagingModel, DateTime? beginDate, DateTime? endDate)
        {
            var q = this.ERP_C003_CustomerRepository.GetMany(i => true);
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


        public List<InputItem> GetCustomerInputData()
        {
            var q = this.ERP_C003_CustomerRepository.GetMany(i => true).ToList();
            var q2 = q.Select(i => new InputItem { DisPlayName = i.Alias, Value = i.CustCode, InputCode1 = i.CustCode, InputCode2 = i.CustName,InputCode3 = Util.PinYin.GetCodstring(i.CustName) });
            return q2.OrderBy(a=>a.Value).ToList();
        }
    }
}