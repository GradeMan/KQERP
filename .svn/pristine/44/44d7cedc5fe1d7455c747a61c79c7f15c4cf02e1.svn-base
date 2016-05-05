using System;
using System.Linq;
using System.Collections.Generic;
using COM.Data;
using ERP.Data;
using ERP.Domain;
using COM.Service;
namespace ERP.Service
{
	public interface IProductFileService
	{
		ERP_M001_Product_File GetById(Guid Id);
        List<ERP_M001_Product_File> GetList();
		List<ERP_M001_Product_File> GetList(PagingModel pagingModel, DateTime? beginDate, DateTime? endDate);
        void Create(ERP_M001_Product_File ERP_M001_Product_File);
        void Update(ERP_M001_Product_File ERP_M001_Product_File);
        void Delete(Guid Id);
	}
    public class ProductFileService : IProductFileService
	{
		private IERP_M001_Product_FileRepository ERP_M001_Product_FileRepository;
		private IUnitOfWork runtimeService;
		private ICacheServiceBase appCacheService = Unity.Instance.GetService<ICacheServiceBase>();
        public ProductFileService(IDatabaseFactory dbfactory)
		{
			this.runtimeService = new UnitOfWork(dbfactory);
			this.ERP_M001_Product_FileRepository = new ERP_M001_Product_FileRepository(dbfactory);
		}

		public List<ERP_M001_Product_File> GetList()
        {
            var q = this.ERP_M001_Product_FileRepository.GetMany(i => true);
            return q.ToList();
        }

        public ERP_M001_Product_File GetById(Guid Id)
        {
            return this.ERP_M001_Product_FileRepository.GetByID(Id);
        }

        public void Create(ERP_M001_Product_File ERP_M001_Product_File)
        {
        	ERP_M001_Product_File.CreateDt = DateTime.Now;
            tb_Sys_User tempUser = appCacheService.GetItem("user") as tb_Sys_User;
            ERP_M001_Product_File.CreateUser = tempUser.UserName;
            ERP_M001_Product_File.Validate();
			this.ERP_M001_Product_FileRepository.Add(ERP_M001_Product_File);
            this.runtimeService.Commit();
        }

        public void Delete(Guid Id)
        {
            var existstb_Sys_Menu = this.GetById(Id);
            this.ERP_M001_Product_FileRepository.Delete(existstb_Sys_Menu);
            this.runtimeService.Commit();
        }

        public void Update(ERP_M001_Product_File ERP_M001_Product_File)
        {
        	ERP_M001_Product_File.ModifyDt = DateTime.Now;
            tb_Sys_User tempUser = appCacheService.GetItem("user") as tb_Sys_User;
            ERP_M001_Product_File.ModifyUser = tempUser.UserName;
            ERP_M001_Product_File.Validate();
            var existstb_Sys_Menu = this.GetById(ERP_M001_Product_File.Id);
            this.ERP_M001_Product_FileRepository.SetValues(ERP_M001_Product_File, existstb_Sys_Menu);
            this.runtimeService.Commit();
        }

        public List<ERP_M001_Product_File> GetList(PagingModel pagingModel, DateTime? beginDate, DateTime? endDate)
        {
            var q = this.ERP_M001_Product_FileRepository.GetMany(i => true);
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