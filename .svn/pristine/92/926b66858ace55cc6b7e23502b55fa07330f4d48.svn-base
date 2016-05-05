using System;
using System.Linq;
using System.Collections.Generic;
using COM.Data;
using ERP.Data;
using ERP.Domain;
using COM.Service;
namespace ERP.Service
{
	public interface IERP_M003_InStoreService
	{
		ERP_M003_InStore GetById(Guid Id);
        List<ERP_M003_InStore> GetList();
		List<ERP_M003_InStore> GetList(PagingModel pagingModel, DateTime? beginDate, DateTime? endDate);
        void Create(ERP_M003_InStore ERP_M003_InStore);
        void Update(ERP_M003_InStore ERP_M003_InStore);
        void Delete(Guid Id);
	}
	public class ERP_M003_InStoreService :IERP_M003_InStoreService
	{
		private IERP_M003_InStoreRepository ERP_M003_InStoreRepository;
		private IUnitOfWork runtimeService;
		private ICacheServiceBase appCacheService = Unity.Instance.GetService<ICacheServiceBase>();
		public ERP_M003_InStoreService(IDatabaseFactory dbfactory)
		{
			this.runtimeService = new UnitOfWork(dbfactory);
			this.ERP_M003_InStoreRepository = new ERP_M003_InStoreRepository(dbfactory);
		}

		public List<ERP_M003_InStore> GetList()
        {
            var q = this.ERP_M003_InStoreRepository.GetMany(i => true);
            return q.ToList();
        }

        public ERP_M003_InStore GetById(Guid Id)
        {
            return this.ERP_M003_InStoreRepository.GetByID(Id);
        }

        public void Create(ERP_M003_InStore ERP_M003_InStore)
        {
        	ERP_M003_InStore.CreateDt = DateTime.Now;
            tb_Sys_User tempUser = appCacheService.GetItem("user") as tb_Sys_User;
            ERP_M003_InStore.CreateUser = tempUser.UserName;
            ERP_M003_InStore.Validate();
			this.ERP_M003_InStoreRepository.Add(ERP_M003_InStore);
            this.runtimeService.Commit();
        }

        public void Delete(Guid Id)
        {
            var existstb_Sys_Menu = this.GetById(Id);
            this.ERP_M003_InStoreRepository.Delete(existstb_Sys_Menu);
            this.runtimeService.Commit();
        }

        public void Update(ERP_M003_InStore ERP_M003_InStore)
        {
        	ERP_M003_InStore.ModifyDt = DateTime.Now;
            tb_Sys_User tempUser = appCacheService.GetItem("user") as tb_Sys_User;
            ERP_M003_InStore.ModifyUser = tempUser.UserName;
            ERP_M003_InStore.Validate();
            var existstb_Sys_Menu = this.GetById(ERP_M003_InStore.Id);
            this.ERP_M003_InStoreRepository.SetValues(ERP_M003_InStore, existstb_Sys_Menu);
            this.runtimeService.Commit();
        }

        public List<ERP_M003_InStore> GetList(PagingModel pagingModel, DateTime? beginDate, DateTime? endDate)
        {
            var q = this.ERP_M003_InStoreRepository.GetMany(i => true);
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