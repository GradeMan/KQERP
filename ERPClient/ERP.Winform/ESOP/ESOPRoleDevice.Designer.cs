namespace ERP.Winform.ESOP
{
    partial class ESOPRoleDevice
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
            this.treeListOrgan = new DevExpress.XtraTreeList.TreeList();
            this.ColumnDevId = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            this.ColumnDevName = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            this.layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataLayoutControl1)).BeginInit();
            this.dataLayoutControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.treeListOrgan)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).BeginInit();
            this.SuspendLayout();
            // 
            // panelControl1
            // 
            this.panelControl1.Size = new System.Drawing.Size(532, 460);
            // 
            // dataLayoutControl1
            // 
            this.dataLayoutControl1.Controls.Add(this.treeListOrgan);
            this.dataLayoutControl1.OptionsCustomizationForm.DesignTimeCustomizationFormPositionAndSize = new System.Drawing.Rectangle(584, 214, 250, 350);
            this.dataLayoutControl1.Size = new System.Drawing.Size(528, 456);
            // 
            // layoutControlGroup1
            // 
            this.layoutControlGroup1.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItem1});
            this.layoutControlGroup1.Size = new System.Drawing.Size(528, 456);
            // 
            // treeListOrgan
            // 
            this.treeListOrgan.Columns.AddRange(new DevExpress.XtraTreeList.Columns.TreeListColumn[] {
            this.ColumnDevId,
            this.ColumnDevName});
            this.treeListOrgan.Location = new System.Drawing.Point(12, 12);
            this.treeListOrgan.Name = "treeListOrgan";
            this.treeListOrgan.OptionsBehavior.AllowIndeterminateCheckState = true;
            this.treeListOrgan.OptionsBehavior.Editable = false;
            this.treeListOrgan.OptionsBehavior.PopulateServiceColumns = true;
            this.treeListOrgan.OptionsView.ShowCheckBoxes = true;
            this.treeListOrgan.Size = new System.Drawing.Size(504, 432);
            this.treeListOrgan.TabIndex = 6;
            this.treeListOrgan.BeforeCheckNode += new DevExpress.XtraTreeList.CheckNodeEventHandler(this.treeListOrgan_BeforeCheckNode);
            // 
            // ColumnDevId
            // 
            this.ColumnDevId.Caption = "设备Id";
            this.ColumnDevId.FieldName = "Id";
            this.ColumnDevId.MinWidth = 32;
            this.ColumnDevId.Name = "ColumnDevId";
            this.ColumnDevId.Width = 145;
            // 
            // ColumnDevName
            // 
            this.ColumnDevName.Caption = "设备名称";
            this.ColumnDevName.FieldName = "DevName";
            this.ColumnDevName.MinWidth = 34;
            this.ColumnDevName.Name = "ColumnDevName";
            this.ColumnDevName.Visible = true;
            this.ColumnDevName.VisibleIndex = 0;
            this.ColumnDevName.Width = 481;
            // 
            // layoutControlItem1
            // 
            this.layoutControlItem1.Control = this.treeListOrgan;
            this.layoutControlItem1.CustomizationFormText = "layoutControlItem1";
            this.layoutControlItem1.Location = new System.Drawing.Point(0, 0);
            this.layoutControlItem1.Name = "layoutControlItem1";
            this.layoutControlItem1.Size = new System.Drawing.Size(508, 436);
            this.layoutControlItem1.Text = "layoutControlItem1";
            this.layoutControlItem1.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem1.TextToControlDistance = 0;
            this.layoutControlItem1.TextVisible = false;
            // 
            // ESOPRoleDevice
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(536, 495);
            this.Name = "ESOPRoleDevice";
            this.Text = "ESOPRoleDevice";
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataLayoutControl1)).EndInit();
            this.dataLayoutControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.treeListOrgan)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraTreeList.TreeList treeListOrgan;
        private DevExpress.XtraTreeList.Columns.TreeListColumn ColumnDevId;
        private DevExpress.XtraTreeList.Columns.TreeListColumn ColumnDevName;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem1;
    }
}