using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using ERP.Domain;
using ERP.Service;
using COM.Winform;
using COM.Service;
using DevExpress.XtraTab;
using ERP.Winform.Properties;
using DevExpress.XtraEditors;
namespace ERP.Winform.CommonModule
{
    public partial class ProcessFlowEditForm : EditForm
    {
        private IProcessFlowService processFlowService = Unity.Instance.GetService<IProcessFlowService>();
        private ICodeService codeService = Unity.Instance.GetService<ICodeService>();
        private ERP_C006_ProcessFlow tempData;
        private ERP_C006_ProcessProdInfoService processProdInfoService = Unity.Instance.GetService<ERP_C006_ProcessProdInfoService>();
        private IERP_C006_ProcessFlow_ProdInfoService prodInfoService = Unity.Instance.GetService<IERP_C006_ProcessFlow_ProdInfoService>();
        public ProcessFlowEditForm(ERP_C006_ProcessFlow tempData, IProcessFlowService processFlowService)
        {
            InitializeComponent();
            //this.processFlowService = processFlowService;
            this.tempData = tempData;
            eRPC006ProcessFlowProcessBindingSource.CurrentChanged += eRPC006ProcessFlowProcessBindingSource_CurrentChanged;
            
        }
        //制程改变，筛选对应工艺
        void eRPC006ProcessFlowProcessBindingSource_CurrentChanged(object sender, EventArgs e)
        {
            ERP_C006_ProcessFlow_Process PF = this.eRPC006ProcessFlowProcessBindingSource.Current as ERP_C006_ProcessFlow_Process;
            string filterSql = string.Format("[ProcessCode]= '{0}' ", "999999");
            if (PF != null)
                filterSql = string.Format("[ProcessCode]= '{0}'", PF.ProcessCode);
            this.gridProdInfo.ActiveFilterString = filterSql;
        }

        protected override void OnSetLayoutItemStyle()
        {
            ERPHelper.Instance.ApplyBindingSettings(ItemForCompCode, ItemBindingType.Required);
            ERPHelper.Instance.ApplyBindingSettings(ItemForProcessFlowCode, ItemBindingType.Required);
            ERPHelper.Instance.ApplyBindingSettings(ItemForProcessFlowName, ItemBindingType.Required);
            SetGridLookUpEdit(repositoryItemPROC, codeService.GetCodeDataByCodeId("PROC"));
            SetGridLookUpEdit(repositoryItemPROCPMS, codeService.GetCodeDataByCodeId("PROCPMS"));
            SetGridLookUpEdit(repositoryItemPROCPMSTATUS, codeService.GetCodeDataByCodeId("PROCPMSTATUS"));
        }
        protected override void InitData()
        {
            this.eRPC006ProcessFlowBindingSource.DataSource = tempData;
            this.eRPC006ProcessFlowProcessBindingSource.DataSource = processFlowService.GetProcessFlowDetail(tempData.PFCode).OrderBy(a => a.ProcessSeqNo).ToList();
            this.eRPC006ProcessFlowProdInfoBindingSource.DataSource = prodInfoService.GetQuery().Where(a => a.PFCode == tempData.PFCode).OrderBy(a => a.TechSeqNo).ToList();
        }
        protected override void OnBtnCommand(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (e.Item.Caption == BtnCommandEnum.Save)
            {
                eRPC006ProcessFlowBindingSource.EndEdit();
                this.gridProcess.CloseEditor();
                this.gridProdInfo.CloseEditor();
                var processDetailList = eRPC006ProcessFlowProcessBindingSource.DataSource as List<ERP_C006_ProcessFlow_Process>;
                var prodInfoList = eRPC006ProcessFlowProdInfoBindingSource.DataSource as List<ERP_C006_ProcessFlow_ProdInfo>;
                processFlowService.Save(tempData, processDetailList, prodInfoList);
                DialogResult = DialogResult.OK;
            }
            if (e.Item.Caption == BtnCommandEnum.Cancel)
                DialogResult = DialogResult.Cancel;
        }

