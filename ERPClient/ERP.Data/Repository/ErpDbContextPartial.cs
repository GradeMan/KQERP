using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Configuration;
using ERP.Domain;
namespace ERP.Data
{
    public partial class ErpDbContext:DbContext
    {

        private void RegistEntityMap(ConfigurationRegistrar configuration)
        {
            this.RegistEntityMapSystem(configuration);
            this.RegistEntityMapProduct(configuration);
            this.RegistEntityMapOrder(configuration);
            this.RegistEntityMapWMS(configuration);
            this.RegistEntityMapFile(configuration);
            this.RegistEntityMapESOP(configuration);
            this.RegistEntityMapSupplier(configuration);
        }

        #region 1.0 系统权限 System
        public DbSet<tb_Sys_User> tb_Sys_UserSet { get; set; }
        public DbSet<tb_Sys_UserRole> tb_Sys_UserRoleSet { get; set; }
        public DbSet<tb_Sys_Menu> tb_Sys_MenuSet { get; set; }
        public DbSet<tb_Sys_Roles> tb_Sys_RolesSet { get; set; }
        public DbSet<tb_Sys_RolesRight> tb_Sys_RolesRightSet { get; set; }
        public DbSet<tb_Sys_RolesBtn> tb_Sys_RolesBtnSet { get; set; }
        public DbSet<tb_Sys_Button> tb_Sys_ButtonSet { get; set; }
        public DbSet<tb_Sys_Controls> tb_Sys_ControlsSet { get; set; }
        public DbSet<tb_Sys_RolesControl> tb_Sys_RolesControlSet { get; set; }
        #endregion

        #region 2.0 基础模块 Common
        public DbSet<ERP_C001_Code> ERP_C001_CodeSet { get; set; }
        public DbSet<ERP_C002_Company> tb_C001_CompanySet { get; set; }
        public DbSet<ERP_C003_Customer> ERP_C003_CustomerSet { get; set; }
        public DbSet<ERP_C004_Supplier> ERP_C004_SupplierSet { get; set; }
        public DbSet<ERP_C005_Employee> tb_C005_EmployeeSet { get; set; }
        public DbSet<ERP_C006_ProcessFlow> ERP_C006_ProcessFlowSet { get; set; }
        public DbSet<ERP_C006_ProcessFlow_Process> ERP_C006_ProcessFlow_ProcessSet { get; set; }
        public DbSet<ERP_C006_ProcessFlow_ProdInfo> ERP_C006_ProcessFlow_ProdInfoSet { get; set; }
        public DbSet<ERP_C006_ProcessProdInfo> ERP_C006_ProcessProdInfoSet { get; set; }
        public DbSet<ERP_C009_Layout> ERP_C009_LayoutSet { get; set; }
        public DbSet<ERP_C001_CodeDictionary> ERP_C001_CodeDictionarySet { get; set; }
        private void RegistEntityMapSystem(ConfigurationRegistrar configuration)
        {
            configuration.Add(new tb_Sys_MenuMap())
                .Add(new tb_Sys_UserMap())
                .Add(new tb_Sys_UserRoleMap())
                .Add(new tb_Sys_RolesMap())
                .Add(new tb_Sys_RolesRightMap())
                .Add(new tb_Sys_RolesBtnMap())
                .Add(new tb_Sys_ButtonMap())
                .Add(new tb_Sys_RolesControlMap())
                .Add(new tb_Sys_ControlsMap())
                .Add(new tb_C001_CompanyMap())
                .Add(new ERP_C001_CodeMap())
                .Add(new ERP_C001_CodeDictionaryMap())
                .Add(new ERP_C003_CustomerMap())
                .Add(new ERP_C004_SupplierMap())
                .Add(new ERP_C006_ProcessFlowMap())
                .Add(new ERP_C005_EmployeeMap())
                .Add(new ERP_C006_ProcessFlow_ProcessMap())
                .Add(new ERP_C006_ProcessFlow_ProdInfoMap())
                .Add(new ERP_C006_ProcessProdInfoMap())
                .Add(new ERP_C009_LayoutMap());

        }
        #endregion

