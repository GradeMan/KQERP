using System;
using System.Linq;
using System.Collections.Generic;
using COM.Data;
using ERP.Data;
using ERP.Domain;
using COM.Service;
namespace ERP.Service
{
	public interface IMES_M501_JobTx_NGService
	{
		MES_M501_JobTx_NG GetById(Guid Id);
        List<MES_M501_JobTx_NG> GetList();
        IQueryable<MES_M501_JobTx_NG> GetQuery();
		List<MES_M501_JobTx_NG> GetList(PagingModel pagingModel, DateTime? beginDate, DateTime? endDate);
        void Create(MES_M501_JobTx_NG MES_M501_JobTx_NG);
        void Update(MES_M501_JobTx_NG MES_M501_JobTx_NG);
        void Delete(Guid Id);
	}
	public class MES_M501_JobTx_NGService :IMES_M501_JobTx_NGService
	{
		private IMES_M501_JobTx_NGRepository MES_M501_JobTx_NGRepository;
		private IUnitOfWork runtimeService;
		private ICacheServiceBase appCacheService = Unity.Instance.GetService<ICacheServiceBase>();
		public MES_M501_JobTx_NGService(IDatabaseFactory dbfactory)
		{
			this.runtimeService = new UnitOfWork(dbfactory);
			this.MES_M501_JobTx_NGRepository = new MES_M501_JobTx_NGRepository(dbfactory);
		}

		public List<MES_M501_JobTx_NG> GetList()
        {
            var q = this.MES_M501_JobTx_NGRepository.GetMany(i => true);
            return q.ToList();
        }
        
		public IQueryable<MES_M501_JobTx_NG> GetQuery()
        {
            var q = this.MES_M501_JobTx_NGRepository.GetMany(i => true);
            return q;
        }
        
        public MES_M501_JobTx_NG GetById(Guid Id)
        {
            return this.MES_M501_JobTx_NGRepository.GetByID(Id);
        }

        public void Create(MES_M501_JobTx_NG MES_M501_JobTx_NG)
        {
        	MES_M501_JobTx_NG.CreateDt = DateTime.Now;
            tb_Sys_User tempUser = appCacheService.GetItem("user") as tb_Sys_User;
            MES_M501_JobTx_NG.CreateUser = tempUser.UserName;
            MES_M501_JobTx_NG.Validate();
			this.MES_M501_JobTx_NGRepository.Add(MES_M501_JobTx_NG);
            this.runtimeService.Commit();
        }

        public void Delete(Guid Id)
        {
            var existstb_Sys_Menu = this.GetById(Id);
            this.MES_M501_JobTx_NGRepository.Delete(existstb_Sys_Menu);
            this.runtimeService.Commit();
        }

        public void Update(MES_M501_JobTx_NG MES_M501_JobTx_NG)
        {
        	MES_M501_JobTx_NG.ModifyDt = DateTime.Now;
            tb_Sys_User tempUser = appCacheService.GetItem("user") as tb_Sys_User;
            MES_M501_JobTx_NG.ModifyUser = tempUser.UserName;
            MES_M501_JobTx_NG.Validate();
            var existstb_Sys_Menu = this.GetById(MES_M501_JobTx_NG.Id);
            this.MES_M501_JobTx_NGRepository.SetValues(MES_M501_JobTx_NG, existstb_Sys_Menu);
            this.runtimeService.Commit();
        }

        public List<MES_M501_JobTx_NG> GetList(PagingModel pagingModel, DateTime? beginDate, DateTime? endDate)
        {
            var q = this.MES_M501_JobTx_NGRepository.GetMany(i => true);
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