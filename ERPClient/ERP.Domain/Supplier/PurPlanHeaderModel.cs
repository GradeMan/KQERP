using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ERP.Domain.Supplier
{
    public class PurPlanHeaderModel
    {
        public string PurPlNo { get; set; }
        public string MatCode { get; set; }
        public string MatName { get; set; }
        public string MatClass1 { get; set; }//物料类别
        public string MatClass2 { get; set; }//材质
        public string MatSpec { get; set; }
        public decimal PurQty { get; set; }
        public string SuppLevel { get; set; }
        public string SuppCode { get; set; }
        public string Alias { get; set; }
        public decimal SuppPurPer { get; set; }
        public decimal SuppQty { get; set; }
        public string Remarks { get; set; }
    }
}
