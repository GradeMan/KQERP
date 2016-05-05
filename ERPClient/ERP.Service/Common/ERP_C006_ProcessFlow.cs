using System;
using System.Linq;
using System.Collections.Generic;
using COM.Data;
using ERP.Data;
using ERP.Domain;
using COM.Service;
using COM.Domain;
namespace ERP.Service
{
	public interface IProcessFlowService
	{
		ERP_C006_ProcessFlow GetById(Guid Id);
        List<ERP_C006_ProcessFlow> GetList();
		List<ERP_C006_ProcessFlow> GetList(PagingModel pagingModel, DateTime? beginDate, DateTime? endDate);
        void Create(ERP_C006_ProcessFlow ERP_C006_ProcessFlow);
        void Update(ERP_C006_ProcessFlow ERP_C006_ProcessFlow);
        void Delete(Guid Id);
        void Save(ERP_C006_ProcessFlow processFlow, List<ERP_C006_ProcessFlow_Process> processDetailList,List<ERP_C006_ProcessFlow_ProdInfo> prodInfoList);
        void MarkDelProcessFlowDetail(Guid id);
        List<InputItem> GetProcessFlowInputData();
        List<ERP_C006_ProcessFlow_Process> GetProcessFlowDetail(string processFlowCode);
	}
    public class ProcessFlowService : IProcessFlowService
	{
        private IDatabaseFactory dbfactory;
		private IERP_C006_ProcessFlowRepository ERP_C006_ProcessFlowRepository;
		private IUnitOfWork runtimeService;
		private ICacheServiceBase appCacheService = Unity.Instance.GetService<ICacheServiceBase>();
        private IERP_C006_ProcessFlow_ProcessRepository processFlowDetailRepository;
        private IERP_C006_ProcessFlow_ProdInfoRepository prodInfoRepository;
        public ProcessFlowService(IDatabaseFactory dbfactory)
		{
            this.dbfactory = dbfactory;
            this.runtimeService = new UnitOfWork(dbfactory);
            this.ERP_C006_ProcessFlowRepository = new ERP_C006_ProcessFlowRepository(dbfactory);
            processFlowDetailRepository = new ERP_C006_ProcessFlow_ProcessRepository(dbfactory);
            prodInfoRepository = new ERP_C006_ProcessFlow_ProdInfoRepository(dbfactory);

		}
		public List<ERP_C006_ProcessFlow> GetList()
        {
            var q = this.ERP_C006_ProcessFlowRepository.GetMany(i => true);
            return q.ToList();
        }

        public ERP_C006_ProcessFlow GetById(Guid Id)
        {
            return this.ERP_C006_ProcessFlowRepository.GetByID(Id);
        }

        public void Create(ERP_C006_ProcessFlow ERP_C006_ProcessFlow)
        {
            ERP_C006_ProcessFlow.CreateDt = DateTime.Now;
            tb_Sys_User tempUser = appCacheService.GetItem("user") as tb_Sys_User;
            ERP_C006_ProcessFlow.CreateUser = tempUser.UserName;
            ERP_C006_ProcessFlow.CompCode = tempUser.CompCode;
            ERP_C006_ProcessFlow.Validate();
			this.ERP_C006_ProcessFlowRepository.Add(ERP_C006_ProcessFlow);
            this.runtimeService.Commit();
        }

        public void Delete(Guid Id)
        {
            var existstb_Sys_Menu = this.GetById(Id);
            this.ERP_C006_ProcessFlowRepository.Delete(existstb_Sys_Menu);
            this.runtimeService.Commit();
        }

        public void Update(ERP_C006_ProcessFlow ERP_C006_ProcessFlow)
        {
        	ERP_C006_ProcessFlow.ModifyDt = DateTime.Now;
            tb_Sys_User tempUser = appCacheService.GetItem("user") as tb_Sys_User;
            ERP_C006_ProcessFlow.ModifyUser = tempUser.UserName;
            ERP_C006_ProcessFlow.Validate();
            var existstb_Sys_Menu = this.GetById(ERP_C006_ProcessFlow.Id);
            this.ERP_C006_ProcessFlowRepository.SetValues(ERP_C006_ProcessFlow, existstb_Sys_Menu);
            this.runtimeService.Commit();
        }

