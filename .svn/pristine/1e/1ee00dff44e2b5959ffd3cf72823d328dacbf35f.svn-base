using System;
using System.Linq;
using System.Collections.Generic;
using COM.Data;
using ERP.Data;
using ERP.Domain;
using COM.Service;
namespace ERP.Service
{
	public interface IERP_M002_BOMService
	{
		ERP_M002_BOM GetById(Guid Id);
        List<ERP_M002_BOM> GetList();
		List<ERP_M002_BOM> GetList(PagingModel pagingModel, DateTime? beginDate, DateTime? endDate);
        void Create(ERP_M002_BOM ERP_M002_BOM);
        void Update(ERP_M002_BOM ERP_M002_BOM);
        void Delete(Guid Id);
        IQueryable<ERP_M002_BOM_Material> GetBomMatQuery();
        void MarkDelMat(ERP_M002_BOM_Material temp);
        void Save(ERP_M002_BOM bom, List<ERP_M002_BOM_Material> bomMatList);
	}
	public class ERP_M002_BOMService :IERP_M002_BOMService
	{
		private IERP_M002_BOMRepository ERP_M002_BOMRepository;
        private IERP_M002_BOM_MaterialRepository bomMaterialRepository;
		private IUnitOfWork runtimeService;
		private ICacheServiceBase appCacheService = Unity.Instance.GetService<ICacheServiceBase>();
		public ERP_M002_BOMService(IDatabaseFactory dbfactory)
		{
			this.runtimeService = new UnitOfWork(dbfactory);
			this.ERP_M002_BOMRepository = new ERP_M002_BOMRepository(dbfactory);
            bomMaterialRepository = new ERP_M002_BOM_MaterialRepository(dbfactory);
		}
        public void Save(ERP_M002_BOM bom, List<ERP_M002_BOM_Material> bomMatList)
        {
            tb_Sys_User tempUser = appCacheService.GetItem("user") as tb_Sys_User;

            var existsdevice = this.GetById(bom.Id);
            if (existsdevice == null)
            {
                bom.CompCode = tempUser.CompCode;
                bom.CreateDt = DateTime.Now;
                bom.CreateUser = tempUser.UserName;
                bom.Validate();
                this.ERP_M002_BOMRepository.Add(bom);
            }
            else
            {
                bom.ModifyDt = DateTime.Now;
                bom.ModifyUser = tempUser.UserName;
                bom.Validate();
                this.ERP_M002_BOMRepository.SetValues(bom, existsdevice);
            }
            foreach (var matSupp in bomMatList)
            {
                var existsmatSupp = bomMaterialRepository.GetByID(matSupp.Id);
                if (existsmatSupp == null)
                {
                    matSupp.CompCode = tempUser.CompCode;
                    matSupp.CreateDt = DateTime.Now;
                    matSupp.CreateUser = tempUser.UserName;
                    matSupp.Validate();
                    this.bomMaterialRepository.Add(matSupp);
                }
                else
                {
                    matSupp.ModifyDt = DateTime.Now;
                    matSupp.ModifyUser = tempUser.UserName;
                    matSupp.Validate();
                    this.bomMaterialRepository.SetValues(matSupp, existsmatSupp);
                }
            }
            this.runtimeService.Commit();
        }
        public void MarkDelMat(ERP_M002_BOM_Material temp)
        {
            var existstb_Sys_Menu = this.bomMaterialRepository.GetByID(temp.Id);
            if (existstb_Sys_Menu != null)
                this.bomMaterialRepository.Delete(existstb_Sys_Menu);
        }
        public IQueryable<ERP_M002_BOM_Material> GetBomMatQuery()
        {
            return bomMaterialRepository.GetMany(i => true);
        }
		public List<ERP_M002_BOM> GetList()
        {
            var q = this.ERP_M002_BOMRepository.GetMany(i => true);
            return q.ToList();
        }

        public ERP_M002_BOM GetById(Guid Id)
        {
            return this.ERP_M002_BOMRepository.GetByID(Id);
        }

        public void Create(ERP_M002_BOM ERP_M002_BOM)
        {
        	ERP_M002_BOM.CreateDt = DateTime.Now;
            tb_Sys_User tempUser = appCacheService.GetItem("user") as tb_Sys_User;
            ERP_M002_BOM.CreateUser = tempUser.UserName;
            ERP_M002_BOM.Validate();
			this.ERP_M002_BOMRepository.Add(ERP_M002_BOM);
            this.runtimeService.Commit();
        }

        public void Delete(Guid Id)
        {
            var existstb_Sys_Menu = this.GetById(Id);
            if (existstb_Sys_Menu != null)
            {
                this.ERP_M002_BOMRepository.Delete(existstb_Sys_Menu);
                var bomMatData = this.bomMaterialRepository.GetMany(a => a.PartNo == existstb_Sys_Menu.PartNo).ToList();
                foreach (var bomMat in bomMatData)
                    this.bomMaterialRepository.Delete(bomMat);
                this.runtimeService.Commit();
            }
        }

        public void Update(ERP_M002_BOM ERP_M002_BOM)
        {
        	ERP_M002_BOM.ModifyDt = DateTime.Now;
            tb_Sys_User tempUser = appCacheService.GetItem("user") as tb_Sys_User;
            ERP_M002_BOM.ModifyUser = tempUser.UserName;
            ERP_M002_BOM.Validate();
            var existstb_Sys_Menu = this.GetById(ERP_M002_BOM.Id);
            this.ERP_M002_BOMRepository.SetValues(ERP_M002_BOM, existstb_Sys_Menu);
            this.runtimeService.Commit();
        }

        public List<ERP_M002_BOM> GetList(PagingModel pagingModel, DateTime? beginDate, DateTime? endDate)
        {
            var q = this.ERP_M002_BOMRepository.GetMany(i => true);
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