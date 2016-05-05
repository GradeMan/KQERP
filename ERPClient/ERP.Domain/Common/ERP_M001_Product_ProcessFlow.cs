using System; 
using System.Text;
using System.Collections.Generic; 
using System.Data;
using COM.Domain;
using System.ComponentModel.DataAnnotations;
namespace ERP.Domain
{
   public class ERP_M001_Product_ProcessFlow:AggregateRoot
	{
   		public  ERP_M001_Product_ProcessFlow(Guid id)
   			: base(id)
		{
			
		}
		public  ERP_M001_Product_ProcessFlow( )
			: base(Guid.NewGuid())
		{
		
		}

        [ColumnMap("CompCode", "CompCode")]
        public string CompCode { get; set; }

        [ColumnMap("PartNo", "PartNo")]
        public string PartNo { get; set; }

        [ColumnMap("PFCode", "PFCode")]
        public string PFCode { get; set; }

        [ColumnMap("ProcessCode", "ProcessCode")]
        public string ProcessCode { get; set; }

        [ColumnMap("ProcessKey", "ProcessKey")]
        public int ProcessKey { get; set; }

        [ColumnMap("ProcessSeqNo", "ProcessSeqNo")]
        public string ProcessSeqNo { get; set; }

        [ColumnMap("Remarks", "Remarks")]
        public string Remarks { get; set; }

        public string ProcessName { get; set; }

        public string ProcessType { get; set; }
		   
	}
}