        #region 3.0 产品模块
        public DbSet<ERP_M001_Product> ERP_M001_ProductSet { get; set; }
        public DbSet<ERP_M001_Product_CustPack> ERP_M001_Product_CustPackSet { get; set; }
        public DbSet<ERP_M001_Product_File> ERP_M001_Product_FileSet { get; set; }
        public DbSet<ERP_M001_Product_Material> ERP_M001_Product_MaterialSet { get; set; }
        public DbSet<ERP_M001_Product_ProcessFlow> ERP_M001_Product_ProcessFlowSet { get; set; }
        public DbSet<ERP_M001_Product_ProdInfo> ERP_M001_Product_ProdInfoSet { get; set; }
        public DbSet<ERP_M002_Material> ERP_M002_MaterialSet { get; set; }
        public DbSet<ERP_M003_Model> ERP_M003_ModelSet { get; set; }
        public DbSet<ERP_M003_Model_Product> ERP_M003_Model_ProductSet { get; set; }
        public DbSet<ERP_M004_QHProduct> ERP_M004_QHProductSet { get; set; }
        public DbSet<ERP_M001_Product_PackInfo> ERP_M001_Product_PackInfoSet { get; set; }
        public DbSet<ERP_M001_Product_SemiProduct> ERP_M001_Product_SemiProductSet { get; set; }
        public DbSet<MES_M801_Label_L> MES_M801_Label_LSet { get; set; }
        public DbSet<MES_M801_Label_M> MES_M801_Label_MSet { get; set; }
        public DbSet<MES_M801_Label_S> MES_M801_Label_SSet { get; set; }
        public DbSet<MES_M801_Label_L_PrintData> MES_M801_Label_L_PrintDataSet { get; set; }
        public DbSet<MES_M801_Label_M_PrintData> MES_M801_Label_M_PrintDataSet { get; set; }
        public DbSet<MES_M801_Label_S_PrintData> MES_M801_Label_S_PrintDataSet { get; set; }
        public DbSet<MES_M802_Packing_Hd> MES_M802_Packing_HdSet { get; set; }
        public DbSet<MES_M802_Packing_Dtl> MES_M802_Packing_DtlSet { get; set; }
        private void RegistEntityMapProduct(ConfigurationRegistrar configuration)
        {
            configuration.Add(new ERP_M001_ProductMap())
                .Add(new ERP_M001_Product_CustPackMap())
                .Add(new ERP_M001_Product_FileMap())
                .Add(new ERP_M001_Product_MaterialMap())
                .Add(new ERP_M001_Product_ProcessFlowMap())
                .Add(new ERP_M001_Product_ProdInfoMap())
                .Add(new ERP_M002_MaterialMap())
                .Add(new ERP_M003_ModelMap())
                .Add(new ERP_M003_Model_ProductMap())
                .Add(new ERP_M004_QHProductMap())
                .Add(new ERP_M001_Product_PackInfoMap())
                .Add(new ERP_M001_Product_SemiProductMap())
                .Add(new MES_M801_Label_LMap())
                .Add(new MES_M801_Label_MMap())
                .Add(new MES_M801_Label_SMap())
                .Add(new MES_M801_Label_L_PrintDataMap())
                .Add(new MES_M801_Label_M_PrintDataMap())
                .Add(new MES_M801_Label_S_PrintDataMap())
                .Add(new MES_M802_Packing_DtlMap())
                .Add(new MES_M802_Packing_HdMap());
        }
        #endregion

