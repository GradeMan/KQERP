namespace ERP.Winform.CommonModule
{
    partial class BomForm
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
            this.ykGridControl1 = new COM.YKControls.YKGridControl();
            this.eRPM002BOMBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colCompCode = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPartNo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPartName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colProcessFlow = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colRemarks = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colStartDt = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colStatus = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colModifyDt = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colModifyUser = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCreateDt = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCreateUser = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colVersion = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colId = new DevExpress.XtraGrid.Columns.GridColumn();
            this.ykGridControl2 = new COM.YKControls.YKGridControl();
            this.eRPM002BOMMaterialBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gridView2 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colCompCode1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPartNo1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMatCode = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colProcessCode = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colUnit = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colUnitConsume = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colEffectiveDt = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIsActive = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colRemarks1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colModifyDt1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colModifyUser1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCreateDt1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCreateUser1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colVersion1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colId1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMatName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMatSpec = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colBOMNo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colBOMNo1 = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl1)).BeginInit();
            this.splitContainerControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ykGridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.eRPM002BOMBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ykGridControl2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.eRPM002BOMMaterialBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).BeginInit();
            this.SuspendLayout();
            // 
            // splitContainerControl1
            // 
            this.splitContainerControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainerControl1.Horizontal = false;
            this.splitContainerControl1.Location = new System.Drawing.Point(0, 0);
            this.splitContainerControl1.Name = "splitContainerControl1";
            this.splitContainerControl1.Panel1.Controls.Add(this.ykGridControl1);
            this.splitContainerControl1.Panel1.Text = "Panel1";
            this.splitContainerControl1.Panel2.Controls.Add(this.ykGridControl2);
            this.splitContainerControl1.Panel2.Text = "Panel2";
            this.splitContainerControl1.Size = new System.Drawing.Size(1185, 550);
            this.splitContainerControl1.SplitterPosition = 269;
            this.splitContainerControl1.TabIndex = 7;
            this.splitContainerControl1.Text = "splitContainerControl1";
            // 
            // ykGridControl1
            // 
            this.ykGridControl1.Cursor = System.Windows.Forms.Cursors.Default;
            this.ykGridControl1.DataSource = this.eRPM002BOMBindingSource;
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
            this.ykGridControl1.Size = new System.Drawing.Size(1185, 269);
            this.ykGridControl1.TabIndex = 9;
            this.ykGridControl1.UseEmbeddedNavigator = true;
            this.ykGridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // eRPM002BOMBindingSource
            // 
            this.eRPM002BOMBindingSource.DataSource = typeof(ERP.Domain.ERP_M002_BOM);
            // 
            // gridView1
            // 
            this.gridView1.Appearance.EvenRow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(234)))), ((int)(((byte)(250)))));
            this.gridView1.Appearance.EvenRow.Options.UseBackColor = true;
            this.gridView1.Appearance.OddRow.BackColor = System.Drawing.Color.White;
            this.gridView1.Appearance.OddRow.Options.UseBackColor = true;
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colCompCode,
            this.colPartNo,
            this.colPartName,
            this.colProcessFlow,
            this.colRemarks,
            this.colStartDt,
            this.colStatus,
            this.colModifyDt,
            this.colModifyUser,
            this.colCreateDt,
            this.colCreateUser,
            this.colVersion,
            this.colId,
            this.colBOMNo1});
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
            // colPartNo
            // 
            this.colPartNo.Caption = "产品编码";
            this.colPartNo.FieldName = "PartNo";
            this.colPartNo.Name = "colPartNo";
            this.colPartNo.Visible = true;
            this.colPartNo.VisibleIndex = 1;
            // 
            // colPartName
            // 
            this.colPartName.Caption = "产品名称";
            this.colPartName.FieldName = "PartName";
            this.colPartName.Name = "colPartName";
            this.colPartName.Visible = true;
            this.colPartName.VisibleIndex = 2;
            // 
            // colProcessFlow
            // 
            this.colProcessFlow.Caption = "流程";
            this.colProcessFlow.FieldName = "ProcessFlow";
            this.colProcessFlow.Name = "colProcessFlow";
            this.colProcessFlow.Visible = true;
            this.colProcessFlow.VisibleIndex = 3;
            // 
            // colRemarks
            // 
            this.colRemarks.Caption = "备注";
            this.colRemarks.FieldName = "Remarks";
            this.colRemarks.Name = "colRemarks";
            this.colRemarks.Visible = true;
            this.colRemarks.VisibleIndex = 4;
            // 
            // colStartDt
            // 
            this.colStartDt.Caption = "起始日期";
            this.colStartDt.FieldName = "StartDt";
            this.colStartDt.Name = "colStartDt";
            this.colStartDt.Visible = true;
            this.colStartDt.VisibleIndex = 5;
            // 
            // colStatus
            // 
            this.colStatus.Caption = "状态";
            this.colStatus.FieldName = "Status";
            this.colStatus.Name = "colStatus";
            this.colStatus.Visible = true;
            this.colStatus.VisibleIndex = 6;
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
            // ykGridControl2
            // 
            this.ykGridControl2.Cursor = System.Windows.Forms.Cursors.Default;
            this.ykGridControl2.DataSource = this.eRPM002BOMMaterialBindingSource;
            this.ykGridControl2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ykGridControl2.EmbeddedNavigator.Buttons.Append.Visible = false;
            this.ykGridControl2.EmbeddedNavigator.Buttons.CancelEdit.Visible = false;
            this.ykGridControl2.EmbeddedNavigator.Buttons.Edit.Visible = false;
            this.ykGridControl2.EmbeddedNavigator.Buttons.EndEdit.Visible = false;
            this.ykGridControl2.EmbeddedNavigator.Buttons.Remove.Visible = false;
            this.ykGridControl2.EmbeddedNavigator.TextStringFormat = "记录:第{0}笔/共{1}笔";
            this.ykGridControl2.Location = new System.Drawing.Point(0, 0);
            this.ykGridControl2.MainView = this.gridView2;
            this.ykGridControl2.MenuManager = this.barManager1;
            this.ykGridControl2.Name = "ykGridControl2";
            this.ykGridControl2.Size = new System.Drawing.Size(1185, 276);
            this.ykGridControl2.TabIndex = 8;
            this.ykGridControl2.UseEmbeddedNavigator = true;
            this.ykGridControl2.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView2});
            // 
            // eRPM002BOMMaterialBindingSource
            // 
            this.eRPM002BOMMaterialBindingSource.DataSource = typeof(ERP.Domain.ERP_M002_BOM_Material);
            // 
            // gridView2
            // 
            this.gridView2.Appearance.EvenRow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(234)))), ((int)(((byte)(250)))));
            this.gridView2.Appearance.EvenRow.Options.UseBackColor = true;
            this.gridView2.Appearance.OddRow.BackColor = System.Drawing.Color.White;
            this.gridView2.Appearance.OddRow.Options.UseBackColor = true;
            this.gridView2.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colCompCode1,
            this.colPartNo1,
            this.colMatCode,
            this.colProcessCode,
            this.colUnit,
            this.colUnitConsume,
            this.colEffectiveDt,
            this.colIsActive,
            this.colRemarks1,
            this.colModifyDt1,
            this.colModifyUser1,
            this.colCreateDt1,
            this.colCreateUser1,
            this.colVersion1,
            this.colId1,
            this.colMatName,
            this.colMatSpec,
            this.colBOMNo});
            this.gridView2.GridControl = this.ykGridControl2;
            this.gridView2.IndicatorWidth = 40;
            this.gridView2.Name = "gridView2";
            this.gridView2.OptionsBehavior.ReadOnly = true;
            this.gridView2.OptionsFind.AlwaysVisible = true;
            this.gridView2.OptionsView.ColumnAutoWidth = false;
            this.gridView2.OptionsView.EnableAppearanceEvenRow = true;
            this.gridView2.OptionsView.EnableAppearanceOddRow = true;
            this.gridView2.OptionsView.ShowFilterPanelMode = DevExpress.XtraGrid.Views.Base.ShowFilterPanelMode.Never;
            this.gridView2.OptionsView.ShowGroupPanel = false;
            // 
            // colCompCode1
            // 
            this.colCompCode1.FieldName = "CompCode";
            this.colCompCode1.Name = "colCompCode1";
            // 
            // colPartNo1
            // 
            this.colPartNo1.Caption = "产品编码";
            this.colPartNo1.FieldName = "PartNo";
            this.colPartNo1.Name = "colPartNo1";
            // 
            // colMatCode
            // 
            this.colMatCode.Caption = "物料编码";
            this.colMatCode.FieldName = "MatCode";
            this.colMatCode.Name = "colMatCode";
            this.colMatCode.Visible = true;
            this.colMatCode.VisibleIndex = 0;
            // 
            // colProcessCode
            // 
            this.colProcessCode.Caption = "流程";
            this.colProcessCode.FieldName = "ProcessCode";
            this.colProcessCode.Name = "colProcessCode";
            this.colProcessCode.Visible = true;
            this.colProcessCode.VisibleIndex = 3;
            // 
            // colUnit
            // 
            this.colUnit.Caption = "单位";
            this.colUnit.FieldName = "Unit";
            this.colUnit.Name = "colUnit";
            this.colUnit.Visible = true;
            this.colUnit.VisibleIndex = 4;
            // 
            // colUnitConsume
            // 
            this.colUnitConsume.Caption = "单位消耗";
            this.colUnitConsume.FieldName = "UnitConsume";
            this.colUnitConsume.Name = "colUnitConsume";
            this.colUnitConsume.Visible = true;
            this.colUnitConsume.VisibleIndex = 5;
            // 
            // colEffectiveDt
            // 
            this.colEffectiveDt.Caption = "生效日期";
            this.colEffectiveDt.FieldName = "EffectiveDt";
            this.colEffectiveDt.Name = "colEffectiveDt";
            this.colEffectiveDt.Visible = true;
            this.colEffectiveDt.VisibleIndex = 6;
            // 
            // colIsActive
            // 
            this.colIsActive.Caption = "是否使用";
            this.colIsActive.FieldName = "IsActive";
            this.colIsActive.Name = "colIsActive";
            this.colIsActive.Visible = true;
            this.colIsActive.VisibleIndex = 7;
            // 
            // colRemarks1
            // 
            this.colRemarks1.Caption = "备注";
            this.colRemarks1.FieldName = "Remarks";
            this.colRemarks1.Name = "colRemarks1";
            this.colRemarks1.Visible = true;
            this.colRemarks1.VisibleIndex = 8;
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
            // 
            // colCreateUser1
            // 
            this.colCreateUser1.FieldName = "CreateUser";
            this.colCreateUser1.Name = "colCreateUser1";
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
            // colMatName
            // 
            this.colMatName.Caption = "物料名称";
            this.colMatName.FieldName = "MatName";
            this.colMatName.Name = "colMatName";
            this.colMatName.Visible = true;
            this.colMatName.VisibleIndex = 1;
            // 
            // colMatSpec
            // 
            this.colMatSpec.Caption = "规格";
            this.colMatSpec.FieldName = "MatSpec";
            this.colMatSpec.Name = "colMatSpec";
            this.colMatSpec.Visible = true;
            this.colMatSpec.VisibleIndex = 2;
            // 
            // colBOMNo
            // 
            this.colBOMNo.FieldName = "BOMNo";
            this.colBOMNo.Name = "colBOMNo";
            // 
            // colBOMNo1
            // 
            this.colBOMNo1.Caption = "BOM号";
            this.colBOMNo1.FieldName = "BOMNo";
            this.colBOMNo1.Name = "colBOMNo1";
            this.colBOMNo1.Visible = true;
            this.colBOMNo1.VisibleIndex = 0;
            // 
            // BomForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1185, 579);
            this.Controls.Add(this.splitContainerControl1);
            this.Name = "BomForm";
            this.Text = "BomForm";
            this.Controls.SetChildIndex(this.splitContainerControl1, 0);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl1)).EndInit();
            this.splitContainerControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ykGridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.eRPM002BOMBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ykGridControl2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.eRPM002BOMMaterialBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.SplitContainerControl splitContainerControl1;
        private COM.YKControls.YKGridControl ykGridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private COM.YKControls.YKGridControl ykGridControl2;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView2;
        private System.Windows.Forms.BindingSource eRPM002BOMBindingSource;
        private DevExpress.XtraGrid.Columns.GridColumn colCompCode;
        private DevExpress.XtraGrid.Columns.GridColumn colPartNo;
        private DevExpress.XtraGrid.Columns.GridColumn colPartName;
        private DevExpress.XtraGrid.Columns.GridColumn colProcessFlow;
        private DevExpress.XtraGrid.Columns.GridColumn colRemarks;
        private DevExpress.XtraGrid.Columns.GridColumn colStartDt;
        private DevExpress.XtraGrid.Columns.GridColumn colStatus;
        private DevExpress.XtraGrid.Columns.GridColumn colModifyDt;
        private DevExpress.XtraGrid.Columns.GridColumn colModifyUser;
        private DevExpress.XtraGrid.Columns.GridColumn colCreateDt;
        private DevExpress.XtraGrid.Columns.GridColumn colCreateUser;
        private DevExpress.XtraGrid.Columns.GridColumn colVersion;
        private DevExpress.XtraGrid.Columns.GridColumn colId;
        private System.Windows.Forms.BindingSource eRPM002BOMMaterialBindingSource;
        private DevExpress.XtraGrid.Columns.GridColumn colCompCode1;
        private DevExpress.XtraGrid.Columns.GridColumn colPartNo1;
        private DevExpress.XtraGrid.Columns.GridColumn colMatCode;
        private DevExpress.XtraGrid.Columns.GridColumn colProcessCode;
        private DevExpress.XtraGrid.Columns.GridColumn colUnit;
        private DevExpress.XtraGrid.Columns.GridColumn colUnitConsume;
        private DevExpress.XtraGrid.Columns.GridColumn colEffectiveDt;
        private DevExpress.XtraGrid.Columns.GridColumn colIsActive;
        private DevExpress.XtraGrid.Columns.GridColumn colRemarks1;
        private DevExpress.XtraGrid.Columns.GridColumn colModifyDt1;
        private DevExpress.XtraGrid.Columns.GridColumn colModifyUser1;
        private DevExpress.XtraGrid.Columns.GridColumn colCreateDt1;
        private DevExpress.XtraGrid.Columns.GridColumn colCreateUser1;
        private DevExpress.XtraGrid.Columns.GridColumn colVersion1;
        private DevExpress.XtraGrid.Columns.GridColumn colId1;
        private DevExpress.XtraGrid.Columns.GridColumn colMatName;
        private DevExpress.XtraGrid.Columns.GridColumn colMatSpec;
        private DevExpress.XtraGrid.Columns.GridColumn colBOMNo;
        private DevExpress.XtraGrid.Columns.GridColumn colBOMNo1;
    }
}