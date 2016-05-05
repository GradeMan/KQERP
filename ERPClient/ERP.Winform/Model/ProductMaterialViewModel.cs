using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ERP.Domain;
namespace ERP.Winform.Model
{
    public class ProductMaterialViewModel: MES_M201_Plan_Material
    {
        public Guid PlanId { get; set; }

        public string PLNo { get; set; }

        public string CustCode { get; set; }

        public string PartNo { get; set; }

        public string PartName { get; set; }

        public string PartSpec { get; set; }
    }
}
