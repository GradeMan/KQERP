using System;
using System.Linq;
using System.Collections.Generic;
using COM.Data;
using ERP.Data;
using ERP.Domain;
using COM.Service;
namespace ERP.Service
{
	public interface IERP_C003_SupplierService
	{
		ERP_C003_Supplier GetById(Guid Id);
        List<ERP_C003_Supplier> GetList();
		List<ERP_C003_Supplier> GetList(PagingModel pagingModel, DateTime? beginDate, DateTime? endDate);
        void Create(ERP_C003_Supplier ERP_C003_Supplier);
        void Update(ERP_C003_Supplier ERP_C003_Supplier);
        void Delete(Guid Id);
        void Save(ERP_C003_Supplier supplier,List<ERP_C003_Supplier_File> suppFiles);
        IQueryable<ERP_C003_Supplier> GetSuppler();
        void MarkDeleteSuppFile(ERP_C003_Supplier_File temp);
	}
	public class ERP_C003_SupplierService :IERP_C003_SupplierService
	{
		private IERP_C003_SupplierRepository ERP_C003_SupplierRepository;
        private IERP_C003_Supplier_FileRepository suppFileRepository;
		private IUnitOfWork runtimeService;
		private ICacheServiceBase appCacheService = Unity.Instance.GetService<ICacheServiceBase>();
		public ERP_C003_SupplierService(IDatabaseFactory dbfactory)
		{
			this.runtimeService = new UnitOfWork(dbfactory);
			this.ERP_C003_SupplierRepository = new ERP_C003_SupplierRepository(dbfactory);
            this.suppFileRepository = new ERP_C003_Supplier_FileRepository(dbfactory);
		}
        public void MarkDeleteSuppFile(ERP_C003_Supplier_File temp)
        {
            var existstb_Sys_Menu = suppFileRepository.GetByID(temp.Id);
            if (existstb_Sys_Menu != null)
                this.suppFileRepository.Delete(existstb_Sys_Menu);
        }
        public IQueryable<ERP_C003_Supplier> GetSuppler()
        {
            return ERP_C003_SupplierRepository.GetMany(i => true);
        }
        public void Save(ERP_C003_Supplier supplier, List<ERP_C003_Supplier_File> suppFiles)
        {
            tb_Sys_User tempUser = appCacheService.GetItem("user") as tb_Sys_User;

            var existsdevice = this.GetById(supplier.Id);
            if (existsdevice == null)
            {
                supplier.CompCode = tempUser.CompCode;
                supplier.CreateDt = DateTime.Now;
                supplier.CreateUser = tempUser.UserName;
                supplier.Validate();
                this.ERP_C003_SupplierRepository.Add(supplier);
            }
            else
            {
                supplier.ModifyDt = DateTime.Now;
                supplier.ModifyUser = tempUser.UserName;
                supplier.Validate();
                this.ERP_C003_SupplierRepository.SetValues(supplier, existsdevice);
            }
            foreach (var file in suppFiles)
            {
                var existsmatSupp = this.suppFileRepository.GetByID(file.Id);
                if (existsmatSupp == null)
                {
                    file.CompCode = tempUser.CompCode;
                    file.CreateDt = DateTime.Now;
                    file.CreateUser = tempUser.UserName;
                    file.Validate();
                    this.suppFileRepository.Add(file);
                }
                else
                {
                    file.ModifyDt = DateTime.Now;
                    file.ModifyUser = tempUser.UserName;
                    file.Validate();
                    this.suppFileRepository.SetValues(file, existsmatSupp);
                }
            }
            this.runtimeService.Commit();
        }
		public List<ERP_C003_Supplier> GetList()
        {
            var q = this.ERP_C003_SupplierRepository.GetMany(i => true);
            return q.ToList();
        }

        public ERP_C003_Supplier GetById(Guid Id)
        {
            return this.ERP_C003_SupplierRepository.GetByID(Id);
        }

        public void Create(ERP_C003_Supplier ERP_C003_Supplier)
        {
        	ERP_C003_Supplier.CreateDt = DateTime.Now;
            tb_Sys_User tempUser = appCacheService.GetItem("user") as tb_Sys_User;
            ERP_C003_Supplier.CreateUser = tempUser.UserName;
            ERP_C003_Supplier.Validate();
			this.ERP_C003_SupplierRepository.Add(ERP_C003_Supplier);
            this.runtimeService.Commit();
        }

        public void Delete(Guid Id)
        {
            var existstb_Sys_Menu = this.GetById(Id);
            this.ERP_C003_SupplierRepository.Delete(existstb_Sys_Menu);
            this.runtimeService.Commit();
        }

        public void Update(ERP_C003_Supplier ERP_C003_Supplier)
        {
        	ERP_C003_Supplier.ModifyDt = DateTime.Now;
            tb_Sys_User tempUser = appCacheService.GetItem("user") as tb_Sys_User;
            ERP_C003_Supplier.ModifyUser = tempUser.UserName;
            ERP_C003_Supplier.Validate();
            var existstb_Sys_Menu = this.GetById(ERP_C003_Supplier.Id);
            this.ERP_C003_SupplierRepository.SetValues(ERP_C003_Supplier, existstb_Sys_Menu);
            this.runtimeService.Commit();
        }

        public List<ERP_C003_Supplier> GetList(PagingModel pagingModel, DateTime? beginDate, DateTime? endDate)
        {
            var q = this.ERP_C003_SupplierRepository.GetMany(i => true);
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