﻿namespace ERP.Winform.ESOP
{
    partial class ESOPPublishEditForm
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
            this.eSOPPublishBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ItemForDevId = new DevExpress.XtraLayout.LayoutControlItem();
            this.DevIdTextEdit = new DevExpress.XtraEditors.GridLookUpEdit();
            this.gridLookUpEdit1View = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.layoutControlGroup2 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.ItemForDocId = new DevExpress.XtraLayout.LayoutControlItem();
            this.DocIdTextEdit = new DevExpress.XtraEditors.GridLookUpEdit();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.ItemForDocIndexId = new DevExpress.XtraLayout.LayoutControlItem();
            this.DocIndexIdTextEdit = new DevExpress.XtraEditors.GridLookUpEdit();
            this.gridView2 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.ItemForEffectiveDt = new DevExpress.XtraLayout.LayoutControlItem();
            this.EffectiveDtDateEdit = new DevExpress.XtraEditors.DateEdit();
            this.ItemForExpireDt = new DevExpress.XtraLayout.LayoutControlItem();
            this.ExpireDtDateEdit = new DevExpress.XtraEditors.DateEdit();
            this.ItemForState = new DevExpress.XtraLayout.LayoutControlItem();
            this.StateTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.ItemForPartNo = new DevExpress.XtraLayout.LayoutControlItem();
            this.PartNoTextEdit = new DevExpress.XtraEditors.TextEdit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataLayoutControl1)).BeginInit();
            this.dataLayoutControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.eSOPPublishBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForDevId)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DevIdTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridLookUpEdit1View)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForDocId)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DocIdTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForDocIndexId)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DocIndexIdTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForEffectiveDt)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.EffectiveDtDateEdit.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.EffectiveDtDateEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForExpireDt)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ExpireDtDateEdit.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ExpireDtDateEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForState)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.StateTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForPartNo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PartNoTextEdit.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // panelControl1
            // 
            this.panelControl1.Size = new System.Drawing.Size(498, 229);
            // 
            // dataLayoutControl1
            // 
            this.dataLayoutControl1.Controls.Add(this.EffectiveDtDateEdit);
            this.dataLayoutControl1.Controls.Add(this.ExpireDtDateEdit);
            this.dataLayoutControl1.Controls.Add(this.StateTextEdit);
            this.dataLayoutControl1.Controls.Add(this.PartNoTextEdit);
            this.dataLayoutControl1.Controls.Add(this.DevIdTextEdit);
            this.dataLayoutControl1.Controls.Add(this.DocIdTextEdit);
            this.dataLayoutControl1.Controls.Add(this.DocIndexIdTextEdit);
            this.dataLayoutControl1.DataSource = this.eSOPPublishBindingSource;
            this.dataLayoutControl1.OptionsCustomizationForm.DesignTimeCustomizationFormPositionAndSize = new System.Drawing.Rectangle(584, 214, 250, 350);
            this.dataLayoutControl1.Size = new System.Drawing.Size(494, 225);
            // 
            // layoutControlGroup1
            // 
            this.layoutControlGroup1.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlGroup2});
            this.layoutControlGroup1.Size = new System.Drawing.Size(494, 225);
            // 
            // eSOPPublishBindingSource
            // 
            this.eSOPPublishBindingSource.DataSource = typeof(ERP.Domain.ESOP_Publish);
            // 
            // ItemForDevId
            // 
            this.ItemForDevId.Control = this.DevIdTextEdit;
            this.ItemForDevId.CustomizationFormText = "Dev Id";
            this.ItemForDevId.Location = new System.Drawing.Point(0, 0);
            this.ItemForDevId.Name = "ItemForDevId";
            this.ItemForDevId.Size = new System.Drawing.Size(474, 24);
            this.ItemForDevId.Text = "设备名称";
            this.ItemForDevId.TextSize = new System.Drawing.Size(48, 14);
            // 
            // DevIdTextEdit
            // 
            this.DevIdTextEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.eSOPPublishBindingSource, "DevId", true));
            this.DevIdTextEdit.Location = new System.Drawing.Point(64, 12);
            this.DevIdTextEdit.Name = "DevIdTextEdit";
            this.DevIdTextEdit.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.DevIdTextEdit.Properties.NullText = "";
            this.DevIdTextEdit.Properties.View = this.gridLookUpEdit1View;
            this.DevIdTextEdit.Size = new System.Drawing.Size(418, 20);
            this.DevIdTextEdit.StyleController = this.dataLayoutControl1;
            this.DevIdTextEdit.TabIndex = 4;
            // 
            // gridLookUpEdit1View
            // 
            this.gridLookUpEdit1View.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.gridLookUpEdit1View.Name = "gridLookUpEdit1View";
            this.gridLookUpEdit1View.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.gridLookUpEdit1View.OptionsView.ShowGroupPanel = false;
            // 
            // layoutControlGroup2
            // 
            this.layoutControlGroup2.AllowDrawBackground = false;
            this.layoutControlGroup2.CustomizationFormText = "autoGeneratedGroup0";
            this.layoutControlGroup2.GroupBordersVisible = false;
            this.layoutControlGroup2.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.ItemForDevId,
            this.ItemForDocId,
            this.ItemForDocIndexId,
            this.ItemForEffectiveDt,
            this.ItemForExpireDt,
            this.ItemForState,
            this.ItemForPartNo});
            this.layoutControlGroup2.Location = new System.Drawing.Point(0, 0);
            this.layoutControlGroup2.Name = "autoGeneratedGroup0";
            this.layoutControlGroup2.Size = new System.Drawing.Size(474, 205);
            this.layoutControlGroup2.Text = "autoGeneratedGroup0";
            // 
            // ItemForDocId
            // 
            this.ItemForDocId.Control = this.DocIdTextEdit;
            this.ItemForDocId.CustomizationFormText = "Doc Id";
            this.ItemForDocId.Location = new System.Drawing.Point(0, 24);
            this.ItemForDocId.Name = "ItemForDocId";
            this.ItemForDocId.Size = new System.Drawing.Size(474, 24);
            this.ItemForDocId.Text = "文档名称";
            this.ItemForDocId.TextSize = new System.Drawing.Size(48, 14);
            // 
            // DocIdTextEdit
            // 
            this.DocIdTextEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.eSOPPublishBindingSource, "DocId", true));
            this.DocIdTextEdit.Location = new System.Drawing.Point(64, 36);
            this.DocIdTextEdit.Name = "DocIdTextEdit";
            this.DocIdTextEdit.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.DocIdTextEdit.Properties.NullText = "";
            this.DocIdTextEdit.Properties.View = this.gridView1;
            this.DocIdTextEdit.Size = new System.Drawing.Size(418, 20);
            this.DocIdTextEdit.StyleController = this.dataLayoutControl1;
            this.DocIdTextEdit.TabIndex = 5;
            // 
            // gridView1
            // 
            this.gridView1.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.gridView1.OptionsView.ShowGroupPanel = false;
            // 
            // ItemForDocIndexId
            // 
            this.ItemForDocIndexId.Control = this.DocIndexIdTextEdit;
            this.ItemForDocIndexId.CustomizationFormText = "Doc Index Id";
            this.ItemForDocIndexId.Location = new System.Drawing.Point(0, 48);
            this.ItemForDocIndexId.Name = "ItemForDocIndexId";
            this.ItemForDocIndexId.Size = new System.Drawing.Size(474, 24);
            this.ItemForDocIndexId.Text = "文档目录";
            this.ItemForDocIndexId.TextSize = new System.Drawing.Size(48, 14);
            // 
            // DocIndexIdTextEdit
            // 
            this.DocIndexIdTextEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.eSOPPublishBindingSource, "DocIndexId", true));
            this.DocIndexIdTextEdit.Location = new System.Drawing.Point(64, 60);
            this.DocIndexIdTextEdit.Name = "DocIndexIdTextEdit";
            this.DocIndexIdTextEdit.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.DocIndexIdTextEdit.Properties.NullText = "";
            this.DocIndexIdTextEdit.Properties.View = this.gridView2;
            this.DocIndexIdTextEdit.Size = new System.Drawing.Size(418, 20);
            this.DocIndexIdTextEdit.StyleController = this.dataLayoutControl1;
            this.DocIndexIdTextEdit.TabIndex = 6;
            this.DocIndexIdTextEdit.EditValueChanged += new System.EventHandler(this.DocIndexIdTextEdit_EditValueChanged);
            // 
            // gridView2
            // 
            this.gridView2.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.gridView2.Name = "gridView2";
            this.gridView2.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.gridView2.OptionsView.ShowGroupPanel = false;
            // 
            // ItemForEffectiveDt
            // 
            this.ItemForEffectiveDt.Control = this.EffectiveDtDateEdit;
            this.ItemForEffectiveDt.CustomizationFormText = "Effective Dt";
            this.ItemForEffectiveDt.Location = new System.Drawing.Point(0, 72);
            this.ItemForEffectiveDt.Name = "ItemForEffectiveDt";
            this.ItemForEffectiveDt.Size = new System.Drawing.Size(474, 24);
            this.ItemForEffectiveDt.Text = "生效日期";
            this.ItemForEffectiveDt.TextSize = new System.Drawing.Size(48, 14);
            // 
            // EffectiveDtDateEdit
            // 
            this.EffectiveDtDateEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.eSOPPublishBindingSource, "EffectiveDt", true));
            this.EffectiveDtDateEdit.EditValue = null;
            this.EffectiveDtDateEdit.Location = new System.Drawing.Point(64, 84);
            this.EffectiveDtDateEdit.Name = "EffectiveDtDateEdit";
            this.EffectiveDtDateEdit.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.EffectiveDtDateEdit.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.EffectiveDtDateEdit.Size = new System.Drawing.Size(418, 20);
            this.EffectiveDtDateEdit.StyleController = this.dataLayoutControl1;
            this.EffectiveDtDateEdit.TabIndex = 7;
            // 
            // ItemForExpireDt
            // 
            this.ItemForExpireDt.Control = this.ExpireDtDateEdit;
            this.ItemForExpireDt.CustomizationFormText = "Expire Dt";
            this.ItemForExpireDt.Location = new System.Drawing.Point(0, 96);
            this.ItemForExpireDt.Name = "ItemForExpireDt";
            this.ItemForExpireDt.Size = new System.Drawing.Size(474, 24);
            this.ItemForExpireDt.Text = "失效日期";
            this.ItemForExpireDt.TextSize = new System.Drawing.Size(48, 14);
            // 
            // ExpireDtDateEdit
            // 
            this.ExpireDtDateEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.eSOPPublishBindingSource, "ExpireDt", true));
            this.ExpireDtDateEdit.EditValue = null;
            this.ExpireDtDateEdit.Location = new System.Drawing.Point(64, 108);
            this.ExpireDtDateEdit.Name = "ExpireDtDateEdit";
            this.ExpireDtDateEdit.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.ExpireDtDateEdit.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.ExpireDtDateEdit.Size = new System.Drawing.Size(418, 20);
            this.ExpireDtDateEdit.StyleController = this.dataLayoutControl1;
            this.ExpireDtDateEdit.TabIndex = 8;
            // 
            // ItemForState
            // 
            this.ItemForState.Control = this.StateTextEdit;
            this.ItemForState.CustomizationFormText = "State";
            this.ItemForState.Location = new System.Drawing.Point(0, 120);
            this.ItemForState.Name = "ItemForState";
            this.ItemForState.Size = new System.Drawing.Size(474, 24);
            this.ItemForState.Text = "状态";
            this.ItemForState.TextSize = new System.Drawing.Size(48, 14);
            // 
            // StateTextEdit
            // 
            this.StateTextEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.eSOPPublishBindingSource, "State", true));
            this.StateTextEdit.Location = new System.Drawing.Point(64, 132);
            this.StateTextEdit.Name = "StateTextEdit";
            this.StateTextEdit.Size = new System.Drawing.Size(418, 20);
            this.StateTextEdit.StyleController = this.dataLayoutControl1;
            this.StateTextEdit.TabIndex = 9;
            // 
            // ItemForPartNo
            // 
            this.ItemForPartNo.Control = this.PartNoTextEdit;
            this.ItemForPartNo.CustomizationFormText = "Part No";
            this.ItemForPartNo.Location = new System.Drawing.Point(0, 144);
            this.ItemForPartNo.Name = "ItemForPartNo";
            this.ItemForPartNo.Size = new System.Drawing.Size(474, 61);
            this.ItemForPartNo.Text = "产品";
            this.ItemForPartNo.TextSize = new System.Drawing.Size(48, 14);
            // 
            // PartNoTextEdit
            // 
            this.PartNoTextEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.eSOPPublishBindingSource, "PartNo", true));
            this.PartNoTextEdit.Location = new System.Drawing.Point(64, 156);
            this.PartNoTextEdit.Name = "PartNoTextEdit";
            this.PartNoTextEdit.Size = new System.Drawing.Size(418, 20);
            this.PartNoTextEdit.StyleController = this.dataLayoutControl1;
            this.PartNoTextEdit.TabIndex = 10;
            // 
            // ESOPPublishEditForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(502, 264);
            this.Name = "ESOPPublishEditForm";
            this.Text = "ESOPPublishEditForm";
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataLayoutControl1)).EndInit();
            this.dataLayoutControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.eSOPPublishBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForDevId)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DevIdTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridLookUpEdit1View)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForDocId)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DocIdTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForDocIndexId)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DocIndexIdTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForEffectiveDt)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.EffectiveDtDateEdit.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.EffectiveDtDateEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForExpireDt)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ExpireDtDateEdit.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ExpireDtDateEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForState)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.StateTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForPartNo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PartNoTextEdit.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.BindingSource eSOPPublishBindingSource;
        private DevExpress.XtraEditors.DateEdit EffectiveDtDateEdit;
        private DevExpress.XtraEditors.DateEdit ExpireDtDateEdit;
        private DevExpress.XtraEditors.TextEdit StateTextEdit;
        private DevExpress.XtraEditors.TextEdit PartNoTextEdit;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup2;
        private DevExpress.XtraLayout.LayoutControlItem ItemForDevId;
        private DevExpress.XtraLayout.LayoutControlItem ItemForDocId;
        private DevExpress.XtraLayout.LayoutControlItem ItemForDocIndexId;
        private DevExpress.XtraLayout.LayoutControlItem ItemForEffectiveDt;
        private DevExpress.XtraLayout.LayoutControlItem ItemForExpireDt;
        private DevExpress.XtraLayout.LayoutControlItem ItemForState;
        private DevExpress.XtraLayout.LayoutControlItem ItemForPartNo;
        private DevExpress.XtraEditors.GridLookUpEdit DevIdTextEdit;
        private DevExpress.XtraGrid.Views.Grid.GridView gridLookUpEdit1View;
        private DevExpress.XtraEditors.GridLookUpEdit DocIdTextEdit;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraEditors.GridLookUpEdit DocIndexIdTextEdit;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView2;
    }
}