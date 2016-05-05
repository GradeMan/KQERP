using COM.Winform;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using ERP.Domain;
using COM.Service;
using ERP.Service;
using DevExpress.XtraEditors;
using Util;
namespace ERP.Winform.MES
{
    /// <summary>
    /// 生产入库要求：
    /// 1.0 打开界面时弹出选项： 工序，班次，机台 
    /// 1.1 检索当天本机台或本工序的生产任务
    /// 1.2 新增生产入库（根据输入批号，判断是否已输入，将计划单，生产任务单，产品，日期，工序，机台，班次分别赋值）
    /// 1.3 保存生产入库 （更新生产任务及计划单完成数，刷新生产任务及已完成批号及未完成批号）
    /// </summary>
    public partial class _MES501JobTxForm : ListForm
    {
        public string macCode;
        public string shiftCode;
        public string processCode;
        private IMES_M501_JobTxService jobTxService = Unity.Instance.GetService<IMES_M501_JobTxService>();
        private IMES_M202_TaskService taskService = Unity.Instance.GetService<IMES_M202_TaskService>();
        private ICodeService codeService = Unity.Instance.GetService<ICodeService>();
        private IEmployeeService employeeService = Unity.Instance.GetService<IEmployeeService>();

        public _MES501JobTxForm()
        {
            InitializeComponent();
        }
        /// <summary>
        /// 加载初始化
        /// </summary>
        public override void OnAttachEvent()
        {
            dataLayoutControl1.OptionsView.IsReadOnly = DevExpress.Utils.DefaultBoolean.True;
            //班次
            var codeData = codeService.GetCodeDataByCodeId("SHIFT");
            SetGridLookUpEdit(ShiftCodeTextEdit, codeData, 1);
            SetGridLookUpEdit(repositoryItemShiftCode, codeData, 1);

            var empList =  employeeService.GetEmployeeData();
            SetGridLookUpEdit(SupervisorTextEdit, empList, 2);
            SetGridLookUpEdit(OperatorTextEdit, empList, 2);
            SetGridLookUpEdit(QCOperatorTextEdit, empList, 2);

            var ngItemList = codeService.GetCodeDataByCodeId("NGPROCESS");
            SetGridLookUpEdit(repositoryItemNgItem, ngItemList);
            //SetGridLookUpEdit

        }
        private void MES501JobTxForm_Shown(object sender, EventArgs e)
        {
            MES501PortalForm frmPortal = new MES501PortalForm();
            if (frmPortal.ShowDialog() == DialogResult.OK)
            {
                macCode = frmPortal.MacCode;
                shiftCode = frmPortal.ShiftCode;
                processCode = frmPortal.ProcessCode;
                this.mESM202TaskDetailBindingSource.DataSource = taskService.GetProductQuery().Where(a => a.MacCode == macCode && a.ShiftCode == shiftCode && a.FQty<a.JobQty).ToList();

            }
        }
        /// <summary>
        /// 双击计划列表，执行新增动作，赋值
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void gridTask_DoubleClick(object sender, EventArgs e)
        {

            var task = this.mESM202TaskDetailBindingSource.Current as MES_M202_Task_Detail;
            if (task != null)
            {
                MES_M501_JobTx jobtx = new MES_M501_JobTx();
                jobtx.JobNo = task.JobNo;
                jobtx.JobType = task.JobType;
                jobtx.PLNo = task.PLNo;
                jobtx.TaskNo = task.TaskNo;
               
                this.mESM501JobTxBindingSource.DataSource = jobtx;
                dataLayoutControl1.OptionsView.IsReadOnly = DevExpress.Utils.DefaultBoolean.False;
                gridCtrolProd.DataSource = this.jobTxService.GetJobTxQuery().Where(a => a.JobNo == jobtx.JobNo).ToList();
                gridCtrolNoProd.DataSource = this.taskService.GetProductQuery().Where(a => a.JobNo == jobtx.JobNo && a.JobQty > a.FQty).ToList().Select(a => new { a.JobNo, a.TaskNo, a.JobQty, a.FQty, NoQty = a.JobQty - a.FQty }).ToList();
                ModelCodeTextEdit.Focus();
            }
        }
        /// <summary>
        /// 执行任务
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        public override void OnBtnCommand(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (e.Item.Caption == BtnCommandEnum.Save)
            {
                this.mESM501JobTxBindingSource.EndEdit();
                var jobLotTX = this.mESM501JobTxBindingSource.DataSource as MES_M501_JobTx;
                var task = this.mESM202TaskDetailBindingSource.Current as MES_M202_Task_Detail;
                //if (jobLotTX.InQty <= 0)
                //{
                //    InQtyTextEdit.Focus();
                //    InQtyTextEdit.SelectAll();
                //    throw new ApplicationException("投入数不能小于0");
                //}
                //if (jobLotTX.OutQty > jobLotTX.InQty)
                //{
                //    OutQtySpinEdit.Focus();
                //    OutQtySpinEdit.SelectAll();
                //    throw new ApplicationException("产出数不能大于投入数");
                //}
                //if (jobLotTX.OutQty > task.JobQty - task.FQty)
                //{
                //    InQtyTextEdit.Focus();
                //    InQtyTextEdit.SelectAll();
                //    throw new AppException("产出数不能大于计划剩余数量");
                //}
                //task.FQty = (task.FQty ?? 0) + (jobLotTX.OutQty ?? 0);
                var jobLotNgList = this.ykGridControl1.DataSource as List<MES_M501_JobTx_NG>;
                //var materialList = this.mESM201PlanMaterialBindingSource.DataSource as List<MES_M201_Plan_Material>;
                jobTxService.Save(jobLotTX, task, jobLotNgList);
                dataLayoutControl1.OptionsView.IsReadOnly = DevExpress.Utils.DefaultBoolean.True;
                this.mESM202TaskDetailBindingSource.ResetCurrentItem();
                gridCtrolProd.DataSource = this.jobTxService.GetJobTxQuery().Where(a => a.JobNo == jobLotTX.JobNo).ToList();
                gridCtrolNoProd.DataSource = this.taskService.GetProductQuery().Where(a => a.JobNo == jobLotTX.JobNo && a.JobQty > a.FQty).ToList().Select(a => new { a.JobNo, a.TaskNo, a.JobQty, a.FQty, NoQty = a.JobQty - a.FQty }).ToList();
            }
        }

