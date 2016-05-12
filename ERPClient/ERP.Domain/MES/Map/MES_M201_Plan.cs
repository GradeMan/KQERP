using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.ComponentModel.DataAnnotations;
using COM.Domain;
namespace ERP.Domain
{
	 	//MES_M201_Plan
	   public class MES_M201_PlanMap:EntityTypeConfiguration<MES_M201_Plan>
	{
           public MES_M201_PlanMap()
           {
               this.ToTable("MES_M201_Plan");
               this.HasKey(t => t.Id);
               this.Property(t => t.Id).HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);
               this.Property(t => t.Id).HasColumnName("Id");
               this.Property(t => t.CompCode).HasColumnName("CompCode");
               this.Property(t => t.PLNo).HasColumnName("PLNo");
               this.Property(t => t.PLDt).HasColumnName("PLDt");
               this.Property(t => t.PLType).HasColumnName("PLType");
               this.Property(t => t.Remarks).HasColumnName("Remarks");
               this.Property(t => t.ModifyDt).HasColumnName("ModifyDt");
               this.Property(t => t.ModifyUser).HasColumnName("ModifyUser");
               this.Property(t => t.CreateDt).HasColumnName("CreateDt");
               this.Property(t => t.CreateUser).HasColumnName("CreateUser");
               this.Property(t => t.PLAuditingDt).HasColumnName("PLAuditingDt");
               this.Property(t => t.Weekly).HasColumnName("Weekly");
               this.Property(t => t.PlanCompleteDt).HasColumnName("PlanCompleteDt");
               this.Property(t => t.PlanDeliveryDt).HasColumnName("PlanDeliveryDt");
           }
	}
}