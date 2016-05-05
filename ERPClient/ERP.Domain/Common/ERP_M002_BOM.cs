using System; 
using System.Text;
using System.Collections.Generic; 
using System.Data;
using COM.Domain;
namespace ERP.Domain
{
   public class ERP_M002_BOM:AggregateRoot
	{
   		public  ERP_M002_BOM(Guid id)
   			: base(id)
		{
			
		}
		public  ERP_M002_BOM( )
			: base(Guid.NewGuid())
		{
		
		}
      			
		[ColumnMap("CompCode", "")]
        public string CompCode{ get; set; }

       [ColumnMap("BOMNo", "")]
        public string BOMNo { get; set; }

       [ColumnMap("EffectiveDt", "")]
        public DateTime? EffectiveDt { get; set; }
				
		[ColumnMap("PartNo", "")]
        public string PartNo{ get; set; }
				
		[ColumnMap("PartName", "")]
        public string PartName{ get; set; }
				
		[ColumnMap("ProcessFlow", "")]
        public string ProcessFlow{ get; set; }
				
		[ColumnMap("Remarks", "")]
        public string Remarks{ get; set; }
				
		[ColumnMap("StartDt", "")]
        public DateTime? StartDt{ get; set; }
				
		[ColumnMap("Status", "")]
        public string Status{ get; set; }
				
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