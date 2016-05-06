using COM.Service;
using ERP.Data;
using ERP.Domain;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using ERP.Service.Dtos;

namespace ERP.Service
{
    public interface IViewService
    {
        List<tb_Sys_Button> GetBtnView();
        List<KQMIS_JobList2> GetJobView(QueryJobView query);
        List<MES_R102_JobDelay> GetJobDelay(DateTime proddt1, DateTime proddt2, int delay);
        List<MES_Y101_DailyYieldSummary> GetDailyYieldSummary(DateTime proddt1, DateTime proddt2);
        List<MES_Y102_DailyYield> GetDailyYield(DateTime proddt1, DateTime proddt2);
        List<MES_Y201_PYield> GetPYield(QueryPYieldView query);
        List<MES_Y202_EYield> GetEYield(QueryEYieldView query);
        List<MES_Y203_CYield> GetCYield(DateTime proddt1, DateTime proddt2);
        List<MES_Y204_QYield> GetQYield(DateTime proddt1, DateTime proddt2);
        List<MES_Q101_DailyQCSummary> GetDailyQCSummary(DateTime proddt1, DateTime proddt2, int iqc);
        List<MES_Q102_DailyQC> GetDailyQC(DateTime proddt1, DateTime proddt2);
        List<MES_Q103_YieldIQCNG> GetQYieldIQCNG(DateTime proddt1, DateTime proddt2);
        List<MES_Q201_NGDetail> GetNGDetail(DateTime proddt1, DateTime proddt2);
        List<MES_Q202_PNG> GetQ202PNG(DateTime proddt1, DateTime proddt2);
        List<MES_Q203_ENG> GetQ203ENG(DateTime proddt1, DateTime proddt2);
        List<MES_Q204_CNG> GetQ204CNG(DateTime proddt1, DateTime proddt2);
        List<string> GetComboxDataByType(string type);
        string GetGenerateOrderCode(int type);
        DataTable GetEmployeelist();
       
        /// <summary>
        /// 冲压实际领用表
        /// </summary>
        /// <param name="proddt1"></param>
        /// <param name="proddt2"></param>
        /// <returns></returns>
        List<MES_P106_ActMatDaily> GetP106ActMatDaily(DateTime proddt1, DateTime proddt2);
        List<K041PDARecords> GetPDARecords(QueryPDARecordView query);
        //计划物料生成表
        List<ProductMaterialViewModel> GetBOMMaterialView(string planId);
        //计划物料表
        List<ProductMaterialViewModel> GetPlanProductMaterialView(string planId);
        //计划物料表
        List<ProductMaterialViewModel> GetPlanProductMaterialView(QueryMESPlanView query);
        //计划产品表
        List<M201PlanProductViewModel> GetPlanProductView(QueryMESPlanView query);

        //生产明细表
        List<R103_JobTxDetail> GetJobTxDetailList(QueryR103JobTxDetailView query);
        //生产明细表
        List<R105_PlanTrace> GetPlanTraceList(QueryR103JobTxDetailView query);

        /// <summary>
        /// 跟踪单报表
        /// </summary>
        /// <param name="taskNoList"></param>
        /// <returns></returns>
        List<TaskReportHead> GetTaskReportHeadList(List<string> taskNoList);
    }

