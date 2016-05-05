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
using COM.Domain;
using COM.Service;

namespace ERP.Winform.WMS
{
    public partial class WMS105MatReturnEditForm : EditForm
    {
        private IWMS_M105_MatReturnService matReturnService;
        private IWMSAreaService areaService = Unity.Instance.GetService<IWMSAreaService>();
        private WMS_M105_MatReturn tempData;
        private IERP_M001_MaterialService materialService = Unity.Instance.GetService<IERP_M001_MaterialService>();
        private IERP_C003_SupplierService supplierService = Unity.Instance.GetService<IERP_C003_SupplierService>();
        List<InputItem> suppList;
        public WMS105MatReturnEditForm(WMS_M105_MatReturn outStore, IWMS_M105_MatReturnService matReturnService)
        {
            InitializeComponent();
            this.tempData = outStore;
            this.matReturnService = matReturnService;
        }
        protected override void InitData()
        {
            var materialList = materialService.GetMaterial().ToList().Select(a => new InputItem { Value = a.MatCode, DisPlayName = a.MatCode, InputCode1 = a.MatName, InputCode2 = a.MatSpec, InputCode3 = a.MatClass2 }).ToList();
            SetGridLookUpEdit(repositoryItemMatSpecCode, materialList, 3);
            //SetGridLookUpEdit(RemarksTextEdit, materialList, "物料代号", "物料名称");
            repositoryItemMatSpecCode.View.Columns[0].Caption = "物料代号";
            repositoryItemMatSpecCode.View.Columns[1].Caption = "物料名称";
            repositoryItemMatSpecCode.View.Columns[2].Caption = "物料规格";
            repositoryItemMatSpecCode.View.Columns[3].Caption = "材质";
            suppList = supplierService.GetSuppler().ToList().Select(a => new InputItem { Value = a.SuppCode, DisPlayName = a.Alias, InputCode1 = a.SuppCode }).ToList();
            SetGridLookUpEdit(repositoryItemSupplier, suppList, 1);
            repositoryItemMatSpecCode.View.Columns[0].Caption = "供应商简称";
            repositoryItemMatSpecCode.View.Columns[1].Caption = "供应商编号";
            this.wMSM105MatReturnBindingSource.DataSource = tempData;
            var matDetailList = matReturnService.GetMatDetailQuery().Where(a => a.ReturnNo == tempData.ReturnNo).ToList();
            var count = matDetailList.Count;
            for (int i = 0; i < 20 - count; i++)
            {
                WMS_M105_MatReturnDetail bomMat = new WMS_M105_MatReturnDetail();
                bomMat.ReturnNo = tempData.ReturnNo;
                matDetailList.Add(bomMat);
            }
            this.wMSM105MatReturnDetailBindingSource.DataSource = matDetailList;
        }

        protected override void OnSetLayoutItemStyle()
        {
            ERPHelper.Instance.ApplyBindingSettings(ItemForReturnNo, ItemBindingType.Required);
        }

        protected override void OnBtnCommand(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (e.Item.Caption == BtnCommandEnum.Save)
            {
                this.wMSM105MatReturnBindingSource.EndEdit();
                this.gridView1.CloseEditor();
                var matDetailList = this.wMSM105MatReturnDetailBindingSource.DataSource as List<WMS_M105_MatReturnDetail>;

                this.matReturnService.Save(tempData, matDetailList.Where(a => a.MatSpecCode != null).ToList());
                DialogResult = DialogResult.OK;
            }
            if (e.Item.Caption == BtnCommandEnum.Cancel)
                DialogResult = DialogResult.Cancel;
        }
    }
}