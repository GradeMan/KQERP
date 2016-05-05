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
	public interface IMaterialService
	{
		ERP_M002_Material GetById(Guid Id);
        List<ERP_M002_Material> GetList();
		List<ERP_M002_Material> GetList(PagingModel pagingModel, DateTime? beginDate, DateTime? endDate);
        void Create(ERP_M002_Material ERP_M002_Material);
        void Update(ERP_M002_Material ERP_M002_Material);
        void Delete(Guid Id);
	}
    public class MaterialService : IMaterialService
	{
		private IERP_M002_MaterialRepository ERP_M002_MaterialRepository;
		private IUnitOfWork runtimeService;
		private ICacheServiceBase appCacheService = Unity.Instance.GetService<ICacheServiceBase>();
        public MaterialService(IDatabaseFactory dbfactory)
		{
			this.runtimeService = new UnitOfWork(dbfactory);
			this.ERP_M002_MaterialRepository = new ERP_M002_MaterialRepository(dbfactory);
		}

		public List<ERP_M002_Material> GetList()
        {
            var q = this.ERP_M002_MaterialRepository.GetMany(i => true);
            return q.ToList();
        }

        public ERP_M002_Material GetById(Guid Id)
        {
            return this.ERP_M002_MaterialRepository.GetByID(Id);
        }

        public void Create(ERP_M002_Material ERP_M002_Material)
        {
        	ERP_M002_Material.CreateDt = DateTime.Now;
            tb_Sys_User tempUser = appCacheService.GetItem("user") as tb_Sys_User;
            ERP_M002_Material.CreateUser = tempUser.UserName;
            ERP_M002_Material.CompCode = tempUser.CompCode;
            ERP_M002_Material.Validate();
			this.ERP_M002_MaterialRepository.Add(ERP_M002_Material);
            this.runtimeService.Commit();
        }

        public void Delete(Guid Id)
        {
            var existstb_Sys_Menu = this.GetById(Id);
            this.ERP_M002_MaterialRepository.Delete(existstb_Sys_Menu);
            this.runtimeService.Commit();
        }

        public void Update(ERP_M002_Material ERP_M002_Material)
        {
        	ERP_M002_Material.ModifyDt = DateTime.Now;
            tb_Sys_User tempUser = appCacheService.GetItem("user") as tb_Sys_User;
            ERP_M002_Material.ModifyUser = tempUser.UserName;
            ERP_M002_Material.Validate();
            var existstb_Sys_Menu = this.GetById(ERP_M002_Material.Id);
            this.ERP_M002_MaterialRepository.SetValues(ERP_M002_Material, existstb_Sys_Menu);
            this.runtimeService.Commit();
        }

        public List<ERP_M002_Material> GetList(PagingModel pagingModel, DateTime? beginDate, DateTime? endDate)
        {
            var q = this.ERP_M002_MaterialRepository.GetMany(i => true);
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