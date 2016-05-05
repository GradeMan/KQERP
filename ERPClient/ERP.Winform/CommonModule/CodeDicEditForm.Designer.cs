namespace ERP.Winform.CommonModule
{
    partial class CodeDicEditForm
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
            this.eRPC001CodeDictionaryBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.layoutControlGroup2 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.ItemForParentId = new DevExpress.XtraLayout.LayoutControlItem();
            this.ParentIdTextEdit = new DevExpress.XtraEditors.GridLookUpEdit();
            this.gridLookUpEdit1View = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.ItemForCode = new DevExpress.XtraLayout.LayoutControlItem();
            this.CodeTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.ItemForFullName = new DevExpress.XtraLayout.LayoutControlItem();
            this.FullNameTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.ItemForRemark = new DevExpress.XtraLayout.LayoutControlItem();
            this.RemarkTextEdit = new DevExpress.XtraEditors.MemoEdit();
            this.ItemForSortCode = new DevExpress.XtraLayout.LayoutControlItem();
            this.SortCodeTextEdit = new DevExpress.XtraEditors.TextEdit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataLayoutControl1)).BeginInit();
            this.dataLayoutControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.eRPC001CodeDictionaryBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForParentId)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ParentIdTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridLookUpEdit1View)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForCode)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CodeTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForFullName)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.FullNameTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForRemark)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.RemarkTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForSortCode)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SortCodeTextEdit.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // panelControl1
            // 
            this.panelControl1.Size = new System.Drawing.Size(432, 276);
            // 
            // dataLayoutControl1
            // 
            this.dataLayoutControl1.Controls.Add(this.CodeTextEdit);
            this.dataLayoutControl1.Controls.Add(this.FullNameTextEdit);
            this.dataLayoutControl1.Controls.Add(this.SortCodeTextEdit);
            this.dataLayoutControl1.Controls.Add(this.ParentIdTextEdit);
            this.dataLayoutControl1.Controls.Add(this.RemarkTextEdit);
            this.dataLayoutControl1.DataSource = this.eRPC001CodeDictionaryBindingSource;
            this.dataLayoutControl1.OptionsCustomizationForm.DesignTimeCustomizationFormPositionAndSize = new System.Drawing.Rectangle(584, 214, 250, 350);
            this.dataLayoutControl1.Size = new System.Drawing.Size(428, 272);
            // 
            // layoutControlGroup1
            // 
            this.layoutControlGroup1.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlGroup2});
            this.layoutControlGroup1.Size = new System.Drawing.Size(428, 272);
            // 
            // eRPC001CodeDictionaryBindingSource
            // 
            this.eRPC001CodeDictionaryBindingSource.DataSource = typeof(ERP.Domain.ERP_C001_CodeDictionary);
            // 
            // layoutControlGroup2
            // 
            this.layoutControlGroup2.AllowDrawBackground = false;
            this.layoutControlGroup2.CustomizationFormText = "autoGeneratedGroup0";
            this.layoutControlGroup2.GroupBordersVisible = false;
            this.layoutControlGroup2.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.ItemForParentId,
            this.ItemForCode,
            this.ItemForFullName,
            this.ItemForRemark,
            this.ItemForSortCode});
            this.layoutControlGroup2.Location = new System.Drawing.Point(0, 0);
            this.layoutControlGroup2.Name = "autoGeneratedGroup0";
            this.layoutControlGroup2.Size = new System.Drawing.Size(408, 252);
            this.layoutControlGroup2.Text = "autoGeneratedGroup0";
            // 
            // ItemForParentId
            // 
            this.ItemForParentId.Control = this.ParentIdTextEdit;
            this.ItemForParentId.CustomizationFormText = "父菜单";
            this.ItemForParentId.Location = new System.Drawing.Point(0, 0);
            this.ItemForParentId.Name = "ItemForParentId";
            this.ItemForParentId.Size = new System.Drawing.Size(408, 24);
            this.ItemForParentId.Text = "父菜单";
            this.ItemForParentId.TextSize = new System.Drawing.Size(48, 14);
            // 
            // ParentIdTextEdit
            // 
            this.ParentIdTextEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.eRPC001CodeDictionaryBindingSource, "ParentId", true));
            this.ParentIdTextEdit.Location = new System.Drawing.Point(64, 12);
            this.ParentIdTextEdit.Name = "ParentIdTextEdit";
            this.ParentIdTextEdit.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.ParentIdTextEdit.Properties.NullText = "";
            this.ParentIdTextEdit.Properties.View = this.gridLookUpEdit1View;
            this.ParentIdTextEdit.Size = new System.Drawing.Size(352, 20);
            this.ParentIdTextEdit.StyleController = this.dataLayoutControl1;
            this.ParentIdTextEdit.TabIndex = 5;
            // 
            // gridLookUpEdit1View
            // 
            this.gridLookUpEdit1View.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.gridLookUpEdit1View.Name = "gridLookUpEdit1View";
            this.gridLookUpEdit1View.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.gridLookUpEdit1View.OptionsView.ShowGroupPanel = false;
            // 
            // ItemForCode
            // 
            this.ItemForCode.Control = this.CodeTextEdit;
            this.ItemForCode.CustomizationFormText = "类别代号";
            this.ItemForCode.Location = new System.Drawing.Point(0, 24);
            this.ItemForCode.Name = "ItemForCode";
            this.ItemForCode.Size = new System.Drawing.Size(408, 24);
            this.ItemForCode.Text = "类别代号";
            this.ItemForCode.TextSize = new System.Drawing.Size(48, 14);
            // 
            // CodeTextEdit
            // 
            this.CodeTextEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.eRPC001CodeDictionaryBindingSource, "Code", true));
            this.CodeTextEdit.Location = new System.Drawing.Point(64, 36);
            this.CodeTextEdit.Name = "CodeTextEdit";
            this.CodeTextEdit.Size = new System.Drawing.Size(352, 20);
            this.CodeTextEdit.StyleController = this.dataLayoutControl1;
            this.CodeTextEdit.TabIndex = 8;
            // 
            // ItemForFullName
            // 
            this.ItemForFullName.Control = this.FullNameTextEdit;
            this.ItemForFullName.CustomizationFormText = "类别名称";
            this.ItemForFullName.Location = new System.Drawing.Point(0, 48);
            this.ItemForFullName.Name = "ItemForFullName";
            this.ItemForFullName.Size = new System.Drawing.Size(408, 24);
            this.ItemForFullName.Text = "类别名称";
            this.ItemForFullName.TextSize = new System.Drawing.Size(48, 14);
            // 
            // FullNameTextEdit
            // 
            this.FullNameTextEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.eRPC001CodeDictionaryBindingSource, "FullName", true));
            this.FullNameTextEdit.Location = new System.Drawing.Point(64, 60);
            this.FullNameTextEdit.Name = "FullNameTextEdit";
            this.FullNameTextEdit.Size = new System.Drawing.Size(352, 20);
            this.FullNameTextEdit.StyleController = this.dataLayoutControl1;
            this.FullNameTextEdit.TabIndex = 9;
            // 
            // ItemForRemark
            // 
            this.ItemForRemark.Control = this.RemarkTextEdit;
            this.ItemForRemark.CustomizationFormText = "备注";
            this.ItemForRemark.Location = new System.Drawing.Point(0, 96);
            this.ItemForRemark.Name = "ItemForRemark";
            this.ItemForRemark.Size = new System.Drawing.Size(408, 156);
            this.ItemForRemark.Text = "备注";
            this.ItemForRemark.TextSize = new System.Drawing.Size(48, 14);
            // 
            // RemarkTextEdit
            // 
            this.RemarkTextEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.eRPC001CodeDictionaryBindingSource, "Remark", true));
            this.RemarkTextEdit.Location = new System.Drawing.Point(64, 108);
            this.RemarkTextEdit.Name = "RemarkTextEdit";
            this.RemarkTextEdit.Size = new System.Drawing.Size(352, 152);
            this.RemarkTextEdit.StyleController = this.dataLayoutControl1;
            this.RemarkTextEdit.TabIndex = 10;
            // 
            // ItemForSortCode
            // 
            this.ItemForSortCode.Control = this.SortCodeTextEdit;
            this.ItemForSortCode.CustomizationFormText = "排序";
            this.ItemForSortCode.Location = new System.Drawing.Point(0, 72);
            this.ItemForSortCode.Name = "ItemForSortCode";
            this.ItemForSortCode.Size = new System.Drawing.Size(408, 24);
            this.ItemForSortCode.Text = "排序";
            this.ItemForSortCode.TextSize = new System.Drawing.Size(48, 14);
            // 
            // SortCodeTextEdit
            // 
            this.SortCodeTextEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.eRPC001CodeDictionaryBindingSource, "SortCode", true));
            this.SortCodeTextEdit.Location = new System.Drawing.Point(64, 84);
            this.SortCodeTextEdit.Name = "SortCodeTextEdit";
            this.SortCodeTextEdit.Size = new System.Drawing.Size(352, 20);
            this.SortCodeTextEdit.StyleController = this.dataLayoutControl1;
            this.SortCodeTextEdit.TabIndex = 12;
            // 
            // CodeDicEditForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(436, 309);
            this.Name = "CodeDicEditForm";
            this.Text = "CodeDicEditForm";
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataLayoutControl1)).EndInit();
            this.dataLayoutControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.eRPC001CodeDictionaryBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForParentId)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ParentIdTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridLookUpEdit1View)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForCode)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CodeTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForFullName)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.FullNameTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForRemark)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.RemarkTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForSortCode)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SortCodeTextEdit.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.BindingSource eRPC001CodeDictionaryBindingSource;
        private DevExpress.XtraEditors.TextEdit CodeTextEdit;
        private DevExpress.XtraEditors.TextEdit FullNameTextEdit;
        private DevExpress.XtraEditors.TextEdit SortCodeTextEdit;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup2;
        private DevExpress.XtraLayout.LayoutControlItem ItemForParentId;
        private DevExpress.XtraLayout.LayoutControlItem ItemForCode;
        private DevExpress.XtraLayout.LayoutControlItem ItemForFullName;
        private DevExpress.XtraLayout.LayoutControlItem ItemForRemark;
        private DevExpress.XtraLayout.LayoutControlItem ItemForSortCode;
        private DevExpress.XtraEditors.GridLookUpEdit ParentIdTextEdit;
        private DevExpress.XtraGrid.Views.Grid.GridView gridLookUpEdit1View;
        private DevExpress.XtraEditors.MemoEdit RemarkTextEdit;
    }
}