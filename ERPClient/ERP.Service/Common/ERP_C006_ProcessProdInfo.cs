using System;
using System.Linq;
using System.Collections.Generic;
using COM.Data;
using ERP.Data;
using ERP.Domain;
using COM.Service;
namespace ERP.Service
{
	public interface IERP_C006_ProcessProdInfoService
	{
		ERP_C006_ProcessProdInfo GetById(Guid Id);
        List<ERP_C006_ProcessProdInfo> GetList();
        IQueryable<ERP_C006_ProcessProdInfo> GetQuery();
		List<ERP_C006_ProcessProdInfo> GetList(PagingModel pagingModel, DateTime? beginDate, DateTime? endDate);
        void Create(ERP_C006_ProcessProdInfo ERP_C006_ProcessProdInfo);
        void Update(ERP_C006_ProcessProdInfo ERP_C006_ProcessProdInfo);
        void Delete(Guid Id);
	}
	public class ERP_C006_ProcessProdInfoService :IERP_C006_ProcessProdInfoService
	{
		private IERP_C006_ProcessProdInfoRepository ERP_C006_ProcessProdInfoRepository;
		private IUnitOfWork runtimeService;
		private ICacheServiceBase appCacheService = Unity.Instance.GetService<ICacheServiceBase>();
		public ERP_C006_ProcessProdInfoService(IDatabaseFactory dbfactory)
		{
			this.runtimeService = new UnitOfWork(dbfactory);
			this.ERP_C006_ProcessProdInfoRepository = new ERP_C006_ProcessProdInfoRepository(dbfactory);
		}

		public List<ERP_C006_ProcessProdInfo> GetList()
        {
            var q = this.ERP_C006_ProcessProdInfoRepository.GetMany(i => true);
            return q.ToList();
        }
        
		public IQueryable<ERP_C006_ProcessProdInfo> GetQuery()
        {
            var q = this.ERP_C006_ProcessProdInfoRepository.GetMany(i => true);
            return q;
        }
        
        public ERP_C006_ProcessProdInfo GetById(Guid Id)
        {
            return this.ERP_C006_ProcessProdInfoRepository.GetByID(Id);
        }

        public void Create(ERP_C006_ProcessProdInfo ERP_C006_ProcessProdInfo)
        {
        	ERP_C006_ProcessProdInfo.CreateDt = DateTime.Now;
            tb_Sys_User tempUser = appCacheService.GetItem("user") as tb_Sys_User;
            ERP_C006_ProcessProdInfo.CreateUser = tempUser.UserName;
            ERP_C006_ProcessProdInfo.CompCode = tempUser.CompCode;
            ERP_C006_ProcessProdInfo.Validate();
			this.ERP_C006_ProcessProdInfoRepository.Add(ERP_C006_ProcessProdInfo);
            this.runtimeService.Commit();
        }

        public void Delete(Guid Id)
        {
            var existstb_Sys_Menu = this.GetById(Id);
            this.ERP_C006_ProcessProdInfoRepository.Delete(existstb_Sys_Menu);
            this.runtimeService.Commit();
        }

        public void Update(ERP_C006_ProcessProdInfo ERP_C006_ProcessProdInfo)
        {
        	ERP_C006_ProcessProdInfo.ModifyDt = DateTime.Now;
            tb_Sys_User tempUser = appCacheService.GetItem("user") as tb_Sys_User;
            ERP_C006_ProcessProdInfo.ModifyUser = tempUser.UserName;
            ERP_C006_ProcessProdInfo.Validate();
            var existstb_Sys_Menu = this.GetById(ERP_C006_ProcessProdInfo.Id);
            this.ERP_C006_ProcessProdInfoRepository.SetValues(ERP_C006_ProcessProdInfo, existstb_Sys_Menu);
            this.runtimeService.Commit();
        }

        public List<ERP_C006_ProcessProdInfo> GetList(PagingModel pagingModel, DateTime? beginDate, DateTime? endDate)
        {
            var q = this.ERP_C006_ProcessProdInfoRepository.GetMany(i => true);
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