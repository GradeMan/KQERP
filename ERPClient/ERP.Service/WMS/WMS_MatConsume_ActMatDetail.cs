using System;
using System.Linq;
using System.Collections.Generic;
using COM.Data;
using ERP.Data;
using ERP.Domain;
using COM.Service;
namespace ERP.Service
{
	public interface IWMS_MatConsume_ActMatDetailService
	{
		WMS_MatConsume_ActMatDetail GetById(Guid Id);
        List<WMS_MatConsume_ActMatDetail> GetList();
        IQueryable<WMS_MatConsume_ActMatDetail> GetQuery();
		List<WMS_MatConsume_ActMatDetail> GetList(PagingModel pagingModel, DateTime? beginDate, DateTime? endDate);
        void Create(WMS_MatConsume_ActMatDetail WMS_MatConsume_ActMatDetail);
        void Update(WMS_MatConsume_ActMatDetail WMS_MatConsume_ActMatDetail);
        void Delete(Guid Id);
	}
	public class WMS_MatConsume_ActMatDetailService :IWMS_MatConsume_ActMatDetailService
	{
		private IWMS_MatConsume_ActMatDetailRepository WMS_MatConsume_ActMatDetailRepository;
		private IUnitOfWork runtimeService;
		private ICacheServiceBase appCacheService = Unity.Instance.GetService<ICacheServiceBase>();
		public WMS_MatConsume_ActMatDetailService(IDatabaseFactory dbfactory)
		{
			this.runtimeService = new UnitOfWork(dbfactory);
			this.WMS_MatConsume_ActMatDetailRepository = new WMS_MatConsume_ActMatDetailRepository(dbfactory);
		}

		public List<WMS_MatConsume_ActMatDetail> GetList()
        {
            var q = this.WMS_MatConsume_ActMatDetailRepository.GetMany(i => true);
            return q.ToList();
        }
        
		public IQueryable<WMS_MatConsume_ActMatDetail> GetQuery()
        {
            var q = this.WMS_MatConsume_ActMatDetailRepository.GetMany(i => true);
            return q;
        }
        
        public WMS_MatConsume_ActMatDetail GetById(Guid Id)
        {
            return this.WMS_MatConsume_ActMatDetailRepository.GetByID(Id);
        }

        public void Create(WMS_MatConsume_ActMatDetail WMS_MatConsume_ActMatDetail)
        {
            tb_Sys_User tempUser = appCacheService.GetItem("user") as tb_Sys_User;
            WMS_MatConsume_ActMatDetail.Validate();
			this.WMS_MatConsume_ActMatDetailRepository.Add(WMS_MatConsume_ActMatDetail);
            this.runtimeService.Commit();
        }

        public void Delete(Guid Id)
        {
            var existstb_Sys_Menu = this.GetById(Id);
            this.WMS_MatConsume_ActMatDetailRepository.Delete(existstb_Sys_Menu);
            this.runtimeService.Commit();
        }

        public void Update(WMS_MatConsume_ActMatDetail WMS_MatConsume_ActMatDetail)
        {
            tb_Sys_User tempUser = appCacheService.GetItem("user") as tb_Sys_User;
            WMS_MatConsume_ActMatDetail.Validate();
            var existstb_Sys_Menu = this.GetById(WMS_MatConsume_ActMatDetail.Id);
            this.WMS_MatConsume_ActMatDetailRepository.SetValues(WMS_MatConsume_ActMatDetail, existstb_Sys_Menu);
            this.runtimeService.Commit();
        }

        public List<WMS_MatConsume_ActMatDetail> GetList(PagingModel pagingModel, DateTime? beginDate, DateTime? endDate)
        {
            var q = this.WMS_MatConsume_ActMatDetailRepository.GetMany(i => true);
            q = q.OrderByDescending(i => i.MatCode);
            q = q.Paging(pagingModel);
            return q.ToList();
        }
	}
}