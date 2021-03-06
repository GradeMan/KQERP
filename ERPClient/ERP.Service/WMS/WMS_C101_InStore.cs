﻿using System;
using System.Linq;
using System.Collections.Generic;
using COM.Data;
using ERP.Data;
using ERP.Domain;
using COM.Service;
using Util;
using System.Data.SqlClient;
namespace ERP.Service
{
	public interface IWMS_C101_InStoreService
	{
		WMS_C101_InStore GetById(Guid Id);
        List<WMS_C101_InStore> GetList();
		List<WMS_C101_InStore> GetList(PagingModel pagingModel, DateTime? beginDate, DateTime? endDate);
        void Create(WMS_C101_InStore WMS_C101_InStore);
        void Update(WMS_C101_InStore WMS_C101_InStore);
        void Delete(Guid Id);
        void MarkDelDetail(Guid InStoreDetailId);
        void Save(WMS_C101_InStore instore, List<WMS_C102_InStoreDetail> instoreDetailList);
        List<WMS_C102_InStoreDetail> GetDetailListByInstoreId(Guid instoreId);
        string GetInStoreNo();
	}
	public class WMS_C101_InStoreService :IWMS_C101_InStoreService
	{
		private IWMS_C101_InStoreRepository WMS_C101_InStoreRepository;
		private IUnitOfWork runtimeService;
		private ICacheServiceBase appCacheService = Unity.Instance.GetService<ICacheServiceBase>();
        private IWMS_C102_InStoreDetailRepository instoreDetailRepository;
        private IWMS_C103_StockRepository stockRepository;
        private IWMS_C105_OutStoreDetailRepository outstoreDetailRepository;
		public WMS_C101_InStoreService(IDatabaseFactory dbfactory)
		{
			this.runtimeService = new UnitOfWork(dbfactory);
			this.WMS_C101_InStoreRepository = new WMS_C101_InStoreRepository(dbfactory);
            this.instoreDetailRepository = new WMS_C102_InStoreDetailRepository(dbfactory);
            this.outstoreDetailRepository = new WMS_C105_OutStoreDetailRepository(dbfactory);
            this.stockRepository = new WMS_C103_StockRepository(dbfactory);

		}
        public string GetInStoreNo()
        {
            Type t = typeof(string);
            SqlParameter[] selcountparms = new SqlParameter[1];
            selcountparms[0] = new SqlParameter("@orderType", 1);
            var instoreno = this.WMS_C101_InStoreRepository.GetDbContext().Database.SqlQuery(t, "exec Proc_GenerateOrderCode @orderType ", selcountparms).Cast<string>().Single();
            return instoreno.Trim();
        }
		public List<WMS_C101_InStore> GetList()
        {
            var q = this.WMS_C101_InStoreRepository.GetMany(i => true);
            return q.ToList();
        }

        public WMS_C101_InStore GetById(Guid Id)
        {
            return this.WMS_C101_InStoreRepository.GetByID(Id);
        }

        public void Create(WMS_C101_InStore WMS_C101_InStore)
        {
        	WMS_C101_InStore.CreateDt = DateTime.Now;
            tb_Sys_User tempUser = appCacheService.GetItem("user") as tb_Sys_User;
            WMS_C101_InStore.CreateUser = tempUser.UserName;
           
            WMS_C101_InStore.Validate();
			this.WMS_C101_InStoreRepository.Add(WMS_C101_InStore);
            this.runtimeService.Commit();
        }

        public void Delete(Guid Id)
        {
            var existsTemp = this.GetById(Id);
            this.WMS_C101_InStoreRepository.Delete(existsTemp);
            this.runtimeService.Commit();
        }

        public void Update(WMS_C101_InStore WMS_C101_InStore)
        {
        	WMS_C101_InStore.ModifyDt = DateTime.Now;
            tb_Sys_User tempUser = appCacheService.GetItem("user") as tb_Sys_User;
            WMS_C101_InStore.ModifyUser = tempUser.UserName;
            WMS_C101_InStore.Validate();
            var existstb_Sys_Menu = this.GetById(WMS_C101_InStore.Id);
            this.WMS_C101_InStoreRepository.SetValues(WMS_C101_InStore, existstb_Sys_Menu);
            this.runtimeService.Commit();
        }