    public class ViewService : IViewService
    {
        private IDatabaseFactory dbfactory;
        ICacheServiceBase appCacheService = Unity.Instance.GetService<ICacheServiceBase>();
        string compCode;
        public ViewService(IDatabaseFactory dbfactory)
		{
            this.dbfactory = dbfactory;
            compCode = appCacheService.GetItem("Company").ToString();
        }
        public List<R105_PlanTrace> GetPlanTraceList(QueryR103JobTxDetailView query)
        {
            StringBuilder sqlStr = new StringBuilder();
            sqlStr.Append(@" select * from (select a.PLNo,a.PartName,a.Qty as PlanQty,a.FQty as PlanFQty,a.AdJustQty,a.SumQty,b.TaskNo,b.JobNo,b.JobQty,b.FQty as TaskFQty 
                                                ,c.ProdDt,c.ShiftCode,c.MacCode,c.InQty,c.OutQty,c.NGQty
                                                from MES_M201_Plan_Detail a
                                                Left Outer join MES_M202_Task_Detail b on a.PLNo = b.PLNo and a.PartNo = b.PartNo and  a.CompCode = b.CompCode
                                                Left Outer join MES_M501_JobTx c on c.PLNo = b.PLNo and c.TaskNo = b.TaskNo and c.PartNo = b.PartNo and c.CompCode = b.CompCode
                                             ) as T
                                        where 1= 1");
            if (query.ProdDt != null && query.ProdDt2 != null)
                sqlStr.AppendFormat(" and ProdDt between '{0}' and  '{1}' ", query.ProdDt, query.ProdDt2);
            if (!string.IsNullOrWhiteSpace(query.PartNo))
                sqlStr.AppendFormat(" and PartNo = '{0}' ", query.PartNo);
            if (!string.IsNullOrWhiteSpace(query.PLNO))
                sqlStr.AppendFormat(" and PLNo = '{0}' ", query.PLNO);
            if (!string.IsNullOrWhiteSpace(query.TaskNo))
                sqlStr.AppendFormat(" and TaskNo = '{0}' ", query.TaskNo);
            if (!string.IsNullOrWhiteSpace(query.JobNo))
                sqlStr.AppendFormat(" and JobNo = '{0}' ", query.JobNo);
            var q = this.dbfactory.Get().Database.SqlQuery<R105_PlanTrace>(sqlStr.ToString());
            return q.ToList();
        }
        public List<R103_JobTxDetail> GetJobTxDetailList(QueryR103JobTxDetailView query)
        {
            StringBuilder sqlStr = new StringBuilder();
            sqlStr.Append(@" select * from (select PLNO,TaskNo,JobNo,ProcessCode,JobType,tx.PartNo,pro.PartName,ProdDt,ModelCode,Shift.Description as ShiftCode,MacCode,Sup.Name as Supervisor
                                            ,Op.Name as Operator,Qc.Name as QCOperator,tx.InQty,tx.OutQty,tx.NGQty,tx.Remarks,tx.CreateDt
                                            from MES_M501_JobTx tx
                                            LEFT OUTER JOIN ERP_M001_Product pro on pro.PartNo = tx.PartNo and pro.CompCode = tx.CompCode
                                            LEFT OUTER JOIN ERP_C001_Code Shift on Shift.Code = tx.ShiftCode and Shift.CompCode = tx.CompCode and Shift.CodeID = 'SHIFT'
                                            LEFT OUTER JOIN ERP_C005_Employee Sup  ON  Sup.EmpNo = tx.Supervisor and Sup.CompCode = tx.CompCode
                                            LEFT OUTER JOIN ERP_C005_Employee Op  ON  Op.EmpNo = tx.Supervisor and Op.CompCode = tx.CompCode
                                            LEFT OUTER JOIN ERP_C005_Employee Qc  ON  Qc.EmpNo = tx.Supervisor and Qc.CompCode = tx.CompCode
                                             ) as T
                                        where 1= 1");
            if (query.ProdDt != null && query.ProdDt2 != null)
                sqlStr.AppendFormat(" and ProdDt between '{0}' and  '{1}' ", query.ProdDt, query.ProdDt2);
            if (!string.IsNullOrWhiteSpace(query.PartNo))
                sqlStr.AppendFormat(" and PartNo = '{0}' ", query.PartNo);
            if (!string.IsNullOrWhiteSpace(query.PLNO))
                sqlStr.AppendFormat(" and PLNo = '{0}' ", query.PLNO);
            if (!string.IsNullOrWhiteSpace(query.TaskNo))
                sqlStr.AppendFormat(" and TaskNo = '{0}' ", query.TaskNo);
            if (!string.IsNullOrWhiteSpace(query.JobNo))
                sqlStr.AppendFormat(" and JobNo = '{0}' ", query.JobNo);
            var q = this.dbfactory.Get().Database.SqlQuery<R103_JobTxDetail>(sqlStr.ToString());
            return q.ToList();
        }
        public DataTable GetEmployeelist()
        {
//            StringBuilder sqlStr = new StringBuilder();
//            sqlStr.Append(@" select * from (select a.id as PlanDetailId,a.PLNo,a.PlanId,a.PartNo,a.CustCode,e.Alias as CustAlias,a.PartName,a.PartSpec,a.SumQty,c.MatCode,c.Unit,c.UnitConsume,d.MatName,d.MatSpec,
//                                                   a.SumQty*c.UnitConsume as Qty,a.SONO 
//                                                from  dbo.MES_M201_Plan_Detail a
//                                                left join dbo.ERP_M002_BOM b on a.PartNo = b.PartNo
//                                                left join dbo.ERP_M002_BOM_Material c on b.BOMNo  = c.BOMNo
//                                                left join dbo.ERP_M001_Material d on c.MatCode = d.MatCode
//                                                left join dbo.ERP_C004_Customer e on a.CustCode = e.CustCode ) as T
//                                                where 1= 1");
//            sqlStr.AppendFormat(" AND PlanId = '{0}'", planId);
            return null;
        }
        public List<ProductMaterialViewModel> GetBOMMaterialView(string planId)
        {
            StringBuilder sqlStr = new StringBuilder();
            sqlStr.Append(@" select * from (select a.id as PlanDetailId,a.PLNo,a.PlanId,a.PartNo,a.CustCode,e.Alias as CustAlias,a.PartName,a.PartSpec,a.SumQty,c.MatCode,c.Unit,c.UnitConsume,d.MatName,d.MatSpec,
                                                   a.SumQty*c.UnitConsume as Qty,a.SONO 
                                                from  dbo.MES_M201_Plan_Detail a
                                                left join dbo.ERP_M002_BOM b on a.PartNo = b.PartNo
                                                left join dbo.ERP_M002_BOM_Material c on b.BOMNo  = c.BOMNo
                                                left join dbo.ERP_M001_Material d on c.MatCode = d.MatCode
                                                left join dbo.ERP_C004_Customer e on a.CustCode = e.CustCode ) as T
                                                where 1= 1");
            sqlStr.AppendFormat(" AND PlanId = '{0}'", planId);
            var q = this.dbfactory.Get().Database.SqlQuery<ProductMaterialViewModel>(sqlStr.ToString());
            return q.ToList();
        }
        public List<ProductMaterialViewModel> GetPlanProductMaterialView(string planId)
        {
            StringBuilder sqlStr = new StringBuilder();
            sqlStr.Append(@" select * from (select p.id as PlanId,p.PLNo,p.PLDt,p.PLType,p.PLAuditing,p.PLAuditingDt,p.State,a.id as PlanDetailId,a.PartNo,e.CustType,a.CustCode,e.Alias as CustAlias,a.PartName,a.PartSpec,a.SumQty,c.MatCode,c.Unit,c.UnitConsume,d.MatName,d.MatSpec,
                                                 c.Qty,a.SONO
                                                from MES_M201_Plan p 
                                                left join  dbo.MES_M201_Plan_Detail a on p.Id = a.PlanId
                                                left join  dbo.MES_M201_Plan_Material c on c.PlanDetailId = a.Id
                                                left join dbo.ERP_M001_Material d on c.MatCode = d.MatCode
                                                left join dbo.ERP_C004_Customer e on a.CustCode = e.CustCode ) as T
                                                where 1= 1    ");
            sqlStr.AppendFormat(" AND PlanId = '{0}'", planId);
            var q = this.dbfactory.Get().Database.SqlQuery<ProductMaterialViewModel>(sqlStr.ToString());
            return q.ToList();
        }

