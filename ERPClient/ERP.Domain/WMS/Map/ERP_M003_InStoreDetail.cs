using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.ComponentModel.DataAnnotations;
using COM.Domain;
namespace ERP.Domain
{
	 	//ERP_M003_InStoreDetail
	   public class ERP_M003_InStoreDetailMap:EntityTypeConfiguration<ERP_M003_InStoreDetail>
	{
           public ERP_M003_InStoreDetailMap()
           {
               this.ToTable("ERP_M003_InStoreDetail");
               this.HasKey(t => t.Id);
               this.Property(t => t.Id).HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);
               this.Property(t => t.Id).HasColumnName("Id");
               this.Property(t => t.CompCode).HasColumnName("CompCode");
               this.Property(t => t.InStoreId).HasColumnName("InStoreId");
               this.Property(t => t.ArCode).HasColumnName("ArCode");
               this.Property(t => t.MatCode).HasColumnName("MatCode");
               this.Property(t => t.ProdDt).HasColumnName("ProdDt");
               this.Property(t => t.LotNo).HasColumnName("LotNo");
               this.Property(t => t.Unit).HasColumnName("Unit");
               this.Property(t => t.UnitPrice).HasColumnName("UnitPrice");
               this.Property(t => t.Qty).HasColumnName("Qty");
               this.Property(t => t.Amount).HasColumnName("Amount");
               this.Property(t => t.Remarks).HasColumnName("Remarks");
               this.Property(t => t.ModifyDt).HasColumnName("ModifyDt");
               this.Property(t => t.ModifyUser).HasColumnName("ModifyUser");
               this.Property(t => t.CreateDt).HasColumnName("CreateDt");
               this.Property(t => t.CreateUser).HasColumnName("CreateUser");
               this.Property(t => t.Version).HasColumnName("Version").IsRowVersion().HasDatabaseGeneratedOption(DatabaseGeneratedOption.Computed).IsOptional();
           }
	}
}