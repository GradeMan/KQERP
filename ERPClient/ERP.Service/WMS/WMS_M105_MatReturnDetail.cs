using System;
using System.Linq;
using System.Collections.Generic;
using COM.Data;
using ERP.Data;
using ERP.Domain;
using COM.Service;
namespace ERP.Service
{
	public interface IWMS_M105_MatReturnDetailService
	{
		WMS_M105_MatReturnDetail GetById(Guid Id);
        List<WMS_M105_MatReturnDetail> GetList();
        IQueryable<WMS_M105_MatReturnDetail> GetQuery();
		List<WMS_M105_MatReturnDetail> GetList(PagingModel pagingModel, DateTime? beginDate, DateTime? endDate);
        void Create(WMS_M105_MatReturnDetail WMS_M105_MatReturnDetail);
        void Update(WMS_M105_MatReturnDetail WMS_M105_MatReturnDetail);
        void Delete(Guid Id);
	}
	public class WMS_M105_MatReturnDetailService :IWMS_M105_MatReturnDetailService
	{
		private IWMS_M105_MatReturnDetailRepository WMS_M105_MatReturnDetailRepository;
		private IUnitOfWork runtimeService;
		private ICacheServiceBase appCacheService = Unity.Instance.GetService<ICacheServiceBase>();
		public WMS_M105_MatReturnDetailService(IDatabaseFactory dbfactory)
		{
			this.runtimeService = new UnitOfWork(dbfactory);
			this.WMS_M105_MatReturnDetailRepository = new WMS_M105_MatReturnDetailRepository(dbfactory);
		}

		public List<WMS_M105_MatReturnDetail> GetList()
        {
            var q = this.WMS_M105_MatReturnDetailRepository.GetMany(i => true);
            return q.ToList();
        }
        
		public IQueryable<WMS_M105_MatReturnDetail> GetQuery()
        {
            var q = this.WMS_M105_MatReturnDetailRepository.GetMany(i => true);
            return q;
        }
        
        public WMS_M105_MatReturnDetail GetById(Guid Id)
        {
            return this.WMS_M105_MatReturnDetailRepository.GetByID(Id);
        }

        public void Create(WMS_M105_MatReturnDetail WMS_M105_MatReturnDetail)
        {
        	WMS_M105_MatReturnDetail.CreateDt = DateTime.Now;
            tb_Sys_User tempUser = appCacheService.GetItem("user") as tb_Sys_User;
            WMS_M105_MatReturnDetail.CreateUser = tempUser.UserName;
            WMS_M105_MatReturnDetail.Validate();
			this.WMS_M105_MatReturnDetailRepository.Add(WMS_M105_MatReturnDetail);
            this.runtimeService.Commit();
        }

        public void Delete(Guid Id)
        {
            var existstb_Sys_Menu = this.GetById(Id);
            this.WMS_M105_MatReturnDetailRepository.Delete(existstb_Sys_Menu);
            this.runtimeService.Commit();
        }

        public void Update(WMS_M105_MatReturnDetail WMS_M105_MatReturnDetail)
        {
        	WMS_M105_MatReturnDetail.ModifyDt = DateTime.Now;
            tb_Sys_User tempUser = appCacheService.GetItem("user") as tb_Sys_User;
            WMS_M105_MatReturnDetail.ModifyUser = tempUser.UserName;
            WMS_M105_MatReturnDetail.Validate();
            var existstb_Sys_Menu = this.GetById(WMS_M105_MatReturnDetail.Id);
            this.WMS_M105_MatReturnDetailRepository.SetValues(WMS_M105_MatReturnDetail, existstb_Sys_Menu);
            this.runtimeService.Commit();
        }

        public List<WMS_M105_MatReturnDetail> GetList(PagingModel pagingModel, DateTime? beginDate, DateTime? endDate)
        {
            var q = this.WMS_M105_MatReturnDetailRepository.GetMany(i => true);
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