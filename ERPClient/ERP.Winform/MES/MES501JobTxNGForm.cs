using COM.Service;
using COM.Winform;
using ERP.Service;
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
namespace ERP.Winform.MES
{
    public partial class MES501JobTxNGForm : EditForm
    {
        private IMES_M501_JobTx_NGService jobtxNgService = Unity.Instance.GetService<IMES_M501_JobTx_NGService>();
        private ICodeService codeService = Unity.Instance.GetService<ICodeService>();
        private string jobLotNo;
        private string currProcessCode = "金丝";
        public List<MES_M501_JobTx_NG> joblottxNg;
        private decimal ngQty;
        public MES501JobTxNGForm()
        {
            InitializeComponent();
        }
        public MES501JobTxNGForm(string JobLotNo, string CurrProcessCode,decimal ngQty)
        {
            InitializeComponent();
            this.jobLotNo = JobLotNo;
            this.ngQty = ngQty;
            //this.currProcessCode = CurrProcessCode;
        }
        protected override void SetToolBarItem()
        {
            //OnAddToolBtn("删除", "ok");
            OnAddToolBtn("确认", "ok");
            OnAddToolBtn("取消", "cancel");
        }
        protected override void InitData()
        {
            var ngItemList = codeService.GetCodeDataByCodeId("NGPROCESS");
            SetGridLookUpEdit(repositoryItemNgItem, ngItemList);
            //var processCodes = ykdbContext.Set<MES_M003_JobLotTx>().Where(a => a.JobLotNo == jobLotNo).Select(a => a.ProcessCode).ToList();
            var info = codeService.GetListByCodeID("NGPROCESS").Select(a => new MES_M501_JobTx_NG { CurrProcessCode = "金丝", ProcessCode = "", NGCode = a.Code, NGQty = 0, JobNo = jobLotNo, CreateDt = DateTime.Now }).ToList().OrderBy(a => a.NGCode).ToList();
            //var JobLotTx_NG = jobtxNgService.GetQuery().Where(a => a.JobNo == jobLotNo && a.CurrProcessCode == currProcessCode).ToList();
            
            //JobLotTx_NG.ForEach(a =>
            //{
            //    var joblot = info.Where(b => b.NGCode == a.NGCode).FirstOrDefault();
            //    if (joblot != null)
            //    {
            //        joblot.NGQty = a.NGQty;
            //        joblot.CurrProcessCode = a.CurrProcessCode;
            //    }
            //});

            this.mESM501JobTxNGBindingSource.DataSource = info;//
        }
        protected override void OnBtnCommand(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (e.Item.Caption == BtnCommandEnum.OK)
            {
                this.gridProduct.CloseEditor();
                joblottxNg = this.mESM501JobTxNGBindingSource.DataSource as List<MES_M501_JobTx_NG>;
                var qty = joblottxNg.Sum(a => a.NGQty);
                if (qty != ngQty)
                    throw new AppException("报废总数不等于" + ngQty.ToStr() + ",请检查");
                DialogResult = DialogResult.OK;
            }
            if (e.Item.Caption == BtnCommandEnum.Cancel)
                DialogResult = DialogResult.Cancel;
        }
    }
}
