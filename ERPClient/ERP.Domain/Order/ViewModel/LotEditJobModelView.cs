using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ERP.Domain.Order.ViewModel
{
    public class LotEditJobModelView
    {
        public string JobNo { get; set; }
        public string CustName { get; set; }
        public string PartName { get; set; }
        public decimal JobQty { get; set; }
        public decimal OrderQty { get; set; }
        
    }
}
