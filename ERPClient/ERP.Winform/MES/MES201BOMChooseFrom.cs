using COM.Service;
using COM.Winform;
using ERP.Domain;
using ERP.Service;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Util;

namespace ERP.Winform.MES
{
    public partial class MES201BOMChooseFrom : EditForm
    {
        private IERP_M002_BOMService bomService = Unity.Instance.GetService<IERP_M002_BOMService>();
        private IERP_C003_SupplierService supplierServer = Unity.Instance.GetService<IERP_C003_SupplierService>();
        public ERP_M002_BOM bomModel;
        public decimal matCount = 0;
        public MES201BOMChooseFrom()
        {
            InitializeComponent();
        }
        protected override void SetToolBarItem()
        {
            //OnAddToolBtn("删除", "ok");
            OnAddToolBtn("确认", "ok");
            OnAddToolBtn("取消", "cancel");
        }
        protected override void InitData()
        {
            this.eRPM002BOMBindingSource.CurrentChanged += eRPM002BOMBindingSource_CurrentChanged;
            this.eRPM002BOMBindingSource.DataSource = bomService.GetList();
            this.gridView1.BestFitColumns();
        }

        void eRPM002BOMBindingSource_CurrentChanged(object sender, EventArgs e)
        {
            var model = this.eRPM002BOMBindingSource.Current as ERP_M002_BOM;
            if (model != null)
                eRPM002BOMMaterialBindingSource.DataSource = bomService.GetBomMatQuery().Where(a => a.PartNo == model.PartNo).ToList();
            else
                eRPM002BOMMaterialBindingSource.DataSource = null;
        }

        protected override void OnBtnCommand(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (e.Item.Caption == BtnCommandEnum.OK)
            {
                bomModel = this.eRPM002BOMBindingSource.Current as ERP_M002_BOM;
                DialogResult = DialogResult.OK;
            }
            if (e.Item.Caption == BtnCommandEnum.Cancel)
                DialogResult = DialogResult.Cancel;
        }

        private void gridView1_DoubleClick(object sender, EventArgs e)
        {
            bomModel = this.eRPM002BOMBindingSource.Current as ERP_M002_BOM;
            DialogResult = DialogResult.OK;
        }
    }
}