        #region 4.0 订单模块
        public DbSet<MES_M001_Order> MES_M001_OrderSet { get; set; }
        public DbSet<MES_M001_Order_Detail> MES_M001_Order_DetailSet { get; set; }
        public DbSet<MES_M002_Job> MES_M002_JobSet { get; set; }
        public DbSet<MES_M002_Job_Lot> MES_M002_Job_LotSet { get; set; }
        public DbSet<MES_M003_LotTx> MES_M003_LotTxSet { get; set; }
        public DbSet<MES_M003_LotTx_NG> MES_M003_LotTx_NGSet { get; set; }
        public DbSet<MES_M003_LotTx_NG_Clone> MES_M003_LotTx_NG_CloneSet { get; set; }
        public DbSet<vw_JobReport> vw_JobReportSet { get; set; }
        public DbSet<MES_M002_Job_Lot_Process> MES_M002_Job_Lot_ProcessSet { get; set; }
        public DbSet<MES_M201_Plan> MES_M201_PlanSet { get; set; }
        public DbSet<MES_M201_Plan_Detail> MES_M201_Plan_DetailSet { get; set; }
        public DbSet<MES_M201_Plan_Material> MES_M201_Plan_MaterialSet { get; set; }
        public DbSet<MES_M201_Plan_Daily> MES_M201_Plan_DailySet { get; set; }
        public DbSet<MES_M202_Task> MES_M202_TaskSet { get; set; }
        public DbSet<MES_M202_Task_Detail> MES_M202_Task_DetailSet { get; set; }
        public DbSet<MES_M202_Task_JobLot> MES_M202_Task_JobLotSet { get; set; }
        public DbSet<MES_M501_JobTx> MES_M501_JobTxSet { get; set; }
        public DbSet<MES_M501_JobTx_NG> MES_M501_JobTx_NGSet { get; set; }
        public DbSet<MES_M501_JobTxDetail> MES_M501_JobTxDetailSet { get; set; }
        public DbSet<MES_M501_JobTxProdInfo> MES_M501_JobTxProdInfoSet { get; set; }
        private void RegistEntityMapOrder(ConfigurationRegistrar configuration)
        {
            configuration.Add(new MES_M001_OrderMap())
                .Add(new MES_M001_Order_DetailMap())
                .Add(new MES_M002_JobMap())
                .Add(new MES_M002_Job_LotMap())
                .Add(new MES_M003_LotTxMap())
                .Add(new MES_M003_LotTx_NGMap())
                .Add(new MES_M003_LotTx_NG_CloneMap())
                .Add(new vw_JobReportMap())
                .Add(new MES_M002_Job_Lot_ProcessMap())
                .Add(new MES_M201_PlanMap())
                .Add(new MES_M201_Plan_DetailMap())
                .Add(new MES_M201_Plan_MaterialMap())
                .Add(new MES_M201_Plan_DailyMap())
                .Add(new MES_M202_TaskMap())
                .Add(new MES_M202_Task_DetailMap())
                .Add(new MES_M202_Task_JobLotMap())
                .Add(new MES_M501_JobTxMap())
                .Add(new MES_M501_JobTxDetailMap())
                .Add(new MES_M501_JobTx_NGMap())
                .Add(new MES_M501_JobTxProdInfoMap());

        }
        #endregion

        #region 5.0 仓库模块
        public DbSet<WMS_C101_WareHouse> WMS_C101_WareHouseSet { get; set; }
        public DbSet<WMS_C102_Area> WMS_C102_AreaSet { get; set; }
        public DbSet<WMS_C103_Shelf> WMS_C103_ShelfSet { get; set; }
        public DbSet<WMS_M001_Product> WMS_M001_ProductSet { get; set; }
        public DbSet<WMS_M002_StockTx> WMS_M002_StockTxSet { get; set; }
        public DbSet<WMS_C101_InStore> WMS_C101_InStoreSet { get; set; }
        public DbSet<WMS_C102_InStoreDetail> WMS_C102_InStoreDetailSet { get; set; }
        public DbSet<WMS_C103_Stock> WMS_C103_StockSet { get; set; }
        public DbSet<WMS_C104_OutStore> WMS_C104_OutStoreSet { get; set; }
        public DbSet<WMS_C105_OutStoreDetail> WMS_C105_OutStoreDetailSet { get; set; }
        public DbSet<WMS_M101_StockTx_Data> WMS_M101_StockTx_DataSet { get; set; }
        public DbSet<WMS_M104_Packing_Hd> WMS_M104_Packing_HdSet { get; set; }
        public DbSet<WMS_M104_Packing_Detail> WMS_M104_Packing_DetailSet { get; set; }
        public DbSet<WMS_MatConsume_ActMat> WMS_MatConsume_ActMatSet { get; set; }
        public DbSet<WMS_MatConsume_ActMatDetail> WMS_MatConsume_ActMatDetailSet { get; set; }
        public DbSet<WMS_MatConsume_ActMatMouthCheck> WMS_MatConsume_ActMatMouthCheckSet { get; set; }
        public DbSet<WMS_M105_MatGet> WMS_M105_MatGetSet { get; set; }
        public DbSet<WMS_M105_MatGetDetail> WMS_M105_MatGetDetailSet { get; set; }
        public DbSet<WMS_M105_MatReturn> WMS_M105_MatReturnSet { get; set; }
        public DbSet<WMS_M105_MatReturnDetail> WMS_M105_MatReturnDetailSet { get; set; }
        public DbSet<WMS_M105_MatSotre> WMS_M105_MatSotreSet { get; set; }
        private void RegistEntityMapWMS(ConfigurationRegistrar configuration)
        {
            configuration.Add(new WMS_C101_WareHouseMap())
                .Add(new WMS_C102_AreaMap())
                .Add(new WMS_C103_ShelfMap())
                .Add(new WMS_M001_ProductMap())
                .Add(new WMS_M002_StockTxMap())
                .Add(new WMS_C101_InStoreMap())
                .Add(new WMS_C102_InStoreDetailMap())
                .Add(new WMS_C103_StockMap())
                .Add(new WMS_C104_OutStoreMap())
                .Add(new WMS_C105_OutStoreDetailMap())
                .Add(new WMS_M101_StockTx_DataMap())
                .Add(new WMS_M104_Packing_HdMap())
                .Add(new WMS_M104_Packing_DetailMap())
                .Add(new WMS_MatConsume_ActMatMap())
                .Add(new WMS_MatConsume_ActMatDetailMap())
                .Add(new WMS_MatConsume_ActMatMouthCheckMap())
                .Add(new WMS_M105_MatGetMap())
                .Add(new WMS_M105_MatGetDetailMap())
                .Add(new WMS_M105_MatReturnMap())
                .Add(new WMS_M105_MatReturnDetailMap())
                .Add(new WMS_M105_MatSotreMap());

        }
        #endregion

