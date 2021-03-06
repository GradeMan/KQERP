﻿using System;
using System.Linq;
using System.Collections.Generic;
using COM.Data;
using ERP.Data;
using ERP.Domain;
using COM.Service;
namespace ERP.Service
{
	public interface IWMS_C103_StockService
	{
		WMS_C103_Stock GetById(Guid Id);
        List<WMS_C103_Stock> GetList();
		List<WMS_C103_Stock> GetList(PagingModel pagingModel, DateTime? beginDate, DateTime? endDate);
        void Create(WMS_C103_Stock WMS_C103_Stock);
        void Update(WMS_C103_Stock WMS_C103_Stock);
        void Delete(Guid Id);
        IQueryable<WMS_C103_Stock> GetQueryStock();
	}
	public class WMS_C103_StockService :IWMS_C103_StockService
	{
		private IWMS_C103_StockRepository WMS_C103_StockRepository;
		private IUnitOfWork runtimeService;
		private ICacheServiceBase appCacheService = Unity.Instance.GetService<ICacheServiceBase>();
		public WMS_C103_StockService(IDatabaseFactory dbfactory)
		{
			this.runtimeService = new UnitOfWork(dbfactory);
			this.WMS_C103_StockRepository = new WMS_C103_StockRepository(dbfactory);
		}
        public IQueryable<WMS_C103_Stock> GetQueryStock()
        {
            var q = this.WMS_C103_StockRepository.GetMany(i => true);
            return q;
        }
		public List<WMS_C103_Stock> GetList()
        {
            var q = this.WMS_C103_StockRepository.GetMany(i => true);
            return q.ToList();
        }

        public WMS_C103_Stock GetById(Guid Id)
        {
            return this.WMS_C103_StockRepository.GetByID(Id);
        }

        public void Create(WMS_C103_Stock WMS_C103_Stock)
        {
        	WMS_C103_Stock.CreateDt = DateTime.Now;
            tb_Sys_User tempUser = appCacheService.GetItem("user") as tb_Sys_User;
            WMS_C103_Stock.CreateUser = tempUser.UserName;
            WMS_C103_Stock.Validate();
			this.WMS_C103_StockRepository.Add(WMS_C103_Stock);
            this.runtimeService.Commit();
        }

        public void Delete(Guid Id)
        {
            var existsTemp = this.GetById(Id);
            this.WMS_C103_StockRepository.Delete(existsTemp);
            this.runtimeService.Commit();
        }

        public void Update(WMS_C103_Stock WMS_C103_Stock)
        {
        	WMS_C103_Stock.ModifyDt = DateTime.Now;
            tb_Sys_User tempUser = appCacheService.GetItem("user") as tb_Sys_User;
            WMS_C103_Stock.ModifyUser = tempUser.UserName;
            WMS_C103_Stock.Validate();
            var existstb_Sys_Menu = this.GetById(WMS_C103_Stock.Id);
            this.WMS_C103_StockRepository.SetValues(WMS_C103_Stock, existstb_Sys_Menu);
            this.runtimeService.Commit();
        }

        public List<WMS_C103_Stock> GetList(PagingModel pagingModel, DateTime? beginDate, DateTime? endDate)
        {
            var q = this.WMS_C103_StockRepository.GetMany(i => true);
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