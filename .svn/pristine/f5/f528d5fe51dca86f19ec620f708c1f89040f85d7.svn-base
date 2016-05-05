using System; 
using System.Text;
using System.Collections.Generic; 
using System.Data;
using COM.Domain;
using System.ComponentModel.DataAnnotations;
namespace ERP.Domain
{
   public class tb_Sys_Menu:AggregateRoot
	{
   		public  tb_Sys_Menu(Guid id)
   			: base(id)
		{
			
		}
		public  tb_Sys_Menu( )
            : base(Guid.NewGuid())
		{
		
		}
      			
		
				
		[ColumnMap("MenuName", "")]
       [Required(ErrorMessage="菜单名称不能为空")]
        public string MenuName{ get; set; }
				
		[ColumnMap("MenuIcon", "")]
        public byte[] MenuIcon{ get; set; }
				
		[ColumnMap("ParentMenuId", "")]
        public Guid? ParentMenuId{ get; set; }
				
		[ColumnMap("SeqNo", "")]
        public string SeqNo{ get; set; }

       [ColumnMap("NameSpeace", "")]
        public string NameSpeace { get; set; }

       [ColumnMap("MenuType", "")]
       public string MenuType { get; set; }

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