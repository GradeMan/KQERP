using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.ComponentModel.DataAnnotations;
using COM.Domain;
namespace ERP.Domain
{
	 	//ERP_M001_Product_SemiProduct
	   public class ERP_M001_Product_SemiProductMap:EntityTypeConfiguration<ERP_M001_Product_SemiProduct>
	{
           public ERP_M001_Product_SemiProductMap()
           {
               this.ToTable("ERP_M001_Product_SemiProduct");
               this.HasKey(t => t.Id);
               this.Property(t => t.Id).HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);
               this.Property(t => t.Id).HasColumnName("Id");
               this.Property(t => t.CompCode).HasColumnName("CompCode");
               this.Property(t => t.PartNo).HasColumnName("PartNo");
               this.Property(t => t.SemiPartNo).HasColumnName("SemiPartNo");
               this.Property(t => t.SemiPartName).HasColumnName("SemiPartName");
               this.Property(t => t.SemiPartSpec).HasColumnName("SemiPartSpec");
               this.Property(t => t.Remarks).HasColumnName("Remarks");
               this.Property(t => t.ModifyDt).HasColumnName("ModifyDt");
               this.Property(t => t.ModifyUser).HasColumnName("ModifyUser");
               this.Property(t => t.CreateDt).HasColumnName("CreateDt");
               this.Property(t => t.CreateUser).HasColumnName("CreateUser");
               this.Property(t => t.Version).HasColumnName("Version").IsRowVersion().HasDatabaseGeneratedOption(DatabaseGeneratedOption.Computed).IsOptional();
           }
	}
}