        public List<WMS_C101_InStore> GetList(PagingModel pagingModel, DateTime? beginDate, DateTime? endDate)
        {
            var q = this.WMS_C101_InStoreRepository.GetMany(i => true);
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


        public void MarkDelDetail(Guid InStoreDetailId)
        {
            var stock = this.stockRepository.GetMany(i => i.InStoreDetailId == InStoreDetailId).FirstOrDefault();
            if (stock != null)
            {
                //var outstore = this.outstoreDetailRepository.GetMany(i => i.StockId == stock.Id).FirstOrDefault();
                //if (outstore != null)
                //    throw new AppException(string.Format("单号{0}下的批号{1}在{2}已出库，不允许删除", stock.JobNo, stock.LotNo, stock.ARCode));
                //this.stockRepository.Delete(stock);
            }
            var existsTemp = this.instoreDetailRepository.GetByID(InStoreDetailId);
            if (existsTemp != null)
                this.instoreDetailRepository.Delete(existsTemp);
           // this.runtimeService.Commit();
        }


        public void Save(WMS_C101_InStore instore, List<WMS_C102_InStoreDetail> instoreDetailList)
        {
            //if (instore.BeforeAmount < instore.ActualAmount)
            //    throw new AppException("实际入库数不能大于计划入库数");
            tb_Sys_User tempUser = appCacheService.GetItem("user") as tb_Sys_User;
            var existslotTx = this.GetById(instore.Id);
            if (existslotTx == null)
            {
                instore.CreateDt = DateTime.Now;
                instore.CreateUser = tempUser.UserName;
                instore.Validate();
                this.WMS_C101_InStoreRepository.Add(instore);
            }
            else
            {
                instore.ModifyDt = DateTime.Now;
                instore.ModifyUser = tempUser.UserName;
                instore.Validate();
                this.WMS_C101_InStoreRepository.SetValues(instore, existslotTx);
            }
            if (instoreDetailList != null)
            {
                foreach (var detail in instoreDetailList)
                {
                    var existstLotTxNG = this.instoreDetailRepository.GetByID(detail.Id);
                    if (existstLotTxNG == null)
                    {
                        detail.CreateDt = DateTime.Now;
                        detail.CreateUser = tempUser.UserName;
                        detail.Validate();
                        this.instoreDetailRepository.Add(detail);
                        WMS_C103_Stock stock = new WMS_C103_Stock();
                        stock.InStoreDetailId = detail.Id;
                        stock.InStoreId = detail.InStoreId;
                        stock.StoreAmount = detail.Amount;
                        stock.StockStatus = "合格";
                        stock.ARCode = detail.ARCode;
                        stock.SuppLot = detail.SuppLot;
                        stock.SuppCode = instore.SuppCode;
                        stock.PartSpec = detail.PartSpec;
                        stock.MatClass2 = detail.MatClass2;
                        
                        stock.CreateDt = DateTime.Now;
                        stock.CreateUser = tempUser.UserName;
                        this.stockRepository.Add(stock);
                    }
                    //else if (existstLotTxNG.Amount != detail.Amount)
                    //{
                    //    //如果已经入库的修改，则判断是否已经出库，如果已经出库，则不允许修改
                    //    var stock = this.stockRepository.GetMany(i => i.InStoreDetailId == detail.Id).FirstOrDefault();
                    //    if (stock != null)
                    //    {
                    //        var outstore = this.outstoreDetailRepository.GetMany(i => i.StockId == stock.Id).FirstOrDefault();
                    //        if (outstore != null)
                    //            throw new AppException(string.Format("单号{0}在{1}已出库，不允许修改", detail.ARCode));
                    //        else
                    //        {
                    //            //stock.LotNo = detail.LotNo;
                    //            stock.ARCode = detail.ARCode;
                    //            stock.StoreAmount = detail.Amount;
                    //            stock.ModifyDt = DateTime.Now;
                    //            stock.ModifyUser = tempUser.UserName;
                    //            stock.SuppLot = detail.SuppLot;
                    //            detail.Validate();
                    //            this.instoreDetailRepository.SetValues(detail, existstLotTxNG);
                    //        }

                    //    }
                    //    //detail.Validate();
                    //   // this.instoreDetailRepository.SetValues(detail, existstLotTxNG);
                    //}
                }
            }
            this.runtimeService.Commit();
        }


        public List<WMS_C102_InStoreDetail> GetDetailListByInstoreId(Guid instoreId)
        {
            var q = this.instoreDetailRepository.GetMany(i => i.InStoreId == instoreId).OrderBy(i=>i.ARCode);
            return q.ToList();
        }
    }
}