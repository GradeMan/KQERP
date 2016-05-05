using COM.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ERP.Domain
{
    public class R105_PlanTrace
    {
        [ColumnMap("PLNo", "")]
        public string PLNo { get; set; }

        [ColumnMap("TaskNo", "")]
        public string TaskNo { get; set; }

        [ColumnMap("JobNo", "")]
        public string JobNo { get; set; }

        [ColumnMap("JobType", "")]
        public string JobType { get; set; }

        [ColumnMap("PartNo", "")]
        public string PartNo { get; set; }

        public string PartName { get; set; }

        [ColumnMap("ProdDt", "")]
        public DateTime? ProdDt { get; set; }

        [ColumnMap("ModelCode", "")]
        public string ModelCode { get; set; }

        [ColumnMap("ShiftCode", "")]
        public string ShiftCode { get; set; }

        [ColumnMap("MacCode", "")]
        public string MacCode { get; set; }

        [ColumnMap("Supervisor", "")]
        public string Supervisor { get; set; }

        [ColumnMap("Operator", "")]
        public string Operator { get; set; }

        [ColumnMap("QCOperator", "")]
        public string QCOperator { get; set; }

        [ColumnMap("InQty", "")]
        public decimal? InQty { get; set; }

        [ColumnMap("OutQty", "")]
        public decimal? OutQty { get; set; }

        [ColumnMap("NGQty", "")]
        public decimal? NGQty { get; set; }

        [ColumnMap("Remarks", "")]
        public string Remarks { get; set; }

        [ColumnMap("CreateDt", "")]
        public DateTime? CreateDt { get; set; }

        public string ProcessCode { get; set; }

        public decimal? PlanQty { get; set; }
        public decimal? PlanFQty { get; set; }
        public decimal? AdJustQty { get; set; }
        public decimal? SumQty { get; set; }
        public decimal? JobQty { get; set; }
        public decimal? TaskFQty { get; set; }
    }
}
