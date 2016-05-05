using COM.Data;
using COM.Service;
using ERP.Data;
using ERP.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ERP.Service
{
    public interface IESOP_PublishService
    {
        ESOP_Publish GetById(Guid Id);
        List<ESOP_Publish> GetList();
        List<ESOP_Publish> GetList(PagingModel pagingModel, DateTime? beginDate, DateTime? endDate);
        void Create(ESOP_Publish ESOP_Product);
        void Update(ESOP_Publish ESOP_Product);
        void Delete(Guid Id);
        void Save(ESOP_Publish product);
        //List<ESOP_PublishViewModel> GetPublishView();
    }
    public class ESOP_PublishService : IESOP_PublishService
    {
        private IESOP_PublishRepository publishRepository;
        private IESOP_DeviceRepository deviceRepository;
        private IESOP_DocIndexRepository docIndexRepository;
        private IESOP_DocRepository docRepository;
        private IUnitOfWork runtimeService;
        private ICacheServiceBase appCacheService = Unity.Instance.GetService<ICacheServiceBase>();
        public ESOP_PublishService(IDatabaseFactory dbfactory)
        {
            this.runtimeService = new UnitOfWork(dbfactory);
            this.publishRepository = new ESOP_PublishRepository(dbfactory);
            this.deviceRepository = new ESOP_DeviceRepository(dbfactory);
            this.docIndexRepository = new ESOP_DocIndexRepository(dbfactory);
            docRepository = new ESOP_DocRepository(dbfactory);
        }
        //public List<ESOP_PublishViewModel> GetPublishView()
        //{
        //    var q = this.publishRepository.GetMany(i => true).Select(a => new ESOP_PublishViewModel { DevId = a.DevId, DocId = a.DocId, DocIndexId = a.DocIndexId, Id = a.Id, PartNo = a.PartNo, EffectiveDt = a.EffectiveDt, ExpireDt = a.ExpireDt, State = a.State }).ToList();
        //    q.ForEach(a=>
        //        {
        //            a.DeviceName = deviceRepository.GetByID(a.DevId).DevName;
        //            a.DocIndexName = docIndexRepository.GetByID(a.DocIndexId).DocIndexName;
        //            a.DocName = docRepository.GetByID(a.DocId).DocName;
        //        });
        //    return q.ToList();

        //}
        public List<ESOP_Publish> GetList()
        {
            var q = this.publishRepository.GetMany(i => true);
            return q.ToList();
        }

        public ESOP_Publish GetById(Guid Id)
        {
            return this.publishRepository.GetByID(Id);
        }

        public void Create(ESOP_Publish ESOP_Publish)
        {
            ESOP_Publish.CreateDt = DateTime.Now;
            tb_Sys_User tempUser = appCacheService.GetItem("user") as tb_Sys_User;
            ESOP_Publish.CreateUser = tempUser.UserName;
            ESOP_Publish.Validate();
            this.publishRepository.Add(ESOP_Publish);
            this.runtimeService.Commit();
        }

        public void Delete(Guid Id)
        {
            var existstb_Sys_Menu = this.GetById(Id);
            this.publishRepository.Delete(existstb_Sys_Menu);
            this.runtimeService.Commit();
        }

        public void Update(ESOP_Publish ESOP_Product)
        {
            ESOP_Product.ModifyDt = DateTime.Now;
            tb_Sys_User tempUser = appCacheService.GetItem("user") as tb_Sys_User;
            ESOP_Product.ModifyUser = tempUser.UserName;
            ESOP_Product.Validate();
            var existstb_Sys_Menu = this.GetById(ESOP_Product.Id);
            this.publishRepository.SetValues(ESOP_Product, existstb_Sys_Menu);
            this.runtimeService.Commit();
        }

        public List<ESOP_Publish> GetList(PagingModel pagingModel, DateTime? beginDate, DateTime? endDate)
        {
            var q = this.publishRepository.GetMany(i => true);
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


        public void Save(ESOP_Publish product)
        {
            tb_Sys_User tempUser = appCacheService.GetItem("user") as tb_Sys_User;

            var existsdevice = this.GetById(product.Id);
            if (existsdevice == null)
            {
                product.CompCode = tempUser.CompCode;
                product.CreateDt = DateTime.Now;
                product.CreateUser = tempUser.UserName;
                product.Validate();
                this.publishRepository.Add(product);
            }
            else
            {
                product.ModifyDt = DateTime.Now;
                product.ModifyUser = tempUser.UserName;
                product.Validate();
                this.publishRepository.SetValues(product, existsdevice);
            }

            this.runtimeService.Commit();
        }
    }
}
