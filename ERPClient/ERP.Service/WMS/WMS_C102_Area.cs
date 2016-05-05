using System;
using System.Linq;
using System.Collections.Generic;
using COM.Data;
using ERP.Data;
using ERP.Domain;
using COM.Service;
namespace ERP.Service
{
	public interface IWMSAreaService
	{
		WMS_C102_Area GetById(Guid Id);
        List<WMS_C102_Area> GetList();
		List<WMS_C102_Area> GetList(PagingModel pagingModel, DateTime? beginDate, DateTime? endDate);
        void Create(WMS_C102_Area WMS_C102_Area);
        void Update(WMS_C102_Area WMS_C102_Area);
        void Delete(Guid Id);
        IQueryable<WMS_C102_Area> GetAreaQuery();
	}
    public class WMSAreaService : IWMSAreaService
	{
		private IWMS_C102_AreaRepository WMS_C102_AreaRepository;
		private IUnitOfWork runtimeService;
		private ICacheServiceBase appCacheService = Unity.Instance.GetService<ICacheServiceBase>();
        public WMSAreaService(IDatabaseFactory dbfactory)
		{
			this.runtimeService = new UnitOfWork(dbfactory);
			this.WMS_C102_AreaRepository = new WMS_C102_AreaRepository(dbfactory);
		}
        public IQueryable<WMS_C102_Area> GetAreaQuery()
        {
            var q = this.WMS_C102_AreaRepository.GetMany(i => true);
            return q;
        }
		public List<WMS_C102_Area> GetList()
        {
            var q = this.WMS_C102_AreaRepository.GetMany(i => true);
            return q.ToList();
        }

        public WMS_C102_Area GetById(Guid Id)
        {
            return this.WMS_C102_AreaRepository.GetByID(Id);
        }

        public void Create(WMS_C102_Area WMS_C102_Area)
        {
        	WMS_C102_Area.CreateDt = DateTime.Now;
            tb_Sys_User tempUser = appCacheService.GetItem("user") as tb_Sys_User;
            WMS_C102_Area.CreateUser = tempUser.UserName;
            WMS_C102_Area.Validate();
			this.WMS_C102_AreaRepository.Add(WMS_C102_Area);
            this.runtimeService.Commit();
        }

        public void Delete(Guid Id)
        {
            var existstb_Sys_Menu = this.GetById(Id);
            this.WMS_C102_AreaRepository.Delete(existstb_Sys_Menu);
            this.runtimeService.Commit();
        }

        public void Update(WMS_C102_Area WMS_C102_Area)
        {
        	WMS_C102_Area.ModifyDt = DateTime.Now;
            tb_Sys_User tempUser = appCacheService.GetItem("user") as tb_Sys_User;
            WMS_C102_Area.ModifyUser = tempUser.UserName;
            WMS_C102_Area.Validate();
            var existstb_Sys_Menu = this.GetById(WMS_C102_Area.Id);
            this.WMS_C102_AreaRepository.SetValues(WMS_C102_Area, existstb_Sys_Menu);
            this.runtimeService.Commit();
        }

        public List<WMS_C102_Area> GetList(PagingModel pagingModel, DateTime? beginDate, DateTime? endDate)
        {
            var q = this.WMS_C102_AreaRepository.GetMany(i => true);
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