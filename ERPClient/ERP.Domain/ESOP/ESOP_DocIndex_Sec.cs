using System; 
using System.Text;
using System.Collections.Generic; 
using System.Data;
using COM.Domain;
namespace ERP.Domain
{
   public class ESOP_DocIndex_Sec:AggregateRoot
	{
   		public  ESOP_DocIndex_Sec(Guid id)
   			: base(id)
		{
			
		}
		public  ESOP_DocIndex_Sec( )
			: base(Guid.NewGuid())
		{
		
		}
				
		[ColumnMap("DocIndexId", "")]
        public Guid DocIndexId { get; set; }
				
		[ColumnMap("RoleId", "")]
        public Guid RoleId { get; set; }
		   
	}
}