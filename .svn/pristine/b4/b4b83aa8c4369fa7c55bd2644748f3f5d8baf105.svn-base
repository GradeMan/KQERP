using System; 
using System.Text;
using System.Collections.Generic; 
using System.Data;
using COM.Domain;
namespace ERP.Domain
{
   public class ERP_M001_Material_Supp:AggregateRoot
	{
   		public  ERP_M001_Material_Supp(Guid id)
   			: base(id)
		{
			
		}
		public  ERP_M001_Material_Supp( )
			: base(Guid.NewGuid())
		{
		
		}

		[ColumnMap("CompCode", "")]
        public string CompCode{ get; set; }
				
		[ColumnMap("MatCode", "")]
        public string MatCode{ get; set; }
				
		[ColumnMap("SuppCode", "")]
        public string SuppCode{ get; set; }
				
		[ColumnMap("Level", "")]
        public string Level{ get; set; }
				
		[ColumnMap("Unit", "")]
        public string Unit{ get; set; }
				
		[ColumnMap("UnitPrice", "")]
        public decimal UnitPrice{ get; set; }

        public decimal PurPer { get; set; }
				
		[ColumnMap("DeliveryTerm", "")]
        public string DeliveryTerm{ get; set; }
				
		[ColumnMap("PayTerm", "")]
        public string PayTerm{ get; set; }
				
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

        public decimal Qty { get; set; }

        public string PriceRemarks { get; set; }

        public DateTime? QuotaDt { get; set; }

        public string ProdModel { get; set; }

        public Int32? DeliveryDays { get; set; }
		   
	}
}