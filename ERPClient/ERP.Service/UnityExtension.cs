using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Util;
using ERP.Data;

namespace ERP.Service
{
    static public class UnityExtension
    {
        static public IUnity RegisterERPService(this IUnity unity)
        {
            RegisterSystemService(unity);
            RegisterSysModule(unity);
            RegisterCommonModule(unity);
            RegisterProductModule(unity);
            RegisterOrderModule(unity);
            RegisterWMSModule(unity);
            RegisterFileModule(unity);
            RegisterESOPModule(unity);
            RegisterSupplierModule(unity);
            RegisterViewModule(unity);
            return unity;
        }
        #region 11 视图模块
        private static void RegisterViewModule(IUnity unity)
        {
            unity.Register<IViewService, ViewService>();
        } 
        #endregion

        #region 10.0 供应商管理模块
        private static void RegisterSupplierModule(IUnity unity)
        {
            unity.Register<IERP_C003_SupplierRepository, ERP_C003_SupplierRepository>()
                .Register<IERP_C003_SupplierService, ERP_C003_SupplierService>()
                .Register<IERP_M001_MaterialRepository, ERP_M001_MaterialRepository>()
                .Register<IERP_M001_MaterialService, ERP_M001_MaterialService>()
                .Register<IERP_M001_Material_SuppRepository, ERP_M001_Material_SuppRepository>()
                .Register<IERP_M001_Material_SuppService, ERP_M001_Material_SuppService>()
                .Register<ISUPP_M001_PurPlan_MaterialRepository, SUPP_M001_PurPlan_MaterialRepository>()
                .Register<ISUPP_M001_PurPlan_MaterialService, SUPP_M001_PurPlan_MaterialService>()
                .Register<ISUPP_M001_PurPlanRepository, SUPP_M001_PurPlanRepository>()
                .Register<ISUPP_M001_PurPlanService, SUPP_M001_PurPlanService>()
                .Register<IERP_M002_BOMRepository, ERP_M002_BOMRepository>()
                .Register<IERP_M002_BOMService, ERP_M002_BOMService>()
                .Register<IERP_M002_BOM_MaterialRepository, ERP_M002_BOM_MaterialRepository>()
                .Register<IERP_M002_BOM_MaterialService, ERP_M002_BOM_MaterialService>()
                .Register<IERP_C003_Supplier_FileRepository, ERP_C003_Supplier_FileRepository>()
                .Register<IERP_C003_Supplier_FileService, ERP_C003_Supplier_FileService>()
                .Register<ISUPP_M001_PurPlan_DetailRepository, SUPP_M001_PurPlan_DetailRepository>()
                .Register<ISUPP_M001_PurPlan_DetailService, SUPP_M001_PurPlan_DetailService>();
        }
        #endregion

        #region 9.0 ESOP管理模块
        private static void RegisterESOPModule(IUnity unity)
        {
            unity.Register<IESOP_DeviceRepository, ESOP_DeviceRepository>()
                .Register<IESOP_DeviceService, ESOP_DeviceService>()
                .Register<IESOP_ProductRepository,ESOP_ProductRepository>()
                .Register<IESOP_ProductService,ESOP_ProductService>()
                .Register<IESOP_PublishRepository, ESOP_PublishRepository>()
                .Register<IESOP_PublishService, ESOP_PublishService>()
                .Register<IESOP_DocIndexRepository, ESOP_DocIndexRepository>()
                .Register<IESOP_DocIndexService, ESOP_DocIndexService>()
                .Register<IESOP_DocRepository, ESOP_DocRepository>()
                .Register<IESOP_DocService, ESOP_DocService>()
                .Register<IESOP_DocIndex_SecRepository, ESOP_DocIndex_SecRepository>()
                .Register<IESOP_RoleDeviceRepository,ESOP_RoleDeviceRepository>();
        }
        #endregion

