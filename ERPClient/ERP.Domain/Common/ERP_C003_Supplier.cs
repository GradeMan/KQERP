using System; 
using System.Text;
using System.Collections.Generic; 
using System.Data;
using COM.Domain;
namespace ERP.Domain
{
   public class ERP_C003_Supplier:AggregateRoot
	{
   		public  ERP_C003_Supplier(Guid id)
   			: base(id)
		{
			
		}
		public  ERP_C003_Supplier( )
			: base(Guid.NewGuid())
		{
		
		}
      			
		[ColumnMap("CompCode", "")]
        public string CompCode{ get; set; }
				
		[ColumnMap("SuppCode", "")]
        public string SuppCode{ get; set; }
				
		[ColumnMap("SuppName", "")]
        public string SuppName{ get; set; }
				
		[ColumnMap("Alias", "")]
        public string Alias{ get; set; }
				
		[ColumnMap("Address", "")]
        public string Address{ get; set; }
				
		[ColumnMap("Phone", "")]
        public string Phone{ get; set; }
				
		[ColumnMap("Fax", "")]
        public string Fax{ get; set; }
				
		[ColumnMap("Contact", "")]
        public string Contact{ get; set; }
				
		[ColumnMap("EMail", "")]
        public string EMail{ get; set; }
				
		[ColumnMap("Level", "")]
        public string Level{ get; set; }
				
		[ColumnMap("Source", "")]
        public string Source{ get; set; }
				
		[ColumnMap("DeliveryTerm", "")]
        public string DeliveryTerm{ get; set; }
				
		[ColumnMap("PayTerm", "")]
        public string PayTerm{ get; set; }
				
		[ColumnMap("StartDt", "")]
        public DateTime? StartDt{ get; set; }
				
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

        public string IndustryType { get; set; }

        public bool? IsQualified { get; set; }

        public DateTime? QualifyDt { get; set; }
		   
	}
}