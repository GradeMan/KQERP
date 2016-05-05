using System;
using System.Linq;
using System.Collections.Generic;
using COM.Data;
using ERP.Data;
using ERP.Domain;
using COM.Service;
namespace ERP.Service
{
	public interface IJobLotService
	{
		MES_M002_Job_Lot GetById(Guid Id);
        List<MES_M002_Job_Lot> GetList();
		List<MES_M002_Job_Lot> GetList(PagingModel pagingModel, DateTime? beginDate, DateTime? endDate);
        void Create(MES_M002_Job_Lot MES_M002_Job_Lot);
        void Update(MES_M002_Job_Lot MES_M002_Job_Lot);
        void Delete(Guid Id);
	}
    public class JobLotService : IJobLotService
	{
		private IJobLotRepository MES_M002_Job_LotRepository;
		private IUnitOfWork runtimeService;
		private ICacheServiceBase appCacheService = Unity.Instance.GetService<ICacheServiceBase>();
        public JobLotService(IDatabaseFactory dbfactory)
		{
			this.runtimeService = new UnitOfWork(dbfactory);
            this.MES_M002_Job_LotRepository = new JobLotRepository(dbfactory);
		}

		public List<MES_M002_Job_Lot> GetList()
        {
            var q = this.MES_M002_Job_LotRepository.GetMany(i => true);
            return q.ToList();
        }

        public MES_M002_Job_Lot GetById(Guid Id)
        {
            return this.MES_M002_Job_LotRepository.GetByID(Id);
        }

        public void Create(MES_M002_Job_Lot MES_M002_Job_Lot)
        {
        	MES_M002_Job_Lot.CreateDt = DateTime.Now;
            tb_Sys_User tempUser = appCacheService.GetItem("user") as tb_Sys_User;
            MES_M002_Job_Lot.CreateUser = tempUser.UserName;
            MES_M002_Job_Lot.CompCode = tempUser.CompCode;
            MES_M002_Job_Lot.Validate();
			this.MES_M002_Job_LotRepository.Add(MES_M002_Job_Lot);
            this.runtimeService.Commit();
        }

        public void Delete(Guid Id)
        {
            var existsTemp = this.GetById(Id);
            this.MES_M002_Job_LotRepository.Delete(existsTemp);
            this.runtimeService.Commit();
        }

        public void Update(MES_M002_Job_Lot MES_M002_Job_Lot)
        {
        	MES_M002_Job_Lot.ModifyDt = DateTime.Now;
            tb_Sys_User tempUser = appCacheService.GetItem("user") as tb_Sys_User;
            MES_M002_Job_Lot.ModifyUser = tempUser.UserName;
            MES_M002_Job_Lot.Validate();
            var existstb_Sys_Menu = this.GetById(MES_M002_Job_Lot.Id);
            this.MES_M002_Job_LotRepository.SetValues(MES_M002_Job_Lot, existstb_Sys_Menu);
            this.runtimeService.Commit();
        }

        public List<MES_M002_Job_Lot> GetList(PagingModel pagingModel, DateTime? beginDate, DateTime? endDate)
        {
            var q = this.MES_M002_Job_LotRepository.GetMany(i => true);
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