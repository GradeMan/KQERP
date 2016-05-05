namespace ERP.Winform.MES
{
    partial class MES202TaskChoosePlanForm
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
            this.gridTask = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
            this.mESM201PlanDetailBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.colCompCode = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPlanId = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPLNo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSONo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCustCode = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPartNo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPartName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPartSpec = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDetailType = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colUnit = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colQty = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colFQty = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colAdJustQty = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSumQty = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colRemarks = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colModifyDt = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colModifyUser = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCreateDt = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCreateUser = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colId = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataLayoutControl1)).BeginInit();
            this.dataLayoutControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ykGridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridTask)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mESM201PlanDetailBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // panelControl1
            // 
            this.panelControl1.Size = new System.Drawing.Size(1117, 627);
            // 
            // dataLayoutControl1
            // 
            this.dataLayoutControl1.Controls.Add(this.ykGridControl1);
            this.dataLayoutControl1.OptionsCustomizationForm.DesignTimeCustomizationFormPositionAndSize = new System.Drawing.Rectangle(584, 214, 250, 350);
            this.dataLayoutControl1.Size = new System.Drawing.Size(1113, 623);
            // 
            // layoutControlGroup1
            // 
            this.layoutControlGroup1.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItem1});
            this.layoutControlGroup1.Size = new System.Drawing.Size(1113, 623);
            // 
            // ykGridControl1
            // 
            this.ykGridControl1.Cursor = System.Windows.Forms.Cursors.Default;
            this.ykGridControl1.DataSource = this.mESM201PlanDetailBindingSource;
            this.ykGridControl1.EmbeddedNavigator.Buttons.Append.Visible = false;
            this.ykGridControl1.EmbeddedNavigator.Buttons.CancelEdit.Visible = false;
            this.ykGridControl1.EmbeddedNavigator.Buttons.Edit.Visible = false;
            this.ykGridControl1.EmbeddedNavigator.Buttons.EndEdit.Visible = false;
            this.ykGridControl1.EmbeddedNavigator.Buttons.Remove.Visible = false;
            this.ykGridControl1.EmbeddedNavigator.TextStringFormat = "记录:第{0}笔/共{1}笔";
            this.ykGridControl1.Location = new System.Drawing.Point(12, 12);
            this.ykGridControl1.MainView = this.gridTask;
            this.ykGridControl1.Name = "ykGridControl1";
            this.ykGridControl1.Size = new System.Drawing.Size(1089, 599);
            this.ykGridControl1.TabIndex = 10;
            this.ykGridControl1.UseEmbeddedNavigator = true;
            this.ykGridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridTask});
            // 
            // gridTask
            // 
            this.gridTask.Appearance.EvenRow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(234)))), ((int)(((byte)(250)))));
            this.gridTask.Appearance.EvenRow.Options.UseBackColor = true;
            this.gridTask.Appearance.OddRow.BackColor = System.Drawing.Color.White;
            this.gridTask.Appearance.OddRow.Options.UseBackColor = true;
            this.gridTask.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colCompCode,
            this.colPlanId,
            this.colPLNo,
            this.colSONo,
            this.colCustCode,
            this.colPartNo,
            this.colPartName,
            this.colPartSpec,
            this.colDetailType,
            this.colUnit,
            this.colQty,
            this.colFQty,
            this.colAdJustQty,
            this.colSumQty,
            this.colRemarks,
            this.colModifyDt,
            this.colModifyUser,
            this.colCreateDt,
            this.colCreateUser,
            this.colId});
            this.gridTask.GridControl = this.ykGridControl1;
            this.gridTask.IndicatorWidth = 40;
            this.gridTask.Name = "gridTask";
            this.gridTask.OptionsBehavior.ReadOnly = true;
            this.gridTask.OptionsFind.AlwaysVisible = true;
            this.gridTask.OptionsSelection.MultiSelect = true;
            this.gridTask.OptionsView.ColumnAutoWidth = false;
            this.gridTask.OptionsView.EnableAppearanceEvenRow = true;
            this.gridTask.OptionsView.EnableAppearanceOddRow = true;
            this.gridTask.OptionsView.ShowFilterPanelMode = DevExpress.XtraGrid.Views.Base.ShowFilterPanelMode.Never;
            this.gridTask.OptionsView.ShowGroupPanel = false;
            // 
            // layoutControlItem1
            // 
            this.layoutControlItem1.Control = this.ykGridControl1;
            this.layoutControlItem1.CustomizationFormText = "layoutControlItem1";
            this.layoutControlItem1.Location = new System.Drawing.Point(0, 0);
            this.layoutControlItem1.Name = "layoutControlItem1";
            this.layoutControlItem1.Size = new System.Drawing.Size(1093, 603);
            this.layoutControlItem1.Text = "layoutControlItem1";
            this.layoutControlItem1.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem1.TextToControlDistance = 0;
            this.layoutControlItem1.TextVisible = false;
            // 
            // mESM201PlanDetailBindingSource
            // 
            this.mESM201PlanDetailBindingSource.DataSource = typeof(ERP.Domain.MES_M201_Plan_Detail);
            // 
            // colCompCode
            // 
            this.colCompCode.FieldName = "CompCode";
            this.colCompCode.Name = "colCompCode";
            this.colCompCode.Visible = true;
            this.colCompCode.VisibleIndex = 0;
            // 
            // colPlanId
            // 
            this.colPlanId.FieldName = "PlanId";
            this.colPlanId.Name = "colPlanId";
            this.colPlanId.Visible = true;
            this.colPlanId.VisibleIndex = 1;
            // 
            // colPLNo
            // 
            this.colPLNo.FieldName = "PLNo";
            this.colPLNo.Name = "colPLNo";
            this.colPLNo.Visible = true;
            this.colPLNo.VisibleIndex = 2;
            // 
            // colSONo
            // 
            this.colSONo.FieldName = "SONo";
            this.colSONo.Name = "colSONo";
            this.colSONo.Visible = true;
            this.colSONo.VisibleIndex = 3;
            // 
            // colCustCode
            // 
            this.colCustCode.FieldName = "CustCode";
            this.colCustCode.Name = "colCustCode";
            this.colCustCode.Visible = true;
            this.colCustCode.VisibleIndex = 4;
            // 
            // colPartNo
            // 
            this.colPartNo.FieldName = "PartNo";
            this.colPartNo.Name = "colPartNo";
            this.colPartNo.Visible = true;
            this.colPartNo.VisibleIndex = 5;
            // 
            // colPartName
            // 
            this.colPartName.FieldName = "PartName";
            this.colPartName.Name = "colPartName";
            this.colPartName.Visible = true;
            this.colPartName.VisibleIndex = 6;
            // 
            // colPartSpec
            // 
            this.colPartSpec.FieldName = "PartSpec";
            this.colPartSpec.Name = "colPartSpec";
            this.colPartSpec.Visible = true;
            this.colPartSpec.VisibleIndex = 7;
            // 
            // colDetailType
            // 
            this.colDetailType.FieldName = "DetailType";
            this.colDetailType.Name = "colDetailType";
            this.colDetailType.Visible = true;
            this.colDetailType.VisibleIndex = 8;
            // 
            // colUnit
            // 
            this.colUnit.FieldName = "Unit";
            this.colUnit.Name = "colUnit";
            this.colUnit.Visible = true;
            this.colUnit.VisibleIndex = 9;
            // 
            // colQty
            // 
            this.colQty.FieldName = "Qty";
            this.colQty.Name = "colQty";
            this.colQty.Visible = true;
            this.colQty.VisibleIndex = 10;
            // 
            // colFQty
            // 
            this.colFQty.FieldName = "FQty";
            this.colFQty.Name = "colFQty";
            this.colFQty.Visible = true;
            this.colFQty.VisibleIndex = 11;
            // 
            // colAdJustQty
            // 
            this.colAdJustQty.FieldName = "AdJustQty";
            this.colAdJustQty.Name = "colAdJustQty";
            this.colAdJustQty.Visible = true;
            this.colAdJustQty.VisibleIndex = 12;
            // 
            // colSumQty
            // 
            this.colSumQty.FieldName = "SumQty";
            this.colSumQty.Name = "colSumQty";
            this.colSumQty.Visible = true;
            this.colSumQty.VisibleIndex = 13;
            // 
            // colRemarks
            // 
            this.colRemarks.FieldName = "Remarks";
            this.colRemarks.Name = "colRemarks";
            this.colRemarks.Visible = true;
            this.colRemarks.VisibleIndex = 14;
            // 
            // colModifyDt
            // 
            this.colModifyDt.FieldName = "ModifyDt";
            this.colModifyDt.Name = "colModifyDt";
            this.colModifyDt.Visible = true;
            this.colModifyDt.VisibleIndex = 15;
            // 
            // colModifyUser
            // 
            this.colModifyUser.FieldName = "ModifyUser";
            this.colModifyUser.Name = "colModifyUser";
            this.colModifyUser.Visible = true;
            this.colModifyUser.VisibleIndex = 16;
            // 
            // colCreateDt
            // 
            this.colCreateDt.FieldName = "CreateDt";
            this.colCreateDt.Name = "colCreateDt";
            this.colCreateDt.Visible = true;
            this.colCreateDt.VisibleIndex = 17;
            // 
            // colCreateUser
            // 
            this.colCreateUser.FieldName = "CreateUser";
            this.colCreateUser.Name = "colCreateUser";
            this.colCreateUser.Visible = true;
            this.colCreateUser.VisibleIndex = 18;
            // 
            // colId
            // 
            this.colId.FieldName = "Id";
            this.colId.Name = "colId";
            this.colId.Visible = true;
            this.colId.VisibleIndex = 19;
            // 
            // MES202TaskChoosePlanForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1121, 660);
            this.Name = "MES202TaskChoosePlanForm";
            this.Text = "MES202TaskChoosePlanForm";
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataLayoutControl1)).EndInit();
            this.dataLayoutControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ykGridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridTask)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mESM201PlanDetailBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private COM.YKControls.YKGridControl ykGridControl1;
        private System.Windows.Forms.BindingSource mESM201PlanDetailBindingSource;
        private DevExpress.XtraGrid.Views.Grid.GridView gridTask;
        private DevExpress.XtraGrid.Columns.GridColumn colCompCode;
        private DevExpress.XtraGrid.Columns.GridColumn colPlanId;
        private DevExpress.XtraGrid.Columns.GridColumn colPLNo;
        private DevExpress.XtraGrid.Columns.GridColumn colSONo;
        private DevExpress.XtraGrid.Columns.GridColumn colCustCode;
        private DevExpress.XtraGrid.Columns.GridColumn colPartNo;
        private DevExpress.XtraGrid.Columns.GridColumn colPartName;
        private DevExpress.XtraGrid.Columns.GridColumn colPartSpec;
        private DevExpress.XtraGrid.Columns.GridColumn colDetailType;
        private DevExpress.XtraGrid.Columns.GridColumn colUnit;
        private DevExpress.XtraGrid.Columns.GridColumn colQty;
        private DevExpress.XtraGrid.Columns.GridColumn colFQty;
        private DevExpress.XtraGrid.Columns.GridColumn colAdJustQty;
        private DevExpress.XtraGrid.Columns.GridColumn colSumQty;
        private DevExpress.XtraGrid.Columns.GridColumn colRemarks;
        private DevExpress.XtraGrid.Columns.GridColumn colModifyDt;
        private DevExpress.XtraGrid.Columns.GridColumn colModifyUser;
        private DevExpress.XtraGrid.Columns.GridColumn colCreateDt;
        private DevExpress.XtraGrid.Columns.GridColumn colCreateUser;
        private DevExpress.XtraGrid.Columns.GridColumn colId;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem1;
    }
}