        #region 8.0 设备管理模块
        private static void RegisterDeviceModule(IUnity unity)
        {
            unity.Register<IDEV_D001_DeviceRepository, DEV_D001_DeviceRepository>()
                .Register<IDEV_D001_DeviceService, DEV_D001_DeviceService>()
                .Register<IDEV_D001_Device_FileRepository, DEV_D001_Device_FileRepository>()
                .Register<IDEV_D001_Device_AppurtenRepository, DEV_D001_Device_AppurtenRepository>();
        }

        #endregion

        #region 7.0 文档模块
        private static void RegisterFileModule(IUnity unity)
        {
            unity .Register<IFTP_F002_FileRepository, FTP_F002_FileRepository>()
                .Register<IFileService, FileService>()
                .Register<IFTP_F003_RolesRightRepository, FTP_F003_RolesRightRepository>()
                .Register<IFileRolesRightService, FileRolesRightService>();
        } 
        #endregion

        #region 6.0 注册仓库模块
        private static void RegisterWMSModule(IUnity unity)
        {
            unity.Register<IWMSWareHouseService, WMSWareHouseService>()
               .Register<IWMS_C101_WareHouseRepository, WMS_C101_WareHouseRepository>()
               .Register<IWMS_C102_AreaRepository, WMS_C102_AreaRepository>()
               .Register<IWMSAreaService, WMSAreaService>()
               .Register<IWMS_C103_ShelfRepository, WMS_C103_ShelfRepository>()
               .Register<IWMSShelfService, WMSShelfService>()
               .Register<IWMS_M001_ProductRepository, WMS_M001_ProductRepository>()
               .Register<IWMSProductService, WMSProductService>()
               .Register<IWMS_M002_StockTxRepository, WMS_M002_StockTxRepository>()
               .Register<IWMSStockTxService, WMSStockTxService>()
               .Register<IWMS_C101_InStoreRepository, WMS_C101_InStoreRepository>()
               .Register<IWMS_C101_InStoreService, WMS_C101_InStoreService>()
               .Register<IWMS_C102_InStoreDetailRepository, WMS_C102_InStoreDetailRepository>()
               .Register<IWMS_C102_InStoreDetailService, WMS_C102_InStoreDetailService>()
               .Register<IWMS_C103_StockRepository, WMS_C103_StockRepository>()
               .Register<IWMS_C103_StockService, WMS_C103_StockService>()
               .Register<IWMS_C104_OutStoreRepository, WMS_C104_OutStoreRepository>()
               .Register<IWMS_C104_OutStoreService, WMS_C104_OutStoreService>()
               .Register<IWMS_C105_OutStoreDetailRepository, WMS_C105_OutStoreDetailRepository>()
               .Register<IWMS_C105_OutStoreDetailService, WMS_C105_OutStoreDetailService>()
               .Register<IWMS_M101_StockTx_DataRepository, WMS_M101_StockTx_DataRepository>()
               .Register<IWMS_M101_StockTx_DataService, WMS_M101_StockTx_DataService>()
               .Register<IWMS_M104_Packing_HdService, WMS_M104_Packing_HdService>()
               .Register<IWMS_M105_MatGetService, WMS_M105_MatGetService>()
               .Register<IWMS_M105_MatReturnService, WMS_M105_MatReturnService>()
               .Register<IWMS_M105_MatSotreService, WMS_M105_MatSotreService>();
            
        }
        #endregion

