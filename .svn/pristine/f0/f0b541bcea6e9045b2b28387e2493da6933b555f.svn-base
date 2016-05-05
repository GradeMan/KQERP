using System;
using System.Linq;
using System.Collections.Generic;
using COM.Data;
using ERP.Data;
using ERP.Domain;
using COM.Service;
namespace ERP.Service
{
	public interface IWMSStockTxService
	{
		WMS_M002_StockTx GetById(Guid Id);
        List<WMS_M002_StockTx> GetList();
		List<WMS_M002_StockTx> GetList(PagingModel pagingModel, DateTime? beginDate, DateTime? endDate);
        void Create(WMS_M002_StockTx WMS_M002_StockTx);
        void Update(WMS_M002_StockTx WMS_M002_StockTx);
        void Delete(Guid Id);
	}
    public class WMSStockTxService : IWMSStockTxService
	{
		private IWMS_M002_StockTxRepository WMS_M002_StockTxRepository;
		private IUnitOfWork runtimeService;
		private ICacheServiceBase appCacheService = Unity.Instance.GetService<ICacheServiceBase>();
        public WMSStockTxService(IDatabaseFactory dbfactory)
		{
			this.runtimeService = new UnitOfWork(dbfactory);
			this.WMS_M002_StockTxRepository = new WMS_M002_StockTxRepository(dbfactory);
		}

		public List<WMS_M002_StockTx> GetList()
        {
            var q = this.WMS_M002_StockTxRepository.GetMany(i => true);
            return q.ToList();
        }

        public WMS_M002_StockTx GetById(Guid Id)
        {
            return this.WMS_M002_StockTxRepository.GetByID(Id);
        }

        public void Create(WMS_M002_StockTx WMS_M002_StockTx)
        {
        	WMS_M002_StockTx.CreateDt = DateTime.Now;
            tb_Sys_User tempUser = appCacheService.GetItem("user") as tb_Sys_User;
            WMS_M002_StockTx.CreateUser = tempUser.UserName;
            WMS_M002_StockTx.Validate();
			this.WMS_M002_StockTxRepository.Add(WMS_M002_StockTx);
            this.runtimeService.Commit();
        }

        public void Delete(Guid Id)
        {
            var existstb_Sys_Menu = this.GetById(Id);
            this.WMS_M002_StockTxRepository.Delete(existstb_Sys_Menu);
            this.runtimeService.Commit();
        }

        public void Update(WMS_M002_StockTx WMS_M002_StockTx)
        {
        	WMS_M002_StockTx.ModifyDt = DateTime.Now;
            tb_Sys_User tempUser = appCacheService.GetItem("user") as tb_Sys_User;
            WMS_M002_StockTx.ModifyUser = tempUser.UserName;
            WMS_M002_StockTx.Validate();
            var existstb_Sys_Menu = this.GetById(WMS_M002_StockTx.Id);
            this.WMS_M002_StockTxRepository.SetValues(WMS_M002_StockTx, existstb_Sys_Menu);
            this.runtimeService.Commit();
        }

        public List<WMS_M002_StockTx> GetList(PagingModel pagingModel, DateTime? beginDate, DateTime? endDate)
        {
            var q = this.WMS_M002_StockTxRepository.GetMany(i => true);
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