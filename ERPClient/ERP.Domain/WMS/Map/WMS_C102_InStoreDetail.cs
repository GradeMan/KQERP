using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.ComponentModel.DataAnnotations;
using COM.Domain;
namespace ERP.Domain
{
	 	//WMS_C102_InStoreDetail
	   public class WMS_C102_InStoreDetailMap:EntityTypeConfiguration<WMS_C102_InStoreDetail>
	{
           public WMS_C102_InStoreDetailMap()
           {
               this.ToTable("WMS_M102_InStoreDetail");
               this.HasKey(t => t.Id);
               this.Property(t => t.Id).HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);
               this.Property(t => t.Id).HasColumnName("Id");
               this.Property(t => t.InStoreId).HasColumnName("InStoreId");
               this.Property(t => t.InStoreNo).HasColumnName("DocNo");
               this.Property(t => t.ARCode).HasColumnName("ARCode");
               this.Property(t => t.PartSpec).HasColumnName("PartSpec");
               this.Property(t => t.MatClass2).HasColumnName("MatClass2");
               this.Property(t => t.Amount).HasColumnName("Qty");
               this.Property(t => t.SuppLot).HasColumnName("SuppLot");
               this.Property(t => t.ModifyDt).HasColumnName("ModifyDt");
               this.Property(t => t.ModifyUser).HasColumnName("ModifyUser");
               this.Property(t => t.CreateDt).HasColumnName("CreateDt");
               this.Property(t => t.CreateUser).HasColumnName("CreateUser");
               this.Property(t => t.Version).HasColumnName("Version").IsRowVersion().HasDatabaseGeneratedOption(DatabaseGeneratedOption.Computed).IsOptional();
               this.Property(t => t.MatCode).HasColumnName("MatCode");
               this.Property(t => t.Unit).HasColumnName("Unit");
               this.Property(t => t.UnitPrice).HasColumnName("UnitPrice");
               this.Property(t => t.Remarks).HasColumnName("Remarks");
               this.Property(t => t.SumPrice).HasColumnName("Amount");
           }
	}
}