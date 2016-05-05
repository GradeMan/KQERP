﻿using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.ComponentModel.DataAnnotations;
using COM.Domain;
namespace ERP.Domain
{
	 	//MES_M801_Label_L_PrintData
	   public class MES_M801_Label_L_PrintDataMap:EntityTypeConfiguration<MES_M801_Label_L_PrintData>
	{
           public MES_M801_Label_L_PrintDataMap()
           {
               this.ToTable("MES_M801_Label_L_PrintData");
               this.HasKey(t => t.Id);
               this.Property(t => t.Id).HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);
               this.Property(t => t.Id).HasColumnName("Id");
               this.Property(t => t.CompCode).HasColumnName("CompCode");
               this.Property(t => t.LotNo).HasColumnName("LotNo");
               this.Property(t => t.MLotNo).HasColumnName("MLotNo");
               this.Property(t => t.BoxNo).HasColumnName("BoxNo");
               this.Property(t => t.TotBox).HasColumnName("TotBox");
               this.Property(t => t.TotPack).HasColumnName("TotPack");
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
               this.Property(t => t.CustPONo).HasColumnName("CustPONo");
               this.Property(t => t.CustLotNo).HasColumnName("CustLotNo");
               this.Property(t => t.MatCode).HasColumnName("MatCode");
               this.Property(t => t.MatType).HasColumnName("MatType");
               this.Property(t => t.MatSuppCode).HasColumnName("MatSuppCode");
               this.Property(t => t.MatLotNo).HasColumnName("MatLotNo");
               this.Property(t => t.LabelType).HasColumnName("LabelType");
               this.Property(t => t.ProdDt).HasColumnName("ProdDt");
               this.Property(t => t.ExpiredDt).HasColumnName("ExpiredDt");
               this.Property(t => t.ExpiredPeriod).HasColumnName("ExpiredPeriod");
               this.Property(t => t.Qty).HasColumnName("Qty");
               this.Property(t => t.Unit).HasColumnName("Unit");
               this.Property(t => t.Code2D).HasColumnName("Code2D");
               this.Property(t => t.LBPartNo).HasColumnName("LBPartNo");
               this.Property(t => t.LBPartName).HasColumnName("LBPartName");
               this.Property(t => t.LBSpec1).HasColumnName("LBSpec1");
               this.Property(t => t.LBSpec2).HasColumnName("LBSpec2");
               this.Property(t => t.JointNumber).HasColumnName("JointNumber");
           }
	}
}