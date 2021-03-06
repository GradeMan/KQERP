﻿namespace ERP.Winform.SysModule
{
    partial class SysControlEditForm
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
            this.tbSysControlsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ItemForCompCode = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlGroup2 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.ItemForWindows = new DevExpress.XtraLayout.LayoutControlItem();
            this.WindowsTextEdit = new DevExpress.XtraEditors.ComboBoxEdit();
            this.ItemForControl = new DevExpress.XtraLayout.LayoutControlItem();
            this.ControlTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.ItemForCValue = new DevExpress.XtraLayout.LayoutControlItem();
            this.CValueTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.layoutControlGroup3 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.ItemForModifyDt = new DevExpress.XtraLayout.LayoutControlItem();
            this.ModifyDtDateEdit = new DevExpress.XtraEditors.DateEdit();
            this.ItemForCreateDt = new DevExpress.XtraLayout.LayoutControlItem();
            this.CreateDtDateEdit = new DevExpress.XtraEditors.DateEdit();
            this.ItemForCreateUser = new DevExpress.XtraLayout.LayoutControlItem();
            this.CreateUserTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.ItemForModifyUser = new DevExpress.XtraLayout.LayoutControlItem();
            this.ModifyUserTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.emptySpaceItem1 = new DevExpress.XtraLayout.EmptySpaceItem();
            this.VersionPictureEdit = new DevExpress.XtraEditors.PictureEdit();
            this.ItemForVersion = new DevExpress.XtraLayout.LayoutControlItem();
            this.IdTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.ItemForId = new DevExpress.XtraLayout.LayoutControlItem();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataLayoutControl1)).BeginInit();
            this.dataLayoutControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CompCodeTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbSysControlsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForCompCode)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForWindows)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.WindowsTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ControlTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForCValue)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CValueTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForModifyDt)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ModifyDtDateEdit.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ModifyDtDateEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForCreateDt)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CreateDtDateEdit.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CreateDtDateEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForCreateUser)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CreateUserTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForModifyUser)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ModifyUserTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.VersionPictureEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForVersion)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.IdTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForId)).BeginInit();
            this.SuspendLayout();
            // 
            // panelControl1
            // 
            this.panelControl1.Size = new System.Drawing.Size(506, 309);
            // 
            // dataLayoutControl1
            // 
            this.dataLayoutControl1.Controls.Add(this.CompCodeTextEdit);
            this.dataLayoutControl1.Controls.Add(this.ControlTextEdit);
            this.dataLayoutControl1.Controls.Add(this.CValueTextEdit);
            this.dataLayoutControl1.Controls.Add(this.ModifyDtDateEdit);
            this.dataLayoutControl1.Controls.Add(this.ModifyUserTextEdit);
            this.dataLayoutControl1.Controls.Add(this.CreateDtDateEdit);
            this.dataLayoutControl1.Controls.Add(this.CreateUserTextEdit);
            this.dataLayoutControl1.Controls.Add(this.VersionPictureEdit);
            this.dataLayoutControl1.Controls.Add(this.IdTextEdit);
            this.dataLayoutControl1.Controls.Add(this.WindowsTextEdit);
            this.dataLayoutControl1.DataSource = this.tbSysControlsBindingSource;
            this.dataLayoutControl1.HiddenItems.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.ItemForCompCode,
            this.ItemForVersion,
            this.ItemForId});
            this.dataLayoutControl1.OptionsCustomizationForm.DesignTimeCustomizationFormPositionAndSize = new System.Drawing.Rectangle(584, 214, 250, 350);
            this.dataLayoutControl1.OptionsView.UseDefaultDragAndDropRendering = false;
            this.dataLayoutControl1.Size = new System.Drawing.Size(502, 305);
            // 
            // layoutControlGroup1
            // 
            this.layoutControlGroup1.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlGroup2});
            this.layoutControlGroup1.Size = new System.Drawing.Size(502, 305);
            // 
            // CompCodeTextEdit
            // 
            this.CompCodeTextEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.tbSysControlsBindingSource, "CompCode", true));
            this.CompCodeTextEdit.Location = new System.Drawing.Point(80, 12);
            this.CompCodeTextEdit.Name = "CompCodeTextEdit";
            this.CompCodeTextEdit.Size = new System.Drawing.Size(635, 20);
            this.CompCodeTextEdit.StyleController = this.dataLayoutControl1;
            this.CompCodeTextEdit.TabIndex = 4;
            // 
            // ItemForCompCode
            // 
            this.ItemForCompCode.Control = this.CompCodeTextEdit;
            this.ItemForCompCode.CustomizationFormText = "Comp Code";
            this.ItemForCompCode.Location = new System.Drawing.Point(0, 0);
            this.ItemForCompCode.Name = "ItemForCompCode";
            this.ItemForCompCode.Size = new System.Drawing.Size(707, 24);
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
            this.ItemForWindows,
            this.ItemForControl,
            this.ItemForCValue,
            this.layoutControlGroup3,
            this.emptySpaceItem1});
            this.layoutControlGroup2.Location = new System.Drawing.Point(0, 0);
            this.layoutControlGroup2.Name = "autoGeneratedGroup0";
            this.layoutControlGroup2.Size = new System.Drawing.Size(482, 285);
            this.layoutControlGroup2.Text = "autoGeneratedGroup0";
            // 
            // ItemForWindows
            // 
            this.ItemForWindows.Control = this.WindowsTextEdit;
            this.ItemForWindows.CustomizationFormText = "窗体";
            this.ItemForWindows.Location = new System.Drawing.Point(0, 0);
            this.ItemForWindows.Name = "ItemForWindows";
            this.ItemForWindows.Size = new System.Drawing.Size(482, 24);
            this.ItemForWindows.Text = "窗体";
            this.ItemForWindows.TextSize = new System.Drawing.Size(48, 14);
            // 
            // WindowsTextEdit
            // 
            this.WindowsTextEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.tbSysControlsBindingSource, "Windows", true));
            this.WindowsTextEdit.Location = new System.Drawing.Point(64, 12);
            this.WindowsTextEdit.Name = "WindowsTextEdit";
            this.WindowsTextEdit.Properties.AllowNullInput = DevExpress.Utils.DefaultBoolean.True;
            this.WindowsTextEdit.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.WindowsTextEdit.Properties.ImmediatePopup = true;
            this.WindowsTextEdit.Size = new System.Drawing.Size(426, 20);
            this.WindowsTextEdit.StyleController = this.dataLayoutControl1;
            this.WindowsTextEdit.TabIndex = 5;
            // 
            // ItemForControl
            // 
            this.ItemForControl.Control = this.ControlTextEdit;
            this.ItemForControl.CustomizationFormText = "Control";
            this.ItemForControl.Location = new System.Drawing.Point(0, 24);
            this.ItemForControl.Name = "ItemForControl";
            this.ItemForControl.Size = new System.Drawing.Size(482, 24);
            this.ItemForControl.Text = "对象";
            this.ItemForControl.TextSize = new System.Drawing.Size(48, 14);
            // 
            // ControlTextEdit
            // 
            this.ControlTextEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.tbSysControlsBindingSource, "Control", true));
            this.ControlTextEdit.Location = new System.Drawing.Point(64, 36);
            this.ControlTextEdit.Name = "ControlTextEdit";
            this.ControlTextEdit.Size = new System.Drawing.Size(426, 20);
            this.ControlTextEdit.StyleController = this.dataLayoutControl1;
            this.ControlTextEdit.TabIndex = 6;
            // 
            // ItemForCValue
            // 
            this.ItemForCValue.Control = this.CValueTextEdit;
            this.ItemForCValue.CustomizationFormText = "值";
            this.ItemForCValue.Location = new System.Drawing.Point(0, 48);
            this.ItemForCValue.Name = "ItemForCValue";
            this.ItemForCValue.Size = new System.Drawing.Size(482, 24);
            this.ItemForCValue.Text = "值";
            this.ItemForCValue.TextSize = new System.Drawing.Size(48, 14);
            // 
            // CValueTextEdit
            // 
            this.CValueTextEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.tbSysControlsBindingSource, "CValue", true));
            this.CValueTextEdit.Location = new System.Drawing.Point(64, 60);
            this.CValueTextEdit.Name = "CValueTextEdit";
            this.CValueTextEdit.Size = new System.Drawing.Size(426, 20);
            this.CValueTextEdit.StyleController = this.dataLayoutControl1;
            this.CValueTextEdit.TabIndex = 7;
            // 
            // layoutControlGroup3
            // 
            this.layoutControlGroup3.CustomizationFormText = "layoutControlGroup3";
            this.layoutControlGroup3.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.ItemForModifyDt,
            this.ItemForCreateDt,
            this.ItemForCreateUser,
            this.ItemForModifyUser});
            this.layoutControlGroup3.Location = new System.Drawing.Point(0, 213);
            this.layoutControlGroup3.Name = "layoutControlGroup3";
            this.layoutControlGroup3.Size = new System.Drawing.Size(482, 72);
            this.layoutControlGroup3.Text = "layoutControlGroup3";
            this.layoutControlGroup3.TextVisible = false;
            // 
            // ItemForModifyDt
            // 
            this.ItemForModifyDt.Control = this.ModifyDtDateEdit;
            this.ItemForModifyDt.CustomizationFormText = "修改日期";
            this.ItemForModifyDt.Location = new System.Drawing.Point(0, 24);
            this.ItemForModifyDt.Name = "ItemForModifyDt";
            this.ItemForModifyDt.Size = new System.Drawing.Size(229, 24);
            this.ItemForModifyDt.Text = "修改日期";
            this.ItemForModifyDt.TextSize = new System.Drawing.Size(48, 14);
            // 
            // ModifyDtDateEdit
            // 
            this.ModifyDtDateEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.tbSysControlsBindingSource, "ModifyDt", true));
            this.ModifyDtDateEdit.EditValue = null;
            this.ModifyDtDateEdit.Location = new System.Drawing.Point(76, 261);
            this.ModifyDtDateEdit.Name = "ModifyDtDateEdit";
            this.ModifyDtDateEdit.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.ModifyDtDateEdit.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.ModifyDtDateEdit.Size = new System.Drawing.Size(173, 20);
            this.ModifyDtDateEdit.StyleController = this.dataLayoutControl1;
            this.ModifyDtDateEdit.TabIndex = 8;
            // 
            // ItemForCreateDt
            // 
            this.ItemForCreateDt.Control = this.CreateDtDateEdit;
            this.ItemForCreateDt.CustomizationFormText = "创建日期";
            this.ItemForCreateDt.Location = new System.Drawing.Point(0, 0);
            this.ItemForCreateDt.Name = "ItemForCreateDt";
            this.ItemForCreateDt.Size = new System.Drawing.Size(229, 24);
            this.ItemForCreateDt.Text = "创建日期";
            this.ItemForCreateDt.TextSize = new System.Drawing.Size(48, 14);
            // 
            // CreateDtDateEdit
            // 
            this.CreateDtDateEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.tbSysControlsBindingSource, "CreateDt", true));
            this.CreateDtDateEdit.EditValue = null;
            this.CreateDtDateEdit.Location = new System.Drawing.Point(76, 237);
            this.CreateDtDateEdit.Name = "CreateDtDateEdit";
            this.CreateDtDateEdit.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.CreateDtDateEdit.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.CreateDtDateEdit.Size = new System.Drawing.Size(173, 20);
            this.CreateDtDateEdit.StyleController = this.dataLayoutControl1;
            this.CreateDtDateEdit.TabIndex = 10;
            // 
            // ItemForCreateUser
            // 
            this.ItemForCreateUser.Control = this.CreateUserTextEdit;
            this.ItemForCreateUser.CustomizationFormText = "创建者";
            this.ItemForCreateUser.Location = new System.Drawing.Point(229, 0);
            this.ItemForCreateUser.Name = "ItemForCreateUser";
            this.ItemForCreateUser.Size = new System.Drawing.Size(229, 24);
            this.ItemForCreateUser.Text = "创建者";
            this.ItemForCreateUser.TextSize = new System.Drawing.Size(48, 14);
            // 
            // CreateUserTextEdit
            // 
            this.CreateUserTextEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.tbSysControlsBindingSource, "CreateUser", true));
            this.CreateUserTextEdit.Location = new System.Drawing.Point(305, 237);
            this.CreateUserTextEdit.Name = "CreateUserTextEdit";
            this.CreateUserTextEdit.Size = new System.Drawing.Size(173, 20);
            this.CreateUserTextEdit.StyleController = this.dataLayoutControl1;
            this.CreateUserTextEdit.TabIndex = 11;
            // 
            // ItemForModifyUser
            // 
            this.ItemForModifyUser.Control = this.ModifyUserTextEdit;
            this.ItemForModifyUser.CustomizationFormText = "修改者";
            this.ItemForModifyUser.Location = new System.Drawing.Point(229, 24);
            this.ItemForModifyUser.Name = "ItemForModifyUser";
            this.ItemForModifyUser.Size = new System.Drawing.Size(229, 24);
            this.ItemForModifyUser.Text = "修改者";
            this.ItemForModifyUser.TextSize = new System.Drawing.Size(48, 14);
            // 
            // ModifyUserTextEdit
            // 
            this.ModifyUserTextEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.tbSysControlsBindingSource, "ModifyUser", true));
            this.ModifyUserTextEdit.Location = new System.Drawing.Point(305, 261);
            this.ModifyUserTextEdit.Name = "ModifyUserTextEdit";
            this.ModifyUserTextEdit.Size = new System.Drawing.Size(173, 20);
            this.ModifyUserTextEdit.StyleController = this.dataLayoutControl1;
            this.ModifyUserTextEdit.TabIndex = 9;
            // 
            // emptySpaceItem1
            // 
            this.emptySpaceItem1.AllowHotTrack = false;
            this.emptySpaceItem1.CustomizationFormText = "emptySpaceItem1";
            this.emptySpaceItem1.Location = new System.Drawing.Point(0, 72);
            this.emptySpaceItem1.Name = "emptySpaceItem1";
            this.emptySpaceItem1.Size = new System.Drawing.Size(482, 141);
            this.emptySpaceItem1.Text = "emptySpaceItem1";
            this.emptySpaceItem1.TextSize = new System.Drawing.Size(0, 0);
            // 
            // VersionPictureEdit
            // 
            this.VersionPictureEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.tbSysControlsBindingSource, "Version", true));
            this.VersionPictureEdit.Location = new System.Drawing.Point(80, 180);
            this.VersionPictureEdit.Name = "VersionPictureEdit";
            this.VersionPictureEdit.Size = new System.Drawing.Size(635, 142);
            this.VersionPictureEdit.StyleController = this.dataLayoutControl1;
            this.VersionPictureEdit.TabIndex = 12;
            // 
            // ItemForVersion
            // 
            this.ItemForVersion.Control = this.VersionPictureEdit;
            this.ItemForVersion.CustomizationFormText = "Version";
            this.ItemForVersion.Location = new System.Drawing.Point(0, 168);
            this.ItemForVersion.Name = "ItemForVersion";
            this.ItemForVersion.Size = new System.Drawing.Size(707, 146);
            this.ItemForVersion.Text = "Version";
            this.ItemForVersion.TextSize = new System.Drawing.Size(50, 20);
            this.ItemForVersion.TextToControlDistance = 5;
            // 
            // IdTextEdit
            // 
            this.IdTextEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.tbSysControlsBindingSource, "Id", true));
            this.IdTextEdit.Location = new System.Drawing.Point(80, 180);
            this.IdTextEdit.Name = "IdTextEdit";
            this.IdTextEdit.Size = new System.Drawing.Size(635, 20);
            this.IdTextEdit.StyleController = this.dataLayoutControl1;
            this.IdTextEdit.TabIndex = 13;
            // 
            // ItemForId
            // 
            this.ItemForId.Control = this.IdTextEdit;
            this.ItemForId.CustomizationFormText = "Id";
            this.ItemForId.Location = new System.Drawing.Point(0, 168);
            this.ItemForId.Name = "ItemForId";
            this.ItemForId.Size = new System.Drawing.Size(707, 170);
            this.ItemForId.Text = "Id";
            this.ItemForId.TextSize = new System.Drawing.Size(50, 20);
            this.ItemForId.TextToControlDistance = 5;
            // 
            // SysControlEditForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(510, 344);
            this.Name = "SysControlEditForm";
            this.Text = "SysControlEditForm";
            this.Load += new System.EventHandler(this.SysControlEditForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataLayoutControl1)).EndInit();
            this.dataLayoutControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CompCodeTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbSysControlsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForCompCode)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForWindows)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.WindowsTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ControlTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForCValue)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CValueTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForModifyDt)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ModifyDtDateEdit.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ModifyDtDateEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForCreateDt)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CreateDtDateEdit.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CreateDtDateEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForCreateUser)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CreateUserTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForModifyUser)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ModifyUserTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.VersionPictureEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForVersion)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.IdTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForId)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.TextEdit CompCodeTextEdit;
        private System.Windows.Forms.BindingSource tbSysControlsBindingSource;
        private DevExpress.XtraEditors.TextEdit ControlTextEdit;
        private DevExpress.XtraEditors.TextEdit CValueTextEdit;
        private DevExpress.XtraEditors.DateEdit ModifyDtDateEdit;
        private DevExpress.XtraEditors.TextEdit ModifyUserTextEdit;
        private DevExpress.XtraEditors.DateEdit CreateDtDateEdit;
        private DevExpress.XtraEditors.TextEdit CreateUserTextEdit;
        private DevExpress.XtraEditors.PictureEdit VersionPictureEdit;
        private DevExpress.XtraEditors.TextEdit IdTextEdit;
        private DevExpress.XtraLayout.LayoutControlItem ItemForCompCode;
        private DevExpress.XtraLayout.LayoutControlItem ItemForVersion;
        private DevExpress.XtraLayout.LayoutControlItem ItemForId;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup2;
        private DevExpress.XtraLayout.LayoutControlItem ItemForWindows;
        private DevExpress.XtraLayout.LayoutControlItem ItemForControl;
        private DevExpress.XtraLayout.LayoutControlItem ItemForCValue;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup3;
        private DevExpress.XtraLayout.LayoutControlItem ItemForModifyDt;
        private DevExpress.XtraLayout.LayoutControlItem ItemForCreateDt;
        private DevExpress.XtraLayout.LayoutControlItem ItemForCreateUser;
        private DevExpress.XtraLayout.LayoutControlItem ItemForModifyUser;
        private DevExpress.XtraLayout.EmptySpaceItem emptySpaceItem1;
        private DevExpress.XtraEditors.ComboBoxEdit WindowsTextEdit;
    }
}