using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.ComponentModel.DataAnnotations;
using COM.Domain;
namespace ERP.Domain
{
	 	//MES_M201_Plan_Material
	   public class MES_M201_Plan_MaterialMap:EntityTypeConfiguration<MES_M201_Plan_Material>
	{
           public MES_M201_Plan_MaterialMap()
           {
               this.ToTable("MES_M201_Plan_Material");
               this.HasKey(t => t.Id);
               this.Property(t => t.Id).HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);
               this.Property(t => t.Id).HasColumnName("Id");
               this.Property(t => t.CompCode).HasColumnName("CompCode");
               this.Property(t => t.PlanDetailId).HasColumnName("PlanDetailId");
               this.Property(t => t.PLNo).HasColumnName("PLNo");
               this.Property(t => t.PartNo).HasColumnName("PartNo");
               this.Property(t => t.MatCode).HasColumnName("MatCode");
               this.Property(t => t.SuppCode).HasColumnName("SuppCode");
               this.Property(t => t.Unit).HasColumnName("Unit");
               this.Property(t => t.UnitPrice).HasColumnName("UnitPrice");
               this.Property(t => t.Qty).HasColumnName("Qty");
               this.Property(t => t.Remarks).HasColumnName("Remarks");
               this.Property(t => t.ModifyDt).HasColumnName("ModifyDt");
               this.Property(t => t.ModifyUser).HasColumnName("ModifyUser");
               this.Property(t => t.CreateDt).HasColumnName("CreateDt");
               this.Property(t => t.CreateUser).HasColumnName("CreateUser");
               this.Property(t => t.UnitConsume).HasColumnName("UnitConsume");
               this.Ignore(t => t.MatName);
               this.Ignore(t => t.MatSpec);
           }
	}
}