        public List<ProductMaterialViewModel> GetPlanProductMaterialView(QueryMESPlanView query)
        {
           
            StringBuilder sqlStr = new StringBuilder();
            sqlStr.Append(@" select * from (select p.CompCode,p.id as PlanId,p.PLNo,p.PLDt,p.PLType,p.PLAuditing,p.PLAuditingDt,p.State,a.id as PlanDetailId,a.PartNo,e.CustType,a.CustCode,e.Alias as CustAlias,a.PartName,a.PartSpec,a.SumQty,c.MatCode,c.Unit,c.UnitConsume,d.MatName,d.MatSpec,
                                                 c.Qty,a.SONO
                                                from MES_M201_Plan p 
                                                left join  dbo.MES_M201_Plan_Detail a on p.CompCode = a.CompCode and p.Id = a.PlanId 
                                                left join  dbo.MES_M201_Plan_Material c on c.CompCode = a.CompCode and c.PlanDetailId = a.Id
                                                left join dbo.ERP_M001_Material d on c.CompCode = d.CompCode and c.MatCode = d.MatCode
                                                left join dbo.ERP_C004_Customer e on a.CompCode = e.CompCode and a.CustCode = e.CustCode ) as T
                                                where 1= 1     ");
            sqlStr.AppendFormat(" and CompCode = '{0}' ", compCode);
            if (query.TxDt != null && query.TxDt2 != null)
                sqlStr.AppendFormat(" and PLDt between '{0}' and  '{1}' ", query.TxDt, query.TxDt2);
            if (!string.IsNullOrWhiteSpace(query.PartNo))
                sqlStr.AppendFormat(" and PartNo = '{0}' ", query.PartNo);
            if (!string.IsNullOrWhiteSpace(query.CustNo))
                sqlStr.AppendFormat(" and CustCode = '{0}' ", query.CustNo);
            if (!string.IsNullOrWhiteSpace(query.PlanNo))
                sqlStr.AppendFormat(" and PLNo = '{0}' ", query.PlanNo);
            if (!string.IsNullOrWhiteSpace(query.SONo))
                sqlStr.AppendFormat(" and SONo = '{0}' ", query.SONo);
            if (!string.IsNullOrWhiteSpace(query.Status))
                sqlStr.AppendFormat(" and State = '{0}' ", query.Status);

            var q = this.dbfactory.Get().Database.SqlQuery<ProductMaterialViewModel>(sqlStr.ToString());
            return q.ToList();
        }
         //计划产品表
        public List<M201PlanProductViewModel> GetPlanProductView(QueryMESPlanView query)
        {
            StringBuilder sqlStr = new StringBuilder();
            sqlStr.Append(@" select * from (select p.id as PlanId,p.PLNo,p.PLDt,p.PLType,p.PLAuditing,p.PLAuditingDt,p.State,a.id as PlanDetailId,a.PartNo,a.CustCode,e.Alias as CustAlias,a.PartName,a.PartSpec,a.SumQty,
                                                 a.SONO,a.AdJustQty,a.Qty
                                                from MES_M201_Plan p 
                                                left join  dbo.MES_M201_Plan_Detail a on p.Id = a.PlanId
                                                left join dbo.ERP_C004_Customer e on a.CustCode = e.CustCode ) as T
                                                where 1= 1   ");
            if (query.TxDt != null && query.TxDt2 != null)
                sqlStr.AppendFormat(" and PLDt between '{0}' and  '{1}' ", query.TxDt, query.TxDt2);
            if (!string.IsNullOrWhiteSpace(query.PartNo))
                sqlStr.AppendFormat(" and PartNo = '{0}' ", query.PartNo);
            if (!string.IsNullOrWhiteSpace(query.CustNo))
                sqlStr.AppendFormat(" and CustCode = '{0}' ", query.CustNo);
            if (!string.IsNullOrWhiteSpace(query.PlanNo))
                sqlStr.AppendFormat(" and PLNo = '{0}' ", query.PlanNo);
            if (!string.IsNullOrWhiteSpace(query.SONo))
                sqlStr.AppendFormat(" and SONo = '{0}' ", query.SONo);
            if (!string.IsNullOrWhiteSpace(query.Status))
                sqlStr.AppendFormat(" and State = '{0}' ", query.Status);
            var q = this.dbfactory.Get().Database.SqlQuery<M201PlanProductViewModel>(sqlStr.ToString());
            return q.ToList();
        }
        public List<K041PDARecords> GetPDARecords(QueryPDARecordView query)
        {
            StringBuilder sqlStr = new StringBuilder();
            sqlStr.Append(" select * from KQLot.dbo.tb_PDA_Records where 1= 1 ");
            if (!string.IsNullOrWhiteSpace(query.CustCode))
                sqlStr.AppendFormat(" and CustCode = '{0}'", query.CustCode);
            if (!string.IsNullOrWhiteSpace(query.LotNo))
                sqlStr.AppendFormat(" and LotNo = '{0}'", query.LotNo);
            if (!string.IsNullOrWhiteSpace(query.PartNo))
                sqlStr.AppendFormat(" and PartNo = '{0}'", query.PartNo);
            if (query.TxDt!=null && query.TxDt2!=null)
                sqlStr.AppendFormat(" and TxDt between '{0}' and  '{1}' ", query.TxDt, query.TxDt2);
            var q = this.dbfactory.Get().Database.SqlQuery<K041PDARecords>(sqlStr.ToString());
            return q.ToList();
        }
        public List<string> GetComboxDataByType(string type)
        {
            string sql = "";
            switch (type)
            {
                case "Product": sql = string.Format("select  distinct PartName from KQLot.dbo.tb_Product ");
                    break;
                case "Customer": sql = string.Format("select  distinct Alias from KQLot.dbo.tb_Customer ");
                    break;
            }
            if (string.IsNullOrWhiteSpace(sql))
                return null;
            else
                return this.dbfactory.Get().Database.SqlQuery<string>(sql).ToList();
        }
        public List<tb_Sys_Button> GetBtnView()
        {
           var q =  this.dbfactory.Get().Database.SqlQuery<tb_Sys_Button>(" select * from tb_Sys_Button");
          // var p = this.dbfactory.Get().Database
           return q.ToList();
        }