        /// <summary>
        /// 重写键盘按钮事件
        /// </summary>
        /// <param name="msg"></param>
        /// <param name="keyData"></param>
        /// <returns></returns>
        protected override bool ProcessCmdKey(ref   Message msg, Keys keyData)
        {

            //判D断?是?否?是?按恪?下?回?车μ键ü
            if (msg.Msg == 256 && keyData == Keys.Enter)
            {
                ////发ぁ?送ítab 
                //// SendKeys.Send("{tab}");
                //if (JobLotNoTextEdit.IsEditorActive)
                //{
                //    btnSearch_Click(null, null);
                //    return true;
                //}
                if (RemarksTextEdit.IsEditorActive)
                {
                    if (XtraMessageBox.Show("是否确定保存？", "系统提醒", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) == DialogResult.OK)
                    {
                        DevExpress.XtraBars.ItemClickEventArgs e = new DevExpress.XtraBars.ItemClickEventArgs(new DevExpress.XtraBars.BarButtonItem(), null);
                        e.Item.Caption = BtnCommandEnum.Save;
                        OnBtnCommand(null, e);
                    }
                    return true;
                }
                else
                {
                    SendKeys.Send("{tab}");
                    return true;
                }
            }
            else
                return base.ProcessCmdKey(ref msg, keyData);
        }

        private void InQtyTextEdit_EditValueChanged(object sender, EventArgs e)
        {
            //this.mESM003JobLotTxBindingSource.EndEdit();
            var jobtx = this.mESM501JobTxBindingSource.DataSource as MES_M501_JobTx;
            if (jobtx != null)
            {
                //jobtx.InQty = InQtyTextEdit.Value;
                //jobtx.OutQty = OutQtySpinEdit.Value;
                //jobtx.NGQty = InQtyTextEdit.Value - OutQtySpinEdit.Value;
                this.mESM501JobTxBindingSource.ResetCurrentItem();
            }
        }

        private void btnEditUNQty_Click(object sender, EventArgs e)
        {
            var joblottx = this.mESM501JobTxBindingSource.Current as MES_M501_JobTx;
            if (joblottx == null)
                throw new ApplicationException("当前没有记录");
            if (string.IsNullOrWhiteSpace(joblottx.JobNo))
                throw new ApplicationException("生产批号不能为空");

            //MES501JobTxNGForm frm = new MES501JobTxNGForm(joblottx.JobNo, joblottx.ProcessCode,joblottx.NGQty??0);
            //if (frm.ShowDialog() == DialogResult.OK)
            //{
            //    var joblottxNg = frm.joblottxNg.Where(a => a.NGQty > 0).ToList();
            //    //var localJobLotNg = this.ykGridControl1.DataSource as List<MES_M501_JobTx_NG>;
            //    //var dd = localJobLotNg.Where(a => a.CurrProcessCode == joblottx.ProcessCode).ToList();
            //    //dd.ForEach(a => localJobLotNg.Remove(a));
            //    //joblottxNg.ForEach(a => localJobLotNg.Add(a));
            //    //var joblotNg = ykdbContext.Set<MES_M003_JobLotTx_NG>().Where(a => a.JobLotNo == joblottx.JobLotNo).ToList();
            //    //joblottx.NGQty = joblottxNg.Sum(a => a.NGQty);
            //    //this.mESM003JobLotTxBindingSource.ResetCurrentItem();
            //    //this.mESM003JobLotTxNGBindingSource.DataSource = localJobLotNg;
            //    this.ykGridControl1.DataSource = joblottxNg;
            //    this.ykGridControl1.RefreshDataSource();
            //}
        }
    }
}
