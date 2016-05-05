using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.ComponentModel.DataAnnotations;
using COM.Domain;
namespace ERP.Domain
{
	 	//WMS_C101_WareHouse
	   public class WMS_C101_WareHouseMap:EntityTypeConfiguration<WMS_C101_WareHouse>
	{
           public WMS_C101_WareHouseMap()
           {
               this.ToTable("WMS_C101_WareHouse");
               this.HasKey(t => t.Id);
               this.Property(t => t.Id).HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);
               this.Property(t => t.Id).HasColumnName("Id");
               this.Property(t => t.CompCode).HasColumnName("CompCode");
               this.Property(t => t.WHCode).HasColumnName("WHCode");
               this.Property(t => t.WHName).HasColumnName("WHName");
               this.Property(t => t.SeqNo).HasColumnName("SeqNo");
               this.Property(t => t.Remarks).HasColumnName("Remarks");
               this.Property(t => t.ModifyDt).HasColumnName("ModifyDt");
               this.Property(t => t.ModifyUser).HasColumnName("ModifyUser");
               this.Property(t => t.CreateDt).HasColumnName("CreateDt");
               this.Property(t => t.CreateUser).HasColumnName("Createuser");
               this.Property(t => t.Version).HasColumnName("Version").IsRowVersion().HasDatabaseGeneratedOption(DatabaseGeneratedOption.Computed).IsOptional();
           }
	}
}