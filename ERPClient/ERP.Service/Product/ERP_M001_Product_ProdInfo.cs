using System;
using System.Linq;
using System.Collections.Generic;
using COM.Data;
using ERP.Data;
using ERP.Domain;
using COM.Service;
using COM.Domain;
namespace ERP.Service
{
	public interface IProductProdInfoService
	{
		ERP_M001_Product_ProdInfo GetById(Guid Id);
        List<ERP_M001_Product_ProdInfo> GetList();
		List<ERP_M001_Product_ProdInfo> GetList(PagingModel pagingModel, DateTime? beginDate, DateTime? endDate);
        void Create(ERP_M001_Product_ProdInfo ERP_M001_Product_ProdInfo);
        void Update(ERP_M001_Product_ProdInfo ERP_M001_Product_ProdInfo);
        void Delete(Guid Id);
        string[] GetListByItemAndPocessCode(string itemCode,string processCode);
	}
    public class ProductProdInfoService : IProductProdInfoService
	{
		private IERP_M001_Product_ProdInfoRepository ERP_M001_Product_ProdInfoRepository;
		private IUnitOfWork runtimeService;
		private ICacheServiceBase appCacheService = Unity.Instance.GetService<ICacheServiceBase>();
        public ProductProdInfoService(IDatabaseFactory dbfactory)
		{
			this.runtimeService = new UnitOfWork(dbfactory);
			this.ERP_M001_Product_ProdInfoRepository = new ERP_M001_Product_ProdInfoRepository(dbfactory);
		}
        
		public List<ERP_M001_Product_ProdInfo> GetList()
        {
            var q = this.ERP_M001_Product_ProdInfoRepository.GetMany(i => true);
            return q.ToList();
        }

        public ERP_M001_Product_ProdInfo GetById(Guid Id)
        {
            return this.ERP_M001_Product_ProdInfoRepository.GetByID(Id);
        }

        public void Create(ERP_M001_Product_ProdInfo ERP_M001_Product_ProdInfo)
        {
            tb_Sys_User tempUser = appCacheService.GetItem("user") as tb_Sys_User;
            ERP_M001_Product_ProdInfo.CompCode = tempUser.CompCode;
            ERP_M001_Product_ProdInfo.Validate();
			this.ERP_M001_Product_ProdInfoRepository.Add(ERP_M001_Product_ProdInfo);
            this.runtimeService.Commit();
        }

        public void Delete(Guid Id)
        {
            var existstb_Sys_Menu = this.GetById(Id);
            this.ERP_M001_Product_ProdInfoRepository.Delete(existstb_Sys_Menu);
            this.runtimeService.Commit();
        }

        public void Update(ERP_M001_Product_ProdInfo ERP_M001_Product_ProdInfo)
        {

            ERP_M001_Product_ProdInfo.Validate();
            var existstb_Sys_Menu = this.GetById(ERP_M001_Product_ProdInfo.Id);
            this.ERP_M001_Product_ProdInfoRepository.SetValues(ERP_M001_Product_ProdInfo, existstb_Sys_Menu);
            this.runtimeService.Commit();
        }

        public List<ERP_M001_Product_ProdInfo> GetList(PagingModel pagingModel, DateTime? beginDate, DateTime? endDate)
        {
            var q = this.ERP_M001_Product_ProdInfoRepository.GetMany(i => true);
            
            q = q.OrderByDescending(i => i.PartNo);
            q = q.Paging(pagingModel);
            return q.ToList();
        }


        public string[] GetListByItemAndPocessCode(string itemCode, string processCode)
        {
            var q = this.ERP_M001_Product_ProdInfoRepository.GetMany(i => i.PartNo == itemCode && i.ProcessCode == processCode).Select(i => i.TechCode+":"+i.TechContent).ToList();
            return q.ToArray();
        }
    }
}