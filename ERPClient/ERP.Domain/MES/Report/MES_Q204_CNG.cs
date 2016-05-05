using COM.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ERP.Domain
{
    public class MES_Q204_CNG
    {
        [ColumnMap("JobNO", "")]
        public string JobNO { get; set; }

        [ColumnMap("Category", "")]
        public string Category { get; set; }

        [ColumnMap("QPartNo", "")]
        public string QPartNo { get; set; }

        [ColumnMap("ProdDt", "")]
        public DateTime? ProdDt { get; set; }

        [ColumnMap("Clot", "")]
        public string Clot { get; set; }

        [ColumnMap("Name", "")]
        public string Name { get; set; }

        [ColumnMap("Suppervisor", "")]
        public string Suppervisor { get; set; }

        [ColumnMap("InQty", "")]
        public decimal? InQty { get; set; }

        [ColumnMap("inqtyink", "")]
        public decimal? inqtyink { get; set; }

        [ColumnMap("CNGCRITERIA_CDBF", "")]
        public decimal? CNGCRITERIA_CDBF { get; set; }

        [ColumnMap("CNGCRITERIA_MGS", "")]
        public decimal? CNGCRITERIA_MGS { get; set; }

        [ColumnMap("CNGCRITERIA_DJBX", "")]
        public decimal? CNGCRITERIA_DJBX { get; set; }

        [ColumnMap("CNGCRITERIA_LW", "")]
        public decimal? CNGCRITERIA_LW { get; set; }

        [ColumnMap("CNGCRITERIA_DY", "")]
        public decimal? CNGCRITERIA_DY { get; set; }

        [ColumnMap("CNGCRITERIA_OTHER", "")]
        public decimal? CNGCRITERIA_OTHER { get; set; }

        [ColumnMap("CNGCRITERIA_MC", "")]
        public decimal? CNGCRITERIA_MC { get; set; }

        [ColumnMap("CNGCRITERIA_HS", "")]
        public decimal? CNGCRITERIA_HS { get; set; }

        [ColumnMap("CNGCRITERIA_ZS", "")]
        public decimal? CNGCRITERIA_ZS { get; set; }

        [ColumnMap("CNGCRITERIA_ZJFQ", "")]
        public decimal? CNGCRITERIA_ZJFQ { get; set; }

        [ColumnMap("CNGCRITERIA_HW", "")]
        public decimal? CNGCRITERIA_HW { get; set; }

        [ColumnMap("CNGCRITERIA_ZW", "")]
        public decimal? CNGCRITERIA_ZW { get; set; }

        [ColumnMap("CNGCRITERIA_HMQX", "")]
        public decimal? CNGCRITERIA_HMQX { get; set; }

        [ColumnMap("CNGCRITERIA_JDTL", "")]
        public decimal? CNGCRITERIA_JDTL { get; set; }

        [ColumnMap("CNGQtyInK", "")]
        public decimal? CNGQtyInK { get; set; }

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
