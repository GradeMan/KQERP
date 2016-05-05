using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.ComponentModel.DataAnnotations;
using COM.Domain;
namespace ERP.Domain
{
	 	//WMS_C102_Area
	   public class WMS_C102_AreaMap:EntityTypeConfiguration<WMS_C102_Area>
	{
           public WMS_C102_AreaMap()
           {
               this.ToTable("WMS_C102_Area");
               this.HasKey(t => t.Id);
               this.Property(t => t.Id).HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);
               this.Property(t => t.Id).HasColumnName("Id");
               this.Property(t => t.StockArea).HasColumnName("StockArea");
               this.Property(t => t.ARCode).HasColumnName("ARCode");
               this.Property(t => t.ARName).HasColumnName("ARName");
               this.Property(t => t.SeqNo).HasColumnName("SeqNo");
               this.Property(t => t.Remarks).HasColumnName("Remarks");
               this.Property(t => t.ModifyUser).HasColumnName("ModifyUser");
               this.Property(t => t.ModifyDt).HasColumnName("ModifyDt");
               this.Property(t => t.CreateUser).HasColumnName("CreateUser");
               this.Property(t => t.CreateDt).HasColumnName("CreateDt");
               this.Property(t => t.Version).HasColumnName("Version").IsRowVersion().HasDatabaseGeneratedOption(DatabaseGeneratedOption.Computed).IsOptional();
               this.Property(t => t.State).HasColumnName("State");
           }
	}
}