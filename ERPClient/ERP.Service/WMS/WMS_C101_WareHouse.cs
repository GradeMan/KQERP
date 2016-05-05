using System;
using System.Linq;
using System.Collections.Generic;
using COM.Data;
using ERP.Data;
using ERP.Domain;
using COM.Service;
namespace ERP.Service
{
	public interface IWMSWareHouseService
	{
		WMS_C101_WareHouse GetById(Guid Id);
        List<WMS_C101_WareHouse> GetList();
		List<WMS_C101_WareHouse> GetList(PagingModel pagingModel, DateTime? beginDate, DateTime? endDate);
        void Create(WMS_C101_WareHouse WMS_C101_WareHouse);
        void Update(WMS_C101_WareHouse WMS_C101_WareHouse);
        void Delete(Guid Id);
	}
    public class WMSWareHouseService : IWMSWareHouseService
	{
		private IWMS_C101_WareHouseRepository WMS_C101_WareHouseRepository;
		private IUnitOfWork runtimeService;
		private ICacheServiceBase appCacheService = Unity.Instance.GetService<ICacheServiceBase>();
        public WMSWareHouseService(IDatabaseFactory dbfactory)
		{
			this.runtimeService = new UnitOfWork(dbfactory);
			this.WMS_C101_WareHouseRepository = new WMS_C101_WareHouseRepository(dbfactory);
		}

		public List<WMS_C101_WareHouse> GetList()
        {
            var q = this.WMS_C101_WareHouseRepository.GetMany(i => true);
            return q.ToList();
        }

        public WMS_C101_WareHouse GetById(Guid Id)
        {
            return this.WMS_C101_WareHouseRepository.GetByID(Id);
        }

        public void Create(WMS_C101_WareHouse WMS_C101_WareHouse)
        {
        	WMS_C101_WareHouse.CreateDt = DateTime.Now;
            tb_Sys_User tempUser = appCacheService.GetItem("user") as tb_Sys_User;
            WMS_C101_WareHouse.CreateUser = tempUser.UserName;
            WMS_C101_WareHouse.Validate();
			this.WMS_C101_WareHouseRepository.Add(WMS_C101_WareHouse);
            this.runtimeService.Commit();
        }

        public void Delete(Guid Id)
        {
            var existstb_Sys_Menu = this.GetById(Id);
            this.WMS_C101_WareHouseRepository.Delete(existstb_Sys_Menu);
            this.runtimeService.Commit();
        }

        public void Update(WMS_C101_WareHouse WMS_C101_WareHouse)
        {
        	WMS_C101_WareHouse.ModifyDt = DateTime.Now;
            tb_Sys_User tempUser = appCacheService.GetItem("user") as tb_Sys_User;
            WMS_C101_WareHouse.ModifyUser = tempUser.UserName;
            WMS_C101_WareHouse.Validate();
            var existstb_Sys_Menu = this.GetById(WMS_C101_WareHouse.Id);
            this.WMS_C101_WareHouseRepository.SetValues(WMS_C101_WareHouse, existstb_Sys_Menu);
            this.runtimeService.Commit();
        }

        public List<WMS_C101_WareHouse> GetList(PagingModel pagingModel, DateTime? beginDate, DateTime? endDate)
        {
            var q = this.WMS_C101_WareHouseRepository.GetMany(i => true);
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