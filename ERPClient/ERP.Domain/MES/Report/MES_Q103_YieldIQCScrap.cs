using COM.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ERP.Domain
{
    public class MES_Q103_YieldIQCScrap
    {
        [ColumnMap("Process", "")]
        public string Process { get; set; }

        [ColumnMap("JobType", "")]
        public string JobType { get; set; }

        [ColumnMap("Category", "")]
        public string Category { get; set; }

        [ColumnMap("PartNo", "")]
        public string PartNo { get; set; }

        [ColumnMap("Proddt", "")]
        public DateTime Proddt { get; set; }

        [ColumnMap("IQCNGQtyINK", "")]
        public decimal IQCNGQtyINK { get; set; }
    }
}
