using COM.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ERP.Domain
{
    public class MES_Q103_YieldIQCNG
    {
        [ColumnMap("JobNO", "")]
        public string JobNO { get; set; }

        [ColumnMap("JobType", "")]
        public string JobType { get; set; }

        [ColumnMap("Category", "")]
        public string Category { get; set; }

        [ColumnMap("QPartNo", "")]
        public string QPartNo { get; set; }

        [ColumnMap("ProdDt", "")]
        public DateTime? ProdDt { get; set; }

        [ColumnMap("IsQCUnitPrice", "")]
        public string IsQCUnitPrice { get; set; }

        [ColumnMap("NgQty", "")]
        public decimal? NgQty { get; set; }

        [ColumnMap("PNGQtyInK", "")]
        public decimal? PNGQtyInK { get; set; }

        [ColumnMap("PIQCNGQtyInk", "")]
        public decimal? PIQCNGQtyInk { get; set; }

        [ColumnMap("PNGQtyInKbyQC", "")]
        public decimal? PNGQtyInKbyQC { get; set; }

        [ColumnMap("PNGQtyInKbyQCAmt", "")]
        public decimal? PNGQtyInKbyQCAmt { get; set; }

        [ColumnMap("ENGQtyInK", "")]
        public decimal? ENGQtyInK { get; set; }

        [ColumnMap("EIQCNGQtyInk", "")]
        public decimal? EIQCNGQtyInk { get; set; }

        [ColumnMap("ENGQtyInKbyQC", "")]
        public decimal? ENGQtyInKbyQC { get; set; }

        [ColumnMap("ENGQtyInKbyQCAmt", "")]
        public decimal? ENGQtyInKbyQCAmt { get; set; }

        [ColumnMap("CNGQtyInK", "")]
        public decimal? CNGQtyInK { get; set; }

        [ColumnMap("CIQCNGQtyInk", "")]
        public decimal? CIQCNGQtyInk { get; set; }

        [ColumnMap("FNGQtyInK", "")]
        public decimal? FNGQtyInK { get; set; }

        [ColumnMap("FIQCNGQtyInk", "")]
        public decimal? FIQCNGQtyInk { get; set; }

        [ColumnMap("Pinqtyink", "")]
        public decimal? Pinqtyink { get; set; }

        [ColumnMap("Einqtyink", "")]
        public decimal? Einqtyink { get; set; }

        [ColumnMap("Cinqtyink", "")]
        public decimal? Cinqtyink { get; set; }

        [ColumnMap("Finqtyink", "")]
        public decimal? Finqtyink { get; set; }

        [ColumnMap("InQty", "")]
        public decimal? InQty { get; set; }

        [ColumnMap("OutQty", "")]
        public decimal? OutQty { get; set; }
    }
}
