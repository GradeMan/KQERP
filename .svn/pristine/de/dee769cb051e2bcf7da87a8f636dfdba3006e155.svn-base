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
using DevExpress.XtraTreeList.Nodes;
using Util;
namespace ERP.Winform.ESOP
{
    public partial class ESOPDocForm : ListForm
    {
        private IESOP_DocIndexService docIndexService = Unity.Instance.GetService<IESOP_DocIndexService>();
        private IESOP_DocService docService = Unity.Instance.GetService<IESOP_DocService>();
        private ICacheServiceBase appCacheService = Unity.Instance.GetService<ICacheServiceBase>();
        public ESOPDocForm()
        {
            InitializeComponent();
        }
        public override void InitData()
        {
            treeListDocIndx.ParentFieldName = "PreDocIndexId";
            treeListDocIndx.KeyFieldName = "Id";
            tb_Sys_Roles tempRole = appCacheService.GetItem("roles") as tb_Sys_Roles;
            if (tempRole.Roles_Name == "系统管理员")
            {
                this.eSOPDocIndexBindingSource.DataSource = docIndexService.GetDocIndex().OrderBy(a => a.SeqNo).ToList();
            }
            else
            {
                List<Guid> roleList = docIndexService.GetDocIndexSec().Where(a => a.RoleId == tempRole.Id).Select(a => a.DocIndexId).ToList();
                this.eSOPDocIndexBindingSource.DataSource = docIndexService.GetDocIndex().Where(i => roleList.Contains(i.Id)).OrderBy(a => a.SeqNo).ToList();
            }
            
            
        }
        public override void OnBtnCommand(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            // MessageBox.Show(e.Item.Caption);
            //新增
            if (e.Item.Caption == BtnCommandEnum.AddDir)
            {
                this.eSOPDocIndexBindingSource.AddNew();
                EditDirForm(BtnCommandEnum.AddDir);
            }
            else if (e.Item.Caption == BtnCommandEnum.EditDir)
            {
                EditDirForm(BtnCommandEnum.EditDir);
            }
            else if (e.Item.Caption == BtnCommandEnum.AddFile)
            {
                this.eSOPDocBindingSource.AddNew();
                EditForm(BtnCommandEnum.EditDir);
            }
            else if (e.Item.Caption == BtnCommandEnum.DelFile)
            {
                //if (ERPHelper.Instance.MessageDel())
                //{
                //    ESOP_Device temp = eSOPDeviceBindingSource.Current as ESOP_Device;
                //    devService.Delete(temp.Id);
                //    eSOPDeviceBindingSource.RemoveCurrent();
                //}
            }
        }

        private void EditDirForm(string formText)
        {
           
            ESOP_DocIndex temp = this.eSOPDocIndexBindingSource.Current as ESOP_DocIndex;
            ESOPDocIndexEditForm edit = new ESOPDocIndexEditForm(temp);
            edit.Text = formText;
            edit.Tag = formText;
            if (edit.ShowDialog() != DialogResult.OK)
            {
                eSOPDocIndexBindingSource.CancelEdit();
            }
            else
            {
               // InitData();
            }
        }
        private void EditForm(string formText)
        {
            ESOP_Doc temp = this.eSOPDocBindingSource.Current as ESOP_Doc;
            string docIndexId = this.treeListDocIndx.FocusedNode[colId].ToStr();
            temp.DocIndexId = docIndexId.ToGuid();
            ESOPDocEditForm edit = new ESOPDocEditForm(temp);
            edit.Text = formText;
            edit.Tag = formText;
            if (edit.ShowDialog() != DialogResult.OK)
            {
                this.eSOPDocBindingSource.CancelEdit();
            }
            else
            {
                // InitData();
            }
        }
        private void treeListDocIndx_FocusedNodeChanged(object sender, DevExpress.XtraTreeList.FocusedNodeChangedEventArgs e)
        {
            TreeListNode node = this.treeListDocIndx.FocusedNode;
            Guid docIndexId = node[colId].ToStr().ToGuid();
            this.eSOPDocBindingSource.DataSource = docService.GetDocByDocIndex(docIndexId);
        }
        
    }
}
