using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.ComponentModel.DataAnnotations;
using COM.Domain;
namespace ERP.Domain
{
	 	//vw_JobReport
	   public class vw_JobReportMap:EntityTypeConfiguration<vw_JobReport>
	{
           public vw_JobReportMap()
           {
               this.ToTable("vw_JobReport");
               this.HasKey(t => t.Id);
               this.Property(t => t.Id).HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);
               this.Property(t => t.JobNo).HasColumnName("JobNo");
               this.Property(t => t.JobDt).HasColumnName("JobDt");
               this.Property(t => t.LotNo).HasColumnName("LotNo");
               this.Property(t => t.LotQty).HasColumnName("LotQty");
               this.Property(t => t.JobType).HasColumnName("JobType");
               this.Property(t => t.CustCode).HasColumnName("CustCode");
               this.Property(t => t.ItemCode).HasColumnName("ItemCode");
               this.Property(t => t.ItemName).HasColumnName("ItemName");
               this.Property(t => t.OrderNo).HasColumnName("OrderNo");
               this.Property(t => t.CustMatNo).HasColumnName("CustMatNo");
               this.Property(t => t.CustPartName).HasColumnName("CustPartName");
               this.Property(t => t.Expr1).HasColumnName("Expr1");
               this.Property(t => t.CorpDrawingNo).HasColumnName("CorpDrawingNo");
               this.Property(t => t.CorpDrawingRevNo).HasColumnName("CorpDrawingRevNo");
               this.Property(t => t.CustDrawingNo).HasColumnName("CustDrawingNo");
               this.Property(t => t.CustDrawingRevNo).HasColumnName("CustDrawingRevNo");
               this.Property(t => t.ItemSize).HasColumnName("ItemSize");
               this.Property(t => t.SpecUnitofSheet).HasColumnName("SpecUnitofSheet");
               this.Property(t => t.SpecLeads).HasColumnName("SpecLeads");
               this.Property(t => t.MatCode).HasColumnName("MatCode");
               this.Property(t => t.MatSpec).HasColumnName("MatSpec");
               this.Property(t => t.SuppCode).HasColumnName("SuppCode");
               this.Property(t => t.OrdQty).HasColumnName("OrdQty");
               this.Property(t => t.JobQty).HasColumnName("JobQty");
               this.Property(t => t.IssueQty).HasColumnName("IssueQty");
               this.Property(t => t.IssueTargetDt).HasColumnName("IssueTargetDt");
               this.Property(t => t.ProdTargetDt).HasColumnName("ProdTargetDt");
               this.Property(t => t.Remarks).HasColumnName("Remarks");
               this.Property(t => t.CustName).HasColumnName("CustName");
               this.Property(t => t.SuppName).HasColumnName("SuppName");
           }
	}
}