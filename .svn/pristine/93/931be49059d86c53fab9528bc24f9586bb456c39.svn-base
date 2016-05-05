using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.ComponentModel.DataAnnotations;
using COM.Domain;
namespace ERP.Domain
{
   public class ERP_C004_SupplierMap:EntityTypeConfiguration<ERP_C004_Supplier>
	{
		public ERP_C004_SupplierMap ()
		{
			this.ToTable("ERP_C004_Supplier");
            this.HasKey(t => t.Id);
            this.Property(t => t.Id).HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);
      					this.Property(t => t.Id).HasColumnName("Id");
						this.Property(t => t.CompCode).HasColumnName("CompCode");
						this.Property(t => t.SuppCode).HasColumnName("SuppCode");
						this.Property(t => t.SuppName).HasColumnName("SuppName");
						this.Property(t => t.Alias).HasColumnName("Alias");
						this.Property(t => t.Add1).HasColumnName("Add1");
						this.Property(t => t.Add2).HasColumnName("Add2");
						this.Property(t => t.Add3).HasColumnName("Add3");
						this.Property(t => t.Country).HasColumnName("Country");
						this.Property(t => t.Phone).HasColumnName("Phone");
						this.Property(t => t.Fax).HasColumnName("Fax");
						this.Property(t => t.CPerson1).HasColumnName("CPerson1");
						this.Property(t => t.CPerson2).HasColumnName("CPerson2");
						this.Property(t => t.CPerson3).HasColumnName("CPerson3");
						this.Property(t => t.CEMail1).HasColumnName("CEMail1");
						this.Property(t => t.CEMail2).HasColumnName("CEMail2");
						this.Property(t => t.CEMail3).HasColumnName("CEMail3");
						this.Property(t => t.CPhone1).HasColumnName("CPhone1");
						this.Property(t => t.CPhone2).HasColumnName("CPhone2");
						this.Property(t => t.CPhone3).HasColumnName("CPhone3");
						this.Property(t => t.CFax1).HasColumnName("CFax1");
						this.Property(t => t.CFax2).HasColumnName("CFax2");
						this.Property(t => t.CFax3).HasColumnName("CFax3");
						this.Property(t => t.DNAdd1).HasColumnName("DNAdd1");
						this.Property(t => t.DNAdd2).HasColumnName("DNAdd2");
						this.Property(t => t.DNAdd3).HasColumnName("DNAdd3");
						this.Property(t => t.Status).HasColumnName("Status");
						this.Property(t => t.Salesman).HasColumnName("Salesman");
						this.Property(t => t.ModifyDt).HasColumnName("ModifyDt");
						this.Property(t => t.ModifyUser).HasColumnName("ModifyUser");
						this.Property(t => t.CreateDt).HasColumnName("CreateDt");
						this.Property(t => t.CreateUser).HasColumnName("CreateUser");
						this.Property(t => t.Version).HasColumnName("Version").IsRowVersion();
			   		}
	}
}