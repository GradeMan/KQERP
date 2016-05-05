using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.ComponentModel.DataAnnotations;
using COM.Domain;
namespace ERP.Domain
{
	 	//ERP_C003_Supplier_File
    public class ERP_C003_Supplier_FileMap : EntityTypeConfiguration<ERP_C003_Supplier_File>
    {
        public ERP_C003_Supplier_FileMap()
        {
            this.ToTable("ERP_C003_Supplier_File");
            this.HasKey(t => t.Id);
            this.Property(t => t.Id).HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);
            this.Property(t => t.Id).HasColumnName("Id");
            this.Property(t => t.CompCode).HasColumnName("CompCode");
            this.Property(t => t.SuppCode).HasColumnName("SuppCode");
            this.Property(t => t.DocNo).HasColumnName("DocNo");
            this.Property(t => t.DocName).HasColumnName("DocName");
            this.Property(t => t.DocEffDt).HasColumnName("DocEffDt");
            this.Property(t => t.DocTermDt).HasColumnName("DocTermDt");
            this.Property(t => t.Content).HasColumnName("Content");
            this.Property(t => t.Remarks).HasColumnName("Remarks");
            this.Property(t => t.ModifyDt).HasColumnName("ModifyDt");
            this.Property(t => t.ModifyUser).HasColumnName("ModifyUser");
            this.Property(t => t.CreateDt).HasColumnName("CreateDt");
            this.Property(t => t.CreateUser).HasColumnName("CreateUser");
            this.Property(t => t.Version).HasColumnName("Version").IsRowVersion().HasDatabaseGeneratedOption(DatabaseGeneratedOption.Computed).IsOptional();
        }
    }
}