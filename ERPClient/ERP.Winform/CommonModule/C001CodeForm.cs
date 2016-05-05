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
using Util;
namespace ERP.Winform.CommonModule
{
    public partial class C001CodeForm : ListForm
    {
        private ICodeService codeService = Unity.Instance.GetService<ICodeService>();
        private IERP_C001_CodeDictionaryService codeDicService = Unity.Instance.GetService<IERP_C001_CodeDictionaryService>();
        public C001CodeForm()
        {
            InitializeComponent();
            this.gridView1.DoubleClick+=new EventHandler(gridView1_DoubleClick);
            this.gridView1.CustomDrawRowIndicator+=new DevExpress.XtraGrid.Views.Grid.RowIndicatorCustomDrawEventHandler(ERPHelper.Instance.ykgridview_CustomDrawRowIndicator);
            this.treeCodeType.FocusedNodeChanged += new DevExpress.XtraTreeList.FocusedNodeChangedEventHandler(treeCodeType_FocusedNodeChanged);
        }
       
        void treeCodeType_FocusedNodeChanged(object sender, DevExpress.XtraTreeList.FocusedNodeChangedEventArgs e)
        {
            ERP_C001_CodeDictionary temp = this.eRPC001CodeDictionaryBindingSource.Current as ERP_C001_CodeDictionary;
            eRPC001CodeBindingSource.DataSource = codeService.GetListByCodeID(temp.Code).OrderBy(a => a.Code).ToList();
        }
        public override void InitData()
        {
            var codeDicList = codeDicService.GetQuery().OrderBy(a=>a.Code).ToList();
            treeCodeType.ParentFieldName = "ParentMenuId";
            treeCodeType.KeyFieldName = "Id";
            //treeCodeType.DataSource = codeDicList;
            this.eRPC001CodeDictionaryBindingSource.DataSource = codeDicList;
        }
        public override void OnBtnCommand(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            // MessageBox.Show(e.Item.Caption);
            //新增
            if (e.Item.Caption == BtnCommandEnum.Add)
            {
                ERP_C001_CodeDictionary codeDic = this.eRPC001CodeDictionaryBindingSource.Current as ERP_C001_CodeDictionary;
                if (codeDic == null)
                    throw new AppException("请先选择类别");
                eRPC001CodeBindingSource.AddNew();
                ERP_C001_Code temp = eRPC001CodeBindingSource.Current as ERP_C001_Code;
                temp.CodeID = codeDic.Code;
                temp.CodeIDDesc = codeDic.FullName;
               // temp.CodeID = treeCodeType.FocusedNode[treeColumnCodeID] == null ? null : treeCodeType.FocusedNode[treeColumnCodeID].ToStr();
                //temp.CodeIDDesc = treeCodeType.FocusedNode[treeColumnCodeIDDesc] == null ? null : treeCodeType.FocusedNode[treeColumnCodeIDDesc].ToStr();

                EditForm("基础代号新增", BtnCommandEnum.Add);
                InitData();
            }
            else if (e.Item.Caption == BtnCommandEnum.Edit)
            {
                EditForm("基础代号修改",BtnCommandEnum.Edit);
            }
            else if (e.Item.Caption == BtnCommandEnum.Delete)
            {
                if (ERPHelper.Instance.MessageDel())
                {
                    var temp = eRPC001CodeBindingSource.Current as ERP_C001_Code;
                    if (temp == null)
                        throw new AppException("请先选择要删除的数据");
                    codeService.Delete(temp.Id);
                    eRPC001CodeBindingSource.RemoveCurrent();
                }
            }
            else if (e.Item.Caption == BtnCommandEnum.AddCodeDic)
            {
                eRPC001CodeDictionaryBindingSource.AddNew();
                ERP_C001_CodeDictionary temp = this.eRPC001CodeDictionaryBindingSource.Current as ERP_C001_CodeDictionary;
                temp.ParentId = "0";
                EditDicForm("类型新增", BtnCommandEnum.AddCodeDic);
            }
            else if (e.Item.Caption == BtnCommandEnum.EditCodeDic)
            {
                EditDicForm("类型修改", BtnCommandEnum.EditCodeDic);
            }
        }

        private void EditForm(string formText,string btnCommand)
        {
            ERP_C001_Code temp = eRPC001CodeBindingSource.Current as ERP_C001_Code;
            C001CodeEditForm edit = new C001CodeEditForm(temp);
            edit.Text = formText;
            edit.Tag = btnCommand;
            if (edit.ShowDialog() != DialogResult.OK)
            {
                eRPC001CodeBindingSource.CancelEdit();
            }
        }
        private void EditDicForm(string formText, string btnCommand)
        {
            ERP_C001_CodeDictionary temp = this.eRPC001CodeDictionaryBindingSource.Current as ERP_C001_CodeDictionary;
            CodeDicEditForm edit = new CodeDicEditForm(codeDicService,temp);
            edit.Text = formText;
            edit.Tag = btnCommand;
            if (edit.ShowDialog() != DialogResult.OK)
            {
                eRPC001CodeDictionaryBindingSource.CancelEdit();
            }
            else
            {
                InitData();
            }
        }
        private void gridView1_DoubleClick(object sender, EventArgs e)
        {
            if (this.ButtonList.Where(i => i.Btn_Name == BtnCommandEnum.Edit).Count() > 0)
            {
                EditForm("代码资料查看",BtnCommandEnum.Watch);
            }
        }
    }
}