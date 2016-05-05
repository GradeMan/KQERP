using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.ComponentModel.DataAnnotations;
using COM.Domain;
namespace ERP.Domain
{
	 	//MES_M002_Job
	   public class MES_M002_JobMap:EntityTypeConfiguration<MES_M002_Job>
	{
           public MES_M002_JobMap()
           {
               this.ToTable("MES_M002_Job");
               this.HasKey(t => t.Id);
               this.Property(t => t.Id).HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);
               this.Property(t => t.Id).HasColumnName("Id");
               this.Property(t => t.CompCode).HasColumnName("CompCode");
               this.Property(t => t.JobNo).HasColumnName("JobNo");
               this.Property(t => t.JobDt).HasColumnName("JobDt");
               this.Property(t => t.JobType).HasColumnName("JobType");
               this.Property(t => t.FItemCode).HasColumnName("FItemCode");
               this.Property(t => t.ItemCode).HasColumnName("ItemCode");
               this.Property(t => t.OrderNo).HasColumnName("OrderNo");
               this.Property(t => t.OrdQty).HasColumnName("OrdQty");
               this.Property(t => t.CustCode).HasColumnName("CustCode");
               this.Property(t => t.ProcessFlow).HasColumnName("ProcessFlow");
               this.Property(t => t.Status).HasColumnName("Status");
               this.Property(t => t.ProdTargetDt).HasColumnName("ProdTargetDt");
               this.Property(t => t.IssueTargetDt).HasColumnName("IssueTargetDt");
               this.Property(t => t.ApprovalDt).HasColumnName("ApprovalDt");
               this.Property(t => t.ApprovalBy).HasColumnName("ApprovalBy");
               this.Property(t => t.Remarks).HasColumnName("Remarks");
               this.Property(t => t.ModifyDt).HasColumnName("ModifyDt");
               this.Property(t => t.ModifyUser).HasColumnName("ModifyUser");
               this.Property(t => t.CreateDt).HasColumnName("CreateDt");
               this.Property(t => t.CreateUser).HasColumnName("CreateUser");
               this.Property(t => t.JobQty).HasColumnName("JobQty");
               this.Property(t => t.PQty).HasColumnName("PQty");
               this.Property(t => t.BCPQty).HasColumnName("BCPQty");
               this.Property(t => t.EQty).HasColumnName("EQty");
               this.Property(t => t.ZZCQty).HasColumnName("ZZCQty");
               this.Property(t => t.CQty).HasColumnName("CQty");
               this.Property(t => t.QQty).HasColumnName("QQty");
               this.Property(t => t.CPQty).HasColumnName("CPQty");
               this.Property(t => t.PanelQty).HasColumnName("PanelQty");
               this.Property(t => t.StripPerPanel).HasColumnName("StripPerPanel");
               this.Property(t => t.LotCount).HasColumnName("LotCount");
               this.Property(t => t.Version).HasColumnName("Version").IsRowVersion().HasDatabaseGeneratedOption(DatabaseGeneratedOption.Computed).IsOptional();
               this.Property(t => t.IssueQty).HasColumnName("IssueQty");
           }
	}
}