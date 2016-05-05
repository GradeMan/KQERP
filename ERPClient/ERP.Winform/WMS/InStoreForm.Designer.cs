namespace ERP.Winform.WMS
{
    partial class InStoreForm
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
            this.ykGridControl1 = new COM.YKControls.YKGridControl();
            this.wMSC101InStoreBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colInStoreNo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDriverName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDriverTel = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDriverBusNumber = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDriverDt = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colEmpInfo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colEmpTel = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSuppCode = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositorySuppCode = new DevExpress.XtraEditors.Repository.RepositoryItemGridLookUpEdit();
            this.gridView2 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colActualAmount = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colModifyDt = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colModifyUser = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCreateDt = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCreateUser = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colRemarks = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colVersion = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colId = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colStoreInDate = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colStockArea = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDeliveryNo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.splitContainerControl1 = new DevExpress.XtraEditors.SplitContainerControl();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.wMSC102InStoreDetailBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gridInstoreDetail = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colInStoreId = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colARCode = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPartSpec = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colAmount = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSuppLot = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn3 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn4 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn5 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn6 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn7 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMatClass2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMatCode = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colRemarks1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSumPrice = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colUnit = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colUnitPrice = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemLotNo = new DevExpress.XtraEditors.Repository.RepositoryItemGridLookUpEdit();
            this.repositoryItemGridLookUpEdit1View = new DevExpress.XtraGrid.Views.Grid.GridView();
            ((System.ComponentModel.ISupportInitialize)(this.ykGridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.wMSC101InStoreBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositorySuppCode)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl1)).BeginInit();
            this.splitContainerControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.wMSC102InStoreDetailBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridInstoreDetail)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemLotNo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemGridLookUpEdit1View)).BeginInit();
            this.SuspendLayout();
            // 
            // ykGridControl1
            // 
            this.ykGridControl1.Cursor = System.Windows.Forms.Cursors.Default;
            this.ykGridControl1.DataSource = this.wMSC101InStoreBindingSource;
            this.ykGridControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ykGridControl1.EmbeddedNavigator.Buttons.Append.Visible = false;
            this.ykGridControl1.EmbeddedNavigator.Buttons.CancelEdit.Visible = false;
            this.ykGridControl1.EmbeddedNavigator.Buttons.Edit.Visible = false;
            this.ykGridControl1.EmbeddedNavigator.Buttons.EndEdit.Visible = false;
            this.ykGridControl1.EmbeddedNavigator.Buttons.Remove.Visible = false;
            this.ykGridControl1.EmbeddedNavigator.TextStringFormat = "记录:第{0}笔/共{1}笔";
            this.ykGridControl1.Location = new System.Drawing.Point(0, 0);
            this.ykGridControl1.MainView = this.gridView1;
            this.ykGridControl1.MenuManager = this.barManager1;
            this.ykGridControl1.Name = "ykGridControl1";
            this.ykGridControl1.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositorySuppCode});
            this.ykGridControl1.Size = new System.Drawing.Size(812, 301);
            this.ykGridControl1.TabIndex = 4;
            this.ykGridControl1.UseEmbeddedNavigator = true;
            this.ykGridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // wMSC101InStoreBindingSource
            // 
            this.wMSC101InStoreBindingSource.DataSource = typeof(ERP.Domain.WMS_C101_InStore);
            // 
            // gridView1
            // 
            this.gridView1.Appearance.EvenRow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(234)))), ((int)(((byte)(250)))));
            this.gridView1.Appearance.EvenRow.Options.UseBackColor = true;
            this.gridView1.Appearance.OddRow.BackColor = System.Drawing.Color.White;
            this.gridView1.Appearance.OddRow.Options.UseBackColor = true;
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colInStoreNo,
            this.colDriverName,
            this.colDriverTel,
            this.colDriverBusNumber,
            this.colDriverDt,
            this.colEmpInfo,
            this.colEmpTel,
            this.colSuppCode,
            this.colActualAmount,
            this.colModifyDt,
            this.colModifyUser,
            this.colCreateDt,
            this.colCreateUser,
            this.colRemarks,
            this.colVersion,
            this.colId,
            this.colStoreInDate,
            this.colStockArea,
            this.colDeliveryNo});
            this.gridView1.GridControl = this.ykGridControl1;
            this.gridView1.IndicatorWidth = 40;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsBehavior.ReadOnly = true;
            this.gridView1.OptionsFind.AlwaysVisible = true;
            this.gridView1.OptionsView.EnableAppearanceEvenRow = true;
            this.gridView1.OptionsView.EnableAppearanceOddRow = true;
            this.gridView1.OptionsView.ShowFilterPanelMode = DevExpress.XtraGrid.Views.Base.ShowFilterPanelMode.Never;
            this.gridView1.OptionsView.ShowGroupPanel = false;
            // 
            // colInStoreNo
            // 
            this.colInStoreNo.Caption = "入库单号";
            this.colInStoreNo.FieldName = "InStoreNo";
            this.colInStoreNo.Name = "colInStoreNo";
            this.colInStoreNo.Visible = true;
            this.colInStoreNo.VisibleIndex = 1;
            // 
            // colDriverName
            // 
            this.colDriverName.Caption = "司机名称";
            this.colDriverName.FieldName = "DriverName";
            this.colDriverName.Name = "colDriverName";
            this.colDriverName.Visible = true;
            this.colDriverName.VisibleIndex = 7;
            // 
            // colDriverTel
            // 
            this.colDriverTel.Caption = "司机电话";
            this.colDriverTel.FieldName = "DriverTel";
            this.colDriverTel.Name = "colDriverTel";
            this.colDriverTel.Visible = true;
            this.colDriverTel.VisibleIndex = 8;
            // 
            // colDriverBusNumber
            // 
            this.colDriverBusNumber.Caption = "车牌号";
            this.colDriverBusNumber.FieldName = "DriverBusNumber";
            this.colDriverBusNumber.Name = "colDriverBusNumber";
            this.colDriverBusNumber.Visible = true;
            this.colDriverBusNumber.VisibleIndex = 9;
            // 
            // colDriverDt
            // 
            this.colDriverDt.Caption = "送货时间";
            this.colDriverDt.FieldName = "DriverDt";
            this.colDriverDt.Name = "colDriverDt";
            this.colDriverDt.Visible = true;
            this.colDriverDt.VisibleIndex = 6;
            // 
            // colEmpInfo
            // 
            this.colEmpInfo.Caption = "业务联系人";
            this.colEmpInfo.FieldName = "EmpInfo";
            this.colEmpInfo.Name = "colEmpInfo";
            this.colEmpInfo.Visible = true;
            this.colEmpInfo.VisibleIndex = 10;
            // 
            // colEmpTel
            // 
            this.colEmpTel.Caption = "业务员电话";
            this.colEmpTel.FieldName = "EmpTel";
            this.colEmpTel.Name = "colEmpTel";
            this.colEmpTel.Visible = true;
            this.colEmpTel.VisibleIndex = 11;
            // 
            // colSuppCode
            // 
            this.colSuppCode.Caption = "供应商";
            this.colSuppCode.ColumnEdit = this.repositorySuppCode;
            this.colSuppCode.FieldName = "SuppCode";
            this.colSuppCode.Name = "colSuppCode";
            this.colSuppCode.Visible = true;
            this.colSuppCode.VisibleIndex = 3;
            // 
            // repositorySuppCode
            // 
            this.repositorySuppCode.AutoHeight = false;
            this.repositorySuppCode.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositorySuppCode.Name = "repositorySuppCode";
            this.repositorySuppCode.View = this.gridView2;
            // 
            // gridView2
            // 
            this.gridView2.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.gridView2.Name = "gridView2";
            this.gridView2.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.gridView2.OptionsView.ShowGroupPanel = false;
            // 
            // colActualAmount
            // 
            this.colActualAmount.Caption = "入库数量";
            this.colActualAmount.FieldName = "ActualAmount";
            this.colActualAmount.Name = "colActualAmount";
            this.colActualAmount.Visible = true;
            this.colActualAmount.VisibleIndex = 4;
            // 
            // colModifyDt
            // 
            this.colModifyDt.Caption = "修改时间";
            this.colModifyDt.FieldName = "ModifyDt";
            this.colModifyDt.Name = "colModifyDt";
            this.colModifyDt.Visible = true;
            this.colModifyDt.VisibleIndex = 14;
            // 
            // colModifyUser
            // 
            this.colModifyUser.Caption = "修改者";
            this.colModifyUser.FieldName = "ModifyUser";
            this.colModifyUser.Name = "colModifyUser";
            this.colModifyUser.Visible = true;
            this.colModifyUser.VisibleIndex = 15;
            // 
            // colCreateDt
            // 
            this.colCreateDt.Caption = "录入日期";
            this.colCreateDt.FieldName = "CreateDt";
            this.colCreateDt.Name = "colCreateDt";
            this.colCreateDt.Visible = true;
            this.colCreateDt.VisibleIndex = 13;
            // 
            // colCreateUser
            // 
            this.colCreateUser.Caption = "录入员";
            this.colCreateUser.FieldName = "CreateUser";
            this.colCreateUser.Name = "colCreateUser";
            this.colCreateUser.Visible = true;
            this.colCreateUser.VisibleIndex = 12;
            // 
            // colRemarks
            // 
            this.colRemarks.FieldName = "Remarks";
            this.colRemarks.Name = "colRemarks";
            // 
            // colVersion
            // 
            this.colVersion.FieldName = "Version";
            this.colVersion.Name = "colVersion";
            // 
            // colId
            // 
            this.colId.FieldName = "Id";
            this.colId.Name = "colId";
            // 
            // colStoreInDate
            // 
            this.colStoreInDate.Caption = "入库时间";
            this.colStoreInDate.FieldName = "StoreInDate";
            this.colStoreInDate.Name = "colStoreInDate";
            this.colStoreInDate.Visible = true;
            this.colStoreInDate.VisibleIndex = 2;
            // 
            // colStockArea
            // 
            this.colStockArea.Caption = "仓库";
            this.colStockArea.FieldName = "StockArea";
            this.colStockArea.Name = "colStockArea";
            this.colStockArea.Visible = true;
            this.colStockArea.VisibleIndex = 0;
            // 
            // colDeliveryNo
            // 
            this.colDeliveryNo.Caption = "送货单号";
            this.colDeliveryNo.FieldName = "DeliveryNo";
            this.colDeliveryNo.Name = "colDeliveryNo";
            this.colDeliveryNo.Visible = true;
            this.colDeliveryNo.VisibleIndex = 5;
            // 
            // splitContainerControl1
            // 
            this.splitContainerControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainerControl1.Horizontal = false;
            this.splitContainerControl1.Location = new System.Drawing.Point(0, 0);
            this.splitContainerControl1.Name = "splitContainerControl1";
            this.splitContainerControl1.Panel1.Controls.Add(this.ykGridControl1);
            this.splitContainerControl1.Panel1.Text = "Panel1";
            this.splitContainerControl1.Panel2.Controls.Add(this.gridControl1);
            this.splitContainerControl1.Panel2.Text = "Panel2";
            this.splitContainerControl1.Size = new System.Drawing.Size(812, 443);
            this.splitContainerControl1.SplitterPosition = 301;
            this.splitContainerControl1.TabIndex = 5;
            this.splitContainerControl1.Text = "splitContainerControl1";
            // 
            // gridControl1
            // 
            this.gridControl1.Cursor = System.Windows.Forms.Cursors.Default;
            this.gridControl1.DataSource = this.wMSC102InStoreDetailBindingSource;
            this.gridControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControl1.Location = new System.Drawing.Point(0, 0);
            this.gridControl1.MainView = this.gridInstoreDetail;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryItemLotNo});
            this.gridControl1.Size = new System.Drawing.Size(812, 137);
            this.gridControl1.TabIndex = 18;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridInstoreDetail});
            // 
            // wMSC102InStoreDetailBindingSource
            // 
            this.wMSC102InStoreDetailBindingSource.DataSource = typeof(ERP.Domain.WMS_C102_InStoreDetail);
            // 
            // gridInstoreDetail
            // 
            this.gridInstoreDetail.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colInStoreId,
            this.gridColumn1,
            this.colARCode,
            this.colPartSpec,
            this.colAmount,
            this.colSuppLot,
            this.gridColumn2,
            this.gridColumn3,
            this.gridColumn4,
            this.gridColumn5,
            this.gridColumn6,
            this.gridColumn7,
            this.colMatClass2,
            this.colMatCode,
            this.colRemarks1,
            this.colSumPrice,
            this.colUnit,
            this.colUnitPrice});
            this.gridInstoreDetail.GridControl = this.gridControl1;
            this.gridInstoreDetail.Name = "gridInstoreDetail";
            this.gridInstoreDetail.OptionsView.ShowFooter = true;
            this.gridInstoreDetail.OptionsView.ShowGroupPanel = false;
            // 
            // colInStoreId
            // 
            this.colInStoreId.FieldName = "InStoreId";
            this.colInStoreId.Name = "colInStoreId";
            // 
            // gridColumn1
            // 
            this.gridColumn1.FieldName = "InStoreNo";
            this.gridColumn1.Name = "gridColumn1";
            // 
            // colARCode
            // 
            this.colARCode.Caption = "区域";
            this.colARCode.FieldName = "ARCode";
            this.colARCode.Name = "colARCode";
            this.colARCode.Visible = true;
            this.colARCode.VisibleIndex = 0;
            // 
            // colPartSpec
            // 
            this.colPartSpec.Caption = "规格";
            this.colPartSpec.FieldName = "PartSpec";
            this.colPartSpec.Name = "colPartSpec";
            this.colPartSpec.Visible = true;
            this.colPartSpec.VisibleIndex = 2;
            // 
            // colAmount
            // 
            this.colAmount.Caption = "数量";
            this.colAmount.FieldName = "Amount";
            this.colAmount.Name = "colAmount";
            this.colAmount.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum)});
            this.colAmount.Visible = true;
            this.colAmount.VisibleIndex = 4;
            // 
            // colSuppLot
            // 
            this.colSuppLot.Caption = "供应商批号";
            this.colSuppLot.FieldName = "SuppLot";
            this.colSuppLot.Name = "colSuppLot";
            this.colSuppLot.Visible = true;
            this.colSuppLot.VisibleIndex = 5;
            // 
            // gridColumn2
            // 
            this.gridColumn2.FieldName = "ModifyDt";
            this.gridColumn2.Name = "gridColumn2";
            // 
            // gridColumn3
            // 
            this.gridColumn3.FieldName = "ModifyUser";
            this.gridColumn3.Name = "gridColumn3";
            // 
            // gridColumn4
            // 
            this.gridColumn4.FieldName = "CreateDt";
            this.gridColumn4.Name = "gridColumn4";
            // 
            // gridColumn5
            // 
            this.gridColumn5.FieldName = "CreateUser";
            this.gridColumn5.Name = "gridColumn5";
            // 
            // gridColumn6
            // 
            this.gridColumn6.FieldName = "Version";
            this.gridColumn6.Name = "gridColumn6";
            // 
            // gridColumn7
            // 
            this.gridColumn7.FieldName = "Id";
            this.gridColumn7.Name = "gridColumn7";
            // 
            // colMatClass2
            // 
            this.colMatClass2.Caption = "材质";
            this.colMatClass2.FieldName = "MatClass2";
            this.colMatClass2.Name = "colMatClass2";
            this.colMatClass2.Visible = true;
            this.colMatClass2.VisibleIndex = 3;
            // 
            // colMatCode
            // 
            this.colMatCode.Caption = "物料";
            this.colMatCode.FieldName = "MatCode";
            this.colMatCode.Name = "colMatCode";
            this.colMatCode.Visible = true;
            this.colMatCode.VisibleIndex = 1;
            // 
            // colRemarks1
            // 
            this.colRemarks1.Caption = "备注";
            this.colRemarks1.FieldName = "Remarks";
            this.colRemarks1.Name = "colRemarks1";
            this.colRemarks1.Visible = true;
            this.colRemarks1.VisibleIndex = 9;
            // 
            // colSumPrice
            // 
            this.colSumPrice.Caption = "金额";
            this.colSumPrice.FieldName = "SumPrice";
            this.colSumPrice.Name = "colSumPrice";
            this.colSumPrice.Visible = true;
            this.colSumPrice.VisibleIndex = 8;
            // 
            // colUnit
            // 
            this.colUnit.Caption = "单位";
            this.colUnit.FieldName = "Unit";
            this.colUnit.Name = "colUnit";
            this.colUnit.Visible = true;
            this.colUnit.VisibleIndex = 6;
            // 
            // colUnitPrice
            // 
            this.colUnitPrice.Caption = "单价";
            this.colUnitPrice.FieldName = "UnitPrice";
            this.colUnitPrice.Name = "colUnitPrice";
            this.colUnitPrice.Visible = true;
            this.colUnitPrice.VisibleIndex = 7;
            // 
            // repositoryItemLotNo
            // 
            this.repositoryItemLotNo.AutoHeight = false;
            this.repositoryItemLotNo.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryItemLotNo.DisplayMember = "LotNo";
            this.repositoryItemLotNo.Name = "repositoryItemLotNo";
            this.repositoryItemLotNo.NullText = "";
            this.repositoryItemLotNo.ValueMember = "LotNo";
            this.repositoryItemLotNo.View = this.repositoryItemGridLookUpEdit1View;
            // 
            // repositoryItemGridLookUpEdit1View
            // 
            this.repositoryItemGridLookUpEdit1View.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.repositoryItemGridLookUpEdit1View.Name = "repositoryItemGridLookUpEdit1View";
            this.repositoryItemGridLookUpEdit1View.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.repositoryItemGridLookUpEdit1View.OptionsView.ShowGroupPanel = false;
            // 
            // InStoreForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(812, 472);
            this.Controls.Add(this.splitContainerControl1);
            this.Name = "InStoreForm";
            this.Text = "InStoreForm";
            this.Controls.SetChildIndex(this.splitContainerControl1, 0);
            ((System.ComponentModel.ISupportInitialize)(this.ykGridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.wMSC101InStoreBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositorySuppCode)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl1)).EndInit();
            this.splitContainerControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.wMSC102InStoreDetailBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridInstoreDetail)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemLotNo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemGridLookUpEdit1View)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private COM.YKControls.YKGridControl ykGridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private System.Windows.Forms.BindingSource wMSC101InStoreBindingSource;
        private DevExpress.XtraGrid.Columns.GridColumn colInStoreNo;
        private DevExpress.XtraGrid.Columns.GridColumn colDriverName;
        private DevExpress.XtraGrid.Columns.GridColumn colDriverTel;
        private DevExpress.XtraGrid.Columns.GridColumn colDriverBusNumber;
        private DevExpress.XtraGrid.Columns.GridColumn colDriverDt;
        private DevExpress.XtraGrid.Columns.GridColumn colEmpInfo;
        private DevExpress.XtraGrid.Columns.GridColumn colEmpTel;
        private DevExpress.XtraGrid.Columns.GridColumn colSuppCode;
        private DevExpress.XtraGrid.Columns.GridColumn colActualAmount;
        private DevExpress.XtraGrid.Columns.GridColumn colModifyDt;
        private DevExpress.XtraGrid.Columns.GridColumn colModifyUser;
        private DevExpress.XtraGrid.Columns.GridColumn colCreateDt;
        private DevExpress.XtraGrid.Columns.GridColumn colCreateUser;
        private DevExpress.XtraGrid.Columns.GridColumn colRemarks;
        private DevExpress.XtraGrid.Columns.GridColumn colVersion;
        private DevExpress.XtraGrid.Columns.GridColumn colId;
        private DevExpress.XtraEditors.SplitContainerControl splitContainerControl1;
        private DevExpress.XtraGrid.GridControl gridControl1;
        private System.Windows.Forms.BindingSource wMSC102InStoreDetailBindingSource;
        private DevExpress.XtraGrid.Views.Grid.GridView gridInstoreDetail;
        private DevExpress.XtraGrid.Columns.GridColumn colInStoreId;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn1;
        private DevExpress.XtraGrid.Columns.GridColumn colARCode;
        private DevExpress.XtraGrid.Columns.GridColumn colPartSpec;
        private DevExpress.XtraGrid.Columns.GridColumn colAmount;
        private DevExpress.XtraGrid.Columns.GridColumn colSuppLot;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn2;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn3;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn4;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn5;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn6;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn7;
        private DevExpress.XtraEditors.Repository.RepositoryItemGridLookUpEdit repositoryItemLotNo;
        private DevExpress.XtraGrid.Views.Grid.GridView repositoryItemGridLookUpEdit1View;
        private DevExpress.XtraEditors.Repository.RepositoryItemGridLookUpEdit repositorySuppCode;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView2;
        private DevExpress.XtraGrid.Columns.GridColumn colStoreInDate;
        private DevExpress.XtraGrid.Columns.GridColumn colStockArea;
        private DevExpress.XtraGrid.Columns.GridColumn colDeliveryNo;
        private DevExpress.XtraGrid.Columns.GridColumn colMatClass2;
        private DevExpress.XtraGrid.Columns.GridColumn colMatCode;
        private DevExpress.XtraGrid.Columns.GridColumn colRemarks1;
        private DevExpress.XtraGrid.Columns.GridColumn colSumPrice;
        private DevExpress.XtraGrid.Columns.GridColumn colUnit;
        private DevExpress.XtraGrid.Columns.GridColumn colUnitPrice;
    }
}