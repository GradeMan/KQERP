using COM.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ERP.Domain
{
    public class MES_Q203_ENG
    {
        [ColumnMap("JobNO", "")]
        public string JobNO { get; set; }

        [ColumnMap("Category", "")]
        public string Category { get; set; }

        [ColumnMap("QPartNo", "")]
        public string QPartNo { get; set; }

        [ColumnMap("ProdDt", "")]
        public DateTime? ProdDt { get; set; }

        [ColumnMap("MacLineNo", "")]
        public string MacLineNo { get; set; }

        [ColumnMap("eLot", "")]
        public string eLot { get; set; }

        [ColumnMap("Name", "")]
        public string Name { get; set; }

        [ColumnMap("Suppervsior", "")]
        public string Suppervsior { get; set; }

        [ColumnMap("InQty", "")]
        public decimal? InQty { get; set; }

        [ColumnMap("inqtyink", "")]
        public decimal? inqtyink { get; set; }

        [ColumnMap("ENGCRITERIA_MGS", "")]
        public decimal? ENGCRITERIA_MGS { get; set; }

        [ColumnMap("ENGCRITERIA_DDYC", "")]
        public decimal? ENGCRITERIA_DDYC { get; set; }

        [ColumnMap("ENGCRITERIA_QP", "")]
        public decimal? ENGCRITERIA_QP { get; set; }

        [ColumnMap("ENGCRITERIA_SJ", "")]
        public decimal? ENGCRITERIA_SJ { get; set; }

        [ColumnMap("ENGCRITERIA_WD", "")]
        public decimal? ENGCRITERIA_WD { get; set; }

        [ColumnMap("ENGCRITERIA_BX", "")]
        public decimal? ENGCRITERIA_BX { get; set; }

        [ColumnMap("ENGCRITERIA_HDBX", "")]
        public decimal? ENGCRITERIA_HDBX { get; set; }

        [ColumnMap("ENGCRITERIA_YY", "")]
        public decimal? ENGCRITERIA_YY { get; set; }

        [ColumnMap("ENGCRITERIA_KDBX", "")]
        public decimal? ENGCRITERIA_KDBX { get; set; }

        [ColumnMap("ENGCRITERIA_GX", "")]
        public decimal? ENGCRITERIA_GX { get; set; }

        [ColumnMap("ENGCRITERIA_TSBL", "")]
        public decimal? ENGCRITERIA_TSBL { get; set; }

        [ColumnMap("ENGCRITERIA_ZW", "")]
        public decimal? ENGCRITERIA_ZW { get; set; }

        [ColumnMap("ENGCRITERIA_TBL", "")]
        public decimal? ENGCRITERIA_TBL { get; set; }

        [ColumnMap("ENGCRITERIA_QIPI", "")]
        public decimal? ENGCRITERIA_QIPI { get; set; }

        [ColumnMap("ENGCRITERIA_CCFF", "")]
        public decimal? ENGCRITERIA_CCFF { get; set; }

        [ColumnMap("ENGCRITERIA_YYM", "")]
        public decimal? ENGCRITERIA_YYM { get; set; }

        [ColumnMap("ENGCRITERIA_ZH", "")]
        public decimal? ENGCRITERIA_ZH { get; set; }

        [ColumnMap("ENGCRITERIA_LT", "")]
        public decimal? ENGCRITERIA_LT { get; set; }

        [ColumnMap("ENGCRITERIA_HW", "")]
        public decimal? ENGCRITERIA_HW { get; set; }

        [ColumnMap("ENGCRITERIA_BJC", "")]
        public decimal? ENGCRITERIA_BJC { get; set; }

        [ColumnMap("ENGCRITERIA_OTHER", "")]
        public decimal? ENGCRITERIA_OTHER { get; set; }

        [ColumnMap("ENGQtyInK", "")]
        public decimal? ENGQtyInK { get; set; }

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
