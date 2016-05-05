using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using Util;
using ERP.Service;
using COM.Service;
using COM.Winform;
namespace ERP.Winform.MES
{
    public partial class MES501PortalForm : EditForm
    {
        public string ProcessCode;
        public string MacCode;
        public string ShiftCode;
        private IMES_M202_TaskService TaskService = Unity.Instance.GetService<IMES_M202_TaskService>();
        private ICodeService codeService = Unity.Instance.GetService<ICodeService>();
        public MES501PortalForm()
        {
            InitializeComponent();
            base.bar1.Visible = false;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            ProcessCode = this.txtProcess.EditValue.ToStr();
            MacCode = txtMacCode.EditValue.ToStr();
            ShiftCode = txtShiftCode.EditValue.ToStr();
            DialogResult = System.Windows.Forms.DialogResult.OK;
        }

        private void MES501PortalForm_Load(object sender, EventArgs e)
        {
            var machineList = codeService.GetCodeDataByCodeId("MACHINE").Select(a => new { 机台编号 = a.Value,机台名称 = a.DisPlayName}).ToList();
            SetGridLookUpEdit(txtMacCode, machineList, "机台名称", "机台编号");
            var shiftList = codeService.GetListByCodeID("SHIFT").Select(a => new { 班次 = a.Description,代号 = a.Code}).ToList();
            SetGridLookUpEdit(txtShiftCode, shiftList, "班次", "代号");

            //txtMacCode.Properties.DataSource = machineList;
            //txtMacCode.Properties.DisplayMember = "机台名称";
            //txtMacCode.Properties.ValueMember = "机台编号";
        }
    }
}