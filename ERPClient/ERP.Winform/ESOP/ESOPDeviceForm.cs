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

namespace ERP.Winform.ESOP
{
    public partial class ESOPDeviceForm : ListForm
    {
        private IESOP_DeviceService devService = Unity.Instance.GetService<IESOP_DeviceService>();
        public ESOPDeviceForm()
        {
            InitializeComponent();
            //this.gridView1.OptionsBehavior.ReadOnly = false;
        }
        public override void InitData()
        {
            this.eSOPDeviceBindingSource.DataSource = devService.GetList();
        }
        public override void OnBtnCommand(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            // MessageBox.Show(e.Item.Caption);
            //新增
            if (e.Item.Caption == BtnCommandEnum.Add)
            {
                eSOPDeviceBindingSource.AddNew();
                ESOP_Device temp = eSOPDeviceBindingSource.Current as ESOP_Device;
                EditForm("产品资料新增", BtnCommandEnum.Add);
            }
            else if (e.Item.Caption == BtnCommandEnum.Edit)
            {
                EditForm("产品资料修改", BtnCommandEnum.Edit);
            }
            else if (e.Item.Caption == BtnCommandEnum.Delete)
            {
                if (ERPHelper.Instance.MessageDel())
                {
                    ESOP_Device temp = eSOPDeviceBindingSource.Current as ESOP_Device;
                    devService.Delete(temp.Id);
                    eSOPDeviceBindingSource.RemoveCurrent();
                }
            }
        }
        private void EditForm(string formText, string btnCommand)
        {
            ESOP_Device temp = this.eSOPDeviceBindingSource.Current as ESOP_Device;
            ESOPDeviceEditForm edit = new ESOPDeviceEditForm(temp);
            edit.Text = formText;
            edit.Tag = btnCommand;
            
            if (edit.ShowDialog() != DialogResult.OK)
            {
                eSOPDeviceBindingSource.CancelEdit();
            }
        }
    }
}
