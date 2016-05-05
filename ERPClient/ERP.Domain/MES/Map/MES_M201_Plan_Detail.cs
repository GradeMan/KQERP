using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.ComponentModel.DataAnnotations;
using COM.Domain;
namespace ERP.Domain
{
	 	//MES_M201_Plan_Detail
	   public class MES_M201_Plan_DetailMap:EntityTypeConfiguration<MES_M201_Plan_Detail>
	{
           public MES_M201_Plan_DetailMap()
           {
               this.ToTable("MES_M201_Plan_Detail");
               this.HasKey(t => t.Id);
               this.Property(t => t.Id).HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);
               this.Property(t => t.Id).HasColumnName("Id");
               this.Property(t => t.CompCode).HasColumnName("CompCode");
               this.Property(t => t.PlanId).HasColumnName("PlanId");
               this.Property(t => t.PLNo).HasColumnName("PLNo");
               this.Property(t => t.CustCode).HasColumnName("CustCode");
               this.Property(t => t.PartNo).HasColumnName("PartNo");
               this.Property(t => t.PartName).HasColumnName("PartName");
               this.Property(t => t.PartSpec).HasColumnName("PartSpec");
               this.Property(t => t.Unit).HasColumnName("Unit");
               this.Property(t => t.Qty).HasColumnName("Qty");
               this.Property(t => t.FQty).HasColumnName("FQty");
               this.Property(t => t.Remarks).HasColumnName("Remarks");
               this.Property(t => t.ModifyDt).HasColumnName("ModifyDt");
               this.Property(t => t.ModifyUser).HasColumnName("ModifyUser");
               this.Property(t => t.CreateDt).HasColumnName("CreateDt");
               this.Property(t => t.CreateUser).HasColumnName("CreateUser");
               this.Property(t => t.SOQty).HasColumnName("SOQty");
               this.Property(t => t.PLevel).HasColumnName("PLevel");
               this.Property(t => t.Status).HasColumnName("Status");
           }
	}
}