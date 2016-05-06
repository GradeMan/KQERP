using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ERP.Service.Dtos
{
    public class TaskReportHead
    {
        public string TaskNo { get; set; }

        public string JobLotNo { get; set; }

        public string CustCode { get; set; }

        public string SoNo { get; set; }

        public decimal? SoQty { get; set; }

        public string PartNo { get; set; }

        public string PartSpec { get; set; }

        public string ProcessFlow { get; set; }
    }
}
