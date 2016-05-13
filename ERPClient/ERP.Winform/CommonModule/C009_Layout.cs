using COM.Service;
using COM.Winform;
using DevExpress.XtraEditors;
using ERP.Domain;
using ERP.Service;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Util;

namespace ERP.Winform.CommonModule
{
    public partial class C009_Layout : XtraForm
    {
        //private List<string> layoutType = new List<string>();
        private IERP_C009_LayoutService layoutService = Unity.Instance.GetService<IERP_C009_LayoutService>();
        private ERP_C009_Layout layout;
        private ICodeService codeService = Unity.Instance.GetService<ICodeService>();
        public C009_Layout(ERP_C009_Layout tempData)
        {
            InitializeComponent();
            this.layout = tempData;
            this.txtFrmType.Text = tempData.FrmType;
        }
        private void btnSaveLayout_Click(object sender, EventArgs e)
        {
            string laytype = this.txtLayoutType.Text.Trim();
            if (string.IsNullOrWhiteSpace(laytype))
                throw new ApplicationException("请先选择要保存的界面");
            var model = layoutService.GetByType(layout.FrmType, laytype);
            if (model != null)
            {
                model.LayFiles = layout.LayFiles;
                model.LayFiles2 = layout.LayFiles2;
                model.LayFiles3 = layout.LayFiles3;
                layoutService.Update(model);
            }
            else
            {
                layout.LayType = laytype;
                layoutService.Create(layout);
            }
            DialogResult = System.Windows.Forms.DialogResult.OK;
        }

        private void C009_Layout_Load(object sender, EventArgs e)
        {
            this.txtLayoutType.Properties.Items.AddRange(GetLayType());
            //this.txtLayoutType.Properties.DataSource = codeService.GetCodeDataByCodeId("PROC");
            //this.txtLayoutType.Properties.DisplayMember = "DisplayMember";
            //this.txtLayoutType.Properties.ValueMember = "Value";
        }

        private List<string> GetLayType()
        {
            List<string> layoutType = new List<string>();
            switch (layout.FrmType)
            {
                case "Y201_PYieldForm": layoutType = new List<string> { "按产品型号", "按冲床型号", "按生产日期", "按操作员", "按模具" };
                    break;
                case "Y202_EYieldForm": layoutType = new List<string> { "按产品型号", "按机台", "按生产日期", "按操作员", "按客户" };
                    break;
                case "MES501JobTxEditForm":
                    layoutType = codeService.GetList().Where(a => a.CodeID == "PROC").OrderBy(a=>a.Code).Select(a => a.Description).ToList();//new List<string> { "粗拉", "熔炼","中拉及清洗(酸洗线)", "电镀", "细拉半成品1", "半成品退火", "细拉半成品2", "细拉成品", "成品清洗", "成品退火", "成品绕线", "成品内包" };
                    break;
            }
            return layoutType;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            DialogResult = System.Windows.Forms.DialogResult.Cancel;
        }
    }
}
