using System;
using System.Linq;
using System.Collections.Generic;
using COM.Data;
using ERP.Data;
using ERP.Domain;
using COM.Service;
namespace ERP.Service
{
	public interface IOrderDetailService
	{
		MES_M001_Order_Detail GetById(Guid Id);
        List<MES_M001_Order_Detail> GetList();
		List<MES_M001_Order_Detail> GetList(PagingModel pagingModel, DateTime? beginDate, DateTime? endDate);
        void Create(MES_M001_Order_Detail MES_M001_Order_Detail);
        void Update(MES_M001_Order_Detail MES_M001_Order_Detail);
        void Delete(Guid Id);
	}
    public class OrderDetailService : IOrderDetailService
	{
		private IOrderDetailRepository MES_M001_Order_DetailRepository;
		private IUnitOfWork runtimeService;
		private ICacheServiceBase appCacheService = Unity.Instance.GetService<ICacheServiceBase>();
        public OrderDetailService(IDatabaseFactory dbfactory)
		{
			this.runtimeService = new UnitOfWork(dbfactory);
            this.MES_M001_Order_DetailRepository = new OrderDetailRepository(dbfactory);
		}

		public List<MES_M001_Order_Detail> GetList()
        {
            var q = this.MES_M001_Order_DetailRepository.GetMany(i => true);
            return q.ToList();
        }

        public MES_M001_Order_Detail GetById(Guid Id)
        {
            return this.MES_M001_Order_DetailRepository.GetByID(Id);
        }

        public void Create(MES_M001_Order_Detail MES_M001_Order_Detail)
        {
        	MES_M001_Order_Detail.CreateDt = DateTime.Now;
            tb_Sys_User tempUser = appCacheService.GetItem("user") as tb_Sys_User;
            MES_M001_Order_Detail.CreateUser = tempUser.UserName;
            MES_M001_Order_Detail.CompCode = tempUser.CompCode;
            MES_M001_Order_Detail.Validate();
			this.MES_M001_Order_DetailRepository.Add(MES_M001_Order_Detail);
            this.runtimeService.Commit();
        }

        public void Delete(Guid Id)
        {
            var existsTemp = this.GetById(Id);
            this.MES_M001_Order_DetailRepository.Delete(existsTemp);
            this.runtimeService.Commit();
        }

        public void Update(MES_M001_Order_Detail MES_M001_Order_Detail)
        {
        	MES_M001_Order_Detail.ModifyDt = DateTime.Now;
            tb_Sys_User tempUser = appCacheService.GetItem("user") as tb_Sys_User;
            MES_M001_Order_Detail.ModifyUser = tempUser.UserName;
            MES_M001_Order_Detail.Validate();
            var existstb_Sys_Menu = this.GetById(MES_M001_Order_Detail.Id);
            this.MES_M001_Order_DetailRepository.SetValues(MES_M001_Order_Detail, existstb_Sys_Menu);
            this.runtimeService.Commit();
        }

        public List<MES_M001_Order_Detail> GetList(PagingModel pagingModel, DateTime? beginDate, DateTime? endDate)
        {
            var q = this.MES_M001_Order_DetailRepository.GetMany(i => true);
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