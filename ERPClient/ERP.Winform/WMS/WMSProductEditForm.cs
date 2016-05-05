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
    public partial class WMSProductEditForm : EditForm
    {
        private IWMSProductService productService = Unity.Instance.GetService<IWMSProductService>();
        public WMSProductEditForm(WMS_M001_Product tempData)
        {
            InitializeComponent();
            this.wMSM001ProductBindingSource.DataSource = tempData;
        }
        protected override void OnSetLayoutItemStyle()
        {
            ERPHelper.Instance.ApplyBindingSettings(ItemForCompCode, ItemBindingType.Required);
            ERPHelper.Instance.ApplyBindingSettings(ItemForPartNo, ItemBindingType.Required);
            ERPHelper.Instance.ApplyBindingSettings(ItemForPartName, ItemBindingType.Required);
        }
        protected override void OnBtnCommand(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (e.Item.Caption == BtnCommandEnum.Save)
            {
                wMSM001ProductBindingSource.EndEdit();
                var tempData = wMSM001ProductBindingSource.DataSource as WMS_M001_Product;
                if (this.Tag.ToString() == BtnCommandEnum.Add)
                    productService.Create(tempData);
                else if (this.Tag.ToString() == BtnCommandEnum.Edit)
                    productService.Update(tempData);
                DialogResult = DialogResult.OK;
            }
            if (e.Item.Caption == BtnCommandEnum.Cancel)
                DialogResult = DialogResult.Cancel;
        }
    }
}
