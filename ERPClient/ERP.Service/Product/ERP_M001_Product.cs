using System;
using System.Linq;
using System.Collections.Generic;
using COM.Data;
using ERP.Data;
using ERP.Domain;
using COM.Service;
using COM.Domain;
using System.Text;
using System.Data.Common;
using System.Data.SqlClient;
using Util;
namespace ERP.Service
{
	public interface IProductService
	{
		ERP_M001_Product GetById(Guid Id);
        ERP_M001_Product GetByPartNo(string partNo);
        List<ERP_M001_Product> GetList();
        List<ERP_M001_Product> GetListByItemType(string itemType);

		List<ERP_M001_Product> GetList(PagingModel pagingModel);
        IQueryable<ERP_M001_Product> GetProduct();

        void Create(ERP_M001_Product ERP_M001_Product);
        void Update(ERP_M001_Product ERP_M001_Product);
        void Delete(Guid Id);
        void DeleteCustPack(Guid id); //标记为删除，不立即执行
        void DeleteFile(Guid id);//标记为删除，不立即执行
        void DeleteMaterial(Guid id);//标记为删除，不立即执行
        void DeleteProcessFlow(Guid id);//标记为删除，不立即执行
        void DeleteProdInfo(Guid id);//标记为删除，不立即执行
        void DeletePackInfo(Guid id);//标记为删除，不立即执行
        //void CreateCustPack(Guid id);
        //void CreateFile(Guid id);
        //void CreateMaterial(Guid id);
        //void CreateProcessFlow(Guid id);
        //void CreateCustPack(Guid id);
        //void Create(ERP_M001_Product ERP_M001_Product, List<ERP_M001_Product_CustPack> custPackList,List<ERP_M001_Product_File> fileList,List<ERP_M001_Product_Material> materialList,List<ERP_M001_Product_ProcessFlow> processFlowList,List<ERP_M001_Product_ProdInfo> prodInfoList);
       //产品，物料，包装，半成品，制程，制程参数
        void Save(ERP_M001_Product ERP_M001_Product, List<ERP_M001_Product_Material> materialList, List<ERP_M001_Product_PackInfo> packInfoList, List<ERP_M001_Product_SemiProduct> semiProdList,List<ERP_M001_Product_ProcessFlow> processList,List<ERP_M001_Product_ProdInfo> prodInfoList);
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
        public IQueryable<ERP_M001_Product> GetProduct()
        {
            return ERP_M001_ProductRepository.GetMany(i => true);
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
            var q = this.ERP_M001_ProductRepository.GetMany(i => i.PartNo == partNo).FirstOrDefault();
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
            if (existstb_Sys_Menu != null)
            {
                StringBuilder strSql = new StringBuilder();
                strSql.Append(@"    Delete ERP_M001_Product where PartNo=@PartNo
                                    Delete ERP_M001_Product_Material where ProductCode = @PartNo
                                    Delete ERP_M001_Product_PackInfo where PartNo = @PartNo
                                    Delete ERP_M001_Product_Process where PartNo = @PartNo
                                    Delete ERP_M001_Product_ProdInfo where PartNo = @PartNo
                                    Delete ERP_M001_Product_SemiProduct where PartNo = @PartNo  ");
                var partNoParam = new SqlParameter
                {
                    ParameterName = "PartNo",
                    Value = existstb_Sys_Menu.PartNo
                };
                this.ERP_M001_ProductRepository.GetDbContext().Database.ExecuteSqlCommand(strSql.ToString(), partNoParam);
            }
            //this.ERP_M001_ProductRepository.Delete(existstb_Sys_Menu);
            //this.runtimeService.Commit();
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
        public void DeletePackInfo(Guid id)
        {
            var existsTemp = this.packInfoRepository.GetByID(id);
            if (existsTemp != null)
                this.packInfoRepository.Delete(existsTemp);
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
            var q = this.processFlowRepository.GetMany(i => i.PartNo == itemCode);
            return q.ToList();
        }

        public List<ERP_M001_Product_ProdInfo> GetProdInfoByProdutCode(string itemCode)
        {
            var q = this.prodInfoReopsitory.GetMany(i => i.PartNo == itemCode);
            return q.ToList();
        }
        public List<ERP_M001_Product_PackInfo> GetPackInfoByPartNo(string partNo)
        {
            var q = this.packInfoRepository.GetMany(i => i.PartNo == partNo);
            return q.ToList();
        }
        public void Save(ERP_M001_Product ERP_M001_Product, List<ERP_M001_Product_Material> materialList, List<ERP_M001_Product_PackInfo> packInfoList, List<ERP_M001_Product_SemiProduct> semiProdList, List<ERP_M001_Product_ProcessFlow> processList, List<ERP_M001_Product_ProdInfo> prodInfoList)
        {
            tb_Sys_User tempUser = appCacheService.GetItem("user") as tb_Sys_User;
            var existsProduct = this.GetById(ERP_M001_Product.Id);
            if (existsProduct == null)
            {
                var existPartNo = this.GetByPartNo(ERP_M001_Product.PartNo);
                if (existPartNo != null)
                    throw new AppException("产品代号已存在，请检查");
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
                //string sql = string.Format("Delete ERP_M001_Product_PackInfo where PartNo = '{0}'", ERP_M001_Product.PartNo);
                //this.packInfoRepository.GetDbContext().Database.ExecuteSqlCommand(sql);
                foreach (var packInfo in packInfoList)
                {
                    var existsPackInfo = this.packInfoRepository.GetByID(packInfo.Id);
                    if (existsPackInfo == null)
                    {
                        packInfo.CompCode = tempUser.CompCode;
                        packInfo.CreateDt = DateTime.Now;
                        packInfo.CreateUser = tempUser.UserName;
                        packInfo.PartNo = ERP_M001_Product.PartNo;
                        packInfo.Validate();
                        this.packInfoRepository.Add(packInfo);
                    }
                    else
                    {
                        packInfo.ModifyDt = DateTime.Now;
                        packInfo.ModifyUser = tempUser.UserName;
                        packInfo.Validate();
                        this.packInfoRepository.SetValues(packInfo, existsPackInfo);
                    }

                }
            }
            if (materialList != null)
            {
                //string sql = string.Format("Delete ERP_M001_Product_Material where ProductCode = '{0}'", ERP_M001_Product.PartNo);
                //this.materialRepository.GetDbContext().Database.ExecuteSqlCommand(sql);
                foreach (var material in materialList)
                {
                    var existsmaterial = this.materialRepository.GetByID(material.Id);
                    if (existsmaterial == null)
                    {
                        material.CompCode = tempUser.CompCode;
                        material.CreateDt = DateTime.Now;
                        material.CreateUser = tempUser.UserName;
                        material.ProductCode = ERP_M001_Product.PartNo;
                        material.Validate();
                        this.materialRepository.Add(material);
                    }
                    else
                    {
                        material.ModifyDt = DateTime.Now;
                        material.ModifyUser = tempUser.UserName;
                        material.Validate();
                        this.materialRepository.SetValues(material, existsmaterial);
                    }

                }
            }
            if (semiProdList != null)
            {
                //string sql = string.Format("Delete ERP_M001_Product_SemiProduct where PartNo = '{0}'", ERP_M001_Product.PartNo);
                //this.semiProductRepository.GetDbContext().Database.ExecuteSqlCommand(sql);
                foreach (var semiProd in semiProdList)
                {
                    var existssemiProd = this.semiProductRepository.GetByID(semiProd.Id);
                    if (existssemiProd == null)
                    {
                        semiProd.CompCode = tempUser.CompCode;
                        semiProd.CreateDt = DateTime.Now;
                        semiProd.CreateUser = tempUser.UserName;
                        semiProd.PartNo = ERP_M001_Product.PartNo;
                        semiProd.Validate();
                        this.semiProductRepository.Add(semiProd);
                    }
                    else
                    {
                        semiProd.ModifyDt = DateTime.Now;
                        semiProd.ModifyUser = tempUser.UserName;
                        semiProd.Validate();
                        this.semiProductRepository.SetValues(semiProd, existssemiProd);
                    }
                }
            }
            if (processList != null)
            {
                string sql = string.Format("Delete ERP_M001_Product_Process where PartNo = '{0}'", ERP_M001_Product.PartNo);
                this.processFlowRepository.GetDbContext().Database.ExecuteSqlCommand(sql);
                foreach (var processDetail in processList)
                {
                    processDetail.PartNo = ERP_M001_Product.PartNo;
                    processDetail.PFCode = ERP_M001_Product.ProcessFlow;
                    processDetail.CompCode = tempUser.CompCode;
                    processDetail.PartNo = ERP_M001_Product.PartNo;
                    processDetail.Validate();
                    this.processFlowRepository.Add(processDetail);
                }
            }
            if (prodInfoList != null)
            {
                string sql = string.Format("Delete ERP_M001_Product_ProdInfo where PartNo = '{0}'", ERP_M001_Product.PartNo);
                prodInfoReopsitory.GetDbContext().Database.ExecuteSqlCommand(sql);
                foreach (var prodInfo in prodInfoList)
                {
                    prodInfo.CompCode = ERP_M001_Product.PartNo;
                    prodInfo.PFCode = ERP_M001_Product.ProcessFlow;
                    prodInfo.CompCode = tempUser.CompCode;
                    prodInfo.PartNo = ERP_M001_Product.PartNo;
                    prodInfo.Validate();
                    this.prodInfoReopsitory.Add(prodInfo);
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