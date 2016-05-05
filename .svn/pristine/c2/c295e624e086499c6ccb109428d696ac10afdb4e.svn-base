using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.ComponentModel.DataAnnotations;
using COM.Domain;
namespace ERP.Domain
{
    //ERP_C001_Code
    public class ERP_C001_CodeMap : EntityTypeConfiguration<ERP_C001_Code>
    {
        public ERP_C001_CodeMap()
        {
            this.ToTable("ERP_C001_Code");
            this.HasKey(t => t.Id);
            this.Property(t => t.Id).HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);
            this.Property(t => t.Id).HasColumnName("Id");
            this.Property(t => t.CompCode).HasColumnName("CompCode");
            this.Property(t => t.CodeID).HasColumnName("CodeID");
            this.Property(t => t.CodeIDDesc).HasColumnName("CodeIDDesc");
            this.Property(t => t.Code).HasColumnName("Code");
            this.Property(t => t.Description).HasColumnName("Description");
            this.Property(t => t.GroupCode).HasColumnName("GroupCode");
            this.Property(t => t.GroupName).HasColumnName("GroupName");
            this.Property(t => t.Status).HasColumnName("Status");
            this.Property(t => t.Remarks).HasColumnName("Remarks");
            this.Property(t => t.ModifyDt).HasColumnName("ModifyDt");
            this.Property(t => t.ModifyUser).HasColumnName("ModifyUser");
            this.Property(t => t.CreateDt).HasColumnName("CreateDt");
            this.Property(t => t.CreateUser).HasColumnName("CreateUser");
            this.Property(t => t.Version).HasColumnName("Version").IsRowVersion().HasDatabaseGeneratedOption(DatabaseGeneratedOption.Computed).IsOptional();
        }
    }
}