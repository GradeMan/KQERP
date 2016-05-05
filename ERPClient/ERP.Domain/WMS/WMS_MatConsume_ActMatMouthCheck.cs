using System; 
using System.Text;
using System.Collections.Generic; 
using System.Data;
using COM.Domain;
namespace ERP.Domain
{
   public class WMS_MatConsume_ActMatMouthCheck:AggregateRoot
	{
   		public  WMS_MatConsume_ActMatMouthCheck(Guid id)
   			: base(id)
		{
			
		}
		public  WMS_MatConsume_ActMatMouthCheck( )
			: base(Guid.NewGuid())
		{
		
		}
				
		[ColumnMap("MatSpecCode","MatSpecCode")]
        public string MatSpecCode{ get; set; }
				
		[ColumnMap("MatSpec","MatSpec")]
        public string MatSpec{ get; set; }
				
		[ColumnMap("SuppCode","SuppCode")]
        public string SuppCode{ get; set; }
				
		[ColumnMap("TxMouth","TxMouth")]
        public string TxMouth{ get; set; }
				
		[ColumnMap("CheckQty","CheckQty")]
        public decimal CheckQty{ get; set; }
				
		[ColumnMap("CreateDt","CreateDt")]
        public DateTime CreateDt{ get; set; }
				
		[ColumnMap("CreateUser","CreateUser")]
        public string CreateUser{ get; set; }
		   
	}
}