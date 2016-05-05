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
using ERP.Service;
using ERP.Domain;
using System.Reflection;

namespace ERP.Winform.SysModule
{
    public partial class SysControlEditForm : EditForm
    {
        private Itb_Sys_ControlsService controlService = Unity.Instance.GetService<Itb_Sys_ControlsService>();
        public SysControlEditForm(tb_Sys_Controls tempData)
        {
            InitializeComponent();
            this.tbSysControlsBindingSource.DataSource = tempData;
        }
        protected override void OnSetLayoutItemStyle()
        {
            ERPHelper.Instance.ApplyBindingSettings(ItemForCompCode, ItemBindingType.Required);
            ERPHelper.Instance.ApplyBindingSettings(ItemForWindows, ItemBindingType.Required);
            ERPHelper.Instance.ApplyBindingSettings(ItemForControl, ItemBindingType.Required);
            ERPHelper.Instance.ApplyBindingSettings(ItemForCValue, ItemBindingType.Required);
        }
        protected override void OnBtnCommand(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (e.Item.Caption == BtnCommandEnum.Save)
            {
                tbSysControlsBindingSource.EndEdit();
                var tempData = tbSysControlsBindingSource.DataSource as tb_Sys_Controls;
                if (this.Tag.ToString() == BtnCommandEnum.Add)
                    controlService.Create(tempData);
                else if (this.Tag.ToString() == BtnCommandEnum.Edit)
                    controlService.Update(tempData);
                DialogResult = DialogResult.OK;
            }
            if (e.Item.Caption == BtnCommandEnum.Cancel)
                DialogResult = DialogResult.Cancel;
        }

        private void SysControlEditForm_Load(object sender, EventArgs e)
        {
            //ParentMenuIdTextEdit.Properties.DataSource = menuService.Gettb_Sys_MenuList().Select(i => new { i.Id, i.MenuName });
            Assembly bllSessionDLL = Assembly.LoadFrom("ERP.Winform.exe");
            Type[] typeBll = bllSessionDLL.GetTypes();
            // BLLSession = Activator.CreateInstance(typeBllSession) as IBLLSession;
            foreach (Type t in typeBll)
            {
                if (t.BaseType == typeof(ListForm) || t == typeof(HomeForm) || t.BaseType == typeof(ReportForm))
                {
                    WindowsTextEdit.Properties.Items.Add(t.Namespace + "." + t.Name);
                }
            }
        }
    }
}
