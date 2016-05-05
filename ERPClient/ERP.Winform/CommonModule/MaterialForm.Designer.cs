namespace ERP.Winform.CommonModule
{
    partial class MaterialForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MaterialForm));
            this.eRPM001MaterialBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ykGridControl1 = new COM.YKControls.YKGridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colCompCode = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMatCode = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMatLevel = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMatClass1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMatClass2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMatClass3 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMatName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMatSpec = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colLocation = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colUnit = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colQty = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSaftyQty = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colStatus = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colRemarks = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colModifyDt = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colModifyUser = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCreateDt = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCreateUser = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colVersion = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colId = new DevExpress.XtraGrid.Columns.GridColumn();
            this.splitContainerControl1 = new DevExpress.XtraEditors.SplitContainerControl();
            this.treeView1 = new System.Windows.Forms.TreeView();
            this.splitContainerControl2 = new DevExpress.XtraEditors.SplitContainerControl();
            this.gridControlSupplier = new DevExpress.XtraGrid.GridControl();
            this.gridView2 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridColumn1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSuppCode = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositorySuppCode = new DevExpress.XtraEditors.Repository.RepositoryItemGridLookUpEdit();
            this.repositoryItemGridLookUpEdit1View = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colLevel = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn3 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colUnitPrice = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDeliveryTerm = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPayTerm = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn4 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn5 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn6 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn7 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn8 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn9 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn10 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPurPer = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDeliveryDays = new DevExpress.XtraGrid.Columns.GridColumn();
            this.eRPM001MaterialSuppBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.eRPM001MaterialBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ykGridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl1)).BeginInit();
            this.splitContainerControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl2)).BeginInit();
            this.splitContainerControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControlSupplier)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositorySuppCode)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemGridLookUpEdit1View)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.eRPM001MaterialSuppBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // eRPM001MaterialBindingSource
            // 
            this.eRPM001MaterialBindingSource.DataSource = typeof(ERP.Domain.ERP_M001_Material);
            // 
            // ykGridControl1
            // 
            this.ykGridControl1.Cursor = System.Windows.Forms.Cursors.Default;
            this.ykGridControl1.DataSource = this.eRPM001MaterialBindingSource;
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
            this.ykGridControl1.Size = new System.Drawing.Size(774, 402);
            this.ykGridControl1.TabIndex = 6;
            this.ykGridControl1.UseEmbeddedNavigator = true;
            this.ykGridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.Appearance.EvenRow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(234)))), ((int)(((byte)(250)))));
            this.gridView1.Appearance.EvenRow.Options.UseBackColor = true;
            this.gridView1.Appearance.OddRow.BackColor = System.Drawing.Color.White;
            this.gridView1.Appearance.OddRow.Options.UseBackColor = true;
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colCompCode,
            this.colMatCode,
            this.colMatLevel,
            this.colMatClass1,
            this.colMatClass2,
            this.colMatClass3,
            this.colMatName,
            this.colMatSpec,
            this.colLocation,
            this.colUnit,
            this.colQty,
            this.colSaftyQty,
            this.colStatus,
            this.colRemarks,
            this.colModifyDt,
            this.colModifyUser,
            this.colCreateDt,
            this.colCreateUser,
            this.colVersion,
            this.colId});
            this.gridView1.GridControl = this.ykGridControl1;
            this.gridView1.IndicatorWidth = 40;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsBehavior.ReadOnly = true;
            this.gridView1.OptionsFind.AlwaysVisible = true;
            this.gridView1.OptionsView.ColumnAutoWidth = false;
            this.gridView1.OptionsView.EnableAppearanceEvenRow = true;
            this.gridView1.OptionsView.EnableAppearanceOddRow = true;
            this.gridView1.OptionsView.ShowFilterPanelMode = DevExpress.XtraGrid.Views.Base.ShowFilterPanelMode.Never;
            this.gridView1.OptionsView.ShowGroupPanel = false;
            this.gridView1.FocusedRowChanged += new DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventHandler(this.gridView1_FocusedRowChanged);
            // 
            // colCompCode
            // 
            this.colCompCode.FieldName = "CompCode";
            this.colCompCode.Name = "colCompCode";
            // 
            // colMatCode
            // 
            this.colMatCode.Caption = "物料编号";
            this.colMatCode.FieldName = "MatCode";
            this.colMatCode.Name = "colMatCode";
            this.colMatCode.Visible = true;
            this.colMatCode.VisibleIndex = 4;
            // 
            // colMatLevel
            // 
            this.colMatLevel.Caption = "物料等级";
            this.colMatLevel.FieldName = "MatLevel";
            this.colMatLevel.Name = "colMatLevel";
            this.colMatLevel.Visible = true;
            this.colMatLevel.VisibleIndex = 0;
            // 
            // colMatClass1
            // 
            this.colMatClass1.Caption = "物料类别1";
            this.colMatClass1.FieldName = "MatClass1";
            this.colMatClass1.Name = "colMatClass1";
            this.colMatClass1.Visible = true;
            this.colMatClass1.VisibleIndex = 1;
            // 
            // colMatClass2
            // 
            this.colMatClass2.Caption = "物料类别2";
            this.colMatClass2.FieldName = "MatClass2";
            this.colMatClass2.Name = "colMatClass2";
            this.colMatClass2.Visible = true;
            this.colMatClass2.VisibleIndex = 2;
            // 
            // colMatClass3
            // 
            this.colMatClass3.Caption = "物料类别3";
            this.colMatClass3.FieldName = "MatClass3";
            this.colMatClass3.Name = "colMatClass3";
            this.colMatClass3.Visible = true;
            this.colMatClass3.VisibleIndex = 3;
            // 
            // colMatName
            // 
            this.colMatName.Caption = "物料名称";
            this.colMatName.FieldName = "MatName";
            this.colMatName.Name = "colMatName";
            this.colMatName.Visible = true;
            this.colMatName.VisibleIndex = 5;
            // 
            // colMatSpec
            // 
            this.colMatSpec.Caption = "物料规格";
            this.colMatSpec.FieldName = "MatSpec";
            this.colMatSpec.Name = "colMatSpec";
            this.colMatSpec.Visible = true;
            this.colMatSpec.VisibleIndex = 6;
            // 
            // colLocation
            // 
            this.colLocation.Caption = "存储位置";
            this.colLocation.FieldName = "Location";
            this.colLocation.Name = "colLocation";
            this.colLocation.Visible = true;
            this.colLocation.VisibleIndex = 7;
            // 
            // colUnit
            // 
            this.colUnit.Caption = "单位";
            this.colUnit.FieldName = "Unit";
            this.colUnit.Name = "colUnit";
            this.colUnit.Visible = true;
            this.colUnit.VisibleIndex = 8;
            // 
            // colQty
            // 
            this.colQty.Caption = "数量";
            this.colQty.DisplayFormat.FormatString = "n0";
            this.colQty.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colQty.FieldName = "Qty";
            this.colQty.Name = "colQty";
            this.colQty.Visible = true;
            this.colQty.VisibleIndex = 9;
            // 
            // colSaftyQty
            // 
            this.colSaftyQty.Caption = "安全库存";
            this.colSaftyQty.DisplayFormat.FormatString = "n0";
            this.colSaftyQty.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colSaftyQty.FieldName = "SaftyQty";
            this.colSaftyQty.Name = "colSaftyQty";
            this.colSaftyQty.Visible = true;
            this.colSaftyQty.VisibleIndex = 10;
            // 
            // colStatus
            // 
            this.colStatus.Caption = "状态";
            this.colStatus.FieldName = "Status";
            this.colStatus.Name = "colStatus";
            this.colStatus.Visible = true;
            this.colStatus.VisibleIndex = 11;
            // 
            // colRemarks
            // 
            this.colRemarks.Caption = "备注";
            this.colRemarks.FieldName = "Remarks";
            this.colRemarks.Name = "colRemarks";
            this.colRemarks.Visible = true;
            this.colRemarks.VisibleIndex = 12;
            // 
            // colModifyDt
            // 
            this.colModifyDt.Caption = "修改日期";
            this.colModifyDt.FieldName = "ModifyDt";
            this.colModifyDt.Name = "colModifyDt";
            this.colModifyDt.Visible = true;
            this.colModifyDt.VisibleIndex = 13;
            // 
            // colModifyUser
            // 
            this.colModifyUser.Caption = "修改者";
            this.colModifyUser.FieldName = "ModifyUser";
            this.colModifyUser.Name = "colModifyUser";
            this.colModifyUser.Visible = true;
            this.colModifyUser.VisibleIndex = 14;
            // 
            // colCreateDt
            // 
            this.colCreateDt.Caption = "创建日期";
            this.colCreateDt.FieldName = "CreateDt";
            this.colCreateDt.Name = "colCreateDt";
            this.colCreateDt.Visible = true;
            this.colCreateDt.VisibleIndex = 15;
            // 
            // colCreateUser
            // 
            this.colCreateUser.Caption = "创建者";
            this.colCreateUser.FieldName = "CreateUser";
            this.colCreateUser.Name = "colCreateUser";
            this.colCreateUser.Visible = true;
            this.colCreateUser.VisibleIndex = 16;
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
            // splitContainerControl1
            // 
            this.splitContainerControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainerControl1.Location = new System.Drawing.Point(0, 0);
            this.splitContainerControl1.Name = "splitContainerControl1";
            this.splitContainerControl1.Panel1.Controls.Add(this.treeView1);
            this.splitContainerControl1.Panel1.Text = "Panel1";
            this.splitContainerControl1.Panel2.Controls.Add(this.splitContainerControl2);
            this.splitContainerControl1.Panel2.Text = "Panel2";
            this.splitContainerControl1.Size = new System.Drawing.Size(957, 479);
            this.splitContainerControl1.SplitterPosition = 178;
            this.splitContainerControl1.TabIndex = 7;
            this.splitContainerControl1.Text = "splitContainerControl1";
            // 
            // treeView1
            // 
            this.treeView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.treeView1.Location = new System.Drawing.Point(0, 0);
            this.treeView1.Name = "treeView1";
            this.treeView1.Size = new System.Drawing.Size(178, 479);
            this.treeView1.TabIndex = 2;
            // 
            // splitContainerControl2
            // 
            this.splitContainerControl2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainerControl2.Horizontal = false;
            this.splitContainerControl2.Location = new System.Drawing.Point(0, 0);
            this.splitContainerControl2.Name = "splitContainerControl2";
            this.splitContainerControl2.Panel1.Controls.Add(this.ykGridControl1);
            this.splitContainerControl2.Panel1.Text = "Panel1";
            this.splitContainerControl2.Panel2.Controls.Add(this.gridControlSupplier);
            this.splitContainerControl2.Panel2.Text = "Panel2";
            this.splitContainerControl2.Size = new System.Drawing.Size(774, 479);
            this.splitContainerControl2.SplitterPosition = 402;
            this.splitContainerControl2.TabIndex = 7;
            this.splitContainerControl2.Text = "splitContainerControl2";
            // 
            // gridControlSupplier
            // 
            this.gridControlSupplier.Cursor = System.Windows.Forms.Cursors.Default;
            this.gridControlSupplier.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControlSupplier.Location = new System.Drawing.Point(0, 0);
            this.gridControlSupplier.MainView = this.gridView2;
            this.gridControlSupplier.Name = "gridControlSupplier";
            this.gridControlSupplier.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositorySuppCode});
            this.gridControlSupplier.Size = new System.Drawing.Size(774, 72);
            this.gridControlSupplier.TabIndex = 2;
            this.gridControlSupplier.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView2});
            // 
            // gridView2
            // 
            this.gridView2.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gridColumn1,
            this.gridColumn2,
            this.colSuppCode,
            this.colLevel,
            this.gridColumn3,
            this.colUnitPrice,
            this.colDeliveryTerm,
            this.colPayTerm,
            this.gridColumn4,
            this.gridColumn5,
            this.gridColumn6,
            this.gridColumn7,
            this.gridColumn8,
            this.gridColumn9,
            this.gridColumn10,
            this.colPurPer,
            this.colDeliveryDays});
            this.gridView2.GridControl = this.gridControlSupplier;
            this.gridView2.Name = "gridView2";
            this.gridView2.OptionsBehavior.ReadOnly = true;
            this.gridView2.OptionsView.ShowGroupPanel = false;
            // 
            // gridColumn1
            // 
            this.gridColumn1.FieldName = "CompCode";
            this.gridColumn1.Name = "gridColumn1";
            // 
            // gridColumn2
            // 
            this.gridColumn2.FieldName = "MatCode";
            this.gridColumn2.Name = "gridColumn2";
            // 
            // colSuppCode
            // 
            this.colSuppCode.Caption = "供应商代号";
            this.colSuppCode.ColumnEdit = this.repositorySuppCode;
            this.colSuppCode.FieldName = "SuppCode";
            this.colSuppCode.Name = "colSuppCode";
            this.colSuppCode.Visible = true;
            this.colSuppCode.VisibleIndex = 0;
            // 
            // repositorySuppCode
            // 
            this.repositorySuppCode.AutoHeight = false;
            this.repositorySuppCode.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositorySuppCode.Name = "repositorySuppCode";
            this.repositorySuppCode.View = this.repositoryItemGridLookUpEdit1View;
            // 
            // repositoryItemGridLookUpEdit1View
            // 
            this.repositoryItemGridLookUpEdit1View.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.repositoryItemGridLookUpEdit1View.Name = "repositoryItemGridLookUpEdit1View";
            this.repositoryItemGridLookUpEdit1View.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.repositoryItemGridLookUpEdit1View.OptionsView.ShowGroupPanel = false;
            // 
            // colLevel
            // 
            this.colLevel.Caption = "供应商等级";
            this.colLevel.FieldName = "Level";
            this.colLevel.Name = "colLevel";
            this.colLevel.Visible = true;
            this.colLevel.VisibleIndex = 1;
            // 
            // gridColumn3
            // 
            this.gridColumn3.Caption = "单位";
            this.gridColumn3.FieldName = "Unit";
            this.gridColumn3.Name = "gridColumn3";
            this.gridColumn3.Visible = true;
            this.gridColumn3.VisibleIndex = 2;
            // 
            // colUnitPrice
            // 
            this.colUnitPrice.Caption = "单价";
            this.colUnitPrice.DisplayFormat.FormatString = "n0";
            this.colUnitPrice.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colUnitPrice.FieldName = "UnitPrice";
            this.colUnitPrice.Name = "colUnitPrice";
            this.colUnitPrice.Visible = true;
            this.colUnitPrice.VisibleIndex = 3;
            // 
            // colDeliveryTerm
            // 
            this.colDeliveryTerm.Caption = "供货方式";
            this.colDeliveryTerm.FieldName = "DeliveryTerm";
            this.colDeliveryTerm.Name = "colDeliveryTerm";
            this.colDeliveryTerm.Visible = true;
            this.colDeliveryTerm.VisibleIndex = 5;
            // 
            // colPayTerm
            // 
            this.colPayTerm.Caption = "付款方式";
            this.colPayTerm.FieldName = "PayTerm";
            this.colPayTerm.Name = "colPayTerm";
            this.colPayTerm.Visible = true;
            this.colPayTerm.VisibleIndex = 7;
            // 
            // gridColumn4
            // 
            this.gridColumn4.Caption = "备注";
            this.gridColumn4.FieldName = "Remarks";
            this.gridColumn4.Name = "gridColumn4";
            this.gridColumn4.Visible = true;
            this.gridColumn4.VisibleIndex = 8;
            // 
            // gridColumn5
            // 
            this.gridColumn5.FieldName = "ModifyDt";
            this.gridColumn5.Name = "gridColumn5";
            // 
            // gridColumn6
            // 
            this.gridColumn6.FieldName = "ModifyUser";
            this.gridColumn6.Name = "gridColumn6";
            // 
            // gridColumn7
            // 
            this.gridColumn7.FieldName = "CreateDt";
            this.gridColumn7.Name = "gridColumn7";
            // 
            // gridColumn8
            // 
            this.gridColumn8.FieldName = "CreateUser";
            this.gridColumn8.Name = "gridColumn8";
            // 
            // gridColumn9
            // 
            this.gridColumn9.FieldName = "Version";
            this.gridColumn9.Name = "gridColumn9";
            // 
            // gridColumn10
            // 
            this.gridColumn10.FieldName = "Id";
            this.gridColumn10.Name = "gridColumn10";
            // 
            // colPurPer
            // 
            this.colPurPer.Caption = "默认采购比例";
            this.colPurPer.DisplayFormat.FormatString = "p";
            this.colPurPer.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colPurPer.FieldName = "PurPer";
            this.colPurPer.Name = "colPurPer";
            this.colPurPer.Visible = true;
            this.colPurPer.VisibleIndex = 4;
            // 
            // colDeliveryDays
            // 
            this.colDeliveryDays.Caption = "交货天数";
            this.colDeliveryDays.DisplayFormat.FormatString = "{0:N0}";
            this.colDeliveryDays.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colDeliveryDays.FieldName = "DeliveryDays";
            this.colDeliveryDays.Name = "colDeliveryDays";
            this.colDeliveryDays.Visible = true;
            this.colDeliveryDays.VisibleIndex = 6;
            // 
            // eRPM001MaterialSuppBindingSource
            // 
            this.eRPM001MaterialSuppBindingSource.DataSource = typeof(ERP.Domain.ERP_M001_Material_Supp);
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "0.png");
            // 
            // MaterialForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(957, 508);
            this.Controls.Add(this.splitContainerControl1);
            this.Name = "MaterialForm";
            this.Text = "物料资料";
            this.Controls.SetChildIndex(this.splitContainerControl1, 0);
            ((System.ComponentModel.ISupportInitialize)(this.eRPM001MaterialBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ykGridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl1)).EndInit();
            this.splitContainerControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl2)).EndInit();
            this.splitContainerControl2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridControlSupplier)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositorySuppCode)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemGridLookUpEdit1View)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.eRPM001MaterialSuppBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.BindingSource eRPM001MaterialBindingSource;
        private COM.YKControls.YKGridControl ykGridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn colCompCode;
        private DevExpress.XtraGrid.Columns.GridColumn colMatCode;
        private DevExpress.XtraGrid.Columns.GridColumn colMatLevel;
        private DevExpress.XtraGrid.Columns.GridColumn colMatClass1;
        private DevExpress.XtraGrid.Columns.GridColumn colMatClass2;
        private DevExpress.XtraGrid.Columns.GridColumn colMatClass3;
        private DevExpress.XtraGrid.Columns.GridColumn colMatName;
        private DevExpress.XtraGrid.Columns.GridColumn colMatSpec;
        private DevExpress.XtraGrid.Columns.GridColumn colLocation;
        private DevExpress.XtraGrid.Columns.GridColumn colUnit;
        private DevExpress.XtraGrid.Columns.GridColumn colQty;
        private DevExpress.XtraGrid.Columns.GridColumn colSaftyQty;
        private DevExpress.XtraGrid.Columns.GridColumn colStatus;
        private DevExpress.XtraGrid.Columns.GridColumn colRemarks;
        private DevExpress.XtraGrid.Columns.GridColumn colModifyDt;
        private DevExpress.XtraGrid.Columns.GridColumn colModifyUser;
        private DevExpress.XtraGrid.Columns.GridColumn colCreateDt;
        private DevExpress.XtraGrid.Columns.GridColumn colCreateUser;
        private DevExpress.XtraGrid.Columns.GridColumn colVersion;
        private DevExpress.XtraGrid.Columns.GridColumn colId;
        private DevExpress.XtraEditors.SplitContainerControl splitContainerControl1;
        private DevExpress.XtraEditors.SplitContainerControl splitContainerControl2;
        private DevExpress.XtraGrid.GridControl gridControlSupplier;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView2;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn1;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn2;
        private DevExpress.XtraGrid.Columns.GridColumn colSuppCode;
        private DevExpress.XtraEditors.Repository.RepositoryItemGridLookUpEdit repositorySuppCode;
        private DevExpress.XtraGrid.Views.Grid.GridView repositoryItemGridLookUpEdit1View;
        private DevExpress.XtraGrid.Columns.GridColumn colLevel;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn3;
        private DevExpress.XtraGrid.Columns.GridColumn colUnitPrice;
        private DevExpress.XtraGrid.Columns.GridColumn colDeliveryTerm;
        private DevExpress.XtraGrid.Columns.GridColumn colPayTerm;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn4;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn5;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn6;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn7;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn8;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn9;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn10;
        private DevExpress.XtraGrid.Columns.GridColumn colPurPer;
        private DevExpress.XtraGrid.Columns.GridColumn colDeliveryDays;
        private System.Windows.Forms.BindingSource eRPM001MaterialSuppBindingSource;
        private System.Windows.Forms.TreeView treeView1;
        private System.Windows.Forms.ImageList imageList1;
    }
}