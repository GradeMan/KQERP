using COM.Service;
using COM.Winform;
using DevExpress.XtraTab;
using ERP.Service;
using ERP.Winform.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using ERP.Domain;
using Util;
using System.IO;
using DevExpress.XtraEditors;
using DevExpress.XtraBars;
using ERP.Winform.CommonModule;
namespace ERP.Winform.MES
{
    public partial class MES501JobTxEditForm : ListForm
    {
        private ICodeService codeService = Unity.Instance.GetService<ICodeService>();
        private IMES_M501_JobTxService jobtxService = Unity.Instance.GetService<IMES_M501_JobTxService>();
        private IMES_M202_TaskService taskService = Unity.Instance.GetService<IMES_M202_TaskService>();
        private string IniFilePath = "D:\\MIS\\Project\\KQERP\\KQERP.INI";
        private IProductService productService = Unity.Instance.GetService<IProductService>();
        private IMES_M202_Task_JobLotService taskJobLotService = Unity.Instance.GetService<IMES_M202_Task_JobLotService>();
        public MES501JobTxEditForm()
        {
            InitializeComponent();
        }
        public override void OnAttachEvent()
        {
            //base.OnAttachEvent();
            dataLayoutControl1.OptionsView.IsReadOnly = DevExpress.Utils.DefaultBoolean.True;
            this.mESM501JobTxBindingSource.CurrentChanged += mESM501JobTxBindingSource_CurrentChanged;
            SetGridLookUpEdit(ProcessCodeTextEdit, codeService.GetCodeDataByCodeId("PROC"), 0);
            SetGridLookUpEdit(txtProcessCode, codeService.GetCodeDataByCodeId("PROC"), 0);
            SetGridLookUpEdit(repositoryItemPROCPMS, codeService.GetCodeDataByCodeId("PROCPMS"));
            SetGridLookUpEdit(repositoryItemPROCPMSTATUS, codeService.GetCodeDataByCodeId("PROCPMSTATUS"));
            if (File.Exists(IniFilePath))
            {
                INIFile inifile = new INIFile(IniFilePath);
                var processCodes = inifile.IniReadValue("JobLot", "ProcessCode").Split(',').ToList();
                StringBuilder strSql = new StringBuilder();
                for (int i = 0; i < processCodes.Count; i++)
                {
                    if (!string.IsNullOrEmpty(processCodes[i]))
                    {
                        if (i == 0)
                            strSql.AppendFormat("[Value]= '{0}'", processCodes[i]);
                        else
                            strSql.AppendFormat(" Or [Value]= '{0}'", processCodes[i]);
                    }
                }
                ProcessCodeTextEdit.Properties.View.ActiveFilterString = strSql.ToString();
                ProcessCodeTextEdit.EditValue = processCodes[0];
                ShowLayForm(ProcessCodeTextEdit.Text);
            }
        }
        /// <summary>
        /// 主表改变事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        void mESM501JobTxBindingSource_CurrentChanged(object sender, EventArgs e)
        {
            var jobtx = (this.mESM501JobTxBindingSource.Current as MES_M501_JobTx)?? new MES_M501_JobTx();
            this.mESM501JobTxDetailBindingSource.DataSource = jobtxService.GetJobTxDetailQuery().Where(a => a.JobNo == jobtx.JobNo&&a.ProcessCode == jobtx.ProcessCode).ToList();
            this.mESM501JobTxProdInfoBindingSource.DataSource = jobtxService.GetJobTxProdInfoQuery().Where(a => a.JobNo == jobtx.JobNo && a.PFCode == jobtx.PFCode && a.ProcessCode == jobtx.ProcessCode).OrderBy(a=>a.TechSeqNo).ToList();
        }
        public override void InitData()
        {
            this.mESM501JobTxBindingSource.DataSource = jobtxService.GetList();
            this.gridTask.BestFitColumns();
        }

