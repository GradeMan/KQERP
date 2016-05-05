using System; 
using System.Text;
using System.Collections.Generic; 
using System.Data;
using COM.Domain;
using System.ComponentModel.DataAnnotations;
namespace ERP.Domain
{
   public class tb_Sys_Button:AggregateRoot
	{
   		public  tb_Sys_Button(Guid id)
   			: base(id)
		{
			
		}
		public  tb_Sys_Button( )
            : base(Guid.NewGuid())
		{
		
		}
      			
		
				
		[ColumnMap("Btn_Name", "")]
        [Required(ErrorMessage = "名称不能为空")]
        public string Btn_Name{ get; set; }
				
		[ColumnMap("Btn_Icon", "")]
        public byte[] Btn_Icon{ get; set; }
				
		[ColumnMap("Btn_SeqNo", "")]
        public string Btn_SeqNo{ get; set; }
				
		
				
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