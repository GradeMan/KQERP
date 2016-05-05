using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ERP.Domain
{
    public class K041PDARecords
    {
        public int IdentityNo { get; set; }
        public string StockID { get; set; }
        public string OPType { get; set; }
        public string CustCode { get; set; }
        public string LotNo { get; set; }
        public string PartNo { get; set; }
        public decimal? BoxQty { get; set; }
        public decimal? Qty { get; set; }
        public DateTime? ProdDt { get; set; }
        public DateTime? ExpiredDt { get; set; }
        public DateTime? TxDt { get; set; }
        public string Remarks { get; set; }
        public int? Status { get; set; }
    }
}
