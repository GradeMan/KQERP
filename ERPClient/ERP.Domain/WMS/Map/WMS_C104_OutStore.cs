﻿using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.ComponentModel.DataAnnotations;
using COM.Domain;
namespace ERP.Domain
{
	 	//WMS_C104_OutStore
	   public class WMS_C104_OutStoreMap:EntityTypeConfiguration<WMS_C104_OutStore>
	{
           public WMS_C104_OutStoreMap()
           {
               this.ToTable("WMS_M103_OutStore");
               this.HasKey(t => t.Id);
               this.Property(t => t.Id).HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);
               this.Property(t => t.Id).HasColumnName("Id");
               this.Property(t => t.CompCode).HasColumnName("CompCode");
               this.Property(t => t.OutStoreNo).HasColumnName("OutStoreNo");
               this.Property(t => t.Unit).HasColumnName("Unit");
               this.Property(t => t.ActulAmount).HasColumnName("ActulAmount");
               this.Property(t => t.LeadDept).HasColumnName("LeadDept");
               this.Property(t => t.LeadDt).HasColumnName("LeadDt");
               this.Property(t => t.LeadUser).HasColumnName("LeadUser");
               this.Property(t => t.LeadManager).HasColumnName("LeadManager");
               this.Property(t => t.StockManager).HasColumnName("StockManager");
               this.Property(t => t.CreateUser).HasColumnName("CreateUser");
               this.Property(t => t.CreateDt).HasColumnName("CreateDt");
               this.Property(t => t.ModifyUser).HasColumnName("ModifyUser");
               this.Property(t => t.ModifyDt).HasColumnName("ModifyDt");
               this.Property(t => t.Version).HasColumnName("Version").IsRowVersion().HasDatabaseGeneratedOption(DatabaseGeneratedOption.Computed).IsOptional();
               this.Property(t => t.Status).HasColumnName("Status");
           }
	}
}