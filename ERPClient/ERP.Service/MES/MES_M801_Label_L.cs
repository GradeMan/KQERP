using System;
using System.Linq;
using System.Collections.Generic;
using COM.Data;
using ERP.Data;
using ERP.Domain;
using COM.Service;
namespace ERP.Service
{
	public interface IMES_M801_Label_LService
	{
		MES_M801_Label_L GetById(Guid Id);
        List<MES_M801_Label_L> GetList();
		List<MES_M801_Label_L> GetList(PagingModel pagingModel, DateTime? beginDate, DateTime? endDate);
        void Create(MES_M801_Label_L MES_M801_Label_L);
        void Update(MES_M801_Label_L MES_M801_Label_L);
        void Delete(Guid Id);
        void Save(List<MES_M801_Label_L> LData, List<MES_M801_Label_M> MData, List<MES_M801_Label_S> SData);
	}
	public class MES_M801_Label_LService :IMES_M801_Label_LService
	{
		private IMES_M801_Label_LRepository MES_M801_Label_LRepository;
		private IUnitOfWork runtimeService;
		private ICacheServiceBase appCacheService = Unity.Instance.GetService<ICacheServiceBase>();
        private IMES_M801_Label_MRepository MES_M801_Label_MRepository;
        private IMES_M801_Label_SRepository MES_M801_Label_SRepository;
        private IMES_M801_Label_L_PrintDataRepository MES_M801_Label_L_PrintDataRepository;
        private IMES_M801_Label_M_PrintDataRepository MES_M801_Label_M_PrintDataRepository;
        private IMES_M801_Label_S_PrintDataRepository MES_M801_Label_S_PrintDataRepository;
		public MES_M801_Label_LService(IDatabaseFactory dbfactory)
		{
			this.runtimeService = new UnitOfWork(dbfactory);
			this.MES_M801_Label_LRepository = new MES_M801_Label_LRepository(dbfactory);
            this.MES_M801_Label_MRepository = new MES_M801_Label_MRepository(dbfactory);
            this.MES_M801_Label_SRepository = new MES_M801_Label_SRepository(dbfactory);
            this.MES_M801_Label_L_PrintDataRepository = new MES_M801_Label_L_PrintDataRepository(dbfactory);
            this.MES_M801_Label_M_PrintDataRepository = new MES_M801_Label_M_PrintDataRepository(dbfactory);
            this.MES_M801_Label_S_PrintDataRepository = new MES_M801_Label_S_PrintDataRepository(dbfactory);
		}
        /// <summary>
        /// 标签资料保存
        /// </summary>
        /// <param name="LData"></param>
        /// <param name="MData"></param>
        /// <param name="SData"></param>
        public void Save(List<MES_M801_Label_L> LData, List<MES_M801_Label_M> MData, List<MES_M801_Label_S> SData)
        {
            //保存前先删除临时表记录
            this.MES_M801_Label_L_PrintDataRepository.GetDbContext().Database.ExecuteSqlCommand(" delete MES_M801_Label_L_PrintData");
            this.MES_M801_Label_L_PrintDataRepository.GetDbContext().Database.ExecuteSqlCommand(" delete MES_M801_Label_M_PrintData");
            this.MES_M801_Label_L_PrintDataRepository.GetDbContext().Database.ExecuteSqlCommand(" delete MES_M801_Label_S_PrintData");
            string labelType = "";
            //LData = LData.OrderBy(a => a.BoxNo).ToList();
            // MData = MData.OrderBy(a => a.MLotNo).ToList();
            //SData = SData.OrderBy(a => a.PackSeqNo).ToList();
            foreach (var L in LData)
            {
                labelType = L.LabelType;
                //this.MES_M801_Label_LRepository.Add(L);
                //如果已经打印保存过则更新
                var exist = this.MES_M801_Label_LRepository.GetByID(L.Id);
                if (exist == null)
                    this.MES_M801_Label_LRepository.Add(L);
                else
                {
                    L.Id = exist.Id;
                    this.MES_M801_Label_LRepository.SetValues(L, exist);
                }
                //保存临时记录表用于标签打印
                MES_M801_Label_L_PrintData lprint = new MES_M801_Label_L_PrintData();
                lprint.CompCode = L.CompCode;
                lprint.LotNo = L.LotNo;
                lprint.MLotNo = L.MLotNo;
                lprint.BoxNo = L.BoxNo;
                lprint.TotBox = L.TotBox;
                lprint.TotPack = L.TotPack;
                lprint.PartNo = L.PartNo;
                lprint.PartName = L.PartName;
                lprint.PartType = L.PartType;
                lprint.PartSpec = L.PartSpec;
                lprint.CustCode = L.CustCode;
                lprint.CustPartNo = L.CustPartNo;
                lprint.CustPartName = L.CustPartName;
                lprint.CustPartType = L.CustPartType;
                lprint.CustPartSpec = L.CustPartSpec;
                lprint.CustDrawingNo = L.CustDrawingNo;
                lprint.CustPONo = L.CustPONo;
                lprint.CustLotNo = L.CustLotNo;
                lprint.MatCode = L.MatCode;
                lprint.MatType = L.MatType;
                lprint.MatSuppCode = L.MatSuppCode;
                lprint.MatLotNo = L.MatLotNo;
                lprint.LabelType = L.LabelType;
                lprint.ProdDt = L.ProdDt;
                lprint.ExpiredDt = L.ExpiredDt;
                lprint.ExpiredPeriod = L.ExpiredPeriod;
                lprint.Qty = L.Qty;
                lprint.Unit = L.Unit;
                lprint.Code2D = L.Code2D;
                lprint.LBPartNo = L.LBPartNo;
                lprint.LBPartName = L.LBPartName;
                lprint.LBSpec1 = L.LBSpec1;
                lprint.LBSpec2 = L.LBSpec2;
                lprint.JointNumber = L.JointNumber;
                this.MES_M801_Label_L_PrintDataRepository.Add(lprint);

            }
            foreach (var M in MData)
            {
                //this.MES_M801_Label_MRepository.Add(M);
                //var exist = this.MES_M801_Label_MRepository.GetMany(i => i.LotNo == M.LotNo).FirstOrDefault();
                var exist = this.MES_M801_Label_MRepository.GetByID(M.Id);
                if (exist == null)
                    this.MES_M801_Label_MRepository.Add(M);
                else
                {
                    M.Id = exist.Id;
                    this.MES_M801_Label_MRepository.SetValues(M, exist);
                }
                
                MES_M801_Label_M_PrintData lprint = new MES_M801_Label_M_PrintData();
                lprint.CompCode = M.CompCode;
                lprint.LotNo = M.LotNo;
                lprint.MLotNo = M.MLotNo;
                lprint.BoxNo = M.BoxNo;
                lprint.TotBox = M.TotBox;
                lprint.TotPack = M.TotPack;
                lprint.PartNo = M.PartNo;
                lprint.PartName = M.PartName;
                lprint.PartType = M.PartType;
                lprint.PartSpec = M.PartSpec;
                lprint.CustCode = M.CustCode;
                lprint.CustPartNo = M.CustPartNo;
                lprint.CustPartName = M.CustPartName;
                lprint.CustPartType = M.CustPartType;
                lprint.CustPartSpec = M.CustPartSpec;
                lprint.CustDrawingNo = M.CustDrawingNo;
                lprint.CustPONo = M.CustPONo;
                lprint.CustLotNo = M.CustLotNo;
                lprint.MatCode = M.MatCode;
                lprint.MatType = M.MatType;
                lprint.MatSuppCode = M.MatSuppCode;
                lprint.MatLotNo = M.MatLotNo;
                lprint.LabelType = M.LabelType;
                lprint.ProdDt = M.ProdDt;
                lprint.ExpiredDt = M.ExpiredDt;
                lprint.ExpiredPeriod = M.ExpiredPeriod;
                lprint.Qty = M.Qty;
                lprint.Unit = M.Unit;
                lprint.Code2D = M.Code2D;
                lprint.LBPartNo = M.LBPartNo;
                lprint.LBPartName = M.LBPartName;
                lprint.LBSpec1 = M.LBSpec1;
                lprint.LBSpec2 = M.LBSpec2;
                lprint.JointNumber = M.JointNumber;
                lprint.LMlotNo = M.LMlotNo;
                lprint.LBoxNo = M.LBoxNo;
                this.MES_M801_Label_M_PrintDataRepository.Add(lprint);
            }
            foreach (var S in SData)
            {
                //this.MES_M801_Label_SRepository.Add(S);
                //var exist = this.MES_M801_Label_SRepository.GetMany(i => i.LotNo == S.LotNo).SingleOrDefault();
                var exist = this.MES_M801_Label_SRepository.GetByID(S.Id);
                if (exist == null)
                    this.MES_M801_Label_SRepository.Add(S);
                else
                {
                    S.Id = exist.Id;
                    this.MES_M801_Label_SRepository.SetValues(S, exist);
                }
                
                MES_M801_Label_S_PrintData lprint = new MES_M801_Label_S_PrintData();
                lprint.CompCode = S.CompCode;
                lprint.LotNo = S.LotNo;
                lprint.MLotNo = S.MLotNo;
                lprint.PartNo = S.PartNo;
                lprint.PackSeqNo = S.PackSeqNo;
                lprint.PartName = S.PartName;
                lprint.PartType = S.PartType;
                lprint.PartSpec = S.PartSpec;
                lprint.CustCode = S.CustCode;
                lprint.CustPartNo = S.CustPartNo;
                lprint.CustPartName = S.CustPartName;
                lprint.CustPartType = S.CustPartType;
                lprint.CustPartSpec = S.CustPartSpec;
                lprint.CustDrawingNo = S.CustDrawingNo;
                lprint.CustPONo = S.CustPONo;
                lprint.CustLotNo = S.CustLotNo;
                lprint.MatCode = S.MatCode;
                lprint.MatType = S.MatType;
                lprint.ProdDt = S.ProdDt;
                lprint.ExpiredDt = S.ExpiredDt;
                lprint.Qty = S.Qty;
                lprint.Unit = S.Unit;
                lprint.Code2D = S.Code2D;
                lprint.LBPartNo = S.LBPartNo;
                lprint.LBPartName = S.LBPartName;
                lprint.LBSpec1 = S.LBSpec1;
                lprint.LBSpec2 = S.LBSpec2;
                lprint.JointNumber = S.JointNumber;
                lprint.LMlotNo = S.LMlotNo;
                lprint.BoxNo = S.BoxNo;
                lprint.PackNo = S.PackNo;
                this.MES_M801_Label_S_PrintDataRepository.Add(lprint);
            }
            this.runtimeService.Commit(); 
        }
		public List<MES_M801_Label_L> GetList()
        {
            var q = this.MES_M801_Label_LRepository.GetMany(i => true);
            return q.ToList();
        }

