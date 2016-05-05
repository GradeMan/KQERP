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
using COM.Service;
using COM.Domain;
using ERP.Domain;

namespace ERP.Winform.WMS
{
    public partial class WMS105MatGetEditForm : EditForm
    {
        private IWMS_M105_MatGetService matGetService;
        private IWMSAreaService areaService = Unity.Instance.GetService<IWMSAreaService>();
        private WMS_M105_MatGet tempData;
        private IERP_M001_MaterialService materialService = Unity.Instance.GetService<IERP_M001_MaterialService>();
        private IERP_C003_SupplierService supplierService = Unity.Instance.GetService<IERP_C003_SupplierService>();
        List<InputItem> suppList;
        public WMS105MatGetEditForm(WMS_M105_MatGet inStore, IWMS_M105_MatGetService matGetService)
        {
            InitializeComponent();
            this.tempData = inStore;
            this.matGetService = matGetService;
        }
        protected override void InitData()
        {
            var materialList = materialService.GetMaterial().ToList().Select(a => new InputItem { Value = a.MatCode, DisPlayName = a.MatCode,InputCode1 =  a.MatName, InputCode2 = a.MatSpec, InputCode3 = a.MatClass2 }).ToList();
            SetGridLookUpEdit(repositoryItemMatSpecCode, materialList,3);
            //SetGridLookUpEdit(RemarksTextEdit, materialList, "物料代号", "物料名称");
            repositoryItemMatSpecCode.View.Columns[0].Caption = "物料代号";
            repositoryItemMatSpecCode.View.Columns[1].Caption = "物料名称";
            repositoryItemMatSpecCode.View.Columns[2].Caption = "物料规格";
            repositoryItemMatSpecCode.View.Columns[3].Caption = "材质";
            suppList = supplierService.GetSuppler().ToList().Select(a => new InputItem { Value = a.SuppCode, DisPlayName = a.Alias,InputCode1 = a.SuppCode }).ToList();
            SetGridLookUpEdit(repositoryItemSupplier, suppList, 1);
            repositoryItemMatSpecCode.View.Columns[0].Caption = "供应商简称";
            repositoryItemMatSpecCode.View.Columns[1].Caption = "供应商编号";
            this.wMSM105MatGetBindingSource.DataSource = tempData;
            var matDetailList = matGetService.GetMatDetailQuery().Where(a => a.RequestNo == tempData.RequestNo).ToList();
            var count = matDetailList.Count;
            for (int i = 0; i < 20 - count; i++)
            {
                WMS_M105_MatGetDetail bomMat = new WMS_M105_MatGetDetail();
                bomMat.RequestNo = tempData.RequestNo;
                matDetailList.Add(bomMat);
            }
            this.wMSM105MatGetDetailBindingSource.DataSource = matDetailList;
        }

        protected override void OnSetLayoutItemStyle()
        {
            ERPHelper.Instance.ApplyBindingSettings(ItemForRequestNo, ItemBindingType.Required);
        }

        protected override void OnBtnCommand(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (e.Item.Caption == BtnCommandEnum.Save)
            {
                this.wMSM105MatGetBindingSource.EndEdit();
                this.gridView1.CloseEditor();
                var matDetailList = this.wMSM105MatGetDetailBindingSource.DataSource as List<WMS_M105_MatGetDetail>;

                this.matGetService.Save(tempData, matDetailList.Where(a => a.MatSpecCode != null).ToList());
                DialogResult = DialogResult.OK;
            }
            if (e.Item.Caption == BtnCommandEnum.Cancel)
                DialogResult = DialogResult.Cancel;
        }
        /// <summary>
        /// 材料规格改变~
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void repositoryItemMatSpecCode_EditValueChanged(object sender, EventArgs e)
        {
            this.gridView1.CloseEditor();
            var detail = this.wMSM105MatGetDetailBindingSource.Current as WMS_M105_MatGetDetail;
            if (detail != null)
            {
                var material = this.materialService.GetMaterial().Where(a => a.MatCode == detail.MatSpecCode).SingleOrDefault();
                detail.MatSpec = material.MatSpec;
                detail.MatType = material.MatClass2;
                //var matSuppList = this.materialService.GetMatSupp().Where(a => a.MatCode == material.MatCode).ToList().Select(a => new InputItem { Value = a.SuppCode, InputCode1 = a.Level });
                //foreach (var matSupp in matSuppList)
                //{
                //    var supplier = suppList.Where(a => a.Value == matSupp.Value).First();
                //    matSupp.DisPlayName = supplier.DisPlayName;
                //}
                //detail. = material.s
                this.wMSM105MatGetBindingSource.ResetCurrentItem();
            }
        }
    }
}