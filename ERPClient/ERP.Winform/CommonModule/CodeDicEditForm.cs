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
    public partial class CodeDicEditForm :EditForm
    {
        private IERP_C001_CodeDictionaryService codeDicService;
        private ERP_C001_CodeDictionary tempData;
        public CodeDicEditForm(IERP_C001_CodeDictionaryService codeDicService,ERP_C001_CodeDictionary tempData)
        {
            InitializeComponent();
            this.tempData = tempData;
            this.codeDicService = codeDicService;
        }
        protected override void InitData()
        {
            this.eRPC001CodeDictionaryBindingSource.DataSource = tempData;
        }
        protected override void OnSetLayoutItemStyle()
        {
            ERPHelper.Instance.ApplyBindingSettings(ItemForCode, ItemBindingType.Required);
            ERPHelper.Instance.ApplyBindingSettings(ItemForParentId, ItemBindingType.Required);
            ERPHelper.Instance.ApplyBindingSettings(ItemForFullName, ItemBindingType.Required);
            var codeDicList = codeDicService.GetQuery().ToList().Select(a => new { 值 = a.Id, 代号 = a.Code, 名称 = a.FullName }).ToList();
            SetGridLookUpEdit(ParentIdTextEdit, codeDicList, "名称", "值");
        }
        protected override void OnBtnCommand(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (e.Item.Caption == BtnCommandEnum.Save)
            {
                eRPC001CodeDictionaryBindingSource.EndEdit();
                if (this.Tag.ToString() == BtnCommandEnum.AddCodeDic)
                    codeDicService.Create(tempData);
                else if (this.Tag.ToString() == BtnCommandEnum.EditCodeDic)
                    codeDicService.Update(tempData);
                DialogResult = DialogResult.OK;
            }
            if (e.Item.Caption == BtnCommandEnum.Cancel)
                DialogResult = DialogResult.Cancel;
        }
    }
}