        public List<KQMIS_JobList2> GetJobView(QueryJobView query)
        {
            StringBuilder sqlStr = new StringBuilder();
            sqlStr.Append(" select * from KQLot.dbo.KQMIS_JobList2 where 1= 1 ");
            if (!string.IsNullOrWhiteSpace(query.JobNo))
                sqlStr.AppendFormat(" and J_JobNo = '{0}'", query.JobNo);
            if (!string.IsNullOrWhiteSpace(query.PartName))
                sqlStr.AppendFormat(" and J_PartNo = '{0}'", query.PartName);
            var q = this.dbfactory.Get().Database.SqlQuery<KQMIS_JobList2>(sqlStr.ToString());
            return q.ToList();
        }
        
        //生产延期表
        public List<MES_R102_JobDelay> GetJobDelay(DateTime proddt1, DateTime proddt2, int delay)
        {
            var sdateParam = new System.Data.SqlClient.SqlParameter("sdate", System.Data.SqlDbType.DateTime);
            sdateParam.Value = proddt1;
            var edateParam = new System.Data.SqlClient.SqlParameter("edate", System.Data.SqlDbType.DateTime);
            edateParam.Value = proddt2;
            var daysParam = new System.Data.SqlClient.SqlParameter("days", System.Data.SqlDbType.Int);
            daysParam.Value = delay;

            var q = this.dbfactory.Get().Database.SqlQuery<MES_R102_JobDelay>("exec KQLot.dbo.P_KQMIS_ProdDelay @sdate, @edate, @days", sdateParam, edateParam, daysParam);
          
            return q.ToList();

            //------------------old system-------------------------------------------
            //var sdateParam = new System.Data.SqlClient.SqlParameter("sdate", System.Data.SqlDbType.DateTime);
            //sdateParam.Value = dtStart.DateTime;
            //var edateParam = new System.Data.SqlClient.SqlParameter("edate", System.Data.SqlDbType.DateTime);
            //edateParam.Value = dtEnd.DateTime;
            //var daysParam = new System.Data.SqlClient.SqlParameter("days", System.Data.SqlDbType.Int);
            //daysParam.Value = txtdelays.Value;

            //var q = context.Database.SqlQuery<P_KQMIS_ProdDelay_Result>("exec P_KQMIS_ProdDelay @sdate, @edate,@days", sdateParam, edateParam, daysParam).ToList();
        }