        #region 5.0 注册订单模块
        /// <summary>
        /// 注册订单模块
        /// </summary>
        /// <param name="unity"></param>
        private static void RegisterOrderModule(IUnity unity)
        {
            unity.Register<IOrderService, OrderService>()
                .Register<IOrderRepository, OrderRepository>()
                .Register<IOrderDetailService, OrderDetailService>()
                .Register<IOrderDetailRepository, OrderDetailRepository>()
                .Register<IJobService, JobService>()
                .Register<IJobRepository, JobRepository>()
                .Register<IJobLotService, JobLotService>()
                .Register<IJobLotRepository, JobLotRepository>()
                .Register<ILotTxService, LotTxService>()
                .Register<ILotTxRepository, LotTxRepository>()
                .Register<ILotTxNGService, LotTxNGService>()
                .Register<ILotTxNGRepository, LotTxNGRepository>()
                .Register<IMES_M003_LotTx_NG_CloneRepository, MES_M003_LotTx_NG_CloneRepository>()
                .Register<ILotTx_NG_CloneService, LotTx_NG_CloneService>()
                .Register<Ivw_JobReportRepository, vw_JobReportRepository>()
                .Register<IJobReportService, JobReportService>()
                .Register<IJobLotProcessService, JobLotProcessService>()
                .Register<IMES_M002_Job_Lot_ProcessRepository, MES_M002_Job_Lot_ProcessRepository>()
                .Register<IMES_M201_PlanService, MES_M201_PlanService>()
                .Register<IMES_M201_PlanRepository, MES_M201_PlanRepository>()
                .Register<IMES_M201_Plan_DetailService, MES_M201_Plan_DetailService>()
                .Register<IMES_M201_Plan_DetailRepository, MES_M201_Plan_DetailRepository>()
                .Register<IMES_M201_Plan_MaterialService, MES_M201_Plan_MaterialService>()
                .Register<IMES_M201_Plan_MaterialRepository, MES_M201_Plan_MaterialRepository>()
                .Register<IMES_M201_Plan_DailyRepository,MES_M201_Plan_DailyRepository>()
		        .Register<IMES_M202_TaskService, MES_M202_TaskService>()
                .Register<IMES_M202_TaskRepository, MES_M202_TaskRepository>()
		        .Register<IMES_M202_Task_DetailService, MES_M202_Task_DetailService>()
                .Register<IMES_M202_Task_DetailRepository, MES_M202_Task_DetailRepository>()
                .Register<IMES_M202_Task_JobLotRepository, MES_M202_Task_JobLotRepository>()
                .Register<IMES_M202_Task_JobLotService, MES_M202_Task_JobLotService>()
		        .Register<IMES_M501_JobTxService, MES_M501_JobTxService>()
                .Register<IMES_M501_JobTxRepository, MES_M501_JobTxRepository>()
                .Register<IMES_M501_JobTxProdInfoRepository, MES_M501_JobTxProdInfoRepository>();
                
        } 
        #endregion

        #region 4.0 注册产品模块
        /// <summary>
        /// 注册产品模块
        /// </summary>
        /// <param name="unity"></param>
        private static void RegisterProductModule(IUnity unity)
        {
            unity.Register<IProductService, ProductService>()
                .Register<IProductCustPackService, ProductCustPackService>()
                .Register<IProductFileService, ProductFileService>()
                .Register<IERP_M001_Product_MaterialService, ERP_M001_Product_MaterialService>()
                .Register<IProductProcessFlowService, ProductProcessFlowService>()
                .Register<IProductProdInfoService, ProductProdInfoService>()
                .Register<IMaterialService, MaterialService>()
                .Register<IModelService, ModelService>()
                .Register<IModelProductService, ModelProductService>()
                .Register<IQHProductService, QHProductService>()
                .Register<IERP_M001_Product_PackInfoService, ERP_M001_Product_PackInfoService>()
                .Register<IERP_M001_Product_SemiProductService, ERP_M001_Product_SemiProductService>()
                .Register<IMES_M801_Label_LService, MES_M801_Label_LService>()
                .Register<IMES_M801_Label_MService, MES_M801_Label_MService>()
                .Register<IMES_M801_Label_SService, MES_M801_Label_SService>()
                .Register<IMES_M501_JobTxService, MES_M501_JobTxService>()
                .Register<IMES_M501_JobTx_NGService, MES_M501_JobTx_NGService>()
                .Register<IMES_M802_Packing_HdService, MES_M802_Packing_HdService>()
                .Register<IMES_M802_Packing_DtlService, MES_M802_Packing_DtlService>();
        } 
        #endregion

