using System; 
using System.Text;
using System.Collections.Generic; 
using System.Data;
using COM.Domain;
namespace ERP.Domain
{
   public class ERP_M003_InStore:AggregateRoot
	{
   		public  ERP_M003_InStore(Guid id)
   			: base(id)
		{
			
		}
		public  ERP_M003_InStore( )
			: base(Guid.NewGuid())
		{
		
		}
      			
	
				
		[ColumnMap("CompCode", "")]
        public string CompCode{ get; set; }
				
		[ColumnMap("InStoreId", "")]
        public string InStoreId{ get; set; }
				
		[ColumnMap("InstoreDt", "")]
        public DateTime? InstoreDt{ get; set; }
				
		[ColumnMap("InStoreType", "")]
        public string InStoreType{ get; set; }
				
		[ColumnMap("SuppCode", "")]
        public string SuppCode{ get; set; }
				
		[ColumnMap("SuppDeliveryNo", "")]
        public string SuppDeliveryNo{ get; set; }
				
		[ColumnMap("WHCode", "")]
        public string WHCode{ get; set; }
				
		[ColumnMap("PONo", "")]
        public string PONo{ get; set; }
				
		[ColumnMap("DeptCode", "")]
        public string DeptCode{ get; set; }
				
		[ColumnMap("Qty", "")]
        public decimal Qty{ get; set; }
				
		[ColumnMap("Amount", "")]
        public decimal Amount{ get; set; }
				
		[ColumnMap("Status", "")]
        public string Status{ get; set; }
				
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