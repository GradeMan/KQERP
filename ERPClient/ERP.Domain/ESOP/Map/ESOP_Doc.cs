using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.ComponentModel.DataAnnotations;
using COM.Domain;
namespace ERP.Domain
{
	 	//ESOP_Doc
	   public class ESOP_DocMap:EntityTypeConfiguration<ESOP_Doc>
	{
           public ESOP_DocMap()
           {
               this.ToTable("ESOP_Doc");
               this.HasKey(t => t.Id);
               this.Property(t => t.Id).HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);
               this.Property(t => t.Id).HasColumnName("Id");
               this.Property(t => t.CompCode).HasColumnName("CompCode");
               this.Property(t => t.DocNo).HasColumnName("DocNo");
               this.Property(t => t.RevNo).HasColumnName("RevNo");
               this.Property(t => t.DocName).HasColumnName("DocName");
               this.Property(t => t.Descreption).HasColumnName("Descreption");
               this.Property(t => t.DocIndexId).HasColumnName("DocIndexId");
               this.Property(t => t.EffectiveDt).HasColumnName("EffectiveDt");
               this.Property(t => t.ExpireDt).HasColumnName("ExpireDt");
               this.Property(t => t.FilePath).HasColumnName("FilePath");
               this.Property(t => t.Status).HasColumnName("Status");
               this.Property(t => t.Fomat).HasColumnName("Fomat");
               this.Property(t => t.Sizes).HasColumnName("Sizes");
               this.Property(t => t.Owner).HasColumnName("Owner");
               this.Property(t => t.PageCount).HasColumnName("PageCount");
               this.Property(t => t.ModifyDt).HasColumnName("ModifyDt");
               this.Property(t => t.ModifyUser).HasColumnName("ModifyUser");
               this.Property(t => t.CreateDt).HasColumnName("CreateDt");
               this.Property(t => t.CreateUser).HasColumnName("CreateUser");
               this.Property(t => t.Version).HasColumnName("Version").IsRowVersion().HasDatabaseGeneratedOption(DatabaseGeneratedOption.Computed).IsOptional();
           }
	}
}