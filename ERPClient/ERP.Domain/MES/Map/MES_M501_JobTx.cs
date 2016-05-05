using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.ComponentModel.DataAnnotations;
using COM.Domain;
namespace ERP.Domain
{
	 	//MES_M501_JobTx
	   public class MES_M501_JobTxMap:EntityTypeConfiguration<MES_M501_JobTx>
	{
           public MES_M501_JobTxMap()
           {
               this.ToTable("MES_M501_JobTx");
               this.HasKey(t => t.Id);
               this.Property(t => t.Id).HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);
               this.Property(t => t.Id).HasColumnName("Id");
               this.Property(t => t.CompCode).HasColumnName("CompCode");
               this.Property(t => t.PLNo).HasColumnName("PLNo");
               this.Property(t => t.JobNo).HasColumnName("JobNo");
               this.Property(t => t.JobType).HasColumnName("JobType");
               this.Property(t => t.ProcessCode).HasColumnName("ProcessCode");
               this.Property(t => t.CustCode).HasColumnName("CustCode");
               this.Property(t => t.TaskNo).HasColumnName("TaskNo");
               this.Property(t => t.SONo).HasColumnName("SONo");
               this.Property(t => t.SOQty).HasColumnName("SOQty");
               this.Property(t => t.PartNo).HasColumnName("PartNo");
               this.Property(t => t.PartType).HasColumnName("PartType");
               this.Property(t => t.PartSpec).HasColumnName("PartSpec");
               this.Property(t => t.PFCode).HasColumnName("PFCode");
               this.Property(t => t.ProdDt).HasColumnName("ProdDt");
               this.Property(t => t.OutDt).HasColumnName("OutDt");
               this.Property(t => t.MacCode).HasColumnName("MacCode");
               this.Property(t => t.ModelCode).HasColumnName("ModelCode");
               this.Property(t => t.OutSpeed).HasColumnName("OutSpeed");
               this.Property(t => t.MatLotNo).HasColumnName("MatLotNo");
               this.Property(t => t.MatSpoolNo).HasColumnName("MatSpoolNo");
               this.Property(t => t.Weight).HasColumnName("Weight");
               this.Property(t => t.InLotNo).HasColumnName("InLotNo");
               this.Property(t => t.InPartNo).HasColumnName("InPartNo");
               this.Property(t => t.InPartSpec).HasColumnName("InPartSpec");
               this.Property(t => t.InLength).HasColumnName("InLength");
               this.Property(t => t.InWeight).HasColumnName("InWeight");
               this.Property(t => t.PlatRate).HasColumnName("PlatRate");
               this.Property(t => t.Speed).HasColumnName("Speed");
               this.Property(t => t.Temp).HasColumnName("Temp");
               this.Property(t => t.ModifyDt).HasColumnName("ModifyDt");
               this.Property(t => t.ModifyUser).HasColumnName("ModifyUser");
               this.Property(t => t.CreateDt).HasColumnName("CreateDt");
               this.Property(t => t.CreateUser).HasColumnName("CreateUser");
           }
	}
}