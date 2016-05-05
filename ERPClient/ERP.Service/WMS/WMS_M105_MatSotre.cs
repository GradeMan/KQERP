using System;
using System.Linq;
using System.Collections.Generic;
using COM.Data;
using ERP.Data;
using ERP.Domain;
using COM.Service;
namespace ERP.Service
{
	public interface IWMS_M105_MatSotreService
	{
		WMS_M105_MatSotre GetById(Guid Id);
        List<WMS_M105_MatSotre> GetList();
        IQueryable<WMS_M105_MatSotre> GetQuery();
		List<WMS_M105_MatSotre> GetList(PagingModel pagingModel, DateTime? beginDate, DateTime? endDate);
        void Create(WMS_M105_MatSotre WMS_M105_MatSotre);
        void Update(WMS_M105_MatSotre WMS_M105_MatSotre);
        void Delete(Guid Id);
	}
	public class WMS_M105_MatSotreService :IWMS_M105_MatSotreService
	{
		private IWMS_M105_MatSotreRepository WMS_M105_MatSotreRepository;
		private IUnitOfWork runtimeService;
		private ICacheServiceBase appCacheService = Unity.Instance.GetService<ICacheServiceBase>();
		public WMS_M105_MatSotreService(IDatabaseFactory dbfactory)
		{
			this.runtimeService = new UnitOfWork(dbfactory);
			this.WMS_M105_MatSotreRepository = new WMS_M105_MatSotreRepository(dbfactory);
		}

		public List<WMS_M105_MatSotre> GetList()
        {
            var q = this.WMS_M105_MatSotreRepository.GetMany(i => true);
            return q.ToList();
        }
        
		public IQueryable<WMS_M105_MatSotre> GetQuery()
        {
            var q = this.WMS_M105_MatSotreRepository.GetMany(i => true);
            return q;
        }
        
        public WMS_M105_MatSotre GetById(Guid Id)
        {
            return this.WMS_M105_MatSotreRepository.GetByID(Id);
        }

        public void Create(WMS_M105_MatSotre WMS_M105_MatSotre)
        {
        	WMS_M105_MatSotre.CreateDt = DateTime.Now;
            tb_Sys_User tempUser = appCacheService.GetItem("user") as tb_Sys_User;
            WMS_M105_MatSotre.CreateUser = tempUser.UserName;
            WMS_M105_MatSotre.Validate();
			this.WMS_M105_MatSotreRepository.Add(WMS_M105_MatSotre);
            this.runtimeService.Commit();
        }

        public void Delete(Guid Id)
        {
            var existstb_Sys_Menu = this.GetById(Id);
            this.WMS_M105_MatSotreRepository.Delete(existstb_Sys_Menu);
            this.runtimeService.Commit();
        }

        public void Update(WMS_M105_MatSotre WMS_M105_MatSotre)
        {
        	WMS_M105_MatSotre.ModifyDt = DateTime.Now;
            tb_Sys_User tempUser = appCacheService.GetItem("user") as tb_Sys_User;
            WMS_M105_MatSotre.ModifyUser = tempUser.UserName;
            WMS_M105_MatSotre.Validate();
            var existstb_Sys_Menu = this.GetById(WMS_M105_MatSotre.Id);
            this.WMS_M105_MatSotreRepository.SetValues(WMS_M105_MatSotre, existstb_Sys_Menu);
            this.runtimeService.Commit();
        }

        public List<WMS_M105_MatSotre> GetList(PagingModel pagingModel, DateTime? beginDate, DateTime? endDate)
        {
            var q = this.WMS_M105_MatSotreRepository.GetMany(i => true);
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