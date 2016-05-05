using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.ComponentModel.DataAnnotations;
using COM.Domain;
namespace ERP.Domain
{
	 	//MES_M501_JobTxProdInfo
	   public class MES_M501_JobTxProdInfoMap:EntityTypeConfiguration<MES_M501_JobTxProdInfo>
	{
           public MES_M501_JobTxProdInfoMap()
           {
               this.ToTable("MES_M501_JobTxProdInfo");
               this.HasKey(t => t.Id);
               this.Property(t => t.Id).HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);
               this.Property(t => t.Id).HasColumnName("Id");
               this.Property(t => t.CompCode).HasColumnName("CompCode");
               this.Property(t => t.JobNo).HasColumnName("JobNo");
               this.Property(t => t.PFCode).HasColumnName("PFCode");
               this.Property(t => t.ProcessCode).HasColumnName("ProcessCode");
               this.Property(t => t.TechCode).HasColumnName("TechCode");
               this.Property(t => t.TechType).HasColumnName("TechType");
               this.Property(t => t.TechSeqNo).HasColumnName("TechSeqNo");
               this.Property(t => t.TechContent).HasColumnName("TechContent");
               this.Property(t => t.Remarks).HasColumnName("Remarks");
               this.Property(t => t.TechReallyContent).HasColumnName("TechReallyContent");
           }
	}
}