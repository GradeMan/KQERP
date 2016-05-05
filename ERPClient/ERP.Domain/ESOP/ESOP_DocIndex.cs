using System; 
using System.Text;
using System.Collections.Generic; 
using System.Data;
using COM.Domain;
namespace ERP.Domain
{
   public class ESOP_DocIndex:AggregateRoot
	{
   		public  ESOP_DocIndex(Guid id)
   			: base(id)
		{
			
		}
		public  ESOP_DocIndex( )
			: base(Guid.NewGuid())
		{
		
		}
      			
		[ColumnMap("CompCode", "")]
        public string CompCode{ get; set; }
				
		[ColumnMap("DocIndexName", "")]
        public string DocIndexName{ get; set; }
				
		[ColumnMap("PreDocIndexId", "")]
        public Guid PreDocIndexId{ get; set; }
				
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
				
		[ColumnMap("CreateUser", "")]
        public string CreateUser{ get; set; }
				
		[ColumnMap("Version", "")]
        public byte[] Version { get; set; }
		   
	}
}