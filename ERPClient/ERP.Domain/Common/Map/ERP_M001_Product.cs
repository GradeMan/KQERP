using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.ComponentModel.DataAnnotations;
using COM.Domain;
namespace ERP.Domain
{
	 	//ERP_M001_Product
	   public class ERP_M001_ProductMap:EntityTypeConfiguration<ERP_M001_Product>
	{
           public ERP_M001_ProductMap()
           {
               this.ToTable("ERP_M001_Product");
               this.HasKey(t => t.Id);
               this.Property(t => t.Id).HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);
               this.Property(t => t.Id).HasColumnName("Id");
               this.Property(t => t.CompCode).HasColumnName("CompCode");
               this.Property(t => t.PartNo).HasColumnName("PartNo");
               this.Property(t => t.Category).HasColumnName("Category");
               this.Property(t => t.PartName).HasColumnName("PartName");
               this.Property(t => t.PartType).HasColumnName("PartType");
               this.Property(t => t.PartSpec).HasColumnName("PartSpec");
               this.Property(t => t.PartDescription).HasColumnName("PartDescription");
               this.Property(t => t.DrawingNo).HasColumnName("DrawingNo");
               this.Property(t => t.DrawingNoRev).HasColumnName("DrawingNoRev");
               this.Property(t => t.ProcessFlow).HasColumnName("ProcessFlow");
               this.Property(t => t.EffectiveDt).HasColumnName("EffectiveDt");
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