using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using COM.Winform;
using ERP.Service;
using COM.Service;
using ERP.Domain;
using System.Drawing.Imaging;
using System.Reflection;
using ERP.Winform.MES;
namespace ERP.Winform.SysModule
{
    public partial class SysMenuEditForm : EditForm
    {
        private Itb_Sys_MenuService menuService = Unity.Instance.GetService<Itb_Sys_MenuService>();
        public SysMenuEditForm(tb_Sys_Menu menuData)
        {
            InitializeComponent();
            tbSysMenuBindingSource.DataSource = menuData;
        }

        protected override void OnSetLayoutItemStyle()
        {
            ERPHelper.Instance.ApplyBindingSettings(ItemForMenuName, ItemBindingType.Required);
            ERPHelper.Instance.ApplyBindingSettings(ItemForNameSpeace, ItemBindingType.Required);
            
        }
        /// <summary>
        /// 保存
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        protected override void OnBtnCommand(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            tbSysMenuBindingSource.EndEdit();
            var MenuData = tbSysMenuBindingSource.DataSource as tb_Sys_Menu;
            if (e.Item.Caption == BtnCommandEnum.Save)
            {
                if (this.Tag.ToString() == BtnCommandEnum.Add)
                    menuService.Createtb_Sys_Menu(MenuData);
                else if (this.Tag.ToString() == BtnCommandEnum.Edit)
                    menuService.Updatetb_Sys_Menu(MenuData);
                DialogResult = System.Windows.Forms.DialogResult.OK;
            }
            if (e.Item.Caption == BtnCommandEnum.Cancel)
                DialogResult = System.Windows.Forms.DialogResult.Cancel;
        }

        private void SysMenuEditForm_Load(object sender, EventArgs e)
        {
            ParentMenuIdTextEdit.Properties.DataSource = menuService.Gettb_Sys_MenuList().Select(i => new { i.Id,i.MenuName});
            Assembly bllSessionDLL = Assembly.LoadFrom("ERP.Winform.exe");
            Type[] typeBll = bllSessionDLL.GetTypes();
            // BLLSession = Activator.CreateInstance(typeBllSession) as IBLLSession;
            foreach (Type t in typeBll)
            {
                if (t.BaseType == typeof(ListForm) || t == typeof(HomeForm) || t.BaseType == typeof(ReportForm) || t.BaseType == typeof(MES501JobTxEditForm))
                {
                    NameSpeaceTextEdit.Properties.Items.Add(t.Namespace + "." + t.Name);
                }
            }
        }

        private void MenuIconPictureEdit_EditValueChanged(object sender, EventArgs e)
        {
            var MenuData = tbSysMenuBindingSource.DataSource as tb_Sys_Menu;
            MenuData.MenuIcon = MenuData.MenuIcon = ERPHelper.Instance.ImageToBuffer(this.MenuIconPictureEdit.Image);
                
        }

    }
}
