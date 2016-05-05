using System;
using System.Linq;
using System.Collections.Generic;
using COM.Data;
using ERP.Data;
using ERP.Domain;
using COM.Service;
using ERP.Domain.Order.ViewModel;
namespace ERP.Service
{
	public interface IOrderService
	{
		MES_M001_Order GetById(Guid Id);
        List<MES_M001_Order> GetList();
		List<MES_M001_Order> GetList(PagingModel pagingModel, DateTime? beginDate, DateTime? endDate);
        void Create(MES_M001_Order MES_M001_Order);
        void Update(MES_M001_Order MES_M001_Order);
        void Delete(Guid Id);
        void MarkDelOrderDetail(Guid id);
        List<MES_M001_Order_Detail> GetOrderDetailByOrderNo(string orderNo);
        void Save(MES_M001_Order MES_M001_Order, List<MES_M001_Order_Detail> orderDetailList);
        List<OrderDashboardModel> GetOrderDashboardModelListGroupByMouth();
	}
    public class OrderService : IOrderService
    {
        private IOrderRepository MES_M001_OrderRepository;
        private IOrderDetailRepository orderDetailRepository;
        private IUnitOfWork runtimeService;
        private ICacheServiceBase appCacheService = Unity.Instance.GetService<ICacheServiceBase>();
        public OrderService(IDatabaseFactory dbfactory)
        {
            this.runtimeService = new UnitOfWork(dbfactory);
            this.MES_M001_OrderRepository = new OrderRepository(dbfactory);
            this.orderDetailRepository = new OrderDetailRepository(dbfactory);
        }

        public List<MES_M001_Order> GetList()
        {
            var q = this.MES_M001_OrderRepository.GetMany(i => true);
            return q.ToList();
        }

        public MES_M001_Order GetById(Guid Id)
        {
            return this.MES_M001_OrderRepository.GetByID(Id);
        }

        public void Create(MES_M001_Order MES_M001_Order)
        {
            MES_M001_Order.CreateDt = DateTime.Now;
            tb_Sys_User tempUser = appCacheService.GetItem("user") as tb_Sys_User;
            MES_M001_Order.CreateUser = tempUser.UserName;
            MES_M001_Order.CompCode = tempUser.CompCode;
            MES_M001_Order.Validate();
            this.MES_M001_OrderRepository.Add(MES_M001_Order);
            this.runtimeService.Commit();
        }

        public void Delete(Guid Id)
        {
            var existsTemp = this.GetById(Id);
            this.MES_M001_OrderRepository.Delete(existsTemp);
            this.runtimeService.Commit();
        }

        public void Update(MES_M001_Order MES_M001_Order)
        {
            MES_M001_Order.ModifyDt = DateTime.Now;
            tb_Sys_User tempUser = appCacheService.GetItem("user") as tb_Sys_User;
            MES_M001_Order.ModifyUser = tempUser.UserName;
            MES_M001_Order.Validate();
            var existstb_Sys_Menu = this.GetById(MES_M001_Order.Id);
            this.MES_M001_OrderRepository.SetValues(MES_M001_Order, existstb_Sys_Menu);
            this.runtimeService.Commit();
        }

        public List<MES_M001_Order> GetList(PagingModel pagingModel, DateTime? beginDate, DateTime? endDate)
        {
            var q = this.MES_M001_OrderRepository.GetMany(i => true);
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


        public List<MES_M001_Order_Detail> GetOrderDetailByOrderNo(string orderNo)
        {
            var q = this.orderDetailRepository.GetMany(i => i.OrdNo == orderNo);
            return q.ToList();
        }


        public void MarkDelOrderDetail(Guid id)
        {
            var existsTemp = orderDetailRepository.GetByID(id);
            if (existsTemp != null)
                this.orderDetailRepository.Delete(existsTemp);
        }


        public void Save(MES_M001_Order order, List<MES_M001_Order_Detail> orderDetailList)
        {
            tb_Sys_User tempUser = appCacheService.GetItem("user") as tb_Sys_User;
            var existsorder = this.GetById(order.Id);
            if (existsorder == null)
            {
                order.CompCode = tempUser.CompCode;
                order.CreateDt = DateTime.Now;
                order.CreateUser = tempUser.UserName;
                order.Validate();
                this.MES_M001_OrderRepository.Add(order);
            }
            else
            {
                order.ModifyDt = DateTime.Now;
                order.ModifyUser = tempUser.UserName;
                order.Validate();
                this.MES_M001_OrderRepository.SetValues(order, existsorder);
            }
            if (orderDetailList != null)
            {
                foreach (var orderDetail in orderDetailList)
                {
                    var existstorderDetail = this.orderDetailRepository.GetByID(orderDetail.Id);
                    if (existstorderDetail == null)
                    {
                        orderDetail.CompCode = tempUser.CompCode;
                        orderDetail.CreateDt = DateTime.Now;
                        orderDetail.CreateUser = tempUser.UserName;
                        orderDetail.Validate();
                        this.orderDetailRepository.Add(orderDetail);
                    }
                    else
                    {
                        orderDetail.ModifyDt = DateTime.Now;
                        orderDetail.ModifyUser = tempUser.UserName;
                        orderDetail.Validate();
                        this.orderDetailRepository.SetValues(orderDetail, existstorderDetail);
                    }
                }
            }
            this.runtimeService.Commit();
        }


        public List<OrderDashboardModel> GetOrderDashboardModelListGroupByMouth()
        {
            var q = this.MES_M001_OrderRepository.GetMany(i => true);
            var q2 = this.orderDetailRepository.GetMany(i => true);
            var q3 = (from order in q
                     join detail in q2 on order.OrdNo equals detail.OrdNo
                     select new
                     {
                         OrdDt = order.OrdDt,
                         Qty = detail.Qty
                     }).ToList();
            var q4 = q3.Select(i => new OrderDashboardModel { OrdDt = i.OrdDt.Value.ToString("yyyy-MM") , Qty = i.Qty }).ToList();
           // OrdDt = i.OrdDt.Value.Year.ToString() + (i.OrdDt.Value.Month < 10 ? 0 + i.OrdDt.Value.Month.ToString() : i.OrdDt.Value.Month.ToString())
            //var q5 = (from i in q4
            //          group i by i.OrdDt into g
            //          select new OrderDashboardModel
            //          {
            //              OrdDt = g.Key,
            //              Qty = g.Sum(i => i.Qty)
            //          }).ToList();
            return q4;
        }
    }
}