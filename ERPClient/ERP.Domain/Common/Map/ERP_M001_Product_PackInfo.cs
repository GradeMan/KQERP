using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.ComponentModel.DataAnnotations;
using COM.Domain;
namespace ERP.Domain
{
	 	//ERP_M001_Product_PackInfo
	   public class ERP_M001_Product_PackInfoMap:EntityTypeConfiguration<ERP_M001_Product_PackInfo>
	{
           public ERP_M001_Product_PackInfoMap()
           {
               this.ToTable("ERP_M001_Product_PackInfo");
               this.HasKey(t => t.Id);
               this.Property(t => t.Id).HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);
               this.Property(t => t.Id).HasColumnName("Id");
               this.Property(t => t.CompCode).HasColumnName("CompCode");
               this.Property(t => t.PartNo).HasColumnName("PartNo");
               this.Property(t => t.PartName).HasColumnName("PartName");
               this.Property(t => t.PartType).HasColumnName("PartType");
               this.Property(t => t.PartSpec).HasColumnName("PartSpec");
               this.Property(t => t.CustCode).HasColumnName("CustCode");
               this.Property(t => t.CustPartNo).HasColumnName("CustPartNo");
               this.Property(t => t.CustPartName).HasColumnName("CustPartName");
               this.Property(t => t.CustPartType).HasColumnName("CustPartType");
               this.Property(t => t.CustPartSpec).HasColumnName("CustPartSpec");
               this.Property(t => t.CustDrawingNo).HasColumnName("CustDrawingNo");
               this.Property(t => t.CustLotNo).HasColumnName("CustLotNo");
               this.Property(t => t.CustPONo).HasColumnName("CustPONo");
               this.Property(t => t.MatCode).HasColumnName("MatCode");
               this.Property(t => t.MatType).HasColumnName("MatType");
               this.Property(t => t.MatSuppCode).HasColumnName("MatSuppCode");
               this.Property(t => t.MatLotNo).HasColumnName("MatLotNo");
               this.Property(t => t.PackPianZhi).HasColumnName("PackPianZhi");
               this.Property(t => t.PackBaoPian).HasColumnName("PackBaoPian");
               this.Property(t => t.PackHeBao).HasColumnName("PackHeBao");
               this.Property(t => t.PackXiangHe).HasColumnName("PackXiangHe");
               this.Property(t => t.ExpiredPeriod).HasColumnName("ExpiredPeriod");
               this.Property(t => t.LabelType).HasColumnName("LabelType");
               this.Property(t => t.IsLabelSeq).HasColumnName("IsLabelSeq");
               this.Property(t => t.PreLotNo).HasColumnName("PreLotNo");
               this.Property(t => t.PostLotNo).HasColumnName("PostLotNo");
               this.Property(t => t.LotNoSeperater).HasColumnName("LotNoSeperater");
               this.Property(t => t.DateTimeFormat).HasColumnName("DateTimeFormat");
               this.Property(t => t.UnitDivsor).HasColumnName("UnitDivsor");
               this.Property(t => t.UnitDivSor2).HasColumnName("UnitDivSor2");
               this.Property(t => t.EffectiveDt).HasColumnName("EffectiveDt");
               this.Property(t => t.Status).HasColumnName("Status");
               this.Property(t => t.Remarks).HasColumnName("Remarks");
               this.Property(t => t.ModifyDt).HasColumnName("ModifyDt");
               this.Property(t => t.ModifyUser).HasColumnName("ModifyUser");
               this.Property(t => t.CreateDt).HasColumnName("CreateDt");
               this.Property(t => t.CreateUser).HasColumnName("CreateUser");
               this.Property(t => t.Version).HasColumnName("Version").IsRowVersion().HasDatabaseGeneratedOption(DatabaseGeneratedOption.Computed).IsOptional();
               this.Property(t => t.LBPartNo).HasColumnName("LBPartNo");
               this.Property(t => t.LBPartName).HasColumnName("LBPartName");
               this.Property(t => t.LBSpec1).HasColumnName("LBSpec1");
               this.Property(t => t.LBSpec2).HasColumnName("LBSpec2");
           }
	}
}