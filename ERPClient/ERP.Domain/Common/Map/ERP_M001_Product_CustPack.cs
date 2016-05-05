using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.ComponentModel.DataAnnotations;
using COM.Domain;
namespace ERP.Domain
{
	 	//ERP_M001_Product_CustPack
	   public class ERP_M001_Product_CustPackMap:EntityTypeConfiguration<ERP_M001_Product_CustPack>
	{
           public ERP_M001_Product_CustPackMap()
           {
               this.ToTable("ERP_M001_Product_CustPack");
               this.HasKey(t => t.Id);
               this.Property(t => t.Id).HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);
               this.Property(t => t.Id).HasColumnName("Id");
               this.Property(t => t.CompCode).HasColumnName("CompCode");
               this.Property(t => t.ItemCode).HasColumnName("ItemCode");
               this.Property(t => t.CustCode).HasColumnName("CustCode");
               this.Property(t => t.CustMatNo).HasColumnName("CustMatNo");
               this.Property(t => t.CustPartName).HasColumnName("CustPartName");
               this.Property(t => t.CustPONo).HasColumnName("CustPONo");
               this.Property(t => t.CustLotNo).HasColumnName("CustLotNo");
               this.Property(t => t.CustDrawingNo).HasColumnName("CustDrawingNo");
               this.Property(t => t.MatCode).HasColumnName("MatCode");
               this.Property(t => t.MatType).HasColumnName("MatType");
               this.Property(t => t.MatSupplier).HasColumnName("MatSupplier");
               this.Property(t => t.PianZhi).HasColumnName("PianZhi");
               this.Property(t => t.BaoPian).HasColumnName("BaoPian");
               this.Property(t => t.HeBao).HasColumnName("HeBao");
               this.Property(t => t.XiangHe).HasColumnName("XiangHe");
               this.Property(t => t.PreLotNo).HasColumnName("PreLotNo");
               this.Property(t => t.PostLotNo).HasColumnName("PostLotNo");
               this.Property(t => t.Remarks).HasColumnName("Remarks");
               this.Property(t => t.ModifyDt).HasColumnName("ModifyDt");
               this.Property(t => t.ModifyUser).HasColumnName("ModifyUser");
               this.Property(t => t.CreateDt).HasColumnName("CreateDt");
               this.Property(t => t.CreateUser).HasColumnName("CreateUser");
               this.Property(t => t.Version).HasColumnName("Version").IsRowVersion();
           }
	}
}