using System;
using System.Text;
using System.Collections.Generic;
using System.Data;
using COM.Domain;
namespace ERP.Domain
{
    public class MES_Y101_DailyYieldSummary
    {
        [ColumnMap("Process", "")]
        public string Process { get; set; }

        [ColumnMap("JobType", "")]
        public string JobType { get; set; }

        [ColumnMap("Category", "")]
        public string Category { get; set; }

        [ColumnMap("PartNo", "")]
        public string PartNo { get; set; }

        [ColumnMap("PlanQty", "")]
        public Decimal? PlanQty { get; set; }

        [ColumnMap("InQty", "")]
        public Decimal? InQty { get; set; }

        [ColumnMap("TDInQty", "")]
        public Decimal? TDInQty { get; set; }

        [ColumnMap("OutQty", "")]
        public Decimal? OutQty { get; set; }

        [ColumnMap("TDOutQty", "")]
        public Decimal? TDOutQty { get; set; }

        [ColumnMap("DiffQty", "")]
        public Decimal? DiffQty { get; set; }

        [ColumnMap("TDDiffQty", "")]
        public Decimal? TDDiffQty { get; set; }

        [ColumnMap("InQtyFactor", "")]
        public Decimal? InQtyFactor { get; set; }

        [ColumnMap("TDInQtyFactor", "")]
        public Decimal? TDInQtyFactor { get; set; }

        [ColumnMap("OutQtyFactor", "")]
        public Decimal? OutQtyFactor { get; set; }

        [ColumnMap("TDOutQtyFactor", "")]
        public Decimal? TDOutQtyFactor { get; set; }


    }
}