using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.ComponentModel.DataAnnotations;
using COM.Domain;
namespace ERP.Domain
{
	 	//MES_M501_JobTxDetail
	   public class MES_M501_JobTxDetailMap:EntityTypeConfiguration<MES_M501_JobTxDetail>
	{
           public MES_M501_JobTxDetailMap()
           {
               this.ToTable("MES_M501_JobTxDetail");
               this.HasKey(t => t.Id);
               this.Property(t => t.Id).HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);
               this.Property(t => t.Id).HasColumnName("Id");
               this.Property(t => t.CompCode).HasColumnName("CompCode");
               this.Property(t => t.JobNo).HasColumnName("JobNo");
               this.Property(t => t.ProcessCode).HasColumnName("ProcessCode");
               this.Property(t => t.InDt).HasColumnName("InDt");
               this.Property(t => t.InSpool).HasColumnName("InSpool");
               this.Property(t => t.OutDt).HasColumnName("OutDt");
               this.Property(t => t.MacCode).HasColumnName("MacCode");
               this.Property(t => t.Dia).HasColumnName("Dia");
               this.Property(t => t.NetWeight).HasColumnName("NetWeight");
               this.Property(t => t.Length).HasColumnName("Length");
               this.Property(t => t.OutSpool).HasColumnName("OutSpool");
               this.Property(t => t.Operator).HasColumnName("Operator");
               this.Property(t => t.QCOperator).HasColumnName("QCOperator");
               this.Property(t => t.ActDia).HasColumnName("ActDia");
               this.Property(t => t.Quanlity).HasColumnName("Quanlity");
               this.Property(t => t.ExtendRate).HasColumnName("ExtendRate");
               this.Property(t => t.Fracture).HasColumnName("Fracture");
               this.Property(t => t.Temp).HasColumnName("Temp");
               this.Property(t => t.Speed).HasColumnName("Speed");
               this.Property(t => t.OPPram).HasColumnName("OPPram");
               this.Property(t => t.CaseNo).HasColumnName("CaseNo");
               this.Property(t => t.SeqNo).HasColumnName("SeqNo");
               this.Property(t => t.SpoolCnt).HasColumnName("SpoolCnt");
               this.Property(t => t.OKSpoolCnt).HasColumnName("OKSpoolCnt");
               this.Property(t => t.PackSpec).HasColumnName("PackSpec");
               this.Property(t => t.SpoolColor).HasColumnName("SpoolColor");
               this.Property(t => t.PackReq).HasColumnName("PackReq");
               this.Property(t => t.PackSpoolCnt).HasColumnName("PackSpoolCnt");
               this.Property(t => t.Remarks).HasColumnName("Remarks");

           }
	}
}