        private void ProcessFlowEditForm_Load(object sender, EventArgs e)
        {
            CreateToolBar();
        }
        protected override void CreateToolBar()
        {
            if (this.xtraTabControl1.SelectedTabPageIndex != 0)
            {
                base.CreateToolBar();
            }
            else
            {
                XtraTabPage page = this.xtraTabControl1.SelectedTabPage;
                foreach (var contr in page.Controls)
                {
                    if (contr is ToolStrip)
                    {
                        ((ToolStrip)contr).Visible = true;
                        return;
                    }
                }
                ToolStrip toolStrip = new ToolStrip();
                ToolStripButton btnAdd = new ToolStripButton();
                btnAdd.Text = "新增制程";
                btnAdd.Image = (Image)Resources.ResourceManager.GetObject("AddToLibrary_32x32");
                btnAdd.TextImageRelation = TextImageRelation.ImageBeforeText;
                btnAdd.DisplayStyle = ToolStripItemDisplayStyle.ImageAndText;
                btnAdd.Click += new EventHandler(btnAdd_Click);
                toolStrip.Items.Add(btnAdd);

                ToolStripSeparator toolSep = new ToolStripSeparator();
                toolStrip.Items.Add(toolSep);
                ToolStripButton btnDel = new ToolStripButton();

                btnDel.Text = "删除制程";
                btnDel.Image = (Image)Resources.ResourceManager.GetObject("Remove_32x32");
                btnDel.DisplayStyle = ToolStripItemDisplayStyle.ImageAndText;
                btnDel.TextImageRelation = TextImageRelation.ImageBeforeText;
                btnDel.Click += new EventHandler(btnDel_Click);
                toolStrip.Items.Add(btnDel);

                ToolStripSeparator toolSep2 = new ToolStripSeparator();
                toolStrip.Items.Add(toolSep2);

                ToolStripButton btnAddProdInfo = new ToolStripButton();
                btnAddProdInfo.Text = "新增制程参数";
                btnAddProdInfo.Image = (Image)Resources.ResourceManager.GetObject("AddToLibrary_32x32");
                btnAddProdInfo.TextImageRelation = TextImageRelation.ImageBeforeText;
                btnAddProdInfo.DisplayStyle = ToolStripItemDisplayStyle.ImageAndText;
                btnAddProdInfo.Click += btnAddProdInfo_Click;
                toolStrip.Items.Add(btnAddProdInfo);

                ToolStripSeparator toolSep3 = new ToolStripSeparator();
                toolStrip.Items.Add(toolSep3);

                ToolStripButton btnDelProdInfo = new ToolStripButton();
                btnDelProdInfo.Text = "删除制程参数";
                btnDelProdInfo.Image = (Image)Resources.ResourceManager.GetObject("Remove_32x32");
                btnDelProdInfo.TextImageRelation = TextImageRelation.ImageBeforeText;
                btnDelProdInfo.DisplayStyle = ToolStripItemDisplayStyle.ImageAndText;
                btnDelProdInfo.Click += btnDelProdInfo_Click;
                toolStrip.Items.Add(btnDelProdInfo);

                toolStrip.Dock = DockStyle.Top;
                toolStrip.BringToFront();
                page.Controls.Add(toolStrip);

            }
        }
        void btnDel_Click(object sender, EventArgs e)
        {
            var temp = eRPC006ProcessFlowProcessBindingSource.Current as ERP_C006_ProcessFlow_Process;
            //processFlowService.MarkDelProcessFlowDetail(temp.Id);
            var processInfos = this.eRPC006ProcessFlowProdInfoBindingSource.DataSource as List<ERP_C006_ProcessFlow_ProdInfo>;
            var processInfoTemp = processInfos.Where(a => a.ProcessCode == temp.ProcessCode && a.PFCode == temp.PFCode).ToList();
            foreach (var processInfo in processInfoTemp)
            {
                //ykdbContext.Set<ERP_C006_ProcessFlow_ProdInfo>().Remove(processInfo);
                this.eRPC006ProcessFlowProdInfoBindingSource.Remove(processInfo);
            }
            eRPC006ProcessFlowProcessBindingSource.RemoveCurrent();
        }

