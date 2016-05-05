namespace ERP.Winform.MES.Report
{
    partial class R102_JobDelayForm
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
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.simpleButton1 = new DevExpress.XtraEditors.SimpleButton();
            this.txtProdDt1 = new DevExpress.XtraEditors.DateEdit();
            this.txtProdDt2 = new DevExpress.XtraEditors.DateEdit();
            this.txtDays = new DevExpress.XtraEditors.SpinEdit();
            this.pivotGridControl1 = new DevExpress.XtraPivotGrid.PivotGridControl();
            this.mESR102JobDelayBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.fieldProcess1 = new DevExpress.XtraPivotGrid.PivotGridField();
            this.fieldJobType1 = new DevExpress.XtraPivotGrid.PivotGridField();
            this.fieldCategory1 = new DevExpress.XtraPivotGrid.PivotGridField();
            this.fieldPartNo1 = new DevExpress.XtraPivotGrid.PivotGridField();
            this.fieldProdDt11 = new DevExpress.XtraPivotGrid.PivotGridField();
            this.fieldProdDt21 = new DevExpress.XtraPivotGrid.PivotGridField();
            this.fieldDelay1 = new DevExpress.XtraPivotGrid.PivotGridField();
            this.fieldQty1 = new DevExpress.XtraPivotGrid.PivotGridField();
            ((System.ComponentModel.ISupportInitialize)(this.dockManager1)).BeginInit();
            this.dockPanel1.SuspendLayout();
            this.dockPanel1_Container.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtProdDt1.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtProdDt1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtProdDt2.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtProdDt2.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDays.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pivotGridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mESR102JobDelayBindingSource)).BeginInit();
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
            this.dockPanel1.OriginalSize = new System.Drawing.Size(200, 107);
            this.dockPanel1.Size = new System.Drawing.Size(1123, 107);
            this.dockPanel1.Text = "查询条件";
            // 
            // dockPanel1_Container
            // 
            this.dockPanel1_Container.Controls.Add(this.labelControl4);
            this.dockPanel1_Container.Controls.Add(this.labelControl3);
            this.dockPanel1_Container.Controls.Add(this.labelControl2);
            this.dockPanel1_Container.Controls.Add(this.labelControl1);
            this.dockPanel1_Container.Controls.Add(this.simpleButton1);
            this.dockPanel1_Container.Controls.Add(this.txtProdDt1);
            this.dockPanel1_Container.Controls.Add(this.txtProdDt2);
            this.dockPanel1_Container.Controls.Add(this.txtDays);
            this.dockPanel1_Container.Location = new System.Drawing.Point(4, 23);
            this.dockPanel1_Container.Name = "dockPanel1_Container";
            this.dockPanel1_Container.Size = new System.Drawing.Size(1115, 80);
            this.dockPanel1_Container.TabIndex = 0;
            // 
            // labelControl4
            // 
            this.labelControl4.Appearance.ForeColor = System.Drawing.Color.Blue;
            this.labelControl4.Location = new System.Drawing.Point(673, 20);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(304, 28);
            this.labelControl4.TabIndex = 7;
            this.labelControl4.Text = "备注： 未生产天数指工序领料日期至当天的天数\r\n          延期生产天数指工序生产日期与出库的日期的天数";
            // 
            // labelControl3
            // 
            this.labelControl3.Location = new System.Drawing.Point(29, 39);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(28, 14);
            this.labelControl3.TabIndex = 6;
            this.labelControl3.Text = "天数:";
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(220, 7);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(4, 14);
            this.labelControl2.TabIndex = 5;
            this.labelControl2.Text = "-";
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(29, 7);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(52, 14);
            this.labelControl1.TabIndex = 4;
            this.labelControl1.Text = "生产日期:";
            // 
            // simpleButton1
            // 
            this.simpleButton1.Location = new System.Drawing.Point(464, 25);
            this.simpleButton1.Name = "simpleButton1";
            this.simpleButton1.Size = new System.Drawing.Size(75, 23);
            this.simpleButton1.TabIndex = 3;
            this.simpleButton1.Text = "查询";
            this.simpleButton1.Click += new System.EventHandler(this.simpleButton1_Click);
            // 
            // txtProdDt1
            // 
            this.txtProdDt1.EditValue = null;
            this.txtProdDt1.Location = new System.Drawing.Point(89, 4);
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
            this.txtProdDt2.Location = new System.Drawing.Point(230, 4);
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
            // txtDays
            // 
            this.txtDays.EditValue = new decimal(new int[] {
            3,
            0,
            0,
            0});
            this.txtDays.Location = new System.Drawing.Point(89, 36);
            this.txtDays.MenuManager = this.barManager1;
            this.txtDays.Name = "txtDays";
            this.txtDays.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.txtDays.Properties.EditValueChangedFiringMode = DevExpress.XtraEditors.Controls.EditValueChangedFiringMode.Default;
            this.txtDays.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.None;
            this.txtDays.Size = new System.Drawing.Size(127, 20);
            this.txtDays.TabIndex = 2;
            // 
            // pivotGridControl1
            // 
            this.pivotGridControl1.DataSource = this.mESR102JobDelayBindingSource;
            this.pivotGridControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pivotGridControl1.Fields.AddRange(new DevExpress.XtraPivotGrid.PivotGridField[] {
            this.fieldProcess1,
            this.fieldJobType1,
            this.fieldCategory1,
            this.fieldPartNo1,
            this.fieldProdDt11,
            this.fieldProdDt21,
            this.fieldDelay1,
            this.fieldQty1});
            this.pivotGridControl1.Location = new System.Drawing.Point(0, 107);
            this.pivotGridControl1.Name = "pivotGridControl1";
            this.pivotGridControl1.Size = new System.Drawing.Size(1123, 416);
            this.pivotGridControl1.TabIndex = 5;
            // 
            // mESR102JobDelayBindingSource
            // 
            this.mESR102JobDelayBindingSource.DataSource = typeof(ERP.Domain.MES_R102_JobDelay);
            // 
            // fieldProcess1
            // 
            this.fieldProcess1.Area = DevExpress.XtraPivotGrid.PivotArea.RowArea;
            this.fieldProcess1.AreaIndex = 0;
            this.fieldProcess1.Caption = "制程";
            this.fieldProcess1.FieldName = "Process";
            this.fieldProcess1.Name = "fieldProcess1";
            // 
            // fieldJobType1
            // 
            this.fieldJobType1.Area = DevExpress.XtraPivotGrid.PivotArea.RowArea;
            this.fieldJobType1.AreaIndex = 1;
            this.fieldJobType1.Caption = "生产类型";
            this.fieldJobType1.FieldName = "JobType";
            this.fieldJobType1.Name = "fieldJobType1";
            // 
            // fieldCategory1
            // 
            this.fieldCategory1.Area = DevExpress.XtraPivotGrid.PivotArea.RowArea;
            this.fieldCategory1.AreaIndex = 2;
            this.fieldCategory1.Caption = "产品系列";
            this.fieldCategory1.FieldName = "Category";
            this.fieldCategory1.Name = "fieldCategory1";
            // 
            // fieldPartNo1
            // 
            this.fieldPartNo1.Area = DevExpress.XtraPivotGrid.PivotArea.RowArea;
            this.fieldPartNo1.AreaIndex = 3;
            this.fieldPartNo1.Caption = "产品型号";
            this.fieldPartNo1.FieldName = "PartNo";
            this.fieldPartNo1.Name = "fieldPartNo1";
            // 
            // fieldProdDt11
            // 
            this.fieldProdDt11.Area = DevExpress.XtraPivotGrid.PivotArea.RowArea;
            this.fieldProdDt11.AreaIndex = 4;
            this.fieldProdDt11.Caption = "投产日期";
            this.fieldProdDt11.CellFormat.FormatString = "{0:yyyy-MM-dd}";
            this.fieldProdDt11.CellFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.fieldProdDt11.FieldName = "ProdDt1";
            this.fieldProdDt11.GrandTotalCellFormat.FormatString = "{0:yyyy-MM-dd}";
            this.fieldProdDt11.GrandTotalCellFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.fieldProdDt11.Name = "fieldProdDt11";
            this.fieldProdDt11.ValueFormat.FormatString = "{0:yyyy-MM-dd}";
            this.fieldProdDt11.ValueFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            // 
            // fieldProdDt21
            // 
            this.fieldProdDt21.AreaIndex = 0;
            this.fieldProdDt21.Caption = "产出日期";
            this.fieldProdDt21.CellFormat.FormatString = "{0:yyyy-MM-dd}";
            this.fieldProdDt21.CellFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.fieldProdDt21.FieldName = "ProdDt2";
            this.fieldProdDt21.Name = "fieldProdDt21";
            // 
            // fieldDelay1
            // 
            this.fieldDelay1.Area = DevExpress.XtraPivotGrid.PivotArea.RowArea;
            this.fieldDelay1.AreaIndex = 5;
            this.fieldDelay1.Caption = "延期天数";
            this.fieldDelay1.FieldName = "Delay";
            this.fieldDelay1.Name = "fieldDelay1";
            // 
            // fieldQty1
            // 
            this.fieldQty1.Area = DevExpress.XtraPivotGrid.PivotArea.DataArea;
            this.fieldQty1.AreaIndex = 0;
            this.fieldQty1.Caption = "数量";
            this.fieldQty1.CellFormat.FormatString = "{0:N2}";
            this.fieldQty1.CellFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.fieldQty1.FieldName = "Qty";
            this.fieldQty1.Name = "fieldQty1";
            // 
            // R102_JobDelayForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1123, 552);
            this.Controls.Add(this.pivotGridControl1);
            this.Controls.Add(this.dockPanel1);
            this.Name = "R102_JobDelayForm";
            this.Text = "R102-生产延期表";
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
            ((System.ComponentModel.ISupportInitialize)(this.txtDays.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pivotGridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mESR102JobDelayBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraBars.Docking.DockManager dockManager1;
        private DevExpress.XtraBars.Docking.DockPanel dockPanel1;
        private DevExpress.XtraBars.Docking.ControlContainer dockPanel1_Container;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.SimpleButton simpleButton1;
        private DevExpress.XtraEditors.DateEdit txtProdDt1;
        private DevExpress.XtraEditors.DateEdit txtProdDt2;
        private DevExpress.XtraEditors.SpinEdit txtDays;
        private DevExpress.XtraPivotGrid.PivotGridControl pivotGridControl1;
        private System.Windows.Forms.BindingSource mESR102JobDelayBindingSource;
        private DevExpress.XtraPivotGrid.PivotGridField fieldProcess1;
        private DevExpress.XtraPivotGrid.PivotGridField fieldJobType1;
        private DevExpress.XtraPivotGrid.PivotGridField fieldCategory1;
        private DevExpress.XtraPivotGrid.PivotGridField fieldPartNo1;
        private DevExpress.XtraPivotGrid.PivotGridField fieldProdDt11;
        private DevExpress.XtraPivotGrid.PivotGridField fieldProdDt21;
        private DevExpress.XtraPivotGrid.PivotGridField fieldDelay1;
        private DevExpress.XtraPivotGrid.PivotGridField fieldQty1;
    }
}