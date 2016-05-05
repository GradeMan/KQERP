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
namespace ERP.Winform.CommonModule
{
    public partial class QHProductEditForm : EditForm
    {
        private IQHProductService qhProductService = Unity.Instance.GetService<IQHProductService>();
        private IProductService productService = Unity.Instance.GetService<IProductService>();
        public QHProductEditForm(ERP_M004_QHProduct tempData)
        {
            InitializeComponent();
            this.eRPM004QHProductBindingSource.DataSource = tempData;
        }
        protected override void InitData()
        {
            ERPHelper.Instance.SetGridLookUpEdit(ItemCodeTextEdit, productService.GetProductInputData(), 2);
            ItemCodeTextEdit.EditValueChanging += new DevExpress.XtraEditors.Controls.ChangingEventHandler(ItemCodeTextEdit_EditValueChanging);
        }

        void ItemCodeTextEdit_EditValueChanging(object sender, DevExpress.XtraEditors.Controls.ChangingEventArgs e)
        {
            this.BeginInvoke(new System.Windows.Forms.MethodInvoker(delegate
            {
                ERPHelper.Instance.FilterLookup(sender);
            }));
        }
        protected override void OnSetLayoutItemStyle()
        {
            ERPHelper.Instance.ApplyBindingSettings(ItemForCompCode, ItemBindingType.Required);
            ERPHelper.Instance.ApplyBindingSettings(ItemForQHItemCode, ItemBindingType.Required);
            ERPHelper.Instance.ApplyBindingSettings(ItemForQHItemName, ItemBindingType.Required);
        }
        protected override void OnBtnCommand(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (e.Item.Caption == BtnCommandEnum.Save)
            {
                eRPM004QHProductBindingSource.EndEdit();
                var tempData = eRPM004QHProductBindingSource.DataSource as ERP_M004_QHProduct;
                if (this.Tag.ToString() == BtnCommandEnum.Add)
                    qhProductService.Create(tempData);
                else if (this.Tag.ToString() == BtnCommandEnum.Edit)
                    qhProductService.Update(tempData);
                DialogResult = DialogResult.OK;
            }
            if (e.Item.Caption == BtnCommandEnum.Cancel)
                DialogResult = DialogResult.Cancel;
        }
    }
}