        void btnAdd_Click(object sender, EventArgs e)
        {
            this.eRPC006ProcessFlowBindingSource.EndEdit();
            var tempData = this.eRPC006ProcessFlowBindingSource.DataSource as ERP_C006_ProcessFlow;
            // string jobNo = this.JobNoTextEdit.Text;
            if (string.IsNullOrWhiteSpace(tempData.PFCode))
            {
                XtraMessageBox.Show("流程代号为空，请先输入流程代号");
                return;
            }
            eRPC006ProcessFlowProcessBindingSource.AddNew();
            var tempDetail = this.eRPC006ProcessFlowProcessBindingSource.Current as ERP_C006_ProcessFlow_Process;
            tempDetail.PFCode = tempData.PFCode;
        }

        /// <summary>
        /// dbo.ERP_C006_ProcessFlow_ProdInfo删除
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        void btnDelProdInfo_Click(object sender, EventArgs e)
        {

            if (this.gridProdInfo.SelectedRowsCount <= 0)
                throw new ApplicationException("请先选择要删除的行");
            ERP_C006_ProcessFlow_ProdInfo tbtemp = this.eRPC006ProcessFlowProdInfoBindingSource.Current as ERP_C006_ProcessFlow_ProdInfo;
            eRPC006ProcessFlowProdInfoBindingSource.RemoveCurrent();
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        void btnAddProdInfo_Click(object sender, EventArgs e)
        {
            if (this.gridProcess.SelectedRowsCount == 0)
                throw new ApplicationException("请先选择制程");
            this.gridProcess.CloseEditor();

            var PFP = this.eRPC006ProcessFlowProcessBindingSource.Current as ERP_C006_ProcessFlow_Process;
            if (string.IsNullOrEmpty(PFP.PFCode))
                throw new ApplicationException("请先输入流程代号");
            if (string.IsNullOrEmpty(PFP.ProcessCode))
                throw new ApplicationException("请先输入制程信息");
            ERP_C006_ProcessFlow_ProdInfo processProdInfo = new ERP_C006_ProcessFlow_ProdInfo();
            //ERP_C006_ProcessFlow_ProdInfo processProdInfo = this.eRPC006ProcessFlowProdInfoBindingSource.Current as ERP_C006_ProcessFlow_ProdInfo;
            processProdInfo.PFCode = PFP.PFCode;
            processProdInfo.ProcessCode = PFP.ProcessCode;
            this.eRPC006ProcessFlowProdInfoBindingSource.Add(processProdInfo);
        }

        //制程信息改变，对应的工艺参数改变
        private void gridProcess_CellValueChanged(object sender, DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs e)
        {
            if (e.Column == colProcessCode)
            {
                if (this.gridProcess.EditingValueModified)
                {
                    if (this.gridProdInfo.SelectedRowsCount == 0)
                    {
                        ERP_C006_ProcessFlow_Process PF = this.eRPC006ProcessFlowProcessBindingSource.Current as ERP_C006_ProcessFlow_Process;
                        if (PF != null && !string.IsNullOrEmpty(PF.ProcessCode))
                        {
                            PF.ProcessType = codeService.GetList().Where(a => a.CodeID == "PROC" && a.Code == PF.ProcessCode).FirstOrDefault().GroupName;
                            var prodInfos = processProdInfoService.GetQuery().Where(a => a.ProcessCode == PF.ProcessCode).ToList()
                                .Select(a => new ERP_C006_ProcessFlow_ProdInfo() { PFCode = PF.PFCode, ProcessCode = a.ProcessCode, TechSeqNo = a.TechSeqNo, TechType = a.TechType, IsVisible = a.IsVisible, TechCode = a.TechCode, TechContent = a.TechContent }).ToList();
                            foreach (var prodInfo in prodInfos)
                            {
                                this.eRPC006ProcessFlowProdInfoBindingSource.Add(prodInfo);
                            }
                            eRPC006ProcessFlowProcessBindingSource_CurrentChanged(null, null);
                        }
                    }
                }
            }
        }
    }
}
