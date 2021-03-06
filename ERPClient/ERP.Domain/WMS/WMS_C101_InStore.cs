﻿using System; 
using System.Text;
using System.Collections.Generic; 
using System.Data;
using COM.Domain;
namespace ERP.Domain
{
   public class WMS_C101_InStore:AggregateRoot
	{
   		public  WMS_C101_InStore(Guid id)
   			: base(id)
		{
			
		}
		public  WMS_C101_InStore( )
			: base(Guid.NewGuid())
		{
		
		}
	
		[ColumnMap("InStoreNo", "")]
        public string InStoreNo{ get; set; }
				
		[ColumnMap("DriverName", "")]
        public string DriverName{ get; set; }
				
		[ColumnMap("DriverTel", "")]
        public string DriverTel{ get; set; }
				
		[ColumnMap("DriverBusNumber", "")]
        public string DriverBusNumber{ get; set; }
				
		[ColumnMap("DriverDt", "")]
        public DateTime? DriverDt{ get; set; }
				
		[ColumnMap("EmpInfo", "")]
        public string EmpInfo{ get; set; }
				
		[ColumnMap("EmpTel", "")]
        public string EmpTel{ get; set; }
				
		[ColumnMap("SuppCode", "")]
        public string SuppCode{ get; set; }
				
		[ColumnMap("ActualAmount", "")]
        public decimal ActualAmount{ get; set; }
				
		[ColumnMap("ModifyDt", "")]
        public DateTime? ModifyDt{ get; set; }
				
		[ColumnMap("ModifyUser", "")]
        public string ModifyUser{ get; set; }
				
		[ColumnMap("CreateDt", "")]
        public DateTime? CreateDt{ get; set; }
				
		[ColumnMap("CreateUser", "")]
        public string CreateUser{ get; set; }
				
		[ColumnMap("Remarks", "")]
        public string Remarks{ get; set; }
				
		[ColumnMap("Version", "")]
        public byte[] Version{ get; set; }

        public DateTime? StoreInDate { get; set; }//入库时间

        public string StockArea { get; set; }//仓库
        public string DeliveryNo { get; set; }//送货单号

		   
	}
}