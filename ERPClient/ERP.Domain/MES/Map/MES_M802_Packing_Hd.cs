using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.ComponentModel.DataAnnotations;
using COM.Domain;
namespace ERP.Domain
{
	 	//MES_M802_Packing_Hd
	   public class MES_M802_Packing_HdMap:EntityTypeConfiguration<MES_M802_Packing_Hd>
	{
           public MES_M802_Packing_HdMap()
           {
               this.ToTable("MES_M802_Packing_Hd");
               this.HasKey(t => t.Id);
               this.Property(t => t.Id).HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);
               this.Property(t => t.Id).HasColumnName("Id");
               this.Property(t => t.CompCode).HasColumnName("CompCode");
               this.Property(t => t.DocNo).HasColumnName("DocNo");
               this.Property(t => t.ProdDt).HasColumnName("ProdDt");
               this.Property(t => t.Qty).HasColumnName("Qty");
               this.Property(t => t.Package).HasColumnName("Package");
               this.Property(t => t.CustCode).HasColumnName("CustCode");
               this.Property(t => t.JobNo).HasColumnName("JobNo");
               this.Property(t => t.PartNo).HasColumnName("PartNo");
               this.Property(t => t.PartType).HasColumnName("PartType");
               this.Property(t => t.SubShipLot1st).HasColumnName("SubShipLot1st");
               this.Property(t => t.Remarks).HasColumnName("Remarks");
               this.Property(t => t.LotNoList).HasColumnName("LotNoList");
               this.Property(t => t.LotNoPackList).HasColumnName("LotNoPackList");
               this.Property(t => t.LotNoPackQtyList).HasColumnName("LotNoPackQtyList");
               this.Property(t => t.CreateDt).HasColumnName("CreateDt");
               this.Property(t => t.CreateUser).HasColumnName("CreateUser");
               this.Property(t => t.ModifyDt).HasColumnName("ModifyDt");
               this.Property(t => t.ModifyUser).HasColumnName("ModifyUser");
           }
	}
}