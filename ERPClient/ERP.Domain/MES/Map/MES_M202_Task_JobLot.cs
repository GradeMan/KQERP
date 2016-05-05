using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.ComponentModel.DataAnnotations;
using COM.Domain;
namespace ERP.Domain
{
	 	//MES_M202_Task_JobLot
	   public class MES_M202_Task_JobLotMap:EntityTypeConfiguration<MES_M202_Task_JobLot>
	{
           public MES_M202_Task_JobLotMap()
           {
               this.ToTable("MES_M202_Task_JobLot");
               this.HasKey(t => t.Id);
               this.Property(t => t.Id).HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);
               this.Property(t => t.Id).HasColumnName("Id");
               this.Property(t => t.CompCode).HasColumnName("CompCode");
               this.Property(t => t.JobNo).HasColumnName("JobNo");
               this.Property(t => t.JobLotNo).HasColumnName("JobLotNo");
               this.Property(t => t.LotQty).HasColumnName("LotQty");
               this.Property(t => t.CurrentProcess).HasColumnName("CurrentProcess");
               this.Property(t => t.ProcessQty).HasColumnName("ProcessQty");
           }
	}
}