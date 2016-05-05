using System; 
using System.Text;
using System.Collections.Generic; 
using System.Data;
using COM.Domain;
namespace ERP.Domain
{
   public class tb_Sys_Controls:AggregateRoot
	{
   		public  tb_Sys_Controls(Guid id)
   			: base(id)
		{
			
		}
		public  tb_Sys_Controls( )
			: base(Guid.NewGuid())
		{
		
		}
      			
				
		[ColumnMap("CompCode", "")]
        public string CompCode{ get; set; }
				
		[ColumnMap("Windows", "")]
        public string Windows{ get; set; }
				
		[ColumnMap("Control", "")]
        public string Control{ get; set; }
				
		[ColumnMap("CValue", "")]
        public string CValue{ get; set; }
				
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