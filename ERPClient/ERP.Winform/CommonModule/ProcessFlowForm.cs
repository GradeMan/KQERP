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
using ERP.Domain;
using COM.Service;
namespace ERP.Winform.CommonModule
{
    public partial class ProcessFlowForm : ListForm
    {
        private IProcessFlowService processFlowService = Unity.Instance.GetService<IProcessFlowService>();
        private IERP_C006_ProcessFlow_ProdInfoService prodInfoService = Unity.Instance.GetService<IERP_C006_ProcessFlow_ProdInfoService>();
        private ICodeService codeService = Unity.Instance.GetService<ICodeService>();
        public ProcessFlowForm()
        {
            InitializeComponent();
            //this.gridView1.DoubleClick+=new EventHandler(gridView1_DoubleClick);
            this.gridView1.CustomDrawRowIndicator += new DevExpress.XtraGrid.Views.Grid.RowIndicatorCustomDrawEventHandler(ERPHelper.Instance.ykgridview_CustomDrawRowIndicator);
            eRPC006ProcessFlowBindingSource.CurrentChanged += eRPC006ProcessFlowBindingSource_CurrentChanged;
            eRPC006ProcessFlowProcessBindingSource.CurrentChanged += eRPC006ProcessFlowProcessBindingSource_CurrentChanged;
        }

        void eRPC006ProcessFlowProcessBindingSource_CurrentChanged(object sender, EventArgs e)
        {
            ERP_C006_ProcessFlow_Process PF = this.eRPC006ProcessFlowProcessBindingSource.Current as ERP_C006_ProcessFlow_Process;
            string filterSql = string.Format("[ProcessCode]= '{0}' ", "999999");
            if (PF != null)
                filterSql = string.Format("[ProcessCode]= '{0}'", PF.ProcessCode);
            this.gridProdInfo.ActiveFilterString = filterSql;
        }

        void eRPC006ProcessFlowBindingSource_CurrentChanged(object sender, EventArgs e)
        {
            ERP_C006_ProcessFlow temp = eRPC006ProcessFlowBindingSource.Current as ERP_C006_ProcessFlow;
            if (temp != null)
            {
                this.eRPC006ProcessFlowProcessBindingSource.DataSource = processFlowService.GetProcessFlowDetail(temp.PFCode).OrderBy(a => a.ProcessSeqNo).ToList();
                this.eRPC006ProcessFlowProdInfoBindingSource.DataSource = prodInfoService.GetQuery().Where(a => a.PFCode == temp.PFCode).OrderBy(a=>a.TechSeqNo).ToList();
            }
        }
        public override void OnAttachEvent()
        {
            SetGridLookUpEdit(repositoryItemPROC, codeService.GetCodeDataByCodeId("PROC"));
            SetGridLookUpEdit(repositoryItemPROCPMS, codeService.GetCodeDataByCodeId("PROCPMS"));
            SetGridLookUpEdit(repositoryItemPROCPMSTATUS, codeService.GetCodeDataByCodeId("PROCPMSTATUS"));
        }
        public override void InitData()
        {
            eRPC006ProcessFlowBindingSource.DataSource = processFlowService.GetList();

        }
        public override void OnBtnCommand(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            // MessageBox.Show(e.Item.Caption);
            //新增
            if (e.Item.Caption == BtnCommandEnum.Add)
            {
                eRPC006ProcessFlowBindingSource.AddNew();
                OpenForm("流程资料新增", BtnCommandEnum.Add);
            }
            else if (e.Item.Caption == BtnCommandEnum.Edit)
            {
                OpenForm("流程资料修改", BtnCommandEnum.Edit);
            }
            else if (e.Item.Caption == BtnCommandEnum.Delete)
            {
                if (ERPHelper.Instance.MessageDel())
                {
                    ERP_C006_ProcessFlow temp = eRPC006ProcessFlowBindingSource.Current as ERP_C006_ProcessFlow;
                    processFlowService.Delete(temp.Id);
                    //eRPC003CustomerBindingSource.RemoveCurrent();
                }
            }
        }
        private void OpenForm(string formText, string btnCommand)
        {
            ERP_C006_ProcessFlow temp = eRPC006ProcessFlowBindingSource.Current as ERP_C006_ProcessFlow;
            ProcessFlowEditForm edit = new ProcessFlowEditForm(temp, processFlowService);
            edit.Text = formText;
            edit.Tag = btnCommand;
            if (edit.ShowDialog() != DialogResult.OK)
            {
                eRPC006ProcessFlowBindingSource.CancelEdit();
            }
            else
            {
                eRPC006ProcessFlowBindingSource_CurrentChanged(null, null);
            }
        }

        private void gridView1_DoubleClick(object sender, EventArgs e)
        {
            OpenForm("流程资料查看", BtnCommandEnum.Watch);
        }
    }
}
