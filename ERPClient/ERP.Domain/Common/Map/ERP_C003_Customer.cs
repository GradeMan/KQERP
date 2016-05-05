using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.ComponentModel.DataAnnotations;
using COM.Domain;
namespace ERP.Domain
{
   public class ERP_C003_CustomerMap:EntityTypeConfiguration<ERP_C003_Customer>
	{
       public ERP_C003_CustomerMap()
       {
           this.ToTable("ERP_C004_Customer");
           this.HasKey(t => t.Id);
           this.Property(t => t.Id).HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);
           this.Property(t => t.Id).HasColumnName("Id");
           this.Property(t => t.CompCode).HasColumnName("CompCode");
           this.Property(t => t.CustCode).HasColumnName("CustCode");
           this.Property(t => t.CustName).HasColumnName("CustName");
           this.Property(t => t.Alias).HasColumnName("Alias");
           this.Property(t => t.Add1).HasColumnName("Add1");
           this.Property(t => t.Add2).HasColumnName("Add2");
           this.Property(t => t.Add3).HasColumnName("Add3");
           this.Property(t => t.Country).HasColumnName("Country");
           this.Property(t => t.Phone).HasColumnName("Phone");
           this.Property(t => t.Fax).HasColumnName("Fax");
           this.Property(t => t.CPerson1).HasColumnName("Person1");
           this.Property(t => t.CPerson2).HasColumnName("Person2");
           this.Property(t => t.CPerson3).HasColumnName("person3");
           this.Property(t => t.CEMail1).HasColumnName("Email1");
           this.Property(t => t.CEMail2).HasColumnName("Email2");
           this.Property(t => t.CEMail3).HasColumnName("Email3");
           this.Property(t => t.CPhone1).HasColumnName("Tel1");
           this.Property(t => t.CPhone2).HasColumnName("Tel2");
           this.Property(t => t.CPhone3).HasColumnName("Tel3");
           this.Property(t => t.CFax1).HasColumnName("Fax1");
           this.Property(t => t.CFax2).HasColumnName("Fax2");
           this.Property(t => t.CFax3).HasColumnName("Fax3");
           this.Property(t => t.DNAdd1).HasColumnName("DNAdd1");
           this.Property(t => t.DNAdd2).HasColumnName("DNAdd2");
           this.Property(t => t.DNAdd3).HasColumnName("DNAdd3");
           this.Property(t => t.Status).HasColumnName("Status");
           this.Property(t => t.ModifyDt).HasColumnName("ModifyDt");
           this.Property(t => t.ModifyUser).HasColumnName("ModifyUser");
           this.Property(t => t.CreateDt).HasColumnName("CreateDt");
           this.Property(t => t.CreateUser).HasColumnName("CreateUser");
           this.Property(t => t.Version).HasColumnName("Version").IsRowVersion();
           this.Property(t => t.Remarks).HasColumnName("Remarks");
           this.Property(t => t.CustType).HasColumnName("CustType");
       }
	}
}