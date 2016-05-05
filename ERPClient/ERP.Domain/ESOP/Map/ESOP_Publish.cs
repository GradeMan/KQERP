using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;

namespace ERP.Domain
{
    public class ESOP_PublishMap : EntityTypeConfiguration<ESOP_Publish>
    {
        public ESOP_PublishMap()
        {
            this.ToTable("ESOP_Publish");
            this.HasKey(t => t.Id);
            this.Property(t => t.Id).HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);
            this.Property(t => t.Id).HasColumnName("Id");
            this.Property(t => t.CompCode).HasColumnName("CompCode");
            this.Property(t => t.PartNo).HasColumnName("PartNo");
            this.Property(t => t.DevId).HasColumnName("DevId");
            this.Property(t => t.DocId).HasColumnName("DocId");
            this.Property(t => t.DocIndexId).HasColumnName("DocIndexId");
            this.Property(t => t.EffectiveDt).HasColumnName("EffectiveDt");
            this.Property(t => t.ExpireDt).HasColumnName("ExpireDt");
            this.Property(t => t.State).HasColumnName("State");
            this.Property(t => t.ModifyDt).HasColumnName("ModifyDt");
            this.Property(t => t.ModifyUser).HasColumnName("ModifyUser");
            this.Property(t => t.CreateDt).HasColumnName("CreateDt");
            this.Property(t => t.CreateUser).HasColumnName("CreateUser");
            this.Property(t => t.Version).HasColumnName("Version").IsRowVersion().HasDatabaseGeneratedOption(DatabaseGeneratedOption.Computed).IsOptional();
        }
    }
}
