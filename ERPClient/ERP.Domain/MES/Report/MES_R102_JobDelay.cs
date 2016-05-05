using System;
using System.Text;
using System.Collections.Generic;
using System.Data;
using COM.Domain;
namespace ERP.Domain
{
    public class MES_R102_JobDelay
    {
        [ColumnMap("Process", "")]
        public string Process { get; set; }

        [ColumnMap("JobType", "")]
        public string JobType { get; set; }

        [ColumnMap("Category", "")]
        public string Category { get; set; }

        [ColumnMap("PartNo", "")]
        public string PartNo { get; set; }

        [ColumnMap("ProdDt1", "")]
        public DateTime? ProdDt1 { get; set; }

        [ColumnMap("ProdDt2", "")]
        public DateTime? ProdDt2 { get; set; }

        [ColumnMap("Delay", "")]
        public int? Delay { get; set; }

        [ColumnMap("Qty", "")]
        public Decimal? Qty { get; set; }

    }
}