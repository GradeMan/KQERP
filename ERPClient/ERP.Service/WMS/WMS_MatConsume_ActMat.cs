using System;
using System.Linq;
using System.Collections.Generic;
using COM.Data;
using ERP.Data;
using ERP.Domain;
using COM.Service;
namespace ERP.Service
{
	public interface IWMS_MatConsume_ActMatService
	{
		WMS_MatConsume_ActMat GetById(Guid Id);
        List<WMS_MatConsume_ActMat> GetList();
        IQueryable<WMS_MatConsume_ActMat> GetQuery();
		List<WMS_MatConsume_ActMat> GetList(PagingModel pagingModel, DateTime? beginDate, DateTime? endDate);
        void Create(WMS_MatConsume_ActMat WMS_MatConsume_ActMat);
        void Update(WMS_MatConsume_ActMat WMS_MatConsume_ActMat);
        void Delete(Guid Id);
	}
	public class WMS_MatConsume_ActMatService :IWMS_MatConsume_ActMatService
	{
		private IWMS_MatConsume_ActMatRepository WMS_MatConsume_ActMatRepository;
		private IUnitOfWork runtimeService;
		private ICacheServiceBase appCacheService = Unity.Instance.GetService<ICacheServiceBase>();
		public WMS_MatConsume_ActMatService(IDatabaseFactory dbfactory)
		{
			this.runtimeService = new UnitOfWork(dbfactory);
			this.WMS_MatConsume_ActMatRepository = new WMS_MatConsume_ActMatRepository(dbfactory);
		}

		public List<WMS_MatConsume_ActMat> GetList()
        {
            var q = this.WMS_MatConsume_ActMatRepository.GetMany(i => true);
            return q.ToList();
        }
        
		public IQueryable<WMS_MatConsume_ActMat> GetQuery()
        {
            var q = this.WMS_MatConsume_ActMatRepository.GetMany(i => true);
            return q;
        }
        
        public WMS_MatConsume_ActMat GetById(Guid Id)
        {
            return this.WMS_MatConsume_ActMatRepository.GetByID(Id);
        }

        public void Create(WMS_MatConsume_ActMat WMS_MatConsume_ActMat)
        {
        	WMS_MatConsume_ActMat.CreatDt = DateTime.Now;
            tb_Sys_User tempUser = appCacheService.GetItem("user") as tb_Sys_User;
            WMS_MatConsume_ActMat.CreateUser = tempUser.UserName;
            WMS_MatConsume_ActMat.Validate();
			this.WMS_MatConsume_ActMatRepository.Add(WMS_MatConsume_ActMat);
            this.runtimeService.Commit();
        }

        public void Delete(Guid Id)
        {
            var existstb_Sys_Menu = this.GetById(Id);
            this.WMS_MatConsume_ActMatRepository.Delete(existstb_Sys_Menu);
            this.runtimeService.Commit();
        }

        public void Update(WMS_MatConsume_ActMat WMS_MatConsume_ActMat)
        {
        	WMS_MatConsume_ActMat.ModifyDt = DateTime.Now;
            tb_Sys_User tempUser = appCacheService.GetItem("user") as tb_Sys_User;
            WMS_MatConsume_ActMat.ModifyUser = tempUser.UserName;
            WMS_MatConsume_ActMat.Validate();
            var existstb_Sys_Menu = this.GetById(WMS_MatConsume_ActMat.Id);
            this.WMS_MatConsume_ActMatRepository.SetValues(WMS_MatConsume_ActMat, existstb_Sys_Menu);
            this.runtimeService.Commit();
        }

        public List<WMS_MatConsume_ActMat> GetList(PagingModel pagingModel, DateTime? beginDate, DateTime? endDate)
        {
            var q = this.WMS_MatConsume_ActMatRepository.GetMany(i => true);
			if (beginDate.HasValue)
            {
                beginDate = beginDate.Value.Date;
           	    q = q.Where(p => p.CreatDt >= beginDate);
            }
            if (endDate.HasValue)
            {
                endDate = endDate.Value.Date.AddDays(1);
                q = q.Where(p => p.CreatDt < endDate);
            }

            q = q.OrderByDescending(i => i.CreatDt);
            q = q.Paging(pagingModel);
            return q.ToList();
        }
	}
}