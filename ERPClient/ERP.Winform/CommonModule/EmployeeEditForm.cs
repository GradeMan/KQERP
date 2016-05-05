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
using ERP.Domain;
using COM.Service;
using COM.Domain;
using Util;
namespace ERP.Winform.CommonModule
{
    public partial class EmployeeEditForm : EditForm
    {
        private IEmployeeService employeeService = Unity.Instance.GetService<IEmployeeService>();
        public EmployeeEditForm(ERP_C005_Employee tempData)
        {
            InitializeComponent();
            //this.customerService = customerService;
            eRPC005EmployeeBindingSource.DataSource = tempData;
        }
        protected override void InitData()
        {
            //var supplierList = supplier.GetList().Select(i => new InputItem { DisPlayName = i.SuppName, Value = i.SuppCode, InputCode1 = i.SuppCode, InputCode2 = PinYin.GetCodstring(i.SuppName) }).ToList();
            //ERPHelper.Instance.SetGridLookUpEdit(VendorCodeTextEdit, supplierList, 2);
            //VendorCodeTextEdit.EditValueChanging += new DevExpress.XtraEditors.Controls.ChangingEventHandler(VendorCodeTextEdit_EditValueChanging);
            // 
        }

        void VendorCodeTextEdit_EditValueChanging(object sender, DevExpress.XtraEditors.Controls.ChangingEventArgs e)
        {
            this.BeginInvoke(new System.Windows.Forms.MethodInvoker(delegate
            {
                ERPHelper.Instance.FilterLookup(sender);
            }));
        }
        //public CustomerEditForm(Guid id,ICustomerService customerService)
        //{
        //    InitializeComponent();
        //    this.customerService = customerService;
        //    eRPC003CustomerBindingSource.DataSource = customerService.GetById(id);
        //}
        protected override void OnSetLayoutItemStyle()
        {
            ERPHelper.Instance.ApplyBindingSettings(ItemForCompCode, ItemBindingType.Required);
            ERPHelper.Instance.ApplyBindingSettings(ItemForEmpNo, ItemBindingType.Required);
            ERPHelper.Instance.ApplyBindingSettings(ItemForName, ItemBindingType.Required);
        }
        protected override void OnBtnCommand(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (e.Item.Caption == BtnCommandEnum.Save)
            {
                eRPC005EmployeeBindingSource.EndEdit();
                var TempData = eRPC005EmployeeBindingSource.DataSource as ERP_C005_Employee;
                if (this.Tag.ToString() == BtnCommandEnum.Add)
                    employeeService.Create(TempData);
                else if (this.Tag.ToString() == BtnCommandEnum.Edit)
                    employeeService.Update(TempData);
                DialogResult = DialogResult.OK;
            }
            if (e.Item.Caption == BtnCommandEnum.Cancel)
                DialogResult = DialogResult.Cancel;
        }
    }
}
