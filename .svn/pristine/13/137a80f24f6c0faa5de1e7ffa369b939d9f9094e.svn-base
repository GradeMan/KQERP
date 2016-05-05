using System; 
using System.Text;
using System.Collections.Generic; 
using System.Data;
using COM.Domain;
namespace ERP.Domain
{
   public class WMS_C101_WareHouse:AggregateRoot
	{
   		public  WMS_C101_WareHouse(Guid id)
   			: base(id)
		{
			
		}
		public  WMS_C101_WareHouse( )
			: base(Guid.NewGuid())
		{
		
		}
      			
		
				
		[ColumnMap("CompCode", "")]
        public string CompCode{ get; set; }
				
		[ColumnMap("WHCode", "")]
        public string WHCode{ get; set; }
				
		[ColumnMap("WHName", "")]
        public string WHName{ get; set; }
				
		[ColumnMap("SeqNo", "")]
        public string SeqNo{ get; set; }
				
		[ColumnMap("Remarks", "")]
        public string Remarks{ get; set; }
				
		[ColumnMap("ModifyDt", "")]
        public DateTime? ModifyDt{ get; set; }
				
		[ColumnMap("ModifyUser", "")]
        public string ModifyUser{ get; set; }
				
		[ColumnMap("CreateDt", "")]
        public DateTime? CreateDt{ get; set; }
				
		[ColumnMap("Createuser", "")]
        public string CreateUser{ get; set; }
				
		[ColumnMap("Version", "")]
        public byte[] Version{ get; set; }
		   
	}
}