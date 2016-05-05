namespace ERP.Winform.CommonModule
{
    partial class C006ProcessProdInfoEditForm
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
            this.eRPC006ProcessProdInfoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.layoutControlGroup2 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.ItemForTechCode = new DevExpress.XtraLayout.LayoutControlItem();
            this.TechCodeTextEdit = new DevExpress.XtraEditors.GridLookUpEdit();
            this.gridLookUpEdit1View = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.ItemForTechSeqNo = new DevExpress.XtraLayout.LayoutControlItem();
            this.TechSeqNoTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.ItemForTechContent = new DevExpress.XtraLayout.LayoutControlItem();
            this.TechContentTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.ItemForTechType = new DevExpress.XtraLayout.LayoutControlItem();
            this.TechTypeTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.ItemForIsVisible = new DevExpress.XtraLayout.LayoutControlItem();
            this.IsVisibleCheckEdit = new DevExpress.XtraEditors.CheckEdit();
            this.ItemForRemarks = new DevExpress.XtraLayout.LayoutControlItem();
            this.RemarksTextEdit = new DevExpress.XtraEditors.MemoEdit();
            this.emptySpaceItem1 = new DevExpress.XtraLayout.EmptySpaceItem();
            this.ItemForProcessCode = new DevExpress.XtraLayout.LayoutControlItem();
            this.ProcessCodeTextEdit = new DevExpress.XtraEditors.TextEdit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataLayoutControl1)).BeginInit();
            this.dataLayoutControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.eRPC006ProcessProdInfoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForTechCode)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TechCodeTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridLookUpEdit1View)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForTechSeqNo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TechSeqNoTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForTechContent)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TechContentTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForTechType)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TechTypeTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForIsVisible)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.IsVisibleCheckEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForRemarks)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.RemarksTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForProcessCode)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ProcessCodeTextEdit.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // panelControl1
            // 
            this.panelControl1.Size = new System.Drawing.Size(594, 371);
            // 
            // dataLayoutControl1
            // 
            this.dataLayoutControl1.Controls.Add(this.ProcessCodeTextEdit);
            this.dataLayoutControl1.Controls.Add(this.TechSeqNoTextEdit);
            this.dataLayoutControl1.Controls.Add(this.TechContentTextEdit);
            this.dataLayoutControl1.Controls.Add(this.TechTypeTextEdit);
            this.dataLayoutControl1.Controls.Add(this.IsVisibleCheckEdit);
            this.dataLayoutControl1.Controls.Add(this.RemarksTextEdit);
            this.dataLayoutControl1.Controls.Add(this.TechCodeTextEdit);
            this.dataLayoutControl1.DataSource = this.eRPC006ProcessProdInfoBindingSource;
            this.dataLayoutControl1.HiddenItems.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.ItemForProcessCode});
            this.dataLayoutControl1.OptionsCustomizationForm.DesignTimeCustomizationFormPositionAndSize = new System.Drawing.Rectangle(584, 214, 250, 350);
            this.dataLayoutControl1.Size = new System.Drawing.Size(590, 367);
            // 
            // layoutControlGroup1
            // 
            this.layoutControlGroup1.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlGroup2});
            this.layoutControlGroup1.Size = new System.Drawing.Size(590, 367);
            // 
            // eRPC006ProcessProdInfoBindingSource
            // 
            this.eRPC006ProcessProdInfoBindingSource.DataSource = typeof(ERP.Domain.ERP_C006_ProcessProdInfo);
            // 
            // layoutControlGroup2
            // 
            this.layoutControlGroup2.AllowDrawBackground = false;
            this.layoutControlGroup2.CustomizationFormText = "autoGeneratedGroup0";
            this.layoutControlGroup2.GroupBordersVisible = false;
            this.layoutControlGroup2.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.ItemForTechCode,
            this.ItemForTechSeqNo,
            this.ItemForTechContent,
            this.ItemForTechType,
            this.ItemForIsVisible,
            this.ItemForRemarks,
            this.emptySpaceItem1});
            this.layoutControlGroup2.Location = new System.Drawing.Point(0, 0);
            this.layoutControlGroup2.Name = "autoGeneratedGroup0";
            this.layoutControlGroup2.Size = new System.Drawing.Size(570, 347);
            this.layoutControlGroup2.Text = "autoGeneratedGroup0";
            // 
            // ItemForTechCode
            // 
            this.ItemForTechCode.Control = this.TechCodeTextEdit;
            this.ItemForTechCode.CustomizationFormText = "制程参数";
            this.ItemForTechCode.Location = new System.Drawing.Point(0, 0);
            this.ItemForTechCode.Name = "ItemForTechCode";
            this.ItemForTechCode.Size = new System.Drawing.Size(570, 24);
            this.ItemForTechCode.Text = "制程参数";
            this.ItemForTechCode.TextSize = new System.Drawing.Size(48, 14);
            // 
            // TechCodeTextEdit
            // 
            this.TechCodeTextEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.eRPC006ProcessProdInfoBindingSource, "TechCode", true));
            this.TechCodeTextEdit.Location = new System.Drawing.Point(64, 12);
            this.TechCodeTextEdit.Name = "TechCodeTextEdit";
            this.TechCodeTextEdit.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.TechCodeTextEdit.Properties.NullText = "";
            this.TechCodeTextEdit.Properties.View = this.gridLookUpEdit1View;
            this.TechCodeTextEdit.Size = new System.Drawing.Size(514, 20);
            this.TechCodeTextEdit.StyleController = this.dataLayoutControl1;
            this.TechCodeTextEdit.TabIndex = 6;
            // 
            // gridLookUpEdit1View
            // 
            this.gridLookUpEdit1View.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.gridLookUpEdit1View.Name = "gridLookUpEdit1View";
            this.gridLookUpEdit1View.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.gridLookUpEdit1View.OptionsView.ShowGroupPanel = false;
            // 
            // ItemForTechSeqNo
            // 
            this.ItemForTechSeqNo.Control = this.TechSeqNoTextEdit;
            this.ItemForTechSeqNo.CustomizationFormText = "排序";
            this.ItemForTechSeqNo.Location = new System.Drawing.Point(0, 24);
            this.ItemForTechSeqNo.Name = "ItemForTechSeqNo";
            this.ItemForTechSeqNo.Size = new System.Drawing.Size(570, 24);
            this.ItemForTechSeqNo.Text = "排序";
            this.ItemForTechSeqNo.TextSize = new System.Drawing.Size(48, 14);
            // 
            // TechSeqNoTextEdit
            // 
            this.TechSeqNoTextEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.eRPC006ProcessProdInfoBindingSource, "TechSeqNo", true));
            this.TechSeqNoTextEdit.Location = new System.Drawing.Point(64, 36);
            this.TechSeqNoTextEdit.Name = "TechSeqNoTextEdit";
            this.TechSeqNoTextEdit.Size = new System.Drawing.Size(514, 20);
            this.TechSeqNoTextEdit.StyleController = this.dataLayoutControl1;
            this.TechSeqNoTextEdit.TabIndex = 7;
            // 
            // ItemForTechContent
            // 
            this.ItemForTechContent.Control = this.TechContentTextEdit;
            this.ItemForTechContent.CustomizationFormText = "内容";
            this.ItemForTechContent.Location = new System.Drawing.Point(0, 48);
            this.ItemForTechContent.Name = "ItemForTechContent";
            this.ItemForTechContent.Size = new System.Drawing.Size(570, 24);
            this.ItemForTechContent.Text = "内容";
            this.ItemForTechContent.TextSize = new System.Drawing.Size(48, 14);
            // 
            // TechContentTextEdit
            // 
            this.TechContentTextEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.eRPC006ProcessProdInfoBindingSource, "TechContent", true));
            this.TechContentTextEdit.Location = new System.Drawing.Point(64, 60);
            this.TechContentTextEdit.Name = "TechContentTextEdit";
            this.TechContentTextEdit.Size = new System.Drawing.Size(514, 20);
            this.TechContentTextEdit.StyleController = this.dataLayoutControl1;
            this.TechContentTextEdit.TabIndex = 8;
            // 
            // ItemForTechType
            // 
            this.ItemForTechType.Control = this.TechTypeTextEdit;
            this.ItemForTechType.CustomizationFormText = "类型";
            this.ItemForTechType.Location = new System.Drawing.Point(0, 72);
            this.ItemForTechType.Name = "ItemForTechType";
            this.ItemForTechType.Size = new System.Drawing.Size(570, 24);
            this.ItemForTechType.Text = "类型";
            this.ItemForTechType.TextSize = new System.Drawing.Size(48, 14);
            // 
            // TechTypeTextEdit
            // 
            this.TechTypeTextEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.eRPC006ProcessProdInfoBindingSource, "TechType", true));
            this.TechTypeTextEdit.Location = new System.Drawing.Point(64, 84);
            this.TechTypeTextEdit.Name = "TechTypeTextEdit";
            this.TechTypeTextEdit.Size = new System.Drawing.Size(514, 20);
            this.TechTypeTextEdit.StyleController = this.dataLayoutControl1;
            this.TechTypeTextEdit.TabIndex = 9;
            // 
            // ItemForIsVisible
            // 
            this.ItemForIsVisible.Control = this.IsVisibleCheckEdit;
            this.ItemForIsVisible.CustomizationFormText = "Is Visible";
            this.ItemForIsVisible.Location = new System.Drawing.Point(0, 96);
            this.ItemForIsVisible.Name = "ItemForIsVisible";
            this.ItemForIsVisible.Size = new System.Drawing.Size(570, 23);
            this.ItemForIsVisible.Text = "是否可见";
            this.ItemForIsVisible.TextSize = new System.Drawing.Size(48, 14);
            // 
            // IsVisibleCheckEdit
            // 
            this.IsVisibleCheckEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.eRPC006ProcessProdInfoBindingSource, "IsVisible", true));
            this.IsVisibleCheckEdit.Location = new System.Drawing.Point(64, 108);
            this.IsVisibleCheckEdit.Name = "IsVisibleCheckEdit";
            this.IsVisibleCheckEdit.Properties.Caption = "";
            this.IsVisibleCheckEdit.Size = new System.Drawing.Size(514, 19);
            this.IsVisibleCheckEdit.StyleController = this.dataLayoutControl1;
            this.IsVisibleCheckEdit.TabIndex = 10;
            // 
            // ItemForRemarks
            // 
            this.ItemForRemarks.Control = this.RemarksTextEdit;
            this.ItemForRemarks.CustomizationFormText = "备注";
            this.ItemForRemarks.Location = new System.Drawing.Point(0, 119);
            this.ItemForRemarks.Name = "ItemForRemarks";
            this.ItemForRemarks.Size = new System.Drawing.Size(570, 91);
            this.ItemForRemarks.Text = "备注";
            this.ItemForRemarks.TextSize = new System.Drawing.Size(48, 14);
            // 
            // RemarksTextEdit
            // 
            this.RemarksTextEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.eRPC006ProcessProdInfoBindingSource, "Remarks", true));
            this.RemarksTextEdit.Location = new System.Drawing.Point(64, 131);
            this.RemarksTextEdit.Name = "RemarksTextEdit";
            this.RemarksTextEdit.Size = new System.Drawing.Size(514, 87);
            this.RemarksTextEdit.StyleController = this.dataLayoutControl1;
            this.RemarksTextEdit.TabIndex = 11;
            // 
            // emptySpaceItem1
            // 
            this.emptySpaceItem1.AllowHotTrack = false;
            this.emptySpaceItem1.CustomizationFormText = "emptySpaceItem1";
            this.emptySpaceItem1.Location = new System.Drawing.Point(0, 210);
            this.emptySpaceItem1.Name = "emptySpaceItem1";
            this.emptySpaceItem1.Size = new System.Drawing.Size(570, 137);
            this.emptySpaceItem1.Text = "emptySpaceItem1";
            this.emptySpaceItem1.TextSize = new System.Drawing.Size(0, 0);
            // 
            // ItemForProcessCode
            // 
            this.ItemForProcessCode.Control = this.ProcessCodeTextEdit;
            this.ItemForProcessCode.CustomizationFormText = "制程";
            this.ItemForProcessCode.Location = new System.Drawing.Point(0, 0);
            this.ItemForProcessCode.Name = "ItemForProcessCode";
            this.ItemForProcessCode.Size = new System.Drawing.Size(570, 24);
            this.ItemForProcessCode.Text = "制程";
            this.ItemForProcessCode.TextSize = new System.Drawing.Size(48, 14);
            this.ItemForProcessCode.TextToControlDistance = 5;
            // 
            // ProcessCodeTextEdit
            // 
            this.ProcessCodeTextEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.eRPC006ProcessProdInfoBindingSource, "ProcessCode", true));
            this.ProcessCodeTextEdit.Location = new System.Drawing.Point(64, 12);
            this.ProcessCodeTextEdit.Name = "ProcessCodeTextEdit";
            this.ProcessCodeTextEdit.Size = new System.Drawing.Size(514, 20);
            this.ProcessCodeTextEdit.StyleController = this.dataLayoutControl1;
            this.ProcessCodeTextEdit.TabIndex = 5;
            // 
            // C006ProcessProdInfoEditForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(598, 404);
            this.Name = "C006ProcessProdInfoEditForm";
            this.Text = "C006ProcessProdInfoEditForm";
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataLayoutControl1)).EndInit();
            this.dataLayoutControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.eRPC006ProcessProdInfoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForTechCode)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TechCodeTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridLookUpEdit1View)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForTechSeqNo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TechSeqNoTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForTechContent)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TechContentTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForTechType)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TechTypeTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForIsVisible)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.IsVisibleCheckEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForRemarks)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.RemarksTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForProcessCode)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ProcessCodeTextEdit.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.TextEdit ProcessCodeTextEdit;
        private System.Windows.Forms.BindingSource eRPC006ProcessProdInfoBindingSource;
        private DevExpress.XtraEditors.TextEdit TechSeqNoTextEdit;
        private DevExpress.XtraEditors.TextEdit TechContentTextEdit;
        private DevExpress.XtraEditors.TextEdit TechTypeTextEdit;
        private DevExpress.XtraEditors.CheckEdit IsVisibleCheckEdit;
        private DevExpress.XtraEditors.MemoEdit RemarksTextEdit;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup2;
        private DevExpress.XtraLayout.LayoutControlItem ItemForProcessCode;
        private DevExpress.XtraLayout.LayoutControlItem ItemForTechCode;
        private DevExpress.XtraLayout.LayoutControlItem ItemForTechSeqNo;
        private DevExpress.XtraLayout.LayoutControlItem ItemForTechContent;
        private DevExpress.XtraLayout.LayoutControlItem ItemForTechType;
        private DevExpress.XtraLayout.LayoutControlItem ItemForIsVisible;
        private DevExpress.XtraLayout.LayoutControlItem ItemForRemarks;
        private DevExpress.XtraLayout.EmptySpaceItem emptySpaceItem1;
        private DevExpress.XtraEditors.GridLookUpEdit TechCodeTextEdit;
        private DevExpress.XtraGrid.Views.Grid.GridView gridLookUpEdit1View;
    }
}