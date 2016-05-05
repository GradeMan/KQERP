using System;
using System.Linq;
using System.Collections.Generic;
using COM.Data;
using ERP.Data;
using ERP.Domain;
using COM.Service;
namespace ERP.Service
{
	public interface IWMS_M101_StockTx_DataService
	{
		WMS_M101_StockTx_Data GetByIdentityNo(Guid IdentityNo);
        List<WMS_M101_StockTx_Data> GetList();
		List<WMS_M101_StockTx_Data> GetList(PagingModel pagingModel, DateTime? beginDate, DateTime? endDate);
        void Create(WMS_M101_StockTx_Data WMS_M101_StockTx_Data);
        void Update(WMS_M101_StockTx_Data WMS_M101_StockTx_Data);
        void Delete(Guid IdentityNo);
        IQueryable<vwSALE_R101_Delivery_Dtl> GetDeliveryDtlQuery();
        IQueryable<WMS_M101_StockTx_Data> GetStockTx_DataQuery();
        void Save(List<WMS_M101_StockTx_Data> stockTxList, string arCode);
	}
	public class WMS_M101_StockTx_DataService :IWMS_M101_StockTx_DataService
	{
		private IWMS_M101_StockTx_DataRepository WMS_M101_StockTx_DataRepository;
		private IUnitOfWork runtimeService;
		private ICacheServiceBase appCacheService = Unity.Instance.GetService<ICacheServiceBase>();
        private IMES_M801_Label_LRepository MES_M801_Label_LRepository;
		public WMS_M101_StockTx_DataService(IDatabaseFactory dbfactory)
		{
			this.runtimeService = new UnitOfWork(dbfactory);
			this.WMS_M101_StockTx_DataRepository = new WMS_M101_StockTx_DataRepository(dbfactory);
            this.MES_M801_Label_LRepository = new MES_M801_Label_LRepository(dbfactory);
		}
        public void Save(List<WMS_M101_StockTx_Data> stockTxList,string arCode)
        {
            foreach (var stock in stockTxList)
            {
                WMS_M101_StockTx_Data model = new WMS_M101_StockTx_Data();
                model.ARCode = arCode;
                model.CustCode = stock.CustCode;
                model.StockID = stock.StockID;
                model.OPType = "CPIN";
                model.TxDt = DateTime.Now.Date;
                model.LotNo = stock.LotNo;
                model.PartNo = stock.PartNo;
                model.Weight = stock.Weight;
                model.Qty = stock.Qty;
                model.IsProcessed = true;
                this.WMS_M101_StockTx_DataRepository.Add(model);

                //更新大标签设置CPIn为True;
            }
           // var Label = MES_M801_Label_LRepository.GetMany(a=>a.LotNo == stock)
            this.runtimeService.Commit();
        }
        public IQueryable<WMS_M101_StockTx_Data> GetStockTx_DataQuery()
        {
            var q = this.WMS_M101_StockTx_DataRepository.GetMany(i => true);
            return q;
        }
        public IQueryable<vwSALE_R101_Delivery_Dtl> GetDeliveryDtlQuery()
        {
            
            var q = this.WMS_M101_StockTx_DataRepository.GetDbContext().Database.SqlQuery<vwSALE_R101_Delivery_Dtl>("select * from vwSALE_R101_Delivery_Dtl");
            return q.AsQueryable() ;
        }
		public List<WMS_M101_StockTx_Data> GetList()
        {
            var q = this.WMS_M101_StockTx_DataRepository.GetMany(i => true);
            return q.ToList();
        }

        public WMS_M101_StockTx_Data GetByIdentityNo(Guid IdentityNo)
        {
            return this.WMS_M101_StockTx_DataRepository.GetByID(IdentityNo);
        }

        public void Create(WMS_M101_StockTx_Data WMS_M101_StockTx_Data)
        {
        	WMS_M101_StockTx_Data.CreateDt = DateTime.Now;
            tb_Sys_User tempUser = appCacheService.GetItem("user") as tb_Sys_User;
            WMS_M101_StockTx_Data.CreateUser = tempUser.UserName;
            WMS_M101_StockTx_Data.Validate();
			this.WMS_M101_StockTx_DataRepository.Add(WMS_M101_StockTx_Data);
            this.runtimeService.Commit();
        }

        public void Delete(Guid IdentityNo)
        {
            var existstb_Sys_Menu = this.GetByIdentityNo(IdentityNo);
            this.WMS_M101_StockTx_DataRepository.Delete(existstb_Sys_Menu);
            this.runtimeService.Commit();
        }

        public void Update(WMS_M101_StockTx_Data WMS_M101_StockTx_Data)
        {
        	WMS_M101_StockTx_Data.ModifyDt = DateTime.Now;
            tb_Sys_User tempUser = appCacheService.GetItem("user") as tb_Sys_User;
            WMS_M101_StockTx_Data.ModifyUser = tempUser.UserName;
            WMS_M101_StockTx_Data.Validate();
            var existstb_Sys_Menu = this.GetByIdentityNo(WMS_M101_StockTx_Data.Id);
            this.WMS_M101_StockTx_DataRepository.SetValues(WMS_M101_StockTx_Data, existstb_Sys_Menu);
            this.runtimeService.Commit();
        }

        public List<WMS_M101_StockTx_Data> GetList(PagingModel pagingModel, DateTime? beginDate, DateTime? endDate)
        {
            var q = this.WMS_M101_StockTx_DataRepository.GetMany(i => true);
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