        #region 6.0 文件管理模块
        public DbSet<FTP_F002_File> FTP_F002_FileSet { get; set; }
        public DbSet<FTP_F003_RolesRight> FTP_F003_RolesRightSet { get; set; }

        private void RegistEntityMapFile(ConfigurationRegistrar configuration)
        {
            configuration.Add(new FTP_F002_FileMap())
                .Add(new FTP_F003_RolesRightMap());
        }
        #endregion

        #region 7.0 设备管理模块
        public DbSet<DEV_D001_Device> DEV_D001_DeviceSet { get; set; }
        public DbSet<DEV_D001_Device_File> DEV_D001_Device_FileSet { get; set; }
        public DbSet<DEV_D001_Device_Appurten> DEV_D001_Device_AppurtenSet { get; set; }
        private void RegistEntityMapDevice(ConfigurationRegistrar configuration)
        {
            configuration.Add(new DEV_D001_DeviceMap())
                .Add(new DEV_D001_Device_FileMap())
                .Add(new DEV_D001_Device_AppurtenMap());
        } 
        #endregion

        #region 8.0 ESOP管理模块
        public DbSet<ESOP_Device> ESOP_DeviceSet { get; set; }
        public DbSet<ESOP_Product> ESOP_ProductSet { get; set; }
        public DbSet<ESOP_Publish> ESOP_PublishSet { get; set; }
        public DbSet<ESOP_Doc> ESOP_DocSet { get; set; }
        public DbSet<ESOP_DocIndex> ESOP_DocIndexSet { get; set; }
        public DbSet<ESOP_DocIndex_Sec> ESOP_DocIndex_SecSet { get; set; }
        public DbSet<ESOP_RoleDevice> ESOP_RoleDeviceSet { get; set; }
        private void RegistEntityMapESOP(ConfigurationRegistrar configuration)
        {
            configuration.Add(new ESOP_DeviceMap())
                .Add(new ESOP_ProductMap())
                .Add(new ESOP_PublishMap())
                .Add(new ESOP_DocMap())
                .Add(new ESOP_DocIndexMap())
                .Add(new ESOP_DocIndex_SecMap())
                .Add(new ESOP_RoleDeviceMap());
               
        }
        #endregion

        #region 9.0 供应商管理模块
        public DbSet<ERP_C003_Supplier> ERP_C003_SupplierSet { get; set; }
        public DbSet<ERP_M001_Material> ERP_M001_MaterialSet { get; set; }
        public DbSet<ERP_M001_Material_Supp> ERP_M001_Material_SuppSet { get; set; }
        public DbSet<SUPP_M001_PurPlan> SUPP_M001_PurPlanSet { get; set; }
        public DbSet<SUPP_M001_PurPlan_Material> SUPP_M001_PurPlan_MaterialSet { get; set; }
        public DbSet<ERP_M002_BOM> ERP_M002_BOMSet { get; set; }
        public DbSet<ERP_M002_BOM_Material> ERP_M002_BOM_MaterialSet { get; set; }
        public DbSet<ERP_C003_Supplier_File> ERP_C003_Supplier_FileSet { get; set; }
        public DbSet<SUPP_M001_PurPlan_Detail> SUPP_M001_PurPlan_DetailSet { get; set; }
        private void RegistEntityMapSupplier(ConfigurationRegistrar configuration)
        {
            configuration.Add(new ERP_C003_SupplierMap())
                .Add(new ERP_M001_MaterialMap())
                .Add(new ERP_M001_Material_SuppMap())
                .Add(new SUPP_M001_PurPlanMap())
                .Add(new SUPP_M001_PurPlan_MaterialMap())
                .Add(new ERP_M002_BOMMap())
                .Add(new ERP_M002_BOM_MaterialMap())
                .Add(new ERP_C003_Supplier_FileMap())
                .Add(new SUPP_M001_PurPlan_DetailMap());

        }
        #endregion
    }
}