        //Y101-产量汇总报表
        public List<MES_Y101_DailyYieldSummary> GetDailyYieldSummary(DateTime proddt1, DateTime proddt2)
        {
            var sdateParam = new System.Data.SqlClient.SqlParameter("sdate", System.Data.SqlDbType.DateTime);
            sdateParam.Value = proddt1;
            var edateParam = new System.Data.SqlClient.SqlParameter("edate", System.Data.SqlDbType.DateTime);
            edateParam.Value = proddt2;

            var q = this.dbfactory.Get().Database.SqlQuery<MES_Y101_DailyYieldSummary>("exec KQLot.dbo.P_KQMIS_DailyYieldByStockSUMMARY @sdate, @edate", sdateParam, edateParam);

            return q.ToList();

        }

        //Y102-产量日报表
        public List<MES_Y102_DailyYield> GetDailyYield(DateTime proddt1, DateTime proddt2)
        {
            var sdateParam = new System.Data.SqlClient.SqlParameter("sdate", System.Data.SqlDbType.DateTime);
            sdateParam.Value = proddt1;
            var edateParam = new System.Data.SqlClient.SqlParameter("edate", System.Data.SqlDbType.DateTime);
            edateParam.Value = proddt2;

            var q = this.dbfactory.Get().Database.SqlQuery<MES_Y102_DailyYield>("exec KQLot.dbo.P_KQMIS_DailyYieldByStock @sdate, @edate", sdateParam, edateParam);

            return q.ToList();

        }

        //Y201-冲压产量报表
        public List<MES_Y201_PYield> GetPYield(QueryPYieldView query)
        {
            StringBuilder sqlStr = new StringBuilder();
            sqlStr.Append(" select * from KQLot.dbo.KQERP_PYield where 1= 1 ");
            if (!string.IsNullOrWhiteSpace(query.proddt1) && !string.IsNullOrWhiteSpace(query.proddt2))
                sqlStr.AppendFormat(" and ProdDt >= '{0}' and ProdDt <= '{1}' ", query.proddt1, query.proddt2);
            if(!string.IsNullOrWhiteSpace(query.PartNo))
                sqlStr.AppendFormat(" and PartNo = '{0}'", query.PartNo);
            if (!string.IsNullOrWhiteSpace(query.IsInStore))
                sqlStr.AppendFormat(" and BCPIn = '{0}'", query.IsInStore == "True" ? 1 : 0);
            if (!string.IsNullOrWhiteSpace(query.IsCheck))
                sqlStr.AppendFormat(" and YieldFactor = '{0}'", query.IsCheck == "True" ? "Y" : "N");
            var q = this.dbfactory.Get().Database.SqlQuery<MES_Y201_PYield>(sqlStr.ToString());
            return q.ToList();
        }

