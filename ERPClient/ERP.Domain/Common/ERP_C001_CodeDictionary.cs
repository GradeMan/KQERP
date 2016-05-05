using System; 
using System.Text;
using System.Collections.Generic; 
using System.Data;
using COM.Domain;
namespace ERP.Domain
{
   public class ERP_C001_CodeDictionary:AggregateRoot
	{
   		public  ERP_C001_CodeDictionary(Guid id)
   			: base(id)
		{
			
		}
		public  ERP_C001_CodeDictionary( )
			: base(Guid.NewGuid())
		{
		
		}
				
		[ColumnMap("CompCode","CompCode")]
        public string CompCode{ get; set; }
				
		[ColumnMap("ParentId","ParentId")]
        public string ParentId{ get; set; }
				
		[ColumnMap("IsTree","IsTree")]
        public int? IsTree{ get; set; }
				
		[ColumnMap("Category","Category")]
        public string Category{ get; set; }
				
		[ColumnMap("Code","Code")]
        public string Code{ get; set; }
				
		[ColumnMap("FullName","FullName")]
        public string FullName{ get; set; }
				
		[ColumnMap("Remark","Remark")]
        public string Remark{ get; set; }
				
		[ColumnMap("Enabled","Enabled")]
        public int? Enabled{ get; set; }
				
		[ColumnMap("SortCode","SortCode")]
        public int? SortCode{ get; set; }
				
		[ColumnMap("DeleteMark","DeleteMark")]
        public int? DeleteMark{ get; set; }
				
		[ColumnMap("CreateDt","CreateDt")]
        public DateTime? CreateDt{ get; set; }
				
		[ColumnMap("CreateUser","CreateUser")]
        public string CreateUser{ get; set; }
				
		[ColumnMap("ModifyDt","ModifyDt")]
        public DateTime? ModifyDt{ get; set; }
				
		[ColumnMap("ModifyUser","ModifyUser")]
        public string ModifyUser{ get; set; }
		   
	}
}