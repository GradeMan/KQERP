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

namespace ERP.Winform.WMS
{
    public partial class StockEditForm : EditForm
    {
        private IWMS_C103_StockService stockService = Unity.Instance.GetService<IWMS_C103_StockService>();
        private WMS_C103_Stock tempData;
        public StockEditForm(WMS_C103_Stock tempData)
        {
            InitializeComponent();
            this.tempData = tempData;
        }
        protected override void InitData()
        {
            this.wMSC103StockBindingSource.DataSource = tempData;
        }
        protected override void OnSetLayoutItemStyle()
        {
            ERPHelper.Instance.ApplyBindingSettings(ItemForARCode, ItemBindingType.Required);
            ERPHelper.Instance.ApplyBindingSettings(ItemForJobNo, ItemBindingType.Required);
            ERPHelper.Instance.ApplyBindingSettings(ItemForStoreAmount, ItemBindingType.Required);
            ERPHelper.Instance.ApplyBindingSettings(ItemForStockStatus, ItemBindingType.Required);
        }
        protected override void OnBtnCommand(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (e.Item.Caption == BtnCommandEnum.Save)
            {
                this.wMSC103StockBindingSource.EndEdit();
               
                if (this.Tag.ToString() == BtnCommandEnum.Add)
                    stockService.Create(tempData);
                else if (this.Tag.ToString() == BtnCommandEnum.Edit)
                    stockService.Update(tempData);
                DialogResult = DialogResult.OK;
            }
            if (e.Item.Caption == BtnCommandEnum.Cancel)
            {
                DialogResult = DialogResult.Cancel;
            }
        }
    }
}
