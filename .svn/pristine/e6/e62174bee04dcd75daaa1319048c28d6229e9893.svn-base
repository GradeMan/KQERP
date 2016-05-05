using System;
using System.Linq;
using System.Collections.Generic;
using COM.Data;
using ERP.Data;
using ERP.Domain;
using COM.Service;
namespace ERP.Service
{
	public interface ILotTxService
	{
		MES_M003_LotTx GetById(Guid Id);
        List<MES_M003_LotTx> GetList();
		List<MES_M003_LotTx> GetList(PagingModel pagingModel, DateTime? beginDate, DateTime? endDate);
        void Create(MES_M003_LotTx MES_M003_LotTx);
        void Update(MES_M003_LotTx MES_M003_LotTx);
        void Delete(Guid Id);
        List<MES_M003_LotTx_NG> GetLotTxNGListByLotNo(string LotNo);
        void MarkDelLotTxNG(Guid id);
        void Save(MES_M003_LotTx lotTx, List<MES_M003_LotTx_NG> lotTXNGList);
        List<MES_M003_LotTx_NG> GetLotTxNgByClone(string ProcessCode);
        List<MES_M003_LotTx> GetListByJobNo(string JobNo);
	}
    public class LotTxService : ILotTxService
	{
		private ILotTxRepository MES_M003_LotTxRepository;
        private ILotTxNGRepository lotTxNGReposiotry;
        private IMES_M003_LotTx_NG_CloneRepository lotTxNGCloneRepository;
		private IUnitOfWork runtimeService;
		private ICacheServiceBase appCacheService = Unity.Instance.GetService<ICacheServiceBase>();
        public LotTxService(IDatabaseFactory dbfactory)
		{
			this.runtimeService = new UnitOfWork(dbfactory);
            this.MES_M003_LotTxRepository = new LotTxRepository(dbfactory);
            this.lotTxNGReposiotry = new LotTxNGRepository(dbfactory);
            this.lotTxNGCloneRepository = new MES_M003_LotTx_NG_CloneRepository(dbfactory);
		}

		public List<MES_M003_LotTx> GetList()
        {
            var q = this.MES_M003_LotTxRepository.GetMany(i => true);
            return q.ToList();
        }

        public MES_M003_LotTx GetById(Guid Id)
        {
            return this.MES_M003_LotTxRepository.GetByID(Id);
        }

        public void Create(MES_M003_LotTx MES_M003_LotTx)
        {
        	MES_M003_LotTx.CreateDt = DateTime.Now;
            tb_Sys_User tempUser = appCacheService.GetItem("user") as tb_Sys_User;
            MES_M003_LotTx.CreateUser = tempUser.UserName;
            MES_M003_LotTx.CompCode = tempUser.CompCode;
            MES_M003_LotTx.Validate();
			this.MES_M003_LotTxRepository.Add(MES_M003_LotTx);
            this.runtimeService.Commit();
        }

        public void Delete(Guid Id)
        {
            var existsTemp = this.GetById(Id);
            this.MES_M003_LotTxRepository.Delete(existsTemp);
            this.runtimeService.Commit();
        }

        public void Update(MES_M003_LotTx MES_M003_LotTx)
        {
        	MES_M003_LotTx.ModifyDt = DateTime.Now;
            tb_Sys_User tempUser = appCacheService.GetItem("user") as tb_Sys_User;
            MES_M003_LotTx.ModifyUser = tempUser.UserName;
            MES_M003_LotTx.Validate();
            var existstb_Sys_Menu = this.GetById(MES_M003_LotTx.Id);
            this.MES_M003_LotTxRepository.SetValues(MES_M003_LotTx, existstb_Sys_Menu);
            this.runtimeService.Commit();
        }

        public List<MES_M003_LotTx> GetList(PagingModel pagingModel, DateTime? beginDate, DateTime? endDate)
        {
            var q = this.MES_M003_LotTxRepository.GetMany(i => true);
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


        public List<MES_M003_LotTx_NG> GetLotTxNGListByLotNo(string LotNo)
        {
            var q = this.lotTxNGReposiotry.GetMany(i => i.LotNo == LotNo);
            return q.ToList();
        }


        public void MarkDelLotTxNG(Guid id)
        {
            var existsTemp = this.lotTxNGReposiotry.GetByID(id);
            if (existsTemp != null)
                this.lotTxNGReposiotry.Delete(existsTemp);
        }

        public void Save(MES_M003_LotTx lotTx, List<MES_M003_LotTx_NG> lotTXNGList)
        {
            tb_Sys_User tempUser = appCacheService.GetItem("user") as tb_Sys_User;
            var existslotTx = this.GetById(lotTx.Id);
            if (existslotTx == null)
            {
                lotTx.CompCode = tempUser.CompCode;
                lotTx.CreateDt = DateTime.Now;
                lotTx.CreateUser = tempUser.UserName;
                lotTx.Validate();
                this.MES_M003_LotTxRepository.Add(lotTx);
            }
            else
            {
                lotTx.ModifyDt = DateTime.Now;
                lotTx.ModifyUser = tempUser.UserName;
                lotTx.Validate();
                this.MES_M003_LotTxRepository.SetValues(lotTx, existslotTx);
            }
            if (lotTXNGList != null)
            {
                foreach (var lotTxNG in lotTXNGList)
                {
                    var existstLotTxNG = this.lotTxNGReposiotry.GetByID(lotTxNG.Id);
                    if (existstLotTxNG == null)
                    {
                        lotTxNG.CompCode = tempUser.CompCode;
                        lotTxNG.CreateDt = DateTime.Now;
                        lotTxNG.CreateUser = tempUser.UserName;
                        lotTxNG.Validate();
                        this.lotTxNGReposiotry.Add(lotTxNG);
                    }
                    else
                    {
                        lotTxNG.ModifyDt = DateTime.Now;
                        lotTxNG.ModifyUser = tempUser.UserName;
                        lotTxNG.Validate();
                        this.lotTxNGReposiotry.SetValues(lotTxNG, existstLotTxNG);
                    }
                }
            }
            this.runtimeService.Commit();
        }

        /// <summary>
        /// 从克隆表里根据流程编号获取报废模版
        /// </summary>
        /// <param name="processCode"></param>
        /// <returns></returns>
        public List<MES_M003_LotTx_NG> GetLotTxNgByClone(string processCode)
        {
            var q = this.lotTxNGCloneRepository.GetMany(i => i.ProcessCode == processCode && i.State == true).OrderBy(i => i.SeqNo);

             var q2 = q.Select(i=>new MES_M003_LotTx_NG{ ProcessCode = i.ProcessCode, CriteriaCode = i.CriteriaCode,Remarks = i.Remarks });
            return q2.ToList();
        }


        public List<MES_M003_LotTx> GetListByJobNo(string JobNo)
        {
            var q = this.MES_M003_LotTxRepository.GetMany(i => i.JobNo == JobNo).OrderBy(i=>i.LotNo);
            return q.ToList();
        }
    }
}