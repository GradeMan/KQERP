using System;
using System.Text;
using System.Collections.Generic;
using System.Data;
using COM.Domain;
namespace ERP.Domain
{
    public class MES_Y204_QYield
    {
        [ColumnMap("JobType", "")]
        public string JobType { get; set; }

        [ColumnMap("Category", "")]
        public string Category { get; set; }

        [ColumnMap("QPartNo", "")]
        public string QPartNo { get; set; }

        [ColumnMap("QPartDesc", "")]
        public string QPartDesc { get; set; }

        [ColumnMap("UnitofSheet", "")]
        public Decimal? UnitofSheet { get; set; }

        [ColumnMap("Operator", "")]
        public string Operator { get; set; }

        [ColumnMap("JobNo", "")]
        public string JobNo { get; set; }

        [ColumnMap("ProdDt", "")]
        public DateTime? ProdDt { get; set; }

        [ColumnMap("YieldFactor", "")]
        public string YieldFactor { get; set; }

        [ColumnMap("NgQty", "")]
        public Decimal? NgQty { get; set; }

        [ColumnMap("PNGQtyInK", "")]
        public decimal? PNGQtyInK { get; set; }

        [ColumnMap("ENGQtyInK", "")]
        public decimal? ENGQtyInK { get; set; }

        [ColumnMap("CNGQtyInK", "")]
        public decimal? CNGQtyInK { get; set; }

        [ColumnMap("FNGQtyInK", "")]
        public decimal? FNGQtyInK { get; set; }

        [ColumnMap("PInQtyInK", "")]
        public decimal? PInQtyInK { get; set; }

        [ColumnMap("EInQtyInK", "")]
        public decimal? EInQtyInK { get; set; }

        [ColumnMap("CInQtyInK", "")]
        public decimal? CInQtyInK { get; set; }

        [ColumnMap("FInQtyInK", "")]
        public decimal? FInQtyInK { get; set; }

        [ColumnMap("Expr1", "")]
        public decimal? Expr1 { get; set; }

        [ColumnMap("InQty", "")]
        public decimal? InQty { get; set; }

        [ColumnMap("OutQty", "")]
        public decimal? OutQty { get; set; }

        [ColumnMap("InQty_Individual", "")]
        public decimal? InQty_Individual { get; set; }

        [ColumnMap("OutQty_Individual", "")]
        public decimal? OutQty_Individual { get; set; }

    }
}