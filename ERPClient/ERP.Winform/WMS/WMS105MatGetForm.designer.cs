namespace ERP.Winform.WMS
{
    partial class WMS105MatGetForm
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
            this.dockManager1 = new DevExpress.XtraBars.Docking.DockManager(this.components);
            this.dockPanel1 = new DevExpress.XtraBars.Docking.DockPanel();
            this.dockPanel1_Container = new DevExpress.XtraBars.Docking.ControlContainer();
            this.ykGridControl1 = new COM.YKControls.YKGridControl();
            this.gridPlan = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.xtraTabControl1 = new DevExpress.XtraTab.XtraTabControl();
            this.xtraTabPage1 = new DevExpress.XtraTab.XtraTabPage();
            this.wMSM105MatGetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ykGridControl2 = new COM.YKControls.YKGridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colCompCode = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colRequestNo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTxDt = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colRemarks = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colModifyDt = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colModifyUser = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCreateDt = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCreateUser = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colVersion = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colId = new DevExpress.XtraGrid.Columns.GridColumn();
            this.wMSM105MatGetDetailBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.colCompCode1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colRequestNo1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMatSpecCode = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMatSpec = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMatType = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSuppode = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colReqQty = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colRemarks1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colModifyDt1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colModifyUser1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCreateDt1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCreateUser1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colVersion1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colId1 = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl1)).BeginInit();
            this.splitContainerControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dockManager1)).BeginInit();
            this.dockPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ykGridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridPlan)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabControl1)).BeginInit();
            this.xtraTabControl1.SuspendLayout();
            this.xtraTabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.wMSM105MatGetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ykGridControl2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.wMSM105MatGetDetailBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // splitContainerControl1
            // 
            this.splitContainerControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainerControl1.Horizontal = false;
            this.splitContainerControl1.Location = new System.Drawing.Point(0, 103);
            this.splitContainerControl1.Name = "splitContainerControl1";
            this.splitContainerControl1.Panel1.Controls.Add(this.ykGridControl1);
            this.splitContainerControl1.Panel1.Text = "Panel1";
            this.splitContainerControl1.Panel2.Controls.Add(this.xtraTabControl1);
            this.splitContainerControl1.Panel2.Text = "Panel2";
            this.splitContainerControl1.Size = new System.Drawing.Size(1097, 453);
            this.splitContainerControl1.SplitterPosition = 234;
            this.splitContainerControl1.TabIndex = 4;
            this.splitContainerControl1.Text = "splitContainerControl1";
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
            this.dockPanel1.ID = new System.Guid("fc3c0182-22f2-494c-be6f-77a8369bb024");
            this.dockPanel1.Location = new System.Drawing.Point(0, 0);
            this.dockPanel1.Name = "dockPanel1";
            this.dockPanel1.OriginalSize = new System.Drawing.Size(200, 103);
            this.dockPanel1.Size = new System.Drawing.Size(1097, 103);
            this.dockPanel1.Text = "搜索条件";
            // 
            // dockPanel1_Container
            // 
            this.dockPanel1_Container.Location = new System.Drawing.Point(4, 23);
            this.dockPanel1_Container.Name = "dockPanel1_Container";
            this.dockPanel1_Container.Size = new System.Drawing.Size(1089, 76);
            this.dockPanel1_Container.TabIndex = 0;
            // 
            // ykGridControl1
            // 
            this.ykGridControl1.Cursor = System.Windows.Forms.Cursors.Default;
            this.ykGridControl1.DataSource = this.wMSM105MatGetBindingSource;
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
            this.ykGridControl1.Size = new System.Drawing.Size(1097, 234);
            this.ykGridControl1.TabIndex = 10;
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
            this.colRequestNo,
            this.colTxDt,
            this.colRemarks,
            this.colModifyDt,
            this.colModifyUser,
            this.colCreateDt,
            this.colCreateUser,
            this.colVersion,
            this.colId});
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
            // xtraTabControl1
            // 
            this.xtraTabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.xtraTabControl1.Location = new System.Drawing.Point(0, 0);
            this.xtraTabControl1.Name = "xtraTabControl1";
            this.xtraTabControl1.SelectedTabPage = this.xtraTabPage1;
            this.xtraTabControl1.Size = new System.Drawing.Size(1097, 214);
            this.xtraTabControl1.TabIndex = 9;
            this.xtraTabControl1.TabPages.AddRange(new DevExpress.XtraTab.XtraTabPage[] {
            this.xtraTabPage1});
            // 
            // xtraTabPage1
            // 
            this.xtraTabPage1.Controls.Add(this.ykGridControl2);
            this.xtraTabPage1.Name = "xtraTabPage1";
            this.xtraTabPage1.Size = new System.Drawing.Size(1091, 185);
            this.xtraTabPage1.Text = "领料明细";
            // 
            // wMSM105MatGetBindingSource
            // 
            this.wMSM105MatGetBindingSource.DataSource = typeof(ERP.Domain.WMS_M105_MatGet);
            // 
            // ykGridControl2
            // 
            this.ykGridControl2.Cursor = System.Windows.Forms.Cursors.Default;
            this.ykGridControl2.DataSource = this.wMSM105MatGetDetailBindingSource;
            this.ykGridControl2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ykGridControl2.EmbeddedNavigator.Buttons.Append.Visible = false;
            this.ykGridControl2.EmbeddedNavigator.Buttons.CancelEdit.Visible = false;
            this.ykGridControl2.EmbeddedNavigator.Buttons.Edit.Visible = false;
            this.ykGridControl2.EmbeddedNavigator.Buttons.EndEdit.Visible = false;
            this.ykGridControl2.EmbeddedNavigator.Buttons.Remove.Visible = false;
            this.ykGridControl2.EmbeddedNavigator.TextStringFormat = "记录:第{0}笔/共{1}笔";
            this.ykGridControl2.Location = new System.Drawing.Point(0, 0);
            this.ykGridControl2.MainView = this.gridView1;
            this.ykGridControl2.MenuManager = this.barManager1;
            this.ykGridControl2.Name = "ykGridControl2";
            this.ykGridControl2.Size = new System.Drawing.Size(1091, 185);
            this.ykGridControl2.TabIndex = 11;
            this.ykGridControl2.UseEmbeddedNavigator = true;
            this.ykGridControl2.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.Appearance.EvenRow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(234)))), ((int)(((byte)(250)))));
            this.gridView1.Appearance.EvenRow.Options.UseBackColor = true;
            this.gridView1.Appearance.OddRow.BackColor = System.Drawing.Color.White;
            this.gridView1.Appearance.OddRow.Options.UseBackColor = true;
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colCompCode1,
            this.colRequestNo1,
            this.colMatSpecCode,
            this.colMatSpec,
            this.colMatType,
            this.colSuppode,
            this.colReqQty,
            this.colRemarks1,
            this.colModifyDt1,
            this.colModifyUser1,
            this.colCreateDt1,
            this.colCreateUser1,
            this.colVersion1,
            this.colId1});
            this.gridView1.GridControl = this.ykGridControl2;
            this.gridView1.IndicatorWidth = 40;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsBehavior.ReadOnly = true;
            this.gridView1.OptionsView.ColumnAutoWidth = false;
            this.gridView1.OptionsView.EnableAppearanceEvenRow = true;
            this.gridView1.OptionsView.EnableAppearanceOddRow = true;
            this.gridView1.OptionsView.ShowFilterPanelMode = DevExpress.XtraGrid.Views.Base.ShowFilterPanelMode.Never;
            this.gridView1.OptionsView.ShowGroupPanel = false;
            // 
            // colCompCode
            // 
            this.colCompCode.FieldName = "CompCode";
            this.colCompCode.Name = "colCompCode";
            this.colCompCode.Visible = true;
            this.colCompCode.VisibleIndex = 0;
            // 
            // colRequestNo
            // 
            this.colRequestNo.Caption = "领料单号";
            this.colRequestNo.FieldName = "RequestNo";
            this.colRequestNo.Name = "colRequestNo";
            this.colRequestNo.Visible = true;
            this.colRequestNo.VisibleIndex = 1;
            // 
            // colTxDt
            // 
            this.colTxDt.Caption = "日期";
            this.colTxDt.FieldName = "TxDt";
            this.colTxDt.Name = "colTxDt";
            this.colTxDt.Visible = true;
            this.colTxDt.VisibleIndex = 2;
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
            // wMSM105MatGetDetailBindingSource
            // 
            this.wMSM105MatGetDetailBindingSource.DataSource = typeof(ERP.Domain.WMS_M105_MatGetDetail);
            // 
            // colCompCode1
            // 
            this.colCompCode1.FieldName = "CompCode";
            this.colCompCode1.Name = "colCompCode1";
            // 
            // colRequestNo1
            // 
            this.colRequestNo1.FieldName = "RequestNo";
            this.colRequestNo1.Name = "colRequestNo1";
            // 
            // colMatSpecCode
            // 
            this.colMatSpecCode.Caption = "材料规格代号";
            this.colMatSpecCode.FieldName = "MatSpecCode";
            this.colMatSpecCode.Name = "colMatSpecCode";
            this.colMatSpecCode.Visible = true;
            this.colMatSpecCode.VisibleIndex = 0;
            // 
            // colMatSpec
            // 
            this.colMatSpec.Caption = "材料规格";
            this.colMatSpec.FieldName = "MatSpec";
            this.colMatSpec.Name = "colMatSpec";
            this.colMatSpec.Visible = true;
            this.colMatSpec.VisibleIndex = 1;
            // 
            // colMatType
            // 
            this.colMatType.Caption = "材质";
            this.colMatType.FieldName = "MatType";
            this.colMatType.Name = "colMatType";
            this.colMatType.Visible = true;
            this.colMatType.VisibleIndex = 2;
            // 
            // colSuppode
            // 
            this.colSuppode.Caption = "供应商";
            this.colSuppode.FieldName = "Suppode";
            this.colSuppode.Name = "colSuppode";
            this.colSuppode.Visible = true;
            this.colSuppode.VisibleIndex = 3;
            // 
            // colReqQty
            // 
            this.colReqQty.Caption = "领取数量";
            this.colReqQty.FieldName = "ReqQty";
            this.colReqQty.Name = "colReqQty";
            this.colReqQty.Visible = true;
            this.colReqQty.VisibleIndex = 4;
            // 
            // colRemarks1
            // 
            this.colRemarks1.Caption = "备注";
            this.colRemarks1.FieldName = "Remarks";
            this.colRemarks1.Name = "colRemarks1";
            this.colRemarks1.Visible = true;
            this.colRemarks1.VisibleIndex = 5;
            // 
            // colModifyDt1
            // 
            this.colModifyDt1.FieldName = "ModifyDt";
            this.colModifyDt1.Name = "colModifyDt1";
            // 
            // colModifyUser1
            // 
            this.colModifyUser1.FieldName = "ModifyUser";
            this.colModifyUser1.Name = "colModifyUser1";
            // 
            // colCreateDt1
            // 
            this.colCreateDt1.FieldName = "CreateDt";
            this.colCreateDt1.Name = "colCreateDt1";
            this.colCreateDt1.Visible = true;
            this.colCreateDt1.VisibleIndex = 6;
            // 
            // colCreateUser1
            // 
            this.colCreateUser1.FieldName = "CreateUser";
            this.colCreateUser1.Name = "colCreateUser1";
            this.colCreateUser1.Visible = true;
            this.colCreateUser1.VisibleIndex = 7;
            // 
            // colVersion1
            // 
            this.colVersion1.FieldName = "Version";
            this.colVersion1.Name = "colVersion1";
            // 
            // colId1
            // 
            this.colId1.FieldName = "Id";
            this.colId1.Name = "colId1";
            // 
            // WMS105MatGetForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1097, 585);
            this.Controls.Add(this.splitContainerControl1);
            this.Controls.Add(this.dockPanel1);
            this.Name = "WMS105MatGetForm";
            this.Text = "WMS105MatGetForm";
            this.Controls.SetChildIndex(this.dockPanel1, 0);
            this.Controls.SetChildIndex(this.splitContainerControl1, 0);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl1)).EndInit();
            this.splitContainerControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dockManager1)).EndInit();
            this.dockPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ykGridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridPlan)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabControl1)).EndInit();
            this.xtraTabControl1.ResumeLayout(false);
            this.xtraTabPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.wMSM105MatGetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ykGridControl2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.wMSM105MatGetDetailBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.SplitContainerControl splitContainerControl1;
        private DevExpress.XtraBars.Docking.DockManager dockManager1;
        private DevExpress.XtraBars.Docking.DockPanel dockPanel1;
        private DevExpress.XtraBars.Docking.ControlContainer dockPanel1_Container;
        private COM.YKControls.YKGridControl ykGridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridPlan;
        private System.Windows.Forms.BindingSource wMSM105MatGetBindingSource;
        private DevExpress.XtraGrid.Columns.GridColumn colCompCode;
        private DevExpress.XtraGrid.Columns.GridColumn colRequestNo;
        private DevExpress.XtraGrid.Columns.GridColumn colTxDt;
        private DevExpress.XtraGrid.Columns.GridColumn colRemarks;
        private DevExpress.XtraGrid.Columns.GridColumn colModifyDt;
        private DevExpress.XtraGrid.Columns.GridColumn colModifyUser;
        private DevExpress.XtraGrid.Columns.GridColumn colCreateDt;
        private DevExpress.XtraGrid.Columns.GridColumn colCreateUser;
        private DevExpress.XtraGrid.Columns.GridColumn colVersion;
        private DevExpress.XtraGrid.Columns.GridColumn colId;
        private DevExpress.XtraTab.XtraTabControl xtraTabControl1;
        private DevExpress.XtraTab.XtraTabPage xtraTabPage1;
        private COM.YKControls.YKGridControl ykGridControl2;
        private System.Windows.Forms.BindingSource wMSM105MatGetDetailBindingSource;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn colCompCode1;
        private DevExpress.XtraGrid.Columns.GridColumn colRequestNo1;
        private DevExpress.XtraGrid.Columns.GridColumn colMatSpecCode;
        private DevExpress.XtraGrid.Columns.GridColumn colMatSpec;
        private DevExpress.XtraGrid.Columns.GridColumn colMatType;
        private DevExpress.XtraGrid.Columns.GridColumn colSuppode;
        private DevExpress.XtraGrid.Columns.GridColumn colReqQty;
        private DevExpress.XtraGrid.Columns.GridColumn colRemarks1;
        private DevExpress.XtraGrid.Columns.GridColumn colModifyDt1;
        private DevExpress.XtraGrid.Columns.GridColumn colModifyUser1;
        private DevExpress.XtraGrid.Columns.GridColumn colCreateDt1;
        private DevExpress.XtraGrid.Columns.GridColumn colCreateUser1;
        private DevExpress.XtraGrid.Columns.GridColumn colVersion1;
        private DevExpress.XtraGrid.Columns.GridColumn colId1;
    }
}