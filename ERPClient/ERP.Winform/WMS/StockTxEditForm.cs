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

namespace ERP.Winform.WMS
{
    public partial class StockTxEditForm : EditForm
    {
        private IWMSStockTxService stockTxService = Unity.Instance.GetService<IWMSStockTxService>();
        public StockTxEditForm()
        {
            
            InitializeComponent();
        }
        protected override void OnSetLayoutItemStyle()
        {
            ERPHelper.Instance.ApplyBindingSettings(ItemForStockID, ItemBindingType.Required);
        }
        protected override void OnBtnCommand(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (e.Item.Caption == BtnCommandEnum.Save)
            {
                wMSM002StockTxBindingSource.EndEdit();
                var tempData = wMSM002StockTxBindingSource.DataSource as WMS_M002_StockTx;
                if (this.Tag.ToString() == BtnCommandEnum.Add)
                    stockTxService.Create(tempData);
                else if (this.Tag.ToString() == BtnCommandEnum.Edit)
                    stockTxService.Update(tempData);
                DialogResult = DialogResult.OK;
            }
            if (e.Item.Caption == BtnCommandEnum.Cancel)
                DialogResult = DialogResult.Cancel;
        }
    }
}