        public override void OnBtnCommand(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (e.Item.Caption == BtnCommandEnum.Add)
            {
                this.mESM501JobTxBindingSource.AddNew();
                toolStrip1.Visible = true;
                dataLayoutControl1.OptionsView.IsReadOnly = DevExpress.Utils.DefaultBoolean.False;
                gridJobTxDetail.OptionsBehavior.ReadOnly = false;
                gridControlJobTx.Enabled = false;
            }
            else if (e.Item.Caption == BtnCommandEnum.Edit)
            {
                toolStrip1.Visible = true;
                dataLayoutControl1.OptionsView.IsReadOnly = DevExpress.Utils.DefaultBoolean.False;
                gridJobTxDetail.OptionsBehavior.ReadOnly = false;
                gridControlJobTx.Enabled = false;
            }
            else if (e.Item.Caption == BtnCommandEnum.Save)
            {
                this.gridJobTxDetail.CloseEditor();
                this.mESM501JobTxBindingSource.EndEdit();
                var jobtx = this.mESM501JobTxBindingSource.Current as MES_M501_JobTx;
                var jobtxDetailList = this.mESM501JobTxDetailBindingSource.DataSource as List<MES_M501_JobTxDetail>;
                var jobtxProdInfoList = this.mESM501JobTxProdInfoBindingSource.DataSource as List<MES_M501_JobTxProdInfo>;
                jobtxService.Save(jobtx, jobtxDetailList.Where(a => a.OutDt != null).ToList(), null, jobtxProdInfoList);
                //DialogResult = DialogResult.OK;
                dataLayoutControl1.OptionsView.IsReadOnly = DevExpress.Utils.DefaultBoolean.True;
                gridJobTxDetail.OptionsBehavior.ReadOnly = true;
                gridProdInfo.OptionsBehavior.ReadOnly = true;
                gridControlJobTx.Enabled = true;
                toolStrip1.Visible = false;
                XtraMessageBox.Show("保存成功");
            }
            else if (e.Item.Caption == BtnCommandEnum.Cancel)
            {
                if (ERPHelper.Instance.MessageIf("确定要取消未保存的数据吗"))
                {
                    this.mESM501JobTxBindingSource.CancelEdit();
                    dataLayoutControl1.OptionsView.IsReadOnly = DevExpress.Utils.DefaultBoolean.True;
                    gridJobTxDetail.OptionsBehavior.ReadOnly = true;
                    gridControlJobTx.Enabled = true;
                    toolStrip1.Visible = false;
                }
            }
            else if (e.Item.Caption == BtnCommandEnum.Delete)
            {
                if (ERPHelper.Instance.MessageDel())
                {
                    var jobtx = this.mESM501JobTxBindingSource.Current as MES_M501_JobTx;
                    jobtxService.Delete(jobtx.Id);
                    mESM501JobTxBindingSource.RemoveCurrent();
                    dataLayoutControl1.OptionsView.IsReadOnly = DevExpress.Utils.DefaultBoolean.True;
                    gridJobTxDetail.OptionsBehavior.ReadOnly = true;
                    gridProdInfo.OptionsBehavior.ReadOnly = true;
                    gridControlJobTx.Enabled = true;
                    toolStrip1.Visible = false;
                }
            }
            if (e.Item.Caption == "保存界面")
            {
                ERP_C009_Layout layout = new ERP_C009_Layout();
                layout.FrmType = this.Name;
                Stream stream1 = new System.IO.MemoryStream();
                this.dataLayoutControl1.SaveLayoutToStream(stream1);
                stream1.Seek(0, System.IO.SeekOrigin.Begin);
                layout.LayFiles = FileStreamHelp.StreamToBytes(stream1);
                Stream stream2 = new System.IO.MemoryStream();
                this.gridJobTxDetail.SaveLayoutToStream(stream2);
                stream2.Seek(0, System.IO.SeekOrigin.Begin);
                layout.LayFiles2 = FileStreamHelp.StreamToBytes(stream2);
                C009_Layout frm = new C009_Layout(layout);
                if (frm.ShowDialog() == DialogResult.OK)
                {
                    XtraMessageBox.Show("保存成功");
                }
            }

        }
        protected  void CreateToolBar()
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
            ToolStripSeparator toolSep2 = new ToolStripSeparator();
            toolStrip.Items.Add(toolSep2);
            toolStrip.Dock = DockStyle.Top;
            toolStrip.BringToFront();
            page.Controls.Add(toolStrip);
        }

        void btnDel_Click(object sender, EventArgs e)
        {
            this.mESM501JobTxDetailBindingSource.AddNew();
        }

        void btnAdd_Click(object sender, EventArgs e)
        {
            this.mESM501JobTxDetailBindingSource.AddNew();
        }

