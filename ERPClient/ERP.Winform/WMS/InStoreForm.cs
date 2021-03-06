﻿using System;
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
using COM.Domain;

namespace ERP.Winform.WMS
{
    public partial class InStoreForm : ListForm
    {
        private IWMS_C101_InStoreService instoreService = Unity.Instance.GetService<IWMS_C101_InStoreService>();
        private IERP_C003_SupplierService supplierServer = Unity.Instance.GetService<IERP_C003_SupplierService>();
        public InStoreForm()
        {
            InitializeComponent();
        }
        public override void InitData()
        {
            var suppData = supplierServer.GetSuppler().Select(a => new InputItem { DisPlayName = a.Alias, Value = a.SuppCode, InputCode1 = a.SuppCode }).ToList();
            SetGridLookUpEdit(repositorySuppCode, suppData, 1);
            this.wMSC101InStoreBindingSource.CurrentChanged += new EventHandler(wMSC101InStoreBindingSource_CurrentChanged);
            this.wMSC101InStoreBindingSource.DataSource = instoreService.GetList();
            
        }

        void wMSC101InStoreBindingSource_CurrentChanged(object sender, EventArgs e)
        {
            WMS_C101_InStore tempData = this.wMSC101InStoreBindingSource.Current as WMS_C101_InStore;
            if (tempData != null)
                this.wMSC102InStoreDetailBindingSource.DataSource = instoreService.GetDetailListByInstoreId(tempData.Id);
            else
                this.wMSC102InStoreDetailBindingSource.DataSource = null;
        }
        public override void OnBtnCommand(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            // MessageBox.Show(e.Item.Caption);
            //新增
            if (e.Item.Caption == BtnCommandEnum.Add)
            {
                this.wMSC101InStoreBindingSource.AddNew();
                WMS_C101_InStore temp = this.wMSC101InStoreBindingSource.Current as WMS_C101_InStore;
                temp.StoreInDate = DateTime.Now.Date;
                temp.DriverDt = DateTime.Now.Date;
                temp.InStoreNo = this.instoreService.GetInStoreNo();
                tb_Sys_Menu menuInfo =this.Tag as tb_Sys_Menu;
                temp.StockArea = menuInfo.MenuType;
                OpenForm("进仓资料新增", BtnCommandEnum.Add);
            }
            else if (e.Item.Caption == BtnCommandEnum.Edit)
            {
                OpenForm("进仓资料修改", BtnCommandEnum.Edit);
            }
            else if (e.Item.Caption == BtnCommandEnum.Delete)
            {
                if (ERPHelper.Instance.MessageDel())
                {
                    WMS_C101_InStore tempData = this.wMSC101InStoreBindingSource.Current as WMS_C101_InStore;
                    instoreService.Delete(tempData.Id);
                    this.wMSC101InStoreBindingSource.RemoveCurrent();
                }
            }
        }
        private void OpenForm(string formText, string btnCommand)
        {
            WMS_C101_InStore temp = this.wMSC101InStoreBindingSource.Current as WMS_C101_InStore;
            InStoreEditForm edit = new InStoreEditForm(temp, instoreService);
            edit.Text = formText;
            edit.Tag = btnCommand;
            if (edit.ShowDialog() != DialogResult.OK)
            {
                this.wMSC101InStoreBindingSource.CancelEdit();
            }
            else
            {
                wMSC101InStoreBindingSource_CurrentChanged(null, null);
            }
        }

        private void gridView1_DoubleClick(object sender, EventArgs e)
        {
            OpenForm("进仓资料查看", BtnCommandEnum.Watch);
        }
    }
}
