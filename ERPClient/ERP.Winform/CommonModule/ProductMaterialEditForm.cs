using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using COM.Winform;
using ERP.Domain;
namespace ERP.Winform.CommonModule
{
    public partial class ProductMaterialEditForm : EditForm
    {
        
        public ProductMaterialEditForm(ERP_M001_Product_Material tempData)
        {
            InitializeComponent();
            this.eRPM001ProductMaterialBindingSource.DataSource = tempData;
        }
        protected override void OnSetLayoutItemStyle()
        {
            ERPHelper.Instance.ApplyBindingSettings(ItemForItemCode, ItemBindingType.Required);
            ERPHelper.Instance.ApplyBindingSettings(财力, ItemBindingType.Required);
        }
        protected override void OnBtnCommand(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (e.Item.Caption == BtnCommandEnum.Save)
            {
                this.eRPM001ProductMaterialBindingSource.EndEdit();
                DialogResult = DialogResult.OK;
            }
            if (e.Item.Caption == BtnCommandEnum.Cancel)
                DialogResult = DialogResult.Cancel;
        }
    }
}