       /// <summary>
       /// 输入工作单号
       /// </summary>
       /// <param name="sender"></param>
       /// <param name="e"></param>
        private void btnSearch_Click(object sender, EventArgs e)
        {
            if (dataLayoutControl1.OptionsView.IsReadOnly == DevExpress.Utils.DefaultBoolean.False)
            {
                throw new AppException("当前还有未保存的制程，请先保存");
            }

            if (string.IsNullOrEmpty(this.JobLotNoTextEdit.Text) || string.IsNullOrEmpty(ProcessCodeTextEdit.Text))
            {
                this.JobLotNoTextEdit.Focus();
                this.JobLotNoTextEdit.SelectAll();
                throw new AppException("制程或者生产批号不能为空");
            }

            string jobLotNo = this.JobLotNoTextEdit.Text.Trim();
            string processCode = ProcessCodeTextEdit.EditValue.ToString();
           
            OnHandelSearch(jobLotNo, processCode);
        }
        /// <summary>
        /// 处理输入的工作单号信息
        /// 1.先判断是否存在，存在则修改
        /// 2.如果不存在则新增
        /// </summary>
        /// <param name="jobNo"></param>
        /// <param name="processCode"></param>
        private void OnHandelSearch(string jobLotNo, string processCode)
        {
            //ItemClickEventArgs e = new ItemClickEventArgs(){e.Item.Caption }
            var jobLotTx = jobtxService.GetJobTxQuery().Where(a => a.JobNo == jobLotNo && a.ProcessCode == processCode).FirstOrDefault();

            if (jobLotTx != null)
            {
                //var jobLotTxList = this.mESM501JobTxBindingSource.DataSource as List<erp>
                this.mESM501JobTxBindingSource.Remove(jobLotTx);
                this.mESM501JobTxBindingSource.Add(jobLotTx);
                //指定查找到的位置
                this.mESM501JobTxBindingSource.Position = this.mESM501JobTxBindingSource.IndexOf(jobLotTx);
            }
            else
            {
                //var taskDetail = taskService.GetProductQuery().Where(a => a.JobNo == jobNo).FirstOrDefault();
                var taskJobLot = taskJobLotService.GetQuery().Where(a => a.JobLotNo == jobLotNo).FirstOrDefault();
                if (taskJobLot == null)
                    throw new AppException("没有对应的生产批次号，请检查");
                var taskDetail = taskService.GetProductQuery().Where(a => a.TaskNo == taskJobLot.JobNo).FirstOrDefault();
                if (taskDetail == null)
                    throw new AppException("没有对应的跟踪单号，请检查");
                this.mESM501JobTxBindingSource.AddNew();
                var jobtx = this.mESM501JobTxBindingSource.Current as MES_M501_JobTx;
                jobtx.PLNo = taskDetail.PLNo;
                jobtx.SONo = taskDetail.SONo;
                jobtx.SOQty = taskDetail.SOQty??0;
                jobtx.TaskNo = taskDetail.TaskNo;
                jobtx.CustCode = taskDetail.CustCode;
                jobtx.JobNo = taskJobLot.JobLotNo;
                jobtx.PartNo = taskDetail.PartNo;
                //jobtx.PartType = taskDetail.PartType;
                //jobtx.PartSpec = taskDetail.PartSpec;
                jobtx.ProcessCode = processCode;
                //jobtx.ProcessFlow = taskDetail.ProcessFlow;
                var product = productService.GetProduct().Where(a => a.PartNo == taskDetail.PartNo).Select(a => new { a.PartSpec, a.PartType, a.ProcessFlow }).FirstOrDefault();
                jobtx.PartSpec = product.PartSpec;
                jobtx.PartType = product.PartType;
                jobtx.PFCode = product.ProcessFlow;
                this.mESM501JobTxBindingSource.ResetCurrentItem();

                //2016-4-5
                var prodInfoList = productService.GetProdInfoByProdutCode(jobtx.PartNo).Where(a => a.ProcessCode == jobtx.ProcessCode).ToList()
                    .Select(a => new MES_M501_JobTxProdInfo() { CompCode = a.CompCode, JobNo = jobtx.JobNo, PFCode = a.PFCode, ProcessCode = a.ProcessCode, TechCode = a.TechCode, TechType = a.TechType, TechContent = a.TechContent, TechSeqNo = a.TechSeqNo }).OrderBy(a => a.TechSeqNo).ToList();
                this.mESM501JobTxProdInfoBindingSource.DataSource = prodInfoList;
            }
            toolStrip1.Visible = true;
            dataLayoutControl1.OptionsView.IsReadOnly = DevExpress.Utils.DefaultBoolean.False;
            gridJobTxDetail.OptionsBehavior.ReadOnly = false;
            gridProdInfo.OptionsBehavior.ReadOnly = false;
            gridControlJobTx.Enabled = false;
            var jobTxDetailList = this.mESM501JobTxDetailBindingSource.DataSource as List<MES_M501_JobTxDetail>;
            var count = jobTxDetailList.Count;
            for (int i = 0; i < 8 - count; i++)
            {
                MES_M501_JobTxDetail jobtxDetail = new MES_M501_JobTxDetail();
                jobTxDetailList.Add(jobtxDetail);
            }
            this.mESM501JobTxDetailBindingSource.ResetBindings(false);
            this.txtModel.Focus();
        }
        /// <summary>
        /// 回车事件重写
        /// </summary>
        /// <param name="msg"></param>
        /// <param name="keyData"></param>
        /// <returns></returns>
        protected override bool ProcessCmdKey(ref   Message msg, Keys keyData)
        {

            //判D断?是?否?是?按恪?下?回?车μ键ü
            if (msg.Msg == 256 && keyData == Keys.Enter)
            {
                //发ぁ?送ítab 
                // SendKeys.Send("{tab}");
                if (JobLotNoTextEdit.IsEditorActive)
                {
                    btnSearch_Click(null, null);
                    return true;
                }
                //else if (RemarksTextEdit.IsEditorActive)
                //{
                //    if (XtraMessageBox.Show("是否确定保存？", "系统提醒", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) == DialogResult.OK)
                //    {
                //        ToolBarCommand toolCommand = new ToolBarCommand();
                //        toolCommand.M_Type = "Save";
                //        tool_OnCommandedEvent(toolCommand, null);
                //    }
                //    return true;
                //}
                else
                    return base.ProcessCmdKey(ref msg, keyData);
            }
            else
                return base.ProcessCmdKey(ref msg, keyData);
        }

