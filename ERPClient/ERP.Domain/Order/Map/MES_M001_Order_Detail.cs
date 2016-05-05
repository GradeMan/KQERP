﻿using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.ComponentModel.DataAnnotations;
using COM.Domain;
namespace ERP.Domain
{
	 	//MES_M001_Order_Detail
	   public class MES_M001_Order_DetailMap:EntityTypeConfiguration<MES_M001_Order_Detail>
	{
           public MES_M001_Order_DetailMap()
           {
               this.ToTable("MES_M001_Order_Detail");
               this.HasKey(t => t.Id);
               this.Property(t => t.Id).HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);
               this.Property(t => t.Id).HasColumnName("Id");
               this.Property(t => t.CompCode).HasColumnName("CompCode");
               this.Property(t => t.OrdNo).HasColumnName("OrdNo");
               this.Property(t => t.ItemCode).HasColumnName("ItemCode");
               this.Property(t => t.Qty).HasColumnName("Qty");
               this.Property(t => t.Unit).HasColumnName("Unit");
               this.Property(t => t.DeliveryDt).HasColumnName("DeliveryDt");
               this.Property(t => t.Remarks).HasColumnName("Remarks");
               this.Property(t => t.Status).HasColumnName("Status");
               this.Property(t => t.ProdQty).HasColumnName("ProdQty");
               this.Property(t => t.StockQty).HasColumnName("StockQty");
               this.Property(t => t.ShipQty).HasColumnName("ShipQty");
               this.Property(t => t.ModifyDt).HasColumnName("ModifyDt");
               this.Property(t => t.ModifyUser).HasColumnName("ModifyUser");
               this.Property(t => t.CreateDt).HasColumnName("CreateDt");
               this.Property(t => t.CreateUser).HasColumnName("CreateUser");
               this.Property(t => t.Version).HasColumnName("Version").IsRowVersion().HasDatabaseGeneratedOption(DatabaseGeneratedOption.Computed).IsOptional();
           }
	}
}