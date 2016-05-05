using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.ComponentModel.DataAnnotations;
using COM.Domain;
namespace ERP.Domain
{
	 	//MES_M501_JobTx_NG
	   public class MES_M501_JobTx_NGMap:EntityTypeConfiguration<MES_M501_JobTx_NG>
	{
           public MES_M501_JobTx_NGMap()
           {
               this.ToTable("MES_M501_JobTx_NG");
               this.HasKey(t => t.Id);
               this.Property(t => t.Id).HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);
               this.Property(t => t.Id).HasColumnName("Id");
               this.Property(t => t.CompCode).HasColumnName("CompCode");
               this.Property(t => t.ProcessCode).HasColumnName("ProcessCode");
               this.Property(t => t.CurrProcessCode).HasColumnName("CurrProcessCode");
               this.Property(t => t.NGCode).HasColumnName("NGCode");
               this.Property(t => t.NGQty).HasColumnName("NGQty");
               this.Property(t => t.Remarks).HasColumnName("Remarks");
               this.Property(t => t.ModifyDt).HasColumnName("ModifyDt");
               this.Property(t => t.ModifyUser).HasColumnName("ModifyUser");
               this.Property(t => t.CreateDt).HasColumnName("CreateDt");
               this.Property(t => t.CreateUser).HasColumnName("CreateUser");
               this.Property(t => t.Version).HasColumnName("Version").IsRowVersion().HasDatabaseGeneratedOption(DatabaseGeneratedOption.Computed).IsOptional();
               this.Property(t => t.JobNo).HasColumnName("JobNo");
           }
	}
}