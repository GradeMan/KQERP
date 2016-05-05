using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.ComponentModel.DataAnnotations;
using COM.Domain;
namespace ERP.Domain
{
	 	//MES_M202_Task
	   public class MES_M202_TaskMap:EntityTypeConfiguration<MES_M202_Task>
	{
		public MES_M202_TaskMap ()
		{
			this.ToTable("MES_M202_Task");
            this.HasKey(t => t.Id);
            this.Property(t => t.Id).HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);
      		this.Property(t => t.Id).HasColumnName("Id");
			this.Property(t => t.CompCode).HasColumnName("CompCode");
			this.Property(t => t.TaskNo).HasColumnName("TaskNo");
			this.Property(t => t.TaskDt).HasColumnName("TaskDt");
			this.Property(t => t.Remarks).HasColumnName("Remarks");
            this.Property(t => t.Status).HasColumnName("Status");
			this.Property(t => t.ModifyDt).HasColumnName("ModifyDt");
			this.Property(t => t.ModifyUser).HasColumnName("ModifyUser");
			this.Property(t => t.CreateDt).HasColumnName("CreateDt");
			this.Property(t => t.CreateUser).HasColumnName("CreateUser");
		}
	}
}