        public MES_M801_Label_L GetById(Guid Id)
        {
            return this.MES_M801_Label_LRepository.GetByID(Id);
        }

        public void Create(MES_M801_Label_L MES_M801_Label_L)
        {
        	MES_M801_Label_L.CreateDt = DateTime.Now;
            tb_Sys_User tempUser = appCacheService.GetItem("user") as tb_Sys_User;
            MES_M801_Label_L.CreateUser = tempUser.UserName;
            MES_M801_Label_L.Validate();
			this.MES_M801_Label_LRepository.Add(MES_M801_Label_L);
            this.runtimeService.Commit();
        }

        public void Delete(Guid Id)
        {
            var existstb_Sys_Menu = this.GetById(Id);
            this.MES_M801_Label_LRepository.Delete(existstb_Sys_Menu);
            this.runtimeService.Commit();
        }

        public void Update(MES_M801_Label_L MES_M801_Label_L)
        {
        	MES_M801_Label_L.ModifyDt = DateTime.Now;
            tb_Sys_User tempUser = appCacheService.GetItem("user") as tb_Sys_User;
            MES_M801_Label_L.ModifyUser = tempUser.UserName;
            MES_M801_Label_L.Validate();
            var existstb_Sys_Menu = this.GetById(MES_M801_Label_L.Id);
            this.MES_M801_Label_LRepository.SetValues(MES_M801_Label_L, existstb_Sys_Menu);
            this.runtimeService.Commit();
        }

        public List<MES_M801_Label_L> GetList(PagingModel pagingModel, DateTime? beginDate, DateTime? endDate)
        {
            var q = this.MES_M801_Label_LRepository.GetMany(i => true);
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