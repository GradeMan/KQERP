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
using COM.Domain;
namespace ERP.Winform.Order
{
    public partial class LotEditForm : EditForm
    {
        private ILotTxService lotTxService = Unity.Instance.GetService<ILotTxService>();
        private ICodeService codeService = Unity.Instance.GetService<ICodeService>();
        private Itb_Sys_ControlsService controlService = Unity.Instance.GetService<Itb_Sys_ControlsService>();
        private MES_M003_LotTx lotTxData;
        private BindingSource lotTxBindingSouce;
        private ICacheServiceBase appCacheService = Unity.Instance.GetService<ICacheServiceBase>();
        private IJobService jobService = Unity.Instance.GetService<IJobService>();
        public IJobReportService jobReportService = Unity.Instance.GetService<IJobReportService>();
        public LotEditForm(BindingSource lotTxBindingSouce)
        {
            InitializeComponent();
            this.lotTxData = lotTxBindingSouce.Current as MES_M003_LotTx;
            this.lotTxBindingSouce = lotTxBindingSouce;
        }
        protected override void InitData()
        {
            gvLotTx_NG.CellValueChanged += new DevExpress.XtraGrid.Views.Base.CellValueChangedEventHandler(gvLotTx_NG_CellValueChanged);
            JobNoTextEdit.EditValueChanged += new EventHandler(JobNoTextEdit_EditValueChanged);
            var roles = appCacheService.GetItem("roles") as tb_Sys_Roles;
            var controlDataList = controlService.GetlistByRolesId(roles.Id).Where(i => i.Windows == "MES_M003_LotTx" && i.Control == "ProcessCode").Select(i => i.CValue).ToList();
            var ProcessData = codeService.GetCodeDataByCodeId("PRC");
            if (controlDataList.Count > 0)
                ProcessData = ProcessData.Where(i => controlDataList.Contains(i.Value)).ToList(); //数据权限筛选制程
            ERPHelper.Instance.SetGridLookUpEdit(ProcessCodeTextEdit, ProcessData, 2,false);//制程
            string processCode = Util.AppConfig.Instance.AppConfigGet("ProcessCode");
            if (ProcessData.Where(i => i.Value == processCode).ToList().Count > 0)
                this.lotTxData.ProcessCode = processCode;
            ERPHelper.Instance.SetGridLookUpEdit(JobNoTextEdit, jobService.GetInputDataList(), 2, false);//工单号
            ERPHelper.Instance.SetGridLookUpEdit(ShiftCodeTextEdit, codeService.GetCodeDataByCodeId("BC"), 2);//班次
            ERPHelper.Instance.SetGridLookUpEdit(OperatorTextEdit, codeService.GetCodeDataByCodeId("BC"), 2);//操作员
            ERPHelper.Instance.SetGridLookUpEdit(MacCodeTextEdit, codeService.GetCodeDataByCodeId("BC"), 2);//机台
            repositoryItemProcessCode.DataSource = ProcessData;
            repositoryItemProcessCode.DisplayMember = "DisPlayName";
            repositoryItemProcessCode.ValueMember = "Value";
            ShiftCodeTextEdit.EditValueChanging += new DevExpress.XtraEditors.Controls.ChangingEventHandler(ShiftCodeTextEdit_EditValueChanging);
            OperatorTextEdit.EditValueChanging += new DevExpress.XtraEditors.Controls.ChangingEventHandler(ShiftCodeTextEdit_EditValueChanging);
            MacCodeTextEdit.EditValueChanging += new DevExpress.XtraEditors.Controls.ChangingEventHandler(ShiftCodeTextEdit_EditValueChanging);
            ProcessCodeTextEdit.EditValueChanging += new DevExpress.XtraEditors.Controls.ChangingEventHandler(ShiftCodeTextEdit_EditValueChanging);

            this.mESM003LotTxBindingSource.DataSource = lotTxData;
            this.gridControl2.DataSource = lotTxService.GetListByJobNo(lotTxData.JobNo);
            this.mESM003LotTxNGBindingSource.DataSource = lotTxService.GetLotTxNGListByLotNo(lotTxData.LotNo);
            
        }
        /// <summary>
        /// 根据工作单改变加载lot下拉信息
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        void JobNoTextEdit_EditValueChanged(object sender, EventArgs e)
        {
            //1.0根据JobNo 加载LotNo
            var jobLotList = jobService.GetJobLotListByJobNo(JobNoTextEdit.EditValue.ToString().Trim());
            var lotNoExistList = this.lotTxService.GetListByJobNo(JobNoTextEdit.EditValue.ToString().Trim()).Select(i => i.LotNo).ToList();
            jobLotList = jobLotList.Where(i => !lotNoExistList.Contains(i.LotNo) || i.LotNo == this.lotTxData.LotNo).ToList();
            var jobLotInpute = jobLotList.Select(i => new InputItem { DisPlayName = i.LotNo, Value = i.LotNo}).ToList();
            ERPHelper.Instance.SetGridLookUpEdit(LotNoTextEdit, jobLotInpute, 2,false);//LotNo
           //2.0列出此jobNo下所有LotNo信息
            this.gridControl2.DataSource = this.lotTxService.GetListByJobNo(JobNoTextEdit.EditValue.ToString().Trim());
           //3.0根据JobNo加载Job信息在Top上展示
            if (string.IsNullOrWhiteSpace(this.lotTxData.JobNo))
                this.vwJobReportBindingSource.DataSource = new vw_JobReport();
            else
                this.vwJobReportBindingSource.DataSource = jobReportService.GetByJobNoList(this.lotTxData.JobNo, null).JobReportHeaderList.FirstOrDefault();
        }

