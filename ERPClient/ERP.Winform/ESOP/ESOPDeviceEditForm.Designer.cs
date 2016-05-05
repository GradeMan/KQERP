namespace ERP.Winform.ESOP
{
    partial class ESOPDeviceEditForm
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
            this.eSOPDeviceBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.DevNameTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.ItemForDevName = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlGroup2 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.ItemForAlias = new DevExpress.XtraLayout.LayoutControlItem();
            this.AliasTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.ItemForState = new DevExpress.XtraLayout.LayoutControlItem();
            this.StateTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.ItemForRemarks = new DevExpress.XtraLayout.LayoutControlItem();
            this.RemarksTextEdit = new DevExpress.XtraEditors.MemoEdit();
            this.emptySpaceItem1 = new DevExpress.XtraLayout.EmptySpaceItem();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataLayoutControl1)).BeginInit();
            this.dataLayoutControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.eSOPDeviceBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DevNameTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForDevName)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForAlias)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.AliasTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForState)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.StateTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForRemarks)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.RemarksTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem1)).BeginInit();
            this.SuspendLayout();
            // 
            // panelControl1
            // 
            this.panelControl1.Size = new System.Drawing.Size(442, 278);
            // 
            // dataLayoutControl1
            // 
            this.dataLayoutControl1.Controls.Add(this.DevNameTextEdit);
            this.dataLayoutControl1.Controls.Add(this.AliasTextEdit);
            this.dataLayoutControl1.Controls.Add(this.StateTextEdit);
            this.dataLayoutControl1.Controls.Add(this.RemarksTextEdit);
            this.dataLayoutControl1.DataSource = this.eSOPDeviceBindingSource;
            this.dataLayoutControl1.OptionsCustomizationForm.DesignTimeCustomizationFormPositionAndSize = new System.Drawing.Rectangle(584, 214, 250, 350);
            this.dataLayoutControl1.Size = new System.Drawing.Size(438, 274);
            // 
            // layoutControlGroup1
            // 
            this.layoutControlGroup1.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlGroup2,
            this.emptySpaceItem1});
            this.layoutControlGroup1.Size = new System.Drawing.Size(438, 274);
            // 
            // eSOPDeviceBindingSource
            // 
            this.eSOPDeviceBindingSource.DataSource = typeof(ERP.Domain.ESOP_Device);
            // 
            // DevNameTextEdit
            // 
            this.DevNameTextEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.eSOPDeviceBindingSource, "DevName", true));
            this.DevNameTextEdit.Location = new System.Drawing.Point(64, 12);
            this.DevNameTextEdit.Name = "DevNameTextEdit";
            this.DevNameTextEdit.Size = new System.Drawing.Size(362, 20);
            this.DevNameTextEdit.StyleController = this.dataLayoutControl1;
            this.DevNameTextEdit.TabIndex = 4;
            // 
            // ItemForDevName
            // 
            this.ItemForDevName.Control = this.DevNameTextEdit;
            this.ItemForDevName.CustomizationFormText = "Dev Name";
            this.ItemForDevName.Location = new System.Drawing.Point(0, 0);
            this.ItemForDevName.Name = "ItemForDevName";
            this.ItemForDevName.Size = new System.Drawing.Size(418, 24);
            this.ItemForDevName.Text = "设备名称";
            this.ItemForDevName.TextSize = new System.Drawing.Size(48, 14);
            // 
            // layoutControlGroup2
            // 
            this.layoutControlGroup2.AllowDrawBackground = false;
            this.layoutControlGroup2.CustomizationFormText = "autoGeneratedGroup0";
            this.layoutControlGroup2.GroupBordersVisible = false;
            this.layoutControlGroup2.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.ItemForDevName,
            this.ItemForAlias,
            this.ItemForState,
            this.ItemForRemarks});
            this.layoutControlGroup2.Location = new System.Drawing.Point(0, 0);
            this.layoutControlGroup2.Name = "autoGeneratedGroup0";
            this.layoutControlGroup2.Size = new System.Drawing.Size(418, 209);
            this.layoutControlGroup2.Text = "autoGeneratedGroup0";
            // 
            // ItemForAlias
            // 
            this.ItemForAlias.Control = this.AliasTextEdit;
            this.ItemForAlias.CustomizationFormText = "Alias";
            this.ItemForAlias.Location = new System.Drawing.Point(0, 24);
            this.ItemForAlias.Name = "ItemForAlias";
            this.ItemForAlias.Size = new System.Drawing.Size(418, 24);
            this.ItemForAlias.Text = "简称";
            this.ItemForAlias.TextSize = new System.Drawing.Size(48, 14);
            // 
            // AliasTextEdit
            // 
            this.AliasTextEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.eSOPDeviceBindingSource, "Alias", true));
            this.AliasTextEdit.Location = new System.Drawing.Point(64, 36);
            this.AliasTextEdit.Name = "AliasTextEdit";
            this.AliasTextEdit.Size = new System.Drawing.Size(362, 20);
            this.AliasTextEdit.StyleController = this.dataLayoutControl1;
            this.AliasTextEdit.TabIndex = 5;
            // 
            // ItemForState
            // 
            this.ItemForState.Control = this.StateTextEdit;
            this.ItemForState.CustomizationFormText = "State";
            this.ItemForState.Location = new System.Drawing.Point(0, 48);
            this.ItemForState.Name = "ItemForState";
            this.ItemForState.Size = new System.Drawing.Size(418, 24);
            this.ItemForState.Text = "状态";
            this.ItemForState.TextSize = new System.Drawing.Size(48, 14);
            // 
            // StateTextEdit
            // 
            this.StateTextEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.eSOPDeviceBindingSource, "State", true));
            this.StateTextEdit.Location = new System.Drawing.Point(64, 60);
            this.StateTextEdit.Name = "StateTextEdit";
            this.StateTextEdit.Size = new System.Drawing.Size(362, 20);
            this.StateTextEdit.StyleController = this.dataLayoutControl1;
            this.StateTextEdit.TabIndex = 6;
            // 
            // ItemForRemarks
            // 
            this.ItemForRemarks.Control = this.RemarksTextEdit;
            this.ItemForRemarks.CustomizationFormText = "Remarks";
            this.ItemForRemarks.Location = new System.Drawing.Point(0, 72);
            this.ItemForRemarks.Name = "ItemForRemarks";
            this.ItemForRemarks.Size = new System.Drawing.Size(418, 137);
            this.ItemForRemarks.Text = "备注";
            this.ItemForRemarks.TextSize = new System.Drawing.Size(48, 14);
            // 
            // RemarksTextEdit
            // 
            this.RemarksTextEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.eSOPDeviceBindingSource, "Remarks", true));
            this.RemarksTextEdit.Location = new System.Drawing.Point(64, 84);
            this.RemarksTextEdit.Name = "RemarksTextEdit";
            this.RemarksTextEdit.Size = new System.Drawing.Size(362, 133);
            this.RemarksTextEdit.StyleController = this.dataLayoutControl1;
            this.RemarksTextEdit.TabIndex = 7;
            // 
            // emptySpaceItem1
            // 
            this.emptySpaceItem1.AllowHotTrack = false;
            this.emptySpaceItem1.CustomizationFormText = "emptySpaceItem1";
            this.emptySpaceItem1.Location = new System.Drawing.Point(0, 209);
            this.emptySpaceItem1.Name = "emptySpaceItem1";
            this.emptySpaceItem1.Size = new System.Drawing.Size(418, 45);
            this.emptySpaceItem1.Text = "emptySpaceItem1";
            this.emptySpaceItem1.TextSize = new System.Drawing.Size(0, 0);
            // 
            // ESOPDeviceEditForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(446, 313);
            this.Name = "ESOPDeviceEditForm";
            this.Text = "ESOPDeviceEditForm";
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataLayoutControl1)).EndInit();
            this.dataLayoutControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.eSOPDeviceBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DevNameTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForDevName)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForAlias)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.AliasTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForState)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.StateTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForRemarks)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.RemarksTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.TextEdit DevNameTextEdit;
        private System.Windows.Forms.BindingSource eSOPDeviceBindingSource;
        private DevExpress.XtraEditors.TextEdit AliasTextEdit;
        private DevExpress.XtraEditors.TextEdit StateTextEdit;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup2;
        private DevExpress.XtraLayout.LayoutControlItem ItemForDevName;
        private DevExpress.XtraLayout.LayoutControlItem ItemForAlias;
        private DevExpress.XtraLayout.LayoutControlItem ItemForState;
        private DevExpress.XtraLayout.LayoutControlItem ItemForRemarks;
        private DevExpress.XtraEditors.MemoEdit RemarksTextEdit;
        private DevExpress.XtraLayout.EmptySpaceItem emptySpaceItem1;
    }
}