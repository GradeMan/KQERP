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
	public interface IERP_M001_MaterialService
	{
		ERP_M001_Material GetById(Guid Id);
        List<ERP_M001_Material> GetList();
		List<ERP_M001_Material> GetList(PagingModel pagingModel, DateTime? beginDate, DateTime? endDate);
        void Create(ERP_M001_Material ERP_M001_Material);
        void Update(ERP_M001_Material ERP_M001_Material);
        void Delete(Guid Id);
        void MarkDeleteMatSupp(ERP_M001_Material_Supp matSupp);
        void Save(ERP_M001_Material material, List<ERP_M001_Material_Supp> matSuppList);
        IQueryable<ERP_M001_Material_Supp> GetMatSupp();
        IQueryable<ERP_M001_Material> GetMaterial();
        List<InputItem> GetInputData();
	}
	public class ERP_M001_MaterialService :IERP_M001_MaterialService
	{
		private IERP_M001_MaterialRepository ERP_M001_MaterialRepository;
        private IERP_M001_Material_SuppRepository matSuppRepository;
		private IUnitOfWork runtimeService;
		private ICacheServiceBase appCacheService = Unity.Instance.GetService<ICacheServiceBase>();
		public ERP_M001_MaterialService(IDatabaseFactory dbfactory)
		{
			this.runtimeService = new UnitOfWork(dbfactory);
			this.ERP_M001_MaterialRepository = new ERP_M001_MaterialRepository(dbfactory);
            matSuppRepository = new ERP_M001_Material_SuppRepository(dbfactory);
		}
        public List<InputItem> GetInputData()
        {
            var q = this.ERP_M001_MaterialRepository.GetMany(i => i.MatCode != null).Select(a => new { a.MatCode, a.MatName, a.MatSpec }).ToList();
            var q2 = q.Select(i => new InputItem { DisPlayName = i.MatName, Value = i.MatCode, InputCode1 = i.MatCode, InputCode2 = i.MatSpec });
            return q2.OrderBy(a => a.DisPlayName).ToList();
        }
        public IQueryable<ERP_M001_Material_Supp> GetMatSupp()
        {
            return matSuppRepository.GetMany(i => true);
        }
        public IQueryable<ERP_M001_Material> GetMaterial()
        {
            return ERP_M001_MaterialRepository.GetMany(i => true);
        }
        public void MarkDeleteMatSupp(ERP_M001_Material_Supp matSupp)
        {
            var existstb_Sys_Menu = matSuppRepository.GetByID(matSupp.Id);
            if (existstb_Sys_Menu != null)
                this.matSuppRepository.Delete(existstb_Sys_Menu);
           // this.runtimeService.Commit();
        }
        public void Save(ERP_M001_Material material, List<ERP_M001_Material_Supp> matSuppList)
        {
            tb_Sys_User tempUser = appCacheService.GetItem("user") as tb_Sys_User;

            var existsdevice = this.GetById(material.Id);
            if (existsdevice == null)
            {
                material.CompCode = tempUser.CompCode;
                material.CreateDt = DateTime.Now;
                material.CreateUser = tempUser.UserName;
                material.Validate();
                this.ERP_M001_MaterialRepository.Add(material);
            }
            else
            {
                material.ModifyDt = DateTime.Now;
                material.ModifyUser = tempUser.UserName;
                material.Validate();
                this.ERP_M001_MaterialRepository.SetValues(material, existsdevice);
            }
            foreach (var matSupp in matSuppList)
            {
                var existsmatSupp = matSuppRepository.GetByID(matSupp.Id);
                if (existsmatSupp == null)
                {
                    matSupp.CompCode = tempUser.CompCode;
                    matSupp.CreateDt = DateTime.Now;
                    matSupp.CreateUser = tempUser.UserName;
                    matSupp.Validate();
                    this.matSuppRepository.Add(matSupp);
                }
                else
                {
                    matSupp.ModifyDt = DateTime.Now;
                    matSupp.ModifyUser = tempUser.UserName;
                    matSupp.Validate();
                    this.matSuppRepository.SetValues(matSupp, existsmatSupp);
                }
            }
            this.runtimeService.Commit();
        }
		public List<ERP_M001_Material> GetList()
        {
            var q = this.ERP_M001_MaterialRepository.GetMany(i => true);
            return q.ToList();
        }

        public ERP_M001_Material GetById(Guid Id)
        {
            return this.ERP_M001_MaterialRepository.GetByID(Id);
        }

        public void Create(ERP_M001_Material ERP_M001_Material)
        {
        	ERP_M001_Material.CreateDt = DateTime.Now;
            tb_Sys_User tempUser = appCacheService.GetItem("user") as tb_Sys_User;
            ERP_M001_Material.CreateUser = tempUser.UserName;
            ERP_M001_Material.Validate();
			this.ERP_M001_MaterialRepository.Add(ERP_M001_Material);
            this.runtimeService.Commit();
        }

        public void Delete(Guid Id)
        {
            var existstb_Sys_Menu = this.GetById(Id);
            this.ERP_M001_MaterialRepository.Delete(existstb_Sys_Menu);
            var matSupps = matSuppRepository.GetMany(a => a.MatCode == existstb_Sys_Menu.MatCode).ToList();
            foreach (var matSupp in matSupps)
                matSuppRepository.Delete(matSupp);
            this.runtimeService.Commit();
        }

        public void Update(ERP_M001_Material ERP_M001_Material)
        {
        	ERP_M001_Material.ModifyDt = DateTime.Now;
            tb_Sys_User tempUser = appCacheService.GetItem("user") as tb_Sys_User;
            ERP_M001_Material.ModifyUser = tempUser.UserName;
            ERP_M001_Material.Validate();
            var existstb_Sys_Menu = this.GetById(ERP_M001_Material.Id);
            this.ERP_M001_MaterialRepository.SetValues(ERP_M001_Material, existstb_Sys_Menu);
            this.runtimeService.Commit();
        }

        public List<ERP_M001_Material> GetList(PagingModel pagingModel, DateTime? beginDate, DateTime? endDate)
        {
            var q = this.ERP_M001_MaterialRepository.GetMany(i => true);
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