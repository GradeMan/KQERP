﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using COM.Winform;
using ERP.Service;
using ERP.Domain;
using COM.Service;
namespace ERP.Winform.CommonModule
{
    public partial class PrudtctCustPackEditForm : EditForm
    {
        //private IProductCustPackService productCustPackService;
        public PrudtctCustPackEditForm(ERP_M001_Product_CustPack tempData)
        {
            InitializeComponent();
            this.eRPM001ProductCustPackBindingSource.DataSource = tempData;
        }
        protected override void OnSetLayoutItemStyle()
        {
            ERPHelper.Instance.ApplyBindingSettings(ItemForItemCode, ItemBindingType.Required);
            ERPHelper.Instance.ApplyBindingSettings(ItemForCustCode, ItemBindingType.Required);
        }
        protected override void OnBtnCommand(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (e.Item.Caption == BtnCommandEnum.Save)
            {
                this.eRPM001ProductCustPackBindingSource.EndEdit();
                DialogResult = DialogResult.OK;
            }
            if (e.Item.Caption == BtnCommandEnum.Cancel)
                DialogResult = DialogResult.Cancel;
        }
    }
}