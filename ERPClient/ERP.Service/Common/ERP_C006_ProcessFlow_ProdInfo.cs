using System;
using System.Linq;
using System.Collections.Generic;
using COM.Data;
using ERP.Data;
using ERP.Domain;
using COM.Service;
namespace ERP.Service
{
	public interface IERP_C006_ProcessFlow_ProdInfoService
	{
		ERP_C006_ProcessFlow_ProdInfo GetById(Guid Id);
        List<ERP_C006_ProcessFlow_ProdInfo> GetList();
        IQueryable<ERP_C006_ProcessFlow_ProdInfo> GetQuery();
		List<ERP_C006_ProcessFlow_ProdInfo> GetList(PagingModel pagingModel, DateTime? beginDate, DateTime? endDate);
        void Create(ERP_C006_ProcessFlow_ProdInfo ERP_C006_ProcessFlow_ProdInfo);
        void Update(ERP_C006_ProcessFlow_ProdInfo ERP_C006_ProcessFlow_ProdInfo);
        void Delete(Guid Id);
	}
	public class ERP_C006_ProcessFlow_ProdInfoService :IERP_C006_ProcessFlow_ProdInfoService
	{
		private IERP_C006_ProcessFlow_ProdInfoRepository ERP_C006_ProcessFlow_ProdInfoRepository;
		private IUnitOfWork runtimeService;
		private ICacheServiceBase appCacheService = Unity.Instance.GetService<ICacheServiceBase>();
		public ERP_C006_ProcessFlow_ProdInfoService(IDatabaseFactory dbfactory)
		{
			this.runtimeService = new UnitOfWork(dbfactory);
			this.ERP_C006_ProcessFlow_ProdInfoRepository = new ERP_C006_ProcessFlow_ProdInfoRepository(dbfactory);
		}

		public List<ERP_C006_ProcessFlow_ProdInfo> GetList()
        {
            var q = this.ERP_C006_ProcessFlow_ProdInfoRepository.GetMany(i => true);
            return q.ToList();
        }
        
		public IQueryable<ERP_C006_ProcessFlow_ProdInfo> GetQuery()
        {
            var q = this.ERP_C006_ProcessFlow_ProdInfoRepository.GetMany(i => true);
            return q;
        }
        
        public ERP_C006_ProcessFlow_ProdInfo GetById(Guid Id)
        {
            return this.ERP_C006_ProcessFlow_ProdInfoRepository.GetByID(Id);
        }

        public void Create(ERP_C006_ProcessFlow_ProdInfo ERP_C006_ProcessFlow_ProdInfo)
        {
            tb_Sys_User tempUser = appCacheService.GetItem("user") as tb_Sys_User;
            ERP_C006_ProcessFlow_ProdInfo.CompCode = tempUser.CompCode;
            ERP_C006_ProcessFlow_ProdInfo.Validate();
			this.ERP_C006_ProcessFlow_ProdInfoRepository.Add(ERP_C006_ProcessFlow_ProdInfo);
            this.runtimeService.Commit();
        }

        public void Delete(Guid Id)
        {
            var existstb_Sys_Menu = this.GetById(Id);
            this.ERP_C006_ProcessFlow_ProdInfoRepository.Delete(existstb_Sys_Menu);
            this.runtimeService.Commit();
        }

        public void Update(ERP_C006_ProcessFlow_ProdInfo ERP_C006_ProcessFlow_ProdInfo)
        {
            tb_Sys_User tempUser = appCacheService.GetItem("user") as tb_Sys_User;
            ERP_C006_ProcessFlow_ProdInfo.Validate();
            var existstb_Sys_Menu = this.GetById(ERP_C006_ProcessFlow_ProdInfo.Id);
            this.ERP_C006_ProcessFlow_ProdInfoRepository.SetValues(ERP_C006_ProcessFlow_ProdInfo, existstb_Sys_Menu);
            this.runtimeService.Commit();
        }

        public List<ERP_C006_ProcessFlow_ProdInfo> GetList(PagingModel pagingModel, DateTime? beginDate, DateTime? endDate)
        {
            var q = this.ERP_C006_ProcessFlow_ProdInfoRepository.GetMany(i => true);
            
            q = q.OrderByDescending(i => i.PFCode);
            q = q.Paging(pagingModel);
            return q.ToList();
        }
	}
}