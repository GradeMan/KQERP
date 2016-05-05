using System;
using System.Text;
using System.Collections.Generic;
using System.Data;
using COM.Domain;
namespace ERP.Domain
{
    public class MES_Q102_DailyQC
    {
        [ColumnMap("YYYYMM", "")]
        public string YYYYMM { get; set; }

        [ColumnMap("Week", "")]
        public string Week { get; set; }

        [ColumnMap("ProdDt", "")]
        public DateTime? ProdDt { get; set; }

        [ColumnMap("CategorySeqNo", "")]
        public string CategorySeqNo { get; set; }

        [ColumnMap("Category", "")]
        public string Category { get; set; }

        [ColumnMap("Process", "")]
        public string Process { get; set; }

        [ColumnMap("Maccode1", "")]
        public string macCode1 { get; set; }

        [ColumnMap("Maccode2", "")]
        public string MacCode2 { get; set; }

        [ColumnMap("MacCode3", "")]
        public string MacCode3 { get; set; }

        [ColumnMap("Suppervisor", "")]
        public string Suppervisor { get; set; }

        [ColumnMap("JobQty", "")]
        public decimal? JobQty { get; set; }

        [ColumnMap("GQty", "")]
        public decimal? GQty { get; set; }

        [ColumnMap("InQty", "")]
        public decimal? InQty { get; set; }

        [ColumnMap("NgQty", "")]
        public decimal? NgQty { get; set; }

        [ColumnMap("IQCNGQty", "")]
        public decimal? IQCNGQty { get; set; }


    }
}