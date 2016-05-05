using System;
using System.Linq;
using System.Collections.Generic;
using COM.Data;
using ERP.Data;
using ERP.Domain;
using COM.Service;
namespace ERP.Service
{
	public interface IWMS_MatConsume_ActMatMouthCheckService
	{
		WMS_MatConsume_ActMatMouthCheck GetById(Guid Id);
        List<WMS_MatConsume_ActMatMouthCheck> GetList();
        IQueryable<WMS_MatConsume_ActMatMouthCheck> GetQuery();
		List<WMS_MatConsume_ActMatMouthCheck> GetList(PagingModel pagingModel, DateTime? beginDate, DateTime? endDate);
        void Create(WMS_MatConsume_ActMatMouthCheck WMS_MatConsume_ActMatMouthCheck);
        void Update(WMS_MatConsume_ActMatMouthCheck WMS_MatConsume_ActMatMouthCheck);
        void Delete(Guid Id);
	}
	public class WMS_MatConsume_ActMatMouthCheckService :IWMS_MatConsume_ActMatMouthCheckService
	{
		private IWMS_MatConsume_ActMatMouthCheckRepository WMS_MatConsume_ActMatMouthCheckRepository;
		private IUnitOfWork runtimeService;
		private ICacheServiceBase appCacheService = Unity.Instance.GetService<ICacheServiceBase>();
		public WMS_MatConsume_ActMatMouthCheckService(IDatabaseFactory dbfactory)
		{
			this.runtimeService = new UnitOfWork(dbfactory);
			this.WMS_MatConsume_ActMatMouthCheckRepository = new WMS_MatConsume_ActMatMouthCheckRepository(dbfactory);
		}

		public List<WMS_MatConsume_ActMatMouthCheck> GetList()
        {
            var q = this.WMS_MatConsume_ActMatMouthCheckRepository.GetMany(i => true);
            return q.ToList();
        }
        
		public IQueryable<WMS_MatConsume_ActMatMouthCheck> GetQuery()
        {
            var q = this.WMS_MatConsume_ActMatMouthCheckRepository.GetMany(i => true);
            return q;
        }
        
        public WMS_MatConsume_ActMatMouthCheck GetById(Guid Id)
        {
            return this.WMS_MatConsume_ActMatMouthCheckRepository.GetByID(Id);
        }

        public void Create(WMS_MatConsume_ActMatMouthCheck WMS_MatConsume_ActMatMouthCheck)
        {
        	WMS_MatConsume_ActMatMouthCheck.CreateDt = DateTime.Now;
            tb_Sys_User tempUser = appCacheService.GetItem("user") as tb_Sys_User;
            WMS_MatConsume_ActMatMouthCheck.CreateUser = tempUser.UserName;
            WMS_MatConsume_ActMatMouthCheck.Validate();
			this.WMS_MatConsume_ActMatMouthCheckRepository.Add(WMS_MatConsume_ActMatMouthCheck);
            this.runtimeService.Commit();
        }

        public void Delete(Guid Id)
        {
            var existstb_Sys_Menu = this.GetById(Id);
            this.WMS_MatConsume_ActMatMouthCheckRepository.Delete(existstb_Sys_Menu);
            this.runtimeService.Commit();
        }

        public void Update(WMS_MatConsume_ActMatMouthCheck WMS_MatConsume_ActMatMouthCheck)
        {
            tb_Sys_User tempUser = appCacheService.GetItem("user") as tb_Sys_User;
            WMS_MatConsume_ActMatMouthCheck.Validate();
            var existstb_Sys_Menu = this.GetById(WMS_MatConsume_ActMatMouthCheck.Id);
            this.WMS_MatConsume_ActMatMouthCheckRepository.SetValues(WMS_MatConsume_ActMatMouthCheck, existstb_Sys_Menu);
            this.runtimeService.Commit();
        }

        public List<WMS_MatConsume_ActMatMouthCheck> GetList(PagingModel pagingModel, DateTime? beginDate, DateTime? endDate)
        {
            var q = this.WMS_MatConsume_ActMatMouthCheckRepository.GetMany(i => true);
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