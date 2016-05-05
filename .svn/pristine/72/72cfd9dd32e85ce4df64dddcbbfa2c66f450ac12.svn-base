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
    public partial class CompanyEditForm : EditForm
    {
        private ICompanyService companyService = Unity.Instance.GetService<ICompanyService>();
        public CompanyEditForm(ERP_C002_Company tempData)
        {
            InitializeComponent();
            //this.companyService = companyService;
            tbC001CompanyBindingSource.DataSource = tempData;
        }

        protected override void OnSetLayoutItemStyle()
        {
            ERPHelper.Instance.ApplyBindingSettings(ItemForCompCode, ItemBindingType.Required);
            ERPHelper.Instance.ApplyBindingSettings(ItemForName, ItemBindingType.Required);
        }
        protected override void OnBtnCommand(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (e.Item.Caption == BtnCommandEnum.Save)
            {
                tbC001CompanyBindingSource.EndEdit();
                var CompanyData = tbC001CompanyBindingSource.DataSource as ERP_C002_Company;
                if (this.Tag.ToString() == BtnCommandEnum.Add)
                    companyService.Create(CompanyData);
                else if (this.Tag.ToString() == BtnCommandEnum.Edit)
                    companyService.Update(CompanyData);
                DialogResult = DialogResult.OK;
            }
            if (e.Item.Caption == BtnCommandEnum.Cancel)
            {
                DialogResult = DialogResult.Cancel;
            }
        }

    }
}