        //Y202-电镀产量报表
        public List<MES_Y202_EYield> GetEYield(QueryEYieldView query)
        {
            StringBuilder sqlStr = new StringBuilder();
            sqlStr.Append(" select * from KQLot.dbo.KQERP_EYield where 1= 1 ");

            if (!string.IsNullOrWhiteSpace(query.proddt1) && !string.IsNullOrWhiteSpace(query.proddt2))
                sqlStr.AppendFormat(" and ProdDt >= '{0}' and ProdDt <= '{1}' ", query.proddt1, query.proddt2);
            if (!string.IsNullOrWhiteSpace(query.IsInStore))
                sqlStr.AppendFormat(" and ZZCIn = '{0}'", query.IsInStore == "True" ? 1 : 0);
            if (!string.IsNullOrWhiteSpace(query.IsCheck))
                sqlStr.AppendFormat(" and YieldFactor = '{0}'", query.IsCheck == "True" ? "Y" : "N");
            if(!string.IsNullOrWhiteSpace(query.PartNo))
                sqlStr.AppendFormat(" and PartNo = '{0}'", query.PartNo);
            if(!string.IsNullOrWhiteSpace(query.CustName))
                sqlStr.AppendFormat(" and CustName = '{0}'", query.CustName);
            var q = this.dbfactory.Get().Database.SqlQuery<MES_Y202_EYield>(sqlStr.ToString());
            return q.ToList();
        }

        //Y203-切断产量报表
        public List<MES_Y203_CYield> GetCYield(DateTime proddt1, DateTime proddt2)
        {
            StringBuilder sqlStr = new StringBuilder();
            sqlStr.Append(" select * from KQLot.dbo.KQMIS_CYield where 1= 1 ");

            sqlStr.AppendFormat(" and ProdDt >= '{0}'", proddt1);

            sqlStr.AppendFormat(" and ProdDt <= '{0}'", proddt2);

            var q = this.dbfactory.Get().Database.SqlQuery<MES_Y203_CYield>(sqlStr.ToString());
            return q.ToList();
        }

        //Y204-全检产量报表
        public List<MES_Y204_QYield> GetQYield(DateTime proddt1, DateTime proddt2)
        {
            StringBuilder sqlStr = new StringBuilder();
            sqlStr.Append(" select * from KQLot.dbo.KQMIS_QYield where 1= 1 ");

            sqlStr.AppendFormat(" and ProdDt >= '{0}'", proddt1);

            sqlStr.AppendFormat(" and ProdDt <= '{0}'", proddt2);

            var q = this.dbfactory.Get().Database.SqlQuery<MES_Y204_QYield>(sqlStr.ToString());
            return q.ToList();
        }

        //Q101-质量统计报表
        public List<MES_Q101_DailyQCSummary> GetDailyQCSummary(DateTime proddt1, DateTime proddt2, int iqc)
        {
            var sdateParam = new System.Data.SqlClient.SqlParameter("sdate", System.Data.SqlDbType.DateTime);
            sdateParam.Value = proddt1;
            var edateParam = new System.Data.SqlClient.SqlParameter("edate", System.Data.SqlDbType.DateTime);
            edateParam.Value = proddt2;
            var iqcParam = new System.Data.SqlClient.SqlParameter("iqc", System.Data.SqlDbType.Int);
            iqcParam.Value = iqc;

            var q = this.dbfactory.Get().Database.SqlQuery<MES_Q101_DailyQCSummary>("exec KQLot.dbo.P_KQMIS_DailyQCSUMMARY @sdate, @edate, @iqc", sdateParam, edateParam,iqcParam);

            return q.ToList();
        }

        //Q102-质量日报表
        public List<MES_Q102_DailyQC> GetDailyQC(DateTime proddt1, DateTime proddt2)
        {
            var sdateParam = new System.Data.SqlClient.SqlParameter("sdate", System.Data.SqlDbType.DateTime);
            sdateParam.Value = proddt1;
            var edateParam = new System.Data.SqlClient.SqlParameter("edate", System.Data.SqlDbType.DateTime);
            edateParam.Value = proddt2;

            var q = this.dbfactory.Get().Database.SqlQuery<MES_Q102_DailyQC>("exec KQLot.dbo.P_KQMIS_DailyQC @sdate, @edate", sdateParam, edateParam);

            return q.ToList();
        }

