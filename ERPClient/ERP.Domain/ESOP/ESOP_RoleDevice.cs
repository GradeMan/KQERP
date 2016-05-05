using System; 
using System.Text;
using System.Collections.Generic; 
using System.Data;
using COM.Domain;
namespace ERP.Domain
{
   public class ESOP_RoleDevice:AggregateRoot
	{
   		public  ESOP_RoleDevice(Guid id)
   			: base(id)
		{
			
		}
		public  ESOP_RoleDevice( )
			: base(Guid.NewGuid())
		{
		
		}
      			
				
		[ColumnMap("RoleId", "")]
        public Guid RoleId{ get; set; }
				
		[ColumnMap("DevId", "")]
        public Guid DevId{ get; set; }
		   
	}
}