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
using ERP.Service;
using COM.Service;
namespace ERP.Winform.CommonModule
{
    public partial class C001CodeEditForm : EditForm
    {
        private ICodeService codeService = Unity.Instance.GetService<ICodeService>();
        public C001CodeEditForm(ERP_C001_Code tempData)
        {
            InitializeComponent();
            //this.codeService = codeService;
            eRPC001CodeBindingSource.DataSource = tempData;
        }

        protected override void OnSetLayoutItemStyle()
        {
            ERPHelper.Instance.ApplyBindingSettings(ItemForCompCode, ItemBindingType.Required);
            ERPHelper.Instance.ApplyBindingSettings(ItemForCode, ItemBindingType.Required);
            ERPHelper.Instance.ApplyBindingSettings(ItemForDescription, ItemBindingType.Required);
        }
        protected override void OnBtnCommand(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (e.Item.Caption == BtnCommandEnum.Save)
            {
                eRPC001CodeBindingSource.EndEdit();
                var tempData = eRPC001CodeBindingSource.DataSource as ERP_C001_Code;
                if (this.Tag.ToString() == BtnCommandEnum.Add)
                    codeService.Create(tempData);
                else if (this.Tag.ToString() == BtnCommandEnum.Edit)
                    codeService.Update(tempData);
                DialogResult = DialogResult.OK;
            }
            if (e.Item.Caption == BtnCommandEnum.Cancel)
                DialogResult = DialogResult.Cancel;
        }
    }
}