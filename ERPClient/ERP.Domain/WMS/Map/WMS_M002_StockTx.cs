using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.ComponentModel.DataAnnotations;
using COM.Domain;
namespace ERP.Domain
{
	 	//WMS_M002_StockTx
	   public class WMS_M002_StockTxMap:EntityTypeConfiguration<WMS_M002_StockTx>
	{
		public WMS_M002_StockTxMap ()
		{
			this.ToTable("WMS_M002_StockTx");
            this.HasKey(t => t.Id);
            this.Property(t => t.Id).HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);
      								 			this.Property(t => t.Id).HasColumnName("Id");
												 			this.Property(t => t.StockID).HasColumnName("StockID");
												 			this.Property(t => t.OPType).HasColumnName("OPType");
												 			this.Property(t => t.CustCode).HasColumnName("CustCode");
												 			this.Property(t => t.MLotNo).HasColumnName("MLotNo");
												 			this.Property(t => t.LotNo).HasColumnName("LotNo");
												 			this.Property(t => t.PartNo).HasColumnName("PartNo");
												 			this.Property(t => t.BoxQty).HasColumnName("BoxQty");
												 			this.Property(t => t.Qty).HasColumnName("Qty");
												 			this.Property(t => t.ProdDt).HasColumnName("ProdDt");
												 			this.Property(t => t.ExpiredDt).HasColumnName("ExpiredDt");
												 			this.Property(t => t.TxDt).HasColumnName("TxDt");
												 			this.Property(t => t.Remarks).HasColumnName("Remarks");
												 			this.Property(t => t.Status).HasColumnName("Status");
												 			this.Property(t => t.Code2D).HasColumnName("Code2D");
												 			this.Property(t => t.ModifyDt).HasColumnName("ModifyDt");
												 			this.Property(t => t.ModifyUser).HasColumnName("ModifyUser");
												 			this.Property(t => t.CreateDt).HasColumnName("CreateDt");
												 			this.Property(t => t.CreateUser).HasColumnName("CreateUser");
									 			this.Property(t => t.Version).HasColumnName("Version").IsRowVersion().HasDatabaseGeneratedOption( DatabaseGeneratedOption.Computed ).IsOptional();
									   		}
	}
}