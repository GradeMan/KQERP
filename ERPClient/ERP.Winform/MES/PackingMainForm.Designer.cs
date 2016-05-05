namespace ERP.Winform.MES
{
    partial class PackingMainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PackingMainForm));
            this.splitContainerControl1 = new DevExpress.XtraEditors.SplitContainerControl();
            this.ykGridControl1 = new COM.YKControls.YKGridControl();
            this.mESM802PackingHdBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ykGridControl2 = new COM.YKControls.YKGridControl();
            this.mESM802PackingDtlBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.btnSearch = new DevExpress.XtraEditors.SimpleButton();
            this.serShipLot = new DevExpress.XtraEditors.TextEdit();
            this.labelControl12 = new DevExpress.XtraEditors.LabelControl();
            this.serJobNo = new DevExpress.XtraEditors.TextEdit();
            this.labelControl11 = new DevExpress.XtraEditors.LabelControl();
            this.datePackingEnd = new DevExpress.XtraEditors.DateEdit();
            this.labelControl10 = new DevExpress.XtraEditors.LabelControl();
            this.datePackingStart = new DevExpress.XtraEditors.DateEdit();
            this.labelControl9 = new DevExpress.XtraEditors.LabelControl();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl1)).BeginInit();
            this.splitContainerControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ykGridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mESM802PackingHdBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ykGridControl2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mESM802PackingDtlBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.serShipLot.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.serJobNo.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.datePackingEnd.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.datePackingEnd.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.datePackingStart.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.datePackingStart.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // splitContainerControl1
            // 
            this.splitContainerControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainerControl1.Horizontal = false;
            this.splitContainerControl1.Location = new System.Drawing.Point(0, 82);
            this.splitContainerControl1.Name = "splitContainerControl1";
            this.splitContainerControl1.Panel1.Controls.Add(this.ykGridControl1);
            this.splitContainerControl1.Panel1.Text = "Panel1";
            this.splitContainerControl1.Panel2.Controls.Add(this.ykGridControl2);
            this.splitContainerControl1.Panel2.Text = "Panel2";
            this.splitContainerControl1.Size = new System.Drawing.Size(1183, 560);
            this.splitContainerControl1.SplitterPosition = 284;
            this.splitContainerControl1.TabIndex = 4;
            this.splitContainerControl1.Text = "splitContainerControl1";
            // 
            // ykGridControl1
            // 
            this.ykGridControl1.Cursor = System.Windows.Forms.Cursors.Default;
            this.ykGridControl1.DataSource = this.mESM802PackingHdBindingSource;
            this.ykGridControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ykGridControl1.EmbeddedNavigator.Buttons.Append.Visible = false;
            this.ykGridControl1.EmbeddedNavigator.Buttons.CancelEdit.Visible = false;
            this.ykGridControl1.EmbeddedNavigator.Buttons.Edit.Visible = false;
            this.ykGridControl1.EmbeddedNavigator.Buttons.EndEdit.Visible = false;
            this.ykGridControl1.EmbeddedNavigator.Buttons.Remove.Visible = false;
            this.ykGridControl1.EmbeddedNavigator.TextStringFormat = "记录:第{0}笔/共{1}笔";
            this.ykGridControl1.Location = new System.Drawing.Point(0, 0);
            this.ykGridControl1.MenuManager = this.barManager1;
            this.ykGridControl1.Name = "ykGridControl1";
            this.ykGridControl1.Size = new System.Drawing.Size(1183, 284);
            this.ykGridControl1.TabIndex = 0;
            this.ykGridControl1.UseEmbeddedNavigator = true;
            // 
            // mESM802PackingHdBindingSource
            // 
            this.mESM802PackingHdBindingSource.DataSource = typeof(ERP.Domain.MES_M802_Packing_Hd);
            // 
            // ykGridControl2
            // 
            this.ykGridControl2.Cursor = System.Windows.Forms.Cursors.Default;
            this.ykGridControl2.DataSource = this.mESM802PackingDtlBindingSource;
            this.ykGridControl2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ykGridControl2.EmbeddedNavigator.Buttons.Append.Visible = false;
            this.ykGridControl2.EmbeddedNavigator.Buttons.CancelEdit.Visible = false;
            this.ykGridControl2.EmbeddedNavigator.Buttons.Edit.Visible = false;
            this.ykGridControl2.EmbeddedNavigator.Buttons.EndEdit.Visible = false;
            this.ykGridControl2.EmbeddedNavigator.Buttons.Remove.Visible = false;
            this.ykGridControl2.EmbeddedNavigator.TextStringFormat = "记录:第{0}笔/共{1}笔";
            this.ykGridControl2.Location = new System.Drawing.Point(0, 0);
            this.ykGridControl2.MenuManager = this.barManager1;
            this.ykGridControl2.Name = "ykGridControl2";
            this.ykGridControl2.Size = new System.Drawing.Size(1183, 271);
            this.ykGridControl2.TabIndex = 0;
            this.ykGridControl2.UseEmbeddedNavigator = true;
            // 
            // mESM802PackingDtlBindingSource
            // 
            this.mESM802PackingDtlBindingSource.DataSource = typeof(ERP.Domain.MES_M802_Packing_Dtl);
            // 
            // groupControl1
            // 
            this.groupControl1.Controls.Add(this.btnSearch);
            this.groupControl1.Controls.Add(this.serShipLot);
            this.groupControl1.Controls.Add(this.labelControl12);
            this.groupControl1.Controls.Add(this.serJobNo);
            this.groupControl1.Controls.Add(this.labelControl11);
            this.groupControl1.Controls.Add(this.datePackingEnd);
            this.groupControl1.Controls.Add(this.labelControl10);
            this.groupControl1.Controls.Add(this.datePackingStart);
            this.groupControl1.Controls.Add(this.labelControl9);
            this.groupControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupControl1.Location = new System.Drawing.Point(0, 0);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(1183, 82);
            this.groupControl1.TabIndex = 5;
            this.groupControl1.Text = "搜索条件";
            // 
            // btnSearch
            // 
            this.btnSearch.Image = ((System.Drawing.Image)(resources.GetObject("btnSearch.Image")));
            this.btnSearch.Location = new System.Drawing.Point(883, 36);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(82, 29);
            this.btnSearch.TabIndex = 31;
            this.btnSearch.Text = "查询";
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // serShipLot
            // 
            this.serShipLot.Location = new System.Drawing.Point(709, 40);
            this.serShipLot.MenuManager = this.barManager1;
            this.serShipLot.Name = "serShipLot";
            this.serShipLot.Size = new System.Drawing.Size(144, 20);
            this.serShipLot.TabIndex = 30;
            // 
            // labelControl12
            // 
            this.labelControl12.Location = new System.Drawing.Point(647, 43);
            this.labelControl12.Name = "labelControl12";
            this.labelControl12.Size = new System.Drawing.Size(60, 14);
            this.labelControl12.TabIndex = 29;
            this.labelControl12.Text = "装箱批号：";
            // 
            // serJobNo
            // 
            this.serJobNo.Location = new System.Drawing.Point(486, 40);
            this.serJobNo.MenuManager = this.barManager1;
            this.serJobNo.Name = "serJobNo";
            this.serJobNo.Size = new System.Drawing.Size(144, 20);
            this.serJobNo.TabIndex = 28;
            // 
            // labelControl11
            // 
            this.labelControl11.Location = new System.Drawing.Point(424, 43);
            this.labelControl11.Name = "labelControl11";
            this.labelControl11.Size = new System.Drawing.Size(60, 14);
            this.labelControl11.TabIndex = 27;
            this.labelControl11.Text = "生产批号：";
            // 
            // datePackingEnd
            // 
            this.datePackingEnd.EditValue = null;
            this.datePackingEnd.Location = new System.Drawing.Point(264, 40);
            this.datePackingEnd.MenuManager = this.barManager1;
            this.datePackingEnd.Name = "datePackingEnd";
            this.datePackingEnd.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.datePackingEnd.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.datePackingEnd.Size = new System.Drawing.Size(144, 20);
            this.datePackingEnd.TabIndex = 26;
            // 
            // labelControl10
            // 
            this.labelControl10.Location = new System.Drawing.Point(246, 43);
            this.labelControl10.Name = "labelControl10";
            this.labelControl10.Size = new System.Drawing.Size(12, 14);
            this.labelControl10.TabIndex = 25;
            this.labelControl10.Text = "～";
            // 
            // datePackingStart
            // 
            this.datePackingStart.EditValue = null;
            this.datePackingStart.Location = new System.Drawing.Point(96, 40);
            this.datePackingStart.MenuManager = this.barManager1;
            this.datePackingStart.Name = "datePackingStart";
            this.datePackingStart.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.datePackingStart.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.datePackingStart.Size = new System.Drawing.Size(144, 20);
            this.datePackingStart.TabIndex = 24;
            // 
            // labelControl9
            // 
            this.labelControl9.Location = new System.Drawing.Point(12, 43);
            this.labelControl9.Name = "labelControl9";
            this.labelControl9.Size = new System.Drawing.Size(82, 14);
            this.labelControl9.TabIndex = 23;
            this.labelControl9.Text = "包装日期(起)：";
            // 
            // PackingMainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1183, 671);
            this.Controls.Add(this.splitContainerControl1);
            this.Controls.Add(this.groupControl1);
            this.Name = "PackingMainForm";
            this.Text = "包装管理";
            this.Controls.SetChildIndex(this.groupControl1, 0);
            this.Controls.SetChildIndex(this.splitContainerControl1, 0);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl1)).EndInit();
            this.splitContainerControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ykGridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mESM802PackingHdBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ykGridControl2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mESM802PackingDtlBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            this.groupControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.serShipLot.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.serJobNo.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.datePackingEnd.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.datePackingEnd.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.datePackingStart.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.datePackingStart.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.SplitContainerControl splitContainerControl1;
        private COM.YKControls.YKGridControl ykGridControl1;
        private COM.YKControls.YKGridControl ykGridControl2;
        private DevExpress.XtraEditors.GroupControl groupControl1;
        private System.Windows.Forms.BindingSource mESM802PackingHdBindingSource;
        private System.Windows.Forms.BindingSource mESM802PackingDtlBindingSource;
        private DevExpress.XtraEditors.SimpleButton btnSearch;
        private DevExpress.XtraEditors.TextEdit serShipLot;
        private DevExpress.XtraEditors.LabelControl labelControl12;
        private DevExpress.XtraEditors.TextEdit serJobNo;
        private DevExpress.XtraEditors.LabelControl labelControl11;
        private DevExpress.XtraEditors.DateEdit datePackingEnd;
        private DevExpress.XtraEditors.LabelControl labelControl10;
        private DevExpress.XtraEditors.DateEdit datePackingStart;
        private DevExpress.XtraEditors.LabelControl labelControl9;
    }
}