        #region 3.0 注册基本模块
        /// <summary>
        /// 注册基本模块
        /// </summary>
        /// <param name="unity"></param>
        private static void RegisterCommonModule(IUnity unity)
        {
            unity.Register<ICompanyService, CompanyService>()
                .Register<Itb_C001_CompanyRepository, tb_C001_CompanyRepository>()
                 .Register<IEmployeeService, EmployeeService>()
                .Register<IERP_C005_EmployeeRepository, ERP_C005_EmployeeRepository>()
                .Register<ICodeService, CodeService>()
                .Register<IERP_C001_CodeRepository, ERP_C001_CodeRepository>()
                .Register<IERP_C001_CodeDictionaryService,ERP_C001_CodeDictionaryService>()
                .Register<IERP_C003_CustomerRepository, ERP_C003_CustomerRepository>()
                .Register<ICustomerService, CustomerService>()
                .Register<ISupplierService, SupplierService>()
                .Register<IERP_C004_SupplierRepository, ERP_C004_SupplierRepository>()
                .Register<IProcessFlowService, ProcessFlowService>()
                .Register<IERP_C006_ProcessFlowRepository, ERP_C006_ProcessFlowRepository>()
                .Register<IERP_C006_ProcessFlow_ProcessRepository, ERP_C006_ProcessFlow_ProcessRepository>()
                .Register<IERP_C006_ProcessFlow_ProcessService, ERP_C006_ProcessFlow_ProcessService>()
                .Register<IERP_C006_ProcessProdInfoService, ERP_C006_ProcessProdInfoService>()
                .Register<IERP_C006_ProcessFlow_ProdInfoService, ERP_C006_ProcessFlow_ProdInfoService>()
                .Register<IERP_C009_LayoutService, ERP_C009_LayoutService>();


        } 
        #endregion

        #region 2.0 注册系统基本模块
        /// <summary>
        /// 注册系统基本模块
        /// </summary>
        /// <param name="unity"></param>
        private static void RegisterSystemService(IUnity unity)
        {
            unity
                .Register<IDatabaseFactory, DatabaseFactory>()
                .Register<IUnitOfWork, UnitOfWork>()
                .Register<IRuntimeService, RuntimeService>()
                .Register<IAppLoginService, AppLoginService>()
               // .Register<IDatabaseFactory, KQDatabaseFactory>()
                ;
        } 
        #endregion

        #region 1.0 注册系统相关模块
        /// <summary>
        /// 注册系统相关模块
        /// </summary>
        /// <param name="unity"></param>
        private static void RegisterSysModule(IUnity unity)
        {
            unity
                .Register<Itb_Sys_UserService, tb_Sys_UserService>()
                .Register<Itb_Sys_UserRepository, tb_Sys_UserRepository>()

                .Register<Itb_Sys_RolesService, tb_Sys_RolesService>()
                .Register<Itb_Sys_RolesRepository, tb_Sys_RolesRepository>()

                .Register<Itb_Sys_UserRoleService, tb_Sys_UserRoleService>()
                .Register<Itb_Sys_UserRoleRepository, tb_Sys_UserRoleRepository>()

                .Register<Itb_Sys_RolesRightService, tb_Sys_RolesRightService>()
                .Register<Itb_Sys_RolesRightRepository, tb_Sys_RolesRightRepository>()

                .Register<Itb_Sys_MenuService, tb_Sys_MenuService>()
                .Register<Itb_Sys_MenuRepository, tb_Sys_MenuRepository>()

                .Register<Itb_Sys_ButtonService, tb_Sys_ButtonService>()
                .Register<Itb_Sys_ButtonRepository, tb_Sys_ButtonRepository>()

                .Register<Itb_Sys_RolesBtnService, tb_Sys_RolesBtnService>()
                .Register<Itb_Sys_RolesBtnRepository, tb_Sys_RolesBtnRepository>()

                .Register<Itb_Sys_RolesControlRepository,tb_Sys_RolesControlRepository>()
                .Register<Itb_Sys_RolesControlService,tb_Sys_RolesControlService>()

                .Register<Itb_Sys_ControlsRepository,tb_Sys_ControlsRepository>()
                .Register<Itb_Sys_ControlsService,tb_Sys_ControlsService>()
                
                ;
        } 
        #endregion

    }

}
