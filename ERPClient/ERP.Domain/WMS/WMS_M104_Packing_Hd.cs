using System; 
using System.Text;
using System.Collections.Generic; 
using System.Data;
using COM.Domain;
namespace ERP.Domain
{
   public class WMS_M104_Packing_Hd:AggregateRoot
	{
   		public  WMS_M104_Packing_Hd(Guid id)
   			: base(id)
		{
			
		}
		public  WMS_M104_Packing_Hd( )
			: base(Guid.NewGuid())
		{
		
		}

        [ColumnMap("Date", "Date")]
        public DateTime? Date { get; set; }

        [ColumnMap("CustCode", "CustCode")]
        public string CustCode { get; set; }

        [ColumnMap("Code", "Code")]
        public string Code { get; set; }

        [ColumnMap("PoNo", "PoNo")]
        public string PoNo { get; set; }

        [ColumnMap("PartNo", "PartNo")]
        public string PartNo { get; set; }

        [ColumnMap("InvoiceNo", "InvoiceNo")]
        public string InvoiceNo { get; set; }

        [ColumnMap("DocNo", "DocNo")]
        public string DocNo { get; set; }

        [ColumnMap("Model", "Model")]
        public string Model { get; set; }

        [ColumnMap("CreateUser", "")]
        public string CreateUser { get; set; }

        [ColumnMap("CreatDt", "")]
        public DateTime? CreateDt { get; set; }

        [ColumnMap("ModifyUser", "")]
        public string ModifyUser { get; set; }

        [ColumnMap("ModifyDt", "")]
        public DateTime? ModifyDt { get; set; }

        public decimal? SumQty { get; set; }
		   
	}
}