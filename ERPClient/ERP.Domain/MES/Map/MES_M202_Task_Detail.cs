using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.ComponentModel.DataAnnotations;
using COM.Domain;
namespace ERP.Domain
{
	 	//MES_M202_Task_Detail
	   public class MES_M202_Task_DetailMap:EntityTypeConfiguration<MES_M202_Task_Detail>
	{
		public MES_M202_Task_DetailMap ()
		{
			this.ToTable("MES_M202_Task_Detail");
            this.HasKey(t => t.Id);
            this.Property(t => t.Id).HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);
      		this.Property(t => t.Id).HasColumnName("Id");
			this.Property(t => t.CompCode).HasColumnName("CompCode");
			this.Property(t => t.TaskNo).HasColumnName("TaskNo");
			this.Property(t => t.PLNo).HasColumnName("PLNo");
            this.Property(t => t.SONo).HasColumnName("SONo");
			this.Property(t => t.JobNo).HasColumnName("JobNo");
			this.Property(t => t.JobType).HasColumnName("JobType");
			this.Property(t => t.SeqNo).HasColumnName("SeqNo");
			this.Property(t => t.CustCode).HasColumnName("CustCode");
			this.Property(t => t.PartNo).HasColumnName("PartNo");
			this.Property(t => t.MacCode).HasColumnName("MacCode");
            this.Property(t => t.ShiftCode).HasColumnName("ShiftCode");
			this.Property(t => t.JobQty).HasColumnName("JobQty");
			this.Property(t => t.FQty).HasColumnName("FQty");
			this.Property(t => t.Remarks).HasColumnName("Remarks");
			this.Property(t => t.ModifyDt).HasColumnName("ModifyDt");
			this.Property(t => t.ModifyUser).HasColumnName("ModifyUser");
			this.Property(t => t.CreateDt).HasColumnName("CreateDt");
			this.Property(t => t.CreateUser).HasColumnName("CreateUser");
            this.Property(t => t.PlanDetailId).HasColumnName("PlanDetailId");
            this.Property(t => t.ProcessFlow).HasColumnName("ProcessFlow");
            this.Ignore(t => t.PlanFQty);
            this.Ignore(t => t.PlanSumQty);
            this.Ignore(t => t.MacName);
            this.Ignore(t => t.ShiftName);
            //this.Ignore(t => t.TaskDt);
            this.Ignore(t => t.CustName);
            this.Ignore(t => t.PartSpec);
            this.Ignore(t => t.PartType);
            //this.Ignore(t => t.ProcessFlow);
            this.Property(t => t.SOQty).HasColumnName("SOQty");
            this.Property(t => t.SOLotNo).HasColumnName("SOLotNo");
            this.Property(t => t.Status).HasColumnName("Status");
            this.Property(t => t.TLevel).HasColumnName("TLevel");
            this.Property(t => t.LotCount).HasColumnName("LotCount");
            this.Property(t => t.ShipQty).HasColumnName("ShipQty");
            this.Property(t => t.PartName).HasColumnName("PartName");
            this.Property(t => t.TaskDt).HasColumnName("TaskDt");

		}
	}
}