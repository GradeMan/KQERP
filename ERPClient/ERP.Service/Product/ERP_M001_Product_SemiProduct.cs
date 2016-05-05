using System;
using System.Linq;
using System.Collections.Generic;
using COM.Data;
using ERP.Data;
using ERP.Domain;
using COM.Service;
namespace ERP.Service
{
	public interface IERP_M001_Product_SemiProductService
	{
		ERP_M001_Product_SemiProduct GetById(Guid Id);
        List<ERP_M001_Product_SemiProduct> GetList();
		List<ERP_M001_Product_SemiProduct> GetList(PagingModel pagingModel, DateTime? beginDate, DateTime? endDate);
        void Create(ERP_M001_Product_SemiProduct ERP_M001_Product_SemiProduct);
        void Update(ERP_M001_Product_SemiProduct ERP_M001_Product_SemiProduct);
        void Delete(Guid Id);
	}
	public class ERP_M001_Product_SemiProductService :IERP_M001_Product_SemiProductService
	{
		private IERP_M001_Product_SemiProductRepository ERP_M001_Product_SemiProductRepository;
		private IUnitOfWork runtimeService;
		private ICacheServiceBase appCacheService = Unity.Instance.GetService<ICacheServiceBase>();
		public ERP_M001_Product_SemiProductService(IDatabaseFactory dbfactory)
		{
			this.runtimeService = new UnitOfWork(dbfactory);
			this.ERP_M001_Product_SemiProductRepository = new ERP_M001_Product_SemiProductRepository(dbfactory);
		}

		public List<ERP_M001_Product_SemiProduct> GetList()
        {
            var q = this.ERP_M001_Product_SemiProductRepository.GetMany(i => true);
            return q.ToList();
        }

        public ERP_M001_Product_SemiProduct GetById(Guid Id)
        {
            return this.ERP_M001_Product_SemiProductRepository.GetByID(Id);
        }

        public void Create(ERP_M001_Product_SemiProduct ERP_M001_Product_SemiProduct)
        {
        	ERP_M001_Product_SemiProduct.CreateDt = DateTime.Now;
            tb_Sys_User tempUser = appCacheService.GetItem("user") as tb_Sys_User;
            ERP_M001_Product_SemiProduct.CreateUser = tempUser.UserName;
            ERP_M001_Product_SemiProduct.Validate();
			this.ERP_M001_Product_SemiProductRepository.Add(ERP_M001_Product_SemiProduct);
            this.runtimeService.Commit();
        }

        public void Delete(Guid Id)
        {
            var existstb_Sys_Menu = this.GetById(Id);
            this.ERP_M001_Product_SemiProductRepository.Delete(existstb_Sys_Menu);
            this.runtimeService.Commit();
        }

        public void Update(ERP_M001_Product_SemiProduct ERP_M001_Product_SemiProduct)
        {
        	ERP_M001_Product_SemiProduct.ModifyDt = DateTime.Now;
            tb_Sys_User tempUser = appCacheService.GetItem("user") as tb_Sys_User;
            ERP_M001_Product_SemiProduct.ModifyUser = tempUser.UserName;
            ERP_M001_Product_SemiProduct.Validate();
            var existstb_Sys_Menu = this.GetById(ERP_M001_Product_SemiProduct.Id);
            this.ERP_M001_Product_SemiProductRepository.SetValues(ERP_M001_Product_SemiProduct, existstb_Sys_Menu);
            this.runtimeService.Commit();
        }

        public List<ERP_M001_Product_SemiProduct> GetList(PagingModel pagingModel, DateTime? beginDate, DateTime? endDate)
        {
            var q = this.ERP_M001_Product_SemiProductRepository.GetMany(i => true);
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