using System;
using System.Linq;
using System.Collections.Generic;
using COM.Data;
using ERP.Data;
using ERP.Domain;
using COM.Service;
namespace ERP.Service
{
	public interface IWMS_M105_MatGetDetailService
	{
		WMS_M105_MatGetDetail GetById(Guid Id);
        List<WMS_M105_MatGetDetail> GetList();
        IQueryable<WMS_M105_MatGetDetail> GetQuery();
		List<WMS_M105_MatGetDetail> GetList(PagingModel pagingModel, DateTime? beginDate, DateTime? endDate);
        void Create(WMS_M105_MatGetDetail WMS_M105_MatGetDetail);
        void Update(WMS_M105_MatGetDetail WMS_M105_MatGetDetail);
        void Delete(Guid Id);
	}
	public class WMS_M105_MatGetDetailService :IWMS_M105_MatGetDetailService
	{
		private IWMS_M105_MatGetDetailRepository WMS_M105_MatGetDetailRepository;
		private IUnitOfWork runtimeService;
		private ICacheServiceBase appCacheService = Unity.Instance.GetService<ICacheServiceBase>();
        
		public WMS_M105_MatGetDetailService(IDatabaseFactory dbfactory)
		{
			this.runtimeService = new UnitOfWork(dbfactory);
			this.WMS_M105_MatGetDetailRepository = new WMS_M105_MatGetDetailRepository(dbfactory);
		}

		public List<WMS_M105_MatGetDetail> GetList()
        {
            var q = this.WMS_M105_MatGetDetailRepository.GetMany(i => true);
            return q.ToList();
        }
        
		public IQueryable<WMS_M105_MatGetDetail> GetQuery()
        {
            var q = this.WMS_M105_MatGetDetailRepository.GetMany(i => true);
            return q;
        }
        
        public WMS_M105_MatGetDetail GetById(Guid Id)
        {
            return this.WMS_M105_MatGetDetailRepository.GetByID(Id);
        }

        public void Create(WMS_M105_MatGetDetail WMS_M105_MatGetDetail)
        {
        	WMS_M105_MatGetDetail.CreateDt = DateTime.Now;
            tb_Sys_User tempUser = appCacheService.GetItem("user") as tb_Sys_User;
            WMS_M105_MatGetDetail.CreateUser = tempUser.UserName;
            WMS_M105_MatGetDetail.Validate();
			this.WMS_M105_MatGetDetailRepository.Add(WMS_M105_MatGetDetail);
            this.runtimeService.Commit();
        }

        public void Delete(Guid Id)
        {
            var existstb_Sys_Menu = this.GetById(Id);
            this.WMS_M105_MatGetDetailRepository.Delete(existstb_Sys_Menu);
            this.runtimeService.Commit();
        }

        public void Update(WMS_M105_MatGetDetail WMS_M105_MatGetDetail)
        {
        	WMS_M105_MatGetDetail.ModifyDt = DateTime.Now;
            tb_Sys_User tempUser = appCacheService.GetItem("user") as tb_Sys_User;
            WMS_M105_MatGetDetail.ModifyUser = tempUser.UserName;
            WMS_M105_MatGetDetail.Validate();
            var existstb_Sys_Menu = this.GetById(WMS_M105_MatGetDetail.Id);
            this.WMS_M105_MatGetDetailRepository.SetValues(WMS_M105_MatGetDetail, existstb_Sys_Menu);
            this.runtimeService.Commit();
        }

        public List<WMS_M105_MatGetDetail> GetList(PagingModel pagingModel, DateTime? beginDate, DateTime? endDate)
        {
            var q = this.WMS_M105_MatGetDetailRepository.GetMany(i => true);
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