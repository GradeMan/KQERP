using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.ComponentModel.DataAnnotations;
using COM.Domain;
namespace ERP.Domain
{
	 	//ERP_M001_Material_Supp
	   public class ERP_M001_Material_SuppMap:EntityTypeConfiguration<ERP_M001_Material_Supp>
	{
           public ERP_M001_Material_SuppMap()
           {
               this.ToTable("ERP_M001_Material_Supp");
               this.HasKey(t => t.Id);
               this.Property(t => t.Id).HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);
               this.Property(t => t.Id).HasColumnName("Id");
               this.Property(t => t.CompCode).HasColumnName("CompCode");
               this.Property(t => t.MatCode).HasColumnName("MatCode");
               this.Property(t => t.SuppCode).HasColumnName("SuppCode");
               this.Property(t => t.Level).HasColumnName("Level");
               this.Property(t => t.Unit).HasColumnName("Unit");
               this.Property(t => t.UnitPrice).HasColumnName("UnitPrice");
               this.Property(t => t.PurPer).HasColumnName("PurPer");
               this.Property(t => t.DeliveryTerm).HasColumnName("DeliveryTerm");
               this.Property(t => t.PayTerm).HasColumnName("PayTerm");
               this.Property(t => t.Remarks).HasColumnName("Remarks");
               this.Property(t => t.ModifyDt).HasColumnName("ModifyDt");
               this.Property(t => t.ModifyUser).HasColumnName("ModifyUser");
               this.Property(t => t.CreateDt).HasColumnName("CreateDt");
               this.Property(t => t.CreateUser).HasColumnName("CreateUser");
               this.Property(t => t.Version).HasColumnName("Version").IsRowVersion().HasDatabaseGeneratedOption(DatabaseGeneratedOption.Computed).IsOptional();
               this.Ignore(a => a.Qty);
               this.Property(t => t.PriceRemarks).HasColumnName("PriceRemarks");
               this.Property(t => t.QuotaDt).HasColumnName("QuotaDt");
               this.Property(t => t.ProdModel).HasColumnName("ProdModel");
               this.Property(t => t.DeliveryDays).HasColumnName("DeliveryDays");
           }
	}
}