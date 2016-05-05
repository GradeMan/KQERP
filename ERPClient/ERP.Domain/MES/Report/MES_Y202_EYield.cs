using System;
using System.Text;
using System.Collections.Generic;
using System.Data;
using COM.Domain;
namespace ERP.Domain
{
    public class MES_Y202_EYield
    {
        [ColumnMap("JobType", "")]
        public string JobType { get; set; }

        [ColumnMap("Category", "")]
        public string Category { get; set; }

        [ColumnMap("PartNo", "")]
        public string PartNo { get; set; }

        [ColumnMap("EPartNo", "")]
        public string EPartNo { get; set; }

        [ColumnMap("ECustCode", "")]
        public string ECustCode { get; set; }

        [ColumnMap("CustName", "")]
        public string CustName { get; set; }

        [ColumnMap("ProdDt", "")]
        public DateTime? ProdDt { get; set; }

        [ColumnMap("JobNo", "")]
        public string JobNo { get; set; }

        [ColumnMap("ELot", "")]
        public string ELot { get; set; }

        [ColumnMap("MacCode", "")]
        public string MacCode { get; set; }

        [ColumnMap("ShiftCode", "")]
        public string ShiftCode { get; set; }

        [ColumnMap("Operator", "")]
        public string Operator { get; set; }

        [ColumnMap("OperatorName", "")]
        public string OperatorName { get; set; }

        [ColumnMap("Supervisor", "")]
        public string Supervisor { get; set; }

        [ColumnMap("SupervisorName", "")]
        public string SupervisorName { get; set; }

        [ColumnMap("YieldFactor", "")]
        public string YieldFactor { get; set; }

        [ColumnMap("ZZCIn", "")]
        public int? ZZCIn { get; set; }

        [ColumnMap("bcpinqty", "")]
        public decimal? bcpinqty { get; set; }

        [ColumnMap("InQty", "")]
        public decimal? InQty { get; set; }

        [ColumnMap("OutQty", "")]
        public decimal? OutQty { get; set; }

        [ColumnMap("zzcinqty", "")]
        public decimal? zzcinqty { get; set; }

        [ColumnMap("OutQty_Individual", "")]
        public decimal? OutQty_Individual { get; set; }

        [ColumnMap("ZZCInQty_Individual", "")]
        public decimal? ZZCInQty_Individual { get; set; }

        public int ScrollCnt { get; set; }
    }
}