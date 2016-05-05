using System; 
using System.Text;
using System.Collections.Generic; 
using System.Data;
using COM.Domain;
namespace ERP.Domain
{
   public class WMS_C104_OutStore:AggregateRoot
	{
   		public  WMS_C104_OutStore(Guid id)
   			: base(id)
		{
			
		}
		public  WMS_C104_OutStore( )
			: base(Guid.NewGuid())
		{
		
		}

        [ColumnMap("CompCode", "")]
        public string CompCode { get; set; }

        [ColumnMap("OutStoreNo", "")]
        public string OutStoreNo { get; set; }

        [ColumnMap("Unit", "")]
        public string Unit { get; set; }

        [ColumnMap("ActulAmount", "")]
        public decimal ActulAmount { get; set; }

        [ColumnMap("LeadDept", "")]
        public string LeadDept { get; set; }

        [ColumnMap("LeadDt", "")]
        public DateTime? LeadDt { get; set; }

        [ColumnMap("LeadUser", "")]
        public string LeadUser { get; set; }

        [ColumnMap("LeadManager", "")]
        public string LeadManager { get; set; }

        [ColumnMap("StockManager", "")]
        public string StockManager { get; set; }

        [ColumnMap("CreateUser", "")]
        public string CreateUser { get; set; }

        [ColumnMap("CreateDt", "")]
        public DateTime? CreateDt { get; set; }

        [ColumnMap("ModifyUser", "")]
        public string ModifyUser { get; set; }

        [ColumnMap("ModifyDt", "")]
        public DateTime? ModifyDt { get; set; }


		[ColumnMap("Version", "")]
        public byte[] Version{ get; set; }

        public string Status { get; set; }
				   		
	}
}