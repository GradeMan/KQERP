namespace ERP.Winform.MES
{
    partial class MES201PlanProductViewForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MES201PlanProductViewForm));
            this.dockManager1 = new DevExpress.XtraBars.Docking.DockManager(this.components);
            this.dockPanel1 = new DevExpress.XtraBars.Docking.DockPanel();
            this.dockPanel1_Container = new DevExpress.XtraBars.Docking.ControlContainer();
            this.labelControl7 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.txtStatus = new DevExpress.XtraEditors.TextEdit();
            this.txtCustomer = new DevExpress.XtraEditors.GridLookUpEdit();
            this.gridView2 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.labelControl6 = new DevExpress.XtraEditors.LabelControl();
            this.txtProduct = new DevExpress.XtraEditors.GridLookUpEdit();
            this.gridLookUpEdit1View = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.txtSONo = new DevExpress.XtraEditors.TextEdit();
            this.txtProdDt1 = new DevExpress.XtraEditors.DateEdit();
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            this.txtProdDt2 = new DevExpress.XtraEditors.DateEdit();
            this.txtPlanNo = new DevExpress.XtraEditors.TextEdit();
            this.btnSearch = new DevExpress.XtraEditors.SimpleButton();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.m201PlanProductViewModelBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colPLNo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPLDt = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPLType = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPLAuditing = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPLAuditingDt = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPlanId = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPartName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPartSpec = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPartNo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCustCode = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCustAlias = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colQty = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colFQty = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colAdJustQty = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSumQty = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSONo = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dockManager1)).BeginInit();
            this.dockPanel1.SuspendLayout();
            this.dockPanel1_Container.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtStatus.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCustomer.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtProduct.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridLookUpEdit1View)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSONo.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtProdDt1.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtProdDt1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtProdDt2.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtProdDt2.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPlanNo.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.m201PlanProductViewModelBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
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
            this.dockPanel1.ID = new System.Guid("8c7de84f-c963-4657-ac83-7146a19c3670");
            this.dockPanel1.Location = new System.Drawing.Point(0, 0);
            this.dockPanel1.Name = "dockPanel1";
            this.dockPanel1.OriginalSize = new System.Drawing.Size(200, 104);
            this.dockPanel1.Size = new System.Drawing.Size(1152, 104);
            this.dockPanel1.Text = "搜索";
            // 
            // dockPanel1_Container
            // 
            this.dockPanel1_Container.Controls.Add(this.labelControl7);
            this.dockPanel1_Container.Controls.Add(this.labelControl3);
            this.dockPanel1_Container.Controls.Add(this.txtStatus);
            this.dockPanel1_Container.Controls.Add(this.txtCustomer);
            this.dockPanel1_Container.Controls.Add(this.labelControl6);
            this.dockPanel1_Container.Controls.Add(this.txtProduct);
            this.dockPanel1_Container.Controls.Add(this.txtSONo);
            this.dockPanel1_Container.Controls.Add(this.txtProdDt1);
            this.dockPanel1_Container.Controls.Add(this.labelControl5);
            this.dockPanel1_Container.Controls.Add(this.txtProdDt2);
            this.dockPanel1_Container.Controls.Add(this.txtPlanNo);
            this.dockPanel1_Container.Controls.Add(this.btnSearch);
            this.dockPanel1_Container.Controls.Add(this.labelControl4);
            this.dockPanel1_Container.Controls.Add(this.labelControl2);
            this.dockPanel1_Container.Controls.Add(this.labelControl1);
            this.dockPanel1_Container.Location = new System.Drawing.Point(4, 23);
            this.dockPanel1_Container.Name = "dockPanel1_Container";
            this.dockPanel1_Container.Size = new System.Drawing.Size(1144, 77);
            this.dockPanel1_Container.TabIndex = 0;
            // 
            // labelControl7
            // 
            this.labelControl7.Location = new System.Drawing.Point(462, 40);
            this.labelControl7.Name = "labelControl7";
            this.labelControl7.Size = new System.Drawing.Size(52, 14);
            this.labelControl7.TabIndex = 60;
            this.labelControl7.Text = "状      态:";
            // 
            // labelControl3
            // 
            this.labelControl3.Location = new System.Drawing.Point(3, 11);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(52, 14);
            this.labelControl3.TabIndex = 50;
            this.labelControl3.Text = "计划单号:";
            // 
            // txtStatus
            // 
            this.txtStatus.Location = new System.Drawing.Point(522, 37);
            this.txtStatus.MenuManager = this.barManager1;
            this.txtStatus.Name = "txtStatus";
            this.txtStatus.Size = new System.Drawing.Size(127, 20);
            this.txtStatus.TabIndex = 59;
            // 
            // txtCustomer
            // 
            this.txtCustomer.Location = new System.Drawing.Point(61, 37);
            this.txtCustomer.MenuManager = this.barManager1;
            this.txtCustomer.Name = "txtCustomer";
            this.txtCustomer.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.txtCustomer.Properties.NullText = "";
            this.txtCustomer.Properties.View = this.gridView2;
            this.txtCustomer.Size = new System.Drawing.Size(157, 20);
            this.txtCustomer.TabIndex = 55;
            // 
            // gridView2
            // 
            this.gridView2.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.gridView2.Name = "gridView2";
            this.gridView2.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.gridView2.OptionsView.ShowGroupPanel = false;
            // 
            // labelControl6
            // 
            this.labelControl6.Location = new System.Drawing.Point(224, 40);
            this.labelControl6.Name = "labelControl6";
            this.labelControl6.Size = new System.Drawing.Size(44, 14);
            this.labelControl6.TabIndex = 57;
            this.labelControl6.Text = "产    品:";
            // 
            // txtProduct
            // 
            this.txtProduct.Location = new System.Drawing.Point(282, 37);
            this.txtProduct.MenuManager = this.barManager1;
            this.txtProduct.Name = "txtProduct";
            this.txtProduct.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.txtProduct.Properties.NullText = "";
            this.txtProduct.Properties.View = this.gridLookUpEdit1View;
            this.txtProduct.Size = new System.Drawing.Size(174, 20);
            this.txtProduct.TabIndex = 58;
            // 
            // gridLookUpEdit1View
            // 
            this.gridLookUpEdit1View.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.gridLookUpEdit1View.Name = "gridLookUpEdit1View";
            this.gridLookUpEdit1View.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.gridLookUpEdit1View.OptionsView.ShowGroupPanel = false;
            // 
            // txtSONo
            // 
            this.txtSONo.Location = new System.Drawing.Point(282, 8);
            this.txtSONo.MenuManager = this.barManager1;
            this.txtSONo.Name = "txtSONo";
            this.txtSONo.Size = new System.Drawing.Size(174, 20);
            this.txtSONo.TabIndex = 56;
            // 
            // txtProdDt1
            // 
            this.txtProdDt1.EditValue = null;
            this.txtProdDt1.Location = new System.Drawing.Point(522, 8);
            this.txtProdDt1.MenuManager = this.barManager1;
            this.txtProdDt1.Name = "txtProdDt1";
            this.txtProdDt1.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.txtProdDt1.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.txtProdDt1.Properties.Mask.EditMask = "";
            this.txtProdDt1.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.None;
            this.txtProdDt1.Size = new System.Drawing.Size(127, 20);
            this.txtProdDt1.TabIndex = 46;
            // 
            // labelControl5
            // 
            this.labelControl5.Location = new System.Drawing.Point(3, 40);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(52, 14);
            this.labelControl5.TabIndex = 53;
            this.labelControl5.Text = "客      户:";
            // 
            // txtProdDt2
            // 
            this.txtProdDt2.EditValue = null;
            this.txtProdDt2.Location = new System.Drawing.Point(663, 8);
            this.txtProdDt2.MenuManager = this.barManager1;
            this.txtProdDt2.Name = "txtProdDt2";
            this.txtProdDt2.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.txtProdDt2.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.txtProdDt2.Properties.Mask.EditMask = "";
            this.txtProdDt2.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.None;
            this.txtProdDt2.Size = new System.Drawing.Size(152, 20);
            this.txtProdDt2.TabIndex = 47;
            // 
            // txtPlanNo
            // 
            this.txtPlanNo.Location = new System.Drawing.Point(61, 8);
            this.txtPlanNo.MenuManager = this.barManager1;
            this.txtPlanNo.Name = "txtPlanNo";
            this.txtPlanNo.Size = new System.Drawing.Size(157, 20);
            this.txtPlanNo.TabIndex = 52;
            // 
            // btnSearch
            // 
            this.btnSearch.Image = ((System.Drawing.Image)(resources.GetObject("btnSearch.Image")));
            this.btnSearch.Location = new System.Drawing.Point(830, 33);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(85, 28);
            this.btnSearch.TabIndex = 48;
            this.btnSearch.Text = "查询";
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // labelControl4
            // 
            this.labelControl4.Location = new System.Drawing.Point(224, 11);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(44, 14);
            this.labelControl4.TabIndex = 54;
            this.labelControl4.Text = "SO单号:";
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(653, 11);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(4, 14);
            this.labelControl2.TabIndex = 51;
            this.labelControl2.Text = "-";
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(462, 11);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(52, 14);
            this.labelControl1.TabIndex = 49;
            this.labelControl1.Text = "下单日期:";
            // 
            // gridControl1
            // 
            this.gridControl1.Cursor = System.Windows.Forms.Cursors.Default;
            this.gridControl1.DataSource = this.m201PlanProductViewModelBindingSource;
            this.gridControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControl1.EmbeddedNavigator.TextStringFormat = "第 {0} 共{1}";
            this.gridControl1.Location = new System.Drawing.Point(0, 104);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.MenuManager = this.barManager1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(1152, 380);
            this.gridControl1.TabIndex = 5;
            this.gridControl1.UseEmbeddedNavigator = true;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // m201PlanProductViewModelBindingSource
            // 
            this.m201PlanProductViewModelBindingSource.DataSource = typeof(ERP.Domain.M201PlanProductViewModel);
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colPLNo,
            this.colPLDt,
            this.colPLType,
            this.colPLAuditing,
            this.colPLAuditingDt,
            this.colPlanId,
            this.colPartName,
            this.colPartSpec,
            this.colPartNo,
            this.colCustCode,
            this.colCustAlias,
            this.colQty,
            this.colFQty,
            this.colAdJustQty,
            this.colSumQty,
            this.colSONo});
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsFind.AlwaysVisible = true;
            this.gridView1.OptionsView.ShowFooter = true;
            this.gridView1.OptionsView.ShowGroupPanel = false;
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
            this.colPLDt.Caption = "计划日期";
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
            // colPLAuditing
            // 
            this.colPLAuditing.Caption = "审核人";
            this.colPLAuditing.FieldName = "PLAuditing";
            this.colPLAuditing.Name = "colPLAuditing";
            this.colPLAuditing.Visible = true;
            this.colPLAuditing.VisibleIndex = 3;
            // 
            // colPLAuditingDt
            // 
            this.colPLAuditingDt.Caption = "审核日期";
            this.colPLAuditingDt.FieldName = "PLAuditingDt";
            this.colPLAuditingDt.Name = "colPLAuditingDt";
            this.colPLAuditingDt.Visible = true;
            this.colPLAuditingDt.VisibleIndex = 4;
            // 
            // colPlanId
            // 
            this.colPlanId.FieldName = "PlanId";
            this.colPlanId.Name = "colPlanId";
            // 
            // colPartName
            // 
            this.colPartName.Caption = "品名";
            this.colPartName.FieldName = "PartName";
            this.colPartName.Name = "colPartName";
            this.colPartName.Visible = true;
            this.colPartName.VisibleIndex = 7;
            // 
            // colPartSpec
            // 
            this.colPartSpec.Caption = "规格";
            this.colPartSpec.FieldName = "PartSpec";
            this.colPartSpec.Name = "colPartSpec";
            this.colPartSpec.Visible = true;
            this.colPartSpec.VisibleIndex = 8;
            // 
            // colPartNo
            // 
            this.colPartNo.Caption = "产品编号";
            this.colPartNo.FieldName = "PartNo";
            this.colPartNo.Name = "colPartNo";
            this.colPartNo.Visible = true;
            this.colPartNo.VisibleIndex = 6;
            // 
            // colCustCode
            // 
            this.colCustCode.Caption = "客户编号";
            this.colCustCode.FieldName = "CustCode";
            this.colCustCode.Name = "colCustCode";
            this.colCustCode.Visible = true;
            this.colCustCode.VisibleIndex = 9;
            // 
            // colCustAlias
            // 
            this.colCustAlias.Caption = "客户名称";
            this.colCustAlias.FieldName = "CustAlias";
            this.colCustAlias.Name = "colCustAlias";
            this.colCustAlias.Visible = true;
            this.colCustAlias.VisibleIndex = 10;
            // 
            // colQty
            // 
            this.colQty.Caption = "计划数量";
            this.colQty.DisplayFormat.FormatString = "n2";
            this.colQty.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colQty.FieldName = "Qty";
            this.colQty.Name = "colQty";
            this.colQty.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum)});
            this.colQty.Visible = true;
            this.colQty.VisibleIndex = 11;
            // 
            // colFQty
            // 
            this.colFQty.FieldName = "FQty";
            this.colFQty.Name = "colFQty";
            // 
            // colAdJustQty
            // 
            this.colAdJustQty.Caption = "调整数量";
            this.colAdJustQty.DisplayFormat.FormatString = "n2";
            this.colAdJustQty.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colAdJustQty.FieldName = "AdJustQty";
            this.colAdJustQty.Name = "colAdJustQty";
            this.colAdJustQty.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum)});
            this.colAdJustQty.Visible = true;
            this.colAdJustQty.VisibleIndex = 12;
            // 
            // colSumQty
            // 
            this.colSumQty.Caption = "总量";
            this.colSumQty.DisplayFormat.FormatString = "n2";
            this.colSumQty.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colSumQty.FieldName = "SumQty";
            this.colSumQty.Name = "colSumQty";
            this.colSumQty.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum)});
            this.colSumQty.Visible = true;
            this.colSumQty.VisibleIndex = 13;
            // 
            // colSONo
            // 
            this.colSONo.Caption = "SO订单";
            this.colSONo.FieldName = "SONo";
            this.colSONo.Name = "colSONo";
            this.colSONo.Visible = true;
            this.colSONo.VisibleIndex = 5;
            // 
            // MES201PlanProductViewForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1152, 513);
            this.Controls.Add(this.gridControl1);
            this.Controls.Add(this.dockPanel1);
            this.Name = "MES201PlanProductViewForm";
            this.Text = "201-计划表列表";
            this.Controls.SetChildIndex(this.dockPanel1, 0);
            this.Controls.SetChildIndex(this.gridControl1, 0);
            ((System.ComponentModel.ISupportInitialize)(this.dockManager1)).EndInit();
            this.dockPanel1.ResumeLayout(false);
            this.dockPanel1_Container.ResumeLayout(false);
            this.dockPanel1_Container.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtStatus.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCustomer.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtProduct.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridLookUpEdit1View)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSONo.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtProdDt1.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtProdDt1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtProdDt2.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtProdDt2.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPlanNo.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.m201PlanProductViewModelBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraBars.Docking.DockManager dockManager1;
        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraBars.Docking.DockPanel dockPanel1;
        private DevExpress.XtraBars.Docking.ControlContainer dockPanel1_Container;
        private System.Windows.Forms.BindingSource m201PlanProductViewModelBindingSource;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn colPLNo;
        private DevExpress.XtraGrid.Columns.GridColumn colPLDt;
        private DevExpress.XtraGrid.Columns.GridColumn colPLType;
        private DevExpress.XtraGrid.Columns.GridColumn colPLAuditing;
        private DevExpress.XtraGrid.Columns.GridColumn colPLAuditingDt;
        private DevExpress.XtraGrid.Columns.GridColumn colPlanId;
        private DevExpress.XtraGrid.Columns.GridColumn colPartName;
        private DevExpress.XtraGrid.Columns.GridColumn colPartSpec;
        private DevExpress.XtraGrid.Columns.GridColumn colPartNo;
        private DevExpress.XtraGrid.Columns.GridColumn colCustCode;
        private DevExpress.XtraGrid.Columns.GridColumn colCustAlias;
        private DevExpress.XtraGrid.Columns.GridColumn colQty;
        private DevExpress.XtraGrid.Columns.GridColumn colFQty;
        private DevExpress.XtraGrid.Columns.GridColumn colAdJustQty;
        private DevExpress.XtraGrid.Columns.GridColumn colSumQty;
        private DevExpress.XtraGrid.Columns.GridColumn colSONo;
        private DevExpress.XtraEditors.LabelControl labelControl7;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.TextEdit txtStatus;
        private DevExpress.XtraEditors.GridLookUpEdit txtCustomer;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView2;
        private DevExpress.XtraEditors.LabelControl labelControl6;
        private DevExpress.XtraEditors.GridLookUpEdit txtProduct;
        private DevExpress.XtraGrid.Views.Grid.GridView gridLookUpEdit1View;
        private DevExpress.XtraEditors.TextEdit txtSONo;
        private DevExpress.XtraEditors.DateEdit txtProdDt1;
        private DevExpress.XtraEditors.LabelControl labelControl5;
        private DevExpress.XtraEditors.DateEdit txtProdDt2;
        private DevExpress.XtraEditors.TextEdit txtPlanNo;
        private DevExpress.XtraEditors.SimpleButton btnSearch;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.LabelControl labelControl1;
    }
}