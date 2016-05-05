using System; 
using System.Text;
using System.Collections.Generic; 
using System.Data;
using COM.Domain;
namespace ERP.Domain
{
   public class WMS_M105_MatReturnDetail:AggregateRoot
	{
   		public  WMS_M105_MatReturnDetail(Guid id)
   			: base(id)
		{
			
		}
		public  WMS_M105_MatReturnDetail( )
			: base(Guid.NewGuid())
		{
		
		}
				
		[ColumnMap("CompCode","CompCode")]
        public string CompCode{ get; set; }
				
		[ColumnMap("ReturnNo","ReturnNo")]
        public string ReturnNo{ get; set; }
				
		[ColumnMap("MatSpecCode","MatSpecCode")]
        public string MatSpecCode{ get; set; }
				
		[ColumnMap("MatSpec","MatSpec")]
        public string MatSpec{ get; set; }

        [ColumnMap("MatType", "MatCode")]
        public string MatType { get; set; }
				
		[ColumnMap("Suppode","Suppode")]
        public string Suppode{ get; set; }
				
		[ColumnMap("RetQty","RetQty")]
        public decimal RetQty{ get; set; }
				
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