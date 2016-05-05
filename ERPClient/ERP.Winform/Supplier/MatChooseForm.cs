using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using ERP.Service;
using COM.Service;
using COM.Domain;
using COM.Winform;
using ERP.Domain;
using Util;
namespace ERP.Winform.Supplier
{
    public partial class MatChooseForm : EditForm
    {
        private IERP_M001_MaterialService materialService = Unity.Instance.GetService<IERP_M001_MaterialService>();
        private IERP_C003_SupplierService supplierServer = Unity.Instance.GetService<IERP_C003_SupplierService>();
        public List<ERP_M001_Material_Supp> matSuppData;
        public decimal matCount = 0;
        public MatChooseForm()
        {
            InitializeComponent();
        }
        protected override void SetToolBarItem()
        {
            //OnAddToolBtn("删除", "ok");
            OnAddToolBtn("确认", "ok");
            OnAddToolBtn("取消", "cancel");
        }
        protected override void InitData()
        {
            var suppData = supplierServer.GetSuppler().Select(a => new InputItem { DisPlayName = a.SuppName, Value = a.SuppCode, InputCode1 = a.SuppCode }).ToList();
            SetGridLookUpEdit(repositorySuppCode, suppData, 1);
            var materialData = materialService.GetMaterial().Select(a => new InputItem { DisPlayName = a.MatName, Value = a.MatCode, InputCode1 = a.MatCode,InputCode2 = a.MatClass2,InputCode3 = a.MatSpec }).ToList();
            SetGridLookUpEdit(repositoryMatCode, materialData, 1);
            SetGridLookUpEdit(txtMatCode, materialData, 3);
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtMatCode.Text))
                throw new AppException("请先选择原材料");
            if(this.txtCount.Value<=0)
                throw new AppException("数量不能小于0");
            string matCode = txtMatCode.EditValue.ToString();
            matCount = txtCount.Value;
            var matSuppData = materialService.GetMatSupp().Where(a => a.MatCode == matCode).ToList();
            foreach (var matSupp in matSuppData)
            {
                matSupp.Qty = matSupp.PurPer * matCount;
            }
            this.gridControl1.DataSource = matSuppData;
        }

        protected override void OnBtnCommand(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (e.Item.Caption == BtnCommandEnum.OK)
            {
                this.gridView1.CloseEditor();
                matSuppData = this.gridControl1.DataSource as List<ERP_M001_Material_Supp>;
                if (matSuppData.Sum(a => a.PurPer) != 1)
                    throw new AppException("百分比总和不等于1，请检查数据");
                DialogResult = DialogResult.OK;
            }
            if (e.Item.Caption == BtnCommandEnum.Cancel)
                DialogResult = DialogResult.Cancel;
        }

        private void MatChooseForm_Load(object sender, EventArgs e)
        {
            
        }

        private void gridView1_CellValueChanged(object sender, DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs e)
        {
            if (e.Column == colPurPer)
            {
                decimal purper = e.Value.ToStr().ToDecimal();
                decimal sum = purper * matCount;
                gridView1.SetFocusedRowCellValue(colQty, sum);
            }

        }
    }
}
