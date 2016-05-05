using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using COM.Winform;
using COM.Service;
using ERP.Domain;
using ERP.Service;
namespace ERP.Winform.SysModule
{
    public partial class SysButtonEditForm : EditForm
    {
        private Itb_Sys_ButtonService roleService = Unity.Instance.GetService<Itb_Sys_ButtonService>();
        public SysButtonEditForm(tb_Sys_Button ButtonData)
        {
            InitializeComponent();
            tbSysButtonBindingSource.DataSource = ButtonData;
        }
       
        protected override void OnSetLayoutItemStyle()
        {
            ERPHelper.Instance.ApplyBindingSettings(ItemForBtn_Name, ItemBindingType.Required);
        }

        protected override void OnBtnCommand(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            tbSysButtonBindingSource.EndEdit();
            var ButtonData = tbSysButtonBindingSource.DataSource as tb_Sys_Button;
            if (e.Item.Caption == BtnCommandEnum.Save)
            {
                if (this.Tag.ToString() == BtnCommandEnum.Add)
                    roleService.Createtb_Sys_Button(ButtonData);
                else if (this.Tag.ToString() == BtnCommandEnum.Edit)
                    roleService.Updatetb_Sys_Button(ButtonData);
                DialogResult = DialogResult.OK;
            }
            if (e.Item.Caption == BtnCommandEnum.Cancel)
                DialogResult = DialogResult.Cancel;
        }

        private void Btn_IconPictureEdit_EditValueChanged(object sender, EventArgs e)
        {
            var ButtonData = tbSysButtonBindingSource.DataSource as tb_Sys_Button;
            ButtonData.Btn_Icon = ERPHelper.Instance.ImageToBuffer(Btn_IconPictureEdit.Image);
        }

        private void SysButtonEditForm_Load(object sender, EventArgs e)
        {
            //Type enumType = typeof(BtnCommandEnum);
            //foreach (string str in Enum.GetNames(enumType))
            //{
            //    Btn_NameTextEdit.Properties.Items.Add(str);
            //}
            Btn_NameTextEdit.Properties.Items.Add(BtnCommandEnum.Add);
            Btn_NameTextEdit.Properties.Items.Add(BtnCommandEnum.Edit);
            Btn_NameTextEdit.Properties.Items.Add(BtnCommandEnum.Save);
            Btn_NameTextEdit.Properties.Items.Add(BtnCommandEnum.Cancel);
            Btn_NameTextEdit.Properties.Items.Add(BtnCommandEnum.Delete);
            Btn_NameTextEdit.Properties.Items.Add(BtnCommandEnum.Print);
            Btn_NameTextEdit.Properties.Items.Add(BtnCommandEnum.AddDir);
            Btn_NameTextEdit.Properties.Items.Add(BtnCommandEnum.AddFile);
            Btn_NameTextEdit.Properties.Items.Add(BtnCommandEnum.DownloadFile);
            Btn_NameTextEdit.Properties.Items.Add(BtnCommandEnum.EditDir);
        }
    }
}
