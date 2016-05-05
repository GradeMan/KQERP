using System; 
using System.Text;
using System.Collections.Generic; 
using System.Data;
using COM.Domain;
namespace ERP.Domain
{
   public class WMS_M105_MatReturn:AggregateRoot
	{
   		public  WMS_M105_MatReturn(Guid id)
   			: base(id)
		{
			
		}
		public  WMS_M105_MatReturn( )
			: base(Guid.NewGuid())
		{
		
		}
				
		[ColumnMap("CompCode","CompCode")]
        public string CompCode{ get; set; }
				
		[ColumnMap("ReturnNo","ReturnNo")]
        public string ReturnNo{ get; set; }
				
		[ColumnMap("TxDt","TxDt")]
        public DateTime TxDt{ get; set; }
				
		[ColumnMap("Remarks","Remarks")]
        public string Remarks{ get; set; }
				
		[ColumnMap("ModifyDt","ModifyDt")]
        public DateTime? ModifyDt{ get; set; }
				
		[ColumnMap("ModifyUser","ModifyUser")]
        public string ModifyUser{ get; set; }
				
		[ColumnMap("CreateDt","CreateDt")]
        public DateTime? CreateDt{ get; set; }
				
		[ColumnMap("CreateUser","CreateUser")]
        public string CreateUser{ get; set; }
				
		[ColumnMap("Version","Version")]
        public byte[] Version{ get; set; }
		   
	}
}