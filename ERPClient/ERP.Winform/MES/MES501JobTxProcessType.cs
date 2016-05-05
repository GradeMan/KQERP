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

namespace ERP.Winform.MES
{
    public partial class MES501JobTxProcessType : DevExpress.XtraEditors.XtraForm
    {
        public string ComType = "";
        public MES501JobTxProcessType(string frmType)
        {
            InitializeComponent();
            this.txtLayoutType.Properties.Items.AddRange(GetLayType(frmType));
        }
        private List<string> GetLayType(string frmType)
        {
            List<string> layoutType = new List<string>();
            switch (frmType)
            {
                case "Y201_PYieldForm": layoutType = new List<string> { "按产品型号", "按冲床型号", "按生产日期", "按操作员", "按模具" };
                    break;
                case "Y202_EYieldForm": layoutType = new List<string> { "按产品型号", "按机台", "按生产日期", "按操作员", "按客户" };
                    break;
                case "MES501JobTxEditForm":
                    this.labName.Text = "制程";
                    layoutType = new List<string> { "粗拉", "中拉及清洗(酸洗线)", "电镀", "细拉半成品1", "半成品退火", "细拉半成品2", "细拉成品", "成品清洗", "成品退火", "成品绕线", "成品内包" };
                    break;
            }
            return layoutType;
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            ComType = this.txtLayoutType.Text;
            if (string.IsNullOrEmpty(ComType))
                throw new AppException("请先选择对应的" + this.labName.Text);
            this.DialogResult = System.Windows.Forms.DialogResult.OK;
        }
    }
}