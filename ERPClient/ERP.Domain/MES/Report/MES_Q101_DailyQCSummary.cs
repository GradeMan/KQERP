using System;
using System.Text;
using System.Collections.Generic;
using System.Data;
using COM.Domain;
namespace ERP.Domain
{
    public class MES_Q101_DailyQCSummary
    {
        [ColumnMap("CategorySeqNo", "")]
        public string CategorySeqNo { get; set; }

        [ColumnMap("Category", "")]
        public string Category { get; set; }

        [ColumnMap("MAT", "")]
        public string MAT { get; set; }

        [ColumnMap("Process", "")]
        public string Process { get; set; }

        [ColumnMap("MacCode1", "")]
        public string MacCode1 { get; set; }

        [ColumnMap("MacCode2", "")]
        public string MacCode2 { get; set; }

        [ColumnMap("MacCode3", "")]
        public string MacCode { get; set; }

        [ColumnMap("Suppervisor", "")]
        public string Suppervisor { get; set; }

        [ColumnMap("JobType", "")]
        public string JobType { get; set; }

        [ColumnMap("JobQty", "")]
        public Decimal? JobQty { get; set; }

        [ColumnMap("GQty", "")]
        public decimal? GQty { get; set; }

        [ColumnMap("InQty", "")]
        public decimal? InQty { get; set; }

        [ColumnMap("NgQty", "")]
        public decimal? NgQty { get; set; }

        [ColumnMap("IQCNGQty", "")]
        public decimal? IQCNGQty { get; set; }

        [ColumnMap("TDInQty", "")]
        public decimal? TDInQty { get; set; }

        [ColumnMap("TDNgQty", "")]
        public decimal? TDNgQty { get; set; }

        [ColumnMap("TDIQCNGQty", "")]
        public decimal? TDIQCNGQty { get; set; }

    }
}