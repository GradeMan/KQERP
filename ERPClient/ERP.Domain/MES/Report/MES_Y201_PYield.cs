using System;
using System.Text;
using System.Collections.Generic;
using System.Data;
using COM.Domain;
namespace ERP.Domain
{
    public class MES_Y201_PYield
    {
        [ColumnMap("JobType", "")]
        public string JobType { get; set; }

        [ColumnMap("Category", "")]
        public string Category { get; set; }

        [ColumnMap("PartNo", "")]
        public string PartNo { get; set; }

        [ColumnMap("ProdDt", "")]
        public DateTime? ProdDt { get; set; }

        [ColumnMap("JobNo", "")]
        public string JobNo { get; set; }

        [ColumnMap("MacGroup", "")]
        public string MacGroup { get; set; }

        [ColumnMap("MacCode", "")]
        public string MacCode { get; set; }

        [ColumnMap("ModelCode", "")]
        public string ModelCode { get; set; }

        [ColumnMap("ModelName", "")]
        public string ModelName { get; set; }

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

        [ColumnMap("BCPIn", "")]
        public int? BCPIn { get; set; }

        [ColumnMap("OutQty", "")]
        public decimal? OutQty { get; set; }

        [ColumnMap("InQty", "")]
        public decimal? InQty { get; set; }

        [ColumnMap("BCPInQty", "")]
        public decimal? BCPInQty { get; set; }

        [ColumnMap("OutQty_Individual", "")]
        public decimal? OutQty_Individual { get; set; }

        [ColumnMap("InQty_Individual", "")]
        public decimal? InQty_Individual { get; set; }

        [ColumnMap("BCPInQty_Individual", "")]
        public decimal? BCPInQty_Individual { get; set; }

        public int ScrollCnt { get; set; }

    }
}