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

namespace ERP.Winform.Device
{
    public partial class DeviceForm : ListForm
    {
        private IDEV_D001_DeviceService devService = Unity.Instance.GetService<IDEV_D001_DeviceService>();
        public DeviceForm()
        {
            InitializeComponent();
        }
        public override void InitData()
        {
            dEVD001DeviceBindingSource.DataSource = devService.GetList();
        }
        public override void OnBtnCommand(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            // MessageBox.Show(e.Item.Caption);
            //新增
            if (e.Item.Caption == BtnCommandEnum.Add)
            {
                dEVD001DeviceBindingSource.AddNew();
                DEV_D001_Device temp = dEVD001DeviceBindingSource.Current as DEV_D001_Device;
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
                    DEV_D001_Device temp = dEVD001DeviceBindingSource.Current as DEV_D001_Device;
                    devService.Delete(temp.Id);
                    dEVD001DeviceBindingSource.RemoveCurrent();
                }
            }
        }

        private void EditForm(string formText, string btnCommand)
        {
            DEV_D001_Device temp = dEVD001DeviceBindingSource.Current as DEV_D001_Device;
            DeviceEditForm edit = new DeviceEditForm(temp);
            edit.Text = formText;
            edit.Tag = btnCommand;

            if (edit.ShowDialog() != DialogResult.OK)
            {
                dEVD001DeviceBindingSource.CancelEdit();
            }
        }

        private void gridView1_DoubleClick(object sender, EventArgs e)
        {
            if (this.ButtonList.Where(i => i.Btn_Name == BtnCommandEnum.Edit).Count() > 0)
            {
                EditForm("产品资料查看", BtnCommandEnum.Watch);
            }
        }

        private void DeviceForm_Load(object sender, EventArgs e)
        {
            this.gridView1.DoubleClick += new EventHandler(gridView1_DoubleClick);
        }
    }
}
