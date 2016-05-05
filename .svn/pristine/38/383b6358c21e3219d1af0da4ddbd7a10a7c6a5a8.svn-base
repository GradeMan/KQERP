using System;
using System.Linq;
using System.Collections.Generic;
using COM.Data;
using ERP.Data;
using ERP.Domain;
using COM.Service;
namespace ERP.Service
{
	public interface IProductCustPackService
	{
		ERP_M001_Product_CustPack GetById(Guid Id);
        List<ERP_M001_Product_CustPack> GetList();
		List<ERP_M001_Product_CustPack> GetList(PagingModel pagingModel, DateTime? beginDate, DateTime? endDate);
        void Create(ERP_M001_Product_CustPack ERP_M001_Product_CustPack);
        void Update(ERP_M001_Product_CustPack ERP_M001_Product_CustPack);
        void Delete(Guid Id);
	}
    public class ProductCustPackService : IProductCustPackService
	{
		private IERP_M001_Product_CustPackRepository ERP_M001_Product_CustPackRepository;
		private IUnitOfWork runtimeService;
		private ICacheServiceBase appCacheService = Unity.Instance.GetService<ICacheServiceBase>();
        public ProductCustPackService(IDatabaseFactory dbfactory)
		{
			this.runtimeService = new UnitOfWork(dbfactory);
			this.ERP_M001_Product_CustPackRepository = new ERP_M001_Product_CustPackRepository(dbfactory);
		}

		public List<ERP_M001_Product_CustPack> GetList()
        {
            var q = this.ERP_M001_Product_CustPackRepository.GetMany(i => true);
            return q.ToList();
        }

        public ERP_M001_Product_CustPack GetById(Guid Id)
        {
            return this.ERP_M001_Product_CustPackRepository.GetByID(Id);
        }

        public void Create(ERP_M001_Product_CustPack ERP_M001_Product_CustPack)
        {
        	ERP_M001_Product_CustPack.CreateDt = DateTime.Now;
            tb_Sys_User tempUser = appCacheService.GetItem("user") as tb_Sys_User;
            ERP_M001_Product_CustPack.CreateUser = tempUser.UserName;
            ERP_M001_Product_CustPack.Validate();
			this.ERP_M001_Product_CustPackRepository.Add(ERP_M001_Product_CustPack);
            this.runtimeService.Commit();
        }

        public void Delete(Guid Id)
        {
            var existstb_Sys_Menu = this.GetById(Id);
            this.ERP_M001_Product_CustPackRepository.Delete(existstb_Sys_Menu);
            this.runtimeService.Commit();
        }

        public void Update(ERP_M001_Product_CustPack ERP_M001_Product_CustPack)
        {
        	ERP_M001_Product_CustPack.ModifyDt = DateTime.Now;
            tb_Sys_User tempUser = appCacheService.GetItem("user") as tb_Sys_User;
            ERP_M001_Product_CustPack.ModifyUser = tempUser.UserName;
            ERP_M001_Product_CustPack.Validate();
            var existstb_Sys_Menu = this.GetById(ERP_M001_Product_CustPack.Id);
            this.ERP_M001_Product_CustPackRepository.SetValues(ERP_M001_Product_CustPack, existstb_Sys_Menu);
            this.runtimeService.Commit();
        }

        public List<ERP_M001_Product_CustPack> GetList(PagingModel pagingModel, DateTime? beginDate, DateTime? endDate)
        {
            var q = this.ERP_M001_Product_CustPackRepository.GetMany(i => true);
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