namespace ERP.Winform.MES.Report
{
    partial class Y102_DailyYieldForm
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
            this.dockManager1 = new DevExpress.XtraBars.Docking.DockManager(this.components);
            this.dockPanel1 = new DevExpress.XtraBars.Docking.DockPanel();
            this.dockPanel1_Container = new DevExpress.XtraBars.Docking.ControlContainer();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.simpleButton1 = new DevExpress.XtraEditors.SimpleButton();
            this.txtProdDt1 = new DevExpress.XtraEditors.DateEdit();
            this.txtProdDt2 = new DevExpress.XtraEditors.DateEdit();
            this.pivotGridControl1 = new DevExpress.XtraPivotGrid.PivotGridControl();
            this.fieldProcess1 = new DevExpress.XtraPivotGrid.PivotGridField();
            this.fieldJobType1 = new DevExpress.XtraPivotGrid.PivotGridField();
            this.fieldCategory1 = new DevExpress.XtraPivotGrid.PivotGridField();
            this.fieldPartNo1 = new DevExpress.XtraPivotGrid.PivotGridField();
            this.fieldPlanQty1 = new DevExpress.XtraPivotGrid.PivotGridField();
            this.fieldInQty1 = new DevExpress.XtraPivotGrid.PivotGridField();
            this.fieldOutQty1 = new DevExpress.XtraPivotGrid.PivotGridField();
            this.fieldDiffQty1 = new DevExpress.XtraPivotGrid.PivotGridField();
            this.fieldInQtyFactor1 = new DevExpress.XtraPivotGrid.PivotGridField();
            this.fieldOutQtyFactor1 = new DevExpress.XtraPivotGrid.PivotGridField();
            this.fieldRate = new DevExpress.XtraPivotGrid.PivotGridField();
            this.mESY102DailyYieldBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.fieldProdDt = new DevExpress.XtraPivotGrid.PivotGridField();
            ((System.ComponentModel.ISupportInitialize)(this.dockManager1)).BeginInit();
            this.dockPanel1.SuspendLayout();
            this.dockPanel1_Container.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtProdDt1.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtProdDt1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtProdDt2.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtProdDt2.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pivotGridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mESY102DailyYieldBindingSource)).BeginInit();
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
            this.dockPanel1.ID = new System.Guid("2c3e095e-c194-43d7-a8ff-28e3340df1cf");
            this.dockPanel1.Location = new System.Drawing.Point(0, 0);
            this.dockPanel1.Name = "dockPanel1";
            this.dockPanel1.OriginalSize = new System.Drawing.Size(200, 88);
            this.dockPanel1.Size = new System.Drawing.Size(1123, 88);
            this.dockPanel1.Text = "查询条件";
            // 
            // dockPanel1_Container
            // 
            this.dockPanel1_Container.Controls.Add(this.labelControl2);
            this.dockPanel1_Container.Controls.Add(this.labelControl1);
            this.dockPanel1_Container.Controls.Add(this.simpleButton1);
            this.dockPanel1_Container.Controls.Add(this.txtProdDt1);
            this.dockPanel1_Container.Controls.Add(this.txtProdDt2);
            this.dockPanel1_Container.Location = new System.Drawing.Point(4, 23);
            this.dockPanel1_Container.Name = "dockPanel1_Container";
            this.dockPanel1_Container.Size = new System.Drawing.Size(1115, 61);
            this.dockPanel1_Container.TabIndex = 0;
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(220, 16);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(4, 14);
            this.labelControl2.TabIndex = 5;
            this.labelControl2.Text = "-";
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(29, 16);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(52, 14);
            this.labelControl1.TabIndex = 4;
            this.labelControl1.Text = "生产日期:";
            // 
            // simpleButton1
            // 
            this.simpleButton1.Location = new System.Drawing.Point(464, 14);
            this.simpleButton1.Name = "simpleButton1";
            this.simpleButton1.Size = new System.Drawing.Size(75, 23);
            this.simpleButton1.TabIndex = 3;
            this.simpleButton1.Text = "查询";
            this.simpleButton1.Click += new System.EventHandler(this.simpleButton1_Click);
            // 
            // txtProdDt1
            // 
            this.txtProdDt1.EditValue = null;
            this.txtProdDt1.Location = new System.Drawing.Point(89, 13);
            this.txtProdDt1.MenuManager = this.barManager1;
            this.txtProdDt1.Name = "txtProdDt1";
            this.txtProdDt1.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.txtProdDt1.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.txtProdDt1.Properties.Mask.EditMask = "";
            this.txtProdDt1.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.None;
            this.txtProdDt1.Size = new System.Drawing.Size(127, 20);
            this.txtProdDt1.TabIndex = 0;
            // 
            // txtProdDt2
            // 
            this.txtProdDt2.EditValue = null;
            this.txtProdDt2.Location = new System.Drawing.Point(230, 13);
            this.txtProdDt2.MenuManager = this.barManager1;
            this.txtProdDt2.Name = "txtProdDt2";
            this.txtProdDt2.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.txtProdDt2.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.txtProdDt2.Properties.Mask.EditMask = "";
            this.txtProdDt2.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.None;
            this.txtProdDt2.Size = new System.Drawing.Size(152, 20);
            this.txtProdDt2.TabIndex = 1;
            // 
            // pivotGridControl1
            // 
            this.pivotGridControl1.Appearance.GrandTotalCell.BackColor = System.Drawing.Color.CornflowerBlue;
            this.pivotGridControl1.Appearance.GrandTotalCell.Options.UseBackColor = true;
            this.pivotGridControl1.Appearance.TotalCell.BackColor = System.Drawing.Color.DodgerBlue;
            this.pivotGridControl1.Appearance.TotalCell.Options.UseBackColor = true;
            this.pivotGridControl1.DataSource = this.mESY102DailyYieldBindingSource;
            this.pivotGridControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pivotGridControl1.Fields.AddRange(new DevExpress.XtraPivotGrid.PivotGridField[] {
            this.fieldProcess1,
            this.fieldJobType1,
            this.fieldCategory1,
            this.fieldPartNo1,
            this.fieldPlanQty1,
            this.fieldInQty1,
            this.fieldOutQty1,
            this.fieldDiffQty1,
            this.fieldInQtyFactor1,
            this.fieldOutQtyFactor1,
            this.fieldRate,
            this.fieldProdDt});
            this.pivotGridControl1.Location = new System.Drawing.Point(0, 88);
            this.pivotGridControl1.Name = "pivotGridControl1";
            this.pivotGridControl1.OptionsView.ShowColumnGrandTotals = false;
            this.pivotGridControl1.Size = new System.Drawing.Size(1123, 435);
            this.pivotGridControl1.TabIndex = 5;
            this.pivotGridControl1.CustomSummary += new DevExpress.XtraPivotGrid.PivotGridCustomSummaryEventHandler(this.pivotGridControl1_CustomSummary);
            this.pivotGridControl1.CustomDrawCell += new DevExpress.XtraPivotGrid.PivotCustomDrawCellEventHandler(this.pivotGridControl1_CustomDrawCell);
            // 
            // fieldProcess1
            // 
            this.fieldProcess1.Area = DevExpress.XtraPivotGrid.PivotArea.ColumnArea;
            this.fieldProcess1.AreaIndex = 0;
            this.fieldProcess1.Caption = "制程";
            this.fieldProcess1.FieldName = "Process";
            this.fieldProcess1.Name = "fieldProcess1";
            // 
            // fieldJobType1
            // 
            this.fieldJobType1.AreaIndex = 0;
            this.fieldJobType1.Caption = "生产类型";
            this.fieldJobType1.FieldName = "JobType";
            this.fieldJobType1.Name = "fieldJobType1";
            // 
            // fieldCategory1
            // 
            this.fieldCategory1.Area = DevExpress.XtraPivotGrid.PivotArea.RowArea;
            this.fieldCategory1.AreaIndex = 0;
            this.fieldCategory1.Caption = "产品系列";
            this.fieldCategory1.FieldName = "Category";
            this.fieldCategory1.Name = "fieldCategory1";
            // 
            // fieldPartNo1
            // 
            this.fieldPartNo1.Area = DevExpress.XtraPivotGrid.PivotArea.RowArea;
            this.fieldPartNo1.AreaIndex = 1;
            this.fieldPartNo1.Caption = "产品型号";
            this.fieldPartNo1.FieldName = "PartNo";
            this.fieldPartNo1.Name = "fieldPartNo1";
            // 
            // fieldPlanQty1
            // 
            this.fieldPlanQty1.Appearance.Cell.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.fieldPlanQty1.Appearance.Cell.Options.UseBackColor = true;
            this.fieldPlanQty1.Area = DevExpress.XtraPivotGrid.PivotArea.DataArea;
            this.fieldPlanQty1.AreaIndex = 2;
            this.fieldPlanQty1.Caption = "计划量";
            this.fieldPlanQty1.CellFormat.FormatString = "n2";
            this.fieldPlanQty1.CellFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.fieldPlanQty1.FieldName = "PlanQty";
            this.fieldPlanQty1.Name = "fieldPlanQty1";
            // 
            // fieldInQty1
            // 
            this.fieldInQty1.Appearance.Cell.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.fieldInQty1.Appearance.Cell.Options.UseBackColor = true;
            this.fieldInQty1.Area = DevExpress.XtraPivotGrid.PivotArea.DataArea;
            this.fieldInQty1.AreaIndex = 0;
            this.fieldInQty1.Caption = "累计投入";
            this.fieldInQty1.CellFormat.FormatString = "n2";
            this.fieldInQty1.CellFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.fieldInQty1.FieldName = "InQty";
            this.fieldInQty1.Name = "fieldInQty1";
            // 
            // fieldOutQty1
            // 
            this.fieldOutQty1.Appearance.Cell.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.fieldOutQty1.Appearance.Cell.Options.UseBackColor = true;
            this.fieldOutQty1.Area = DevExpress.XtraPivotGrid.PivotArea.DataArea;
            this.fieldOutQty1.AreaIndex = 1;
            this.fieldOutQty1.Caption = "累计产出";
            this.fieldOutQty1.CellFormat.FormatString = "n2";
            this.fieldOutQty1.CellFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.fieldOutQty1.FieldName = "OutQty";
            this.fieldOutQty1.Name = "fieldOutQty1";
            // 
            // fieldDiffQty1
            // 
            this.fieldDiffQty1.AreaIndex = 1;
            this.fieldDiffQty1.Caption = "累计报废";
            this.fieldDiffQty1.FieldName = "DiffQty";
            this.fieldDiffQty1.Name = "fieldDiffQty1";
            // 
            // fieldInQtyFactor1
            // 
            this.fieldInQtyFactor1.AreaIndex = 2;
            this.fieldInQtyFactor1.Caption = "In Qty Factor";
            this.fieldInQtyFactor1.FieldName = "InQtyFactor";
            this.fieldInQtyFactor1.Name = "fieldInQtyFactor1";
            // 
            // fieldOutQtyFactor1
            // 
            this.fieldOutQtyFactor1.AreaIndex = 3;
            this.fieldOutQtyFactor1.Caption = "Out Qty Factor";
            this.fieldOutQtyFactor1.FieldName = "OutQtyFactor";
            this.fieldOutQtyFactor1.Name = "fieldOutQtyFactor1";
            // 
            // fieldRate
            // 
            this.fieldRate.Area = DevExpress.XtraPivotGrid.PivotArea.DataArea;
            this.fieldRate.AreaIndex = 3;
            this.fieldRate.Caption = "达成率";
            this.fieldRate.CellFormat.FormatString = "P";
            this.fieldRate.CellFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.fieldRate.Name = "fieldRate";
            this.fieldRate.SummaryType = DevExpress.Data.PivotGrid.PivotSummaryType.Custom;
            this.fieldRate.ValueFormat.FormatString = "P";
            this.fieldRate.ValueFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            // 
            // mESY102DailyYieldBindingSource
            // 
            this.mESY102DailyYieldBindingSource.DataSource = typeof(ERP.Domain.MES_Y102_DailyYield);
            // 
            // fieldProdDt
            // 
            this.fieldProdDt.Area = DevExpress.XtraPivotGrid.PivotArea.ColumnArea;
            this.fieldProdDt.AreaIndex = 1;
            this.fieldProdDt.Caption = "生产日期";
            this.fieldProdDt.CellFormat.FormatString = "{0:yyyy-MM-dd}";
            this.fieldProdDt.CellFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.fieldProdDt.FieldName = "ProdDt";
            this.fieldProdDt.Name = "fieldProdDt";
            this.fieldProdDt.ValueFormat.FormatString = "{0:yyyy-MM-dd}";
            this.fieldProdDt.ValueFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            // 
            // Y102_DailyYieldForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1123, 552);
            this.Controls.Add(this.pivotGridControl1);
            this.Controls.Add(this.dockPanel1);
            this.Name = "Y102_DailyYieldForm";
            this.Text = "Y102-产量日报表";
            this.Controls.SetChildIndex(this.dockPanel1, 0);
            this.Controls.SetChildIndex(this.pivotGridControl1, 0);
            ((System.ComponentModel.ISupportInitialize)(this.dockManager1)).EndInit();
            this.dockPanel1.ResumeLayout(false);
            this.dockPanel1_Container.ResumeLayout(false);
            this.dockPanel1_Container.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtProdDt1.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtProdDt1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtProdDt2.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtProdDt2.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pivotGridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mESY102DailyYieldBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraBars.Docking.DockManager dockManager1;
        private DevExpress.XtraBars.Docking.DockPanel dockPanel1;
        private DevExpress.XtraBars.Docking.ControlContainer dockPanel1_Container;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.SimpleButton simpleButton1;
        private DevExpress.XtraEditors.DateEdit txtProdDt1;
        private DevExpress.XtraEditors.DateEdit txtProdDt2;
        private DevExpress.XtraPivotGrid.PivotGridControl pivotGridControl1;
        private DevExpress.XtraPivotGrid.PivotGridField fieldProcess1;
        private DevExpress.XtraPivotGrid.PivotGridField fieldJobType1;
        private DevExpress.XtraPivotGrid.PivotGridField fieldCategory1;
        private DevExpress.XtraPivotGrid.PivotGridField fieldPartNo1;
        private DevExpress.XtraPivotGrid.PivotGridField fieldPlanQty1;
        private DevExpress.XtraPivotGrid.PivotGridField fieldInQty1;
        private DevExpress.XtraPivotGrid.PivotGridField fieldOutQty1;
        private DevExpress.XtraPivotGrid.PivotGridField fieldDiffQty1;
        private DevExpress.XtraPivotGrid.PivotGridField fieldInQtyFactor1;
        private DevExpress.XtraPivotGrid.PivotGridField fieldOutQtyFactor1;
        private DevExpress.XtraPivotGrid.PivotGridField fieldRate;
        private System.Windows.Forms.BindingSource mESY102DailyYieldBindingSource;
        private DevExpress.XtraPivotGrid.PivotGridField fieldProdDt;
    }
}