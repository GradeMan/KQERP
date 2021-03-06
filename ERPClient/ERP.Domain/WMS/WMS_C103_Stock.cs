﻿using System; 
using System.Text;
using System.Collections.Generic; 
using System.Data;
using COM.Domain;
namespace ERP.Domain
{
   public class WMS_C103_Stock:AggregateRoot
	{
        public WMS_C103_Stock(Guid id)
            : base(id)
        {

        }
        public WMS_C103_Stock()
            : base(Guid.NewGuid())
        {

        }

        [ColumnMap("InStoreDetailId", "")]
        public Guid InStoreDetailId { get; set; }

        [ColumnMap("InStoreId", "")]
        public Guid InStoreId { get; set; }

        [ColumnMap("ARCode", "")]
        public string ARCode { get; set; }

        [ColumnMap("PartSpec", "")]
        public string PartSpec { get; set; }

        [ColumnMap("MatClass2", "")]
        public string MatClass2 { get; set; }

        [ColumnMap("SuppLot", "")]
        public string SuppLot { get; set; }

        [ColumnMap("StoreAmount", "")]
        public decimal StoreAmount { get; set; }

        [ColumnMap("StockStatus", "")]
        public string StockStatus { get; set; }

        [ColumnMap("SuppCode", "")]
        public string SuppCode { get; set; }

        [ColumnMap("ModifyDt", "")]
        public DateTime? ModifyDt { get; set; }

        [ColumnMap("ModifyUser", "")]
        public string ModifyUser { get; set; }

        [ColumnMap("CreateDt", "")]
        public DateTime CreateDt { get; set; }

        [ColumnMap("CreateUser", "")]
        public string CreateUser { get; set; }
					
		[ColumnMap("Version", "")]
        public byte[] Version{ get; set; }

        public decimal OutAmount { get; set; }

        public string MatCode { get; set; }
				   		
	}
}