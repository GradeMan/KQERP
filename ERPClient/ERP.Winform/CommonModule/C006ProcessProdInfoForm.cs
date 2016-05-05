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
using Util;
namespace ERP.Winform.CommonModule
{
    public partial class C006ProcessProdInfoForm : ListForm
    {
        private ICodeService codeService = Unity.Instance.GetService<ICodeService>();
        private IERP_C006_ProcessProdInfoService processProdInfoService = Unity.Instance.GetService<IERP_C006_ProcessProdInfoService>();
        public C006ProcessProdInfoForm()
        {
            InitializeComponent();
        }
        public override void OnAttachEvent()
        {
            var ProdInfoList = codeService.GetCodeDataByCodeId("PROCPMS");
            SetGridLookUpEdit(repositoryItemPROCPMS, ProdInfoList, 1);
        }
        public override void InitData()
        {
            treeCodeType.DataSource = codeService.GetList().Where(a => a.CodeID == "PROC").Select(i => new { i.Code, i.Description }).OrderBy(a=>a.Code).ToList();
            this.gridPlan.BestFitColumns();
            //eRPC001CodeBindingSource.DataSource = codeService.GetList();  
        }
        public override void OnBtnCommand(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            // MessageBox.Show(e.Item.Caption);
            //新增
            if (e.Item.Caption == BtnCommandEnum.Add)
            {
                if (treeCodeType.FocusedNode[treeColumnCodeID] == null)
                    throw new AppException("请先选择制程");
                this.eRPC006ProcessProdInfoBindingSource.AddNew();
                ERP_C006_ProcessProdInfo temp = eRPC006ProcessProdInfoBindingSource.Current as ERP_C006_ProcessProdInfo;
                temp.ProcessCode = treeCodeType.FocusedNode[treeColumnCodeID].ToStr();
                //temp.CodeIDDesc = treeCodeType.FocusedNode[treeColumnCodeIDDesc] == null ? null : treeCodeType.FocusedNode[treeColumnCodeIDDesc].ToStr();
                EditForm("基础代号新增", BtnCommandEnum.Add);
            }
            else if (e.Item.Caption == BtnCommandEnum.Edit)
            {
                ERP_C006_ProcessProdInfo temp = eRPC006ProcessProdInfoBindingSource.Current as ERP_C006_ProcessProdInfo;
                if(temp==null)
                    throw new AppException("请先选择修改项");
                EditForm("基础代号修改", BtnCommandEnum.Edit);
            }
            else if (e.Item.Caption == BtnCommandEnum.Delete)
            {
                if (ERPHelper.Instance.MessageDel())
                {
                    var temp = eRPC006ProcessProdInfoBindingSource.Current as ERP_C006_ProcessProdInfo;
                    processProdInfoService.Delete(temp.Id);
                    eRPC006ProcessProdInfoBindingSource.RemoveCurrent();
                }
            }
        }

        private void EditForm(string formText, string btnCommand)
        {
            ERP_C006_ProcessProdInfo temp = eRPC006ProcessProdInfoBindingSource.Current as ERP_C006_ProcessProdInfo;
            C006ProcessProdInfoEditForm edit = new C006ProcessProdInfoEditForm(temp);
            edit.Text = formText;
            edit.Tag = btnCommand;
            if (edit.ShowDialog() != DialogResult.OK)
            {
                eRPC006ProcessProdInfoBindingSource.CancelEdit();
            }
        }

        private void treeCodeType_FocusedNodeChanged(object sender, DevExpress.XtraTreeList.FocusedNodeChangedEventArgs e)
        {
            var codeId = e.Node[treeColumnCodeID].ToString();
            this.eRPC006ProcessProdInfoBindingSource.DataSource = processProdInfoService.GetQuery().Where(a => a.ProcessCode == codeId).OrderBy(a=>a.TechSeqNo).ToList();
        }
    }
}