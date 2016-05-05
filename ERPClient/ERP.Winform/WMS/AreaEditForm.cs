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
    public partial class AreaEditForm : EditForm
    {
        private IWMSAreaService areaService = Unity.Instance.GetService<IWMSAreaService>();
        public AreaEditForm(WMS_C102_Area tempData)
        {
            InitializeComponent();

            this.wMSC102AreaBindingSource.DataSource = tempData;
        }
        protected override void OnSetLayoutItemStyle()
        {
            ERPHelper.Instance.ApplyBindingSettings(ItemForCompCode, ItemBindingType.Required);
            ERPHelper.Instance.ApplyBindingSettings(ItemForARCode, ItemBindingType.Required);
            ERPHelper.Instance.ApplyBindingSettings(ItemForARName, ItemBindingType.Required);
        }
        protected override void OnBtnCommand(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (e.Item.Caption == BtnCommandEnum.Save)
            {
                wMSC102AreaBindingSource.EndEdit();
                var tempData = wMSC102AreaBindingSource.DataSource as WMS_C102_Area;
                if (this.Tag.ToString() == BtnCommandEnum.Add)
                    areaService.Create(tempData);
                else if (this.Tag.ToString() == BtnCommandEnum.Edit)
                    areaService.Update(tempData);
                DialogResult = DialogResult.OK;
            }
            if (e.Item.Caption == BtnCommandEnum.Cancel)
                DialogResult = DialogResult.Cancel;
        }
    }
}
