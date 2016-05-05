namespace ERP.Winform.MES
{
    partial class MES201BOMChooseFrom
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
            this.layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
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
            this.layoutControlItem2 = new DevExpress.XtraLayout.LayoutControlItem();
            this.splitterItem1 = new DevExpress.XtraLayout.SplitterItem();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataLayoutControl1)).BeginInit();
            this.dataLayoutControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ykGridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.eRPM002BOMBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ykGridControl2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.eRPM002BOMMaterialBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitterItem1)).BeginInit();
            this.SuspendLayout();
            // 
            // panelControl1
            // 
            this.panelControl1.Size = new System.Drawing.Size(1019, 518);
            // 
            // dataLayoutControl1
            // 
            this.dataLayoutControl1.Controls.Add(this.ykGridControl2);
            this.dataLayoutControl1.Controls.Add(this.ykGridControl1);
            this.dataLayoutControl1.OptionsCustomizationForm.DesignTimeCustomizationFormPositionAndSize = new System.Drawing.Rectangle(1049, 344, 250, 350);
            this.dataLayoutControl1.Size = new System.Drawing.Size(1015, 514);
            // 
            // layoutControlGroup1
            // 
            this.layoutControlGroup1.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItem1,
            this.layoutControlItem2,
            this.splitterItem1});
            this.layoutControlGroup1.Name = "Root";
            this.layoutControlGroup1.Size = new System.Drawing.Size(1015, 514);
            this.layoutControlGroup1.Text = "Root";
            // 
            // ykGridControl1
            // 
            this.ykGridControl1.Cursor = System.Windows.Forms.Cursors.Default;
            this.ykGridControl1.DataSource = this.eRPM002BOMBindingSource;
            this.ykGridControl1.EmbeddedNavigator.Buttons.Append.Visible = false;
            this.ykGridControl1.EmbeddedNavigator.Buttons.CancelEdit.Visible = false;
            this.ykGridControl1.EmbeddedNavigator.Buttons.Edit.Visible = false;
            this.ykGridControl1.EmbeddedNavigator.Buttons.EndEdit.Visible = false;
            this.ykGridControl1.EmbeddedNavigator.Buttons.Remove.Visible = false;
            this.ykGridControl1.EmbeddedNavigator.TextStringFormat = "记录:第{0}笔/共{1}笔";
            this.ykGridControl1.Location = new System.Drawing.Point(12, 12);
            this.ykGridControl1.MainView = this.gridView1;
            this.ykGridControl1.Name = "ykGridControl1";
            this.ykGridControl1.Size = new System.Drawing.Size(991, 258);
            this.ykGridControl1.TabIndex = 10;
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
            this.gridView1.DoubleClick += new System.EventHandler(this.gridView1_DoubleClick);
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
            this.colPartNo.VisibleIndex = 0;
            // 
            // colPartName
            // 
            this.colPartName.Caption = "产品名称";
            this.colPartName.FieldName = "PartName";
            this.colPartName.Name = "colPartName";
            this.colPartName.Visible = true;
            this.colPartName.VisibleIndex = 1;
            // 
            // colProcessFlow
            // 
            this.colProcessFlow.Caption = "流程";
            this.colProcessFlow.FieldName = "ProcessFlow";
            this.colProcessFlow.Name = "colProcessFlow";
            this.colProcessFlow.Visible = true;
            this.colProcessFlow.VisibleIndex = 2;
            // 
            // colRemarks
            // 
            this.colRemarks.Caption = "备注";
            this.colRemarks.FieldName = "Remarks";
            this.colRemarks.Name = "colRemarks";
            this.colRemarks.Visible = true;
            this.colRemarks.VisibleIndex = 3;
            // 
            // colStartDt
            // 
            this.colStartDt.Caption = "起始日期";
            this.colStartDt.FieldName = "StartDt";
            this.colStartDt.Name = "colStartDt";
            this.colStartDt.Visible = true;
            this.colStartDt.VisibleIndex = 4;
            // 
            // colStatus
            // 
            this.colStatus.Caption = "状态";
            this.colStatus.FieldName = "Status";
            this.colStatus.Name = "colStatus";
            this.colStatus.Visible = true;
            this.colStatus.VisibleIndex = 5;
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
            // layoutControlItem1
            // 
            this.layoutControlItem1.Control = this.ykGridControl1;
            this.layoutControlItem1.CustomizationFormText = "layoutControlItem1";
            this.layoutControlItem1.Location = new System.Drawing.Point(0, 0);
            this.layoutControlItem1.Name = "layoutControlItem1";
            this.layoutControlItem1.Size = new System.Drawing.Size(995, 262);
            this.layoutControlItem1.Text = "layoutControlItem1";
            this.layoutControlItem1.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem1.TextToControlDistance = 0;
            this.layoutControlItem1.TextVisible = false;
            // 
            // ykGridControl2
            // 
            this.ykGridControl2.Cursor = System.Windows.Forms.Cursors.Default;
            this.ykGridControl2.DataSource = this.eRPM002BOMMaterialBindingSource;
            this.ykGridControl2.EmbeddedNavigator.Buttons.Append.Visible = false;
            this.ykGridControl2.EmbeddedNavigator.Buttons.CancelEdit.Visible = false;
            this.ykGridControl2.EmbeddedNavigator.Buttons.Edit.Visible = false;
            this.ykGridControl2.EmbeddedNavigator.Buttons.EndEdit.Visible = false;
            this.ykGridControl2.EmbeddedNavigator.Buttons.Remove.Visible = false;
            this.ykGridControl2.EmbeddedNavigator.TextStringFormat = "记录:第{0}笔/共{1}笔";
            this.ykGridControl2.Location = new System.Drawing.Point(12, 279);
            this.ykGridControl2.MainView = this.gridView2;
            this.ykGridControl2.Name = "ykGridControl2";
            this.ykGridControl2.Size = new System.Drawing.Size(991, 223);
            this.ykGridControl2.TabIndex = 11;
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
            this.colId1});
            this.gridView2.GridControl = this.ykGridControl2;
            this.gridView2.IndicatorWidth = 40;
            this.gridView2.Name = "gridView2";
            this.gridView2.OptionsBehavior.ReadOnly = true;
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
            this.colProcessCode.VisibleIndex = 1;
            // 
            // colUnit
            // 
            this.colUnit.Caption = "单位";
            this.colUnit.FieldName = "Unit";
            this.colUnit.Name = "colUnit";
            this.colUnit.Visible = true;
            this.colUnit.VisibleIndex = 2;
            // 
            // colUnitConsume
            // 
            this.colUnitConsume.Caption = "单位消耗";
            this.colUnitConsume.FieldName = "UnitConsume";
            this.colUnitConsume.Name = "colUnitConsume";
            this.colUnitConsume.Visible = true;
            this.colUnitConsume.VisibleIndex = 3;
            // 
            // colEffectiveDt
            // 
            this.colEffectiveDt.Caption = "生效日期";
            this.colEffectiveDt.FieldName = "EffectiveDt";
            this.colEffectiveDt.Name = "colEffectiveDt";
            this.colEffectiveDt.Visible = true;
            this.colEffectiveDt.VisibleIndex = 4;
            // 
            // colIsActive
            // 
            this.colIsActive.Caption = "是否使用";
            this.colIsActive.FieldName = "IsActive";
            this.colIsActive.Name = "colIsActive";
            this.colIsActive.Visible = true;
            this.colIsActive.VisibleIndex = 5;
            // 
            // colRemarks1
            // 
            this.colRemarks1.Caption = "备注";
            this.colRemarks1.FieldName = "Remarks";
            this.colRemarks1.Name = "colRemarks1";
            this.colRemarks1.Visible = true;
            this.colRemarks1.VisibleIndex = 6;
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
            // layoutControlItem2
            // 
            this.layoutControlItem2.Control = this.ykGridControl2;
            this.layoutControlItem2.CustomizationFormText = "layoutControlItem2";
            this.layoutControlItem2.Location = new System.Drawing.Point(0, 267);
            this.layoutControlItem2.Name = "layoutControlItem2";
            this.layoutControlItem2.Size = new System.Drawing.Size(995, 227);
            this.layoutControlItem2.Text = "layoutControlItem2";
            this.layoutControlItem2.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem2.TextToControlDistance = 0;
            this.layoutControlItem2.TextVisible = false;
            // 
            // splitterItem1
            // 
            this.splitterItem1.AllowHotTrack = true;
            this.splitterItem1.CustomizationFormText = "splitterItem1";
            this.splitterItem1.Location = new System.Drawing.Point(0, 262);
            this.splitterItem1.Name = "splitterItem1";
            this.splitterItem1.Size = new System.Drawing.Size(995, 5);
            // 
            // MES201BOMChooseFrom
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1023, 551);
            this.Name = "MES201BOMChooseFrom";
            this.Text = "_201ProductChooseFrom";
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataLayoutControl1)).EndInit();
            this.dataLayoutControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ykGridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.eRPM002BOMBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ykGridControl2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.eRPM002BOMMaterialBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitterItem1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private COM.YKControls.YKGridControl ykGridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
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
        private System.Windows.Forms.BindingSource eRPM002BOMBindingSource;
        private COM.YKControls.YKGridControl ykGridControl2;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView2;
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
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem1;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem2;
        private DevExpress.XtraLayout.SplitterItem splitterItem1;
        private System.Windows.Forms.BindingSource eRPM002BOMMaterialBindingSource;


    }
}