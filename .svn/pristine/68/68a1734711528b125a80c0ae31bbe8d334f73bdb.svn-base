using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.ComponentModel.DataAnnotations;
using COM.Domain;
namespace ERP.Domain
{
	 	//SUPP_M001_PurPlan_Detail
	   public class SUPP_M001_PurPlan_DetailMap:EntityTypeConfiguration<SUPP_M001_PurPlan_Detail>
	{
           public SUPP_M001_PurPlan_DetailMap()
           {
               this.ToTable("SUPP_M001_PurPlan_Detail");
               this.HasKey(t => t.Id);
               this.Property(t => t.Id).HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);
               this.Property(t => t.Id).HasColumnName("Id");
               this.Property(t => t.CompCode).HasColumnName("CompCode");
               this.Property(t => t.PurPlNo).HasColumnName("PurPlNo");
               this.Property(t => t.MatCode).HasColumnName("MatCode");
               this.Property(t => t.PurQty).HasColumnName("PurQty");
               this.Property(t => t.Remarks).HasColumnName("Remarks");
               this.Property(t => t.ModifyDt).HasColumnName("ModifyDt");
               this.Property(t => t.ModifyUser).HasColumnName("ModifyUser");
               this.Property(t => t.CreateDt).HasColumnName("CreateDt");
               this.Property(t => t.CreateUser).HasColumnName("CreateUser");
               this.Property(t => t.Version).HasColumnName("Version").IsRowVersion().HasDatabaseGeneratedOption(DatabaseGeneratedOption.Computed).IsOptional();
           }
	}
}