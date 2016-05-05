using System; 
using System.Text;
using System.Collections.Generic; 
using System.Data;
using COM.Domain;
namespace ERP.Domain
{
   public class SUPP_M001_PurPlan_Material:AggregateRoot
	{
   		public  SUPP_M001_PurPlan_Material(Guid id)
   			: base(id)
		{
			
		}
		public  SUPP_M001_PurPlan_Material( )
			: base(Guid.NewGuid())
		{
		
		}

		[ColumnMap("CompCode", "")]
        public string CompCode{ get; set; }
				
		[ColumnMap("PurPlNo", "")]
        public string PurPlNo{ get; set; }
				
		[ColumnMap("MatCode", "")]
        public string MatCode{ get; set; }
				
		[ColumnMap("SuppCode", "")]
        public string SuppCode{ get; set; }
				
		[ColumnMap("SuppLevel", "")]
        public string SuppLevel{ get; set; }
				
		[ColumnMap("SuppPurPer", "")]
        public decimal SuppPurPer{ get; set; }
				
		[ColumnMap("Remarks", "")]
        public string Remarks{ get; set; }
				
		[ColumnMap("ModifyDt", "")]
        public DateTime? ModifyDt{ get; set; }
				
		[ColumnMap("ModifyUser", "")]
        public string ModifyUser{ get; set; }
				
		[ColumnMap("CreateDt", "")]
        public DateTime? CreateDt{ get; set; }
				
		[ColumnMap("CreateUser", "")]
        public string CreateUser{ get; set; }
				
		[ColumnMap("Version", "")]
        public byte[] Version{ get; set; }

        public decimal SuppQty { get; set; }

        public decimal PurQty { get; set; }

        public DateTime? DeliveryDt { get; set; }
		   
	}
}