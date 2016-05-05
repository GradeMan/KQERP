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
using Util;

namespace ERP.Winform.WMS
{
    public partial class K041PDARecords : ListForm
    {
        private IViewService viewService = Unity.Instance.GetService<IViewService>();
        public K041PDARecords()
        {
            InitializeComponent();
        }
        public override void OnAttachEvent()
        {
            this.dateTxdt.DateTime = dateTxdt2.DateTime = DateTime.Now.Date;

        }
        public override void InitData()
        {
            var query = new QueryPDARecordView();
            if (string.IsNullOrWhiteSpace(dateTxdt.Text) || string.IsNullOrWhiteSpace(dateTxdt2.Text))
            {
                throw new AppException("日期不能为空，请选择一个日期范围");
            }
            query.TxDt = dateTxdt.DateTime.Date;
            query.TxDt2 = dateTxdt2.DateTime.Date.AddDays(1);
            this.k041PDARecordsBindingSource.DataSource = viewService.GetPDARecords(query);
            this.gridProduct.BestFitColumns();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            InitData();
        }
    }
}
