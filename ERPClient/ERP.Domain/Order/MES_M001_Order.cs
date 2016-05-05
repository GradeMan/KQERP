using System; 
using System.Text;
using System.Collections.Generic; 
using System.Data;
using COM.Domain;
namespace ERP.Domain
{
   public class MES_M001_Order:AggregateRoot
	{
   		public  MES_M001_Order(Guid id)
   			: base(id)
		{
			
		}
		public  MES_M001_Order( )
			: base(Guid.NewGuid())
		{
		
		}
      						
		[ColumnMap("CompCode", "")]
        public string CompCode{ get; set; }
								
		[ColumnMap("OrdNo", "")]
        public string OrdNo{ get; set; }
								
		[ColumnMap("CustCode", "")]
        public string CustCode{ get; set; }
								
		[ColumnMap("OrdDt", "")]
        public DateTime? OrdDt{ get; set; }
								
		[ColumnMap("Status", "")]
        public string Status{ get; set; }
								
		[ColumnMap("SalesMan", "")]
        public string SalesMan{ get; set; }
								
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