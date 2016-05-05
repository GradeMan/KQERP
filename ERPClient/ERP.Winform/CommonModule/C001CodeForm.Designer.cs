namespace ERP.Winform.CommonModule
{
    partial class C001CodeForm
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
            this.eRPC001CodeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colCompCode = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCodeID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCodeIDDesc = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCode = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDescription = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colGroupCode = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colGroupName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colStatus = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colRemarks = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colModifyDt = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colModifyUser = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCreateDt = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCreateUser = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colVersion = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colId = new DevExpress.XtraGrid.Columns.GridColumn();
            this.treeCodeType = new DevExpress.XtraTreeList.TreeList();
            this.colCompCode1 = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            this.colParentId = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            this.colIsTree = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            this.colCategory = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            this.colCode1 = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            this.colFullName = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            this.colRemark = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            this.colEnabled = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            this.colSortCode = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            this.colDeleteMark = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            this.colCreateDt1 = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            this.colCreateUser1 = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            this.colModifyDt1 = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            this.colModifyUser1 = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            this.colId1 = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            this.eRPC001CodeDictionaryBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.ykGridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.eRPC001CodeBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.treeCodeType)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.eRPC001CodeDictionaryBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // ykGridControl1
            // 
            this.ykGridControl1.Cursor = System.Windows.Forms.Cursors.Default;
            this.ykGridControl1.DataSource = this.eRPC001CodeBindingSource;
            this.ykGridControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ykGridControl1.EmbeddedNavigator.Buttons.Append.Visible = false;
            this.ykGridControl1.EmbeddedNavigator.Buttons.CancelEdit.Visible = false;
            this.ykGridControl1.EmbeddedNavigator.Buttons.Edit.Visible = false;
            this.ykGridControl1.EmbeddedNavigator.Buttons.EndEdit.Visible = false;
            this.ykGridControl1.EmbeddedNavigator.Buttons.Remove.Visible = false;
            this.ykGridControl1.EmbeddedNavigator.TextStringFormat = "第 {0} 总 {1}";
            this.ykGridControl1.Location = new System.Drawing.Point(205, 0);
            this.ykGridControl1.MainView = this.gridView1;
            this.ykGridControl1.MenuManager = this.barManager1;
            this.ykGridControl1.Name = "ykGridControl1";
            this.ykGridControl1.Size = new System.Drawing.Size(671, 485);
            this.ykGridControl1.TabIndex = 4;
            this.ykGridControl1.UseEmbeddedNavigator = true;
            this.ykGridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // eRPC001CodeBindingSource
            // 
            this.eRPC001CodeBindingSource.DataSource = typeof(ERP.Domain.ERP_C001_Code);
            // 
            // gridView1
            // 
            this.gridView1.Appearance.EvenRow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(234)))), ((int)(((byte)(250)))));
            this.gridView1.Appearance.EvenRow.Options.UseBackColor = true;
            this.gridView1.Appearance.OddRow.BackColor = System.Drawing.Color.White;
            this.gridView1.Appearance.OddRow.Options.UseBackColor = true;
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colCompCode,
            this.colCodeID,
            this.colCodeIDDesc,
            this.colCode,
            this.colDescription,
            this.colGroupCode,
            this.colGroupName,
            this.colStatus,
            this.colRemarks,
            this.colModifyDt,
            this.colModifyUser,
            this.colCreateDt,
            this.colCreateUser,
            this.colVersion,
            this.colId});
            this.gridView1.CustomizationFormBounds = new System.Drawing.Rectangle(858, 488, 210, 179);
            this.gridView1.GridControl = this.ykGridControl1;
            this.gridView1.IndicatorWidth = 40;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsBehavior.ReadOnly = true;
            this.gridView1.OptionsFind.AlwaysVisible = true;
            this.gridView1.OptionsView.EnableAppearanceEvenRow = true;
            this.gridView1.OptionsView.EnableAppearanceOddRow = true;
            this.gridView1.OptionsView.ShowFilterPanelMode = DevExpress.XtraGrid.Views.Base.ShowFilterPanelMode.Never;
            this.gridView1.OptionsView.ShowGroupPanel = false;
            this.gridView1.SortInfo.AddRange(new DevExpress.XtraGrid.Columns.GridColumnSortInfo[] {
            new DevExpress.XtraGrid.Columns.GridColumnSortInfo(this.colCodeIDDesc, DevExpress.Data.ColumnSortOrder.Ascending)});
            this.gridView1.DoubleClick += new System.EventHandler(this.gridView1_DoubleClick);
            // 
            // colCompCode
            // 
            this.colCompCode.Caption = "公司代号";
            this.colCompCode.FieldName = "CompCode";
            this.colCompCode.Name = "colCompCode";
            // 
            // colCodeID
            // 
            this.colCodeID.Caption = "类别代号";
            this.colCodeID.FieldName = "CodeID";
            this.colCodeID.Name = "colCodeID";
            // 
            // colCodeIDDesc
            // 
            this.colCodeIDDesc.Caption = "类别名称";
            this.colCodeIDDesc.FieldName = "CodeIDDesc";
            this.colCodeIDDesc.Name = "colCodeIDDesc";
            // 
            // colCode
            // 
            this.colCode.Caption = "代号";
            this.colCode.FieldName = "Code";
            this.colCode.Name = "colCode";
            this.colCode.Visible = true;
            this.colCode.VisibleIndex = 0;
            // 
            // colDescription
            // 
            this.colDescription.Caption = "描述";
            this.colDescription.FieldName = "Description";
            this.colDescription.Name = "colDescription";
            this.colDescription.Visible = true;
            this.colDescription.VisibleIndex = 1;
            // 
            // colGroupCode
            // 
            this.colGroupCode.Caption = "分组代号";
            this.colGroupCode.FieldName = "GroupCode";
            this.colGroupCode.Name = "colGroupCode";
            // 
            // colGroupName
            // 
            this.colGroupName.Caption = "分组";
            this.colGroupName.FieldName = "GroupName";
            this.colGroupName.Name = "colGroupName";
            this.colGroupName.Visible = true;
            this.colGroupName.VisibleIndex = 2;
            // 
            // colStatus
            // 
            this.colStatus.Caption = "状态";
            this.colStatus.FieldName = "Status";
            this.colStatus.Name = "colStatus";
            this.colStatus.Visible = true;
            this.colStatus.VisibleIndex = 3;
            // 
            // colRemarks
            // 
            this.colRemarks.Caption = "备注";
            this.colRemarks.FieldName = "Remarks";
            this.colRemarks.Name = "colRemarks";
            this.colRemarks.Visible = true;
            this.colRemarks.VisibleIndex = 4;
            // 
            // colModifyDt
            // 
            this.colModifyDt.FieldName = "ModifyDt";
            this.colModifyDt.Name = "colModifyDt";
            // 
            // colModifyUser
            // 
            this.colModifyUser.FieldName = "ModifyUser";
            this.colModifyUser.Name = "colModifyUser";
            // 
            // colCreateDt
            // 
            this.colCreateDt.FieldName = "CreateDt";
            this.colCreateDt.Name = "colCreateDt";
            // 
            // colCreateUser
            // 
            this.colCreateUser.FieldName = "CreateUser";
            this.colCreateUser.Name = "colCreateUser";
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
            // treeCodeType
            // 
            this.treeCodeType.Columns.AddRange(new DevExpress.XtraTreeList.Columns.TreeListColumn[] {
            this.colCompCode1,
            this.colParentId,
            this.colIsTree,
            this.colCategory,
            this.colCode1,
            this.colFullName,
            this.colRemark,
            this.colEnabled,
            this.colSortCode,
            this.colDeleteMark,
            this.colCreateDt1,
            this.colCreateUser1,
            this.colModifyDt1,
            this.colModifyUser1,
            this.colId1});
            this.treeCodeType.DataSource = this.eRPC001CodeDictionaryBindingSource;
            this.treeCodeType.Dock = System.Windows.Forms.DockStyle.Left;
            this.treeCodeType.Location = new System.Drawing.Point(0, 0);
            this.treeCodeType.Name = "treeCodeType";
            this.treeCodeType.OptionsBehavior.PopulateServiceColumns = true;
            this.treeCodeType.Size = new System.Drawing.Size(205, 485);
            this.treeCodeType.TabIndex = 5;
            // 
            // colCompCode1
            // 
            this.colCompCode1.FieldName = "CompCode";
            this.colCompCode1.Name = "colCompCode1";
            this.colCompCode1.Width = 20;
            // 
            // colParentId
            // 
            this.colParentId.FieldName = "ParentId";
            this.colParentId.Name = "colParentId";
            this.colParentId.Width = 74;
            // 
            // colIsTree
            // 
            this.colIsTree.FieldName = "IsTree";
            this.colIsTree.Name = "colIsTree";
            this.colIsTree.Width = 80;
            // 
            // colCategory
            // 
            this.colCategory.FieldName = "Category";
            this.colCategory.Name = "colCategory";
            this.colCategory.Width = 87;
            // 
            // colCode1
            // 
            this.colCode1.Caption = "代号";
            this.colCode1.FieldName = "Code";
            this.colCode1.Name = "colCode1";
            this.colCode1.Visible = true;
            this.colCode1.VisibleIndex = 0;
            this.colCode1.Width = 94;
            // 
            // colFullName
            // 
            this.colFullName.Caption = "类型名称";
            this.colFullName.FieldName = "FullName";
            this.colFullName.Name = "colFullName";
            this.colFullName.Visible = true;
            this.colFullName.VisibleIndex = 1;
            this.colFullName.Width = 93;
            // 
            // colRemark
            // 
            this.colRemark.FieldName = "Remark";
            this.colRemark.Name = "colRemark";
            this.colRemark.Width = 92;
            // 
            // colEnabled
            // 
            this.colEnabled.FieldName = "Enabled";
            this.colEnabled.Name = "colEnabled";
            this.colEnabled.Width = 92;
            // 
            // colSortCode
            // 
            this.colSortCode.FieldName = "SortCode";
            this.colSortCode.Name = "colSortCode";
            this.colSortCode.Width = 92;
            // 
            // colDeleteMark
            // 
            this.colDeleteMark.FieldName = "DeleteMark";
            this.colDeleteMark.Name = "colDeleteMark";
            this.colDeleteMark.Width = 92;
            // 
            // colCreateDt1
            // 
            this.colCreateDt1.FieldName = "CreateDt";
            this.colCreateDt1.Name = "colCreateDt1";
            this.colCreateDt1.Width = 91;
            // 
            // colCreateUser1
            // 
            this.colCreateUser1.FieldName = "CreateUser";
            this.colCreateUser1.Name = "colCreateUser1";
            this.colCreateUser1.Width = 91;
            // 
            // colModifyDt1
            // 
            this.colModifyDt1.FieldName = "ModifyDt";
            this.colModifyDt1.Name = "colModifyDt1";
            this.colModifyDt1.Width = 91;
            // 
            // colModifyUser1
            // 
            this.colModifyUser1.FieldName = "ModifyUser";
            this.colModifyUser1.Name = "colModifyUser1";
            this.colModifyUser1.Width = 91;
            // 
            // colId1
            // 
            this.colId1.FieldName = "Id";
            this.colId1.Name = "colId1";
            this.colId1.Width = 91;
            // 
            // eRPC001CodeDictionaryBindingSource
            // 
            this.eRPC001CodeDictionaryBindingSource.DataSource = typeof(ERP.Domain.ERP_C001_CodeDictionary);
            // 
            // C001CodeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(876, 514);
            this.Controls.Add(this.ykGridControl1);
            this.Controls.Add(this.treeCodeType);
            this.Name = "C001CodeForm";
            this.Text = "CodeForm";
            this.Controls.SetChildIndex(this.treeCodeType, 0);
            this.Controls.SetChildIndex(this.ykGridControl1, 0);
            ((System.ComponentModel.ISupportInitialize)(this.ykGridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.eRPC001CodeBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.treeCodeType)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.eRPC001CodeDictionaryBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private COM.YKControls.YKGridControl ykGridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private System.Windows.Forms.BindingSource eRPC001CodeBindingSource;
        private DevExpress.XtraGrid.Columns.GridColumn colCompCode;
        private DevExpress.XtraGrid.Columns.GridColumn colCodeID;
        private DevExpress.XtraGrid.Columns.GridColumn colCodeIDDesc;
        private DevExpress.XtraGrid.Columns.GridColumn colCode;
        private DevExpress.XtraGrid.Columns.GridColumn colDescription;
        private DevExpress.XtraGrid.Columns.GridColumn colGroupCode;
        private DevExpress.XtraGrid.Columns.GridColumn colGroupName;
        private DevExpress.XtraGrid.Columns.GridColumn colStatus;
        private DevExpress.XtraGrid.Columns.GridColumn colRemarks;
        private DevExpress.XtraGrid.Columns.GridColumn colModifyDt;
        private DevExpress.XtraGrid.Columns.GridColumn colModifyUser;
        private DevExpress.XtraGrid.Columns.GridColumn colCreateDt;
        private DevExpress.XtraGrid.Columns.GridColumn colCreateUser;
        private DevExpress.XtraGrid.Columns.GridColumn colVersion;
        private DevExpress.XtraGrid.Columns.GridColumn colId;
        private DevExpress.XtraTreeList.TreeList treeCodeType;
        private DevExpress.XtraTreeList.Columns.TreeListColumn colCompCode1;
        private DevExpress.XtraTreeList.Columns.TreeListColumn colParentId;
        private DevExpress.XtraTreeList.Columns.TreeListColumn colIsTree;
        private DevExpress.XtraTreeList.Columns.TreeListColumn colCategory;
        private DevExpress.XtraTreeList.Columns.TreeListColumn colCode1;
        private DevExpress.XtraTreeList.Columns.TreeListColumn colFullName;
        private DevExpress.XtraTreeList.Columns.TreeListColumn colRemark;
        private DevExpress.XtraTreeList.Columns.TreeListColumn colEnabled;
        private DevExpress.XtraTreeList.Columns.TreeListColumn colSortCode;
        private DevExpress.XtraTreeList.Columns.TreeListColumn colDeleteMark;
        private DevExpress.XtraTreeList.Columns.TreeListColumn colCreateDt1;
        private DevExpress.XtraTreeList.Columns.TreeListColumn colCreateUser1;
        private DevExpress.XtraTreeList.Columns.TreeListColumn colModifyDt1;
        private DevExpress.XtraTreeList.Columns.TreeListColumn colModifyUser1;
        private DevExpress.XtraTreeList.Columns.TreeListColumn colId1;
        private System.Windows.Forms.BindingSource eRPC001CodeDictionaryBindingSource;
      
    }
}