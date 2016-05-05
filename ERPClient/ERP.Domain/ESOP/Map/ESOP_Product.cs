using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.Entity.ModelConfiguration;
using System.ComponentModel.DataAnnotations;

namespace ERP.Domain
{
    public class ESOP_ProductMap : EntityTypeConfiguration<ESOP_Product>
    {
        public ESOP_ProductMap()
        {
            this.ToTable("ESOP_Product");
            this.HasKey(t => t.Id);
            this.Property(t => t.Id).HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);
            this.Property(t => t.Id).HasColumnName("Id");
            this.Property(t => t.PartNo).HasColumnName("PartNo");
            this.Property(t => t.ParName).HasColumnName("ParName");
            this.Property(t => t.Remarks).HasColumnName("Remarks");
            this.Property(t => t.ModifyDt).HasColumnName("ModifyDt");
            this.Property(t => t.ModifyUser).HasColumnName("ModifyUser");
            this.Property(t => t.CreateDt).HasColumnName("CreateDt");
            this.Property(t => t.CreateUser).HasColumnName("CreateUser");
            this.Property(t => t.Version).HasColumnName("Version").IsRowVersion().HasDatabaseGeneratedOption(DatabaseGeneratedOption.Computed).IsOptional();
        }
    }
}
