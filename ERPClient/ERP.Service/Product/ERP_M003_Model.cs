using System;
using System.Linq;
using System.Collections.Generic;
using COM.Data;
using ERP.Data;
using ERP.Domain;
using COM.Service;
using COM.Domain;
namespace ERP.Service
{
	public interface IModelService
	{
		ERP_M003_Model GetById(Guid Id);
        List<ERP_M003_Model> GetList();
		List<ERP_M003_Model> GetList(PagingModel pagingModel, DateTime? beginDate, DateTime? endDate);
        void Create(ERP_M003_Model ERP_M003_Model);
        void Update(ERP_M003_Model ERP_M003_Model);
        void Delete(Guid Id);
        void MarkDeleteProduct(Guid id);
        List<ERP_M003_Model_Product> GetProductListByModelCode(string modelCode);
        void Save(ERP_M003_Model ERP_M003_Model, List<ERP_M003_Model_Product> modelProductList);
        List<InputItem> GetSupplierData();
	}
    public class ModelService : IModelService
	{
		private IERP_M003_ModelRepository ERP_M003_ModelRepository;
        private IERP_M003_Model_ProductRepository modelProductRepository;
        private ERP_C004_SupplierRepository supplierRepository;
		private IUnitOfWork runtimeService;
		private ICacheServiceBase appCacheService = Unity.Instance.GetService<ICacheServiceBase>();
        public ModelService(IDatabaseFactory dbfactory)
		{
			this.runtimeService = new UnitOfWork(dbfactory);
			this.ERP_M003_ModelRepository = new ERP_M003_ModelRepository(dbfactory);
            this.modelProductRepository = new ERP_M003_Model_ProductRepository(dbfactory);
            this.supplierRepository = new ERP_C004_SupplierRepository(dbfactory);
		}

		public List<ERP_M003_Model> GetList()
        {
            var q = this.ERP_M003_ModelRepository.GetMany(i => true);
            return q.ToList();
        }

        public ERP_M003_Model GetById(Guid Id)
        {
            return this.ERP_M003_ModelRepository.GetByID(Id);
        }

        public void Create(ERP_M003_Model ERP_M003_Model)
        {
        	ERP_M003_Model.CreateDt = DateTime.Now;
            tb_Sys_User tempUser = appCacheService.GetItem("user") as tb_Sys_User;
            ERP_M003_Model.CreateUser = tempUser.UserName;
            ERP_M003_Model.CompCode = tempUser.CompCode;
            ERP_M003_Model.Validate();
			this.ERP_M003_ModelRepository.Add(ERP_M003_Model);
            this.runtimeService.Commit();
        }

        public void Delete(Guid Id)
        {
            var existstb_Sys_Menu = this.GetById(Id);
            this.ERP_M003_ModelRepository.Delete(existstb_Sys_Menu);
            this.runtimeService.Commit();
        }

        public void Update(ERP_M003_Model ERP_M003_Model)
        {
        	ERP_M003_Model.ModifyDt = DateTime.Now;
            tb_Sys_User tempUser = appCacheService.GetItem("user") as tb_Sys_User;
            ERP_M003_Model.ModifyUser = tempUser.UserName;
            ERP_M003_Model.Validate();
            var existstb_Sys_Menu = this.GetById(ERP_M003_Model.Id);
            this.ERP_M003_ModelRepository.SetValues(ERP_M003_Model, existstb_Sys_Menu);
            this.runtimeService.Commit();
        }

        public List<ERP_M003_Model> GetList(PagingModel pagingModel, DateTime? beginDate, DateTime? endDate)
        {
            var q = this.ERP_M003_ModelRepository.GetMany(i => true);
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


        public List<ERP_M003_Model_Product> GetProductListByModelCode(string modelCode)
        {
            var q = modelProductRepository.GetMany(i => i.ModelCode == modelCode);
            return q.ToList();
        }


        public void MarkDeleteProduct(Guid id)
        {
            var existsPro = this.modelProductRepository.GetByID(id);
            if (existsPro != null)
                this.modelProductRepository.Delete(existsPro);
        }


        public void Save(ERP_M003_Model ERP_M003_Model, List<ERP_M003_Model_Product> modelProductList)
        {
            tb_Sys_User tempUser = appCacheService.GetItem("user") as tb_Sys_User;
            var existsModel = this.GetById(ERP_M003_Model.Id);
            if (existsModel == null)
            {
                ERP_M003_Model.CompCode = tempUser.CompCode;
                ERP_M003_Model.CreateDt = DateTime.Now;
                ERP_M003_Model.CreateUser = tempUser.UserName;
                ERP_M003_Model.Validate();
                this.ERP_M003_ModelRepository.Add(ERP_M003_Model);
            }
            else
            {
                ERP_M003_Model.ModifyDt = DateTime.Now;
                ERP_M003_Model.ModifyUser = tempUser.UserName;
                ERP_M003_Model.Validate();
                this.ERP_M003_ModelRepository.SetValues(ERP_M003_Model, existsModel);
            }
            if (modelProductList != null)
            {
                foreach (var product in modelProductList)
                {
                    var existstproduct = this.modelProductRepository.GetByID(product.Id);
                    if (existstproduct == null)
                    {
                        product.CompCode = tempUser.CompCode;
                        product.CreateDt = DateTime.Now;
                        product.CreateUser = tempUser.UserName;
                        product.Validate();
                        this.modelProductRepository.Add(product);
                    }
                    else
                    {
                        product.ModifyDt = DateTime.Now;
                        product.ModifyUser = tempUser.UserName;
                        product.Validate();
                        this.modelProductRepository.SetValues(product, existstproduct);
                    }
                }
            }
        }


        public List<InputItem> GetSupplierData()
        {
            var q = this.supplierRepository.GetMany(i => true).ToList();
            var q2 = q.Select(i => new InputItem { DisPlayName = i.SuppName, Value = i.SuppCode, InputCode1 = i.SuppCode, InputCode2 = Util.PinYin.GetCodstring(i.SuppName) });
            return q2.ToList();
        }
    }
}