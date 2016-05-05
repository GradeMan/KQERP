using System;
using System.Linq;
using System.Collections.Generic;
using COM.Data;
using ERP.Data;
using ERP.Domain;
using COM.Service;
namespace ERP.Service
{
	public interface IERP_C006_ProcessFlow_ProcessService
	{
		ERP_C006_ProcessFlow_Process GetById(Guid Id);
        List<ERP_C006_ProcessFlow_Process> GetList();
		List<ERP_C006_ProcessFlow_Process> GetList(PagingModel pagingModel, DateTime? beginDate, DateTime? endDate);
        void Create(ERP_C006_ProcessFlow_Process ERP_C006_ProcessFlow_Process);
        void Update(ERP_C006_ProcessFlow_Process ERP_C006_ProcessFlow_Process);
        void Delete(Guid Id);
	}
	public class ERP_C006_ProcessFlow_ProcessService :IERP_C006_ProcessFlow_ProcessService
	{
		private IERP_C006_ProcessFlow_ProcessRepository ERP_C006_ProcessFlow_ProcessRepository;
		private IUnitOfWork runtimeService;
		private ICacheServiceBase appCacheService = Unity.Instance.GetService<ICacheServiceBase>();
		public ERP_C006_ProcessFlow_ProcessService(IDatabaseFactory dbfactory)
		{
			this.runtimeService = new UnitOfWork(dbfactory);
			this.ERP_C006_ProcessFlow_ProcessRepository = new ERP_C006_ProcessFlow_ProcessRepository(dbfactory);
		}

		public List<ERP_C006_ProcessFlow_Process> GetList()
        {
            var q = this.ERP_C006_ProcessFlow_ProcessRepository.GetMany(i => true);
            return q.ToList();
        }

        public ERP_C006_ProcessFlow_Process GetById(Guid Id)
        {
            return this.ERP_C006_ProcessFlow_ProcessRepository.GetByID(Id);
        }

        public void Create(ERP_C006_ProcessFlow_Process ERP_C006_ProcessFlow_Process)
        {
        	ERP_C006_ProcessFlow_Process.CreateDt = DateTime.Now;
            tb_Sys_User tempUser = appCacheService.GetItem("user") as tb_Sys_User;
            ERP_C006_ProcessFlow_Process.CreateUser = tempUser.UserName;
            ERP_C006_ProcessFlow_Process.Validate();
			this.ERP_C006_ProcessFlow_ProcessRepository.Add(ERP_C006_ProcessFlow_Process);
            this.runtimeService.Commit();
        }

        public void Delete(Guid Id)
        {
            var existstb_Sys_Menu = this.GetById(Id);
            this.ERP_C006_ProcessFlow_ProcessRepository.Delete(existstb_Sys_Menu);
            this.runtimeService.Commit();
        }

        public void Update(ERP_C006_ProcessFlow_Process ERP_C006_ProcessFlow_Process)
        {
        	ERP_C006_ProcessFlow_Process.ModifyDt = DateTime.Now;
            tb_Sys_User tempUser = appCacheService.GetItem("user") as tb_Sys_User;
            ERP_C006_ProcessFlow_Process.ModifyUser = tempUser.UserName;
            ERP_C006_ProcessFlow_Process.Validate();
            var existstb_Sys_Menu = this.GetById(ERP_C006_ProcessFlow_Process.Id);
            this.ERP_C006_ProcessFlow_ProcessRepository.SetValues(ERP_C006_ProcessFlow_Process, existstb_Sys_Menu);
            this.runtimeService.Commit();
        }

        public List<ERP_C006_ProcessFlow_Process> GetList(PagingModel pagingModel, DateTime? beginDate, DateTime? endDate)
        {
            var q = this.ERP_C006_ProcessFlow_ProcessRepository.GetMany(i => true);
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