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
using ERP.Service;
using ERP.Domain;
using COM.Service;
namespace ERP.Winform.CommonModule
{
    public partial class CompanyForm : ListForm
    {
        private ICompanyService companyService = Unity.Instance.GetService<ICompanyService>();
        public CompanyForm()
        {
            InitializeComponent();
            this.gridView1.DoubleClick+=new EventHandler(gridView1_DoubleClick);
            this.gridView1.CustomDrawRowIndicator += new DevExpress.XtraGrid.Views.Grid.RowIndicatorCustomDrawEventHandler(ERPHelper.Instance.ykgridview_CustomDrawRowIndicator);
        }
        public override void InitData()
        {
            tbC001CompanyBindingSource.DataSource = companyService.GetList();

        }
        public override void OnBtnCommand(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            // MessageBox.Show(e.Item.Caption);
            //新增
            if (e.Item.Caption == BtnCommandEnum.Add)
            {
                tbC001CompanyBindingSource.AddNew();
                OpenForm("公司资料新增", BtnCommandEnum.Add);
            }
            else if (e.Item.Caption == BtnCommandEnum.Edit)
            {
                OpenForm("公司资料修改", BtnCommandEnum.Edit);
            }
            else if (e.Item.Caption == BtnCommandEnum.Delete)
            {
                if (ERPHelper.Instance.MessageDel())
                {
                    ERP_C002_Company user = tbC001CompanyBindingSource.Current as ERP_C002_Company;
                    companyService.Delete(user.Id);
                    tbC001CompanyBindingSource.RemoveCurrent();
                }
            }
        }
        private void OpenForm(string formText, string btnCommand)
        {
            ERP_C002_Company temp = tbC001CompanyBindingSource.Current as ERP_C002_Company;
            CompanyEditForm edit = new CompanyEditForm(temp);
            edit.Text = formText;
            edit.Tag = btnCommand;
            if (edit.ShowDialog() != DialogResult.OK)
            {
                tbC001CompanyBindingSource.CancelEdit();
            }
        }

        private void gridView1_DoubleClick(object sender, EventArgs e)
        {
            OpenForm("公司资料查看", BtnCommandEnum.Watch);
        }

    }
}