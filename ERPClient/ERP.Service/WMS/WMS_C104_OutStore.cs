using System;
using System.Linq;
using System.Collections.Generic;
using COM.Data;
using ERP.Data;
using ERP.Domain;
using COM.Service;
using Util;
using COM.Domain;
namespace ERP.Service
{
	public interface IWMS_C104_OutStoreService
	{
		WMS_C104_OutStore GetById(Guid Id);
        List<WMS_C104_OutStore> GetList();
		List<WMS_C104_OutStore> GetList(PagingModel pagingModel, DateTime? beginDate, DateTime? endDate);
        void Create(WMS_C104_OutStore WMS_C104_OutStore);
        void Update(WMS_C104_OutStore WMS_C104_OutStore);
        void Delete(Guid Id);
        List<WMS_C105_OutStoreDetail> GetDetailListByOutStoreId(Guid outStoreId);
        void MarkDeleteDetail(WMS_C105_OutStoreDetail outDetail);
        void Save(WMS_C104_OutStore outstore, List<WMS_C105_OutStoreDetail> outstoreDetailList);
	}
	public class WMS_C104_OutStoreService :IWMS_C104_OutStoreService
	{
		private IWMS_C104_OutStoreRepository WMS_C104_OutStoreRepository;
		private IUnitOfWork runtimeService;
		private ICacheServiceBase appCacheService = Unity.Instance.GetService<ICacheServiceBase>();
        private IWMS_C105_OutStoreDetailRepository outStoreDetailRepository;
        private IWMS_C103_StockRepository stockRepostiroy;
		public WMS_C104_OutStoreService(IDatabaseFactory dbfactory)
		{
			this.runtimeService = new UnitOfWork(dbfactory);
			this.WMS_C104_OutStoreRepository = new WMS_C104_OutStoreRepository(dbfactory);
            this.outStoreDetailRepository = new WMS_C105_OutStoreDetailRepository(dbfactory);
            this.stockRepostiroy = new WMS_C103_StockRepository(dbfactory);
		}

		public List<WMS_C104_OutStore> GetList()
        {
            var q = this.WMS_C104_OutStoreRepository.GetMany(i => true);
            return q.ToList();
        }

        public WMS_C104_OutStore GetById(Guid Id)
        {
            return this.WMS_C104_OutStoreRepository.GetByID(Id);
        }

        public void Create(WMS_C104_OutStore WMS_C104_OutStore)
        {
        	WMS_C104_OutStore.CreateDt = DateTime.Now;
            tb_Sys_User tempUser = appCacheService.GetItem("user") as tb_Sys_User;
            WMS_C104_OutStore.CreateUser = tempUser.UserName;
            WMS_C104_OutStore.CompCode = tempUser.CompCode;
            WMS_C104_OutStore.Validate();
			this.WMS_C104_OutStoreRepository.Add(WMS_C104_OutStore);
            this.runtimeService.Commit();
        }

        public void Delete(Guid Id)
        {
            
            var existsTemp = this.GetById(Id);
            if (existsTemp.Status == "HasOutStore")
                throw new AppException("此出库单已出库，不能删除");
            this.WMS_C104_OutStoreRepository.Delete(existsTemp);
            this.runtimeService.Commit();
        }

        public void Update(WMS_C104_OutStore WMS_C104_OutStore)
        {
        	WMS_C104_OutStore.ModifyDt = DateTime.Now;
            tb_Sys_User tempUser = appCacheService.GetItem("user") as tb_Sys_User;
            WMS_C104_OutStore.ModifyUser = tempUser.UserName;
            WMS_C104_OutStore.Validate();
            var existstb_Sys_Menu = this.GetById(WMS_C104_OutStore.Id);
            this.WMS_C104_OutStoreRepository.SetValues(WMS_C104_OutStore, existstb_Sys_Menu);
            this.runtimeService.Commit();
        }

        public List<WMS_C104_OutStore> GetList(PagingModel pagingModel, DateTime? beginDate, DateTime? endDate)
        {
            var q = this.WMS_C104_OutStoreRepository.GetMany(i => true);
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


        public List<WMS_C105_OutStoreDetail> GetDetailListByOutStoreId(Guid outStoreId)
        {
            var q = this.outStoreDetailRepository.GetMany(i => i.OutStoreId == outStoreId);
            return q.ToList();
        }

        public void MarkDeleteDetail(WMS_C105_OutStoreDetail outDetail)
        {
            var outStore = this.WMS_C104_OutStoreRepository.GetMany(i => i.Id == outDetail.OutStoreId).FirstOrDefault();
            if (outStore != null && outStore.Status == "HasOutStore")
                throw new AppException("此出库单已经出库，不允许删除");
            var existsTemp = this.outStoreDetailRepository.GetByID(outDetail.Id);
            this.outStoreDetailRepository.Delete(existsTemp);
        }


        public void Save(WMS_C104_OutStore outstore, List<WMS_C105_OutStoreDetail> outstoreDetailList)
        {
            tb_Sys_User tempUser = appCacheService.GetItem("user") as tb_Sys_User;
            var existslotTx = this.GetById(outstore.Id);
            if (existslotTx == null)
            {
                outstore.CompCode = tempUser.CompCode;
                outstore.CreateDt = DateTime.Now;
                outstore.CreateUser = tempUser.UserName;
                outstore.Validate();
                this.WMS_C104_OutStoreRepository.Add(outstore);
            }
            else
            {
                outstore.ModifyDt = DateTime.Now;
                outstore.ModifyUser = tempUser.UserName;
                outstore.Validate();
                this.WMS_C104_OutStoreRepository.SetValues(outstore, existslotTx);
            }
            if (outstoreDetailList != null)
            {
                foreach (var detail in outstoreDetailList)
                {
                    var existstoutStoreDetail = this.outStoreDetailRepository.GetByID(detail.Id);
                    if (existstoutStoreDetail == null)
                    {
                        //var stock = this.stockRepostiroy.GetMany(i => i.Id == detail.StockId).FirstOrDefault();
                        var stock = this.stockRepostiroy.GetMany(i => i.ARCode == detail.ARCode && i.PartSpec == detail.PartSpec && i.MatClass2 == detail.MatClass2).FirstOrDefault();
                        if (stock == null)
                            throw new AppException(string.Format("出库单'{0}'在位置'{1}'没有库存，请检查", detail.OutSotreNo, detail.ARCode));
                        if (detail.Amount > stock.StoreAmount)
                            throw new AppException(string.Format("出库单'{0}'在位置'{1}'的库存小于出库数量，请检查", detail.OutSotreNo, detail.ARCode));
                        detail.CompCode = tempUser.CompCode;
                        detail.CreateDt = DateTime.Now;
                        detail.CreateUser = tempUser.UserName;
                        detail.Validate();
                        this.outStoreDetailRepository.Add(detail);
                        //更新库存
                         stock.StoreAmount = stock.StoreAmount - detail.Amount;
                    }
                    else
                    {
                        if (existstoutStoreDetail.Amount!= detail.Amount)
                            throw new AppException(string.Format("出库单'{0}'在位置'{1}'的已经出库，无法修改", detail.OutSotreNo, detail.ARCode));
                        detail.Validate();
                        this.outStoreDetailRepository.SetValues(detail, existstoutStoreDetail);
                    }                   
                }
            }
            this.runtimeService.Commit();
        }


      
    }
}