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
using ERP.Domain;

namespace ERP.Winform.CommonModule
{
    public partial class C006ProcessProdInfoEditForm : EditForm
    {
        private ICodeService codeService = Unity.Instance.GetService<ICodeService>();
        private IERP_C006_ProcessProdInfoService processProdInfoService = Unity.Instance.GetService<IERP_C006_ProcessProdInfoService>();
        private ERP_C006_ProcessProdInfo tempData;
        public C006ProcessProdInfoEditForm(ERP_C006_ProcessProdInfo processProd)
        {
            InitializeComponent();
            this.tempData = processProd;
        }
        protected override void OnSetLayoutItemStyle()
        {
            ERPHelper.Instance.ApplyBindingSettings(ItemForTechCode, ItemBindingType.Required);
            ERPHelper.Instance.ApplyBindingSettings(ItemForTechContent, ItemBindingType.Required);
            var ProdInfoList = codeService.GetCodeDataByCodeId("PROCPMS");
            SetGridLookUpEdit(TechCodeTextEdit, ProdInfoList,1);
        }
        protected override void InitData()
        {
            this.eRPC006ProcessProdInfoBindingSource.DataSource = tempData;
        }
        protected override void OnBtnCommand(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (e.Item.Caption == BtnCommandEnum.Save)
            {
                this.eRPC006ProcessProdInfoBindingSource.EndEdit();
                if (this.Tag.ToString() == BtnCommandEnum.Add)
                    processProdInfoService.Create(tempData);
                else if (this.Tag.ToString() == BtnCommandEnum.Edit)
                    processProdInfoService.Update(tempData);
                DialogResult = DialogResult.OK;
            }
            if (e.Item.Caption == BtnCommandEnum.Cancel)
                DialogResult = DialogResult.Cancel;
        }
    }
}