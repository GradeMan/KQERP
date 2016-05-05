using System; 
using System.Text;
using System.Collections.Generic; 
using System.Data;
using COM.Domain;
namespace ERP.Domain
{
   public class tb_Sys_RolesBtn:AggregateRoot
	{
   		public  tb_Sys_RolesBtn(Guid id)
   			: base(id)
		{
			
		}
		public  tb_Sys_RolesBtn( )
            : base(Guid.NewGuid())
		{
		
		}

        [ColumnMap("Menu_Id", "")]
        public Guid Menu_Id { get; set; }
				
		[ColumnMap("Roles_Id", "")]
        public Guid Roles_Id{ get; set; }
				
		[ColumnMap("Btn_Id", "")]
        public Guid Btn_Id{ get; set; }

        [ColumnMap("CreateTime", "")]
        public DateTime? CreateTime { get; set; }

        [ColumnMap("Version", "")]
        public byte[] Version { get; set; }
		   
	}
}