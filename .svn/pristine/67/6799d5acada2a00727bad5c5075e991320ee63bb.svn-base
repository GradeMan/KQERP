using System;
using System.Linq;
using System.Collections.Generic;
using COM.Data;
using ERP.Data;
using ERP.Domain;
using COM.Service;
namespace ERP.Service
{
	public interface IERP_C003_Supplier_FileService
	{
		ERP_C003_Supplier_File GetById(Guid Id);
        List<ERP_C003_Supplier_File> GetList();
		List<ERP_C003_Supplier_File> GetList(PagingModel pagingModel, DateTime? beginDate, DateTime? endDate);
        void Create(ERP_C003_Supplier_File ERP_C003_Supplier_File);
        void Update(ERP_C003_Supplier_File ERP_C003_Supplier_File);
        void Delete(Guid Id);
        IQueryable<ERP_C003_Supplier_File> GetQuery();
	}
	public class ERP_C003_Supplier_FileService :IERP_C003_Supplier_FileService
	{
		private IERP_C003_Supplier_FileRepository ERP_C003_Supplier_FileRepository;
		private IUnitOfWork runtimeService;
		private ICacheServiceBase appCacheService = Unity.Instance.GetService<ICacheServiceBase>();
		public ERP_C003_Supplier_FileService(IDatabaseFactory dbfactory)
		{
			this.runtimeService = new UnitOfWork(dbfactory);
			this.ERP_C003_Supplier_FileRepository = new ERP_C003_Supplier_FileRepository(dbfactory);
		}
        public IQueryable<ERP_C003_Supplier_File> GetQuery()
        {
            return this.ERP_C003_Supplier_FileRepository.GetMany(i => true);
        }
		public List<ERP_C003_Supplier_File> GetList()
        {
            var q = this.ERP_C003_Supplier_FileRepository.GetMany(i => true);
            return q.ToList();
        }

        public ERP_C003_Supplier_File GetById(Guid Id)
        {
            return this.ERP_C003_Supplier_FileRepository.GetByID(Id);
        }

        public void Create(ERP_C003_Supplier_File ERP_C003_Supplier_File)
        {
        	ERP_C003_Supplier_File.CreateDt = DateTime.Now;
            tb_Sys_User tempUser = appCacheService.GetItem("user") as tb_Sys_User;
            ERP_C003_Supplier_File.CreateUser = tempUser.UserName;
            ERP_C003_Supplier_File.Validate();
			this.ERP_C003_Supplier_FileRepository.Add(ERP_C003_Supplier_File);
            this.runtimeService.Commit();
        }

        public void Delete(Guid Id)
        {
            var existstb_Sys_Menu = this.GetById(Id);
            this.ERP_C003_Supplier_FileRepository.Delete(existstb_Sys_Menu);
            this.runtimeService.Commit();
        }

        public void Update(ERP_C003_Supplier_File ERP_C003_Supplier_File)
        {
        	ERP_C003_Supplier_File.ModifyDt = DateTime.Now;
            tb_Sys_User tempUser = appCacheService.GetItem("user") as tb_Sys_User;
            ERP_C003_Supplier_File.ModifyUser = tempUser.UserName;
            ERP_C003_Supplier_File.Validate();
            var existstb_Sys_Menu = this.GetById(ERP_C003_Supplier_File.Id);
            this.ERP_C003_Supplier_FileRepository.SetValues(ERP_C003_Supplier_File, existstb_Sys_Menu);
            this.runtimeService.Commit();
        }

        public List<ERP_C003_Supplier_File> GetList(PagingModel pagingModel, DateTime? beginDate, DateTime? endDate)
        {
            var q = this.ERP_C003_Supplier_FileRepository.GetMany(i => true);
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