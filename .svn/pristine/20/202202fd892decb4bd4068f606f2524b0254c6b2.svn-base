using System; 
using System.Text;
using System.Collections.Generic; 
using System.Data;
using COM.Domain;
namespace ERP.Domain
{
   public class ERP_C003_Supplier_File : AggregateRoot
	{
   		public  ERP_C003_Supplier_File(Guid id)
   			: base(id)
		{
			
		}
		public  ERP_C003_Supplier_File( )
			: base(Guid.NewGuid())
		{
		
		}

		[ColumnMap("CompCode", "")]
        public string CompCode{ get; set; }
				
		[ColumnMap("SuppCode", "")]
        public string SuppCode{ get; set; }
				
		[ColumnMap("DocNo", "")]
        public string DocNo{ get; set; }
				
		[ColumnMap("DocName", "")]
        public string DocName{ get; set; }
				
		[ColumnMap("DocEffDt", "")]
        public DateTime? DocEffDt{ get; set; }
				
		[ColumnMap("DocTermDt", "")]
        public DateTime? DocTermDt{ get; set; }
				
		[ColumnMap("Content", "")]
        public byte[] Content{ get; set; }
				
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

        public byte[] Version { get; set; }
		   
	}
}