namespace ERP.Winform.MES
{
    partial class MES201PlanMaterialViewForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MES201PlanMaterialViewForm));
            this.dockManager1 = new DevExpress.XtraBars.Docking.DockManager(this.components);
            this.dockPanel1 = new DevExpress.XtraBars.Docking.DockPanel();
            this.dockPanel1_Container = new DevExpress.XtraBars.Docking.ControlContainer();
            this.labelControl7 = new DevExpress.XtraEditors.LabelControl();
            this.txtStatus = new DevExpress.XtraEditors.TextEdit();
            this.labelControl6 = new DevExpress.XtraEditors.LabelControl();
            this.txtSONo = new DevExpress.XtraEditors.TextEdit();
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            this.txtPlanNo = new DevExpress.XtraEditors.TextEdit();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.btnSearch = new DevExpress.XtraEditors.SimpleButton();
            this.txtProdDt2 = new DevExpress.XtraEditors.DateEdit();
            this.txtProdDt1 = new DevExpress.XtraEditors.DateEdit();
            this.txtCustomer = new DevExpress.XtraEditors.GridLookUpEdit();
            this.gridLookUpEdit1View = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.txtProduct = new DevExpress.XtraEditors.GridLookUpEdit();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.pivotGridControl1 = new DevExpress.XtraPivotGrid.PivotGridControl();
            this.productMaterialViewModelBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.fieldCompCode1 = new DevExpress.XtraPivotGrid.PivotGridField();
            this.fieldPLNo1 = new DevExpress.XtraPivotGrid.PivotGridField();
            this.fieldPartNo1 = new DevExpress.XtraPivotGrid.PivotGridField();
            this.fieldMatCode1 = new DevExpress.XtraPivotGrid.PivotGridField();
            this.fieldSuppCode1 = new DevExpress.XtraPivotGrid.PivotGridField();
            this.fieldUnit1 = new DevExpress.XtraPivotGrid.PivotGridField();
            this.fieldUnitPrice1 = new DevExpress.XtraPivotGrid.PivotGridField();
            this.fieldQty1 = new DevExpress.XtraPivotGrid.PivotGridField();
            this.fieldRemarks1 = new DevExpress.XtraPivotGrid.PivotGridField();
            this.fieldCustCode1 = new DevExpress.XtraPivotGrid.PivotGridField();
            this.fieldPartName1 = new DevExpress.XtraPivotGrid.PivotGridField();
            this.fieldPartSpec1 = new DevExpress.XtraPivotGrid.PivotGridField();
            this.fieldMatName1 = new DevExpress.XtraPivotGrid.PivotGridField();
            this.fieldMatSpec1 = new DevExpress.XtraPivotGrid.PivotGridField();
            this.fieldUnitConsume1 = new DevExpress.XtraPivotGrid.PivotGridField();
            this.fieldCustAlias1 = new DevExpress.XtraPivotGrid.PivotGridField();
            this.fieldSumQty1 = new DevExpress.XtraPivotGrid.PivotGridField();
            this.fieldPLDt1 = new DevExpress.XtraPivotGrid.PivotGridField();
            this.fieldPLType1 = new DevExpress.XtraPivotGrid.PivotGridField();
            this.fieldPLAuditing1 = new DevExpress.XtraPivotGrid.PivotGridField();
            this.fieldPLAuditingDt1 = new DevExpress.XtraPivotGrid.PivotGridField();
            this.fieldSONo = new DevExpress.XtraPivotGrid.PivotGridField();
            this.fieldCustType = new DevExpress.XtraPivotGrid.PivotGridField();
            ((System.ComponentModel.ISupportInitialize)(this.dockManager1)).BeginInit();
            this.dockPanel1.SuspendLayout();
            this.dockPanel1_Container.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtStatus.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSONo.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPlanNo.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtProdDt2.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtProdDt2.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtProdDt1.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtProdDt1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCustomer.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridLookUpEdit1View)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtProduct.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pivotGridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.productMaterialViewModelBindingSource)).BeginInit();
            this.SuspendLayout();
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
            this.dockPanel1.FloatVertical = true;
            this.dockPanel1.ID = new System.Guid("29db7099-dd3b-4aa9-8b3c-a47326b1b206");
            this.dockPanel1.Location = new System.Drawing.Point(0, 0);
            this.dockPanel1.Name = "dockPanel1";
            this.dockPanel1.OriginalSize = new System.Drawing.Size(200, 104);
            this.dockPanel1.Size = new System.Drawing.Size(1101, 104);
            this.dockPanel1.Text = "搜索";
            // 
            // dockPanel1_Container
            // 
            this.dockPanel1_Container.Controls.Add(this.labelControl7);
            this.dockPanel1_Container.Controls.Add(this.txtStatus);
            this.dockPanel1_Container.Controls.Add(this.labelControl6);
            this.dockPanel1_Container.Controls.Add(this.txtSONo);
            this.dockPanel1_Container.Controls.Add(this.labelControl5);
            this.dockPanel1_Container.Controls.Add(this.txtPlanNo);
            this.dockPanel1_Container.Controls.Add(this.labelControl4);
            this.dockPanel1_Container.Controls.Add(this.labelControl3);
            this.dockPanel1_Container.Controls.Add(this.labelControl1);
            this.dockPanel1_Container.Controls.Add(this.labelControl2);
            this.dockPanel1_Container.Controls.Add(this.btnSearch);
            this.dockPanel1_Container.Controls.Add(this.txtProdDt2);
            this.dockPanel1_Container.Controls.Add(this.txtProdDt1);
            this.dockPanel1_Container.Controls.Add(this.txtCustomer);
            this.dockPanel1_Container.Controls.Add(this.txtProduct);
            this.dockPanel1_Container.Location = new System.Drawing.Point(4, 23);
            this.dockPanel1_Container.Name = "dockPanel1_Container";
            this.dockPanel1_Container.Size = new System.Drawing.Size(1093, 77);
            this.dockPanel1_Container.TabIndex = 0;
            // 
            // labelControl7
            // 
            this.labelControl7.Location = new System.Drawing.Point(477, 42);
            this.labelControl7.Name = "labelControl7";
            this.labelControl7.Size = new System.Drawing.Size(52, 14);
            this.labelControl7.TabIndex = 30;
            this.labelControl7.Text = "状      态:";
            // 
            // txtStatus
            // 
            this.txtStatus.Location = new System.Drawing.Point(537, 39);
            this.txtStatus.MenuManager = this.barManager1;
            this.txtStatus.Name = "txtStatus";
            this.txtStatus.Size = new System.Drawing.Size(127, 20);
            this.txtStatus.TabIndex = 29;
            // 
            // labelControl6
            // 
            this.labelControl6.Location = new System.Drawing.Point(239, 42);
            this.labelControl6.Name = "labelControl6";
            this.labelControl6.Size = new System.Drawing.Size(44, 14);
            this.labelControl6.TabIndex = 26;
            this.labelControl6.Text = "产    品:";
            // 
            // txtSONo
            // 
            this.txtSONo.Location = new System.Drawing.Point(297, 10);
            this.txtSONo.MenuManager = this.barManager1;
            this.txtSONo.Name = "txtSONo";
            this.txtSONo.Size = new System.Drawing.Size(174, 20);
            this.txtSONo.TabIndex = 25;
            // 
            // labelControl5
            // 
            this.labelControl5.Location = new System.Drawing.Point(18, 42);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(52, 14);
            this.labelControl5.TabIndex = 24;
            this.labelControl5.Text = "客      户:";
            // 
            // txtPlanNo
            // 
            this.txtPlanNo.Location = new System.Drawing.Point(76, 10);
            this.txtPlanNo.MenuManager = this.barManager1;
            this.txtPlanNo.Name = "txtPlanNo";
            this.txtPlanNo.Size = new System.Drawing.Size(157, 20);
            this.txtPlanNo.TabIndex = 23;
            // 
            // labelControl4
            // 
            this.labelControl4.Location = new System.Drawing.Point(239, 13);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(44, 14);
            this.labelControl4.TabIndex = 24;
            this.labelControl4.Text = "SO单号:";
            // 
            // labelControl3
            // 
            this.labelControl3.Location = new System.Drawing.Point(18, 13);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(52, 14);
            this.labelControl3.TabIndex = 22;
            this.labelControl3.Text = "计划单号:";
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(477, 13);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(52, 14);
            this.labelControl1.TabIndex = 21;
            this.labelControl1.Text = "下单日期:";
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(668, 13);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(4, 14);
            this.labelControl2.TabIndex = 22;
            this.labelControl2.Text = "-";
            // 
            // btnSearch
            // 
            this.btnSearch.Image = ((System.Drawing.Image)(resources.GetObject("btnSearch.Image")));
            this.btnSearch.Location = new System.Drawing.Point(845, 35);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(85, 28);
            this.btnSearch.TabIndex = 20;
            this.btnSearch.Text = "查询";
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // txtProdDt2
            // 
            this.txtProdDt2.EditValue = null;
            this.txtProdDt2.Location = new System.Drawing.Point(678, 10);
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
            // txtProdDt1
            // 
            this.txtProdDt1.EditValue = null;
            this.txtProdDt1.Location = new System.Drawing.Point(537, 10);
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
            // txtCustomer
            // 
            this.txtCustomer.Location = new System.Drawing.Point(76, 39);
            this.txtCustomer.MenuManager = this.barManager1;
            this.txtCustomer.Name = "txtCustomer";
            this.txtCustomer.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.txtCustomer.Properties.NullText = "";
            this.txtCustomer.Properties.View = this.gridLookUpEdit1View;
            this.txtCustomer.Size = new System.Drawing.Size(157, 20);
            this.txtCustomer.TabIndex = 25;
            // 
            // gridLookUpEdit1View
            // 
            this.gridLookUpEdit1View.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.gridLookUpEdit1View.Name = "gridLookUpEdit1View";
            this.gridLookUpEdit1View.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.gridLookUpEdit1View.OptionsView.ShowGroupPanel = false;
            // 
            // txtProduct
            // 
            this.txtProduct.Location = new System.Drawing.Point(297, 39);
            this.txtProduct.MenuManager = this.barManager1;
            this.txtProduct.Name = "txtProduct";
            this.txtProduct.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.txtProduct.Properties.NullText = "";
            this.txtProduct.Properties.View = this.gridView1;
            this.txtProduct.Size = new System.Drawing.Size(174, 20);
            this.txtProduct.TabIndex = 27;
            // 
            // gridView1
            // 
            this.gridView1.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.gridView1.OptionsView.ShowGroupPanel = false;
            // 
            // pivotGridControl1
            // 
            this.pivotGridControl1.DataSource = this.productMaterialViewModelBindingSource;
            this.pivotGridControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pivotGridControl1.Fields.AddRange(new DevExpress.XtraPivotGrid.PivotGridField[] {
            this.fieldCompCode1,
            this.fieldPLNo1,
            this.fieldPartNo1,
            this.fieldMatCode1,
            this.fieldSuppCode1,
            this.fieldUnit1,
            this.fieldUnitPrice1,
            this.fieldQty1,
            this.fieldRemarks1,
            this.fieldCustCode1,
            this.fieldPartName1,
            this.fieldPartSpec1,
            this.fieldMatName1,
            this.fieldMatSpec1,
            this.fieldUnitConsume1,
            this.fieldCustAlias1,
            this.fieldSumQty1,
            this.fieldPLDt1,
            this.fieldPLType1,
            this.fieldPLAuditing1,
            this.fieldPLAuditingDt1,
            this.fieldSONo,
            this.fieldCustType});
            this.pivotGridControl1.Location = new System.Drawing.Point(0, 104);
            this.pivotGridControl1.Name = "pivotGridControl1";
            this.pivotGridControl1.OptionsView.ShowColumnHeaders = false;
            this.pivotGridControl1.OptionsView.ShowDataHeaders = false;
            this.pivotGridControl1.OptionsView.ShowFilterHeaders = false;
            this.pivotGridControl1.Size = new System.Drawing.Size(1101, 504);
            this.pivotGridControl1.TabIndex = 5;
            // 
            // productMaterialViewModelBindingSource
            // 
            this.productMaterialViewModelBindingSource.DataSource = typeof(ERP.Domain.ProductMaterialViewModel);
            // 
            // fieldCompCode1
            // 
            this.fieldCompCode1.AreaIndex = 0;
            this.fieldCompCode1.Caption = "公司代号";
            this.fieldCompCode1.FieldName = "CompCode";
            this.fieldCompCode1.Name = "fieldCompCode1";
            // 
            // fieldPLNo1
            // 
            this.fieldPLNo1.Area = DevExpress.XtraPivotGrid.PivotArea.RowArea;
            this.fieldPLNo1.AreaIndex = 1;
            this.fieldPLNo1.Caption = "计划单号";
            this.fieldPLNo1.FieldName = "PLNo";
            this.fieldPLNo1.Name = "fieldPLNo1";
            // 
            // fieldPartNo1
            // 
            this.fieldPartNo1.Area = DevExpress.XtraPivotGrid.PivotArea.RowArea;
            this.fieldPartNo1.AreaIndex = 5;
            this.fieldPartNo1.Caption = "产品代号";
            this.fieldPartNo1.FieldName = "PartNo";
            this.fieldPartNo1.Name = "fieldPartNo1";
            // 
            // fieldMatCode1
            // 
            this.fieldMatCode1.Area = DevExpress.XtraPivotGrid.PivotArea.RowArea;
            this.fieldMatCode1.AreaIndex = 8;
            this.fieldMatCode1.Caption = "物料代号";
            this.fieldMatCode1.FieldName = "MatCode";
            this.fieldMatCode1.Name = "fieldMatCode1";
            // 
            // fieldSuppCode1
            // 
            this.fieldSuppCode1.AreaIndex = 1;
            this.fieldSuppCode1.Caption = "供应商代号";
            this.fieldSuppCode1.FieldName = "SuppCode";
            this.fieldSuppCode1.Name = "fieldSuppCode1";
            // 
            // fieldUnit1
            // 
            this.fieldUnit1.AreaIndex = 2;
            this.fieldUnit1.Caption = "单位";
            this.fieldUnit1.FieldName = "Unit";
            this.fieldUnit1.Name = "fieldUnit1";
            // 
            // fieldUnitPrice1
            // 
            this.fieldUnitPrice1.AreaIndex = 3;
            this.fieldUnitPrice1.Caption = "单价";
            this.fieldUnitPrice1.FieldName = "UnitPrice";
            this.fieldUnitPrice1.Name = "fieldUnitPrice1";
            // 
            // fieldQty1
            // 
            this.fieldQty1.Area = DevExpress.XtraPivotGrid.PivotArea.DataArea;
            this.fieldQty1.AreaIndex = 1;
            this.fieldQty1.Caption = "物料数量";
            this.fieldQty1.CellFormat.FormatString = "n2";
            this.fieldQty1.CellFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.fieldQty1.FieldName = "Qty";
            this.fieldQty1.Name = "fieldQty1";
            // 
            // fieldRemarks1
            // 
            this.fieldRemarks1.AreaIndex = 4;
            this.fieldRemarks1.Caption = "备注";
            this.fieldRemarks1.FieldName = "Remarks";
            this.fieldRemarks1.Name = "fieldRemarks1";
            // 
            // fieldCustCode1
            // 
            this.fieldCustCode1.AreaIndex = 5;
            this.fieldCustCode1.Caption = "客户代号";
            this.fieldCustCode1.FieldName = "CustCode";
            this.fieldCustCode1.Name = "fieldCustCode1";
            // 
            // fieldPartName1
            // 
            this.fieldPartName1.Area = DevExpress.XtraPivotGrid.PivotArea.RowArea;
            this.fieldPartName1.AreaIndex = 6;
            this.fieldPartName1.Caption = "产品名称";
            this.fieldPartName1.FieldName = "PartName";
            this.fieldPartName1.Name = "fieldPartName1";
            // 
            // fieldPartSpec1
            // 
            this.fieldPartSpec1.Area = DevExpress.XtraPivotGrid.PivotArea.RowArea;
            this.fieldPartSpec1.AreaIndex = 7;
            this.fieldPartSpec1.Caption = "产品规格";
            this.fieldPartSpec1.FieldName = "PartSpec";
            this.fieldPartSpec1.Name = "fieldPartSpec1";
            // 
            // fieldMatName1
            // 
            this.fieldMatName1.Area = DevExpress.XtraPivotGrid.PivotArea.RowArea;
            this.fieldMatName1.AreaIndex = 9;
            this.fieldMatName1.Caption = "物料名称";
            this.fieldMatName1.FieldName = "MatName";
            this.fieldMatName1.Name = "fieldMatName1";
            // 
            // fieldMatSpec1
            // 
            this.fieldMatSpec1.Area = DevExpress.XtraPivotGrid.PivotArea.RowArea;
            this.fieldMatSpec1.AreaIndex = 10;
            this.fieldMatSpec1.Caption = "物料规格";
            this.fieldMatSpec1.FieldName = "MatSpec";
            this.fieldMatSpec1.Name = "fieldMatSpec1";
            // 
            // fieldUnitConsume1
            // 
            this.fieldUnitConsume1.AreaIndex = 9;
            this.fieldUnitConsume1.Caption = "单位消耗量";
            this.fieldUnitConsume1.CellFormat.FormatString = "n2";
            this.fieldUnitConsume1.CellFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.fieldUnitConsume1.FieldName = "UnitConsume";
            this.fieldUnitConsume1.Name = "fieldUnitConsume1";
            // 
            // fieldCustAlias1
            // 
            this.fieldCustAlias1.Area = DevExpress.XtraPivotGrid.PivotArea.RowArea;
            this.fieldCustAlias1.AreaIndex = 4;
            this.fieldCustAlias1.Caption = "客户名称";
            this.fieldCustAlias1.FieldName = "CustAlias";
            this.fieldCustAlias1.Name = "fieldCustAlias1";
            // 
            // fieldSumQty1
            // 
            this.fieldSumQty1.Area = DevExpress.XtraPivotGrid.PivotArea.DataArea;
            this.fieldSumQty1.AreaIndex = 0;
            this.fieldSumQty1.Caption = "产品总量";
            this.fieldSumQty1.CellFormat.FormatString = "n2";
            this.fieldSumQty1.CellFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.fieldSumQty1.FieldName = "SumQty";
            this.fieldSumQty1.Name = "fieldSumQty1";
            // 
            // fieldPLDt1
            // 
            this.fieldPLDt1.AreaIndex = 6;
            this.fieldPLDt1.Caption = "计划开单日期";
            this.fieldPLDt1.FieldName = "PLDt";
            this.fieldPLDt1.Name = "fieldPLDt1";
            // 
            // fieldPLType1
            // 
            this.fieldPLType1.Area = DevExpress.XtraPivotGrid.PivotArea.RowArea;
            this.fieldPLType1.AreaIndex = 2;
            this.fieldPLType1.Caption = "类别";
            this.fieldPLType1.FieldName = "PLType";
            this.fieldPLType1.Name = "fieldPLType1";
            // 
            // fieldPLAuditing1
            // 
            this.fieldPLAuditing1.AreaIndex = 7;
            this.fieldPLAuditing1.Caption = "审核人";
            this.fieldPLAuditing1.FieldName = "PLAuditing";
            this.fieldPLAuditing1.Name = "fieldPLAuditing1";
            // 
            // fieldPLAuditingDt1
            // 
            this.fieldPLAuditingDt1.AreaIndex = 8;
            this.fieldPLAuditingDt1.Caption = "审核时间";
            this.fieldPLAuditingDt1.FieldName = "PLAuditingDt";
            this.fieldPLAuditingDt1.Name = "fieldPLAuditingDt1";
            // 
            // fieldSONo
            // 
            this.fieldSONo.Area = DevExpress.XtraPivotGrid.PivotArea.RowArea;
            this.fieldSONo.AreaIndex = 3;
            this.fieldSONo.Caption = "SO订单";
            this.fieldSONo.FieldName = "SONo";
            this.fieldSONo.Name = "fieldSONo";
            // 
            // fieldCustType
            // 
            this.fieldCustType.Area = DevExpress.XtraPivotGrid.PivotArea.RowArea;
            this.fieldCustType.AreaIndex = 0;
            this.fieldCustType.Caption = "客户类别";
            this.fieldCustType.FieldName = "CustType";
            this.fieldCustType.Name = "fieldCustType";
            // 
            // MES201PlanMaterialViewForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1101, 637);
            this.Controls.Add(this.pivotGridControl1);
            this.Controls.Add(this.dockPanel1);
            this.Name = "MES201PlanMaterialViewForm";
            this.Text = "201-计划物料需求表";
            this.Controls.SetChildIndex(this.dockPanel1, 0);
            this.Controls.SetChildIndex(this.pivotGridControl1, 0);
            ((System.ComponentModel.ISupportInitialize)(this.dockManager1)).EndInit();
            this.dockPanel1.ResumeLayout(false);
            this.dockPanel1_Container.ResumeLayout(false);
            this.dockPanel1_Container.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtStatus.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSONo.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPlanNo.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtProdDt2.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtProdDt2.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtProdDt1.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtProdDt1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCustomer.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridLookUpEdit1View)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtProduct.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pivotGridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.productMaterialViewModelBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraBars.Docking.DockManager dockManager1;
        private DevExpress.XtraBars.Docking.DockPanel dockPanel1;
        private DevExpress.XtraBars.Docking.ControlContainer dockPanel1_Container;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.SimpleButton btnSearch;
        private DevExpress.XtraEditors.DateEdit txtProdDt2;
        private DevExpress.XtraEditors.DateEdit txtProdDt1;
        private DevExpress.XtraPivotGrid.PivotGridControl pivotGridControl1;
        private DevExpress.XtraPivotGrid.PivotGridField fieldCompCode1;
        private DevExpress.XtraPivotGrid.PivotGridField fieldPLNo1;
        private DevExpress.XtraPivotGrid.PivotGridField fieldPartNo1;
        private DevExpress.XtraPivotGrid.PivotGridField fieldMatCode1;
        private DevExpress.XtraPivotGrid.PivotGridField fieldSuppCode1;
        private DevExpress.XtraPivotGrid.PivotGridField fieldUnit1;
        private DevExpress.XtraPivotGrid.PivotGridField fieldUnitPrice1;
        private DevExpress.XtraPivotGrid.PivotGridField fieldQty1;
        private DevExpress.XtraPivotGrid.PivotGridField fieldRemarks1;
        private DevExpress.XtraPivotGrid.PivotGridField fieldCustCode1;
        private DevExpress.XtraPivotGrid.PivotGridField fieldPartName1;
        private DevExpress.XtraPivotGrid.PivotGridField fieldPartSpec1;
        private DevExpress.XtraPivotGrid.PivotGridField fieldMatName1;
        private DevExpress.XtraPivotGrid.PivotGridField fieldMatSpec1;
        private DevExpress.XtraPivotGrid.PivotGridField fieldUnitConsume1;
        private DevExpress.XtraPivotGrid.PivotGridField fieldCustAlias1;
        private DevExpress.XtraPivotGrid.PivotGridField fieldSumQty1;
        private DevExpress.XtraPivotGrid.PivotGridField fieldPLDt1;
        private DevExpress.XtraPivotGrid.PivotGridField fieldPLType1;
        private DevExpress.XtraPivotGrid.PivotGridField fieldPLAuditing1;
        private DevExpress.XtraPivotGrid.PivotGridField fieldPLAuditingDt1;
        private DevExpress.XtraEditors.LabelControl labelControl7;
        private DevExpress.XtraEditors.TextEdit txtStatus;
        private DevExpress.XtraEditors.LabelControl labelControl6;
        private DevExpress.XtraEditors.TextEdit txtSONo;
        private DevExpress.XtraEditors.LabelControl labelControl5;
        private DevExpress.XtraEditors.TextEdit txtPlanNo;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraPivotGrid.PivotGridField fieldSONo;
        private System.Windows.Forms.BindingSource productMaterialViewModelBindingSource;
        private DevExpress.XtraEditors.GridLookUpEdit txtCustomer;
        private DevExpress.XtraGrid.Views.Grid.GridView gridLookUpEdit1View;
        private DevExpress.XtraEditors.GridLookUpEdit txtProduct;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraPivotGrid.PivotGridField fieldCustType;
    }
}