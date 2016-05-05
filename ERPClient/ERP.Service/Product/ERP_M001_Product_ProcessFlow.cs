using System;
using System.Linq;
using System.Collections.Generic;
using COM.Data;
using ERP.Data;
using ERP.Domain;
using COM.Service;
namespace ERP.Service
{
	public interface IProductProcessFlowService
	{
		ERP_M001_Product_ProcessFlow GetById(Guid Id);
        List<ERP_M001_Product_ProcessFlow> GetList();
		List<ERP_M001_Product_ProcessFlow> GetList(PagingModel pagingModel, DateTime? beginDate, DateTime? endDate);
        void Create(ERP_M001_Product_ProcessFlow ERP_M001_Product_ProcessFlow);
        void Update(ERP_M001_Product_ProcessFlow ERP_M001_Product_ProcessFlow);
        void Delete(Guid Id);
	}
    public class ProductProcessFlowService : IProductProcessFlowService
	{
		private IERP_M001_Product_ProcessFlowRepository ERP_M001_Product_ProcessFlowRepository;
		private IUnitOfWork runtimeService;
		private ICacheServiceBase appCacheService = Unity.Instance.GetService<ICacheServiceBase>();
        public ProductProcessFlowService(IDatabaseFactory dbfactory)
		{
			this.runtimeService = new UnitOfWork(dbfactory);
			this.ERP_M001_Product_ProcessFlowRepository = new ERP_M001_Product_ProcessFlowRepository(dbfactory);
		}

		public List<ERP_M001_Product_ProcessFlow> GetList()
        {
            var q = this.ERP_M001_Product_ProcessFlowRepository.GetMany(i => true);
            return q.ToList();
        }

        public ERP_M001_Product_ProcessFlow GetById(Guid Id)
        {
            return this.ERP_M001_Product_ProcessFlowRepository.GetByID(Id);
        }

        public void Create(ERP_M001_Product_ProcessFlow ERP_M001_Product_ProcessFlow)
        {
            tb_Sys_User tempUser = appCacheService.GetItem("user") as tb_Sys_User;
            ERP_M001_Product_ProcessFlow.CompCode = tempUser.CompCode;
            ERP_M001_Product_ProcessFlow.Validate();
			this.ERP_M001_Product_ProcessFlowRepository.Add(ERP_M001_Product_ProcessFlow);
            this.runtimeService.Commit();
        }

        public void Delete(Guid Id)
        {
            var existstb_Sys_Menu = this.GetById(Id);
            this.ERP_M001_Product_ProcessFlowRepository.Delete(existstb_Sys_Menu);
            this.runtimeService.Commit();
        }

        public void Update(ERP_M001_Product_ProcessFlow ERP_M001_Product_ProcessFlow)
        {
            ERP_M001_Product_ProcessFlow.Validate();
            var existstb_Sys_Menu = this.GetById(ERP_M001_Product_ProcessFlow.Id);
            this.ERP_M001_Product_ProcessFlowRepository.SetValues(ERP_M001_Product_ProcessFlow, existstb_Sys_Menu);
            this.runtimeService.Commit();
        }

        public List<ERP_M001_Product_ProcessFlow> GetList(PagingModel pagingModel, DateTime? beginDate, DateTime? endDate)
        {
            var q = this.ERP_M001_Product_ProcessFlowRepository.GetMany(i => true);
            
            q = q.OrderByDescending(i => i.PartNo);
            q = q.Paging(pagingModel);
            return q.ToList();
        }
	}
}