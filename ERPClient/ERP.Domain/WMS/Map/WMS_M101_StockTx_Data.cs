using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.ComponentModel.DataAnnotations;
using COM.Domain;
namespace ERP.Domain
{
	 	//WMS_M101_StockTx_Data
	   public class WMS_M101_StockTx_DataMap:EntityTypeConfiguration<WMS_M101_StockTx_Data>
	{
           public WMS_M101_StockTx_DataMap()
           {
               this.ToTable("WMS_M101_StockTx_Data");
               this.HasKey(t => t.Id);
               this.Property(t => t.Id).HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);
               this.Property(t => t.Id).HasColumnName("IdentityNo");
               this.Property(t => t.StockID).HasColumnName("StockID");
               this.Property(t => t.OPType).HasColumnName("OPType");
               this.Property(t => t.DocNo).HasColumnName("DocNo");
               this.Property(t => t.TxDt).HasColumnName("TxDt");
               this.Property(t => t.LotNo).HasColumnName("LotNo");
               this.Property(t => t.CustCode).HasColumnName("CustCode");
               this.Property(t => t.PartNo).HasColumnName("PartNo");
               this.Property(t => t.Weight).HasColumnName("Weight");
               this.Property(t => t.Qty).HasColumnName("Qty");
               this.Property(t => t.Operator).HasColumnName("Operator");
               this.Property(t => t.ModifyDt).HasColumnName("ModifyDt");
               this.Property(t => t.ModifyUser).HasColumnName("ModifyUser");
               this.Property(t => t.CreateDt).HasColumnName("CreateDt");
               this.Property(t => t.CreateUser).HasColumnName("CreateUser");
               this.Property(t => t.Version).HasColumnName("Version").IsRowVersion().HasDatabaseGeneratedOption(DatabaseGeneratedOption.Computed).IsOptional();
               this.Property(t => t.ARCode).HasColumnName("ARCode");
               this.Property(t => t.IsProcessed).HasColumnName("IsProcessed");
               this.Ignore(t => t.Check);
           }
	}
}