        void ShiftCodeTextEdit_EditValueChanging(object sender, DevExpress.XtraEditors.Controls.ChangingEventArgs e)
        {
            this.BeginInvoke(new System.Windows.Forms.MethodInvoker(delegate
            {
                ERPHelper.Instance.FilterLookup(sender);
            }));
        }

        void gvLotTx_NG_CellValueChanged(object sender, DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs e)
        {
            var lotNgList = this.mESM003LotTxNGBindingSource.DataSource as List<MES_M003_LotTx_NG>;
            if (e.Column == colQty)
            {
                lotTxData.NGQty = lotNgList.Sum(i => i.Qty);
                //this.mESM003LotTxBindingSource.ResetCurrentItem();
            }
            if (e.Column == colCriteriaCode) //判断报废类别有没有重复
            {
                int CriteriaCodeCount = lotNgList.Where(i => i.CriteriaCode == e.Value.ToString()).Count();
                if (CriteriaCodeCount > 1)
                {
                    XtraMessageBox.Show("报废类别不能重复");
                    this.gvLotTx_NG.SetFocusedRowCellValue(e.Column, null);
                }
            }
        }

        protected override void OnSetLayoutItemStyle()
        {
            ERPHelper.Instance.ApplyBindingSettings(ItemForLotNo, ItemBindingType.Required);
            ERPHelper.Instance.ApplyBindingSettings(ItemForMacCode, ItemBindingType.Required);
        }

        protected override void OnBtnCommand(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (e.Item.Caption == BtnCommandEnum.Save)
            {
                Save();
                DialogResult = DialogResult.OK;
            }
            if (e.Item.Caption == BtnCommandEnum.Cancel)
                DialogResult = DialogResult.Cancel;
            if (e.Item.Caption == BtnCommandEnum.SaveAndNew)
            {
                Save();
                this.lotTxBindingSouce.AddNew();
                var lottxNew = this.lotTxBindingSouce.Current as MES_M003_LotTx;
                lottxNew.JobNo = this.lotTxData.JobNo;
                lottxNew.ProcessCode = this.lotTxData.ProcessCode;
                lottxNew.TxDt = this.lotTxData.TxDt;
                //this.lotTxData = lottxNew;
                this.mESM003LotTxBindingSource.DataSource = lottxNew;
                this.lotTxData = this.mESM003LotTxBindingSource.DataSource as MES_M003_LotTx;
                JobNoTextEdit_EditValueChanged(null, null);

            }
        }
        private void Save()
        {
            mESM003LotTxBindingSource.EndEdit();
            mESM003LotTxNGBindingSource.EndEdit();
            var LotTxNGList = this.mESM003LotTxNGBindingSource.DataSource as List<MES_M003_LotTx_NG>;
            this.lotTxService.Save(lotTxData, LotTxNGList);
        }
        protected override void SetToolBarItem()
        {
            base.SetToolBarItem();
            if (this.Tag == null) return;
            if (this.Tag.ToString() == BtnCommandEnum.Add || this.Tag.ToString() == BtnCommandEnum.Edit)
            {
                OnAddToolBtn("保存并新增", "SaveAndNew");
                OnAddToolBtn("导入报废", null);
            }
        }
        private void LotEditForm_Load(object sender, EventArgs e)
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
            var temp = mESM003LotTxNGBindingSource.Current as MES_M003_LotTx_NG;
            lotTxService.MarkDelLotTxNG(temp.Id);
            mESM003LotTxNGBindingSource.RemoveCurrent();
        }

        void btnAdd_Click(object sender, EventArgs e)
        {
            mESM003LotTxNGBindingSource.AddNew();
            var lotTxng = this.mESM003LotTxNGBindingSource.Current as MES_M003_LotTx_NG;
            lotTxng.LotNo = this.lotTxData.LotNo;
        }
    }
}