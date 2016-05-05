using System; 
using System.Text;
using System.Collections.Generic; 
using System.Data;
using COM.Domain;
using System.ComponentModel.DataAnnotations;
namespace ERP.Domain
{
   public class ERP_M001_Product_File:AggregateRoot
	{
   		public  ERP_M001_Product_File(Guid id)
   			: base(id)
		{
			
		}
		public  ERP_M001_Product_File( )
			: base(Guid.NewGuid())
		{
		
		}
      			
		
				
		[ColumnMap("CompCode", "")]
        public string CompCode{ get; set; }
				
		[ColumnMap("ItemCode", "")]
        [Required(ErrorMessage = "产品代号不能为空")]
        public string ItemCode{ get; set; }
				
		[ColumnMap("DocNo", "")]
        [Required(ErrorMessage = "文件代号不能为空")]
        public string DocNo{ get; set; }
				
		[ColumnMap("DocType", "")]
        public string DocType{ get; set; }
				
		[ColumnMap("DocName", "")]
        public string DocName{ get; set; }
				
		[ColumnMap("Content", "")]
        public byte[] Content{ get; set; }
				
		[ColumnMap("Remarks", "")]
        public string Remarks{ get; set; }
				
		[ColumnMap("EffDt", "")]
        public DateTime? EffDt{ get; set; }
				
		[ColumnMap("TermDt", "")]
        public DateTime? TermDt{ get; set; }
				
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