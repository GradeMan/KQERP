using System; 
using System.Text;
using System.Collections.Generic; 
using System.Data;
using COM.Domain;
using System.ComponentModel.DataAnnotations;
namespace ERP.Domain
{
   public class ERP_C001_Code:AggregateRoot
	{
   		public  ERP_C001_Code(Guid id)
   			: base(id)
		{
			
		}
		public  ERP_C001_Code( )
			: base(Guid.NewGuid())
		{
		
		}
      			
		
				
		[ColumnMap("CompCode", "")]
       [Required(ErrorMessage="公司名称不能为空")]
        public string CompCode{ get; set; }
				
		[ColumnMap("CodeID", "")]
       [Required(ErrorMessage="类别代号不能为空")]
        public string CodeID{ get; set; }
				
		[ColumnMap("CodeIDDesc", "")]
       [Required(ErrorMessage="类别名称不能为空")]
        public string CodeIDDesc{ get; set; }
				
		[ColumnMap("Code", "")]
       [Required(ErrorMessage="代号不能为空")]
        public string Code{ get; set; }
				
		[ColumnMap("Description", "")]
       [Required(ErrorMessage="描述不能为空")]
        public string Description{ get; set; }
				
		[ColumnMap("GroupCode", "")]
        public string GroupCode{ get; set; }
				
		[ColumnMap("GroupName", "")]
        public string GroupName{ get; set; }
				
		[ColumnMap("Status", "")]
        public string Status{ get; set; }
				
		[ColumnMap("Remarks", "")]
        public string Remarks{ get; set; }
				
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