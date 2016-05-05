using System; 
using System.Text;
using System.Collections.Generic; 
using System.Data;
using COM.Domain;
namespace ERP.Domain
{
   public class ERP_M001_Material:AggregateRoot
	{
   		public  ERP_M001_Material(Guid id)
   			: base(id)
		{
			
		}
		public  ERP_M001_Material( )
			: base(Guid.NewGuid())
		{
		
		}

		[ColumnMap("CompCode", "")]
        public string CompCode{ get; set; }
				
		[ColumnMap("MatCode", "")]
        public string MatCode{ get; set; }
				
		[ColumnMap("MatLevel", "")]
        public string MatLevel{ get; set; }
				
		[ColumnMap("MatClass1", "")]
        public string MatClass1{ get; set; }
				
		[ColumnMap("MatClass2", "")]
        public string MatClass2{ get; set; }
				
		[ColumnMap("MatClass3", "")]
        public string MatClass3{ get; set; }
				
		[ColumnMap("MatName", "")]
        public string MatName{ get; set; }
				
		[ColumnMap("MatSpec", "")]
        public string MatSpec{ get; set; }
				
		[ColumnMap("Location", "")]
        public string Location{ get; set; }
				
		[ColumnMap("Unit", "")]
        public string Unit{ get; set; }
				
		[ColumnMap("Qty", "")]
        public decimal? Qty{ get; set; }
				
		[ColumnMap("SaftyQty", "")]
        public decimal? SaftyQty{ get; set; }
				
		[ColumnMap("Status", "")]
        public string Status{ get; set; }
				
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
		   
	}
}