using System; 
using System.Text;
using System.Collections.Generic; 
using System.Data;
using COM.Domain;
namespace ERP.Domain
{
   public class WMS_C105_OutStoreDetail:AggregateRoot
	{
   		public  WMS_C105_OutStoreDetail(Guid id)
   			: base(id)
		{
			
		}
		public  WMS_C105_OutStoreDetail( )
			: base(Guid.NewGuid())
		{
		
		}

        [ColumnMap("CompCode", "")]
        public string CompCode { get; set; }

        [ColumnMap("OutStoreId", "")]
        public Guid OutStoreId { get; set; }

        [ColumnMap("OutSotreNo", "")]
        public string OutSotreNo { get; set; }

        [ColumnMap("ARCode", "")]
        public string ARCode { get; set; }

        [ColumnMap("PartSpec", "")]
        public string PartSpec { get; set; }

        [ColumnMap("MatClass2", "")]
        public string MatClass2 { get; set; }

        [ColumnMap("Amount", "")]
        public decimal Amount { get; set; }

        [ColumnMap("SuppLot", "")]
        public string SuppLot { get; set; }

        [ColumnMap("SuppCode", "")]
        public string SuppCode { get; set; }

        [ColumnMap("StockId", "")]
        public Guid StockId { get; set; }

        [ColumnMap("CreateUser", "")]
        public string CreateUser { get; set; }

        [ColumnMap("CreateDt", "")]
        public DateTime? CreateDt { get; set; }

        [ColumnMap("ModifyDt", "")]
        public DateTime? ModifyDt { get; set; }

        [ColumnMap("ModifyUser", "")]
        public string ModifyUser { get; set; }

		[ColumnMap("Version", "")]
        public byte[] Version{ get; set; }
				   		
	}
}