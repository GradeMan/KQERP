namespace ERP.Winform.MES
{
    partial class PackingScanForm
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
            this.mESM802PackingDtlBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colCompCode = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDocNo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colJobNo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colShipLot = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colShipLotPackage = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colShipLotQty = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colRemarks = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colModifyDt = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colModifyUser = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCreateDt = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCreateUser = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colId = new DevExpress.XtraGrid.Columns.GridColumn();
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.simpleButton1 = new DevExpress.XtraEditors.SimpleButton();
            this.lbTips = new DevExpress.XtraEditors.LabelControl();
            this.txtBarCode = new DevExpress.XtraEditors.MemoEdit();
            this.labelControl7 = new DevExpress.XtraEditors.LabelControl();
            this.lbJobPackage = new DevExpress.XtraEditors.LabelControl();
            this.layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
            this.groupControl2 = new DevExpress.XtraEditors.GroupControl();
            this.dataLayoutControl2 = new DevExpress.XtraDataLayout.DataLayoutControl();
            this.CustCodeTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.eRPM001ProductPackInfoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.CustPartNoTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.CustPartNameTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.CustPartTypeTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.CustPartSpecTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.PackPianZhiSpinEdit = new DevExpress.XtraEditors.SpinEdit();
            this.PackBaoPianSpinEdit = new DevExpress.XtraEditors.SpinEdit();
            this.PackHeBaoSpinEdit = new DevExpress.XtraEditors.SpinEdit();
            this.PackXiangHeSpinEdit = new DevExpress.XtraEditors.SpinEdit();
            this.layoutControlGroup2 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlGroup3 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.ItemForCustPartNo = new DevExpress.XtraLayout.LayoutControlItem();
            this.ItemForCustPartType = new DevExpress.XtraLayout.LayoutControlItem();
            this.ItemForCustPartSpec = new DevExpress.XtraLayout.LayoutControlItem();
            this.ItemForPackBaoPian = new DevExpress.XtraLayout.LayoutControlItem();
            this.ItemForPackXiangHe = new DevExpress.XtraLayout.LayoutControlItem();
            this.ItemForCustCode = new DevExpress.XtraLayout.LayoutControlItem();
            this.ItemForCustPartName = new DevExpress.XtraLayout.LayoutControlItem();
            this.ItemForPackPianZhi = new DevExpress.XtraLayout.LayoutControlItem();
            this.ItemForPackHeBao = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem3 = new DevExpress.XtraLayout.LayoutControlItem();
            this.ykGridControl2 = new COM.YKControls.YKGridControl();
            this.mESM801LabelSBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gridView2 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colCompCode1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colLotNo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMLotNo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPackSeqNo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPartNo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPartName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPartType = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPartSpec = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCustCode = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCustPartNo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCustPartName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCustPartType = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCustPartSpec = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCustDrawingNo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCustPONo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCustLotNo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colProdDt = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colExpiredDt = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMatCode = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMatType = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colQty = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCode2D = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colUnit = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIsPack = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colLBPartNo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colLBPartName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPQty = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colLBSpec1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colLBSpec2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colId1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.layoutControlItem4 = new DevExpress.XtraLayout.LayoutControlItem();
            this.groupControl3 = new DevExpress.XtraEditors.GroupControl();
            this.dataLayoutControl4 = new DevExpress.XtraDataLayout.DataLayoutControl();
            this.DocNoTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.mESM802PackingHdBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ProdDtDateEdit = new DevExpress.XtraEditors.DateEdit();
            this.QtySpinEdit = new DevExpress.XtraEditors.SpinEdit();
            this.PackageSpinEdit = new DevExpress.XtraEditors.SpinEdit();
            this.textEdit3 = new DevExpress.XtraEditors.TextEdit();
            this.txtJobNo = new DevExpress.XtraEditors.TextEdit();
            this.PartNoTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.PartTypeTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.SubShipLot1stTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.LotNoListTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.LotNoPackListTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.LotNoPackQtyListTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.CreateDtDateEdit = new DevExpress.XtraEditors.DateEdit();
            this.CreateUserTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.ModifyDtDateEdit = new DevExpress.XtraEditors.DateEdit();
            this.ModifyUserTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.RemarksTextEdit = new DevExpress.XtraEditors.MemoEdit();
            this.layoutControlGroup6 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlGroup7 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.ItemForProdDt = new DevExpress.XtraLayout.LayoutControlItem();
            this.ItemForSubShipLot1st = new DevExpress.XtraLayout.LayoutControlItem();
            this.ItemForLotNoList = new DevExpress.XtraLayout.LayoutControlItem();
            this.ItemForLotNoPackList = new DevExpress.XtraLayout.LayoutControlItem();
            this.ItemForLotNoPackQtyList = new DevExpress.XtraLayout.LayoutControlItem();
            this.ItemForDocNo = new DevExpress.XtraLayout.LayoutControlItem();
            this.ItemForQty = new DevExpress.XtraLayout.LayoutControlItem();
            this.ItemForPackage = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem10 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem9 = new DevExpress.XtraLayout.LayoutControlItem();
            this.ItemForPartNo = new DevExpress.XtraLayout.LayoutControlItem();
            this.ItemForPartType = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlGroup8 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.ItemForModifyUser = new DevExpress.XtraLayout.LayoutControlItem();
            this.ItemForModifyDt = new DevExpress.XtraLayout.LayoutControlItem();
            this.ItemForCreateUser = new DevExpress.XtraLayout.LayoutControlItem();
            this.ItemForCreateDt = new DevExpress.XtraLayout.LayoutControlItem();
            this.ItemForRemarks = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem2 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem5 = new DevExpress.XtraLayout.LayoutControlItem();
            this.groupControl4 = new DevExpress.XtraEditors.GroupControl();
            this.dataLayoutControl3 = new DevExpress.XtraDataLayout.DataLayoutControl();
            this.JobNoTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.mESM501JobTxBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.LotNoTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.textEdit1 = new DevExpress.XtraEditors.TextEdit();
            this.textEdit2 = new DevExpress.XtraEditors.TextEdit();
            this.QCOperatorTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.InQtyInkSpinEdit = new DevExpress.XtraEditors.SpinEdit();
            this.OutQtyInkSpinEdit = new DevExpress.XtraEditors.SpinEdit();
            this.NGQtyInkSpinEdit = new DevExpress.XtraEditors.SpinEdit();
            this.layoutControlGroup4 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlGroup5 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.ItemForJobNo = new DevExpress.XtraLayout.LayoutControlItem();
            this.ItemForLotNo = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem7 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem8 = new DevExpress.XtraLayout.LayoutControlItem();
            this.ItemForQCOperator = new DevExpress.XtraLayout.LayoutControlItem();
            this.ItemForInQtyInk = new DevExpress.XtraLayout.LayoutControlItem();
            this.ItemForOutQtyInk = new DevExpress.XtraLayout.LayoutControlItem();
            this.ItemForNGQtyInk = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem6 = new DevExpress.XtraLayout.LayoutControlItem();
            this.emptySpaceItem1 = new DevExpress.XtraLayout.EmptySpaceItem();
            this.layoutConverter1 = new DevExpress.XtraLayout.Converter.LayoutConverter(this.components);
            this.layoutConverter2 = new DevExpress.XtraLayout.Converter.LayoutConverter(this.components);
            this.layoutControlGroup9 = new DevExpress.XtraLayout.LayoutControlGroup();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataLayoutControl1)).BeginInit();
            this.dataLayoutControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ykGridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mESM802PackingDtlBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtBarCode.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).BeginInit();
            this.groupControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataLayoutControl2)).BeginInit();
            this.dataLayoutControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.CustCodeTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.eRPM001ProductPackInfoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CustPartNoTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CustPartNameTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CustPartTypeTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CustPartSpecTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PackPianZhiSpinEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PackBaoPianSpinEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PackHeBaoSpinEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PackXiangHeSpinEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForCustPartNo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForCustPartType)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForCustPartSpec)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForPackBaoPian)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForPackXiangHe)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForCustCode)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForCustPartName)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForPackPianZhi)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForPackHeBao)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ykGridControl2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mESM801LabelSBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl3)).BeginInit();
            this.groupControl3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataLayoutControl4)).BeginInit();
            this.dataLayoutControl4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DocNoTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mESM802PackingHdBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ProdDtDateEdit.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ProdDtDateEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.QtySpinEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PackageSpinEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit3.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtJobNo.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PartNoTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PartTypeTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SubShipLot1stTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.LotNoListTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.LotNoPackListTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.LotNoPackQtyListTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CreateDtDateEdit.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CreateDtDateEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CreateUserTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ModifyDtDateEdit.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ModifyDtDateEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ModifyUserTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.RemarksTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForProdDt)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForSubShipLot1st)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForLotNoList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForLotNoPackList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForLotNoPackQtyList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForDocNo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForQty)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForPackage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem10)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem9)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForPartNo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForPartType)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup8)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForModifyUser)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForModifyDt)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForCreateUser)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForCreateDt)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForRemarks)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl4)).BeginInit();
            this.groupControl4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataLayoutControl3)).BeginInit();
            this.dataLayoutControl3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.JobNoTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mESM501JobTxBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.LotNoTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit2.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.QCOperatorTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.InQtyInkSpinEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.OutQtyInkSpinEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NGQtyInkSpinEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForJobNo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForLotNo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem8)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForQCOperator)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForInQtyInk)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForOutQtyInk)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForNGQtyInk)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup9)).BeginInit();
            this.SuspendLayout();
            // 
            // panelControl1
            // 
            this.panelControl1.Size = new System.Drawing.Size(1242, 754);
            // 
            // dataLayoutControl1
            // 
            this.dataLayoutControl1.Controls.Add(this.groupControl4);
            this.dataLayoutControl1.Controls.Add(this.groupControl3);
            this.dataLayoutControl1.Controls.Add(this.ykGridControl2);
            this.dataLayoutControl1.Controls.Add(this.groupControl2);
            this.dataLayoutControl1.Controls.Add(this.groupControl1);
            this.dataLayoutControl1.OptionsCustomizationForm.DesignTimeCustomizationFormPositionAndSize = new System.Drawing.Rectangle(565, 289, 250, 350);
            this.dataLayoutControl1.Size = new System.Drawing.Size(1238, 750);
            // 
            // layoutControlGroup1
            // 
            this.layoutControlGroup1.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItem1,
            this.layoutControlItem3,
            this.layoutControlItem5,
            this.layoutControlItem6,
            this.emptySpaceItem1,
            this.layoutControlGroup9});
            this.layoutControlGroup1.Size = new System.Drawing.Size(1238, 750);
            // 
            // ykGridControl1
            // 
            this.ykGridControl1.Cursor = System.Windows.Forms.Cursors.Default;
            this.ykGridControl1.DataSource = this.mESM802PackingDtlBindingSource;
            this.ykGridControl1.EmbeddedNavigator.Buttons.Append.Visible = false;
            this.ykGridControl1.EmbeddedNavigator.Buttons.CancelEdit.Visible = false;
            this.ykGridControl1.EmbeddedNavigator.Buttons.Edit.Visible = false;
            this.ykGridControl1.EmbeddedNavigator.Buttons.EndEdit.Visible = false;
            this.ykGridControl1.EmbeddedNavigator.Buttons.Remove.Visible = false;
            this.ykGridControl1.EmbeddedNavigator.TextStringFormat = "记录:第{0}笔/共{1}笔";
            this.ykGridControl1.Location = new System.Drawing.Point(2, 215);
            this.ykGridControl1.MainView = this.gridView1;
            this.ykGridControl1.Name = "ykGridControl1";
            this.ykGridControl1.Size = new System.Drawing.Size(788, 286);
            this.ykGridControl1.TabIndex = 2;
            this.ykGridControl1.UseEmbeddedNavigator = true;
            this.ykGridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // mESM802PackingDtlBindingSource
            // 
            this.mESM802PackingDtlBindingSource.DataSource = typeof(ERP.Domain.MES_M802_Packing_Dtl);
            // 
            // gridView1
            // 
            this.gridView1.Appearance.EvenRow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(234)))), ((int)(((byte)(250)))));
            this.gridView1.Appearance.EvenRow.Options.UseBackColor = true;
            this.gridView1.Appearance.OddRow.BackColor = System.Drawing.Color.White;
            this.gridView1.Appearance.OddRow.Options.UseBackColor = true;
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colCompCode,
            this.colDocNo,
            this.colJobNo,
            this.colShipLot,
            this.colShipLotPackage,
            this.colShipLotQty,
            this.colRemarks,
            this.colModifyDt,
            this.colModifyUser,
            this.colCreateDt,
            this.colCreateUser,
            this.colId});
            this.gridView1.GridControl = this.ykGridControl1;
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
            // 
            // colDocNo
            // 
            this.colDocNo.Caption = "单据号";
            this.colDocNo.FieldName = "DocNo";
            this.colDocNo.Name = "colDocNo";
            this.colDocNo.Visible = true;
            this.colDocNo.VisibleIndex = 0;
            // 
            // colJobNo
            // 
            this.colJobNo.Caption = "生产批号";
            this.colJobNo.FieldName = "JobNo";
            this.colJobNo.Name = "colJobNo";
            this.colJobNo.Visible = true;
            this.colJobNo.VisibleIndex = 1;
            // 
            // colShipLot
            // 
            this.colShipLot.Caption = "装箱批号";
            this.colShipLot.FieldName = "ShipLot";
            this.colShipLot.Name = "colShipLot";
            this.colShipLot.Visible = true;
            this.colShipLot.VisibleIndex = 2;
            // 
            // colShipLotPackage
            // 
            this.colShipLotPackage.Caption = "包数";
            this.colShipLotPackage.FieldName = "ShipLotPackage";
            this.colShipLotPackage.Name = "colShipLotPackage";
            this.colShipLotPackage.Visible = true;
            this.colShipLotPackage.VisibleIndex = 3;
            // 
            // colShipLotQty
            // 
            this.colShipLotQty.Caption = "数量";
            this.colShipLotQty.FieldName = "ShipLotQty";
            this.colShipLotQty.Name = "colShipLotQty";
            this.colShipLotQty.Visible = true;
            this.colShipLotQty.VisibleIndex = 4;
            // 
            // colRemarks
            // 
            this.colRemarks.Caption = "备注";
            this.colRemarks.FieldName = "Remarks";
            this.colRemarks.Name = "colRemarks";
            this.colRemarks.Visible = true;
            this.colRemarks.VisibleIndex = 5;
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
            // groupControl1
            // 
            this.groupControl1.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.groupControl1.Appearance.Options.UseBackColor = true;
            this.groupControl1.Controls.Add(this.simpleButton1);
            this.groupControl1.Controls.Add(this.lbTips);
            this.groupControl1.Controls.Add(this.txtBarCode);
            this.groupControl1.Controls.Add(this.labelControl7);
            this.groupControl1.Controls.Add(this.lbJobPackage);
            this.groupControl1.Location = new System.Drawing.Point(12, 12);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(796, 195);
            this.groupControl1.TabIndex = 0;
            this.groupControl1.Text = "扫描信息 (Scan Data)";
            // 
            // simpleButton1
            // 
            this.simpleButton1.Location = new System.Drawing.Point(668, 153);
            this.simpleButton1.Name = "simpleButton1";
            this.simpleButton1.Size = new System.Drawing.Size(75, 23);
            this.simpleButton1.TabIndex = 34;
            this.simpleButton1.Text = "simpleButton1";
            this.simpleButton1.Click += new System.EventHandler(this.simpleButton1_Click);
            // 
            // lbTips
            // 
            this.lbTips.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTips.Appearance.ForeColor = System.Drawing.Color.Blue;
            this.lbTips.Location = new System.Drawing.Point(411, 36);
            this.lbTips.Name = "lbTips";
            this.lbTips.Size = new System.Drawing.Size(221, 19);
            this.lbTips.TabIndex = 31;
            this.lbTips.Text = "提示：请扫描标签条码。。。";
            // 
            // txtBarCode
            // 
            this.txtBarCode.Location = new System.Drawing.Point(18, 34);
            this.txtBarCode.Name = "txtBarCode";
            this.txtBarCode.Properties.NullText = "请扫描条码";
            this.txtBarCode.Size = new System.Drawing.Size(357, 156);
            this.txtBarCode.TabIndex = 30;
            // 
            // labelControl7
            // 
            this.labelControl7.Appearance.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl7.Appearance.ForeColor = System.Drawing.Color.Blue;
            this.labelControl7.Location = new System.Drawing.Point(564, 153);
            this.labelControl7.Name = "labelControl7";
            this.labelControl7.Size = new System.Drawing.Size(22, 25);
            this.labelControl7.TabIndex = 33;
            this.labelControl7.Text = "包";
            // 
            // lbJobPackage
            // 
            this.lbJobPackage.Appearance.Font = new System.Drawing.Font("Tahoma", 42F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbJobPackage.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.lbJobPackage.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple;
            this.lbJobPackage.Location = new System.Drawing.Point(448, 109);
            this.lbJobPackage.Name = "lbJobPackage";
            this.lbJobPackage.Size = new System.Drawing.Size(110, 70);
            this.lbJobPackage.TabIndex = 32;
            this.lbJobPackage.Text = "100";
            // 
            // layoutControlItem1
            // 
            this.layoutControlItem1.Control = this.groupControl1;
            this.layoutControlItem1.CustomizationFormText = "layoutControlItem1";
            this.layoutControlItem1.Location = new System.Drawing.Point(0, 0);
            this.layoutControlItem1.MaxSize = new System.Drawing.Size(0, 199);
            this.layoutControlItem1.MinSize = new System.Drawing.Size(104, 199);
            this.layoutControlItem1.Name = "layoutControlItem1";
            this.layoutControlItem1.Size = new System.Drawing.Size(800, 199);
            this.layoutControlItem1.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
            this.layoutControlItem1.Text = "layoutControlItem1";
            this.layoutControlItem1.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem1.TextToControlDistance = 0;
            this.layoutControlItem1.TextVisible = false;
            // 
            // groupControl2
            // 
            this.groupControl2.Controls.Add(this.dataLayoutControl2);
            this.groupControl2.Location = new System.Drawing.Point(822, 12);
            this.groupControl2.Name = "groupControl2";
            this.groupControl2.Size = new System.Drawing.Size(404, 156);
            this.groupControl2.TabIndex = 1;
            this.groupControl2.Text = "产品包装信息(Product Pack Info.)";
            // 
            // dataLayoutControl2
            // 
            this.dataLayoutControl2.Controls.Add(this.CustCodeTextEdit);
            this.dataLayoutControl2.Controls.Add(this.CustPartNoTextEdit);
            this.dataLayoutControl2.Controls.Add(this.CustPartNameTextEdit);
            this.dataLayoutControl2.Controls.Add(this.CustPartTypeTextEdit);
            this.dataLayoutControl2.Controls.Add(this.CustPartSpecTextEdit);
            this.dataLayoutControl2.Controls.Add(this.PackPianZhiSpinEdit);
            this.dataLayoutControl2.Controls.Add(this.PackBaoPianSpinEdit);
            this.dataLayoutControl2.Controls.Add(this.PackHeBaoSpinEdit);
            this.dataLayoutControl2.Controls.Add(this.PackXiangHeSpinEdit);
            this.dataLayoutControl2.DataSource = this.eRPM001ProductPackInfoBindingSource;
            this.dataLayoutControl2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataLayoutControl2.Location = new System.Drawing.Point(2, 22);
            this.dataLayoutControl2.Name = "dataLayoutControl2";
            this.dataLayoutControl2.OptionsCustomizationForm.DesignTimeCustomizationFormPositionAndSize = new System.Drawing.Rectangle(927, 304, 250, 350);
            this.dataLayoutControl2.OptionsView.IsReadOnly = DevExpress.Utils.DefaultBoolean.True;
            this.dataLayoutControl2.Root = this.layoutControlGroup2;
            this.dataLayoutControl2.Size = new System.Drawing.Size(400, 132);
            this.dataLayoutControl2.TabIndex = 0;
            this.dataLayoutControl2.Text = "dataLayoutControl2";
            // 
            // CustCodeTextEdit
            // 
            this.CustCodeTextEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.eRPM001ProductPackInfoBindingSource, "CustCode", true));
            this.CustCodeTextEdit.Location = new System.Drawing.Point(53, 2);
            this.CustCodeTextEdit.Name = "CustCodeTextEdit";
            this.CustCodeTextEdit.Properties.ReadOnly = true;
            this.CustCodeTextEdit.Size = new System.Drawing.Size(144, 20);
            this.CustCodeTextEdit.StyleController = this.dataLayoutControl2;
            this.CustCodeTextEdit.TabIndex = 7;
            // 
            // eRPM001ProductPackInfoBindingSource
            // 
            this.eRPM001ProductPackInfoBindingSource.DataSource = typeof(ERP.Domain.ERP_M001_Product_PackInfo);
            // 
            // CustPartNoTextEdit
            // 
            this.CustPartNoTextEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.eRPM001ProductPackInfoBindingSource, "PartNo", true));
            this.CustPartNoTextEdit.Location = new System.Drawing.Point(252, 2);
            this.CustPartNoTextEdit.Name = "CustPartNoTextEdit";
            this.CustPartNoTextEdit.Properties.ReadOnly = true;
            this.CustPartNoTextEdit.Size = new System.Drawing.Size(146, 20);
            this.CustPartNoTextEdit.StyleController = this.dataLayoutControl2;
            this.CustPartNoTextEdit.TabIndex = 8;
            // 
            // CustPartNameTextEdit
            // 
            this.CustPartNameTextEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.eRPM001ProductPackInfoBindingSource, "PartName", true));
            this.CustPartNameTextEdit.Location = new System.Drawing.Point(53, 26);
            this.CustPartNameTextEdit.Name = "CustPartNameTextEdit";
            this.CustPartNameTextEdit.Properties.ReadOnly = true;
            this.CustPartNameTextEdit.Size = new System.Drawing.Size(144, 20);
            this.CustPartNameTextEdit.StyleController = this.dataLayoutControl2;
            this.CustPartNameTextEdit.TabIndex = 9;
            // 
            // CustPartTypeTextEdit
            // 
            this.CustPartTypeTextEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.eRPM001ProductPackInfoBindingSource, "PartType", true));
            this.CustPartTypeTextEdit.Location = new System.Drawing.Point(252, 26);
            this.CustPartTypeTextEdit.Name = "CustPartTypeTextEdit";
            this.CustPartTypeTextEdit.Properties.ReadOnly = true;
            this.CustPartTypeTextEdit.Size = new System.Drawing.Size(146, 20);
            this.CustPartTypeTextEdit.StyleController = this.dataLayoutControl2;
            this.CustPartTypeTextEdit.TabIndex = 10;
            // 
            // CustPartSpecTextEdit
            // 
            this.CustPartSpecTextEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.eRPM001ProductPackInfoBindingSource, "PartSpec", true));
            this.CustPartSpecTextEdit.Location = new System.Drawing.Point(53, 50);
            this.CustPartSpecTextEdit.Name = "CustPartSpecTextEdit";
            this.CustPartSpecTextEdit.Properties.ReadOnly = true;
            this.CustPartSpecTextEdit.Size = new System.Drawing.Size(345, 20);
            this.CustPartSpecTextEdit.StyleController = this.dataLayoutControl2;
            this.CustPartSpecTextEdit.TabIndex = 11;
            // 
            // PackPianZhiSpinEdit
            // 
            this.PackPianZhiSpinEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.eRPM001ProductPackInfoBindingSource, "PackPianZhi", true));
            this.PackPianZhiSpinEdit.EditValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.PackPianZhiSpinEdit.Location = new System.Drawing.Point(53, 74);
            this.PackPianZhiSpinEdit.Name = "PackPianZhiSpinEdit";
            this.PackPianZhiSpinEdit.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.PackPianZhiSpinEdit.Properties.ReadOnly = true;
            this.PackPianZhiSpinEdit.Size = new System.Drawing.Size(144, 20);
            this.PackPianZhiSpinEdit.StyleController = this.dataLayoutControl2;
            this.PackPianZhiSpinEdit.TabIndex = 13;
            // 
            // PackBaoPianSpinEdit
            // 
            this.PackBaoPianSpinEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.eRPM001ProductPackInfoBindingSource, "PackBaoPian", true));
            this.PackBaoPianSpinEdit.EditValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.PackBaoPianSpinEdit.Location = new System.Drawing.Point(252, 74);
            this.PackBaoPianSpinEdit.Name = "PackBaoPianSpinEdit";
            this.PackBaoPianSpinEdit.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.PackBaoPianSpinEdit.Properties.ReadOnly = true;
            this.PackBaoPianSpinEdit.Size = new System.Drawing.Size(146, 20);
            this.PackBaoPianSpinEdit.StyleController = this.dataLayoutControl2;
            this.PackBaoPianSpinEdit.TabIndex = 14;
            // 
            // PackHeBaoSpinEdit
            // 
            this.PackHeBaoSpinEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.eRPM001ProductPackInfoBindingSource, "PackHeBao", true));
            this.PackHeBaoSpinEdit.EditValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.PackHeBaoSpinEdit.Location = new System.Drawing.Point(53, 98);
            this.PackHeBaoSpinEdit.Name = "PackHeBaoSpinEdit";
            this.PackHeBaoSpinEdit.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.PackHeBaoSpinEdit.Properties.ReadOnly = true;
            this.PackHeBaoSpinEdit.Size = new System.Drawing.Size(144, 20);
            this.PackHeBaoSpinEdit.StyleController = this.dataLayoutControl2;
            this.PackHeBaoSpinEdit.TabIndex = 15;
            // 
            // PackXiangHeSpinEdit
            // 
            this.PackXiangHeSpinEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.eRPM001ProductPackInfoBindingSource, "PackXiangHe", true));
            this.PackXiangHeSpinEdit.EditValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.PackXiangHeSpinEdit.Location = new System.Drawing.Point(252, 98);
            this.PackXiangHeSpinEdit.Name = "PackXiangHeSpinEdit";
            this.PackXiangHeSpinEdit.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.PackXiangHeSpinEdit.Properties.ReadOnly = true;
            this.PackXiangHeSpinEdit.Size = new System.Drawing.Size(146, 20);
            this.PackXiangHeSpinEdit.StyleController = this.dataLayoutControl2;
            this.PackXiangHeSpinEdit.TabIndex = 16;
            // 
            // layoutControlGroup2
            // 
            this.layoutControlGroup2.CustomizationFormText = "layoutControlGroup2";
            this.layoutControlGroup2.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.layoutControlGroup2.GroupBordersVisible = false;
            this.layoutControlGroup2.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlGroup3});
            this.layoutControlGroup2.Location = new System.Drawing.Point(0, 0);
            this.layoutControlGroup2.Name = "layoutControlGroup2";
            this.layoutControlGroup2.Padding = new DevExpress.XtraLayout.Utils.Padding(0, 0, 0, 0);
            this.layoutControlGroup2.Size = new System.Drawing.Size(400, 132);
            this.layoutControlGroup2.Text = "layoutControlGroup2";
            this.layoutControlGroup2.TextVisible = false;
            // 
            // layoutControlGroup3
            // 
            this.layoutControlGroup3.AllowDrawBackground = false;
            this.layoutControlGroup3.CustomizationFormText = "autoGeneratedGroup0";
            this.layoutControlGroup3.GroupBordersVisible = false;
            this.layoutControlGroup3.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.ItemForCustPartNo,
            this.ItemForCustPartType,
            this.ItemForCustPartSpec,
            this.ItemForPackBaoPian,
            this.ItemForPackXiangHe,
            this.ItemForCustCode,
            this.ItemForCustPartName,
            this.ItemForPackPianZhi,
            this.ItemForPackHeBao});
            this.layoutControlGroup3.Location = new System.Drawing.Point(0, 0);
            this.layoutControlGroup3.Name = "autoGeneratedGroup0";
            this.layoutControlGroup3.Size = new System.Drawing.Size(400, 132);
            this.layoutControlGroup3.Text = "autoGeneratedGroup0";
            // 
            // ItemForCustPartNo
            // 
            this.ItemForCustPartNo.Control = this.CustPartNoTextEdit;
            this.ItemForCustPartNo.CustomizationFormText = "产品编号";
            this.ItemForCustPartNo.Location = new System.Drawing.Point(199, 0);
            this.ItemForCustPartNo.Name = "ItemForCustPartNo";
            this.ItemForCustPartNo.Size = new System.Drawing.Size(201, 24);
            this.ItemForCustPartNo.Text = "产品编号";
            this.ItemForCustPartNo.TextSize = new System.Drawing.Size(48, 14);
            // 
            // ItemForCustPartType
            // 
            this.ItemForCustPartType.Control = this.CustPartTypeTextEdit;
            this.ItemForCustPartType.CustomizationFormText = "产品型号";
            this.ItemForCustPartType.Location = new System.Drawing.Point(199, 24);
            this.ItemForCustPartType.Name = "ItemForCustPartType";
            this.ItemForCustPartType.Size = new System.Drawing.Size(201, 24);
            this.ItemForCustPartType.Text = "产品型号";
            this.ItemForCustPartType.TextSize = new System.Drawing.Size(48, 14);
            // 
            // ItemForCustPartSpec
            // 
            this.ItemForCustPartSpec.Control = this.CustPartSpecTextEdit;
            this.ItemForCustPartSpec.CustomizationFormText = "产品规格";
            this.ItemForCustPartSpec.Location = new System.Drawing.Point(0, 48);
            this.ItemForCustPartSpec.Name = "ItemForCustPartSpec";
            this.ItemForCustPartSpec.Size = new System.Drawing.Size(400, 24);
            this.ItemForCustPartSpec.Text = "产品规格";
            this.ItemForCustPartSpec.TextSize = new System.Drawing.Size(48, 14);
            // 
            // ItemForPackBaoPian
            // 
            this.ItemForPackBaoPian.Control = this.PackBaoPianSpinEdit;
            this.ItemForPackBaoPian.CustomizationFormText = "片/包";
            this.ItemForPackBaoPian.Location = new System.Drawing.Point(199, 72);
            this.ItemForPackBaoPian.Name = "ItemForPackBaoPian";
            this.ItemForPackBaoPian.Size = new System.Drawing.Size(201, 24);
            this.ItemForPackBaoPian.Text = "片/包";
            this.ItemForPackBaoPian.TextSize = new System.Drawing.Size(48, 14);
            // 
            // ItemForPackXiangHe
            // 
            this.ItemForPackXiangHe.Control = this.PackXiangHeSpinEdit;
            this.ItemForPackXiangHe.CustomizationFormText = "盒/箱";
            this.ItemForPackXiangHe.Location = new System.Drawing.Point(199, 96);
            this.ItemForPackXiangHe.Name = "ItemForPackXiangHe";
            this.ItemForPackXiangHe.Size = new System.Drawing.Size(201, 36);
            this.ItemForPackXiangHe.Text = "盒/箱";
            this.ItemForPackXiangHe.TextSize = new System.Drawing.Size(48, 14);
            // 
            // ItemForCustCode
            // 
            this.ItemForCustCode.Control = this.CustCodeTextEdit;
            this.ItemForCustCode.CustomizationFormText = "客户";
            this.ItemForCustCode.Location = new System.Drawing.Point(0, 0);
            this.ItemForCustCode.Name = "ItemForCustCode";
            this.ItemForCustCode.Size = new System.Drawing.Size(199, 24);
            this.ItemForCustCode.Text = "客户";
            this.ItemForCustCode.TextSize = new System.Drawing.Size(48, 14);
            // 
            // ItemForCustPartName
            // 
            this.ItemForCustPartName.Control = this.CustPartNameTextEdit;
            this.ItemForCustPartName.CustomizationFormText = "产品名称";
            this.ItemForCustPartName.Location = new System.Drawing.Point(0, 24);
            this.ItemForCustPartName.Name = "ItemForCustPartName";
            this.ItemForCustPartName.Size = new System.Drawing.Size(199, 24);
            this.ItemForCustPartName.Text = "产品名称";
            this.ItemForCustPartName.TextSize = new System.Drawing.Size(48, 14);
            // 
            // ItemForPackPianZhi
            // 
            this.ItemForPackPianZhi.Control = this.PackPianZhiSpinEdit;
            this.ItemForPackPianZhi.CustomizationFormText = "只/片";
            this.ItemForPackPianZhi.Location = new System.Drawing.Point(0, 72);
            this.ItemForPackPianZhi.Name = "ItemForPackPianZhi";
            this.ItemForPackPianZhi.Size = new System.Drawing.Size(199, 24);
            this.ItemForPackPianZhi.Text = "只/片";
            this.ItemForPackPianZhi.TextSize = new System.Drawing.Size(48, 14);
            // 
            // ItemForPackHeBao
            // 
            this.ItemForPackHeBao.Control = this.PackHeBaoSpinEdit;
            this.ItemForPackHeBao.CustomizationFormText = "包/盒";
            this.ItemForPackHeBao.Location = new System.Drawing.Point(0, 96);
            this.ItemForPackHeBao.Name = "ItemForPackHeBao";
            this.ItemForPackHeBao.Size = new System.Drawing.Size(199, 36);
            this.ItemForPackHeBao.Text = "包/盒";
            this.ItemForPackHeBao.TextSize = new System.Drawing.Size(48, 14);
            // 
            // layoutControlItem3
            // 
            this.layoutControlItem3.Control = this.groupControl2;
            this.layoutControlItem3.CustomizationFormText = "layoutControlItem3";
            this.layoutControlItem3.Location = new System.Drawing.Point(810, 0);
            this.layoutControlItem3.MaxSize = new System.Drawing.Size(0, 160);
            this.layoutControlItem3.MinSize = new System.Drawing.Size(104, 160);
            this.layoutControlItem3.Name = "layoutControlItem3";
            this.layoutControlItem3.Size = new System.Drawing.Size(408, 160);
            this.layoutControlItem3.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
            this.layoutControlItem3.Text = "layoutControlItem3";
            this.layoutControlItem3.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem3.TextToControlDistance = 0;
            this.layoutControlItem3.TextVisible = false;
            // 
            // ykGridControl2
            // 
            this.ykGridControl2.Cursor = System.Windows.Forms.Cursors.Default;
            this.ykGridControl2.DataSource = this.mESM801LabelSBindingSource;
            this.ykGridControl2.EmbeddedNavigator.Buttons.Append.Visible = false;
            this.ykGridControl2.EmbeddedNavigator.Buttons.CancelEdit.Visible = false;
            this.ykGridControl2.EmbeddedNavigator.Buttons.Edit.Visible = false;
            this.ykGridControl2.EmbeddedNavigator.Buttons.EndEdit.Visible = false;
            this.ykGridControl2.EmbeddedNavigator.Buttons.Remove.Visible = false;
            this.ykGridControl2.EmbeddedNavigator.TextStringFormat = "记录:第{0}笔/共{1}笔";
            this.ykGridControl2.Location = new System.Drawing.Point(825, 424);
            this.ykGridControl2.MainView = this.gridView2;
            this.ykGridControl2.Name = "ykGridControl2";
            this.ykGridControl2.Size = new System.Drawing.Size(398, 311);
            this.ykGridControl2.TabIndex = 3;
            this.ykGridControl2.UseEmbeddedNavigator = true;
            this.ykGridControl2.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView2});
            // 
            // mESM801LabelSBindingSource
            // 
            this.mESM801LabelSBindingSource.DataSource = typeof(ERP.Domain.MES_M801_Label_S);
            // 
            // gridView2
            // 
            this.gridView2.Appearance.EvenRow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(234)))), ((int)(((byte)(250)))));
            this.gridView2.Appearance.EvenRow.Options.UseBackColor = true;
            this.gridView2.Appearance.OddRow.BackColor = System.Drawing.Color.White;
            this.gridView2.Appearance.OddRow.Options.UseBackColor = true;
            this.gridView2.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colCompCode1,
            this.colLotNo,
            this.colMLotNo,
            this.colPackSeqNo,
            this.colPartNo,
            this.colPartName,
            this.colPartType,
            this.colPartSpec,
            this.colCustCode,
            this.colCustPartNo,
            this.colCustPartName,
            this.colCustPartType,
            this.colCustPartSpec,
            this.colCustDrawingNo,
            this.colCustPONo,
            this.colCustLotNo,
            this.colProdDt,
            this.colExpiredDt,
            this.colMatCode,
            this.colMatType,
            this.colQty,
            this.colCode2D,
            this.colUnit,
            this.colIsPack,
            this.colLBPartNo,
            this.colLBPartName,
            this.colPQty,
            this.colLBSpec1,
            this.colLBSpec2,
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
            this.gridView2.SortInfo.AddRange(new DevExpress.XtraGrid.Columns.GridColumnSortInfo[] {
            new DevExpress.XtraGrid.Columns.GridColumnSortInfo(this.colCustCode, DevExpress.Data.ColumnSortOrder.Ascending)});
            // 
            // colCompCode1
            // 
            this.colCompCode1.FieldName = "CompCode";
            this.colCompCode1.Name = "colCompCode1";
            // 
            // colLotNo
            // 
            this.colLotNo.Caption = "生产批号";
            this.colLotNo.FieldName = "LotNo";
            this.colLotNo.Name = "colLotNo";
            this.colLotNo.Visible = true;
            this.colLotNo.VisibleIndex = 1;
            // 
            // colMLotNo
            // 
            this.colMLotNo.Caption = "主批号";
            this.colMLotNo.FieldName = "MLotNo";
            this.colMLotNo.Name = "colMLotNo";
            this.colMLotNo.Visible = true;
            this.colMLotNo.VisibleIndex = 0;
            // 
            // colPackSeqNo
            // 
            this.colPackSeqNo.FieldName = "PackSeqNo";
            this.colPackSeqNo.Name = "colPackSeqNo";
            // 
            // colPartNo
            // 
            this.colPartNo.Caption = "产品编号";
            this.colPartNo.FieldName = "PartNo";
            this.colPartNo.Name = "colPartNo";
            this.colPartNo.Visible = true;
            this.colPartNo.VisibleIndex = 2;
            // 
            // colPartName
            // 
            this.colPartName.Caption = "产品名称";
            this.colPartName.FieldName = "PartName";
            this.colPartName.Name = "colPartName";
            this.colPartName.Visible = true;
            this.colPartName.VisibleIndex = 3;
            // 
            // colPartType
            // 
            this.colPartType.Caption = "产品型号";
            this.colPartType.FieldName = "PartType";
            this.colPartType.Name = "colPartType";
            this.colPartType.Visible = true;
            this.colPartType.VisibleIndex = 4;
            // 
            // colPartSpec
            // 
            this.colPartSpec.Caption = "产品规格";
            this.colPartSpec.FieldName = "PartSpec";
            this.colPartSpec.Name = "colPartSpec";
            this.colPartSpec.Visible = true;
            this.colPartSpec.VisibleIndex = 5;
            // 
            // colCustCode
            // 
            this.colCustCode.Caption = "客户";
            this.colCustCode.FieldName = "CustCode";
            this.colCustCode.Name = "colCustCode";
            this.colCustCode.Visible = true;
            this.colCustCode.VisibleIndex = 6;
            // 
            // colCustPartNo
            // 
            this.colCustPartNo.FieldName = "CustPartNo";
            this.colCustPartNo.Name = "colCustPartNo";
            // 
            // colCustPartName
            // 
            this.colCustPartName.FieldName = "CustPartName";
            this.colCustPartName.Name = "colCustPartName";
            // 
            // colCustPartType
            // 
            this.colCustPartType.FieldName = "CustPartType";
            this.colCustPartType.Name = "colCustPartType";
            // 
            // colCustPartSpec
            // 
            this.colCustPartSpec.FieldName = "CustPartSpec";
            this.colCustPartSpec.Name = "colCustPartSpec";
            // 
            // colCustDrawingNo
            // 
            this.colCustDrawingNo.FieldName = "CustDrawingNo";
            this.colCustDrawingNo.Name = "colCustDrawingNo";
            // 
            // colCustPONo
            // 
            this.colCustPONo.FieldName = "CustPONo";
            this.colCustPONo.Name = "colCustPONo";
            // 
            // colCustLotNo
            // 
            this.colCustLotNo.FieldName = "CustLotNo";
            this.colCustLotNo.Name = "colCustLotNo";
            // 
            // colProdDt
            // 
            this.colProdDt.Caption = "生产日期";
            this.colProdDt.FieldName = "ProdDt";
            this.colProdDt.Name = "colProdDt";
            this.colProdDt.Visible = true;
            this.colProdDt.VisibleIndex = 7;
            // 
            // colExpiredDt
            // 
            this.colExpiredDt.FieldName = "ExpiredDt";
            this.colExpiredDt.Name = "colExpiredDt";
            // 
            // colMatCode
            // 
            this.colMatCode.FieldName = "MatCode";
            this.colMatCode.Name = "colMatCode";
            // 
            // colMatType
            // 
            this.colMatType.FieldName = "MatType";
            this.colMatType.Name = "colMatType";
            // 
            // colQty
            // 
            this.colQty.Caption = "数量";
            this.colQty.FieldName = "Qty";
            this.colQty.Name = "colQty";
            this.colQty.Visible = true;
            this.colQty.VisibleIndex = 8;
            // 
            // colCode2D
            // 
            this.colCode2D.Caption = "二维码";
            this.colCode2D.FieldName = "Code2D";
            this.colCode2D.Name = "colCode2D";
            this.colCode2D.Visible = true;
            this.colCode2D.VisibleIndex = 9;
            // 
            // colUnit
            // 
            this.colUnit.FieldName = "Unit";
            this.colUnit.Name = "colUnit";
            // 
            // colIsPack
            // 
            this.colIsPack.Caption = "是否扫描";
            this.colIsPack.FieldName = "IsPack";
            this.colIsPack.Name = "colIsPack";
            this.colIsPack.Visible = true;
            this.colIsPack.VisibleIndex = 10;
            // 
            // colLBPartNo
            // 
            this.colLBPartNo.FieldName = "LBPartNo";
            this.colLBPartNo.Name = "colLBPartNo";
            // 
            // colLBPartName
            // 
            this.colLBPartName.FieldName = "LBPartName";
            this.colLBPartName.Name = "colLBPartName";
            // 
            // colPQty
            // 
            this.colPQty.FieldName = "PQty";
            this.colPQty.Name = "colPQty";
            // 
            // colLBSpec1
            // 
            this.colLBSpec1.FieldName = "LBSpec1";
            this.colLBSpec1.Name = "colLBSpec1";
            // 
            // colLBSpec2
            // 
            this.colLBSpec2.FieldName = "LBSpec2";
            this.colLBSpec2.Name = "colLBSpec2";
            // 
            // colId1
            // 
            this.colId1.FieldName = "Id";
            this.colId1.Name = "colId1";
            // 
            // layoutControlItem4
            // 
            this.layoutControlItem4.Control = this.ykGridControl2;
            this.layoutControlItem4.CustomizationFormText = "layoutControlItem4";
            this.layoutControlItem4.Location = new System.Drawing.Point(0, 0);
            this.layoutControlItem4.Name = "layoutControlItem4";
            this.layoutControlItem4.Size = new System.Drawing.Size(402, 315);
            this.layoutControlItem4.Text = "layoutControlItem4";
            this.layoutControlItem4.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem4.TextToControlDistance = 0;
            this.layoutControlItem4.TextVisible = false;
            // 
            // groupControl3
            // 
            this.groupControl3.Controls.Add(this.dataLayoutControl4);
            this.groupControl3.Location = new System.Drawing.Point(12, 211);
            this.groupControl3.Name = "groupControl3";
            this.groupControl3.Size = new System.Drawing.Size(796, 527);
            this.groupControl3.TabIndex = 5;
            this.groupControl3.Text = "包装及包装明细 (Packing Head & Packing Detail)";
            // 
            // dataLayoutControl4
            // 
            this.dataLayoutControl4.Controls.Add(this.DocNoTextEdit);
            this.dataLayoutControl4.Controls.Add(this.ProdDtDateEdit);
            this.dataLayoutControl4.Controls.Add(this.QtySpinEdit);
            this.dataLayoutControl4.Controls.Add(this.PackageSpinEdit);
            this.dataLayoutControl4.Controls.Add(this.ykGridControl1);
            this.dataLayoutControl4.Controls.Add(this.textEdit3);
            this.dataLayoutControl4.Controls.Add(this.txtJobNo);
            this.dataLayoutControl4.Controls.Add(this.PartNoTextEdit);
            this.dataLayoutControl4.Controls.Add(this.PartTypeTextEdit);
            this.dataLayoutControl4.Controls.Add(this.SubShipLot1stTextEdit);
            this.dataLayoutControl4.Controls.Add(this.LotNoListTextEdit);
            this.dataLayoutControl4.Controls.Add(this.LotNoPackListTextEdit);
            this.dataLayoutControl4.Controls.Add(this.LotNoPackQtyListTextEdit);
            this.dataLayoutControl4.Controls.Add(this.CreateDtDateEdit);
            this.dataLayoutControl4.Controls.Add(this.CreateUserTextEdit);
            this.dataLayoutControl4.Controls.Add(this.ModifyDtDateEdit);
            this.dataLayoutControl4.Controls.Add(this.ModifyUserTextEdit);
            this.dataLayoutControl4.Controls.Add(this.RemarksTextEdit);
            this.dataLayoutControl4.DataSource = this.mESM802PackingHdBindingSource;
            this.dataLayoutControl4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataLayoutControl4.Location = new System.Drawing.Point(2, 22);
            this.dataLayoutControl4.Name = "dataLayoutControl4";
            this.dataLayoutControl4.Root = this.layoutControlGroup6;
            this.dataLayoutControl4.Size = new System.Drawing.Size(792, 503);
            this.dataLayoutControl4.TabIndex = 0;
            this.dataLayoutControl4.Text = "dataLayoutControl4";
            // 
            // DocNoTextEdit
            // 
            this.DocNoTextEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.mESM802PackingHdBindingSource, "DocNo", true));
            this.DocNoTextEdit.Location = new System.Drawing.Point(53, 2);
            this.DocNoTextEdit.Name = "DocNoTextEdit";
            this.DocNoTextEdit.Properties.ReadOnly = true;
            this.DocNoTextEdit.Size = new System.Drawing.Size(189, 20);
            this.DocNoTextEdit.StyleController = this.dataLayoutControl4;
            this.DocNoTextEdit.TabIndex = 4;
            // 
            // mESM802PackingHdBindingSource
            // 
            this.mESM802PackingHdBindingSource.DataSource = typeof(ERP.Domain.MES_M802_Packing_Hd);
            // 
            // ProdDtDateEdit
            // 
            this.ProdDtDateEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.mESM802PackingHdBindingSource, "ProdDt", true));
            this.ProdDtDateEdit.EditValue = null;
            this.ProdDtDateEdit.Location = new System.Drawing.Point(654, 2);
            this.ProdDtDateEdit.Name = "ProdDtDateEdit";
            this.ProdDtDateEdit.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.ProdDtDateEdit.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.ProdDtDateEdit.Properties.ReadOnly = true;
            this.ProdDtDateEdit.Size = new System.Drawing.Size(136, 20);
            this.ProdDtDateEdit.StyleController = this.dataLayoutControl4;
            this.ProdDtDateEdit.TabIndex = 5;
            // 
            // QtySpinEdit
            // 
            this.QtySpinEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.mESM802PackingHdBindingSource, "Qty", true));
            this.QtySpinEdit.EditValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.QtySpinEdit.Location = new System.Drawing.Point(480, 2);
            this.QtySpinEdit.Name = "QtySpinEdit";
            this.QtySpinEdit.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.QtySpinEdit.Properties.ReadOnly = true;
            this.QtySpinEdit.Size = new System.Drawing.Size(119, 20);
            this.QtySpinEdit.StyleController = this.dataLayoutControl4;
            this.QtySpinEdit.TabIndex = 6;
            // 
            // PackageSpinEdit
            // 
            this.PackageSpinEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.mESM802PackingHdBindingSource, "Package", true));
            this.PackageSpinEdit.EditValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.PackageSpinEdit.Location = new System.Drawing.Point(297, 2);
            this.PackageSpinEdit.Name = "PackageSpinEdit";
            this.PackageSpinEdit.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.PackageSpinEdit.Properties.ReadOnly = true;
            this.PackageSpinEdit.Size = new System.Drawing.Size(128, 20);
            this.PackageSpinEdit.StyleController = this.dataLayoutControl4;
            this.PackageSpinEdit.TabIndex = 7;
            // 
            // textEdit3
            // 
            this.textEdit3.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.mESM802PackingHdBindingSource, "CustCode", true));
            this.textEdit3.Location = new System.Drawing.Point(53, 26);
            this.textEdit3.Name = "textEdit3";
            this.textEdit3.Properties.ReadOnly = true;
            this.textEdit3.Size = new System.Drawing.Size(189, 20);
            this.textEdit3.StyleController = this.dataLayoutControl4;
            this.textEdit3.TabIndex = 8;
            // 
            // txtJobNo
            // 
            this.txtJobNo.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.mESM802PackingHdBindingSource, "JobNo", true));
            this.txtJobNo.Location = new System.Drawing.Point(654, 26);
            this.txtJobNo.Name = "txtJobNo";
            this.txtJobNo.Properties.ReadOnly = true;
            this.txtJobNo.Size = new System.Drawing.Size(136, 20);
            this.txtJobNo.StyleController = this.dataLayoutControl4;
            this.txtJobNo.TabIndex = 9;
            // 
            // PartNoTextEdit
            // 
            this.PartNoTextEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.mESM802PackingHdBindingSource, "PartNo", true));
            this.PartNoTextEdit.Location = new System.Drawing.Point(480, 26);
            this.PartNoTextEdit.Name = "PartNoTextEdit";
            this.PartNoTextEdit.Properties.ReadOnly = true;
            this.PartNoTextEdit.Size = new System.Drawing.Size(119, 20);
            this.PartNoTextEdit.StyleController = this.dataLayoutControl4;
            this.PartNoTextEdit.TabIndex = 10;
            // 
            // PartTypeTextEdit
            // 
            this.PartTypeTextEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.mESM802PackingHdBindingSource, "PartType", true));
            this.PartTypeTextEdit.Location = new System.Drawing.Point(297, 26);
            this.PartTypeTextEdit.Name = "PartTypeTextEdit";
            this.PartTypeTextEdit.Properties.ReadOnly = true;
            this.PartTypeTextEdit.Size = new System.Drawing.Size(128, 20);
            this.PartTypeTextEdit.StyleController = this.dataLayoutControl4;
            this.PartTypeTextEdit.TabIndex = 11;
            // 
            // SubShipLot1stTextEdit
            // 
            this.SubShipLot1stTextEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.mESM802PackingHdBindingSource, "SubShipLot1st", true));
            this.SubShipLot1stTextEdit.Location = new System.Drawing.Point(53, 50);
            this.SubShipLot1stTextEdit.Name = "SubShipLot1stTextEdit";
            this.SubShipLot1stTextEdit.Properties.ReadOnly = true;
            this.SubShipLot1stTextEdit.Size = new System.Drawing.Size(737, 20);
            this.SubShipLot1stTextEdit.StyleController = this.dataLayoutControl4;
            this.SubShipLot1stTextEdit.TabIndex = 12;
            // 
            // LotNoListTextEdit
            // 
            this.LotNoListTextEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.mESM802PackingHdBindingSource, "LotNoList", true));
            this.LotNoListTextEdit.Location = new System.Drawing.Point(53, 74);
            this.LotNoListTextEdit.Name = "LotNoListTextEdit";
            this.LotNoListTextEdit.Properties.ReadOnly = true;
            this.LotNoListTextEdit.Size = new System.Drawing.Size(737, 20);
            this.LotNoListTextEdit.StyleController = this.dataLayoutControl4;
            this.LotNoListTextEdit.TabIndex = 14;
            // 
            // LotNoPackListTextEdit
            // 
            this.LotNoPackListTextEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.mESM802PackingHdBindingSource, "LotNoPackList", true));
            this.LotNoPackListTextEdit.Location = new System.Drawing.Point(53, 98);
            this.LotNoPackListTextEdit.Name = "LotNoPackListTextEdit";
            this.LotNoPackListTextEdit.Properties.ReadOnly = true;
            this.LotNoPackListTextEdit.Size = new System.Drawing.Size(737, 20);
            this.LotNoPackListTextEdit.StyleController = this.dataLayoutControl4;
            this.LotNoPackListTextEdit.TabIndex = 15;
            // 
            // LotNoPackQtyListTextEdit
            // 
            this.LotNoPackQtyListTextEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.mESM802PackingHdBindingSource, "LotNoPackQtyList", true));
            this.LotNoPackQtyListTextEdit.Location = new System.Drawing.Point(53, 122);
            this.LotNoPackQtyListTextEdit.Name = "LotNoPackQtyListTextEdit";
            this.LotNoPackQtyListTextEdit.Properties.ReadOnly = true;
            this.LotNoPackQtyListTextEdit.Size = new System.Drawing.Size(737, 20);
            this.LotNoPackQtyListTextEdit.StyleController = this.dataLayoutControl4;
            this.LotNoPackQtyListTextEdit.TabIndex = 16;
            // 
            // CreateDtDateEdit
            // 
            this.CreateDtDateEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.mESM802PackingHdBindingSource, "CreateDt", true));
            this.CreateDtDateEdit.EditValue = null;
            this.CreateDtDateEdit.Location = new System.Drawing.Point(53, 191);
            this.CreateDtDateEdit.Name = "CreateDtDateEdit";
            this.CreateDtDateEdit.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.CreateDtDateEdit.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.CreateDtDateEdit.Properties.ReadOnly = true;
            this.CreateDtDateEdit.Size = new System.Drawing.Size(123, 20);
            this.CreateDtDateEdit.StyleController = this.dataLayoutControl4;
            this.CreateDtDateEdit.TabIndex = 17;
            // 
            // CreateUserTextEdit
            // 
            this.CreateUserTextEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.mESM802PackingHdBindingSource, "CreateUser", true));
            this.CreateUserTextEdit.Location = new System.Drawing.Point(231, 191);
            this.CreateUserTextEdit.Name = "CreateUserTextEdit";
            this.CreateUserTextEdit.Properties.ReadOnly = true;
            this.CreateUserTextEdit.Size = new System.Drawing.Size(123, 20);
            this.CreateUserTextEdit.StyleController = this.dataLayoutControl4;
            this.CreateUserTextEdit.TabIndex = 18;
            // 
            // ModifyDtDateEdit
            // 
            this.ModifyDtDateEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.mESM802PackingHdBindingSource, "ModifyDt", true));
            this.ModifyDtDateEdit.EditValue = null;
            this.ModifyDtDateEdit.Location = new System.Drawing.Point(409, 191);
            this.ModifyDtDateEdit.Name = "ModifyDtDateEdit";
            this.ModifyDtDateEdit.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.ModifyDtDateEdit.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.ModifyDtDateEdit.Properties.ReadOnly = true;
            this.ModifyDtDateEdit.Size = new System.Drawing.Size(124, 20);
            this.ModifyDtDateEdit.StyleController = this.dataLayoutControl4;
            this.ModifyDtDateEdit.TabIndex = 19;
            // 
            // ModifyUserTextEdit
            // 
            this.ModifyUserTextEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.mESM802PackingHdBindingSource, "ModifyUser", true));
            this.ModifyUserTextEdit.Location = new System.Drawing.Point(588, 191);
            this.ModifyUserTextEdit.Name = "ModifyUserTextEdit";
            this.ModifyUserTextEdit.Properties.ReadOnly = true;
            this.ModifyUserTextEdit.Size = new System.Drawing.Size(202, 20);
            this.ModifyUserTextEdit.StyleController = this.dataLayoutControl4;
            this.ModifyUserTextEdit.TabIndex = 20;
            // 
            // RemarksTextEdit
            // 
            this.RemarksTextEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.mESM802PackingHdBindingSource, "Remarks", true));
            this.RemarksTextEdit.Location = new System.Drawing.Point(53, 146);
            this.RemarksTextEdit.Name = "RemarksTextEdit";
            this.RemarksTextEdit.Size = new System.Drawing.Size(737, 41);
            this.RemarksTextEdit.StyleController = this.dataLayoutControl4;
            this.RemarksTextEdit.TabIndex = 13;
            // 
            // layoutControlGroup6
            // 
            this.layoutControlGroup6.CustomizationFormText = "layoutControlGroup6";
            this.layoutControlGroup6.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.layoutControlGroup6.GroupBordersVisible = false;
            this.layoutControlGroup6.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlGroup7,
            this.layoutControlGroup8});
            this.layoutControlGroup6.Location = new System.Drawing.Point(0, 0);
            this.layoutControlGroup6.Name = "layoutControlGroup6";
            this.layoutControlGroup6.Padding = new DevExpress.XtraLayout.Utils.Padding(0, 0, 0, 0);
            this.layoutControlGroup6.Size = new System.Drawing.Size(792, 503);
            this.layoutControlGroup6.Text = "layoutControlGroup6";
            this.layoutControlGroup6.TextVisible = false;
            // 
            // layoutControlGroup7
            // 
            this.layoutControlGroup7.AllowDrawBackground = false;
            this.layoutControlGroup7.CustomizationFormText = "autoGeneratedGroup0";
            this.layoutControlGroup7.GroupBordersVisible = false;
            this.layoutControlGroup7.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.ItemForProdDt,
            this.ItemForSubShipLot1st,
            this.ItemForLotNoList,
            this.ItemForLotNoPackList,
            this.ItemForLotNoPackQtyList,
            this.ItemForDocNo,
            this.ItemForQty,
            this.ItemForPackage,
            this.layoutControlItem10,
            this.layoutControlItem9,
            this.ItemForPartNo,
            this.ItemForPartType});
            this.layoutControlGroup7.Location = new System.Drawing.Point(0, 0);
            this.layoutControlGroup7.Name = "autoGeneratedGroup0";
            this.layoutControlGroup7.Size = new System.Drawing.Size(792, 144);
            this.layoutControlGroup7.Text = "autoGeneratedGroup0";
            // 
            // ItemForProdDt
            // 
            this.ItemForProdDt.Control = this.ProdDtDateEdit;
            this.ItemForProdDt.CustomizationFormText = "日期";
            this.ItemForProdDt.Location = new System.Drawing.Point(601, 0);
            this.ItemForProdDt.Name = "ItemForProdDt";
            this.ItemForProdDt.Size = new System.Drawing.Size(191, 24);
            this.ItemForProdDt.Text = "日期";
            this.ItemForProdDt.TextSize = new System.Drawing.Size(48, 14);
            // 
            // ItemForSubShipLot1st
            // 
            this.ItemForSubShipLot1st.Control = this.SubShipLot1stTextEdit;
            this.ItemForSubShipLot1st.CustomizationFormText = "扫描标签";
            this.ItemForSubShipLot1st.Location = new System.Drawing.Point(0, 48);
            this.ItemForSubShipLot1st.Name = "ItemForSubShipLot1st";
            this.ItemForSubShipLot1st.Size = new System.Drawing.Size(792, 24);
            this.ItemForSubShipLot1st.Text = "扫描标签";
            this.ItemForSubShipLot1st.TextSize = new System.Drawing.Size(48, 14);
            // 
            // ItemForLotNoList
            // 
            this.ItemForLotNoList.Control = this.LotNoListTextEdit;
            this.ItemForLotNoList.CustomizationFormText = "装箱列表";
            this.ItemForLotNoList.Location = new System.Drawing.Point(0, 72);
            this.ItemForLotNoList.Name = "ItemForLotNoList";
            this.ItemForLotNoList.Size = new System.Drawing.Size(792, 24);
            this.ItemForLotNoList.Text = "装箱列表";
            this.ItemForLotNoList.TextSize = new System.Drawing.Size(48, 14);
            // 
            // ItemForLotNoPackList
            // 
            this.ItemForLotNoPackList.Control = this.LotNoPackListTextEdit;
            this.ItemForLotNoPackList.CustomizationFormText = "包数列表";
            this.ItemForLotNoPackList.Location = new System.Drawing.Point(0, 96);
            this.ItemForLotNoPackList.Name = "ItemForLotNoPackList";
            this.ItemForLotNoPackList.Size = new System.Drawing.Size(792, 24);
            this.ItemForLotNoPackList.Text = "包数列表";
            this.ItemForLotNoPackList.TextSize = new System.Drawing.Size(48, 14);
            // 
            // ItemForLotNoPackQtyList
            // 
            this.ItemForLotNoPackQtyList.Control = this.LotNoPackQtyListTextEdit;
            this.ItemForLotNoPackQtyList.CustomizationFormText = "数量列表";
            this.ItemForLotNoPackQtyList.Location = new System.Drawing.Point(0, 120);
            this.ItemForLotNoPackQtyList.Name = "ItemForLotNoPackQtyList";
            this.ItemForLotNoPackQtyList.Size = new System.Drawing.Size(792, 24);
            this.ItemForLotNoPackQtyList.Text = "数量列表";
            this.ItemForLotNoPackQtyList.TextSize = new System.Drawing.Size(48, 14);
            // 
            // ItemForDocNo
            // 
            this.ItemForDocNo.Control = this.DocNoTextEdit;
            this.ItemForDocNo.CustomizationFormText = "单 据 号:";
            this.ItemForDocNo.Location = new System.Drawing.Point(0, 0);
            this.ItemForDocNo.Name = "ItemForDocNo";
            this.ItemForDocNo.Size = new System.Drawing.Size(244, 24);
            this.ItemForDocNo.Text = "单 据 号:";
            this.ItemForDocNo.TextSize = new System.Drawing.Size(48, 14);
            // 
            // ItemForQty
            // 
            this.ItemForQty.Control = this.QtySpinEdit;
            this.ItemForQty.CustomizationFormText = "数量";
            this.ItemForQty.Location = new System.Drawing.Point(427, 0);
            this.ItemForQty.Name = "ItemForQty";
            this.ItemForQty.Size = new System.Drawing.Size(174, 24);
            this.ItemForQty.Text = "数量";
            this.ItemForQty.TextSize = new System.Drawing.Size(48, 14);
            // 
            // ItemForPackage
            // 
            this.ItemForPackage.Control = this.PackageSpinEdit;
            this.ItemForPackage.CustomizationFormText = "总包数";
            this.ItemForPackage.Location = new System.Drawing.Point(244, 0);
            this.ItemForPackage.Name = "ItemForPackage";
            this.ItemForPackage.Size = new System.Drawing.Size(183, 24);
            this.ItemForPackage.Text = "总包数";
            this.ItemForPackage.TextSize = new System.Drawing.Size(48, 14);
            // 
            // layoutControlItem10
            // 
            this.layoutControlItem10.Control = this.txtJobNo;
            this.layoutControlItem10.CustomizationFormText = "生产批号";
            this.layoutControlItem10.Location = new System.Drawing.Point(601, 24);
            this.layoutControlItem10.Name = "ItemForJobNo";
            this.layoutControlItem10.Size = new System.Drawing.Size(191, 24);
            this.layoutControlItem10.Text = "生产批号";
            this.layoutControlItem10.TextSize = new System.Drawing.Size(48, 14);
            // 
            // layoutControlItem9
            // 
            this.layoutControlItem9.Control = this.textEdit3;
            this.layoutControlItem9.CustomizationFormText = "客户";
            this.layoutControlItem9.Location = new System.Drawing.Point(0, 24);
            this.layoutControlItem9.Name = "ItemForCustCode";
            this.layoutControlItem9.Size = new System.Drawing.Size(244, 24);
            this.layoutControlItem9.Text = "客户";
            this.layoutControlItem9.TextSize = new System.Drawing.Size(48, 14);
            // 
            // ItemForPartNo
            // 
            this.ItemForPartNo.Control = this.PartNoTextEdit;
            this.ItemForPartNo.CustomizationFormText = "产品编号";
            this.ItemForPartNo.Location = new System.Drawing.Point(427, 24);
            this.ItemForPartNo.Name = "ItemForPartNo";
            this.ItemForPartNo.Size = new System.Drawing.Size(174, 24);
            this.ItemForPartNo.Text = "产品编号";
            this.ItemForPartNo.TextSize = new System.Drawing.Size(48, 14);
            // 
            // ItemForPartType
            // 
            this.ItemForPartType.Control = this.PartTypeTextEdit;
            this.ItemForPartType.CustomizationFormText = "产品型号";
            this.ItemForPartType.Location = new System.Drawing.Point(244, 24);
            this.ItemForPartType.Name = "ItemForPartType";
            this.ItemForPartType.Size = new System.Drawing.Size(183, 24);
            this.ItemForPartType.Text = "产品型号";
            this.ItemForPartType.TextSize = new System.Drawing.Size(48, 14);
            // 
            // layoutControlGroup8
            // 
            this.layoutControlGroup8.AllowDrawBackground = false;
            this.layoutControlGroup8.CustomizationFormText = "autoGeneratedGroup1";
            this.layoutControlGroup8.GroupBordersVisible = false;
            this.layoutControlGroup8.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.ItemForModifyUser,
            this.ItemForModifyDt,
            this.ItemForCreateUser,
            this.ItemForCreateDt,
            this.ItemForRemarks,
            this.layoutControlItem2});
            this.layoutControlGroup8.Location = new System.Drawing.Point(0, 144);
            this.layoutControlGroup8.Name = "autoGeneratedGroup1";
            this.layoutControlGroup8.Size = new System.Drawing.Size(792, 359);
            this.layoutControlGroup8.Text = "autoGeneratedGroup1";
            // 
            // ItemForModifyUser
            // 
            this.ItemForModifyUser.Control = this.ModifyUserTextEdit;
            this.ItemForModifyUser.CustomizationFormText = "修改者";
            this.ItemForModifyUser.Location = new System.Drawing.Point(535, 45);
            this.ItemForModifyUser.Name = "ItemForModifyUser";
            this.ItemForModifyUser.Size = new System.Drawing.Size(257, 24);
            this.ItemForModifyUser.Text = "修改者";
            this.ItemForModifyUser.TextSize = new System.Drawing.Size(48, 14);
            // 
            // ItemForModifyDt
            // 
            this.ItemForModifyDt.Control = this.ModifyDtDateEdit;
            this.ItemForModifyDt.CustomizationFormText = "修改日期";
            this.ItemForModifyDt.Location = new System.Drawing.Point(356, 45);
            this.ItemForModifyDt.Name = "ItemForModifyDt";
            this.ItemForModifyDt.Size = new System.Drawing.Size(179, 24);
            this.ItemForModifyDt.Text = "修改日期";
            this.ItemForModifyDt.TextSize = new System.Drawing.Size(48, 14);
            // 
            // ItemForCreateUser
            // 
            this.ItemForCreateUser.Control = this.CreateUserTextEdit;
            this.ItemForCreateUser.CustomizationFormText = "创建者";
            this.ItemForCreateUser.Location = new System.Drawing.Point(178, 45);
            this.ItemForCreateUser.Name = "ItemForCreateUser";
            this.ItemForCreateUser.Size = new System.Drawing.Size(178, 24);
            this.ItemForCreateUser.Text = "创建者";
            this.ItemForCreateUser.TextSize = new System.Drawing.Size(48, 14);
            // 
            // ItemForCreateDt
            // 
            this.ItemForCreateDt.Control = this.CreateDtDateEdit;
            this.ItemForCreateDt.CustomizationFormText = "创建日期";
            this.ItemForCreateDt.Location = new System.Drawing.Point(0, 45);
            this.ItemForCreateDt.Name = "ItemForCreateDt";
            this.ItemForCreateDt.Size = new System.Drawing.Size(178, 24);
            this.ItemForCreateDt.Text = "创建日期";
            this.ItemForCreateDt.TextSize = new System.Drawing.Size(48, 14);
            // 
            // ItemForRemarks
            // 
            this.ItemForRemarks.Control = this.RemarksTextEdit;
            this.ItemForRemarks.CustomizationFormText = "备注";
            this.ItemForRemarks.Location = new System.Drawing.Point(0, 0);
            this.ItemForRemarks.Name = "ItemForRemarks";
            this.ItemForRemarks.Size = new System.Drawing.Size(792, 45);
            this.ItemForRemarks.Text = "备注";
            this.ItemForRemarks.TextSize = new System.Drawing.Size(48, 14);
            // 
            // layoutControlItem2
            // 
            this.layoutControlItem2.Control = this.ykGridControl1;
            this.layoutControlItem2.CustomizationFormText = "layoutControlItem2";
            this.layoutControlItem2.Location = new System.Drawing.Point(0, 69);
            this.layoutControlItem2.Name = "layoutControlItem2";
            this.layoutControlItem2.Size = new System.Drawing.Size(792, 290);
            this.layoutControlItem2.Text = "layoutControlItem2";
            this.layoutControlItem2.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem2.TextToControlDistance = 0;
            this.layoutControlItem2.TextVisible = false;
            // 
            // layoutControlItem5
            // 
            this.layoutControlItem5.Control = this.groupControl3;
            this.layoutControlItem5.CustomizationFormText = "layoutControlItem5";
            this.layoutControlItem5.Location = new System.Drawing.Point(0, 199);
            this.layoutControlItem5.Name = "layoutControlItem5";
            this.layoutControlItem5.Size = new System.Drawing.Size(800, 531);
            this.layoutControlItem5.Text = "layoutControlItem5";
            this.layoutControlItem5.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem5.TextToControlDistance = 0;
            this.layoutControlItem5.TextVisible = false;
            // 
            // groupControl4
            // 
            this.groupControl4.Controls.Add(this.dataLayoutControl3);
            this.groupControl4.Location = new System.Drawing.Point(822, 172);
            this.groupControl4.Name = "groupControl4";
            this.groupControl4.Size = new System.Drawing.Size(404, 225);
            this.groupControl4.TabIndex = 6;
            this.groupControl4.Text = "全检信息(Job Tx Info.)";
            // 
            // dataLayoutControl3
            // 
            this.dataLayoutControl3.Controls.Add(this.JobNoTextEdit);
            this.dataLayoutControl3.Controls.Add(this.LotNoTextEdit);
            this.dataLayoutControl3.Controls.Add(this.textEdit1);
            this.dataLayoutControl3.Controls.Add(this.textEdit2);
            this.dataLayoutControl3.Controls.Add(this.QCOperatorTextEdit);
            this.dataLayoutControl3.Controls.Add(this.InQtyInkSpinEdit);
            this.dataLayoutControl3.Controls.Add(this.OutQtyInkSpinEdit);
            this.dataLayoutControl3.Controls.Add(this.NGQtyInkSpinEdit);
            this.dataLayoutControl3.DataSource = this.mESM501JobTxBindingSource;
            this.dataLayoutControl3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataLayoutControl3.Location = new System.Drawing.Point(2, 22);
            this.dataLayoutControl3.Name = "dataLayoutControl3";
            this.dataLayoutControl3.OptionsCustomizationForm.DesignTimeCustomizationFormPositionAndSize = new System.Drawing.Rectangle(1283, 205, 250, 350);
            this.dataLayoutControl3.OptionsView.IsReadOnly = DevExpress.Utils.DefaultBoolean.True;
            this.dataLayoutControl3.Root = this.layoutControlGroup4;
            this.dataLayoutControl3.Size = new System.Drawing.Size(400, 201);
            this.dataLayoutControl3.TabIndex = 0;
            this.dataLayoutControl3.Text = "dataLayoutControl3";
            // 
            // JobNoTextEdit
            // 
            this.JobNoTextEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.mESM501JobTxBindingSource, "JobNo", true));
            this.JobNoTextEdit.Location = new System.Drawing.Point(58, 2);
            this.JobNoTextEdit.Name = "JobNoTextEdit";
            this.JobNoTextEdit.Properties.ReadOnly = true;
            this.JobNoTextEdit.Size = new System.Drawing.Size(340, 20);
            this.JobNoTextEdit.StyleController = this.dataLayoutControl3;
            this.JobNoTextEdit.TabIndex = 4;
            // 
            // mESM501JobTxBindingSource
            // 
            this.mESM501JobTxBindingSource.DataSource = typeof(ERP.Domain.MES_M501_JobTx);
            // 
            // LotNoTextEdit
            // 
            this.LotNoTextEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.mESM501JobTxBindingSource, "LotNo", true));
            this.LotNoTextEdit.Location = new System.Drawing.Point(58, 26);
            this.LotNoTextEdit.Name = "LotNoTextEdit";
            this.LotNoTextEdit.Properties.ReadOnly = true;
            this.LotNoTextEdit.Size = new System.Drawing.Size(340, 20);
            this.LotNoTextEdit.StyleController = this.dataLayoutControl3;
            this.LotNoTextEdit.TabIndex = 5;
            // 
            // textEdit1
            // 
            this.textEdit1.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.mESM501JobTxBindingSource, "PartNo", true));
            this.textEdit1.Location = new System.Drawing.Point(58, 50);
            this.textEdit1.Name = "textEdit1";
            this.textEdit1.Properties.ReadOnly = true;
            this.textEdit1.Size = new System.Drawing.Size(340, 20);
            this.textEdit1.StyleController = this.dataLayoutControl3;
            this.textEdit1.TabIndex = 6;
            // 
            // textEdit2
            // 
            this.textEdit2.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.mESM501JobTxBindingSource, "PartType", true));
            this.textEdit2.Location = new System.Drawing.Point(58, 74);
            this.textEdit2.Name = "textEdit2";
            this.textEdit2.Properties.ReadOnly = true;
            this.textEdit2.Size = new System.Drawing.Size(340, 20);
            this.textEdit2.StyleController = this.dataLayoutControl3;
            this.textEdit2.TabIndex = 7;
            // 
            // QCOperatorTextEdit
            // 
            this.QCOperatorTextEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.mESM501JobTxBindingSource, "QCOperator", true));
            this.QCOperatorTextEdit.Location = new System.Drawing.Point(58, 98);
            this.QCOperatorTextEdit.Name = "QCOperatorTextEdit";
            this.QCOperatorTextEdit.Properties.ReadOnly = true;
            this.QCOperatorTextEdit.Size = new System.Drawing.Size(340, 20);
            this.QCOperatorTextEdit.StyleController = this.dataLayoutControl3;
            this.QCOperatorTextEdit.TabIndex = 8;
            // 
            // InQtyInkSpinEdit
            // 
            this.InQtyInkSpinEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.mESM501JobTxBindingSource, "InQtyInk", true));
            this.InQtyInkSpinEdit.EditValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.InQtyInkSpinEdit.Location = new System.Drawing.Point(58, 122);
            this.InQtyInkSpinEdit.Name = "InQtyInkSpinEdit";
            this.InQtyInkSpinEdit.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.InQtyInkSpinEdit.Properties.ReadOnly = true;
            this.InQtyInkSpinEdit.Size = new System.Drawing.Size(340, 20);
            this.InQtyInkSpinEdit.StyleController = this.dataLayoutControl3;
            this.InQtyInkSpinEdit.TabIndex = 10;
            // 
            // OutQtyInkSpinEdit
            // 
            this.OutQtyInkSpinEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.mESM501JobTxBindingSource, "OutQtyInk", true));
            this.OutQtyInkSpinEdit.EditValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.OutQtyInkSpinEdit.Location = new System.Drawing.Point(58, 146);
            this.OutQtyInkSpinEdit.Name = "OutQtyInkSpinEdit";
            this.OutQtyInkSpinEdit.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.OutQtyInkSpinEdit.Properties.ReadOnly = true;
            this.OutQtyInkSpinEdit.Size = new System.Drawing.Size(340, 20);
            this.OutQtyInkSpinEdit.StyleController = this.dataLayoutControl3;
            this.OutQtyInkSpinEdit.TabIndex = 12;
            // 
            // NGQtyInkSpinEdit
            // 
            this.NGQtyInkSpinEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.mESM501JobTxBindingSource, "NGQtyInk", true));
            this.NGQtyInkSpinEdit.EditValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.NGQtyInkSpinEdit.Location = new System.Drawing.Point(58, 170);
            this.NGQtyInkSpinEdit.Name = "NGQtyInkSpinEdit";
            this.NGQtyInkSpinEdit.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.NGQtyInkSpinEdit.Properties.ReadOnly = true;
            this.NGQtyInkSpinEdit.Size = new System.Drawing.Size(340, 20);
            this.NGQtyInkSpinEdit.StyleController = this.dataLayoutControl3;
            this.NGQtyInkSpinEdit.TabIndex = 14;
            // 
            // layoutControlGroup4
            // 
            this.layoutControlGroup4.CustomizationFormText = "layoutControlGroup4";
            this.layoutControlGroup4.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.layoutControlGroup4.GroupBordersVisible = false;
            this.layoutControlGroup4.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlGroup5});
            this.layoutControlGroup4.Location = new System.Drawing.Point(0, 0);
            this.layoutControlGroup4.Name = "layoutControlGroup4";
            this.layoutControlGroup4.Padding = new DevExpress.XtraLayout.Utils.Padding(0, 0, 0, 0);
            this.layoutControlGroup4.Size = new System.Drawing.Size(400, 201);
            this.layoutControlGroup4.Text = "layoutControlGroup4";
            this.layoutControlGroup4.TextVisible = false;
            // 
            // layoutControlGroup5
            // 
            this.layoutControlGroup5.AllowDrawBackground = false;
            this.layoutControlGroup5.CustomizationFormText = "autoGeneratedGroup0";
            this.layoutControlGroup5.GroupBordersVisible = false;
            this.layoutControlGroup5.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.ItemForJobNo,
            this.ItemForLotNo,
            this.layoutControlItem7,
            this.layoutControlItem8,
            this.ItemForQCOperator,
            this.ItemForInQtyInk,
            this.ItemForOutQtyInk,
            this.ItemForNGQtyInk});
            this.layoutControlGroup5.Location = new System.Drawing.Point(0, 0);
            this.layoutControlGroup5.Name = "autoGeneratedGroup0";
            this.layoutControlGroup5.Size = new System.Drawing.Size(400, 201);
            this.layoutControlGroup5.Text = "autoGeneratedGroup0";
            // 
            // ItemForJobNo
            // 
            this.ItemForJobNo.Control = this.JobNoTextEdit;
            this.ItemForJobNo.CustomizationFormText = "工单号";
            this.ItemForJobNo.Location = new System.Drawing.Point(0, 0);
            this.ItemForJobNo.Name = "ItemForJobNo";
            this.ItemForJobNo.Size = new System.Drawing.Size(400, 24);
            this.ItemForJobNo.Text = "工单号";
            this.ItemForJobNo.TextSize = new System.Drawing.Size(53, 14);
            // 
            // ItemForLotNo
            // 
            this.ItemForLotNo.Control = this.LotNoTextEdit;
            this.ItemForLotNo.CustomizationFormText = "生产批号";
            this.ItemForLotNo.Location = new System.Drawing.Point(0, 24);
            this.ItemForLotNo.Name = "ItemForLotNo";
            this.ItemForLotNo.Size = new System.Drawing.Size(400, 24);
            this.ItemForLotNo.Text = "生产批号";
            this.ItemForLotNo.TextSize = new System.Drawing.Size(53, 14);
            // 
            // layoutControlItem7
            // 
            this.layoutControlItem7.Control = this.textEdit1;
            this.layoutControlItem7.CustomizationFormText = "产品名称";
            this.layoutControlItem7.Location = new System.Drawing.Point(0, 48);
            this.layoutControlItem7.Name = "ItemForPartNo";
            this.layoutControlItem7.Size = new System.Drawing.Size(400, 24);
            this.layoutControlItem7.Text = "产品名称";
            this.layoutControlItem7.TextSize = new System.Drawing.Size(53, 14);
            // 
            // layoutControlItem8
            // 
            this.layoutControlItem8.Control = this.textEdit2;
            this.layoutControlItem8.CustomizationFormText = "产品型号";
            this.layoutControlItem8.Location = new System.Drawing.Point(0, 72);
            this.layoutControlItem8.Name = "ItemForPartType";
            this.layoutControlItem8.Size = new System.Drawing.Size(400, 24);
            this.layoutControlItem8.Text = "产品型号";
            this.layoutControlItem8.TextSize = new System.Drawing.Size(53, 14);
            // 
            // ItemForQCOperator
            // 
            this.ItemForQCOperator.Control = this.QCOperatorTextEdit;
            this.ItemForQCOperator.CustomizationFormText = "操作员";
            this.ItemForQCOperator.Location = new System.Drawing.Point(0, 96);
            this.ItemForQCOperator.Name = "ItemForQCOperator";
            this.ItemForQCOperator.Size = new System.Drawing.Size(400, 24);
            this.ItemForQCOperator.Text = "操作员";
            this.ItemForQCOperator.TextSize = new System.Drawing.Size(53, 14);
            // 
            // ItemForInQtyInk
            // 
            this.ItemForInQtyInk.Control = this.InQtyInkSpinEdit;
            this.ItemForInQtyInk.CustomizationFormText = "投入数(K)";
            this.ItemForInQtyInk.Location = new System.Drawing.Point(0, 120);
            this.ItemForInQtyInk.Name = "ItemForInQtyInk";
            this.ItemForInQtyInk.Size = new System.Drawing.Size(400, 24);
            this.ItemForInQtyInk.Text = "投入数(K)";
            this.ItemForInQtyInk.TextSize = new System.Drawing.Size(53, 14);
            // 
            // ItemForOutQtyInk
            // 
            this.ItemForOutQtyInk.Control = this.OutQtyInkSpinEdit;
            this.ItemForOutQtyInk.CustomizationFormText = "良品数(K)";
            this.ItemForOutQtyInk.Location = new System.Drawing.Point(0, 144);
            this.ItemForOutQtyInk.Name = "ItemForOutQtyInk";
            this.ItemForOutQtyInk.Size = new System.Drawing.Size(400, 24);
            this.ItemForOutQtyInk.Text = "良品数(K)";
            this.ItemForOutQtyInk.TextSize = new System.Drawing.Size(53, 14);
            // 
            // ItemForNGQtyInk
            // 
            this.ItemForNGQtyInk.Control = this.NGQtyInkSpinEdit;
            this.ItemForNGQtyInk.CustomizationFormText = "不良数(K)";
            this.ItemForNGQtyInk.Location = new System.Drawing.Point(0, 168);
            this.ItemForNGQtyInk.Name = "ItemForNGQtyInk";
            this.ItemForNGQtyInk.Size = new System.Drawing.Size(400, 33);
            this.ItemForNGQtyInk.Text = "不良数(K)";
            this.ItemForNGQtyInk.TextSize = new System.Drawing.Size(53, 14);
            // 
            // layoutControlItem6
            // 
            this.layoutControlItem6.Control = this.groupControl4;
            this.layoutControlItem6.CustomizationFormText = "layoutControlItem6";
            this.layoutControlItem6.Location = new System.Drawing.Point(810, 160);
            this.layoutControlItem6.MaxSize = new System.Drawing.Size(0, 229);
            this.layoutControlItem6.MinSize = new System.Drawing.Size(104, 229);
            this.layoutControlItem6.Name = "layoutControlItem6";
            this.layoutControlItem6.Size = new System.Drawing.Size(408, 229);
            this.layoutControlItem6.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
            this.layoutControlItem6.Text = "layoutControlItem6";
            this.layoutControlItem6.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem6.TextToControlDistance = 0;
            this.layoutControlItem6.TextVisible = false;
            // 
            // emptySpaceItem1
            // 
            this.emptySpaceItem1.AllowHotTrack = false;
            this.emptySpaceItem1.CustomizationFormText = "emptySpaceItem1";
            this.emptySpaceItem1.Location = new System.Drawing.Point(800, 0);
            this.emptySpaceItem1.Name = "emptySpaceItem1";
            this.emptySpaceItem1.Size = new System.Drawing.Size(10, 730);
            this.emptySpaceItem1.Text = "emptySpaceItem1";
            this.emptySpaceItem1.TextSize = new System.Drawing.Size(0, 0);
            // 
            // layoutControlGroup9
            // 
            this.layoutControlGroup9.CustomizationFormText = "未使用小标签数据(S Label List)";
            this.layoutControlGroup9.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItem4});
            this.layoutControlGroup9.Location = new System.Drawing.Point(810, 389);
            this.layoutControlGroup9.Name = "layoutControlGroup9";
            this.layoutControlGroup9.Padding = new DevExpress.XtraLayout.Utils.Padding(0, 0, 0, 0);
            this.layoutControlGroup9.Size = new System.Drawing.Size(408, 341);
            this.layoutControlGroup9.Text = "未使用小标签数据(S Label List)";
            // 
            // PackingScanForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1246, 787);
            this.Name = "PackingScanForm";
            this.Text = "包装扫描";
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataLayoutControl1)).EndInit();
            this.dataLayoutControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ykGridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mESM802PackingDtlBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            this.groupControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtBarCode.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).EndInit();
            this.groupControl2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataLayoutControl2)).EndInit();
            this.dataLayoutControl2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.CustCodeTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.eRPM001ProductPackInfoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CustPartNoTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CustPartNameTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CustPartTypeTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CustPartSpecTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PackPianZhiSpinEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PackBaoPianSpinEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PackHeBaoSpinEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PackXiangHeSpinEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForCustPartNo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForCustPartType)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForCustPartSpec)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForPackBaoPian)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForPackXiangHe)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForCustCode)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForCustPartName)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForPackPianZhi)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForPackHeBao)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ykGridControl2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mESM801LabelSBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl3)).EndInit();
            this.groupControl3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataLayoutControl4)).EndInit();
            this.dataLayoutControl4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DocNoTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mESM802PackingHdBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ProdDtDateEdit.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ProdDtDateEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.QtySpinEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PackageSpinEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit3.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtJobNo.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PartNoTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PartTypeTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SubShipLot1stTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.LotNoListTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.LotNoPackListTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.LotNoPackQtyListTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CreateDtDateEdit.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CreateDtDateEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CreateUserTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ModifyDtDateEdit.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ModifyDtDateEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ModifyUserTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.RemarksTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForProdDt)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForSubShipLot1st)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForLotNoList)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForLotNoPackList)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForLotNoPackQtyList)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForDocNo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForQty)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForPackage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem10)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem9)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForPartNo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForPartType)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup8)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForModifyUser)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForModifyDt)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForCreateUser)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForCreateDt)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForRemarks)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl4)).EndInit();
            this.groupControl4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataLayoutControl3)).EndInit();
            this.dataLayoutControl3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.JobNoTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mESM501JobTxBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.LotNoTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit2.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.QCOperatorTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.InQtyInkSpinEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.OutQtyInkSpinEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NGQtyInkSpinEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForJobNo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForLotNo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem8)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForQCOperator)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForInQtyInk)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForOutQtyInk)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForNGQtyInk)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup9)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private COM.YKControls.YKGridControl ykGridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem1;
        private DevExpress.XtraEditors.MemoEdit txtBarCode;
        private COM.YKControls.YKGridControl ykGridControl2;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView2;
        private DevExpress.XtraEditors.GroupControl groupControl2;
        private DevExpress.XtraDataLayout.DataLayoutControl dataLayoutControl2;
        private System.Windows.Forms.BindingSource eRPM001ProductPackInfoBindingSource;
        private DevExpress.XtraEditors.TextEdit CustCodeTextEdit;
        private DevExpress.XtraEditors.TextEdit CustPartNoTextEdit;
        private DevExpress.XtraEditors.TextEdit CustPartNameTextEdit;
        private DevExpress.XtraEditors.TextEdit CustPartTypeTextEdit;
        private DevExpress.XtraEditors.TextEdit CustPartSpecTextEdit;
        private DevExpress.XtraEditors.SpinEdit PackPianZhiSpinEdit;
        private DevExpress.XtraEditors.SpinEdit PackBaoPianSpinEdit;
        private DevExpress.XtraEditors.SpinEdit PackHeBaoSpinEdit;
        private DevExpress.XtraEditors.SpinEdit PackXiangHeSpinEdit;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup2;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup3;
        private DevExpress.XtraLayout.LayoutControlItem ItemForCustPartNo;
        private DevExpress.XtraLayout.LayoutControlItem ItemForCustPartType;
        private DevExpress.XtraLayout.LayoutControlItem ItemForCustPartSpec;
        private DevExpress.XtraLayout.LayoutControlItem ItemForPackBaoPian;
        private DevExpress.XtraLayout.LayoutControlItem ItemForPackXiangHe;
        private DevExpress.XtraLayout.LayoutControlItem ItemForCustCode;
        private DevExpress.XtraLayout.LayoutControlItem ItemForCustPartName;
        private DevExpress.XtraLayout.LayoutControlItem ItemForPackPianZhi;
        private DevExpress.XtraLayout.LayoutControlItem ItemForPackHeBao;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem3;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem4;
        private DevExpress.XtraEditors.GroupControl groupControl4;
        private DevExpress.XtraEditors.GroupControl groupControl3;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem5;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem6;
        private DevExpress.XtraLayout.EmptySpaceItem emptySpaceItem1;
        private System.Windows.Forms.BindingSource mESM801LabelSBindingSource;
        private DevExpress.XtraGrid.Columns.GridColumn colCompCode1;
        private DevExpress.XtraGrid.Columns.GridColumn colLotNo;
        private DevExpress.XtraGrid.Columns.GridColumn colMLotNo;
        private DevExpress.XtraGrid.Columns.GridColumn colPackSeqNo;
        private DevExpress.XtraGrid.Columns.GridColumn colPartNo;
        private DevExpress.XtraGrid.Columns.GridColumn colPartName;
        private DevExpress.XtraGrid.Columns.GridColumn colPartType;
        private DevExpress.XtraGrid.Columns.GridColumn colPartSpec;
        private DevExpress.XtraGrid.Columns.GridColumn colCustCode;
        private DevExpress.XtraGrid.Columns.GridColumn colCustPartNo;
        private DevExpress.XtraGrid.Columns.GridColumn colCustPartName;
        private DevExpress.XtraGrid.Columns.GridColumn colCustPartType;
        private DevExpress.XtraGrid.Columns.GridColumn colCustPartSpec;
        private DevExpress.XtraGrid.Columns.GridColumn colCustDrawingNo;
        private DevExpress.XtraGrid.Columns.GridColumn colCustPONo;
        private DevExpress.XtraGrid.Columns.GridColumn colCustLotNo;
        private DevExpress.XtraGrid.Columns.GridColumn colProdDt;
        private DevExpress.XtraGrid.Columns.GridColumn colExpiredDt;
        private DevExpress.XtraGrid.Columns.GridColumn colMatCode;
        private DevExpress.XtraGrid.Columns.GridColumn colMatType;
        private DevExpress.XtraGrid.Columns.GridColumn colQty;
        private DevExpress.XtraGrid.Columns.GridColumn colCode2D;
        private DevExpress.XtraGrid.Columns.GridColumn colUnit;
        private DevExpress.XtraGrid.Columns.GridColumn colIsPack;
        private DevExpress.XtraGrid.Columns.GridColumn colLBPartNo;
        private DevExpress.XtraGrid.Columns.GridColumn colLBPartName;
        private DevExpress.XtraGrid.Columns.GridColumn colPQty;
        private DevExpress.XtraGrid.Columns.GridColumn colLBSpec1;
        private DevExpress.XtraGrid.Columns.GridColumn colLBSpec2;
        private DevExpress.XtraGrid.Columns.GridColumn colId1;
        private System.Windows.Forms.BindingSource mESM802PackingDtlBindingSource;
        private DevExpress.XtraGrid.Columns.GridColumn colCompCode;
        private DevExpress.XtraGrid.Columns.GridColumn colDocNo;
        private DevExpress.XtraGrid.Columns.GridColumn colJobNo;
        private DevExpress.XtraGrid.Columns.GridColumn colShipLot;
        private DevExpress.XtraGrid.Columns.GridColumn colShipLotPackage;
        private DevExpress.XtraGrid.Columns.GridColumn colShipLotQty;
        private DevExpress.XtraGrid.Columns.GridColumn colRemarks;
        private DevExpress.XtraGrid.Columns.GridColumn colModifyDt;
        private DevExpress.XtraGrid.Columns.GridColumn colModifyUser;
        private DevExpress.XtraGrid.Columns.GridColumn colCreateDt;
        private DevExpress.XtraGrid.Columns.GridColumn colCreateUser;
        private DevExpress.XtraGrid.Columns.GridColumn colId;
        private DevExpress.XtraDataLayout.DataLayoutControl dataLayoutControl3;
        private DevExpress.XtraEditors.TextEdit JobNoTextEdit;
        private System.Windows.Forms.BindingSource mESM501JobTxBindingSource;
        private DevExpress.XtraEditors.TextEdit LotNoTextEdit;
        private DevExpress.XtraEditors.TextEdit textEdit1;
        private DevExpress.XtraEditors.TextEdit textEdit2;
        private DevExpress.XtraEditors.TextEdit QCOperatorTextEdit;
        private DevExpress.XtraEditors.SpinEdit InQtyInkSpinEdit;
        private DevExpress.XtraEditors.SpinEdit OutQtyInkSpinEdit;
        private DevExpress.XtraEditors.SpinEdit NGQtyInkSpinEdit;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup4;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup5;
        private DevExpress.XtraLayout.LayoutControlItem ItemForJobNo;
        private DevExpress.XtraLayout.LayoutControlItem ItemForLotNo;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem7;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem8;
        private DevExpress.XtraLayout.LayoutControlItem ItemForQCOperator;
        private DevExpress.XtraLayout.LayoutControlItem ItemForInQtyInk;
        private DevExpress.XtraLayout.LayoutControlItem ItemForOutQtyInk;
        private DevExpress.XtraLayout.LayoutControlItem ItemForNGQtyInk;
        private DevExpress.XtraEditors.LabelControl lbJobPackage;
        private DevExpress.XtraEditors.LabelControl labelControl7;
        private DevExpress.XtraEditors.LabelControl lbTips;
        private DevExpress.XtraLayout.Converter.LayoutConverter layoutConverter1;
        private DevExpress.XtraLayout.Converter.LayoutConverter layoutConverter2;
        private DevExpress.XtraDataLayout.DataLayoutControl dataLayoutControl4;
        private DevExpress.XtraEditors.TextEdit DocNoTextEdit;
        private System.Windows.Forms.BindingSource mESM802PackingHdBindingSource;
        private DevExpress.XtraEditors.DateEdit ProdDtDateEdit;
        private DevExpress.XtraEditors.SpinEdit QtySpinEdit;
        private DevExpress.XtraEditors.SpinEdit PackageSpinEdit;
        private DevExpress.XtraEditors.TextEdit textEdit3;
        private DevExpress.XtraEditors.TextEdit txtJobNo;
        private DevExpress.XtraEditors.TextEdit PartNoTextEdit;
        private DevExpress.XtraEditors.TextEdit PartTypeTextEdit;
        private DevExpress.XtraEditors.TextEdit SubShipLot1stTextEdit;
        private DevExpress.XtraEditors.TextEdit LotNoListTextEdit;
        private DevExpress.XtraEditors.TextEdit LotNoPackListTextEdit;
        private DevExpress.XtraEditors.TextEdit LotNoPackQtyListTextEdit;
        private DevExpress.XtraEditors.DateEdit CreateDtDateEdit;
        private DevExpress.XtraEditors.TextEdit CreateUserTextEdit;
        private DevExpress.XtraEditors.DateEdit ModifyDtDateEdit;
        private DevExpress.XtraEditors.TextEdit ModifyUserTextEdit;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup6;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup7;
        private DevExpress.XtraLayout.LayoutControlItem ItemForProdDt;
        private DevExpress.XtraLayout.LayoutControlItem ItemForSubShipLot1st;
        private DevExpress.XtraLayout.LayoutControlItem ItemForLotNoList;
        private DevExpress.XtraLayout.LayoutControlItem ItemForLotNoPackList;
        private DevExpress.XtraLayout.LayoutControlItem ItemForLotNoPackQtyList;
        private DevExpress.XtraLayout.LayoutControlItem ItemForDocNo;
        private DevExpress.XtraLayout.LayoutControlItem ItemForQty;
        private DevExpress.XtraLayout.LayoutControlItem ItemForPackage;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem10;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem9;
        private DevExpress.XtraLayout.LayoutControlItem ItemForPartNo;
        private DevExpress.XtraLayout.LayoutControlItem ItemForPartType;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup8;
        private DevExpress.XtraLayout.LayoutControlItem ItemForModifyUser;
        private DevExpress.XtraLayout.LayoutControlItem ItemForModifyDt;
        private DevExpress.XtraLayout.LayoutControlItem ItemForCreateUser;
        private DevExpress.XtraLayout.LayoutControlItem ItemForCreateDt;
        private DevExpress.XtraLayout.LayoutControlItem ItemForRemarks;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup9;
        private DevExpress.XtraEditors.MemoEdit RemarksTextEdit;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem2;
        private DevExpress.XtraEditors.SimpleButton simpleButton1;
    }
}