using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using COM.Domain;
using System.Data.Entity.ModelConfiguration;
using System.ComponentModel.DataAnnotations;

namespace ERP.Domain
{
    public class ESOP_DeviceMap : EntityTypeConfiguration<ESOP_Device>
    {
        public ESOP_DeviceMap()
           {
               this.ToTable("ESOP_Device");
               this.HasKey(t => t.Id);
               this.Property(t => t.Id).HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);
               this.Property(t => t.Id).HasColumnName("Id");
               this.Property(t => t.DevName).HasColumnName("DevName");
               this.Property(t => t.Alias).HasColumnName("Alias");
               this.Property(t => t.State).HasColumnName("State");
               this.Property(t => t.Remarks).HasColumnName("Remarks");
               this.Property(t => t.ModifyDt).HasColumnName("ModifyDt");
               this.Property(t => t.ModifyUser).HasColumnName("ModifyUser");
               this.Property(t => t.CreateDt).HasColumnName("CreateDt");
               this.Property(t => t.CreateUser).HasColumnName("CreateUser");
               this.Property(t => t.Version).HasColumnName("Version").IsRowVersion().HasDatabaseGeneratedOption(DatabaseGeneratedOption.Computed).IsOptional();
           }
    }
}
