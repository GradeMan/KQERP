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
using COM.Domain;

namespace ERP.Winform.ESOP
{
    public partial class ESOPDocIndexEditForm : EditForm
    {
        private IESOP_DocIndexService docIndexService = Unity.Instance.GetService<IESOP_DocIndexService>();
        private ESOP_DocIndex tempData;
        public ESOPDocIndexEditForm(ESOP_DocIndex tempData)
        {
            InitializeComponent();
            this.tempData = tempData;
        }
        protected override void InitData()
        {
            var DocIndexData = docIndexService.GetDocIndex().Select(a => new InputItem() { DisPlayName = a.DocIndexName, Value2 = a.Id }).ToList();
            ERPHelper.Instance.SetGridLookUpEdit(PreDocIndexIdTextEdit, DocIndexData, 0);
            PreDocIndexIdTextEdit.Properties.ValueMember = "Value2";
            //ERPHelper.Instance.SetGridLookUpEdit(StatusTextEdit, codeService.GetCodeDataByCodeId("IST"), 2);//状态
            this.eSOPDocIndexBindingSource.DataSource = tempData;
        }
        protected override void OnSetLayoutItemStyle()
        {
            ERPHelper.Instance.ApplyBindingSettings(ItemForDocIndexName, ItemBindingType.Required);
        }
        protected override void OnBtnCommand(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (e.Item.Caption == BtnCommandEnum.Save)
            {
                this.eSOPDocIndexBindingSource.EndEdit();
                docIndexService.Save(tempData);
                DialogResult = DialogResult.OK;
            }
            if (e.Item.Caption == BtnCommandEnum.Cancel)
                DialogResult = DialogResult.Cancel;
        }
    }
}
