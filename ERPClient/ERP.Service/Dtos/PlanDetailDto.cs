using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ERP.Service.Dtos
{
    public class PlanDetailDto
    {
        public string PLevel { get; set; }

        public string PLNo { get; set; }

        public string SONo { get; set; }

        public decimal? SOQty { get; set; }

        public string CustCode { get; set; }

        public string PartNo { get; set; }

        public string PartName { get; set; }

        public string PartSpec { get; set; }

        public string DetailType { get; set; }

        public string Unit { get; set; }

        public decimal? DetailQty { get; set; }

        public decimal? FQty { get; set; }

        public decimal? AdJustQty { get; set; }

        public decimal? SumQty { get; set; }

        public DateTime? TxDt { get; set; }

        public decimal? DailyQty { get; set; }
    }
}
