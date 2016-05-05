using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ERP.Service
{
    public class QueryJobView
    {
        public string JobNo { get; set; }
        public string PartName { get; set; }
    }

    public class QueryPYieldView
    {
        public string proddt1 { get; set; }
        public string proddt2 { get; set; }
        public string PartNo { get; set; }
        public string IsInStore { get; set; }//是否入库
        public string IsCheck { get; set; }//是否检验
    }

    public class QueryEYieldView
    {
        public string proddt1 { get; set; }
        public string proddt2 { get; set; }
        public string PartNo { get; set; }
        public string IsInStore { get; set; }//是否入库
        public string IsCheck { get; set; }//是否检验
        public string CustName { get; set; }
    }

    public class QueryPDARecordView
    {
        public string OPType { get; set; }
        public string CustCode { get; set; }
        public string LotNo { get; set; }
        public string PartNo { get; set; }
        public DateTime? TxDt { get; set; }
        public DateTime? TxDt2 { get; set; }
    }

    public class QueryMESPlanView
    {
        public DateTime? TxDt { get; set; }
        public DateTime? TxDt2 { get; set; }
        public string PartNo { get; set; }
        public string CustNo { get; set; }
        public string PlanNo { get; set; }
        public string SONo { get; set; }
        public string Status { get; set; }
    }

    public class QueryR103JobTxDetailView
    {
        public string CustName { get; set; }
        public string PartNo { get; set; }
        public string PLNO { get; set; }
        public string TaskNo { get; set; }
        public string JobNo { get; set; }
        public string ProdDt { get; set; }
        public string ProdDt2 { get; set; }
    }
}
