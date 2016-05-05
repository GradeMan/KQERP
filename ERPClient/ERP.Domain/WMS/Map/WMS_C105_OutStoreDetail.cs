using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.ComponentModel.DataAnnotations;
using COM.Domain;
namespace ERP.Domain
{
	 	//WMS_C105_OutStoreDetail
    public class WMS_C105_OutStoreDetailMap : EntityTypeConfiguration<WMS_C105_OutStoreDetail>
    {
        public WMS_C105_OutStoreDetailMap()
        {
            this.ToTable("WMS_M103_OutStoreDetail");
            this.HasKey(t => t.Id);
            this.Property(t => t.Id).HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);
            this.Property(t => t.Id).HasColumnName("Id");
            this.Property(t => t.CompCode).HasColumnName("CompCode");
            this.Property(t => t.OutStoreId).HasColumnName("OutStoreId");
            this.Property(t => t.OutSotreNo).HasColumnName("OutSotreNo");
            this.Property(t => t.ARCode).HasColumnName("ARCode");
            this.Property(t => t.PartSpec).HasColumnName("PartSpec");
            this.Property(t => t.MatClass2).HasColumnName("MatClass2");
            this.Property(t => t.Amount).HasColumnName("Amount");
            this.Property(t => t.SuppLot).HasColumnName("SuppLot");
            this.Property(t => t.SuppCode).HasColumnName("SuppCode");
            this.Property(t => t.StockId).HasColumnName("StockId");
            this.Property(t => t.CreateUser).HasColumnName("CreateUser");
            this.Property(t => t.CreateDt).HasColumnName("CreateDt");
            this.Property(t => t.ModifyDt).HasColumnName("ModifyDt");
            this.Property(t => t.ModifyUser).HasColumnName("ModifyUser");
            this.Property(t => t.Version).HasColumnName("Version").IsRowVersion().HasDatabaseGeneratedOption(DatabaseGeneratedOption.Computed).IsOptional();
        }
    }
}