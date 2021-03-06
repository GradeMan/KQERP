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
using ERP.Domain;
using COM.Service;
namespace ERP.Winform.WMS
{
    public partial class WareHouseEditForm : EditForm
    {
        private IWMSWareHouseService wareHouseService = Unity.Instance.GetService<IWMSWareHouseService>();
        public WareHouseEditForm(WMS_C101_WareHouse tempData)
        {
            InitializeComponent();
            wMSC101WareHouseBindingSource.DataSource = tempData;
            
        }
        protected override void OnSetLayoutItemStyle()
        {
            ERPHelper.Instance.ApplyBindingSettings(ItemForCompCode, ItemBindingType.Required);
            ERPHelper.Instance.ApplyBindingSettings(ItemForWHCode, ItemBindingType.Required);
            ERPHelper.Instance.ApplyBindingSettings(ItemForWHName, ItemBindingType.Required);
        }
        protected override void OnBtnCommand(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (e.Item.Caption == BtnCommandEnum.Save)
            {
                wMSC101WareHouseBindingSource.EndEdit();
                var tempData = wMSC101WareHouseBindingSource.DataSource as WMS_C101_WareHouse;
                if (this.Tag.ToString() == BtnCommandEnum.Add)
                    wareHouseService.Create(tempData);
                else if (this.Tag.ToString() == BtnCommandEnum.Edit)
                    wareHouseService.Update(tempData);
                DialogResult = DialogResult.OK;
            }
            if (e.Item.Caption == BtnCommandEnum.Cancel)
                DialogResult = DialogResult.Cancel;
        }
    }
}
