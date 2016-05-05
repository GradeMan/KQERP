using System;
using System.Linq;
using System.Collections.Generic;
using COM.Data;
using ERP.Data;
using ERP.Domain;
using COM.Service;
namespace ERP.Service
{
	public interface IJobLotProcessService
	{
		MES_M002_Job_Lot_Process GetById(Guid Id);
        List<MES_M002_Job_Lot_Process> GetList();
		List<MES_M002_Job_Lot_Process> GetList(PagingModel pagingModel, DateTime? beginDate, DateTime? endDate);
        void Create(MES_M002_Job_Lot_Process MES_M002_Job_Lot_Process);
        void Update(MES_M002_Job_Lot_Process MES_M002_Job_Lot_Process);
        void Delete(Guid Id);
	}
    public class JobLotProcessService : IJobLotProcessService
	{
		private IMES_M002_Job_Lot_ProcessRepository MES_M002_Job_Lot_ProcessRepository;
		private IUnitOfWork runtimeService;
		private ICacheServiceBase appCacheService = Unity.Instance.GetService<ICacheServiceBase>();
        public JobLotProcessService(IDatabaseFactory dbfactory)
		{
			this.runtimeService = new UnitOfWork(dbfactory);
			this.MES_M002_Job_Lot_ProcessRepository = new MES_M002_Job_Lot_ProcessRepository(dbfactory);
		}

		public List<MES_M002_Job_Lot_Process> GetList()
        {
            var q = this.MES_M002_Job_Lot_ProcessRepository.GetMany(i => true);
            return q.ToList();
        }

        public MES_M002_Job_Lot_Process GetById(Guid Id)
        {
            return this.MES_M002_Job_Lot_ProcessRepository.GetByID(Id);
        }

        public void Create(MES_M002_Job_Lot_Process MES_M002_Job_Lot_Process)
        {
        	MES_M002_Job_Lot_Process.CreateDt = DateTime.Now;
            tb_Sys_User tempUser = appCacheService.GetItem("user") as tb_Sys_User;
            MES_M002_Job_Lot_Process.CreateUser = tempUser.UserName;
            MES_M002_Job_Lot_Process.Validate();
			this.MES_M002_Job_Lot_ProcessRepository.Add(MES_M002_Job_Lot_Process);
            this.runtimeService.Commit();
        }

        public void Delete(Guid Id)
        {
            var existstb_Sys_Menu = this.GetById(Id);
            this.MES_M002_Job_Lot_ProcessRepository.Delete(existstb_Sys_Menu);
            this.runtimeService.Commit();
        }

        public void Update(MES_M002_Job_Lot_Process MES_M002_Job_Lot_Process)
        {
        	MES_M002_Job_Lot_Process.ModifyDt = DateTime.Now;
            tb_Sys_User tempUser = appCacheService.GetItem("user") as tb_Sys_User;
            MES_M002_Job_Lot_Process.ModifyUser = tempUser.UserName;
            MES_M002_Job_Lot_Process.Validate();
            var existstb_Sys_Menu = this.GetById(MES_M002_Job_Lot_Process.Id);
            this.MES_M002_Job_Lot_ProcessRepository.SetValues(MES_M002_Job_Lot_Process, existstb_Sys_Menu);
            this.runtimeService.Commit();
        }

        public List<MES_M002_Job_Lot_Process> GetList(PagingModel pagingModel, DateTime? beginDate, DateTime? endDate)
        {
            var q = this.MES_M002_Job_Lot_ProcessRepository.GetMany(i => true);
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