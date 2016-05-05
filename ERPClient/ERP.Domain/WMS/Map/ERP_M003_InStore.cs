using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.ComponentModel.DataAnnotations;
using COM.Domain;
namespace ERP.Domain
{
	 	//ERP_M003_InStore
	   public class ERP_M003_InStoreMap:EntityTypeConfiguration<ERP_M003_InStore>
	{
           public ERP_M003_InStoreMap()
           {
               this.ToTable("ERP_M003_InStore");
               this.HasKey(t => t.Id);
               this.Property(t => t.Id).HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);
               this.Property(t => t.Id).HasColumnName("Id");
               this.Property(t => t.CompCode).HasColumnName("CompCode");
               this.Property(t => t.InStoreId).HasColumnName("InStoreId");
               this.Property(t => t.InstoreDt).HasColumnName("InstoreDt");
               this.Property(t => t.InStoreType).HasColumnName("InStoreType");
               this.Property(t => t.SuppCode).HasColumnName("SuppCode");
               this.Property(t => t.SuppDeliveryNo).HasColumnName("SuppDeliveryNo");
               this.Property(t => t.WHCode).HasColumnName("WHCode");
               this.Property(t => t.PONo).HasColumnName("PONo");
               this.Property(t => t.DeptCode).HasColumnName("DeptCode");
               this.Property(t => t.Qty).HasColumnName("Qty");
               this.Property(t => t.Amount).HasColumnName("Amount");
               this.Property(t => t.Status).HasColumnName("Status");
               this.Property(t => t.ModifyDt).HasColumnName("ModifyDt");
               this.Property(t => t.ModifyUser).HasColumnName("ModifyUser");
               this.Property(t => t.CreateDt).HasColumnName("CreateDt");
               this.Property(t => t.CreateUser).HasColumnName("CreateUser");
               this.Property(t => t.Version).HasColumnName("Version").IsRowVersion().HasDatabaseGeneratedOption(DatabaseGeneratedOption.Computed).IsOptional();
           }
	}
}