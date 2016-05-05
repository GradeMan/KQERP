using System;
using System.Linq;
using System.Collections.Generic;
using COM.Data;
using ERP.Data;
using ERP.Domain;
using COM.Service;
namespace ERP.Service
{
	public interface ILotTxNGService
	{
		MES_M003_LotTx_NG GetById(Guid Id);
        List<MES_M003_LotTx_NG> GetList();
		List<MES_M003_LotTx_NG> GetList(PagingModel pagingModel, DateTime? beginDate, DateTime? endDate);
        void Create(MES_M003_LotTx_NG MES_M003_LotTx_NG);
        void Update(MES_M003_LotTx_NG MES_M003_LotTx_NG);
        void Delete(Guid Id);
	}
    public class LotTxNGService : ILotTxNGService
	{
		private ILotTxNGRepository MES_M003_LotTx_NGRepository;
		private IUnitOfWork runtimeService;
		private ICacheServiceBase appCacheService = Unity.Instance.GetService<ICacheServiceBase>();
        public LotTxNGService(IDatabaseFactory dbfactory)
		{
			this.runtimeService = new UnitOfWork(dbfactory);
            this.MES_M003_LotTx_NGRepository = new LotTxNGRepository(dbfactory);
		}

		public List<MES_M003_LotTx_NG> GetList()
        {
            var q = this.MES_M003_LotTx_NGRepository.GetMany(i => true);
            return q.ToList();
        }

        public MES_M003_LotTx_NG GetById(Guid Id)
        {
            return this.MES_M003_LotTx_NGRepository.GetByID(Id);
        }

        public void Create(MES_M003_LotTx_NG MES_M003_LotTx_NG)
        {
        	MES_M003_LotTx_NG.CreateDt = DateTime.Now;
            tb_Sys_User tempUser = appCacheService.GetItem("user") as tb_Sys_User;
            MES_M003_LotTx_NG.CreateUser = tempUser.UserName;
            MES_M003_LotTx_NG.CompCode = tempUser.CompCode;
            MES_M003_LotTx_NG.Validate();
			this.MES_M003_LotTx_NGRepository.Add(MES_M003_LotTx_NG);
            this.runtimeService.Commit();
        }

        public void Delete(Guid Id)
        {
            var existsTemp = this.GetById(Id);
            this.MES_M003_LotTx_NGRepository.Delete(existsTemp);
            this.runtimeService.Commit();
        }

        public void Update(MES_M003_LotTx_NG MES_M003_LotTx_NG)
        {
        	MES_M003_LotTx_NG.ModifyDt = DateTime.Now;
            tb_Sys_User tempUser = appCacheService.GetItem("user") as tb_Sys_User;
            MES_M003_LotTx_NG.ModifyUser = tempUser.UserName;
            MES_M003_LotTx_NG.Validate();
            var existstb_Sys_Menu = this.GetById(MES_M003_LotTx_NG.Id);
            this.MES_M003_LotTx_NGRepository.SetValues(MES_M003_LotTx_NG, existstb_Sys_Menu);
            this.runtimeService.Commit();
        }

        public List<MES_M003_LotTx_NG> GetList(PagingModel pagingModel, DateTime? beginDate, DateTime? endDate)
        {
            var q = this.MES_M003_LotTx_NGRepository.GetMany(i => true);
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