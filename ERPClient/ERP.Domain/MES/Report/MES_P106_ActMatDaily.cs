using COM.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ERP.Domain
{
    public class MES_P106_ActMatDaily
    {

        [ColumnMap("MatSpecCode", "")]
        public string MatSpecCode { get; set; }

        [ColumnMap("MatSpec", "")]
        public string MatSpec { get; set; }

        [ColumnMap("MatCode", "")]
        public string MatCode { get; set; }

        public string MatName { get; set; }

        [ColumnMap("Suppode", "")]
        public string Suppode { get; set; }

        public string ShortName { get; set; }

        [ColumnMap("TxDt", "")]
        public DateTime TxDt { get; set; }

        [ColumnMap("ReqQty", "")]
        public decimal? ReqQty { get; set; }

        [ColumnMap("RetQty", "")]
        public decimal? RetQty { get; set; }

        [ColumnMap("Remarks", "")]
        public string Remarks { get; set; }

        public decimal? CheckQty { get; set; }

        public decimal? LastCheckQty { get; set; }
    }
}
