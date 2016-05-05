using System;
using System.Linq;
using System.Collections.Generic;
using COM.Data;
using ERP.Data;
using ERP.Domain;
using COM.Service;
namespace ERP.Service
{
	public interface IERP_M001_Material_SuppService
	{
		ERP_M001_Material_Supp GetById(Guid Id);
        List<ERP_M001_Material_Supp> GetList();
		List<ERP_M001_Material_Supp> GetList(PagingModel pagingModel, DateTime? beginDate, DateTime? endDate);
        void Create(ERP_M001_Material_Supp ERP_M001_Material_Supp);
        void Update(ERP_M001_Material_Supp ERP_M001_Material_Supp);
        void Delete(Guid Id);
        List<ERP_M001_Material_Supp> GetListByMatCode(string matCode);
	}
	public class ERP_M001_Material_SuppService :IERP_M001_Material_SuppService
	{
		private IERP_M001_Material_SuppRepository ERP_M001_Material_SuppRepository;
		private IUnitOfWork runtimeService;
		private ICacheServiceBase appCacheService = Unity.Instance.GetService<ICacheServiceBase>();
		public ERP_M001_Material_SuppService(IDatabaseFactory dbfactory)
		{
			this.runtimeService = new UnitOfWork(dbfactory);
			this.ERP_M001_Material_SuppRepository = new ERP_M001_Material_SuppRepository(dbfactory);
		}
        public List<ERP_M001_Material_Supp> GetListByMatCode(string matCode)
        {
            var q = this.ERP_M001_Material_SuppRepository.GetMany(i => i.MatCode == matCode);
            return q.ToList();
        }
		public List<ERP_M001_Material_Supp> GetList()
        {
            var q = this.ERP_M001_Material_SuppRepository.GetMany(i => true);
            return q.ToList();
        }

        public ERP_M001_Material_Supp GetById(Guid Id)
        {
            return this.ERP_M001_Material_SuppRepository.GetByID(Id);
        }

        public void Create(ERP_M001_Material_Supp ERP_M001_Material_Supp)
        {
        	ERP_M001_Material_Supp.CreateDt = DateTime.Now;
            tb_Sys_User tempUser = appCacheService.GetItem("user") as tb_Sys_User;
            ERP_M001_Material_Supp.CreateUser = tempUser.UserName;
            ERP_M001_Material_Supp.Validate();
			this.ERP_M001_Material_SuppRepository.Add(ERP_M001_Material_Supp);
            this.runtimeService.Commit();
        }

        public void Delete(Guid Id)
        {
            var existstb_Sys_Menu = this.GetById(Id);
            this.ERP_M001_Material_SuppRepository.Delete(existstb_Sys_Menu);
            this.runtimeService.Commit();
        }

        public void Update(ERP_M001_Material_Supp ERP_M001_Material_Supp)
        {
        	ERP_M001_Material_Supp.ModifyDt = DateTime.Now;
            tb_Sys_User tempUser = appCacheService.GetItem("user") as tb_Sys_User;
            ERP_M001_Material_Supp.ModifyUser = tempUser.UserName;
            ERP_M001_Material_Supp.Validate();
            var existstb_Sys_Menu = this.GetById(ERP_M001_Material_Supp.Id);
            this.ERP_M001_Material_SuppRepository.SetValues(ERP_M001_Material_Supp, existstb_Sys_Menu);
            this.runtimeService.Commit();
        }

        public List<ERP_M001_Material_Supp> GetList(PagingModel pagingModel, DateTime? beginDate, DateTime? endDate)
        {
            var q = this.ERP_M001_Material_SuppRepository.GetMany(i => true);
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