        public List<ERP_C006_ProcessFlow> GetList(PagingModel pagingModel, DateTime? beginDate, DateTime? endDate)
        {
            var q = this.ERP_C006_ProcessFlowRepository.GetMany(i => true);
			if (beginDate.HasValue)
            {
                beginDate = beginDate.Value.Date;
           	    q = q.Where(p => p.CreateDt >= beginDate);
            }
            if (endDate.HasValue)
            {
                endDate = endDate.Value.Date.AddDays(1);
                q = q.Where(p => p.CreateDt < endDate);
            }
            
            q = q.OrderByDescending(i => i.CreateDt);
            q = q.Paging(pagingModel);
            return q.ToList();
        }


        public List<InputItem> GetProcessFlowInputData()
        {
            var q = this.ERP_C006_ProcessFlowRepository.GetMany(i => true).ToList();
            var q2 = q.Select(i => new InputItem { DisPlayName = i.PFName, Value = i.PFCode, InputCode1 = i.PFCode, InputCode2 = Util.PinYin.GetCodstring(i.PFName) });
            return q2.ToList();
        }


        public List<ERP_C006_ProcessFlow_Process> GetProcessFlowDetail(string processFlowCode)
        {
            var q = this.processFlowDetailRepository.GetMany(i => i.PFCode == processFlowCode);
            return q.ToList();
        }


        public void MarkDelProcessFlowDetail(Guid id)
        {
            var existstb_Sys_Menu = processFlowDetailRepository.GetByID(id);
            this.processFlowDetailRepository.Delete(existstb_Sys_Menu);
        }


        public void Save(ERP_C006_ProcessFlow processFlow, List<ERP_C006_ProcessFlow_Process> processDetailList, List<ERP_C006_ProcessFlow_ProdInfo> prodInfoList)
        {
            tb_Sys_User tempUser = appCacheService.GetItem("user") as tb_Sys_User;
            var existstemp = this.GetById(processFlow.Id);
            if (existstemp == null)
            {
                processFlow.CompCode = tempUser.CompCode;
                processFlow.CreateDt = DateTime.Now;
                processFlow.CreateUser = tempUser.UserName;
                processFlow.Validate();
                this.ERP_C006_ProcessFlowRepository.Add(processFlow);
            }
            else
            {
                processFlow.ModifyDt = DateTime.Now;
                processFlow.ModifyUser = tempUser.UserName;
                processFlow.Validate();
                this.ERP_C006_ProcessFlowRepository.SetValues(processFlow, existstemp);
            }
            if (processDetailList != null)
            {
                string sql = string.Format("Delete ERP_C006_ProcessFlow_Process where PFCode = '{0}'", processFlow.PFCode);
                processFlowDetailRepository.GetDbContext().Database.ExecuteSqlCommand(sql);
                foreach (var processDetail in processDetailList)
                {
                    processDetail.PFCode = processFlow.PFCode;
                    processDetail.CompCode = tempUser.CompCode;
                    processDetail.CreateDt = DateTime.Now;
                    processDetail.CreateUser = tempUser.UserName;
                    processDetail.Validate();
                    this.processFlowDetailRepository.Add(processDetail);
                }
            }
            if (prodInfoList != null)
            {
                string sql = string.Format("Delete ERP_C006_ProcessFlow_ProdInfo where PFCode = '{0}'", processFlow.PFCode);
                prodInfoRepository.GetDbContext().Database.ExecuteSqlCommand(sql);
                foreach (var prodInfo in prodInfoList)
                {
                    prodInfo.PFCode = processFlow.PFCode;
                    prodInfo.CompCode = tempUser.CompCode;
                    prodInfo.Validate();
                    this.prodInfoRepository.Add(prodInfo);
                }
            }
            this.runtimeService.Commit();
        }
    }
}