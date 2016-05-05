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
using DevExpress.XtraTreeList.Nodes;
using Util;
using ERP.Domain;
using DevExpress.XtraEditors;
namespace ERP.Winform.ESOP
{
    public partial class ESOPRoleDevice : EditForm
    {
        private IESOP_DeviceService devService = Unity.Instance.GetService<IESOP_DeviceService>();
        private Guid roleId;
        public ESOPRoleDevice(Guid roleId)
        {
            InitializeComponent();
            this.roleId = roleId;
        }
        protected override void InitData()
        {
            //ERPHelper.Instance.SetGridLookUpEdit(StatusTextEdit, codeService.GetCodeDataByCodeId("IST"), 2);//状态
            treeListOrgan.ParentFieldName = "OrgCode";
            treeListOrgan.KeyFieldName = "OrgCode";
            treeListOrgan.DataSource = devService.GetList();
            treeListOrgan.ExpandAll();
            SetSecurity();
        }
        protected override void OnSetLayoutItemStyle()
        {
            //ERPHelper.Instance.ApplyBindingSettings(ItemForDevName, ItemBindingType.Required);
        }
        protected override void OnBtnCommand(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (e.Item.Caption == BtnCommandEnum.Save)
            {
                foreach (TreeListNode node in treeListOrgan.Nodes)
                {
                    //string ControlsID = node.GetValue(ColumnOrgCode).ToString().Trim(); //获取orgCode 
                    if (node.Checked)
                    {
                        Guid devId = node.GetValue(ColumnDevId).ToString().ToGuid();//获取PermissionID 
                        var roleDeviceData = devService.GetDevIdByRoleId(roleId);
                        if (!roleDeviceData.Contains(devId))
                        {
                            ESOP_RoleDevice userDevice = new ESOP_RoleDevice() { DevId = devId, RoleId = roleId };
                            devService.Create(userDevice);
                        }
                        //BLLSecurity.SaveRolePermission(Roleid, Perid);//保存
                        //SaveTreeList(node);
                    }
                }
                DialogResult = System.Windows.Forms.DialogResult.OK;
            }
            if (e.Item.Caption == BtnCommandEnum.Cancel)
                DialogResult = DialogResult.Cancel;
        }

        /// <summary>
        /// 设置权限
        /// </summary>
        private void SetSecurity()
        {
            var roleDeviceData = devService.GetDevIdByRoleId(roleId);
            //treeListUser.DataSource = dt; //获取角色对应的用户列表
            //treeListUser.ParentFieldName = "UserID";
            // treeListUser.KeyFieldName = "UserID";
            // sql = string.Format("select b.PermissionID,PermissionFatherID,PermissionName from tb_KQMIS_RolePermission a inner join tb_KQMIS_Permission b on b.PermissionID = a.PermissionID where a.RoleID='{0}'", RoleIDTextEdit.Text.Trim());
            // dt2 = DBKQMES.DataToTable(sql);   //获取该角色所具有的功能
            foreach (TreeListNode node in treeListOrgan.Nodes)
            {
                Guid  devId = node.GetValue(ColumnDevId).ToString().ToGuid(); //获取orgCode 

                if (roleDeviceData.Contains(devId))
                {
                    node.Checked = true;
                    //SetTreeListChecks(node);
                }
                else
                {
                    node.Checked = false;
                    //SetTreeListChecks(node);
                }
            }
        }

        private void treeListOrgan_BeforeCheckNode(object sender, DevExpress.XtraTreeList.CheckNodeEventArgs e)
        {
            e.State = (e.PrevState == CheckState.Checked ? CheckState.Unchecked : CheckState.Checked);
        }
    }
}
