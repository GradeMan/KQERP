using System;
using System.Linq;
using System.Collections.Generic;
using COM.Data;
using ERP.Data;
using ERP.Domain;
using COM.Service;
namespace ERP.Service
{
	public interface IERP_M002_BOM_MaterialService
	{
		ERP_M002_BOM_Material GetById(Guid Id);
        List<ERP_M002_BOM_Material> GetList();
		List<ERP_M002_BOM_Material> GetList(PagingModel pagingModel, DateTime? beginDate, DateTime? endDate);
        void Create(ERP_M002_BOM_Material ERP_M002_BOM_Material);
        void Update(ERP_M002_BOM_Material ERP_M002_BOM_Material);
        void Delete(Guid Id);
        IQueryable<ERP_M002_BOM_Material> GetQuery();
	}
	public class ERP_M002_BOM_MaterialService :IERP_M002_BOM_MaterialService
	{
		private IERP_M002_BOM_MaterialRepository ERP_M002_BOM_MaterialRepository;
		private IUnitOfWork runtimeService;
		private ICacheServiceBase appCacheService = Unity.Instance.GetService<ICacheServiceBase>();
		public ERP_M002_BOM_MaterialService(IDatabaseFactory dbfactory)
		{
			this.runtimeService = new UnitOfWork(dbfactory);
			this.ERP_M002_BOM_MaterialRepository = new ERP_M002_BOM_MaterialRepository(dbfactory);
		}
        public IQueryable<ERP_M002_BOM_Material> GetQuery()
        {
            return this.ERP_M002_BOM_MaterialRepository.GetMany(i => true);
        }
		public List<ERP_M002_BOM_Material> GetList()
        {
            var q = this.ERP_M002_BOM_MaterialRepository.GetMany(i => true);
            return q.ToList();
        }

        public ERP_M002_BOM_Material GetById(Guid Id)
        {
            return this.ERP_M002_BOM_MaterialRepository.GetByID(Id);
        }

        public void Create(ERP_M002_BOM_Material ERP_M002_BOM_Material)
        {
        	ERP_M002_BOM_Material.CreateDt = DateTime.Now;
            tb_Sys_User tempUser = appCacheService.GetItem("user") as tb_Sys_User;
            ERP_M002_BOM_Material.CreateUser = tempUser.UserName;
            ERP_M002_BOM_Material.Validate();
			this.ERP_M002_BOM_MaterialRepository.Add(ERP_M002_BOM_Material);
            this.runtimeService.Commit();
        }

        public void Delete(Guid Id)
        {
            var existstb_Sys_Menu = this.GetById(Id);
            this.ERP_M002_BOM_MaterialRepository.Delete(existstb_Sys_Menu);
            this.runtimeService.Commit();
        }

        public void Update(ERP_M002_BOM_Material ERP_M002_BOM_Material)
        {
        	ERP_M002_BOM_Material.ModifyDt = DateTime.Now;
            tb_Sys_User tempUser = appCacheService.GetItem("user") as tb_Sys_User;
            ERP_M002_BOM_Material.ModifyUser = tempUser.UserName;
            ERP_M002_BOM_Material.Validate();
            var existstb_Sys_Menu = this.GetById(ERP_M002_BOM_Material.Id);
            this.ERP_M002_BOM_MaterialRepository.SetValues(ERP_M002_BOM_Material, existstb_Sys_Menu);
            this.runtimeService.Commit();
        }

        public List<ERP_M002_BOM_Material> GetList(PagingModel pagingModel, DateTime? beginDate, DateTime? endDate)
        {
            var q = this.ERP_M002_BOM_MaterialRepository.GetMany(i => true);
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