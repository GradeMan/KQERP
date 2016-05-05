using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.ComponentModel.DataAnnotations;
using COM.Domain;
namespace ERP.Domain
{
	 	//ESOP_DocIndex_Sec
	   public class ESOP_DocIndex_SecMap:EntityTypeConfiguration<ESOP_DocIndex_Sec>
	{
           public ESOP_DocIndex_SecMap()
           {
               this.ToTable("ESOP_DocIndex_Sec");
               this.HasKey(t => t.Id);
               this.Property(t => t.Id).HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);
               this.Property(t => t.Id).HasColumnName("Id");
               this.Property(t => t.DocIndexId).HasColumnName("DocIndexId");
               this.Property(t => t.RoleId).HasColumnName("RoleId");
           }
	}
}