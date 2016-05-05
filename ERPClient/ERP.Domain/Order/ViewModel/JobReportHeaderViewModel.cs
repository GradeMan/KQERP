using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ERP.Domain.Order.ViewModel
{
   public class JobReportModel
    {
       List<vw_JobReport> JobReportHeaderList;
       List<vw_JobReport> JobReportDetailList;
        //public string JobNo { get; set; }//工单号
        //public DateTime? JobDt { get; set; }//开单日期
        //public string LotNo { get; set; }//批号
        //public decimal? LotQty { get; set; }//批数
        //public string JobType { get; set; }//生产类别
        //public string CustCode { get; set; }//客户
        //public string ItemCode { get; set; }//产品编号
        //public string ItemName { get; set; } //产品名称
        //public string OrderNo { get; set; }//订单号
        //public string CustMatNo { get; set; }//客户料号
        //public string CustPartNo { get; set; }//客户产品编号
        //public string CorpDrawingNo { get; set; }//图号
        //public string CorpDrawingRevNo { get; set; }//图号版本
        //public string CustDrawingNo { get; set; }//客户图号
        //public string CustDrawingRevNo { get; set; }//客户图号版本
        //public string CustPartName { get; set; }//客户品名
        //public string ItemSize { get; set; }//产品尺寸
        //public string SpecUnitofSheet { get; set; }//只/条
        //public string SpecLeads { get; set; }//脚仔数:
        //public string MatCode { get; set; }//材料编号
        //public string MatSpec { get; set;  }//材料规格
        //public string MatSuppName { get; set; }//材料供应商
        //public decimal OrdQty { get; set; }//订单数量
        //public decimal JobQty { get; set; }//工单数量
        //public decimal IssueQty { get; set; }//出货数量
        //public DateTime? IssueTargetDt { get; set; }//出货日期t
        //public DateTime? ProdTargetDt { get; set; }//要求完成日期
        //public string JobRemarks { get; set; }//工单备注
    }

   public class JobReportDetailModel
   {
       public string JobNo { get; set; } //工单号
       public string LotNo { get; set; }//批号
       public string ProcessCode { get; set; }//生产制程
       public string ProContent { get; set; }//生产信息
   }
}
