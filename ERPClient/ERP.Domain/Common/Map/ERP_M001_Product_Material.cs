using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.ComponentModel.DataAnnotations;
using COM.Domain;
namespace ERP.Domain
{
	 	//ERP_M001_Product_Material
	   public class ERP_M001_Product_MaterialMap:EntityTypeConfiguration<ERP_M001_Product_Material>
	{
           public ERP_M001_Product_MaterialMap()
           {
               this.ToTable("ERP_M001_Product_Material");
               this.HasKey(t => t.Id);
               this.Property(t => t.Id).HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);
               this.Property(t => t.Id).HasColumnName("Id");
               this.Property(t => t.CompCode).HasColumnName("CompCode");
               this.Property(t => t.ProductCode).HasColumnName("ProductCode");
               this.Property(t => t.ProcessCode).HasColumnName("ProcessCode");
               this.Property(t => t.MatCode).HasColumnName("MatCode");
               this.Property(t => t.BaseQty).HasColumnName("BaseQty");
               this.Property(t => t.Unit).HasColumnName("Unit");
               this.Property(t => t.UnitConsume).HasColumnName("UnitConsume");
               this.Property(t => t.UnitConsume1).HasColumnName("UnitConsume1");
               this.Property(t => t.UnitConsume2).HasColumnName("UnitConsume2");
               this.Property(t => t.NGFactor).HasColumnName("NGFactor");
               this.Property(t => t.EffectiveDt).HasColumnName("EffectiveDt");
               this.Property(t => t.IsActive).HasColumnName("IsActive");
               this.Property(t => t.Remarks).HasColumnName("Remarks");
               this.Property(t => t.ModifyDt).HasColumnName("ModifyDt");
               this.Property(t => t.ModifyUser).HasColumnName("ModifyUser");
               this.Property(t => t.CreateDt).HasColumnName("CreateDt");
               this.Property(t => t.CreateUser).HasColumnName("CreateUser");
               this.Property(t => t.Version).HasColumnName("Version").IsRowVersion().HasDatabaseGeneratedOption(DatabaseGeneratedOption.Computed).IsOptional();
           }
	}
}