using System;
using System.Linq;
using System.Collections.Generic;
using COM.Data;
using ERP.Data;
using ERP.Domain;
using COM.Service;
namespace ERP.Service
{
	public interface IModelProductService
	{
		ERP_M003_Model_Product GetById(Guid Id);
        List<ERP_M003_Model_Product> GetList();
		List<ERP_M003_Model_Product> GetList(PagingModel pagingModel, DateTime? beginDate, DateTime? endDate);
        void Create(ERP_M003_Model_Product ERP_M003_Model_Product);
        void Update(ERP_M003_Model_Product ERP_M003_Model_Product);
        void Delete(Guid Id);
	}
    public class ModelProductService : IModelProductService
	{
		private IERP_M003_Model_ProductRepository ERP_M003_Model_ProductRepository;
		private IUnitOfWork runtimeService;
		private ICacheServiceBase appCacheService = Unity.Instance.GetService<ICacheServiceBase>();
        public ModelProductService(IDatabaseFactory dbfactory)
		{
			this.runtimeService = new UnitOfWork(dbfactory);
			this.ERP_M003_Model_ProductRepository = new ERP_M003_Model_ProductRepository(dbfactory);
		}

		public List<ERP_M003_Model_Product> GetList()
        {
            var q = this.ERP_M003_Model_ProductRepository.GetMany(i => true);
            return q.ToList();
        }

        public ERP_M003_Model_Product GetById(Guid Id)
        {
            return this.ERP_M003_Model_ProductRepository.GetByID(Id);
        }

        public void Create(ERP_M003_Model_Product ERP_M003_Model_Product)
        {
        	ERP_M003_Model_Product.CreateDt = DateTime.Now;
            tb_Sys_User tempUser = appCacheService.GetItem("user") as tb_Sys_User;
            ERP_M003_Model_Product.CreateUser = tempUser.UserName;
            ERP_M003_Model_Product.Validate();
			this.ERP_M003_Model_ProductRepository.Add(ERP_M003_Model_Product);
            this.runtimeService.Commit();
        }

        public void Delete(Guid Id)
        {
            var existstb_Sys_Menu = this.GetById(Id);
            this.ERP_M003_Model_ProductRepository.Delete(existstb_Sys_Menu);
            this.runtimeService.Commit();
        }

        public void Update(ERP_M003_Model_Product ERP_M003_Model_Product)
        {
        	ERP_M003_Model_Product.ModifyDt = DateTime.Now;
            tb_Sys_User tempUser = appCacheService.GetItem("user") as tb_Sys_User;
            ERP_M003_Model_Product.ModifyUser = tempUser.UserName;
            ERP_M003_Model_Product.Validate();
            var existstb_Sys_Menu = this.GetById(ERP_M003_Model_Product.Id);
            this.ERP_M003_Model_ProductRepository.SetValues(ERP_M003_Model_Product, existstb_Sys_Menu);
            this.runtimeService.Commit();
        }

        public List<ERP_M003_Model_Product> GetList(PagingModel pagingModel, DateTime? beginDate, DateTime? endDate)
        {
            var q = this.ERP_M003_Model_ProductRepository.GetMany(i => true);
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