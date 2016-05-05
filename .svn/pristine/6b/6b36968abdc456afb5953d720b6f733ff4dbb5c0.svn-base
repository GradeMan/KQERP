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
using COM.Service;
using ERP.Domain;
using ERP.Service;
using DevExpress.XtraTab;
using ERP.Winform.Properties;
namespace ERP.Winform.Order
{
    public partial class JobEditForm : EditForm
    {
        private IJobService jobService = Unity.Instance.GetService<IJobService>();
        private ICustomerService customerService = Unity.Instance.GetService<ICustomerService>();
        private ICodeService codeService = Unity.Instance.GetService<ICodeService>();
        private IProcessFlowService processFlowService = Unity.Instance.GetService<IProcessFlowService>();
        private MES_M002_Job jobData;
        public JobEditForm(MES_M002_Job jobData)
        {
            InitializeComponent();
            this.jobData = jobData;
        }
        protected override void InitData()
        {
            ERPHelper.Instance.SetGridLookUpEdit(CustCodeTextEdit,customerService.GetCustomerInputData(),2);//客户
            ERPHelper.Instance.SetGridLookUpEdit(StatusTextEdit,codeService.GetCodeDataByCodeId("ST"), 2);//状态
            ERPHelper.Instance.SetGridLookUpEdit(ProcessFlowTextEdit, processFlowService.GetProcessFlowInputData(), 2);//工艺流程
            CustCodeTextEdit.EditValueChanging += new DevExpress.XtraEditors.Controls.ChangingEventHandler(CustCodeTextEdit_EditValueChanging);
            StatusTextEdit.EditValueChanging += new DevExpress.XtraEditors.Controls.ChangingEventHandler(CustCodeTextEdit_EditValueChanging);
            ProcessFlowTextEdit.EditValueChanging += new DevExpress.XtraEditors.Controls.ChangingEventHandler(CustCodeTextEdit_EditValueChanging);
            this.gridView1.CellValueChanged += new DevExpress.XtraGrid.Views.Base.CellValueChangedEventHandler(gridView1_CellValueChanged);
            this.gridView1.RowCountChanged += new EventHandler(gridView1_RowCountChanged);
            this.gridView1.FocusedRowChanged += new DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventHandler(gridView1_FocusedRowChanged);
            this.mESM002JobBindingSource.DataSource = jobData;
            this.mESM002JobLotBindingSource.DataSource = jobService.GetJobLotListByJobNo(jobData.JobNo);
            this.mESM002JobLotProcessBindingSource.DataSource = new List<MES_M002_Job_Lot_Process>();
        }

        void CustCodeTextEdit_EditValueChanging(object sender, DevExpress.XtraEditors.Controls.ChangingEventArgs e)
        {
            this.BeginInvoke(new System.Windows.Forms.MethodInvoker(delegate
            {
                ERPHelper.Instance.FilterLookup(sender);
            }));
        }
        void gridView1_RowCountChanged(object sender, EventArgs e)
        {
            SetJobQtyAndLotCount();
        }

        void gridView1_CellValueChanged(object sender, DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs e)
        {
            if (e.Column == colLotQty)
            {
                SetJobQtyAndLotCount();
            }
            else if (e.Column == colLotNo)
            {
                MES_M002_Job_Lot lotMsg = this.mESM002JobLotBindingSource.Current as MES_M002_Job_Lot;
                if (lotMsg != null)
                {
                    this.mESM002JobLotProcessBindingSource.DataSource = GetProcessList(lotMsg.JobNo, lotMsg.LotNo);
                    this.gridView4.RefreshData();
                }
            }
        }
        /// <summary>
        /// 根据Lot信息改变
        /// </summary>
        void SetJobQtyAndLotCount()
        {
            var jobLotList = this.mESM002JobLotBindingSource.DataSource as List<MES_M002_Job_Lot>;
            var jobData = this.mESM002JobBindingSource.DataSource as MES_M002_Job;
            if (jobLotList == null || jobData == null)
                return;
            decimal jobQty = jobLotList.Sum(i => i.LotQty);
            decimal lotCount = jobLotList.Count();
            jobData.JobQty = jobQty;
            jobData.LotCount = lotCount;
            this.mESM002JobBindingSource.ResetCurrentItem();
        }
        void gridView1_DataSourceChanged(object sender, EventArgs e)
        {
            XtraMessageBox.Show("改变国");
        }

