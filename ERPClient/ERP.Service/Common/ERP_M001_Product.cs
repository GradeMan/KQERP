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
	public interface IProductService
	{
		ERP_M001_Product GetById(Guid Id);
        ERP_M001_Product GetByPartNo(string partNo);
        List<ERP_M001_Product> GetList();
        List<ERP_M001_Product> GetListByItemType(string itemType);

		List<ERP_M001_Product> GetList(PagingModel pagingModel);
        void Create(ERP_M001_Product ERP_M001_Product);
        void Update(ERP_M001_Product ERP_M001_Product);
        void Delete(Guid Id);
        void DeleteCustPack(Guid id); //标记为删除，不立即执行
        void DeleteFile(Guid id);//标记为删除，不立即执行
        void DeleteMaterial(Guid id);//标记为删除，不立即执行
        void DeleteProcessFlow(Guid id);//标记为删除，不立即执行
        void DeleteProdInfo(Guid id);//标记为删除，不立即执行
        //void CreateCustPack(Guid id);
        //void CreateFile(Guid id);
        //void CreateMaterial(Guid id);
        //void CreateProcessFlow(Guid id);
        //void CreateCustPack(Guid id);
        //void Create(ERP_M001_Product ERP_M001_Product, List<ERP_M001_Product_CustPack> custPackList,List<ERP_M001_Product_File> fileList,List<ERP_M001_Product_Material> materialList,List<ERP_M001_Product_ProcessFlow> processFlowList,List<ERP_M001_Product_ProdInfo> prodInfoList);
        void Save(ERP_M001_Product ERP_M001_Product, List<ERP_M001_Product_Material> materialList, List<ERP_M001_Product_PackInfo> packInfoList, List<ERP_M001_Product_SemiProduct> semiProdList);
        List<ERP_M001_Product_CustPack> GetCustPackListByProdutCode(string itemCode);
        List<ERP_M001_Product_File> GetProductFileByProdutCode(string itemCode);
        List<ERP_M001_Product_Material> GetMaterialByProdutCode(string itemCode);
        List<ERP_M001_Product_ProcessFlow> GetProcessFlowByProdutCode(string itemCode);
        List<ERP_M001_Product_ProdInfo> GetProdInfoByProdutCode(string itemCode);
        List<ERP_M001_Product_PackInfo> GetPackInfoByPartNo(string partNo);
        List<ERP_M001_Product_SemiProduct> GetProductSemiByPartNo(string partNo);
        List<InputItem> GetProductInputData();

	}
    public class ProductService : IProductService
	{
		private IERP_M001_ProductRepository ERP_M001_ProductRepository;
        private IERP_M001_Product_CustPackRepository custPackRepository;
        private IERP_M001_Product_FileRepository fileRepository;
        private IERP_M001_Product_MaterialRepository materialRepository;
        private IERP_M001_Product_ProcessFlowRepository processFlowRepository;
        private IERP_M001_Product_ProdInfoRepository prodInfoReopsitory;
        private IERP_M001_Product_PackInfoRepository packInfoRepository;
        private IERP_C001_CodeRepository codeRepository;
        private IERP_M001_Product_SemiProductRepository semiProductRepository;
		private IUnitOfWork runtimeService;
		private ICacheServiceBase appCacheService = Unity.Instance.GetService<ICacheServiceBase>();
        public ProductService(IDatabaseFactory dbfactory)
		{
			this.runtimeService = new UnitOfWork(dbfactory);
			this.ERP_M001_ProductRepository = new ERP_M001_ProductRepository(dbfactory);
            this.custPackRepository = new ERP_M001_Product_CustPackRepository(dbfactory);
            this.fileRepository = new ERP_M001_Product_FileRepository(dbfactory);
            this.materialRepository = new ERP_M001_Product_MaterialRepository(dbfactory);
            this.processFlowRepository = new ERP_M001_Product_ProcessFlowRepository(dbfactory);
            this.prodInfoReopsitory = new ERP_M001_Product_ProdInfoRepository(dbfactory);
            this.codeRepository = new ERP_C001_CodeRepository(dbfactory);
            this.packInfoRepository = new ERP_M001_Product_PackInfoRepository(dbfactory);
            this.semiProductRepository = new ERP_M001_Product_SemiProductRepository(dbfactory);
		}

		public List<ERP_M001_Product> GetList()
        {
            var q = this.ERP_M001_ProductRepository.GetMany(i => true);
            return q.ToList();
        }

        public ERP_M001_Product GetById(Guid Id)
        {
            return this.ERP_M001_ProductRepository.GetByID(Id);
        }
        public ERP_M001_Product GetByPartNo(string partNo)
        {
            var q = this.ERP_M001_ProductRepository.GetMany(i => i.PartNo == partNo).SingleOrDefault();
            return q;
        }
        
        public void Create(ERP_M001_Product ERP_M001_Product)
        {
        	ERP_M001_Product.CreateDt = DateTime.Now;
            tb_Sys_User tempUser = appCacheService.GetItem("user") as tb_Sys_User;
            ERP_M001_Product.CreateUser = tempUser.UserName;
            ERP_M001_Product.CompCode = tempUser.CompCode;
            ERP_M001_Product.Validate();
			this.ERP_M001_ProductRepository.Add(ERP_M001_Product);
            //foreach (var custpack in productViewModel.CustPackList)
            //    this.custPackRepository.Add(custpack);
            this.runtimeService.Commit();
        }
        /// <summary>
        /// bia
        /// </summary>
        /// <param name="Id"></param>
        public void Delete(Guid Id)
        {
            var existstb_Sys_Menu = this.GetById(Id);
            this.ERP_M001_ProductRepository.Delete(existstb_Sys_Menu);
            this.runtimeService.Commit();
        }
        /// <summary>
        /// 标记CustPack为删除
        /// </summary>
        /// <param name="id"></param>
        public void DeleteCustPack(Guid id)
        {
            var existsCustPack = this.custPackRepository.GetByID(id);
            if (existsCustPack != null)
                this.custPackRepository.Delete(existsCustPack);
            //this.runtimeService.Commit();
        }
        //标记File为删除
        public void DeleteFile(Guid id)
        {
            var existsFile = this.fileRepository.GetByID(id);
            if (existsFile != null)
                this.fileRepository.Delete(existsFile);
        }
        public void DeleteMaterial(Guid id)
        {
            var existsTemp = this.materialRepository.GetByID(id);
            if (existsTemp != null)
                this.materialRepository.Delete(existsTemp);
        }

        public void DeleteProcessFlow(Guid id)
        {
            var existsTemp = this.processFlowRepository.GetByID(id);
            if (existsTemp != null)
                this.processFlowRepository.Delete(existsTemp);
        }

        public void DeleteProdInfo(Guid id)
        {
            var existsTemp = this.prodInfoReopsitory.GetByID(id);
            if (existsTemp != null)
                this.prodInfoReopsitory.Delete(existsTemp);
        }

        public void Update(ERP_M001_Product ERP_M001_Product)
        {
        	ERP_M001_Product.ModifyDt = DateTime.Now;
            tb_Sys_User tempUser = appCacheService.GetItem("user") as tb_Sys_User;
            ERP_M001_Product.ModifyUser = tempUser.UserName;
            ERP_M001_Product.Validate();
            var existstb_Sys_Menu = this.GetById(ERP_M001_Product.Id);
            this.ERP_M001_ProductRepository.SetValues(ERP_M001_Product, existstb_Sys_Menu);
            this.runtimeService.Commit();
        }

        public List<ERP_M001_Product> GetList(PagingModel pagingModel)
        {
            var q = this.ERP_M001_ProductRepository.GetMany(i => true);
            q = q.OrderByDescending(i => i.CreateDt);
            q = q.Paging(pagingModel);
            return q.ToList();
        }

        /// <summary>
        /// 根据产品itemCode获取CustPack
        /// </summary>
        /// <param name="itemCode"></param>
        /// <returns></returns>
        public List<ERP_M001_Product_CustPack> GetCustPackListByProdutCode(string itemCode)
        {
            var q = this.custPackRepository.GetMany(i => i.ItemCode == itemCode);
            return q.ToList();
        }
        /// <summary>
        /// 根据产品itemCode获取Semi
        /// </summary>
        /// <param name="itemCode"></param>
        /// <returns></returns>
        public List<ERP_M001_Product_SemiProduct> GetProductSemiByPartNo(string partNo)
        {
            var q = this.semiProductRepository.GetMany(i => i.PartNo == partNo);
            return q.ToList();
        }
        /// <summary>
        /// 根据产品itemCode获取File
        /// </summary>
        /// <param name="itemCode"></param>
        /// <returns></returns>
        public List<ERP_M001_Product_File> GetProductFileByProdutCode(string itemCode)
        {
            var q = this.fileRepository.GetMany(i => i.ItemCode == itemCode);
            return q.ToList();
        }
        public List<ERP_M001_Product_Material> GetMaterialByProdutCode(string itemCode)
        {
            var q = this.materialRepository.GetMany(i => i.ProductCode == itemCode);
            return q.ToList();
        }

        public List<ERP_M001_Product_ProcessFlow> GetProcessFlowByProdutCode(string itemCode)
        {
            var q = this.processFlowRepository.GetMany(i => i.ItemCode == itemCode);
            return q.ToList();
        }

        public List<ERP_M001_Product_ProdInfo> GetProdInfoByProdutCode(string itemCode)
        {
            var q = this.prodInfoReopsitory.GetMany(i => i.ItemCode == itemCode);
            return q.ToList();
        }
        public List<ERP_M001_Product_PackInfo> GetPackInfoByPartNo(string partNo)
        {
            var q = this.packInfoRepository.GetMany(i => i.PartNo == partNo);
            return q.ToList();
        }
        public void Save(ERP_M001_Product ERP_M001_Product, List<ERP_M001_Product_Material> materialList, List<ERP_M001_Product_PackInfo> packInfoList, List<ERP_M001_Product_SemiProduct> semiProdList)
        {
            tb_Sys_User tempUser = appCacheService.GetItem("user") as tb_Sys_User;
            var existsProduct = this.GetById(ERP_M001_Product.Id);
            if (existsProduct == null)
            {
                ERP_M001_Product.CreateDt = DateTime.Now;
                ERP_M001_Product.CreateUser = tempUser.UserName;
                ERP_M001_Product.CompCode = tempUser.CompCode;
                ERP_M001_Product.Validate();
                this.ERP_M001_ProductRepository.Add(ERP_M001_Product);
            }
            else
            {
                ERP_M001_Product.ModifyDt = DateTime.Now;
                ERP_M001_Product.ModifyUser = tempUser.UserName;
                ERP_M001_Product.Validate();
                this.ERP_M001_ProductRepository.SetValues(ERP_M001_Product, existsProduct);
            }
            if (packInfoList != null)
            {
                foreach (var file in packInfoList)
                {
                    var existstfile = this.packInfoRepository.GetByID(file.Id);
                    if (existstfile == null)
                    {
                        file.CompCode = tempUser.CompCode;
                        file.CreateDt = DateTime.Now;
                        file.CreateUser = tempUser.UserName;
                        file.Validate();
                        this.packInfoRepository.Add(file);
                    }
                    else
                    {
                        file.ModifyDt = DateTime.Now;
                        file.ModifyUser = tempUser.UserName;
                        file.Validate();
                        this.packInfoRepository.SetValues(file, existstfile);
                    }
                }
            }
            if (materialList != null)
            {
                foreach (var material in materialList)
                {
                    var existstmaterial = this.materialRepository.GetByID(material.Id);
                    if (existstmaterial == null)
                    {
                        material.CompCode = tempUser.CompCode;
                        material.CreateDt = DateTime.Now;
                        material.CreateUser = tempUser.UserName;
                        material.Validate();
                        this.materialRepository.Add(material);
                    }
                    else
                    {
                        material.ModifyDt = DateTime.Now;
                        material.ModifyUser = tempUser.UserName;
                        material.Validate();
                        this.materialRepository.SetValues(material, existstmaterial);
                    }
                }
            }
            if (semiProdList != null)
            {
                foreach (var processFlow in semiProdList)
                {
                    var existsttemp = this.semiProductRepository.GetByID(processFlow.Id);
                    if (existsttemp == null)
                    {
                        processFlow.CompCode = tempUser.CompCode;
                        processFlow.CreateDt = DateTime.Now;
                        processFlow.CreateUser = tempUser.UserName;
                        processFlow.Validate();
                        this.semiProductRepository.Add(processFlow);
                    }
                    else
                    {
                        processFlow.ModifyDt = DateTime.Now;
                        processFlow.ModifyUser = tempUser.UserName;
                        processFlow.Validate();
                        this.semiProductRepository.SetValues(processFlow, existsttemp);
                    }
                }
            }
           
            this.runtimeService.Commit();
        }


        public List<InputItem> GetProductInputData()
        {
            var q = this.ERP_M001_ProductRepository.GetMany(i => i.PartNo!=null && i.PartName!=null).Select(a => new { a.PartName, a.PartNo,a.PartDescription }).ToList();
            var q2 = q.Select(i => new InputItem { DisPlayName = i.PartName, Value = i.PartNo, InputCode1 = i.PartNo, InputCode2 = i.PartDescription });
            return q2.OrderBy(a=>a.DisPlayName).ToList();
        }


        public List<ERP_M001_Product> GetListByItemType(string itemType)
        {
            var q = this.ERP_M001_ProductRepository.GetMany(i => i.PartType == itemType);
            return q.ToList();
        }
    }
}