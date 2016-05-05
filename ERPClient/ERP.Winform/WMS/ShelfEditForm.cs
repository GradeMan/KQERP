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
    public partial class ShelfEditForm : EditForm
    {
        private IWMSShelfService shelfService = Unity.Instance.GetService<IWMSShelfService>();
        public ShelfEditForm(WMS_C103_Shelf tempData)
        {
            InitializeComponent();
            this.wMSC103ShelfBindingSource.DataSource = tempData;
        }
        protected override void OnSetLayoutItemStyle()
        {
            ERPHelper.Instance.ApplyBindingSettings(ItemForCompCode, ItemBindingType.Required);
            ERPHelper.Instance.ApplyBindingSettings(ItemForSFCode, ItemBindingType.Required);
            ERPHelper.Instance.ApplyBindingSettings(ItemForSFName, ItemBindingType.Required);
        }
        protected override void OnBtnCommand(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (e.Item.Caption == BtnCommandEnum.Save)
            {
                wMSC103ShelfBindingSource.EndEdit();
                var tempData = wMSC103ShelfBindingSource.DataSource as WMS_C103_Shelf;
                if (this.Tag.ToString() == BtnCommandEnum.Add)
                    shelfService.Create(tempData);
                else if (this.Tag.ToString() == BtnCommandEnum.Edit)
                    shelfService.Update(tempData);
                DialogResult = DialogResult.OK;
            }
            if (e.Item.Caption == BtnCommandEnum.Cancel)
                DialogResult = DialogResult.Cancel;
        }
    }
}