        //Q103-全检质量报表
        public List<MES_Q103_YieldIQCNG> GetQYieldIQCNG(DateTime proddt1, DateTime proddt2)
        {
            StringBuilder sqlStr = new StringBuilder();
            sqlStr.Append(" select * from KQLot.dbo.KQMIS_QYield_IQCNG where 1= 1 ");

            sqlStr.AppendFormat(" and ProdDt >= '{0}'", proddt1);

            sqlStr.AppendFormat(" and ProdDt <= '{0}'", proddt2);

            StringBuilder sqlStr2 = new StringBuilder();
            sqlStr2.Append(" select * from KQLot.dbo.KQMIS_QYield_IQCScrap where 1= 1 ");

            sqlStr2.AppendFormat(" and ProdDt >= '{0}'", proddt1);

            sqlStr2.AppendFormat(" and ProdDt <= '{0}'", proddt2);

            var yieldIQCNG = this.dbfactory.Get().Database.SqlQuery<MES_Q103_YieldIQCNG>(sqlStr.ToString()).ToList();
            var yieldIQCScrap = this.dbfactory.Get().Database.SqlQuery<MES_Q103_YieldIQCScrap>(sqlStr2.ToString()).ToList();
            //循环Q103_YieldIQCScrap，如果在MES_Q103_YieldIQCNG表中能找到数据，则赋值给MES_Q103_YieldIQCNG的PIQCNGQtyInk，如果找不到，则新增一个到MES_Q103_YieldIQCNG
            foreach (var qcscrap in yieldIQCScrap)
            {
                var iQCNG = yieldIQCNG.Where(a => a.JobType == qcscrap.JobType && a.Category == qcscrap.Category && a.QPartNo == qcscrap.PartNo && a.ProdDt == qcscrap.Proddt).FirstOrDefault();
                if (iQCNG != null)
                {
                    
                }
                else
                {
                    iQCNG =  new MES_Q103_YieldIQCNG();
                    iQCNG.JobType = qcscrap.JobType;
                    iQCNG.Category = qcscrap.Category;
                    iQCNG.QPartNo = qcscrap.PartNo;
                    iQCNG.ProdDt = qcscrap.Proddt;
                    iQCNG.JobType = qcscrap.JobType;
                }
                switch (qcscrap.Process.Trim())
                {
                    case "01-冲压": iQCNG.PIQCNGQtyInk = qcscrap.IQCNGQtyINK;
                        break;
                    case "02-电镀": iQCNG.EIQCNGQtyInk = qcscrap.IQCNGQtyINK;
                        break;
                    case "03-切断": iQCNG.CIQCNGQtyInk = qcscrap.IQCNGQtyINK;
                        break;
                    case "04-其他": iQCNG.FIQCNGQtyInk = qcscrap.IQCNGQtyINK;
                        break;
                }
            }
            return yieldIQCNG.ToList();
        }

        /// <summary>
        ///Q201-报废明细表
        /// </summary>
        /// <param name="proddt1"></param>
        /// <param name="proddt2"></param>
        /// <returns></returns>
        public List<MES_Q201_NGDetail> GetNGDetail(DateTime proddt1, DateTime proddt2)
        {
            StringBuilder sqlStr = new StringBuilder();
            sqlStr.Append(" select * from KQLot.dbo.KQMIS_NGDetail where 1= 1 ");

            sqlStr.AppendFormat(" and ProdDt >= '{0}'", proddt1);

            sqlStr.AppendFormat(" and ProdDt <= '{0}'", proddt2);

            var q = this.dbfactory.Get().Database.SqlQuery<MES_Q201_NGDetail>(sqlStr.ToString());
            return q.ToList();
        }

        /// <summary>
        ///Q202-冲压报表
        /// </summary>
        /// <param name="proddt1"></param>
        /// <param name="proddt2"></param>
        /// <returns></returns>
        public List<MES_Q202_PNG> GetQ202PNG(DateTime proddt1, DateTime proddt2)
        {
            StringBuilder sqlStr = new StringBuilder();
            sqlStr.Append(" select * from KQLot.dbo.KQMIS_PNG where 1= 1 ");

            sqlStr.AppendFormat(" and ProdDt >= '{0}'", proddt1);

            sqlStr.AppendFormat(" and ProdDt <= '{0}'", proddt2);

            var q = this.dbfactory.Get().Database.SqlQuery<MES_Q202_PNG>(sqlStr.ToString());
            return q.ToList();
        }

