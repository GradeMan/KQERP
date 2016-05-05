using System; 
using System.Text;
using System.Collections.Generic; 
using System.Data;
using COM.Domain;
namespace ERP.Domain
{
   public class MES_M501_JobTxProdInfo:AggregateRoot
	{
   		public  MES_M501_JobTxProdInfo(Guid id)
   			: base(id)
		{
			
		}
		public  MES_M501_JobTxProdInfo( )
			: base(Guid.NewGuid())
		{
		
		}
				
		[ColumnMap("CompCode","CompCode")]
        public string CompCode{ get; set; }
				
		[ColumnMap("JobNo","JobNo")]
        public string JobNo{ get; set; }
				
		[ColumnMap("PFCode","PFCode")]
        public string PFCode{ get; set; }
				
		[ColumnMap("ProcessCode","ProcessCode")]
        public string ProcessCode{ get; set; }
				
		[ColumnMap("TechCode","TechCode")]
        public string TechCode{ get; set; }
				
		[ColumnMap("TechType","TechType")]
        public string TechType{ get; set; }
				
		[ColumnMap("TechSeqNo","TechSeqNo")]
        public string TechSeqNo{ get; set; }
				
		[ColumnMap("TechContent","TechContent")]
        public string TechContent{ get; set; }
				
		[ColumnMap("Remarks","Remarks")]
        public string Remarks{ get; set; }

        [ColumnMap("TechReallyContent", "TechReallyContent")]
        public string TechReallyContent { get; set; }
		   
	}
}