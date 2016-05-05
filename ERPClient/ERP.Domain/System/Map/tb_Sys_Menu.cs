using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.ComponentModel.DataAnnotations;
using COM.Domain;
namespace ERP.Domain
{
	 	//tb_Sys_Menu
	   public class tb_Sys_MenuMap:EntityTypeConfiguration<tb_Sys_Menu>
	{
           public tb_Sys_MenuMap()
           {
               this.ToTable("tb_Sys_Menu");
               this.HasKey(t => t.Id);
               this.Property(t => t.Id).HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);
               this.Property(t => t.Id).HasColumnName("Id");
               this.Property(t => t.MenuName).HasColumnName("MenuName");
               this.Property(t => t.MenuIcon).HasColumnName("MenuIcon");
               this.Property(t => t.ParentMenuId).HasColumnName("ParentMenuId");
               this.Property(t => t.SeqNo).HasColumnName("SeqNo");
               this.Property(t => t.NameSpeace).HasColumnName("NameSpeace");
               this.Property(t => t.MenuType).HasColumnName("MenuType");
               this.Property(t => t.Version).HasColumnName("Version").IsRowVersion();
               this.Property(t => t.CreateTime).HasColumnName("CreateTime");
               this.Property(t => t.ModifyTime).HasColumnName("ModifyTime");
               this.Property(t => t.CreateUser).HasColumnName("CreateUser");
               this.Property(t => t.ModifyUser).HasColumnName("ModifyUser");
           }
	}
}