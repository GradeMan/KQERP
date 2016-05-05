using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using DevExpress.XtraReports.UI;
using ERP.Service;
using COM.Service;
using System.Linq;
namespace ERP.Winform.Report
{
    public partial class PackingListReport : DevExpress.XtraReports.UI.XtraReport
    {
        private IWMS_M104_Packing_HdService packingService = Unity.Instance.GetService<IWMS_M104_Packing_HdService>();
        public PackingListReport(Guid id)
        {
            InitializeComponent();
            var hd = packingService.GetById(id);
            var details = packingService.GetDetailList(id);
            int i =1;
            details.ForEach(a => { a.SeqNo = i++; });
            hd.SumQty = details.Sum(a => a.Qty);
            this.bindingSource1.DataSource = hd;
            this.bindingSource2.DataSource = details;

        }

    }
}
