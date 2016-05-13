namespace ERP.Winform.MES
{
    partial class MES201PlanForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MES201PlanForm));
            this.mESM201PlanBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.mESM201PlanDetailBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.mESM201PlanDailyBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.dockManager1 = new DevExpress.XtraBars.Docking.DockManager(this.components);
            this.dockPanel1 = new DevExpress.XtraBars.Docking.DockPanel();
            this.dockPanel1_Container = new DevExpress.XtraBars.Docking.ControlContainer();
            this.txtPlanNo = new DevExpress.XtraEditors.TextEdit();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.txtProdDt2 = new DevExpress.XtraEditors.DateEdit();
            this.btnSearch = new DevExpress.XtraEditors.SimpleButton();
            this.txtProdDt1 = new DevExpress.XtraEditors.DateEdit();
            this.xtraTabControl1 = new DevExpress.XtraTab.XtraTabControl();
            this.xtraTabPage1 = new DevExpress.XtraTab.XtraTabPage();
            this.pivotGridControl1 = new DevExpress.XtraPivotGrid.PivotGridControl();
            this.planDetailDtoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.fieldPLevel1 = new DevExpress.XtraPivotGrid.PivotGridField();
            this.fieldPLNo1 = new DevExpress.XtraPivotGrid.PivotGridField();
            this.fieldSOQty1 = new DevExpress.XtraPivotGrid.PivotGridField();
            this.fieldCustCode1 = new DevExpress.XtraPivotGrid.PivotGridField();
            this.fieldPartNo1 = new DevExpress.XtraPivotGrid.PivotGridField();
            this.fieldPartName1 = new DevExpress.XtraPivotGrid.PivotGridField();
            this.fieldPartSpec1 = new DevExpress.XtraPivotGrid.PivotGridField();
            this.fieldDetailType1 = new DevExpress.XtraPivotGrid.PivotGridField();
            this.fieldUnit1 = new DevExpress.XtraPivotGrid.PivotGridField();
            this.fieldDetailQty1 = new DevExpress.XtraPivotGrid.PivotGridField();
            this.fieldFQty1 = new DevExpress.XtraPivotGrid.PivotGridField();
            this.fieldAdJustQty1 = new DevExpress.XtraPivotGrid.PivotGridField();
            this.fieldSumQty1 = new DevExpress.XtraPivotGrid.PivotGridField();
            this.fieldTxDt1 = new DevExpress.XtraPivotGrid.PivotGridField();
            this.fieldDailyQty1 = new DevExpress.XtraPivotGrid.PivotGridField();
            this.xtraTabPage2 = new DevExpress.XtraTab.XtraTabPage();
            this.gridControl2 = new DevExpress.XtraGrid.GridControl();
            this.gridMaterial = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridView();
            this.gridBand1 = new DevExpress.XtraGrid.Views.BandedGrid.GridBand();
            this.bandedGridColumn1 = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.bandedGridColumn2 = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.bandedGridColumn3 = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.colCustAlias = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.bandedGridColumn4 = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.bandedGridColumn5 = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.bandedGridColumn6 = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.bandedGridColumn7 = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.bandedGridColumn8 = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.colPlanDetailId = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.bandedGridColumn9 = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.bandedGridColumn10 = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.bandedGridColumn11 = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.bandedGridColumn12 = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.bandedGridColumn13 = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.bandedGridColumn14 = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.gridBand2 = new DevExpress.XtraGrid.Views.BandedGrid.GridBand();
            this.colMatCode = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.colMatName = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.colMatSpec = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.colSuppCode = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.bandedGridColumn15 = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.colUnitPrice = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.colUnitConsume = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.bandedGridColumn16 = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.repositoryItemMaterial = new DevExpress.XtraEditors.Repository.RepositoryItemGridLookUpEdit();
            this.gridView3 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridView2 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.ykGridControl1 = new COM.YKControls.YKGridControl();
            this.gridPlan = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colCompCode = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPLNo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPLDt = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPLType = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colRemarks = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colModifyDt = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colModifyUser = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCreateDt = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCreateUser = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colId = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPLAuditing = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPLAuditingDt = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colState = new DevExpress.XtraGrid.Columns.GridColumn();
            this.splitContainerControl1 = new DevExpress.XtraEditors.SplitContainerControl();
            this.fieldSONo = new DevExpress.XtraPivotGrid.PivotGridField();
            ((System.ComponentModel.ISupportInitialize)(this.mESM201PlanBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mESM201PlanDetailBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mESM201PlanDailyBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dockManager1)).BeginInit();
            this.dockPanel1.SuspendLayout();
            this.dockPanel1_Container.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtPlanNo.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtProdDt2.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtProdDt2.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtProdDt1.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtProdDt1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabControl1)).BeginInit();
            this.xtraTabControl1.SuspendLayout();
            this.xtraTabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pivotGridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.planDetailDtoBindingSource)).BeginInit();
            this.xtraTabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridMaterial)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemMaterial)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ykGridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridPlan)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl1)).BeginInit();
            this.splitContainerControl1.SuspendLayout();
            this.SuspendLayout();
            // 
            // mESM201PlanBindingSource
            // 
            this.mESM201PlanBindingSource.DataSource = typeof(ERP.Domain.MES_M201_Plan);
            // 
            // mESM201PlanDetailBindingSource
            // 
            this.mESM201PlanDetailBindingSource.DataSource = typeof(ERP.Domain.MES_M201_Plan_Detail);
            // 
            // mESM201PlanDailyBindingSource
            // 
            this.mESM201PlanDailyBindingSource.DataSource = typeof(ERP.Domain.MES_M201_Plan_Daily);
            // 
            // gridView1
            // 
            this.gridView1.Name = "gridView1";
            // 
            // dockManager1
            // 
            this.dockManager1.Form = this;
            this.dockManager1.MenuManager = this.barManager1;
            this.dockManager1.RootPanels.AddRange(new DevExpress.XtraBars.Docking.DockPanel[] {
            this.dockPanel1});
            this.dockManager1.TopZIndexControls.AddRange(new string[] {
            "DevExpress.XtraBars.BarDockControl",
            "DevExpress.XtraBars.StandaloneBarDockControl",
            "System.Windows.Forms.StatusBar",
            "System.Windows.Forms.MenuStrip",
            "System.Windows.Forms.StatusStrip",
            "DevExpress.XtraBars.Ribbon.RibbonStatusBar",
            "DevExpress.XtraBars.Ribbon.RibbonControl",
            "DevExpress.XtraBars.Navigation.OfficeNavigationBar",
            "DevExpress.XtraBars.Navigation.TileNavPane"});
            // 
            // dockPanel1
            // 
            this.dockPanel1.Controls.Add(this.dockPanel1_Container);
            this.dockPanel1.Dock = DevExpress.XtraBars.Docking.DockingStyle.Top;
            this.dockPanel1.ID = new System.Guid("d62f95eb-368c-40d2-8d34-9359ee0902fb");
            this.dockPanel1.Location = new System.Drawing.Point(0, 0);
            this.dockPanel1.Name = "dockPanel1";
            this.dockPanel1.OriginalSize = new System.Drawing.Size(200, 89);
            this.dockPanel1.Size = new System.Drawing.Size(1149, 89);
            this.dockPanel1.Text = "搜索框";
            // 
            // dockPanel1_Container
            // 
            this.dockPanel1_Container.Controls.Add(this.txtPlanNo);
            this.dockPanel1_Container.Controls.Add(this.labelControl3);
            this.dockPanel1_Container.Controls.Add(this.labelControl2);
            this.dockPanel1_Container.Controls.Add(this.labelControl1);
            this.dockPanel1_Container.Controls.Add(this.txtProdDt2);
            this.dockPanel1_Container.Controls.Add(this.btnSearch);
            this.dockPanel1_Container.Controls.Add(this.txtProdDt1);
            this.dockPanel1_Container.Location = new System.Drawing.Point(4, 23);
            this.dockPanel1_Container.Name = "dockPanel1_Container";
            this.dockPanel1_Container.Size = new System.Drawing.Size(1141, 62);
            this.dockPanel1_Container.TabIndex = 0;
            // 
            // txtPlanNo
            // 
            this.txtPlanNo.Location = new System.Drawing.Point(443, 12);
            this.txtPlanNo.MenuManager = this.barManager1;
            this.txtPlanNo.Name = "txtPlanNo";
            this.txtPlanNo.Size = new System.Drawing.Size(158, 20);
            this.txtPlanNo.TabIndex = 24;
            // 
            // labelControl3
            // 
            this.labelControl3.Location = new System.Drawing.Point(385, 15);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(52, 14);
            this.labelControl3.TabIndex = 23;
            this.labelControl3.Text = "计划单号:";
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(199, 15);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(4, 14);
            this.labelControl2.TabIndex = 22;
            this.labelControl2.Text = "-";
            this.labelControl2.Click += new System.EventHandler(this.labelControl2_Click);
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(8, 15);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(52, 14);
            this.labelControl1.TabIndex = 21;
            this.labelControl1.Text = "计划日期:";
            this.labelControl1.Click += new System.EventHandler(this.labelControl1_Click);
            // 
            // txtProdDt2
            // 
            this.txtProdDt2.EditValue = null;
            this.txtProdDt2.Location = new System.Drawing.Point(209, 12);
            this.txtProdDt2.MenuManager = this.barManager1;
            this.txtProdDt2.Name = "txtProdDt2";
            this.txtProdDt2.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.txtProdDt2.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.txtProdDt2.Properties.Mask.EditMask = "";
            this.txtProdDt2.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.None;
            this.txtProdDt2.Size = new System.Drawing.Size(152, 20);
            this.txtProdDt2.TabIndex = 19;
            // 
            // btnSearch
            // 
            this.btnSearch.Image = ((System.Drawing.Image)(resources.GetObject("btnSearch.Image")));
            this.btnSearch.Location = new System.Drawing.Point(699, 7);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(75, 30);
            this.btnSearch.TabIndex = 20;
            this.btnSearch.Text = "查询";
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // txtProdDt1
            // 
            this.txtProdDt1.EditValue = null;
            this.txtProdDt1.Location = new System.Drawing.Point(68, 12);
            this.txtProdDt1.MenuManager = this.barManager1;
            this.txtProdDt1.Name = "txtProdDt1";
            this.txtProdDt1.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.txtProdDt1.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.txtProdDt1.Properties.Mask.EditMask = "";
            this.txtProdDt1.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.None;
            this.txtProdDt1.Size = new System.Drawing.Size(127, 20);
            this.txtProdDt1.TabIndex = 18;
            // 
            // xtraTabControl1
            // 
            this.xtraTabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.xtraTabControl1.Location = new System.Drawing.Point(0, 0);
            this.xtraTabControl1.Name = "xtraTabControl1";
            this.xtraTabControl1.SelectedTabPage = this.xtraTabPage1;
            this.xtraTabControl1.Size = new System.Drawing.Size(1149, 376);
            this.xtraTabControl1.TabIndex = 8;
            this.xtraTabControl1.TabPages.AddRange(new DevExpress.XtraTab.XtraTabPage[] {
            this.xtraTabPage1,
            this.xtraTabPage2});
            // 
            // xtraTabPage1
            // 
            this.xtraTabPage1.Controls.Add(this.pivotGridControl1);
            this.xtraTabPage1.Name = "xtraTabPage1";
            this.xtraTabPage1.Size = new System.Drawing.Size(1143, 347);
            this.xtraTabPage1.Text = "产品信息";
            // 
            // pivotGridControl1
            // 
            this.pivotGridControl1.DataSource = this.planDetailDtoBindingSource;
            this.pivotGridControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pivotGridControl1.Fields.AddRange(new DevExpress.XtraPivotGrid.PivotGridField[] {
            this.fieldPLevel1,
            this.fieldPLNo1,
            this.fieldSOQty1,
            this.fieldCustCode1,
            this.fieldPartNo1,
            this.fieldPartName1,
            this.fieldPartSpec1,
            this.fieldDetailType1,
            this.fieldUnit1,
            this.fieldDetailQty1,
            this.fieldFQty1,
            this.fieldAdJustQty1,
            this.fieldSumQty1,
            this.fieldTxDt1,
            this.fieldDailyQty1,
            this.fieldSONo});
            this.pivotGridControl1.Location = new System.Drawing.Point(0, 0);
            this.pivotGridControl1.Name = "pivotGridControl1";
            this.pivotGridControl1.Size = new System.Drawing.Size(1143, 347);
            this.pivotGridControl1.TabIndex = 0;
            // 
            // planDetailDtoBindingSource
            // 
            this.planDetailDtoBindingSource.DataSource = typeof(ERP.Service.Dtos.PlanDetailDto);
            // 
            // fieldPLevel1
            // 
            this.fieldPLevel1.Area = DevExpress.XtraPivotGrid.PivotArea.RowArea;
            this.fieldPLevel1.AreaIndex = 0;
            this.fieldPLevel1.Caption = "优先级";
            this.fieldPLevel1.FieldName = "PLevel";
            this.fieldPLevel1.Name = "fieldPLevel1";
            // 
            // fieldPLNo1
            // 
            this.fieldPLNo1.AreaIndex = 2;
            this.fieldPLNo1.Caption = "计划单号";
            this.fieldPLNo1.FieldName = "PLNo";
            this.fieldPLNo1.Name = "fieldPLNo1";
            // 
            // fieldSOQty1
            // 
            this.fieldSOQty1.Area = DevExpress.XtraPivotGrid.PivotArea.RowArea;
            this.fieldSOQty1.AreaIndex = 2;
            this.fieldSOQty1.Caption = "订单数量";
            this.fieldSOQty1.CellFormat.FormatString = "n0";
            this.fieldSOQty1.CellFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.fieldSOQty1.FieldName = "SOQty";
            this.fieldSOQty1.Name = "fieldSOQty1";
            // 
            // fieldCustCode1
            // 
            this.fieldCustCode1.Area = DevExpress.XtraPivotGrid.PivotArea.RowArea;
            this.fieldCustCode1.AreaIndex = 3;
            this.fieldCustCode1.Caption = "客户";
            this.fieldCustCode1.FieldName = "CustCode";
            this.fieldCustCode1.Name = "fieldCustCode1";
            // 
            // fieldPartNo1
            // 
            this.fieldPartNo1.Area = DevExpress.XtraPivotGrid.PivotArea.RowArea;
            this.fieldPartNo1.AreaIndex = 4;
            this.fieldPartNo1.Caption = "产品编号";
            this.fieldPartNo1.FieldName = "PartNo";
            this.fieldPartNo1.Name = "fieldPartNo1";
            // 
            // fieldPartName1
            // 
            this.fieldPartName1.Area = DevExpress.XtraPivotGrid.PivotArea.RowArea;
            this.fieldPartName1.AreaIndex = 5;
            this.fieldPartName1.Caption = "品名";
            this.fieldPartName1.FieldName = "PartName";
            this.fieldPartName1.Name = "fieldPartName1";
            // 
            // fieldPartSpec1
            // 
            this.fieldPartSpec1.AreaIndex = 0;
            this.fieldPartSpec1.Caption = "规格";
            this.fieldPartSpec1.FieldName = "PartSpec";
            this.fieldPartSpec1.Name = "fieldPartSpec1";
            // 
            // fieldDetailType1
            // 
            this.fieldDetailType1.AreaIndex = 1;
            this.fieldDetailType1.Caption = "类型";
            this.fieldDetailType1.FieldName = "DetailType";
            this.fieldDetailType1.Name = "fieldDetailType1";
            // 
            // fieldUnit1
            // 
            this.fieldUnit1.Area = DevExpress.XtraPivotGrid.PivotArea.RowArea;
            this.fieldUnit1.AreaIndex = 6;
            this.fieldUnit1.Caption = "单位";
            this.fieldUnit1.FieldName = "Unit";
            this.fieldUnit1.Name = "fieldUnit1";
            // 
            // fieldDetailQty1
            // 
            this.fieldDetailQty1.Area = DevExpress.XtraPivotGrid.PivotArea.RowArea;
            this.fieldDetailQty1.AreaIndex = 7;
            this.fieldDetailQty1.Caption = "数量";
            this.fieldDetailQty1.CellFormat.FormatString = "n0";
            this.fieldDetailQty1.CellFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.fieldDetailQty1.FieldName = "DetailQty";
            this.fieldDetailQty1.Name = "fieldDetailQty1";
            this.fieldDetailQty1.ValueFormat.FormatString = "n0";
            this.fieldDetailQty1.ValueFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            // 
            // fieldFQty1
            // 
            this.fieldFQty1.AreaIndex = 3;
            this.fieldFQty1.Caption = "完成数量";
            this.fieldFQty1.CellFormat.FormatString = "n0";
            this.fieldFQty1.CellFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.fieldFQty1.FieldName = "FQty";
            this.fieldFQty1.Name = "fieldFQty1";
            this.fieldFQty1.ValueFormat.FormatString = "n0";
            this.fieldFQty1.ValueFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            // 
            // fieldAdJustQty1
            // 
            this.fieldAdJustQty1.Area = DevExpress.XtraPivotGrid.PivotArea.RowArea;
            this.fieldAdJustQty1.AreaIndex = 8;
            this.fieldAdJustQty1.Caption = "调整数量";
            this.fieldAdJustQty1.CellFormat.FormatString = "n0";
            this.fieldAdJustQty1.CellFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.fieldAdJustQty1.FieldName = "AdJustQty";
            this.fieldAdJustQty1.Name = "fieldAdJustQty1";
            this.fieldAdJustQty1.ValueFormat.FormatString = "n0";
            this.fieldAdJustQty1.ValueFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            // 
            // fieldSumQty1
            // 
            this.fieldSumQty1.Area = DevExpress.XtraPivotGrid.PivotArea.RowArea;
            this.fieldSumQty1.AreaIndex = 9;
            this.fieldSumQty1.Caption = "总数量";
            this.fieldSumQty1.CellFormat.FormatString = "n0";
            this.fieldSumQty1.CellFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.fieldSumQty1.FieldName = "SumQty";
            this.fieldSumQty1.Name = "fieldSumQty1";
            this.fieldSumQty1.ValueFormat.FormatString = "n0";
            this.fieldSumQty1.ValueFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            // 
            // fieldTxDt1
            // 
            this.fieldTxDt1.Area = DevExpress.XtraPivotGrid.PivotArea.ColumnArea;
            this.fieldTxDt1.AreaIndex = 0;
            this.fieldTxDt1.Caption = "日期";
            this.fieldTxDt1.CellFormat.FormatString = "yyyy-MM-dd";
            this.fieldTxDt1.CellFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.fieldTxDt1.FieldName = "TxDt";
            this.fieldTxDt1.Name = "fieldTxDt1";
            this.fieldTxDt1.ValueFormat.FormatString = "yyyy-MM-dd";
            this.fieldTxDt1.ValueFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            // 
            // fieldDailyQty1
            // 
            this.fieldDailyQty1.Area = DevExpress.XtraPivotGrid.PivotArea.DataArea;
            this.fieldDailyQty1.AreaIndex = 0;
            this.fieldDailyQty1.Caption = "数量";
            this.fieldDailyQty1.CellFormat.FormatString = "N0";
            this.fieldDailyQty1.CellFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.fieldDailyQty1.FieldName = "DailyQty";
            this.fieldDailyQty1.Name = "fieldDailyQty1";
            // 
            // xtraTabPage2
            // 
            this.xtraTabPage2.Controls.Add(this.gridControl2);
            this.xtraTabPage2.Name = "xtraTabPage2";
            this.xtraTabPage2.Size = new System.Drawing.Size(1143, 347);
            this.xtraTabPage2.Text = "物料信息";
            // 
            // gridControl2
            // 
            this.gridControl2.Cursor = System.Windows.Forms.Cursors.Default;
            this.gridControl2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControl2.Location = new System.Drawing.Point(0, 0);
            this.gridControl2.MainView = this.gridMaterial;
            this.gridControl2.Name = "gridControl2";
            this.gridControl2.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryItemMaterial});
            this.gridControl2.Size = new System.Drawing.Size(1143, 347);
            this.gridControl2.TabIndex = 5;
            this.gridControl2.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridMaterial,
            this.gridView2});
            // 
            // gridMaterial
            // 
            this.gridMaterial.Bands.AddRange(new DevExpress.XtraGrid.Views.BandedGrid.GridBand[] {
            this.gridBand1,
            this.gridBand2});
            this.gridMaterial.Columns.AddRange(new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn[] {
            this.bandedGridColumn1,
            this.bandedGridColumn2,
            this.bandedGridColumn3,
            this.bandedGridColumn4,
            this.bandedGridColumn5,
            this.bandedGridColumn6,
            this.bandedGridColumn8,
            this.colPlanDetailId,
            this.colMatCode,
            this.colSuppCode,
            this.bandedGridColumn15,
            this.colUnitPrice,
            this.bandedGridColumn16,
            this.bandedGridColumn9,
            this.bandedGridColumn10,
            this.bandedGridColumn11,
            this.bandedGridColumn12,
            this.bandedGridColumn13,
            this.bandedGridColumn14,
            this.colMatName,
            this.colMatSpec,
            this.bandedGridColumn7,
            this.colUnitConsume,
            this.colCustAlias});
            this.gridMaterial.GridControl = this.gridControl2;
            this.gridMaterial.Name = "gridMaterial";
            this.gridMaterial.OptionsBehavior.ReadOnly = true;
            this.gridMaterial.OptionsView.AllowCellMerge = true;
            this.gridMaterial.OptionsView.ShowFooter = true;
            this.gridMaterial.OptionsView.ShowGroupPanel = false;
            // 
            // gridBand1
            // 
            this.gridBand1.AppearanceHeader.Options.UseTextOptions = true;
            this.gridBand1.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridBand1.Caption = "产品资料";
            this.gridBand1.Columns.Add(this.bandedGridColumn1);
            this.gridBand1.Columns.Add(this.bandedGridColumn2);
            this.gridBand1.Columns.Add(this.bandedGridColumn3);
            this.gridBand1.Columns.Add(this.colCustAlias);
            this.gridBand1.Columns.Add(this.bandedGridColumn4);
            this.gridBand1.Columns.Add(this.bandedGridColumn5);
            this.gridBand1.Columns.Add(this.bandedGridColumn6);
            this.gridBand1.Columns.Add(this.bandedGridColumn7);
            this.gridBand1.Columns.Add(this.bandedGridColumn8);
            this.gridBand1.Columns.Add(this.colPlanDetailId);
            this.gridBand1.Columns.Add(this.bandedGridColumn9);
            this.gridBand1.Columns.Add(this.bandedGridColumn10);
            this.gridBand1.Columns.Add(this.bandedGridColumn11);
            this.gridBand1.Columns.Add(this.bandedGridColumn12);
            this.gridBand1.Columns.Add(this.bandedGridColumn13);
            this.gridBand1.Columns.Add(this.bandedGridColumn14);
            this.gridBand1.Name = "gridBand1";
            this.gridBand1.VisibleIndex = 0;
            this.gridBand1.Width = 375;
            // 
            // bandedGridColumn1
            // 
            this.bandedGridColumn1.FieldName = "PlanId";
            this.bandedGridColumn1.Name = "bandedGridColumn1";
            // 
            // bandedGridColumn2
            // 
            this.bandedGridColumn2.FieldName = "PLNo";
            this.bandedGridColumn2.Name = "bandedGridColumn2";
            // 
            // bandedGridColumn3
            // 
            this.bandedGridColumn3.Caption = "客户";
            this.bandedGridColumn3.FieldName = "CustCode";
            this.bandedGridColumn3.Name = "bandedGridColumn3";
            this.bandedGridColumn3.OptionsColumn.AllowMerge = DevExpress.Utils.DefaultBoolean.True;
            // 
            // colCustAlias
            // 
            this.colCustAlias.Caption = "客户";
            this.colCustAlias.FieldName = "CustAlias";
            this.colCustAlias.Name = "colCustAlias";
            this.colCustAlias.Visible = true;
            // 
            // bandedGridColumn4
            // 
            this.bandedGridColumn4.Caption = "产品编码";
            this.bandedGridColumn4.FieldName = "PartNo";
            this.bandedGridColumn4.Name = "bandedGridColumn4";
            this.bandedGridColumn4.OptionsColumn.AllowMerge = DevExpress.Utils.DefaultBoolean.True;
            this.bandedGridColumn4.Visible = true;
            // 
            // bandedGridColumn5
            // 
            this.bandedGridColumn5.Caption = "产品名称";
            this.bandedGridColumn5.FieldName = "PartName";
            this.bandedGridColumn5.Name = "bandedGridColumn5";
            this.bandedGridColumn5.OptionsColumn.AllowMerge = DevExpress.Utils.DefaultBoolean.True;
            this.bandedGridColumn5.Visible = true;
            // 
            // bandedGridColumn6
            // 
            this.bandedGridColumn6.Caption = "产品规格";
            this.bandedGridColumn6.FieldName = "PartSpec";
            this.bandedGridColumn6.Name = "bandedGridColumn6";
            this.bandedGridColumn6.OptionsColumn.AllowMerge = DevExpress.Utils.DefaultBoolean.True;
            this.bandedGridColumn6.Visible = true;
            // 
            // bandedGridColumn7
            // 
            this.bandedGridColumn7.Caption = "产品数量";
            this.bandedGridColumn7.DisplayFormat.FormatString = "n0";
            this.bandedGridColumn7.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.bandedGridColumn7.FieldName = "SumQty";
            this.bandedGridColumn7.Name = "bandedGridColumn7";
            this.bandedGridColumn7.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum)});
            this.bandedGridColumn7.Visible = true;
            // 
            // bandedGridColumn8
            // 
            this.bandedGridColumn8.FieldName = "CompCode";
            this.bandedGridColumn8.Name = "bandedGridColumn8";
            // 
            // colPlanDetailId
            // 
            this.colPlanDetailId.FieldName = "PlanDetailId";
            this.colPlanDetailId.Name = "colPlanDetailId";
            // 
            // bandedGridColumn9
            // 
            this.bandedGridColumn9.FieldName = "Remarks";
            this.bandedGridColumn9.Name = "bandedGridColumn9";
            // 
            // bandedGridColumn10
            // 
            this.bandedGridColumn10.FieldName = "ModifyDt";
            this.bandedGridColumn10.Name = "bandedGridColumn10";
            // 
            // bandedGridColumn11
            // 
            this.bandedGridColumn11.FieldName = "ModifyUser";
            this.bandedGridColumn11.Name = "bandedGridColumn11";
            // 
            // bandedGridColumn12
            // 
            this.bandedGridColumn12.FieldName = "CreateDt";
            this.bandedGridColumn12.Name = "bandedGridColumn12";
            // 
            // bandedGridColumn13
            // 
            this.bandedGridColumn13.FieldName = "CreateUser";
            this.bandedGridColumn13.Name = "bandedGridColumn13";
            // 
            // bandedGridColumn14
            // 
            this.bandedGridColumn14.FieldName = "Id";
            this.bandedGridColumn14.Name = "bandedGridColumn14";
            // 
            // gridBand2
            // 
            this.gridBand2.AppearanceHeader.Options.UseTextOptions = true;
            this.gridBand2.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridBand2.Caption = "物料资料";
            this.gridBand2.Columns.Add(this.colMatCode);
            this.gridBand2.Columns.Add(this.colMatName);
            this.gridBand2.Columns.Add(this.colMatSpec);
            this.gridBand2.Columns.Add(this.colSuppCode);
            this.gridBand2.Columns.Add(this.bandedGridColumn15);
            this.gridBand2.Columns.Add(this.colUnitPrice);
            this.gridBand2.Columns.Add(this.colUnitConsume);
            this.gridBand2.Columns.Add(this.bandedGridColumn16);
            this.gridBand2.Name = "gridBand2";
            this.gridBand2.VisibleIndex = 1;
            this.gridBand2.Width = 525;
            // 
            // colMatCode
            // 
            this.colMatCode.Caption = "物料编码";
            this.colMatCode.FieldName = "MatCode";
            this.colMatCode.Name = "colMatCode";
            this.colMatCode.OptionsColumn.AllowMerge = DevExpress.Utils.DefaultBoolean.False;
            this.colMatCode.Visible = true;
            // 
            // colMatName
            // 
            this.colMatName.Caption = "物料名称";
            this.colMatName.FieldName = "MatName";
            this.colMatName.Name = "colMatName";
            this.colMatName.OptionsColumn.AllowMerge = DevExpress.Utils.DefaultBoolean.False;
            this.colMatName.Visible = true;
            // 
            // colMatSpec
            // 
            this.colMatSpec.Caption = "物料规格";
            this.colMatSpec.FieldName = "MatSpec";
            this.colMatSpec.Name = "colMatSpec";
            this.colMatSpec.OptionsColumn.AllowMerge = DevExpress.Utils.DefaultBoolean.False;
            this.colMatSpec.Visible = true;
            // 
            // colSuppCode
            // 
            this.colSuppCode.Caption = "供应商";
            this.colSuppCode.FieldName = "SuppCode";
            this.colSuppCode.Name = "colSuppCode";
            this.colSuppCode.OptionsColumn.AllowMerge = DevExpress.Utils.DefaultBoolean.False;
            this.colSuppCode.Visible = true;
            // 
            // bandedGridColumn15
            // 
            this.bandedGridColumn15.Caption = "单位";
            this.bandedGridColumn15.FieldName = "Unit";
            this.bandedGridColumn15.Name = "bandedGridColumn15";
            this.bandedGridColumn15.OptionsColumn.AllowMerge = DevExpress.Utils.DefaultBoolean.False;
            this.bandedGridColumn15.Visible = true;
            // 
            // colUnitPrice
            // 
            this.colUnitPrice.Caption = "单价";
            this.colUnitPrice.FieldName = "UnitPrice";
            this.colUnitPrice.Name = "colUnitPrice";
            // 
            // colUnitConsume
            // 
            this.colUnitConsume.Caption = "单位消耗";
            this.colUnitConsume.DisplayFormat.FormatString = "n0";
            this.colUnitConsume.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colUnitConsume.FieldName = "UnitConsume";
            this.colUnitConsume.Name = "colUnitConsume";
            this.colUnitConsume.OptionsColumn.AllowMerge = DevExpress.Utils.DefaultBoolean.False;
            this.colUnitConsume.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum)});
            this.colUnitConsume.Visible = true;
            // 
            // bandedGridColumn16
            // 
            this.bandedGridColumn16.Caption = "数量";
            this.bandedGridColumn16.DisplayFormat.FormatString = "n0";
            this.bandedGridColumn16.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.bandedGridColumn16.FieldName = "Qty";
            this.bandedGridColumn16.Name = "bandedGridColumn16";
            this.bandedGridColumn16.OptionsColumn.AllowMerge = DevExpress.Utils.DefaultBoolean.False;
            this.bandedGridColumn16.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum)});
            this.bandedGridColumn16.Visible = true;
            // 
            // repositoryItemMaterial
            // 
            this.repositoryItemMaterial.AutoHeight = false;
            this.repositoryItemMaterial.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryItemMaterial.Name = "repositoryItemMaterial";
            this.repositoryItemMaterial.NullText = "";
            this.repositoryItemMaterial.View = this.gridView3;
            // 
            // gridView3
            // 
            this.gridView3.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.gridView3.Name = "gridView3";
            this.gridView3.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.gridView3.OptionsView.ShowGroupPanel = false;
            // 
            // gridView2
            // 
            this.gridView2.GridControl = this.gridControl2;
            this.gridView2.Name = "gridView2";
            // 
            // ykGridControl1
            // 
            this.ykGridControl1.Cursor = System.Windows.Forms.Cursors.Default;
            this.ykGridControl1.DataSource = this.mESM201PlanBindingSource;
            this.ykGridControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ykGridControl1.EmbeddedNavigator.Buttons.Append.Visible = false;
            this.ykGridControl1.EmbeddedNavigator.Buttons.CancelEdit.Visible = false;
            this.ykGridControl1.EmbeddedNavigator.Buttons.Edit.Visible = false;
            this.ykGridControl1.EmbeddedNavigator.Buttons.EndEdit.Visible = false;
            this.ykGridControl1.EmbeddedNavigator.Buttons.Remove.Visible = false;
            this.ykGridControl1.EmbeddedNavigator.TextStringFormat = "记录:第{0}笔/共{1}笔";
            this.ykGridControl1.Location = new System.Drawing.Point(0, 0);
            this.ykGridControl1.MainView = this.gridPlan;
            this.ykGridControl1.MenuManager = this.barManager1;
            this.ykGridControl1.Name = "ykGridControl1";
            this.ykGridControl1.Size = new System.Drawing.Size(1149, 234);
            this.ykGridControl1.TabIndex = 9;
            this.ykGridControl1.UseEmbeddedNavigator = true;
            this.ykGridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridPlan});
            // 
            // gridPlan
            // 
            this.gridPlan.Appearance.EvenRow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(234)))), ((int)(((byte)(250)))));
            this.gridPlan.Appearance.EvenRow.Options.UseBackColor = true;
            this.gridPlan.Appearance.OddRow.BackColor = System.Drawing.Color.White;
            this.gridPlan.Appearance.OddRow.Options.UseBackColor = true;
            this.gridPlan.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colCompCode,
            this.colPLNo,
            this.colPLDt,
            this.colPLType,
            this.colRemarks,
            this.colModifyDt,
            this.colModifyUser,
            this.colCreateDt,
            this.colCreateUser,
            this.colId,
            this.colPLAuditing,
            this.colPLAuditingDt,
            this.colState});
            this.gridPlan.GridControl = this.ykGridControl1;
            this.gridPlan.IndicatorWidth = 40;
            this.gridPlan.Name = "gridPlan";
            this.gridPlan.OptionsBehavior.ReadOnly = true;
            this.gridPlan.OptionsFind.AlwaysVisible = true;
            this.gridPlan.OptionsView.ColumnAutoWidth = false;
            this.gridPlan.OptionsView.EnableAppearanceEvenRow = true;
            this.gridPlan.OptionsView.EnableAppearanceOddRow = true;
            this.gridPlan.OptionsView.ShowFilterPanelMode = DevExpress.XtraGrid.Views.Base.ShowFilterPanelMode.Never;
            this.gridPlan.OptionsView.ShowGroupPanel = false;
            // 
            // colCompCode
            // 
            this.colCompCode.Caption = "公司";
            this.colCompCode.FieldName = "CompCode";
            this.colCompCode.Name = "colCompCode";
            // 
            // colPLNo
            // 
            this.colPLNo.Caption = "计划单号";
            this.colPLNo.FieldName = "PLNo";
            this.colPLNo.Name = "colPLNo";
            this.colPLNo.Visible = true;
            this.colPLNo.VisibleIndex = 0;
            // 
            // colPLDt
            // 
            this.colPLDt.Caption = "日期";
            this.colPLDt.FieldName = "PLDt";
            this.colPLDt.Name = "colPLDt";
            this.colPLDt.Visible = true;
            this.colPLDt.VisibleIndex = 1;
            // 
            // colPLType
            // 
            this.colPLType.Caption = "类别";
            this.colPLType.FieldName = "PLType";
            this.colPLType.Name = "colPLType";
            this.colPLType.Visible = true;
            this.colPLType.VisibleIndex = 2;
            // 
            // colRemarks
            // 
            this.colRemarks.Caption = "备注";
            this.colRemarks.FieldName = "Remarks";
            this.colRemarks.Name = "colRemarks";
            this.colRemarks.Visible = true;
            this.colRemarks.VisibleIndex = 3;
            // 
            // colModifyDt
            // 
            this.colModifyDt.Caption = "修改日期";
            this.colModifyDt.FieldName = "ModifyDt";
            this.colModifyDt.Name = "colModifyDt";
            this.colModifyDt.Visible = true;
            this.colModifyDt.VisibleIndex = 4;
            // 
            // colModifyUser
            // 
            this.colModifyUser.Caption = "修改者";
            this.colModifyUser.FieldName = "ModifyUser";
            this.colModifyUser.Name = "colModifyUser";
            this.colModifyUser.Visible = true;
            this.colModifyUser.VisibleIndex = 5;
            // 
            // colCreateDt
            // 
            this.colCreateDt.Caption = "创建日期";
            this.colCreateDt.FieldName = "CreateDt";
            this.colCreateDt.Name = "colCreateDt";
            this.colCreateDt.Visible = true;
            this.colCreateDt.VisibleIndex = 6;
            // 
            // colCreateUser
            // 
            this.colCreateUser.Caption = "创建者";
            this.colCreateUser.FieldName = "CreateUser";
            this.colCreateUser.Name = "colCreateUser";
            this.colCreateUser.Visible = true;
            this.colCreateUser.VisibleIndex = 7;
            // 
            // colId
            // 
            this.colId.FieldName = "Id";
            this.colId.Name = "colId";
            // 
            // colPLAuditing
            // 
            this.colPLAuditing.Caption = "审核人";
            this.colPLAuditing.FieldName = "PLAuditing";
            this.colPLAuditing.Name = "colPLAuditing";
            this.colPLAuditing.Visible = true;
            this.colPLAuditing.VisibleIndex = 8;
            // 
            // colPLAuditingDt
            // 
            this.colPLAuditingDt.Caption = "审核时间";
            this.colPLAuditingDt.FieldName = "PLAuditingDt";
            this.colPLAuditingDt.Name = "colPLAuditingDt";
            this.colPLAuditingDt.Visible = true;
            this.colPLAuditingDt.VisibleIndex = 9;
            // 
            // colState
            // 
            this.colState.Caption = "状态";
            this.colState.FieldName = "State";
            this.colState.Name = "colState";
            this.colState.Visible = true;
            this.colState.VisibleIndex = 10;
            // 
            // splitContainerControl1
            // 
            this.splitContainerControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainerControl1.Horizontal = false;
            this.splitContainerControl1.Location = new System.Drawing.Point(0, 89);
            this.splitContainerControl1.Name = "splitContainerControl1";
            this.splitContainerControl1.Panel1.Controls.Add(this.ykGridControl1);
            this.splitContainerControl1.Panel1.Text = "Panel1";
            this.splitContainerControl1.Panel2.Controls.Add(this.xtraTabControl1);
            this.splitContainerControl1.Panel2.Text = "Panel2";
            this.splitContainerControl1.Size = new System.Drawing.Size(1149, 615);
            this.splitContainerControl1.SplitterPosition = 234;
            this.splitContainerControl1.TabIndex = 4;
            this.splitContainerControl1.Text = "splitContainerControl1";
            // 
            // fieldSONo
            // 
            this.fieldSONo.Area = DevExpress.XtraPivotGrid.PivotArea.RowArea;
            this.fieldSONo.AreaIndex = 1;
            this.fieldSONo.Caption = "订单号";
            this.fieldSONo.FieldName = "SONo";
            this.fieldSONo.Name = "fieldSONo";
            // 
            // MES201PlanForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1149, 733);
            this.Controls.Add(this.splitContainerControl1);
            this.Controls.Add(this.dockPanel1);
            this.Name = "MES201PlanForm";
            this.Text = "_201PlanForm";
            this.Controls.SetChildIndex(this.dockPanel1, 0);
            this.Controls.SetChildIndex(this.splitContainerControl1, 0);
            ((System.ComponentModel.ISupportInitialize)(this.mESM201PlanBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mESM201PlanDetailBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mESM201PlanDailyBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dockManager1)).EndInit();
            this.dockPanel1.ResumeLayout(false);
            this.dockPanel1_Container.ResumeLayout(false);
            this.dockPanel1_Container.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtPlanNo.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtProdDt2.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtProdDt2.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtProdDt1.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtProdDt1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabControl1)).EndInit();
            this.xtraTabControl1.ResumeLayout(false);
            this.xtraTabPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pivotGridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.planDetailDtoBindingSource)).EndInit();
            this.xtraTabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridControl2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridMaterial)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemMaterial)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ykGridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridPlan)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl1)).EndInit();
            this.splitContainerControl1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.BindingSource mESM201PlanBindingSource;
        private System.Windows.Forms.BindingSource mESM201PlanDetailBindingSource;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraBars.Docking.DockManager dockManager1;
        private DevExpress.XtraBars.Docking.DockPanel dockPanel1;
        private DevExpress.XtraBars.Docking.ControlContainer dockPanel1_Container;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.DateEdit txtProdDt2;
        private DevExpress.XtraEditors.SimpleButton btnSearch;
        private DevExpress.XtraEditors.DateEdit txtProdDt1;
        private DevExpress.XtraEditors.TextEdit txtPlanNo;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private System.Windows.Forms.BindingSource mESM201PlanDailyBindingSource;
        private DevExpress.XtraEditors.SplitContainerControl splitContainerControl1;
        private COM.YKControls.YKGridControl ykGridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridPlan;
        private DevExpress.XtraGrid.Columns.GridColumn colCompCode;
        private DevExpress.XtraGrid.Columns.GridColumn colPLNo;
        private DevExpress.XtraGrid.Columns.GridColumn colPLDt;
        private DevExpress.XtraGrid.Columns.GridColumn colPLType;
        private DevExpress.XtraGrid.Columns.GridColumn colRemarks;
        private DevExpress.XtraGrid.Columns.GridColumn colModifyDt;
        private DevExpress.XtraGrid.Columns.GridColumn colModifyUser;
        private DevExpress.XtraGrid.Columns.GridColumn colCreateDt;
        private DevExpress.XtraGrid.Columns.GridColumn colCreateUser;
        private DevExpress.XtraGrid.Columns.GridColumn colId;
        private DevExpress.XtraGrid.Columns.GridColumn colPLAuditing;
        private DevExpress.XtraGrid.Columns.GridColumn colPLAuditingDt;
        private DevExpress.XtraGrid.Columns.GridColumn colState;
        private DevExpress.XtraTab.XtraTabControl xtraTabControl1;
        private DevExpress.XtraTab.XtraTabPage xtraTabPage1;
        private DevExpress.XtraPivotGrid.PivotGridControl pivotGridControl1;
        private DevExpress.XtraTab.XtraTabPage xtraTabPage2;
        private DevExpress.XtraGrid.GridControl gridControl2;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridView gridMaterial;
        private DevExpress.XtraGrid.Views.BandedGrid.GridBand gridBand1;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn bandedGridColumn1;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn bandedGridColumn2;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn bandedGridColumn3;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn colCustAlias;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn bandedGridColumn4;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn bandedGridColumn5;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn bandedGridColumn6;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn bandedGridColumn7;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn bandedGridColumn8;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn colPlanDetailId;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn bandedGridColumn9;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn bandedGridColumn10;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn bandedGridColumn11;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn bandedGridColumn12;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn bandedGridColumn13;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn bandedGridColumn14;
        private DevExpress.XtraGrid.Views.BandedGrid.GridBand gridBand2;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn colMatCode;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn colMatName;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn colMatSpec;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn colSuppCode;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn bandedGridColumn15;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn colUnitPrice;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn colUnitConsume;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn bandedGridColumn16;
        private DevExpress.XtraEditors.Repository.RepositoryItemGridLookUpEdit repositoryItemMaterial;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView3;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView2;
        private System.Windows.Forms.BindingSource planDetailDtoBindingSource;
        private DevExpress.XtraPivotGrid.PivotGridField fieldPLevel1;
        private DevExpress.XtraPivotGrid.PivotGridField fieldPLNo1;
        private DevExpress.XtraPivotGrid.PivotGridField fieldSOQty1;
        private DevExpress.XtraPivotGrid.PivotGridField fieldCustCode1;
        private DevExpress.XtraPivotGrid.PivotGridField fieldPartNo1;
        private DevExpress.XtraPivotGrid.PivotGridField fieldPartName1;
        private DevExpress.XtraPivotGrid.PivotGridField fieldPartSpec1;
        private DevExpress.XtraPivotGrid.PivotGridField fieldDetailType1;
        private DevExpress.XtraPivotGrid.PivotGridField fieldUnit1;
        private DevExpress.XtraPivotGrid.PivotGridField fieldDetailQty1;
        private DevExpress.XtraPivotGrid.PivotGridField fieldFQty1;
        private DevExpress.XtraPivotGrid.PivotGridField fieldAdJustQty1;
        private DevExpress.XtraPivotGrid.PivotGridField fieldSumQty1;
        private DevExpress.XtraPivotGrid.PivotGridField fieldTxDt1;
        private DevExpress.XtraPivotGrid.PivotGridField fieldDailyQty1;
        private DevExpress.XtraPivotGrid.PivotGridField fieldSONo;
    }
}