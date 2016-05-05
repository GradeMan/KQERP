using System;
using System.Linq;
using System.Collections.Generic;
using COM.Data;
using ERP.Data;
using ERP.Domain;
using COM.Service;
namespace ERP.Service
{
	public interface IMES_M202_Task_JobLotService
	{
		MES_M202_Task_JobLot GetById(Guid Id);
        List<MES_M202_Task_JobLot> GetList();
        IQueryable<MES_M202_Task_JobLot> GetQuery();
		List<MES_M202_Task_JobLot> GetList(PagingModel pagingModel, DateTime? beginDate, DateTime? endDate);
        void Create(MES_M202_Task_JobLot MES_M202_Task_JobLot);
        void Update(MES_M202_Task_JobLot MES_M202_Task_JobLot);
        void Delete(Guid Id);
	}
	public class MES_M202_Task_JobLotService :IMES_M202_Task_JobLotService
	{
		private IMES_M202_Task_JobLotRepository MES_M202_Task_JobLotRepository;
		private IUnitOfWork runtimeService;
		private ICacheServiceBase appCacheService = Unity.Instance.GetService<ICacheServiceBase>();
		public MES_M202_Task_JobLotService(IDatabaseFactory dbfactory)
		{
			this.runtimeService = new UnitOfWork(dbfactory);
			this.MES_M202_Task_JobLotRepository = new MES_M202_Task_JobLotRepository(dbfactory);
		}

		public List<MES_M202_Task_JobLot> GetList()
        {
            var q = this.MES_M202_Task_JobLotRepository.GetMany(i => true);
            return q.ToList();
        }
        
		public IQueryable<MES_M202_Task_JobLot> GetQuery()
        {
            var q = this.MES_M202_Task_JobLotRepository.GetMany(i => true);
            return q;
        }
        
        public MES_M202_Task_JobLot GetById(Guid Id)
        {
            return this.MES_M202_Task_JobLotRepository.GetByID(Id);
        }

        public void Create(MES_M202_Task_JobLot MES_M202_Task_JobLot)
        {
            tb_Sys_User tempUser = appCacheService.GetItem("user") as tb_Sys_User;
            MES_M202_Task_JobLot.CompCode = tempUser.CompCode;
            MES_M202_Task_JobLot.Validate();
			this.MES_M202_Task_JobLotRepository.Add(MES_M202_Task_JobLot);
            this.runtimeService.Commit();
        }

        public void Delete(Guid Id)
        {
            var existstb_Sys_Menu = this.GetById(Id);
            this.MES_M202_Task_JobLotRepository.Delete(existstb_Sys_Menu);
            this.runtimeService.Commit();
        }

        public void Update(MES_M202_Task_JobLot MES_M202_Task_JobLot)
        {
            MES_M202_Task_JobLot.Validate();
            var existstb_Sys_Menu = this.GetById(MES_M202_Task_JobLot.Id);
            this.MES_M202_Task_JobLotRepository.SetValues(MES_M202_Task_JobLot, existstb_Sys_Menu);
            this.runtimeService.Commit();
        }

        public List<MES_M202_Task_JobLot> GetList(PagingModel pagingModel, DateTime? beginDate, DateTime? endDate)
        {
            var q = this.MES_M202_Task_JobLotRepository.GetMany(i => true);
            
            q = q.OrderByDescending(i => i.JobLotNo);
            q = q.Paging(pagingModel);
            return q.ToList();
        }
	}
}