using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ERP.Domain;
using COM.Data;
using ERP.Data;
using COM.Service;

namespace ERP.Service
{
    public interface IESOP_ProductService
    {
        ESOP_Product GetById(Guid Id);
        List<ESOP_Product> GetList();
        List<ESOP_Product> GetList(PagingModel pagingModel, DateTime? beginDate, DateTime? endDate);
        void Create(ESOP_Product ESOP_Product);
        void Update(ESOP_Product ESOP_Product);
        void Delete(Guid Id);
        void Save(ESOP_Product product);
    }
    public class ESOP_ProductService : IESOP_ProductService
    {
        private IESOP_ProductRepository productRepository;
        private IUnitOfWork runtimeService;
        private ICacheServiceBase appCacheService = Unity.Instance.GetService<ICacheServiceBase>();
        public ESOP_ProductService(IDatabaseFactory dbfactory)
        {
            this.runtimeService = new UnitOfWork(dbfactory);
            this.productRepository = new ESOP_ProductRepository(dbfactory);

        }

        public List<ESOP_Product> GetList()
        {
            var q = this.productRepository.GetMany(i => true);
            return q.ToList();
        }

        public ESOP_Product GetById(Guid Id)
        {
            return this.productRepository.GetByID(Id);
        }

        public void Create(ESOP_Product ESOP_Product)
        {
            ESOP_Product.CreateDt = DateTime.Now;
            tb_Sys_User tempUser = appCacheService.GetItem("user") as tb_Sys_User;
            ESOP_Product.CreateUser = tempUser.UserName;
            ESOP_Product.Validate();
            this.productRepository.Add(ESOP_Product);
            this.runtimeService.Commit();
        }

        public void Delete(Guid Id)
        {
            var existstb_Sys_Menu = this.GetById(Id);
            this.productRepository.Delete(existstb_Sys_Menu);
            this.runtimeService.Commit();
        }

        public void Update(ESOP_Product ESOP_Product)
        {
            ESOP_Product.ModifyDt = DateTime.Now;
            tb_Sys_User tempUser = appCacheService.GetItem("user") as tb_Sys_User;
            ESOP_Product.ModifyUser = tempUser.UserName;
            ESOP_Product.Validate();
            var existstb_Sys_Menu = this.GetById(ESOP_Product.Id);
            this.productRepository.SetValues(ESOP_Product, existstb_Sys_Menu);
            this.runtimeService.Commit();
        }

        public List<ESOP_Product> GetList(PagingModel pagingModel, DateTime? beginDate, DateTime? endDate)
        {
            var q = this.productRepository.GetMany(i => true);
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


        public void Save(ESOP_Product product)
        {
            tb_Sys_User tempUser = appCacheService.GetItem("user") as tb_Sys_User;

            var existsdevice = this.GetById(product.Id);
            if (existsdevice == null)
            {
                product.CompCode = tempUser.CompCode;
                product.CreateDt = DateTime.Now;
                product.CreateUser = tempUser.UserName;
                product.Validate();
                this.productRepository.Add(product);
            }
            else
            {
                product.ModifyDt = DateTime.Now;
                product.ModifyUser = tempUser.UserName;
                product.Validate();
                this.productRepository.SetValues(product, existsdevice);
            }

            this.runtimeService.Commit();
        }
    }
}
