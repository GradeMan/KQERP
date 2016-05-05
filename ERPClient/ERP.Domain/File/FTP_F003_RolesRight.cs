using System; 
using System.Text;
using System.Collections.Generic; 
using System.Data;
using COM.Domain;
namespace ERP.Domain
{
   public class FTP_F003_RolesRight:AggregateRoot
	{
   		public  FTP_F003_RolesRight(Guid id)
   			: base(id)
		{
			
		}
		public  FTP_F003_RolesRight( )
			: base(Guid.NewGuid())
		{
		
		}

        [ColumnMap("CompCode", "")]
        public string CompCode { get; set; }
							
		[ColumnMap("RoleId", "")]
        public Guid RoleId{ get; set; }
								
		[ColumnMap("DirId", "")]
        public Guid DirId{ get; set; }
								
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