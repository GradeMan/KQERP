using System; 
using System.Text;
using System.Collections.Generic; 
using System.Data;
using COM.Domain;
namespace ERP.Domain
{
   public class tb_Sys_UserRole:AggregateRoot
	{
   		public  tb_Sys_UserRole(Guid id)
   			: base(id)
		{
			
		}
		public  tb_Sys_UserRole( )
            : base(Guid.NewGuid())
		{
		
		}
      			
	
				
		[ColumnMap("UserId", "")]
        public Guid UserId{ get; set; }
				
		[ColumnMap("RoleId", "")]
        public Guid RoleId{ get; set; }

        [ColumnMap("CreateTime", "")]
        public DateTime? CreateTime { get; set; }

        [ColumnMap("Version", "")]
        public byte[] Version { get; set; }
		   
	}
}