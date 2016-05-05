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
	public interface ISupplierService
	{
		ERP_C004_Supplier GetById(Guid Id);
        List<ERP_C004_Supplier> GetList();
		List<ERP_C004_Supplier> GetList(PagingModel pagingModel, DateTime? beginDate, DateTime? endDate);
        IQueryable<ERP_C004_Supplier> GetSupplier();
        void Create(ERP_C004_Supplier ERP_C004_Supplier);
        void Update(ERP_C004_Supplier ERP_C004_Supplier);
        void Delete(Guid Id);
        List<InputItem> GetSupplierData();
	}
    public class SupplierService : ISupplierService
	{
        private IDatabaseFactory dbfactory;
		private IERP_C004_SupplierRepository ERP_C004_SupplierRepository;
		private IUnitOfWork runtimeService;
		private ICacheServiceBase appCacheService = Unity.Instance.GetService<ICacheServiceBase>();
        public SupplierService(IDatabaseFactory dbfactory)
		{
            this.dbfactory = dbfactory;
			this.runtimeService = new UnitOfWork(dbfactory);
            this.ERP_C004_SupplierRepository = new ERP_C004_SupplierRepository(dbfactory);
		}

		public List<ERP_C004_Supplier> GetList()
        {
            var q = this.ERP_C004_SupplierRepository.GetMany(i => true);
            return q.ToList();
        }
        public IQueryable<ERP_C004_Supplier> GetSupplier()
        {
            var q = this.ERP_C004_SupplierRepository.GetMany(i => true);
            return q;
        }

        public ERP_C004_Supplier GetById(Guid Id)
        {
            return this.ERP_C004_SupplierRepository.GetByID(Id);
        }

        public void Create(ERP_C004_Supplier ERP_C004_Supplier)
        {
            ERP_C004_Supplier.CreateDt = DateTime.Now;
            tb_Sys_User tempUser = appCacheService.GetItem("user") as tb_Sys_User;
            ERP_C004_Supplier.CreateUser = tempUser.UserName;
            ERP_C004_Supplier.CompCode = tempUser.CompCode;
            ERP_C004_Supplier.Validate();
			this.ERP_C004_SupplierRepository.Add(ERP_C004_Supplier);
            this.runtimeService.Commit();
        }

        public void Delete(Guid Id)
        {
            var existstb_Sys_Menu = this.GetById(Id);
            this.ERP_C004_SupplierRepository.Delete(existstb_Sys_Menu);
            this.runtimeService.Commit();
        }

        public void Update(ERP_C004_Supplier ERP_C004_Supplier)
        {
        	ERP_C004_Supplier.ModifyDt = DateTime.Now;
            tb_Sys_User tempUser = appCacheService.GetItem("user") as tb_Sys_User;
            ERP_C004_Supplier.ModifyUser = tempUser.UserName;
            ERP_C004_Supplier.Validate();
            var existstb_Sys_Menu = this.GetById(ERP_C004_Supplier.Id);
            this.ERP_C004_SupplierRepository.SetValues(ERP_C004_Supplier, existstb_Sys_Menu);
            this.runtimeService.Commit();
        }

        public List<ERP_C004_Supplier> GetList(PagingModel pagingModel, DateTime? beginDate, DateTime? endDate)
        {
            var q = this.ERP_C004_SupplierRepository.GetMany(i => true);
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


        public List<InputItem> GetSupplierData()
        {
            var q = this.ERP_C004_SupplierRepository.GetMany(i => true).ToList();
            var q2 = q.Select(i => new InputItem { DisPlayName = i.SuppName, Value = i.SuppCode, InputCode1 = i.SuppCode, InputCode2 = Util.PinYin.GetCodstring(i.SuppName) });
            return q2.ToList();
        }
    }
}