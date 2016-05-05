using System; 
using System.Text;
using System.Collections.Generic; 
using System.Data;
using COM.Domain;
using System.ComponentModel.DataAnnotations;
namespace ERP.Domain
{
   public partial class tb_Sys_User:AggregateRoot
	{
   		public  tb_Sys_User(Guid id)
   			: base(id)
		{
			
		}
		public  tb_Sys_User( )
            :base(Guid.NewGuid())
		{
		
		}

        [ColumnMap("CompCode", "")]
        public string CompCode { get; set; }
				
		[ColumnMap("UserCode", "")]
        public string UserCode{ get; set; }
				
		[ColumnMap("UserName", "")]
        [Required(ErrorMessage="姓名不能为空")]
        public string UserName{ get; set; }
				
		[ColumnMap("UserPassword", "")]
       [Required(ErrorMessage="密码不能为空")]
        public string UserPassword{ get; set; }
				

				
		[ColumnMap("CreateTime", "")]
        public DateTime? CreateTime{ get; set; }
				
		[ColumnMap("ModifyTime", "")]
        public DateTime? ModifyTime{ get; set; }
				
		[ColumnMap("Createuser", "")]
        public string Createuser{ get; set; }
				
		[ColumnMap("ModifyUser", "")]
        public string ModifyUser{ get; set; }

        [ColumnMap("Version", "")]
        public byte[] Version { get; set; }
		   
	}
}