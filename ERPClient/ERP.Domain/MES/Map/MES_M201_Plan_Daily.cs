using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.ComponentModel.DataAnnotations;
using COM.Domain;
namespace ERP.Domain
{
	 	//MES_M201_Plan_Daily
	   public class MES_M201_Plan_DailyMap:EntityTypeConfiguration<MES_M201_Plan_Daily>
	{
	       public MES_M201_Plan_DailyMap()
	       {
	           this.ToTable("MES_M201_Plan_Daily");
	           this.HasKey(t => t.Id);
	           this.Property(t => t.Id).HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);
	           this.Property(t => t.Id).HasColumnName("Id");
	           this.Property(t => t.CompCode).HasColumnName("CompCode");
	           this.Property(t => t.PlanDetailId).HasColumnName("PlanDetailId");
	           this.Property(t => t.TxDt).HasColumnName("TxDt");
	           this.Property(t => t.Qty).HasColumnName("Qty");
	           this.Property(t => t.PLNo).HasColumnName("PLNo");
	           this.Property(t => t.Remarks).HasColumnName("Remarks");
	       }
	}
}