namespace ERP.Winform.WMS
{
    partial class ShelfEditForm
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
            this.CompCodeTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.wMSC103ShelfBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ItemForCompCode = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlGroup2 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.ItemForSFCode = new DevExpress.XtraLayout.LayoutControlItem();
            this.SFCodeTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.ItemForSFName = new DevExpress.XtraLayout.LayoutControlItem();
            this.SFNameTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.ItemForSeqNo = new DevExpress.XtraLayout.LayoutControlItem();
            this.SeqNoTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.ItemForRemarks = new DevExpress.XtraLayout.LayoutControlItem();
            this.RemarksTextEdit = new DevExpress.XtraEditors.MemoEdit();
            this.layoutControlGroup3 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.ItemForModifyUser = new DevExpress.XtraLayout.LayoutControlItem();
            this.ModifyUserTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.ItemForCreateDt = new DevExpress.XtraLayout.LayoutControlItem();
            this.CreateDtDateEdit = new DevExpress.XtraEditors.DateEdit();
            this.创建 = new DevExpress.XtraLayout.LayoutControlItem();
            this.CreateUserTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.ItemForModifyDt = new DevExpress.XtraLayout.LayoutControlItem();
            this.ModifyDtDateEdit = new DevExpress.XtraEditors.DateEdit();
            this.emptySpaceItem1 = new DevExpress.XtraLayout.EmptySpaceItem();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataLayoutControl1)).BeginInit();
            this.dataLayoutControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CompCodeTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.wMSC103ShelfBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForCompCode)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForSFCode)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SFCodeTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForSFName)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SFNameTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForSeqNo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SeqNoTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForRemarks)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.RemarksTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForModifyUser)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ModifyUserTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForCreateDt)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CreateDtDateEdit.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CreateDtDateEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.创建)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CreateUserTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForModifyDt)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ModifyDtDateEdit.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ModifyDtDateEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem1)).BeginInit();
            this.SuspendLayout();
            // 
            // panelControl1
            // 
            this.panelControl1.Size = new System.Drawing.Size(457, 287);
            // 
            // dataLayoutControl1
            // 
            this.dataLayoutControl1.Controls.Add(this.CompCodeTextEdit);
            this.dataLayoutControl1.Controls.Add(this.SFCodeTextEdit);
            this.dataLayoutControl1.Controls.Add(this.SFNameTextEdit);
            this.dataLayoutControl1.Controls.Add(this.SeqNoTextEdit);
            this.dataLayoutControl1.Controls.Add(this.ModifyUserTextEdit);
            this.dataLayoutControl1.Controls.Add(this.ModifyDtDateEdit);
            this.dataLayoutControl1.Controls.Add(this.CreateUserTextEdit);
            this.dataLayoutControl1.Controls.Add(this.CreateDtDateEdit);
            this.dataLayoutControl1.Controls.Add(this.RemarksTextEdit);
            this.dataLayoutControl1.DataSource = this.wMSC103ShelfBindingSource;
            this.dataLayoutControl1.HiddenItems.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.ItemForCompCode});
            this.dataLayoutControl1.OptionsCustomizationForm.DesignTimeCustomizationFormPositionAndSize = new System.Drawing.Rectangle(584, 214, 250, 350);
            this.dataLayoutControl1.Size = new System.Drawing.Size(453, 283);
            // 
            // layoutControlGroup1
            // 
            this.layoutControlGroup1.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlGroup2});
            this.layoutControlGroup1.Size = new System.Drawing.Size(453, 283);
            // 
            // CompCodeTextEdit
            // 
            this.CompCodeTextEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.wMSC103ShelfBindingSource, "CompCode", true));
            this.CompCodeTextEdit.Location = new System.Drawing.Point(80, 12);
            this.CompCodeTextEdit.Name = "CompCodeTextEdit";
            this.CompCodeTextEdit.Size = new System.Drawing.Size(607, 20);
            this.CompCodeTextEdit.StyleController = this.dataLayoutControl1;
            this.CompCodeTextEdit.TabIndex = 4;
            // 
            // wMSC103ShelfBindingSource
            // 
            this.wMSC103ShelfBindingSource.DataSource = typeof(ERP.Domain.WMS_C103_Shelf);
            // 
            // ItemForCompCode
            // 
            this.ItemForCompCode.Control = this.CompCodeTextEdit;
            this.ItemForCompCode.CustomizationFormText = "Comp Code";
            this.ItemForCompCode.Location = new System.Drawing.Point(0, 0);
            this.ItemForCompCode.Name = "ItemForCompCode";
            this.ItemForCompCode.Size = new System.Drawing.Size(679, 24);
            this.ItemForCompCode.Text = "Comp Code";
            this.ItemForCompCode.TextSize = new System.Drawing.Size(50, 20);
            this.ItemForCompCode.TextToControlDistance = 5;
            // 
            // layoutControlGroup2
            // 
            this.layoutControlGroup2.AllowDrawBackground = false;
            this.layoutControlGroup2.CustomizationFormText = "autoGeneratedGroup0";
            this.layoutControlGroup2.GroupBordersVisible = false;
            this.layoutControlGroup2.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.ItemForSFCode,
            this.ItemForSFName,
            this.ItemForSeqNo,
            this.ItemForRemarks,
            this.layoutControlGroup3,
            this.emptySpaceItem1});
            this.layoutControlGroup2.Location = new System.Drawing.Point(0, 0);
            this.layoutControlGroup2.Name = "autoGeneratedGroup0";
            this.layoutControlGroup2.Size = new System.Drawing.Size(433, 263);
            this.layoutControlGroup2.Text = "autoGeneratedGroup0";
            // 
            // ItemForSFCode
            // 
            this.ItemForSFCode.Control = this.SFCodeTextEdit;
            this.ItemForSFCode.CustomizationFormText = "SF Code";
            this.ItemForSFCode.Location = new System.Drawing.Point(0, 0);
            this.ItemForSFCode.Name = "ItemForSFCode";
            this.ItemForSFCode.Size = new System.Drawing.Size(433, 24);
            this.ItemForSFCode.Text = "货架编号";
            this.ItemForSFCode.TextSize = new System.Drawing.Size(48, 14);
            // 
            // SFCodeTextEdit
            // 
            this.SFCodeTextEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.wMSC103ShelfBindingSource, "SFCode", true));
            this.SFCodeTextEdit.Location = new System.Drawing.Point(64, 12);
            this.SFCodeTextEdit.Name = "SFCodeTextEdit";
            this.SFCodeTextEdit.Size = new System.Drawing.Size(377, 20);
            this.SFCodeTextEdit.StyleController = this.dataLayoutControl1;
            this.SFCodeTextEdit.TabIndex = 5;
            // 
            // ItemForSFName
            // 
            this.ItemForSFName.Control = this.SFNameTextEdit;
            this.ItemForSFName.CustomizationFormText = "SF Name";
            this.ItemForSFName.Location = new System.Drawing.Point(0, 24);
            this.ItemForSFName.Name = "ItemForSFName";
            this.ItemForSFName.Size = new System.Drawing.Size(433, 24);
            this.ItemForSFName.Text = "货架名称";
            this.ItemForSFName.TextSize = new System.Drawing.Size(48, 14);
            // 
            // SFNameTextEdit
            // 
            this.SFNameTextEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.wMSC103ShelfBindingSource, "SFName", true));
            this.SFNameTextEdit.Location = new System.Drawing.Point(64, 36);
            this.SFNameTextEdit.Name = "SFNameTextEdit";
            this.SFNameTextEdit.Size = new System.Drawing.Size(377, 20);
            this.SFNameTextEdit.StyleController = this.dataLayoutControl1;
            this.SFNameTextEdit.TabIndex = 6;
            // 
            // ItemForSeqNo
            // 
            this.ItemForSeqNo.Control = this.SeqNoTextEdit;
            this.ItemForSeqNo.CustomizationFormText = "Seq No";
            this.ItemForSeqNo.Location = new System.Drawing.Point(0, 48);
            this.ItemForSeqNo.Name = "ItemForSeqNo";
            this.ItemForSeqNo.Size = new System.Drawing.Size(433, 24);
            this.ItemForSeqNo.Text = "排序";
            this.ItemForSeqNo.TextSize = new System.Drawing.Size(48, 14);
            // 
            // SeqNoTextEdit
            // 
            this.SeqNoTextEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.wMSC103ShelfBindingSource, "SeqNo", true));
            this.SeqNoTextEdit.Location = new System.Drawing.Point(64, 60);
            this.SeqNoTextEdit.Name = "SeqNoTextEdit";
            this.SeqNoTextEdit.Size = new System.Drawing.Size(377, 20);
            this.SeqNoTextEdit.StyleController = this.dataLayoutControl1;
            this.SeqNoTextEdit.TabIndex = 7;
            // 
            // ItemForRemarks
            // 
            this.ItemForRemarks.Control = this.RemarksTextEdit;
            this.ItemForRemarks.CustomizationFormText = "Remarks";
            this.ItemForRemarks.Location = new System.Drawing.Point(0, 72);
            this.ItemForRemarks.Name = "ItemForRemarks";
            this.ItemForRemarks.Size = new System.Drawing.Size(433, 38);
            this.ItemForRemarks.Text = "备注";
            this.ItemForRemarks.TextSize = new System.Drawing.Size(48, 14);
            // 
            // RemarksTextEdit
            // 
            this.RemarksTextEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.wMSC103ShelfBindingSource, "Remarks", true));
            this.RemarksTextEdit.Location = new System.Drawing.Point(64, 84);
            this.RemarksTextEdit.Name = "RemarksTextEdit";
            this.RemarksTextEdit.Size = new System.Drawing.Size(377, 34);
            this.RemarksTextEdit.StyleController = this.dataLayoutControl1;
            this.RemarksTextEdit.TabIndex = 8;
            // 
            // layoutControlGroup3
            // 
            this.layoutControlGroup3.CustomizationFormText = "layoutControlGroup3";
            this.layoutControlGroup3.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.ItemForModifyUser,
            this.ItemForCreateDt,
            this.创建,
            this.ItemForModifyDt});
            this.layoutControlGroup3.Location = new System.Drawing.Point(0, 191);
            this.layoutControlGroup3.Name = "layoutControlGroup3";
            this.layoutControlGroup3.Size = new System.Drawing.Size(433, 72);
            this.layoutControlGroup3.Text = "layoutControlGroup3";
            this.layoutControlGroup3.TextVisible = false;
            // 
            // ItemForModifyUser
            // 
            this.ItemForModifyUser.Control = this.ModifyUserTextEdit;
            this.ItemForModifyUser.CustomizationFormText = "Modify User";
            this.ItemForModifyUser.Location = new System.Drawing.Point(204, 24);
            this.ItemForModifyUser.Name = "ItemForModifyUser";
            this.ItemForModifyUser.Size = new System.Drawing.Size(205, 24);
            this.ItemForModifyUser.Text = "修改者";
            this.ItemForModifyUser.TextSize = new System.Drawing.Size(48, 14);
            // 
            // ModifyUserTextEdit
            // 
            this.ModifyUserTextEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.wMSC103ShelfBindingSource, "ModifyUser", true));
            this.ModifyUserTextEdit.Location = new System.Drawing.Point(280, 239);
            this.ModifyUserTextEdit.Name = "ModifyUserTextEdit";
            this.ModifyUserTextEdit.Properties.ReadOnly = true;
            this.ModifyUserTextEdit.Size = new System.Drawing.Size(149, 20);
            this.ModifyUserTextEdit.StyleController = this.dataLayoutControl1;
            this.ModifyUserTextEdit.TabIndex = 9;
            // 
            // ItemForCreateDt
            // 
            this.ItemForCreateDt.Control = this.CreateDtDateEdit;
            this.ItemForCreateDt.CustomizationFormText = "创建日期";
            this.ItemForCreateDt.Location = new System.Drawing.Point(0, 0);
            this.ItemForCreateDt.Name = "ItemForCreateDt";
            this.ItemForCreateDt.Size = new System.Drawing.Size(204, 24);
            this.ItemForCreateDt.Text = "创建日期";
            this.ItemForCreateDt.TextSize = new System.Drawing.Size(48, 14);
            // 
            // CreateDtDateEdit
            // 
            this.CreateDtDateEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.wMSC103ShelfBindingSource, "CreateDt", true));
            this.CreateDtDateEdit.EditValue = null;
            this.CreateDtDateEdit.Location = new System.Drawing.Point(76, 215);
            this.CreateDtDateEdit.Name = "CreateDtDateEdit";
            this.CreateDtDateEdit.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.CreateDtDateEdit.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.CreateDtDateEdit.Properties.ReadOnly = true;
            this.CreateDtDateEdit.Size = new System.Drawing.Size(148, 20);
            this.CreateDtDateEdit.StyleController = this.dataLayoutControl1;
            this.CreateDtDateEdit.TabIndex = 12;
            // 
            // 创建
            // 
            this.创建.Control = this.CreateUserTextEdit;
            this.创建.CustomizationFormText = "Create User";
            this.创建.Location = new System.Drawing.Point(204, 0);
            this.创建.Name = "创建";
            this.创建.Size = new System.Drawing.Size(205, 24);
            this.创建.Text = "创建者";
            this.创建.TextSize = new System.Drawing.Size(48, 14);
            // 
            // CreateUserTextEdit
            // 
            this.CreateUserTextEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.wMSC103ShelfBindingSource, "CreateUser", true));
            this.CreateUserTextEdit.Location = new System.Drawing.Point(280, 215);
            this.CreateUserTextEdit.Name = "CreateUserTextEdit";
            this.CreateUserTextEdit.Properties.ReadOnly = true;
            this.CreateUserTextEdit.Size = new System.Drawing.Size(149, 20);
            this.CreateUserTextEdit.StyleController = this.dataLayoutControl1;
            this.CreateUserTextEdit.TabIndex = 11;
            // 
            // ItemForModifyDt
            // 
            this.ItemForModifyDt.Control = this.ModifyDtDateEdit;
            this.ItemForModifyDt.CustomizationFormText = "Modify Dt";
            this.ItemForModifyDt.Location = new System.Drawing.Point(0, 24);
            this.ItemForModifyDt.Name = "ItemForModifyDt";
            this.ItemForModifyDt.Size = new System.Drawing.Size(204, 24);
            this.ItemForModifyDt.Text = "修改日期";
            this.ItemForModifyDt.TextSize = new System.Drawing.Size(48, 14);
            // 
            // ModifyDtDateEdit
            // 
            this.ModifyDtDateEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.wMSC103ShelfBindingSource, "ModifyDt", true));
            this.ModifyDtDateEdit.EditValue = null;
            this.ModifyDtDateEdit.Location = new System.Drawing.Point(76, 239);
            this.ModifyDtDateEdit.Name = "ModifyDtDateEdit";
            this.ModifyDtDateEdit.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.ModifyDtDateEdit.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.ModifyDtDateEdit.Properties.ReadOnly = true;
            this.ModifyDtDateEdit.Size = new System.Drawing.Size(148, 20);
            this.ModifyDtDateEdit.StyleController = this.dataLayoutControl1;
            this.ModifyDtDateEdit.TabIndex = 10;
            // 
            // emptySpaceItem1
            // 
            this.emptySpaceItem1.AllowHotTrack = false;
            this.emptySpaceItem1.CustomizationFormText = "emptySpaceItem1";
            this.emptySpaceItem1.Location = new System.Drawing.Point(0, 110);
            this.emptySpaceItem1.Name = "emptySpaceItem1";
            this.emptySpaceItem1.Size = new System.Drawing.Size(433, 81);
            this.emptySpaceItem1.Text = "emptySpaceItem1";
            this.emptySpaceItem1.TextSize = new System.Drawing.Size(0, 0);
            // 
            // ShelfEditForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(461, 322);
            this.Name = "ShelfEditForm";
            this.Text = "ShelfEditForm";
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataLayoutControl1)).EndInit();
            this.dataLayoutControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CompCodeTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.wMSC103ShelfBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForCompCode)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForSFCode)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SFCodeTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForSFName)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SFNameTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForSeqNo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SeqNoTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForRemarks)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.RemarksTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForModifyUser)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ModifyUserTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForCreateDt)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CreateDtDateEdit.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CreateDtDateEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.创建)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CreateUserTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForModifyDt)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ModifyDtDateEdit.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ModifyDtDateEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.TextEdit CompCodeTextEdit;
        private System.Windows.Forms.BindingSource wMSC103ShelfBindingSource;
        private DevExpress.XtraEditors.TextEdit SFCodeTextEdit;
        private DevExpress.XtraEditors.TextEdit SFNameTextEdit;
        private DevExpress.XtraEditors.TextEdit SeqNoTextEdit;
        private DevExpress.XtraEditors.TextEdit ModifyUserTextEdit;
        private DevExpress.XtraEditors.DateEdit ModifyDtDateEdit;
        private DevExpress.XtraEditors.TextEdit CreateUserTextEdit;
        private DevExpress.XtraEditors.DateEdit CreateDtDateEdit;
        private DevExpress.XtraEditors.MemoEdit RemarksTextEdit;
        private DevExpress.XtraLayout.LayoutControlItem ItemForCompCode;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup2;
        private DevExpress.XtraLayout.LayoutControlItem ItemForSFCode;
        private DevExpress.XtraLayout.LayoutControlItem ItemForSFName;
        private DevExpress.XtraLayout.LayoutControlItem ItemForSeqNo;
        private DevExpress.XtraLayout.LayoutControlItem ItemForRemarks;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup3;
        private DevExpress.XtraLayout.LayoutControlItem ItemForModifyUser;
        private DevExpress.XtraLayout.LayoutControlItem ItemForCreateDt;
        private DevExpress.XtraLayout.LayoutControlItem 创建;
        private DevExpress.XtraLayout.LayoutControlItem ItemForModifyDt;
        private DevExpress.XtraLayout.EmptySpaceItem emptySpaceItem1;
    }
}