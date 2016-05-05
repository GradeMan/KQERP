using System;
using System.Linq;
using System.Collections.Generic;
using COM.Data;
using ERP.Data;
using ERP.Domain;
using COM.Service;
namespace ERP.Service
{
	public interface IWMSProductService
	{
		WMS_M001_Product GetById(Guid Id);
        List<WMS_M001_Product> GetList();
		List<WMS_M001_Product> GetList(PagingModel pagingModel, DateTime? beginDate, DateTime? endDate);
        void Create(WMS_M001_Product WMS_M001_Product);
        void Update(WMS_M001_Product WMS_M001_Product);
        void Delete(Guid Id);
	}
    public class WMSProductService : IWMSProductService
	{
		private IWMS_M001_ProductRepository WMS_M001_ProductRepository;
		private IUnitOfWork runtimeService;
		private ICacheServiceBase appCacheService = Unity.Instance.GetService<ICacheServiceBase>();
        public WMSProductService(IDatabaseFactory dbfactory)
		{
			this.runtimeService = new UnitOfWork(dbfactory);
			this.WMS_M001_ProductRepository = new WMS_M001_ProductRepository(dbfactory);
		}

		public List<WMS_M001_Product> GetList()
        {
            var q = this.WMS_M001_ProductRepository.GetMany(i => true);
            return q.ToList();
        }

        public WMS_M001_Product GetById(Guid Id)
        {
            return this.WMS_M001_ProductRepository.GetByID(Id);
        }

        public void Create(WMS_M001_Product WMS_M001_Product)
        {
        	WMS_M001_Product.CreateDt = DateTime.Now;
            tb_Sys_User tempUser = appCacheService.GetItem("user") as tb_Sys_User;
            WMS_M001_Product.CreateUser = tempUser.UserName;
            WMS_M001_Product.Validate();
			this.WMS_M001_ProductRepository.Add(WMS_M001_Product);
            this.runtimeService.Commit();
        }

        public void Delete(Guid Id)
        {
            var existstb_Sys_Menu = this.GetById(Id);
            this.WMS_M001_ProductRepository.Delete(existstb_Sys_Menu);
            this.runtimeService.Commit();
        }

        public void Update(WMS_M001_Product WMS_M001_Product)
        {
        	WMS_M001_Product.ModifyDt = DateTime.Now;
            tb_Sys_User tempUser = appCacheService.GetItem("user") as tb_Sys_User;
            WMS_M001_Product.ModifyUser = tempUser.UserName;
            WMS_M001_Product.Validate();
            var existstb_Sys_Menu = this.GetById(WMS_M001_Product.Id);
            this.WMS_M001_ProductRepository.SetValues(WMS_M001_Product, existstb_Sys_Menu);
            this.runtimeService.Commit();
        }

        public List<WMS_M001_Product> GetList(PagingModel pagingModel, DateTime? beginDate, DateTime? endDate)
        {
            var q = this.WMS_M001_ProductRepository.GetMany(i => true);
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