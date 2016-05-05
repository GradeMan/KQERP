using System;
using System.Linq;
using System.Collections.Generic;
using COM.Data;
using ERP.Data;
using ERP.Domain;
using COM.Service;
namespace ERP.Service
{
	public interface ILotTx_NG_CloneService
	{
		MES_M003_LotTx_NG_Clone GetById(Guid Id);
        List<MES_M003_LotTx_NG_Clone> GetList();
		List<MES_M003_LotTx_NG_Clone> GetList(PagingModel pagingModel, DateTime? beginDate, DateTime? endDate);
        void Create(MES_M003_LotTx_NG_Clone MES_M003_LotTx_NG_Clone);
        void Update(MES_M003_LotTx_NG_Clone MES_M003_LotTx_NG_Clone);
        void Delete(Guid Id);
	}
    public class LotTx_NG_CloneService : ILotTx_NG_CloneService
	{
		private IMES_M003_LotTx_NG_CloneRepository MES_M003_LotTx_NG_CloneRepository;
		private IUnitOfWork runtimeService;
		private ICacheServiceBase appCacheService = Unity.Instance.GetService<ICacheServiceBase>();
        public LotTx_NG_CloneService(IDatabaseFactory dbfactory)
		{
			this.runtimeService = new UnitOfWork(dbfactory);
			this.MES_M003_LotTx_NG_CloneRepository = new MES_M003_LotTx_NG_CloneRepository(dbfactory);
		}

		public List<MES_M003_LotTx_NG_Clone> GetList()
        {
            var q = this.MES_M003_LotTx_NG_CloneRepository.GetMany(i => true);
            return q.ToList();
        }

        public MES_M003_LotTx_NG_Clone GetById(Guid Id)
        {
            return this.MES_M003_LotTx_NG_CloneRepository.GetByID(Id);
        }

        public void Create(MES_M003_LotTx_NG_Clone MES_M003_LotTx_NG_Clone)
        {
        	MES_M003_LotTx_NG_Clone.CreateDt = DateTime.Now;
            tb_Sys_User tempUser = appCacheService.GetItem("user") as tb_Sys_User;
            MES_M003_LotTx_NG_Clone.CreateUser = tempUser.UserName;
            MES_M003_LotTx_NG_Clone.Validate();
			this.MES_M003_LotTx_NG_CloneRepository.Add(MES_M003_LotTx_NG_Clone);
            this.runtimeService.Commit();
        }

        public void Delete(Guid Id)
        {
            var existstb_Sys_Menu = this.GetById(Id);
            this.MES_M003_LotTx_NG_CloneRepository.Delete(existstb_Sys_Menu);
            this.runtimeService.Commit();
        }

        public void Update(MES_M003_LotTx_NG_Clone MES_M003_LotTx_NG_Clone)
        {
        	MES_M003_LotTx_NG_Clone.ModifyDt = DateTime.Now;
            tb_Sys_User tempUser = appCacheService.GetItem("user") as tb_Sys_User;
            MES_M003_LotTx_NG_Clone.ModifyUser = tempUser.UserName;
            MES_M003_LotTx_NG_Clone.Validate();
            var existstb_Sys_Menu = this.GetById(MES_M003_LotTx_NG_Clone.Id);
            this.MES_M003_LotTx_NG_CloneRepository.SetValues(MES_M003_LotTx_NG_Clone, existstb_Sys_Menu);
            this.runtimeService.Commit();
        }

        public List<MES_M003_LotTx_NG_Clone> GetList(PagingModel pagingModel, DateTime? beginDate, DateTime? endDate)
        {
            var q = this.MES_M003_LotTx_NG_CloneRepository.GetMany(i => true);
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