using System; 
using System.Text;
using System.Collections.Generic; 
using System.Data;
using COM.Domain;
namespace ERP.Domain
{
   public class tb_Sys_RolesControl:AggregateRoot
	{
   		public  tb_Sys_RolesControl(Guid id)
   			: base(id)
		{
			
		}
		public  tb_Sys_RolesControl( )
			: base(Guid.NewGuid())
		{
		
		}
      			
				
		[ColumnMap("CompCode", "")]
        public string CompCode{ get; set; }
				
		[ColumnMap("Roles_Id", "")]
        public Guid? Roles_Id{ get; set; }
				
		[ColumnMap("ControlId", "")]
        public Guid? ControlId{ get; set; }
				
		[ColumnMap("ModifyDt", "")]
        public DateTime? ModifyDt{ get; set; }
				
		[ColumnMap("ModifyUser", "")]
        public string ModifyUser{ get; set; }
				
		[ColumnMap("CreateDt", "")]
        public DateTime? CreateDt{ get; set; }
				
		[ColumnMap("CreateUser", "")]
        public string CreateUser{ get; set; }
				
		[ColumnMap("Version", "")]
        public byte[] Version{ get; set; }
		   
	}
}