using System;
using System.Linq;
using System.Collections.Generic;
using COM.Data;
using ERP.Data;
using ERP.Domain;
using COM.Service;
namespace ERP.Service
{
	public interface IQHProductService
	{
		ERP_M004_QHProduct GetById(Guid Id);
        List<ERP_M004_QHProduct> GetList();
		List<ERP_M004_QHProduct> GetList(PagingModel pagingModel, DateTime? beginDate, DateTime? endDate);
        void Create(ERP_M004_QHProduct ERP_M004_QHProduct);
        void Update(ERP_M004_QHProduct ERP_M004_QHProduct);
        void Delete(Guid Id);
	}
    public class QHProductService : IQHProductService
	{
		private IERP_M004_QHProductRepository ERP_M004_QHProductRepository;
		private IUnitOfWork runtimeService;
		private ICacheServiceBase appCacheService = Unity.Instance.GetService<ICacheServiceBase>();
        public QHProductService(IDatabaseFactory dbfactory)
		{
			this.runtimeService = new UnitOfWork(dbfactory);
			this.ERP_M004_QHProductRepository = new ERP_M004_QHProductRepository(dbfactory);
		}

		public List<ERP_M004_QHProduct> GetList()
        {
            var q = this.ERP_M004_QHProductRepository.GetMany(i => true);
            return q.ToList();
        }

        public ERP_M004_QHProduct GetById(Guid Id)
        {
            return this.ERP_M004_QHProductRepository.GetByID(Id);
        }

        public void Create(ERP_M004_QHProduct ERP_M004_QHProduct)
        {

        	ERP_M004_QHProduct.CreateDt = DateTime.Now;
            tb_Sys_User tempUser = appCacheService.GetItem("user") as tb_Sys_User;
            ERP_M004_QHProduct.CreateUser = tempUser.UserName;
            ERP_M004_QHProduct.CompCode = tempUser.CompCode;
            ERP_M004_QHProduct.Validate();
			this.ERP_M004_QHProductRepository.Add(ERP_M004_QHProduct);
            this.runtimeService.Commit();
        }

        public void Delete(Guid Id)
        {
            var existstb_Sys_Menu = this.GetById(Id);
            this.ERP_M004_QHProductRepository.Delete(existstb_Sys_Menu);
            this.runtimeService.Commit();
        }

        public void Update(ERP_M004_QHProduct ERP_M004_QHProduct)
        {
        	ERP_M004_QHProduct.ModifyDt = DateTime.Now;
            tb_Sys_User tempUser = appCacheService.GetItem("user") as tb_Sys_User;
            ERP_M004_QHProduct.ModifyUser = tempUser.UserName;
            ERP_M004_QHProduct.Validate();
            var existstb_Sys_Menu = this.GetById(ERP_M004_QHProduct.Id);
            this.ERP_M004_QHProductRepository.SetValues(ERP_M004_QHProduct, existstb_Sys_Menu);
            this.runtimeService.Commit();
        }

        public List<ERP_M004_QHProduct> GetList(PagingModel pagingModel, DateTime? beginDate, DateTime? endDate)
        {
            var q = this.ERP_M004_QHProductRepository.GetMany(i => true);
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