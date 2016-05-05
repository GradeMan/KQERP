using COM.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ERP.Domain
{
    public class MES_Q201_NGDetail
    {
        [ColumnMap("YYYYMM", "")]
        public string YYYYMM { get; set; }

        [ColumnMap("ProdDt", "")]
        public DateTime? ProdDt { get; set; }

        [ColumnMap("Category", "")]
        public string Category { get; set; }

        [ColumnMap("PartNo", "")]
        public string PartNo { get; set; }

        [ColumnMap("Process", "")]
        public string Process { get; set; }

        [ColumnMap("NGItemNo", "")]
        public string NGItemNo { get; set; }

        [ColumnMap("NGItemQty", "")]
        public decimal? NGItemQty { get; set; }
    }
}
