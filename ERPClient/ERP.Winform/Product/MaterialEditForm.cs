using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using COM.Winform;
using ERP.Domain;
using ERP.Service;
using COM.Service;

namespace ERP.Winform.Product
{
    public partial class MaterialEditForm : EditForm
    {
        private IMaterialService materialService = Unity.Instance.GetService<IMaterialService>();
        private ICodeService codeService = Unity.Instance.GetService<ICodeService>();
        private ISupplierService supplier = Unity.Instance.GetService<ISupplierService>();
        public MaterialEditForm(ERP_M002_Material tempData)
        {
            InitializeComponent();
            this.eRPM002MaterialBindingSource.DataSource = tempData;

        }
        protected override void InitData()
        {
            ERPHelper.Instance.SetGridLookUpEdit(MatCategoryTextEdit, codeService.GetCodeDataByCodeId("MTP"), 2);//材质
            ERPHelper.Instance.SetGridLookUpEdit(MatTypeTextEdit, codeService.GetCodeDataByCodeId("MCA"), 2);//类别
            ERPHelper.Instance.SetGridLookUpEdit(SuppCodeTextEdit, supplier.GetSupplierData(), 2);//类别
            MatCategoryTextEdit.EditValueChanging += new DevExpress.XtraEditors.Controls.ChangingEventHandler(MatCategoryTextEdit_EditValueChanging);
            MatTypeTextEdit.EditValueChanging += new DevExpress.XtraEditors.Controls.ChangingEventHandler(MatCategoryTextEdit_EditValueChanging);
            SuppCodeTextEdit.EditValueChanging += new DevExpress.XtraEditors.Controls.ChangingEventHandler(MatCategoryTextEdit_EditValueChanging);
        }

        void MatCategoryTextEdit_EditValueChanging(object sender, DevExpress.XtraEditors.Controls.ChangingEventArgs e)
        {
            this.BeginInvoke(new System.Windows.Forms.MethodInvoker(delegate
            {
                ERPHelper.Instance.FilterLookup(sender);
            }));
        }
        protected override void OnSetLayoutItemStyle()
        {
            ERPHelper.Instance.ApplyBindingSettings(ItemForMatCode, ItemBindingType.Required);
            ERPHelper.Instance.ApplyBindingSettings(ItemForMatName, ItemBindingType.Required);
        }
        protected override void OnBtnCommand(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (e.Item.Caption == BtnCommandEnum.Save)
            {
                eRPM002MaterialBindingSource.EndEdit();
                var tempData = eRPM002MaterialBindingSource.DataSource as ERP_M002_Material;
                if (this.Tag.ToString() == BtnCommandEnum.Add)
                    materialService.Create(tempData);
                else if (this.Tag.ToString() == BtnCommandEnum.Edit)
                    materialService.Update(tempData);
                DialogResult = DialogResult.OK;
            }
            if (e.Item.Caption == BtnCommandEnum.Cancel)
                DialogResult = DialogResult.Cancel;
        }
    }
}
