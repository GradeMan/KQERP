using System; 
using System.Text;
using System.Collections.Generic; 
using System.Data;
using COM.Domain;
namespace ERP.Domain
{
   public class ERP_C009_Layout:AggregateRoot
	{
   		public  ERP_C009_Layout(Guid id)
   			: base(id)
		{
			
		}
		public  ERP_C009_Layout( )
			: base(Guid.NewGuid())
		{
		
		}
				
		[ColumnMap("UserId", "")]
        public string UserId{ get; set; }
				
		[ColumnMap("FrmType", "")]
        public string FrmType{ get; set; }
				
		[ColumnMap("LayType", "")]
        public string LayType{ get; set; }
				
		[ColumnMap("LayFiles", "")]
        public byte[] LayFiles{ get; set; }

       [ColumnMap("LayFiles2", "")]
        public byte[] LayFiles2{ get; set; }

       [ColumnMap("LayFiles3", "")]
        public byte[] LayFiles3{ get; set; }
		   
	}
}