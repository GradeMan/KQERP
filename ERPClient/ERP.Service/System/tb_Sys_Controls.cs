using System;
using System.Linq;
using System.Collections.Generic;
using COM.Data;
using ERP.Data;
using ERP.Domain;
using COM.Service;
namespace ERP.Service
{
	public interface Itb_Sys_ControlsService
	{
		tb_Sys_Controls GetById(Guid Id);
        List<tb_Sys_Controls> GetList();
		List<tb_Sys_Controls> GetList(PagingModel pagingModel, DateTime? beginDate, DateTime? endDate);
        void Create(tb_Sys_Controls tb_Sys_Controls);
        void Update(tb_Sys_Controls tb_Sys_Controls);
        void Delete(Guid Id);
        List<tb_Sys_Controls> GetlistByRolesId(Guid roleId);
	}
	public class tb_Sys_ControlsService :Itb_Sys_ControlsService
	{
		private Itb_Sys_ControlsRepository tb_Sys_ControlsRepository;
        private Itb_Sys_RolesControlRepository rolesControlRepository;
		private IUnitOfWork runtimeService;
		private ICacheServiceBase appCacheService = Unity.Instance.GetService<ICacheServiceBase>();
		public tb_Sys_ControlsService(IDatabaseFactory dbfactory)
		{
			this.runtimeService = new UnitOfWork(dbfactory);
			this.tb_Sys_ControlsRepository = new tb_Sys_ControlsRepository(dbfactory);
            this.rolesControlRepository = new tb_Sys_RolesControlRepository(dbfactory);
		}

		public List<tb_Sys_Controls> GetList()
        {
            var q = this.tb_Sys_ControlsRepository.GetMany(i => true);
            return q.ToList();
        }

        public tb_Sys_Controls GetById(Guid Id)
        {
            return this.tb_Sys_ControlsRepository.GetByID(Id);
        }

        public void Create(tb_Sys_Controls tb_Sys_Controls)
        {
        	tb_Sys_Controls.CreateDt = DateTime.Now;
            tb_Sys_User tempUser = appCacheService.GetItem("user") as tb_Sys_User;
            tb_Sys_Controls.CreateUser = tempUser.UserName;
            tb_Sys_Controls.CompCode = tempUser.CompCode;
            tb_Sys_Controls.Validate();
			this.tb_Sys_ControlsRepository.Add(tb_Sys_Controls);
            this.runtimeService.Commit();
        }

        public void Delete(Guid Id)
        {
            var existstb_Sys_Menu = this.GetById(Id);
            this.tb_Sys_ControlsRepository.Delete(existstb_Sys_Menu);
            this.runtimeService.Commit();
        }

        public void Update(tb_Sys_Controls tb_Sys_Controls)
        {
        	tb_Sys_Controls.ModifyDt = DateTime.Now;
            tb_Sys_User tempUser = appCacheService.GetItem("user") as tb_Sys_User;
            tb_Sys_Controls.ModifyUser = tempUser.UserName;
            tb_Sys_Controls.Validate();
            var existstb_Sys_Menu = this.GetById(tb_Sys_Controls.Id);
            this.tb_Sys_ControlsRepository.SetValues(tb_Sys_Controls, existstb_Sys_Menu);
            this.runtimeService.Commit();
        }

        public List<tb_Sys_Controls> GetList(PagingModel pagingModel, DateTime? beginDate, DateTime? endDate)
        {
            var q = this.tb_Sys_ControlsRepository.GetMany(i => true);
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


        public List<tb_Sys_Controls> GetlistByRolesId(Guid roleId)
        {
            var controlIdList = this.rolesControlRepository.GetMany(i => i.Roles_Id == roleId).Select(i=>i.ControlId).ToList();
            var q = this.tb_Sys_ControlsRepository.GetMany(i => controlIdList.Contains(i.Id));
            return q.ToList();
        }
    }
}