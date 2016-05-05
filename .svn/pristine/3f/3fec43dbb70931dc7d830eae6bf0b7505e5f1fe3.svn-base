using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.ComponentModel.DataAnnotations;
using COM.Domain;
namespace ERP.Domain
{
	 	//ERP_C003_Supplier
	   public class ERP_C003_SupplierMap:EntityTypeConfiguration<ERP_C003_Supplier>
	{
           public ERP_C003_SupplierMap()
           {
               this.ToTable("ERP_C003_Supplier");
               this.HasKey(t => t.Id);
               this.Property(t => t.Id).HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);
               this.Property(t => t.Id).HasColumnName("Id");
               this.Property(t => t.CompCode).HasColumnName("CompCode");
               this.Property(t => t.SuppCode).HasColumnName("SuppCode");
               this.Property(t => t.SuppName).HasColumnName("SuppName");
               this.Property(t => t.Alias).HasColumnName("Alias");
               this.Property(t => t.Address).HasColumnName("Address");
               this.Property(t => t.Phone).HasColumnName("Phone");
               this.Property(t => t.Fax).HasColumnName("Fax");
               this.Property(t => t.Contact).HasColumnName("Contact");
               this.Property(t => t.EMail).HasColumnName("EMail");
               this.Property(t => t.Level).HasColumnName("Level");
               this.Property(t => t.Source).HasColumnName("Source");
               this.Property(t => t.DeliveryTerm).HasColumnName("DeliveryTerm");
               this.Property(t => t.PayTerm).HasColumnName("PayTerm");
               this.Property(t => t.StartDt).HasColumnName("StartDt");
               this.Property(t => t.Status).HasColumnName("Status");
               this.Property(t => t.Remarks).HasColumnName("Remarks");
               this.Property(t => t.ModifyDt).HasColumnName("ModifyDt");
               this.Property(t => t.ModifyUser).HasColumnName("ModifyUser");
               this.Property(t => t.CreateDt).HasColumnName("CreateDt");
               this.Property(t => t.CreateUser).HasColumnName("CreateUser");
               this.Property(t => t.Version).HasColumnName("Version").IsRowVersion().HasDatabaseGeneratedOption(DatabaseGeneratedOption.Computed).IsOptional();
               this.Property(t => t.IndustryType).HasColumnName("IndustryType");
               this.Property(t => t.IsQualified).HasColumnName("IsQualified");
               this.Property(t => t.QualifyDt).HasColumnName("QualifyDt");
           }
	}
}