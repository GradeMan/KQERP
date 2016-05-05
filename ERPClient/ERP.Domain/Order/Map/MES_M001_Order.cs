using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.ComponentModel.DataAnnotations;
using COM.Domain;
namespace ERP.Domain
{
	 	//MES_M001_Order
	   public class MES_M001_OrderMap:EntityTypeConfiguration<MES_M001_Order>
	{
           public MES_M001_OrderMap()
           {
               this.ToTable("MES_M001_Order");
               this.HasKey(t => t.Id);
               this.Property(t => t.Id).HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);
               this.Property(t => t.Id).HasColumnName("Id");
               this.Property(t => t.CompCode).HasColumnName("CompCode");
               this.Property(t => t.OrdNo).HasColumnName("OrdNo");
               this.Property(t => t.CustCode).HasColumnName("CustCode");
               this.Property(t => t.OrdDt).HasColumnName("OrdDt");
               this.Property(t => t.Status).HasColumnName("Status");
               this.Property(t => t.SalesMan).HasColumnName("SalesMan");
               this.Property(t => t.Remarks).HasColumnName("Remarks");
               this.Property(t => t.ModifyDt).HasColumnName("ModifyDt");
               this.Property(t => t.ModifyUser).HasColumnName("ModifyUser");
               this.Property(t => t.CreateDt).HasColumnName("CreateDt");
               this.Property(t => t.CreateUser).HasColumnName("CreateUser");
               this.Property(t => t.Version).HasColumnName("Version").IsRowVersion().HasDatabaseGeneratedOption(DatabaseGeneratedOption.Computed).IsOptional();
           }
	}
}