        protected override void SetToolBarItem()
        {
            base.SetToolBarItem();
            if (this.Tag == null) return;
            if(this.Tag.ToString() == BtnCommandEnum.Add || this.Tag.ToString() == BtnCommandEnum.Edit)
                OnAddToolBtn("生成Lot", null);
        }
        protected override void OnSetLayoutItemStyle()
        {
            ERPHelper.Instance.ApplyBindingSettings(ItemForJobNo, ItemBindingType.Required);
        }
        protected override void OnBtnCommand(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (e.Item.Caption == BtnCommandEnum.Save)
            {
                mESM002JobBindingSource.EndEdit();
                mESM002JobLotBindingSource.EndEdit();
                var job = this.mESM002JobBindingSource.DataSource as MES_M002_Job;
                var jobLotList = this.mESM002JobLotBindingSource.DataSource as List<MES_M002_Job_Lot>;
                List<MES_M002_Job_Lot_Process> jobLotProcessList = new List<MES_M002_Job_Lot_Process>();
                if (jobLotList != null)
                {
                    foreach (var lot in jobLotList)
                        jobLotProcessList.AddRange(GetProcessList(lot.JobNo, lot.LotNo));
                }
                this.jobService.Save(job, jobLotList, jobLotProcessList);
                DialogResult = DialogResult.OK;
            }
            if (e.Item.Caption == BtnCommandEnum.Cancel)
                DialogResult = DialogResult.Cancel;
            if (e.Item.Caption == BtnCommandEnum.CreateLot)
            {
                if (string.IsNullOrWhiteSpace(this.ProcessFlowTextEdit.Text))
                {
                    XtraMessageBox.Show("请先输入流程号");
                    return;
                }
                decimal lotCount = LotCountSpinEdit.Value;//Lot数
                decimal jobQty = JobQtySpinEdit.Value;//工单数量
                decimal specPanelStrip = StripPerPanelEdit.Value;//每板数量
                decimal panelQty = PainQtyEdit.Value;//板数量
                string jobNo = JobNoTextEdit.Text.Trim();
                if (lotCount>0)
                {
                    if (ERPHelper.Instance.MessageIf("是否要重新生成Lot？"))
                    {
                        jobService.DeleteLotByJobNo(jobNo);//先删除数据库里的Job对应的Lot信息
                        
                    }
                }
               var jobLotList = jobService.CreateJobLots(jobQty, panelQty, specPanelStrip, jobNo);
               mESM002JobLotBindingSource.DataSource = jobLotList;
            }
        }

        private void JobEditForm_Load(object sender, EventArgs e)
        {
            CreateToolBar();
        }

        private void CreateToolBar()
        {
            XtraTabPage page = this.xtraTabControl1.SelectedTabPage;
            foreach (var contr in page.Controls)
            {
                if (contr is ToolStrip)
                    return;
            }
            ToolStrip toolStrip = new ToolStrip();
            ToolStripButton btnAdd = new ToolStripButton();
            btnAdd.Text = "新增明细";
            btnAdd.Image = (Image)Resources.ResourceManager.GetObject("edit_add");
            btnAdd.TextImageRelation = TextImageRelation.ImageAboveText;
            btnAdd.DisplayStyle = ToolStripItemDisplayStyle.ImageAndText;
            btnAdd.Click += new EventHandler(btnAdd_Click);
            toolStrip.Items.Add(btnAdd);
            ToolStripSeparator toolSep = new ToolStripSeparator();
            toolStrip.Items.Add(toolSep);
            ToolStripButton btnDel = new ToolStripButton();
            btnDel.Text = "删除明细";
            btnDel.Image = (Image)Resources.ResourceManager.GetObject("cancel");
            btnDel.DisplayStyle = ToolStripItemDisplayStyle.ImageAndText;
            btnDel.TextImageRelation = TextImageRelation.ImageAboveText;
            btnDel.Click += new EventHandler(btnDel_Click);
            toolStrip.Items.Add(btnDel);
            toolStrip.Dock = DockStyle.Top;
            toolStrip.BringToFront();
            page.Controls.Add(toolStrip);
        }

        void btnDel_Click(object sender, EventArgs e)
        {
            var temp = mESM002JobLotBindingSource.Current as MES_M002_Job_Lot;
            jobService.MarkDelLot(temp.Id);
            mESM002JobLotBindingSource.RemoveCurrent();
        }

        void btnAdd_Click(object sender, EventArgs e)
        {
            this.mESM002JobBindingSource.EndEdit();
            var jobData = this.mESM002JobBindingSource.DataSource as MES_M002_Job;
           // string jobNo = this.JobNoTextEdit.Text;
            if (string.IsNullOrWhiteSpace(jobData.JobNo))
            {
                XtraMessageBox.Show("工作单位为空，请先输入工作单号");
                return;
            }
            mESM002JobLotBindingSource.AddNew();
            var jobLot = this.mESM002JobLotBindingSource.Current as MES_M002_Job_Lot;
            jobLot.JobNo = jobData.JobNo;
        }
        /// <summary>
        /// Lot行改变重新加载Process数据
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void gridView1_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            MES_M002_Job_Lot lotMsg = this.mESM002JobLotBindingSource.Current as MES_M002_Job_Lot;
            if (lotMsg != null)
            {
                this.mESM002JobLotProcessBindingSource.DataSource = GetProcessList(lotMsg.JobNo, lotMsg.LotNo);
                this.gridView4.RefreshData();
            }
        }

        private void gridView1_CellValueChanged_1(object sender, DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs e)
        {
           
        }

        private List<MES_M002_Job_Lot_Process> GetProcessList(string jobNo,string lotNo)
        {
            if (ProcessFlowTextEdit.EditValue == null) return null;
            string processFlowCode = ProcessFlowTextEdit.EditValue.ToString();
            var processList = processFlowService.GetProcessFlowDetail(processFlowCode);
            var jobProcessList = processList.Select(i => new MES_M002_Job_Lot_Process()
                {
                    JobNo = jobNo,
                    LotNo = lotNo,
                    ProcessCode = i.Process,
                    SeqNo = i.SeqNo,
                }).ToList();
            return jobProcessList;
        }
    }
}