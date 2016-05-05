using System;
using System.Linq;
using System.Collections.Generic;
using COM.Data;
using ERP.Data;
using ERP.Domain;
using COM.Service;
namespace ERP.Service
{
	public interface IMES_M501_JobTxProdInfoService
	{
		MES_M501_JobTxProdInfo GetByID(Guid ID);
        List<MES_M501_JobTxProdInfo> GetList();
        IQueryable<MES_M501_JobTxProdInfo> GetQuery();
		List<MES_M501_JobTxProdInfo> GetList(PagingModel pagingModel, DateTime? beginDate, DateTime? endDate);
        void Create(MES_M501_JobTxProdInfo MES_M501_JobTxProdInfo);
        void Update(MES_M501_JobTxProdInfo MES_M501_JobTxProdInfo);
        void Delete(Guid ID);
	}
	public class MES_M501_JobTxProdInfoService :IMES_M501_JobTxProdInfoService
	{
		private IMES_M501_JobTxProdInfoRepository MES_M501_JobTxProdInfoRepository;
		private IUnitOfWork runtimeService;
		private ICacheServiceBase appCacheService = Unity.Instance.GetService<ICacheServiceBase>();
		public MES_M501_JobTxProdInfoService(IDatabaseFactory dbfactory)
		{
			this.runtimeService = new UnitOfWork(dbfactory);
			this.MES_M501_JobTxProdInfoRepository = new MES_M501_JobTxProdInfoRepository(dbfactory);
		}

		public List<MES_M501_JobTxProdInfo> GetList()
        {
            var q = this.MES_M501_JobTxProdInfoRepository.GetMany(i => true);
            return q.ToList();
        }
        
		public IQueryable<MES_M501_JobTxProdInfo> GetQuery()
        {
            var q = this.MES_M501_JobTxProdInfoRepository.GetMany(i => true);
            return q;
        }
        
        public MES_M501_JobTxProdInfo GetByID(Guid ID)
        {
            return this.MES_M501_JobTxProdInfoRepository.GetByID(ID);
        }

        public void Create(MES_M501_JobTxProdInfo MES_M501_JobTxProdInfo)
        {
            tb_Sys_User tempUser = appCacheService.GetItem("user") as tb_Sys_User;
            MES_M501_JobTxProdInfo.CompCode = tempUser.CompCode;
            MES_M501_JobTxProdInfo.Validate();
			this.MES_M501_JobTxProdInfoRepository.Add(MES_M501_JobTxProdInfo);
            this.runtimeService.Commit();
        }

        public void Delete(Guid ID)
        {
            var existstb_Sys_Menu = this.GetByID(ID);
            this.MES_M501_JobTxProdInfoRepository.Delete(existstb_Sys_Menu);
            this.runtimeService.Commit();
        }

        public void Update(MES_M501_JobTxProdInfo MES_M501_JobTxProdInfo)
        {
            MES_M501_JobTxProdInfo.Validate();
            var existstb_Sys_Menu = this.GetByID(MES_M501_JobTxProdInfo.Id);
            this.MES_M501_JobTxProdInfoRepository.SetValues(MES_M501_JobTxProdInfo, existstb_Sys_Menu);
            this.runtimeService.Commit();
        }

        public List<MES_M501_JobTxProdInfo> GetList(PagingModel pagingModel, DateTime? beginDate, DateTime? endDate)
        {
            var q = this.MES_M501_JobTxProdInfoRepository.GetMany(i => true);
            
            q = q.OrderByDescending(i => i.JobNo);
            q = q.Paging(pagingModel);
            return q.ToList();
        }
	}
}