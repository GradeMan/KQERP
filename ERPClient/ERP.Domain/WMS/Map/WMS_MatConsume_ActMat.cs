using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.ComponentModel.DataAnnotations;
using COM.Domain;
namespace ERP.Domain
{
	 	//WMS_MatConsume_ActMat
	   public class WMS_MatConsume_ActMatMap:EntityTypeConfiguration<WMS_MatConsume_ActMat>
	{
           public WMS_MatConsume_ActMatMap()
           {
               this.ToTable("WMS_MatConsume_ActMat");
               this.HasKey(t => t.Id);
               this.Property(t => t.Id).HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);
               this.Property(t => t.Id).HasColumnName("Id");
               this.Property(t => t.StampingNo).HasColumnName("StampingNo");
               this.Property(t => t.TxDt).HasColumnName("TxDt");
               this.Property(t => t.Remarks).HasColumnName("Remarks");
               this.Property(t => t.Owner).HasColumnName("Owner");
               this.Property(t => t.CreateUser).HasColumnName("CreateUser");
               this.Property(t => t.CreatDt).HasColumnName("CreatDt");
               this.Property(t => t.ModifyUser).HasColumnName("ModifyUser");
               this.Property(t => t.ModifyDt).HasColumnName("ModifyDt");
           }
	}
}