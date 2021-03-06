﻿using System; 
using System.Text;
using System.Collections.Generic; 
using System.Data;
using COM.Domain;
namespace ERP.Domain
{
   public class WMS_C102_Area:AggregateRoot
	{
   		public  WMS_C102_Area(Guid id)
   			: base(id)
		{
			
		}
		public  WMS_C102_Area( )
			: base(Guid.NewGuid())
		{
		
		}



        [ColumnMap("StockArea", "")]
        public string StockArea { get; set; }
				
		[ColumnMap("ARCode", "")]
        public string ARCode{ get; set; }
				
		[ColumnMap("ARName", "")]
        public string ARName{ get; set; }
				
		[ColumnMap("SeqNo", "")]
        public string SeqNo{ get; set; }
				
		[ColumnMap("Remarks", "")]
        public string Remarks{ get; set; }
				
		[ColumnMap("ModifyUser", "")]
        public string ModifyUser{ get; set; }
				
		[ColumnMap("ModifyDt", "")]
        public DateTime? ModifyDt{ get; set; }
				
		[ColumnMap("CreateUser", "")]
        public string CreateUser{ get; set; }
				
		[ColumnMap("CreateDt", "")]
        public DateTime? CreateDt{ get; set; }
				
		[ColumnMap("Version", "")]
        public byte[] Version{ get; set; }

        public string State { get; set; }
	}
}