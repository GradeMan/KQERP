using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.ComponentModel.DataAnnotations;
using COM.Domain;
namespace ERP.Domain
{
	 	//MES_M003_LotTx_NG_Clone
	   public class MES_M003_LotTx_NG_CloneMap:EntityTypeConfiguration<MES_M003_LotTx_NG_Clone>
	{
           public MES_M003_LotTx_NG_CloneMap()
           {
               this.ToTable("MES_M003_LotTx_NG_Clone");
               this.HasKey(t => t.Id);
               this.Property(t => t.Id).HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);
               this.Property(t => t.Id).HasColumnName("Id");
               this.Property(t => t.CompCode).HasColumnName("CompCode");
               this.Property(t => t.ProcessCode).HasColumnName("ProcessCode");
               this.Property(t => t.CriteriaCode).HasColumnName("CriteriaCode");
               this.Property(t => t.Remarks).HasColumnName("Remarks");
               this.Property(t => t.ModifyDt).HasColumnName("ModifyDt");
               this.Property(t => t.ModifyUser).HasColumnName("ModifyUser");
               this.Property(t => t.CreateDt).HasColumnName("CreateDt");
               this.Property(t => t.CreateUser).HasColumnName("CreateUser");
               this.Property(t => t.SeqNo).HasColumnName("SeqNo");
               this.Property(t => t.State).HasColumnName("State");
               this.Property(t => t.Version).HasColumnName("Version").IsRowVersion().HasDatabaseGeneratedOption(DatabaseGeneratedOption.Computed).IsOptional();
           }
	}
}