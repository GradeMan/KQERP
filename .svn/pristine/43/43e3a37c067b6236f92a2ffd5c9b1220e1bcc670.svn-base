using System; 
using System.Text;
using System.Collections.Generic; 
using System.Data;
using COM.Domain;
using System.ComponentModel.DataAnnotations;
namespace ERP.Domain
{
   public class tb_Sys_Roles:AggregateRoot
	{
   		public  tb_Sys_Roles(Guid id)
   			: base(id)
		{
			
		}
		public  tb_Sys_Roles( )
            : base(Guid.NewGuid())
		{
		
		}
      			
		
				
		[ColumnMap("Roles_Name", "")]
        [Required(ErrorMessage = "名称不能为空")]
        public string Roles_Name{ get; set; }
				
		[ColumnMap("Roles_Remark", "")]
        public string Roles_Remark{ get; set; }
				
		
				
		[ColumnMap("CreateTime", "")]
        public DateTime? CreateTime{ get; set; }
				
		[ColumnMap("ModifyTime", "")]
        public DateTime? ModifyTime{ get; set; }
				
		[ColumnMap("CreateUser", "")]
        public string CreateUser{ get; set; }
				
		[ColumnMap("ModifyUser", "")]
        public string ModifyUser{ get; set; }

        [ColumnMap("Version", "")]
        public byte[] Version { get; set; }
		   
	}
}