        /// <summary>
        ///Q203-电镀报表
        /// </summary>
        /// <param name="proddt1"></param>
        /// <param name="proddt2"></param>
        /// <returns></returns>
        public List<MES_Q203_ENG> GetQ203ENG(DateTime proddt1, DateTime proddt2)
        {
            StringBuilder sqlStr = new StringBuilder();
            sqlStr.Append(" select * from KQLot.dbo.KQMIS_ENG where 1= 1 ");

            sqlStr.AppendFormat(" and ProdDt >= '{0}'", proddt1);

            sqlStr.AppendFormat(" and ProdDt <= '{0}'", proddt2);

            var q = this.dbfactory.Get().Database.SqlQuery<MES_Q203_ENG>(sqlStr.ToString());
            return q.ToList();
        }

        /// <summary>
        ///Q204-切断报表
        /// </summary>
        /// <param name="proddt1"></param>
        /// <param name="proddt2"></param>
        /// <returns></returns>
        public List<MES_Q204_CNG> GetQ204CNG(DateTime proddt1, DateTime proddt2)
        {
            StringBuilder sqlStr = new StringBuilder();
            sqlStr.Append(" select * from KQLot.dbo.KQMIS_CNG where 1= 1 ");

            sqlStr.AppendFormat(" and ProdDt >= '{0}'", proddt1);

            sqlStr.AppendFormat(" and ProdDt <= '{0}'", proddt2);

            var q = this.dbfactory.Get().Database.SqlQuery<MES_Q204_CNG>(sqlStr.ToString());
            return q.ToList();
        }

        /// <summary>
        /// 冲压实际领用表
        /// </summary>
        /// <param name="proddt1"></param>
        /// <param name="proddt2"></param>
        /// <returns></returns>
        public List<MES_P106_ActMatDaily> GetP106ActMatDaily(DateTime proddt1, DateTime proddt2)
        {
            StringBuilder strSql = new StringBuilder();

            strSql.Append(" select a.MatSpecCode,a.MatSpec,a.MatCode,d.MatName,a.Suppode,e.ShortName,ReqQty,RetQty,TxDt,c.CheckQty,b.CheckQty as LastCheckQty ");
            strSql.Append(" from KQLot.dbo.tb_MatConsume_ActMat_Daily a");
            strSql.Append(" left outer join KQLot.dbo.tb_material d on a.MatCode = d.MatCode");
            strSql.Append(" left outer join KQLot.dbo.tb_supplier e on a.Suppode = e.SuppCode");
            strSql.Append(" left outer join KQLot.dbo.tb_MatConsume_ActMat_MouthCheck b  on a.MatSpecCode = b.MatSpecCode and a.MatSpec = b.MatSpec and a.MatCode = b.MatCode");
            strSql.AppendFormat(" and b.TxMouth = '{0}'", proddt1.Date.AddMonths(-1).ToString("yyyy-MM"));
            strSql.Append(" left outer join KQLot.dbo.tb_MatConsume_ActMat_MouthCheck c  on a.MatSpecCode = c.MatSpecCode and a.MatSpec = c.MatSpec and a.MatCode = c.MatCode  ");
            strSql.AppendFormat(" and c.TxMouth = '{0}'", proddt1.Date.ToString("yyyy-MM"));
            strSql.AppendFormat(" where TxDt between '{0}' and '{1}' ", proddt1.Date, proddt2.Date);
            var q = this.dbfactory.Get().Database.SqlQuery<MES_P106_ActMatDaily>(strSql.ToString());
            return q.ToList();
        }

        public string GetGenerateOrderCode(int type)
        {
            var sdateParam = new System.Data.SqlClient.SqlParameter("orderType", System.Data.SqlDbType.Int);
            sdateParam.Value = type;
            var q = this.dbfactory.Get().Database.SqlQuery<string>("exec Proc_GenerateOrderCode @orderType", sdateParam);

            return q.ToList().First();
        }

        public List<TaskReportHead> GetTaskReportHeadList(List<string> taskNoList )
        {
            StringBuilder strSql = new StringBuilder();

            strSql.Append(@" select TaskNo,JobLotNo,CustCode,SoNo,SoQty,a.PartNo,PartSpec,a.ProcessFlow from MES_M202_Task_Detail a
                                inner join MES_M202_Task_JobLot b on a.TaskNo = b.JobNo
                                left outer join ERP_M001_Product p on a.PartNo = p.PartNo
                                ORDER BY TaskNo,JobLotNo ");
            //strSql.AppendFormat(" where TxDt between '{0}' and '{1}' ", proddt1.Date, proddt2.Date);
            var q = this.dbfactory.Get().Database.SqlQuery<TaskReportHead>(strSql.ToString());
            q = q.Where(a => taskNoList.Contains(a.TaskNo));
            return q.ToList();
        }
    }
}
