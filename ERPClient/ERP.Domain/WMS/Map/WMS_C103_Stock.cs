using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.ComponentModel.DataAnnotations;
using COM.Domain;
namespace ERP.Domain
{
	 	//WMS_C103_Stock
	   public class WMS_C103_StockMap:EntityTypeConfiguration<WMS_C103_Stock>
	{
           public WMS_C103_StockMap()
           {
               this.ToTable("WMS_M101_Stock");
               this.HasKey(t => t.Id);
               this.Property(t => t.Id).HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);
               this.Property(t => t.Id).HasColumnName("Id");
               this.Property(t => t.InStoreDetailId).HasColumnName("InStoreDetailId");
               this.Property(t => t.InStoreId).HasColumnName("InStoreId");
               this.Property(t => t.ARCode).HasColumnName("ARCode");
               this.Property(t => t.PartSpec).HasColumnName("PartSpec");
               this.Property(t => t.MatClass2).HasColumnName("MatClass2");
               this.Property(t => t.SuppLot).HasColumnName("SuppLot");
               this.Property(t => t.StoreAmount).HasColumnName("StoreAmount");
               this.Property(t => t.StockStatus).HasColumnName("StockStatus");
               this.Property(t => t.SuppCode).HasColumnName("SuppCode");
               this.Property(t => t.ModifyDt).HasColumnName("ModifyDt");
               this.Property(t => t.ModifyUser).HasColumnName("ModifyUser");
               this.Property(t => t.CreateDt).HasColumnName("CreateDt");
               this.Property(t => t.CreateUser).HasColumnName("CreateUser");
               this.Property(t => t.Version).HasColumnName("Version").IsRowVersion().HasDatabaseGeneratedOption(DatabaseGeneratedOption.Computed).IsOptional();
               this.Ignore(a => a.OutAmount);
               this.Property(t => t.MatCode).HasColumnName("MatCode");
           }
	}
}