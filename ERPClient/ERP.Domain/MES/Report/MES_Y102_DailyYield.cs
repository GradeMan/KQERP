using System;
using System.Text;
using System.Collections.Generic;
using System.Data;
using COM.Domain;
namespace ERP.Domain
{
    public class MES_Y102_DailyYield
    {
        [ColumnMap("Process", "")]
        public string Process { get; set; }

        [ColumnMap("JobType", "")]
        public string JobType { get; set; }

        [ColumnMap("Category", "")]
        public string Category { get; set; }

        [ColumnMap("PartNo", "")]
        public string PartNo { get; set; }

        [ColumnMap("ProdDt", "")]
        public DateTime? ProdDt { get; set; }

        [ColumnMap("PlanQty", "")]
        public Decimal? PlanQty { get; set; }

        [ColumnMap("InQty", "")]
        public Decimal? InQty { get; set; }

        [ColumnMap("OutQty", "")]
        public Decimal? OutQty { get; set; }

        [ColumnMap("DiffQty", "")]
        public Decimal? DiffQty { get; set; }

        [ColumnMap("InQtyFactor", "")]
        public Decimal? InQtyFactor { get; set; }

        [ColumnMap("OutQtyFactor", "")]
        public Decimal? OutQtyFactor { get; set; }

    }
}