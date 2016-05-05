using System;
using System.Linq;
using System.Collections.Generic;
using COM.Data;
using ERP.Data;
using ERP.Domain;
using COM.Service;
namespace ERP.Service
{
	public interface IWMSShelfService
	{
		WMS_C103_Shelf GetById(Guid Id);
        List<WMS_C103_Shelf> GetList();
		List<WMS_C103_Shelf> GetList(PagingModel pagingModel, DateTime? beginDate, DateTime? endDate);
        void Create(WMS_C103_Shelf WMS_C103_Shelf);
        void Update(WMS_C103_Shelf WMS_C103_Shelf);
        void Delete(Guid Id);
	}
    public class WMSShelfService : IWMSShelfService
	{
		private IWMS_C103_ShelfRepository WMS_C103_ShelfRepository;
		private IUnitOfWork runtimeService;
		private ICacheServiceBase appCacheService = Unity.Instance.GetService<ICacheServiceBase>();
        public WMSShelfService(IDatabaseFactory dbfactory)
		{
			this.runtimeService = new UnitOfWork(dbfactory);
			this.WMS_C103_ShelfRepository = new WMS_C103_ShelfRepository(dbfactory);
		}

		public List<WMS_C103_Shelf> GetList()
        {
            var q = this.WMS_C103_ShelfRepository.GetMany(i => true);
            return q.ToList();
        }

        public WMS_C103_Shelf GetById(Guid Id)
        {
            return this.WMS_C103_ShelfRepository.GetByID(Id);
        }

        public void Create(WMS_C103_Shelf WMS_C103_Shelf)
        {
        	WMS_C103_Shelf.CreateDt = DateTime.Now;
            tb_Sys_User tempUser = appCacheService.GetItem("user") as tb_Sys_User;
            WMS_C103_Shelf.CreateUser = tempUser.UserName;
            WMS_C103_Shelf.Validate();
			this.WMS_C103_ShelfRepository.Add(WMS_C103_Shelf);
            this.runtimeService.Commit();
        }

        public void Delete(Guid Id)
        {
            var existstb_Sys_Menu = this.GetById(Id);
            this.WMS_C103_ShelfRepository.Delete(existstb_Sys_Menu);
            this.runtimeService.Commit();
        }

        public void Update(WMS_C103_Shelf WMS_C103_Shelf)
        {
        	WMS_C103_Shelf.ModifyDt = DateTime.Now;
            tb_Sys_User tempUser = appCacheService.GetItem("user") as tb_Sys_User;
            WMS_C103_Shelf.ModifyUser = tempUser.UserName;
            WMS_C103_Shelf.Validate();
            var existstb_Sys_Menu = this.GetById(WMS_C103_Shelf.Id);
            this.WMS_C103_ShelfRepository.SetValues(WMS_C103_Shelf, existstb_Sys_Menu);
            this.runtimeService.Commit();
        }

        public List<WMS_C103_Shelf> GetList(PagingModel pagingModel, DateTime? beginDate, DateTime? endDate)
        {
            var q = this.WMS_C103_ShelfRepository.GetMany(i => true);
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