using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.ComponentModel.DataAnnotations;
using COM.Domain;
namespace ERP.Domain
{
	 	//MES_M003_LotTx
	   public class MES_M003_LotTxMap:EntityTypeConfiguration<MES_M003_LotTx>
	{
           public MES_M003_LotTxMap()
           {
               this.ToTable("MES_M003_LotTx");
               this.HasKey(t => t.Id);
               this.Property(t => t.Id).HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);
               this.Property(t => t.Id).HasColumnName("Id");
               this.Property(t => t.CompCode).HasColumnName("CompCode");
               this.Property(t => t.LotNo).HasColumnName("LotNo");
               this.Property(t => t.ProcessCode).HasColumnName("ProcessCode");
               this.Property(t => t.TxDt).HasColumnName("TxDt");
               this.Property(t => t.ShiftCode).HasColumnName("ShiftCode");
               this.Property(t => t.MacCode).HasColumnName("MacCode");
               this.Property(t => t.Operator).HasColumnName("Operator");
               this.Property(t => t.InQty).HasColumnName("InQty");
               this.Property(t => t.OutQty).HasColumnName("OutQty");
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