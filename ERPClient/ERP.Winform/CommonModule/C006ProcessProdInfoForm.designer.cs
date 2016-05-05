namespace ERP.Winform.CommonModule
{
    partial class C006ProcessProdInfoForm
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
            this.splitContainerControl1 = new DevExpress.XtraEditors.SplitContainerControl();
            this.treeCodeType = new DevExpress.XtraTreeList.TreeList();
            this.treeColumnCodeIDDesc = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            this.treeColumnCodeID = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            this.ykGridControl1 = new COM.YKControls.YKGridControl();
            this.eRPC006ProcessProdInfoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gridPlan = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colCompCode = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colProcessCode = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTechCode = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemPROCPMS = new DevExpress.XtraEditors.Repository.RepositoryItemGridLookUpEdit();
            this.repositoryItemGridLookUpEdit1View = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colTechSeqNo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTechContent = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTechType = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIsVisible = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colRemarks = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colModifyDt = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colModifyUser = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCreateDt = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCreateUser = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colId = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl1)).BeginInit();
            this.splitContainerControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.treeCodeType)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ykGridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.eRPC006ProcessProdInfoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridPlan)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemPROCPMS)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemGridLookUpEdit1View)).BeginInit();
            this.SuspendLayout();
            // 
            // splitContainerControl1
            // 
            this.splitContainerControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainerControl1.Location = new System.Drawing.Point(0, 0);
            this.splitContainerControl1.Name = "splitContainerControl1";
            this.splitContainerControl1.Panel1.Controls.Add(this.treeCodeType);
            this.splitContainerControl1.Panel1.Text = "Panel1";
            this.splitContainerControl1.Panel2.Controls.Add(this.ykGridControl1);
            this.splitContainerControl1.Panel2.Text = "Panel2";
            this.splitContainerControl1.Size = new System.Drawing.Size(1194, 521);
            this.splitContainerControl1.SplitterPosition = 228;
            this.splitContainerControl1.TabIndex = 0;
            this.splitContainerControl1.Text = "splitContainerControl1";
            // 
            // treeCodeType
            // 
            this.treeCodeType.Columns.AddRange(new DevExpress.XtraTreeList.Columns.TreeListColumn[] {
            this.treeColumnCodeIDDesc,
            this.treeColumnCodeID});
            this.treeCodeType.Dock = System.Windows.Forms.DockStyle.Fill;
            this.treeCodeType.Location = new System.Drawing.Point(0, 0);
            this.treeCodeType.Name = "treeCodeType";
            this.treeCodeType.Size = new System.Drawing.Size(228, 521);
            this.treeCodeType.TabIndex = 6;
            this.treeCodeType.FocusedNodeChanged += new DevExpress.XtraTreeList.FocusedNodeChangedEventHandler(this.treeCodeType_FocusedNodeChanged);
            // 
            // treeColumnCodeIDDesc
            // 
            this.treeColumnCodeIDDesc.Caption = "制程";
            this.treeColumnCodeIDDesc.FieldName = "Description";
            this.treeColumnCodeIDDesc.Name = "treeColumnCodeIDDesc";
            this.treeColumnCodeIDDesc.Visible = true;
            this.treeColumnCodeIDDesc.VisibleIndex = 0;
            this.treeColumnCodeIDDesc.Width = 78;
            // 
            // treeColumnCodeID
            // 
            this.treeColumnCodeID.Caption = "制程代号";
            this.treeColumnCodeID.FieldName = "Code";
            this.treeColumnCodeID.Name = "treeColumnCodeID";
            this.treeColumnCodeID.Visible = true;
            this.treeColumnCodeID.VisibleIndex = 1;
            this.treeColumnCodeID.Width = 78;
            // 
            // ykGridControl1
            // 
            this.ykGridControl1.Cursor = System.Windows.Forms.Cursors.Default;
            this.ykGridControl1.DataSource = this.eRPC006ProcessProdInfoBindingSource;
            this.ykGridControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ykGridControl1.EmbeddedNavigator.Buttons.Append.Visible = false;
            this.ykGridControl1.EmbeddedNavigator.Buttons.CancelEdit.Visible = false;
            this.ykGridControl1.EmbeddedNavigator.Buttons.Edit.Visible = false;
            this.ykGridControl1.EmbeddedNavigator.Buttons.EndEdit.Visible = false;
            this.ykGridControl1.EmbeddedNavigator.Buttons.Remove.Visible = false;
            this.ykGridControl1.EmbeddedNavigator.TextStringFormat = "记录:第{0}笔/共{1}笔";
            this.ykGridControl1.Location = new System.Drawing.Point(0, 0);
            this.ykGridControl1.MainView = this.gridPlan;
            this.ykGridControl1.Name = "ykGridControl1";
            this.ykGridControl1.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryItemPROCPMS});
            this.ykGridControl1.Size = new System.Drawing.Size(961, 521);
            this.ykGridControl1.TabIndex = 11;
            this.ykGridControl1.UseEmbeddedNavigator = true;
            this.ykGridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridPlan});
            // 
            // eRPC006ProcessProdInfoBindingSource
            // 
            this.eRPC006ProcessProdInfoBindingSource.DataSource = typeof(ERP.Domain.ERP_C006_ProcessProdInfo);
            // 
            // gridPlan
            // 
            this.gridPlan.Appearance.EvenRow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(234)))), ((int)(((byte)(250)))));
            this.gridPlan.Appearance.EvenRow.Options.UseBackColor = true;
            this.gridPlan.Appearance.OddRow.BackColor = System.Drawing.Color.White;
            this.gridPlan.Appearance.OddRow.Options.UseBackColor = true;
            this.gridPlan.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colCompCode,
            this.colProcessCode,
            this.colTechCode,
            this.colTechSeqNo,
            this.colTechContent,
            this.colTechType,
            this.colIsVisible,
            this.colRemarks,
            this.colModifyDt,
            this.colModifyUser,
            this.colCreateDt,
            this.colCreateUser,
            this.colId});
            this.gridPlan.GridControl = this.ykGridControl1;
            this.gridPlan.IndicatorWidth = 40;
            this.gridPlan.Name = "gridPlan";
            this.gridPlan.OptionsBehavior.ReadOnly = true;
            this.gridPlan.OptionsFind.AlwaysVisible = true;
            this.gridPlan.OptionsView.EnableAppearanceEvenRow = true;
            this.gridPlan.OptionsView.EnableAppearanceOddRow = true;
            this.gridPlan.OptionsView.ShowFilterPanelMode = DevExpress.XtraGrid.Views.Base.ShowFilterPanelMode.Never;
            this.gridPlan.OptionsView.ShowGroupPanel = false;
            // 
            // colCompCode
            // 
            this.colCompCode.FieldName = "CompCode";
            this.colCompCode.Name = "colCompCode";
            // 
            // colProcessCode
            // 
            this.colProcessCode.Caption = "制程";
            this.colProcessCode.FieldName = "ProcessCode";
            this.colProcessCode.Name = "colProcessCode";
            // 
            // colTechCode
            // 
            this.colTechCode.Caption = "制程参数";
            this.colTechCode.ColumnEdit = this.repositoryItemPROCPMS;
            this.colTechCode.FieldName = "TechCode";
            this.colTechCode.Name = "colTechCode";
            this.colTechCode.Visible = true;
            this.colTechCode.VisibleIndex = 0;
            // 
            // repositoryItemPROCPMS
            // 
            this.repositoryItemPROCPMS.AutoHeight = false;
            this.repositoryItemPROCPMS.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryItemPROCPMS.Name = "repositoryItemPROCPMS";
            this.repositoryItemPROCPMS.NullText = "";
            this.repositoryItemPROCPMS.View = this.repositoryItemGridLookUpEdit1View;
            // 
            // repositoryItemGridLookUpEdit1View
            // 
            this.repositoryItemGridLookUpEdit1View.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.repositoryItemGridLookUpEdit1View.Name = "repositoryItemGridLookUpEdit1View";
            this.repositoryItemGridLookUpEdit1View.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.repositoryItemGridLookUpEdit1View.OptionsView.ShowGroupPanel = false;
            // 
            // colTechSeqNo
            // 
            this.colTechSeqNo.Caption = "排序";
            this.colTechSeqNo.FieldName = "TechSeqNo";
            this.colTechSeqNo.Name = "colTechSeqNo";
            this.colTechSeqNo.Visible = true;
            this.colTechSeqNo.VisibleIndex = 1;
            // 
            // colTechContent
            // 
            this.colTechContent.Caption = "内容";
            this.colTechContent.FieldName = "TechContent";
            this.colTechContent.Name = "colTechContent";
            this.colTechContent.Visible = true;
            this.colTechContent.VisibleIndex = 2;
            // 
            // colTechType
            // 
            this.colTechType.Caption = "类别";
            this.colTechType.FieldName = "TechType";
            this.colTechType.Name = "colTechType";
            this.colTechType.Visible = true;
            this.colTechType.VisibleIndex = 3;
            // 
            // colIsVisible
            // 
            this.colIsVisible.Caption = "是否可见";
            this.colIsVisible.FieldName = "IsVisible";
            this.colIsVisible.Name = "colIsVisible";
            this.colIsVisible.Visible = true;
            this.colIsVisible.VisibleIndex = 4;
            // 
            // colRemarks
            // 
            this.colRemarks.Caption = "备注";
            this.colRemarks.FieldName = "Remarks";
            this.colRemarks.Name = "colRemarks";
            this.colRemarks.Visible = true;
            this.colRemarks.VisibleIndex = 5;
            this.colRemarks.Width = 104;
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
            // colId
            // 
            this.colId.FieldName = "Id";
            this.colId.Name = "colId";
            // 
            // C006ProcessProdInfoForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1194, 550);
            this.Controls.Add(this.splitContainerControl1);
            this.Name = "C006ProcessProdInfoForm";
            this.Text = "C006ProcessProdInfoForm";
            this.Controls.SetChildIndex(this.splitContainerControl1, 0);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl1)).EndInit();
            this.splitContainerControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.treeCodeType)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ykGridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.eRPC006ProcessProdInfoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridPlan)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemPROCPMS)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemGridLookUpEdit1View)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.SplitContainerControl splitContainerControl1;
        private COM.YKControls.YKGridControl ykGridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridPlan;
        private DevExpress.XtraTreeList.TreeList treeCodeType;
        private DevExpress.XtraTreeList.Columns.TreeListColumn treeColumnCodeIDDesc;
        private DevExpress.XtraTreeList.Columns.TreeListColumn treeColumnCodeID;
        private System.Windows.Forms.BindingSource eRPC006ProcessProdInfoBindingSource;
        private DevExpress.XtraGrid.Columns.GridColumn colCompCode;
        private DevExpress.XtraGrid.Columns.GridColumn colProcessCode;
        private DevExpress.XtraGrid.Columns.GridColumn colTechCode;
        private DevExpress.XtraGrid.Columns.GridColumn colTechSeqNo;
        private DevExpress.XtraGrid.Columns.GridColumn colTechContent;
        private DevExpress.XtraGrid.Columns.GridColumn colTechType;
        private DevExpress.XtraGrid.Columns.GridColumn colIsVisible;
        private DevExpress.XtraGrid.Columns.GridColumn colRemarks;
        private DevExpress.XtraGrid.Columns.GridColumn colModifyDt;
        private DevExpress.XtraGrid.Columns.GridColumn colModifyUser;
        private DevExpress.XtraGrid.Columns.GridColumn colCreateDt;
        private DevExpress.XtraGrid.Columns.GridColumn colCreateUser;
        private DevExpress.XtraGrid.Columns.GridColumn colId;
        private DevExpress.XtraEditors.Repository.RepositoryItemGridLookUpEdit repositoryItemPROCPMS;
        private DevExpress.XtraGrid.Views.Grid.GridView repositoryItemGridLookUpEdit1View;
    }
}