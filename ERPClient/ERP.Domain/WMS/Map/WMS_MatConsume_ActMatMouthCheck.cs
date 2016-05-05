using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.ComponentModel.DataAnnotations;
using COM.Domain;
namespace ERP.Domain
{
	 	//WMS_MatConsume_ActMatMouthCheck
	   public class WMS_MatConsume_ActMatMouthCheckMap:EntityTypeConfiguration<WMS_MatConsume_ActMatMouthCheck>
	{
           public WMS_MatConsume_ActMatMouthCheckMap()
           {
               this.ToTable("WMS_MatConsume_ActMatMouthCheck");
               this.HasKey(t => t.Id);
               this.Property(t => t.Id).HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);
               this.Property(t => t.Id).HasColumnName("Id");
               this.Property(t => t.MatSpecCode).HasColumnName("MatSpecCode");
               this.Property(t => t.MatSpec).HasColumnName("MatSpec");
               this.Property(t => t.SuppCode).HasColumnName("SuppCode");
               this.Property(t => t.TxMouth).HasColumnName("TxMouth");
               this.Property(t => t.CheckQty).HasColumnName("CheckQty");
               this.Property(t => t.CreateDt).HasColumnName("CreateDt");
               this.Property(t => t.CreateUser).HasColumnName("CreateUser");
           }
	}
}