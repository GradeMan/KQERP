using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.ComponentModel.DataAnnotations;
using COM.Domain;
namespace ERP.Domain
{
	 	//ERP_M001_Material
	   public class ERP_M001_MaterialMap:EntityTypeConfiguration<ERP_M001_Material>
	{
           public ERP_M001_MaterialMap()
           {
               this.ToTable("ERP_M001_Material");
               this.HasKey(t => t.Id);
               this.Property(t => t.Id).HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);
               this.Property(t => t.Id).HasColumnName("Id");
               this.Property(t => t.CompCode).HasColumnName("CompCode");
               this.Property(t => t.MatCode).HasColumnName("MatCode");
               this.Property(t => t.MatLevel).HasColumnName("MatLevel");
               this.Property(t => t.MatClass1).HasColumnName("MatClass1");
               this.Property(t => t.MatClass2).HasColumnName("MatClass2");
               this.Property(t => t.MatClass3).HasColumnName("MatClass3");
               this.Property(t => t.MatName).HasColumnName("MatName");
               this.Property(t => t.MatSpec).HasColumnName("MatSpec");
               this.Property(t => t.Location).HasColumnName("Location");
               this.Property(t => t.Unit).HasColumnName("Unit");
               this.Property(t => t.Qty).HasColumnName("Qty");
               this.Property(t => t.SaftyQty).HasColumnName("SaftyQty");
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