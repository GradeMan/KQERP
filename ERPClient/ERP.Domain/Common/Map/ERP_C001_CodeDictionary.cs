using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.ComponentModel.DataAnnotations;
using COM.Domain;
namespace ERP.Domain
{
	 	//ERP_C001_CodeDictionary
	   public class ERP_C001_CodeDictionaryMap:EntityTypeConfiguration<ERP_C001_CodeDictionary>
	{
           public ERP_C001_CodeDictionaryMap()
           {
               this.ToTable("ERP_C001_CodeDictionary");
               this.HasKey(t => t.Id);
               this.Property(t => t.Id).HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);
               this.Property(t => t.Id).HasColumnName("Id");
               this.Property(t => t.CompCode).HasColumnName("CompCode");
               this.Property(t => t.ParentId).HasColumnName("ParentId");
               this.Property(t => t.IsTree).HasColumnName("IsTree");
               this.Property(t => t.Category).HasColumnName("Category");
               this.Property(t => t.Code).HasColumnName("Code");
               this.Property(t => t.FullName).HasColumnName("FullName");
               this.Property(t => t.Remark).HasColumnName("Remark");
               this.Property(t => t.Enabled).HasColumnName("Enabled");
               this.Property(t => t.SortCode).HasColumnName("SortCode");
               this.Property(t => t.DeleteMark).HasColumnName("DeleteMark");
               this.Property(t => t.CreateDt).HasColumnName("CreateDt");
               this.Property(t => t.CreateUser).HasColumnName("CreateUser");
               this.Property(t => t.ModifyDt).HasColumnName("ModifyDt");
               this.Property(t => t.ModifyUser).HasColumnName("ModifyUser");
           }
	}
}