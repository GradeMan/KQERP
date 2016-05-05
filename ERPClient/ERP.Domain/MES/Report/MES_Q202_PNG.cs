using COM.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ERP.Domain
{
    public class MES_Q202_PNG
    {
        [ColumnMap("JobNO", "")]
        public string JobNO { get; set; }

        [ColumnMap("Category", "")]
        public string Category { get; set; }

        [ColumnMap("QPartNo", "")]
        public string QPartNo { get; set; }

        [ColumnMap("plot", "")]
        public string plot { get; set; }

        [ColumnMap("ProdDt", "")]
        public DateTime? ProdDt { get; set; }

        [ColumnMap("Name", "")]
        public string Name { get; set; }

        [ColumnMap("suppervisor", "")]
        public string suppervisor { get; set; }

        [ColumnMap("InQty", "")]
        public decimal? InQty { get; set; }

        [ColumnMap("inqtyink", "")]
        public decimal? inqtyink { get; set; }

        [ColumnMap("PNGCRITERIA_MC", "")]
        public decimal? PNGCRITERIA_MC { get; set; }

        [ColumnMap("PNGCRITERIA_HDBX", "")]
        public decimal? PNGCRITERIA_HDBX { get; set; }

        [ColumnMap("PNGCRITERIA_DY", "")]
        public decimal? PNGCRITERIA_DY { get; set; }

        [ColumnMap("PNGCRITERIA_DJBX", "")]
        public decimal? PNGCRITERIA_DJBX { get; set; }

        [ColumnMap("PNGCRITERIA_WD", "")]
        public decimal? PNGCRITERIA_WD { get; set; }

        [ColumnMap("PNGCRITERIA_BJC", "")]
        public decimal? PNGCRITERIA_BJC { get; set; }

        [ColumnMap("PNGCRITERIA_CTD", "")]
        public decimal? PNGCRITERIA_CTD { get; set; }

        [ColumnMap("PNGCRITERIA_WJY", "")]
        public decimal? PNGCRITERIA_WJY { get; set; }

        [ColumnMap("PNGCRITERIA_SX", "")]
        public decimal? PNGCRITERIA_SX { get; set; }

        [ColumnMap("PNGCRITERIA_HS", "")]
        public decimal? PNGCRITERIA_HS { get; set; }

        [ColumnMap("PNGCRITERIA_ZH", "")]
        public decimal? PNGCRITERIA_ZH { get; set; }

        [ColumnMap("PNGCRITERIA_HW", "")]
        public decimal? PNGCRITERIA_HW { get; set; }

        [ColumnMap("PNGCRITERIA_BJD", "")]
        public decimal? PNGCRITERIA_BJD { get; set; }

        [ColumnMap("PNGCRITERIA_OTHER", "")]
        public decimal? PNGCRITERIA_OTHER { get; set; }

        [ColumnMap("PNGQtyInK", "")]
        public decimal? PNGQtyInK { get; set; }

        [ColumnMap("QCFactor", "")]
        public decimal? QCFactor { get; set; }

        [ColumnMap("QCUnitPrice", "")]
        public decimal? QCUnitPrice { get; set; }

        [ColumnMap("QCAmount", "")]
        public decimal? QCAmount { get; set; }

        [ColumnMap("c_groupby", "")]
        public string c_groupby { get; set; }
    }
}