        private void ykGridControl1_Click(object sender, EventArgs e)
        {

        }
        
        private void MES501JobTxEditForm_Activated(object sender, EventArgs e)
        {
           
        }
        /// <summary>
        /// 读取窗体样式
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void MES501JobTxEditForm_Load(object sender, EventArgs e)
        {
            //MES501JobTxProcessType frm = new MES501JobTxProcessType(this.Name);
            //if (frm.ShowDialog() == DialogResult.OK)
            //{
            //    var layoutService = Unity.Instance.GetService<IERP_C009_LayoutService>();
            //    var layout = layoutService.GetByType(this.Name, frm.ComType);
            //    if (layout != null)
            //    {
            //        Stream stream = FileStreamHelp.BytesToStream(layout.LayFiles);
            //        this.dataLayoutControl1.RestoreLayoutFromStream(stream);
            //        stream.Seek(0, System.IO.SeekOrigin.Begin);
            //        Stream stream2 = FileStreamHelp.BytesToStream(layout.LayFiles2);
            //        this.gridJobTxDetail.RestoreLayoutFromStream(stream2);
            //        stream2.Seek(0, System.IO.SeekOrigin.Begin);
            //    }
            //    else
            //    {
            //        throw new ApplicationException("该界面尚未有保存的模版");
            //    }
            //}
        }
        /// <summary>
        /// 制程改变则显示对应的界面模版
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ProcessCodeTextEdit_EditValueChanged(object sender, EventArgs e)
        {
            ShowLayForm(ProcessCodeTextEdit.Text);
        }

        private void ShowLayForm(string type)
        {
            var layoutService = Unity.Instance.GetService<IERP_C009_LayoutService>();
            var layout = layoutService.GetByType(this.Name, type);
            if (layout != null)
            {
                Stream stream = FileStreamHelp.BytesToStream(layout.LayFiles);
                this.dataLayoutControl1.RestoreLayoutFromStream(stream);
                stream.Seek(0, System.IO.SeekOrigin.Begin);
                Stream stream2 = FileStreamHelp.BytesToStream(layout.LayFiles2);
                this.gridJobTxDetail.RestoreLayoutFromStream(stream2);
                stream2.Seek(0, System.IO.SeekOrigin.Begin);
            }
            else
            {
                //dataLayoutControl1.re
            }
        }
    }
}
