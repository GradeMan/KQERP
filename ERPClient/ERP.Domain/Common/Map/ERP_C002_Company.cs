using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.ComponentModel.DataAnnotations;
using COM.Domain;
namespace ERP.Domain
{
	 	//tb_C001_Company
    public class tb_C001_CompanyMap : EntityTypeConfiguration<ERP_C002_Company>
	{
        public tb_C001_CompanyMap()
        {
            this.ToTable("ERP_C002_Company");
            this.HasKey(t => t.Id);
            this.Property(t => t.Id).HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);
            this.Property(t => t.Id).HasColumnName("Id");
            this.Property(t => t.CompCode).HasColumnName("CompCode");
            this.Property(t => t.CompName).HasColumnName("CompName");
            this.Property(t => t.Alias).HasColumnName("Alias");
            this.Property(t => t.Add1).HasColumnName("Add1");
            this.Property(t => t.Add2).HasColumnName("Add2");
            this.Property(t => t.Add3).HasColumnName("Add3");
            this.Property(t => t.Tel).HasColumnName("Tel");
            this.Property(t => t.Fax).HasColumnName("Fax");
            this.Property(t => t.Email).HasColumnName("Email");
            this.Property(t => t.CreateDt).HasColumnName("CreateDt");
            this.Property(t => t.CreateUser).HasColumnName("CreateUser");
            this.Property(t => t.ModifyDt).HasColumnName("ModifyDt");
            this.Property(t => t.ModifyUser).HasColumnName("ModifyUser");
            this.Property(t => t.Version).HasColumnName("Version").IsRowVersion();
            this.Property(t => t.SysName).HasColumnName("SysName");
        }
	}
}