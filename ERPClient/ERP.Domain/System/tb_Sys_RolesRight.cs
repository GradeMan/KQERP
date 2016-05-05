using System; 
using System.Text;
using System.Collections.Generic; 
using System.Data;
using COM.Domain;
namespace ERP.Domain
{
   public class tb_Sys_RolesRight:AggregateRoot
	{
   		public  tb_Sys_RolesRight(Guid id)
   			: base(id)
		{
			
		}
		public  tb_Sys_RolesRight( )
            : base(Guid.NewGuid())
		{
		
		}
      	
				
		[ColumnMap("Roles_Id", "")]
        public Guid Roles_Id{ get; set; }
				
		[ColumnMap("Menu_Id", "")]
        public Guid Menu_Id{ get; set; }
				
		
				
		[ColumnMap("CreateTime", "")]
        public DateTime? CreateTime{ get; set; }
				
		[ColumnMap("CreateUser", "")]
        public string CreateUser{ get; set; }

        [ColumnMap("Version", "")]
        public byte[] Version { get; set; }
		   
	}
}