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
	public interface IERP_M001_Product_PackInfoService
	{
		ERP_M001_Product_PackInfo GetById(Guid Id);
        List<ERP_M001_Product_PackInfo> GetList();
		List<ERP_M001_Product_PackInfo> GetList(PagingModel pagingModel, DateTime? beginDate, DateTime? endDate);
        void Create(ERP_M001_Product_PackInfo ERP_M001_Product_PackInfo);
        void Update(ERP_M001_Product_PackInfo ERP_M001_Product_PackInfo);
        void Delete(Guid Id);
        List<InputItem> GetProductInputDataByCustCode(string CustCode);
        ERP_M001_Product_PackInfo GetPackInfo(string custCode, string lbpartNo);
        IQueryable<ERP_M001_Product_PackInfo> GetPackInfoQuery();
	}
	public class ERP_M001_Product_PackInfoService :IERP_M001_Product_PackInfoService
	{
		private IERP_M001_Product_PackInfoRepository ERP_M001_Product_PackInfoRepository;
		private IUnitOfWork runtimeService;
		private ICacheServiceBase appCacheService = Unity.Instance.GetService<ICacheServiceBase>();
		public ERP_M001_Product_PackInfoService(IDatabaseFactory dbfactory)
		{
			this.runtimeService = new UnitOfWork(dbfactory);
			this.ERP_M001_Product_PackInfoRepository = new ERP_M001_Product_PackInfoRepository(dbfactory);
		}
        public IQueryable<ERP_M001_Product_PackInfo> GetPackInfoQuery()
        {
            return this.ERP_M001_Product_PackInfoRepository.GetMany(i => true);
        }
        public ERP_M001_Product_PackInfo GetPackInfo(string custCode, string lbpartNo)
        {
            var q = this.ERP_M001_Product_PackInfoRepository.GetMany(i => true);
            if (!string.IsNullOrWhiteSpace(custCode))
                q = q.Where(a => a.CustCode == custCode);
            if (!string.IsNullOrWhiteSpace(lbpartNo))
                q = q.Where(a => a.LBPartNo == lbpartNo);
            try
            {
                return q.Single();
            }
            catch
            {
                throw new Exception("产品包装资料有错误，请联系工程部");
            }
        }
        public List<InputItem> GetProductInputDataByCustCode(string CustCode)
        {
            var q = this.ERP_M001_Product_PackInfoRepository.GetMany(i => true).Select(a => new { a.LBPartNo,a.LBPartName,a.PartNo, a.PartName, a.CustCode,a.PartType });
            if(!string.IsNullOrWhiteSpace(CustCode))
                q = q.Where(a=>a.CustCode == CustCode);
            var q2 = q.ToList().Select(i => new InputItem { DisPlayName = i.LBPartName, Value = i.LBPartNo, InputCode1 = i.LBPartNo, InputCode2 = i.PartNo,InputCode3 = i.PartName,InputCode4 = i.PartType });
            return q2.ToList();
        }
		public List<ERP_M001_Product_PackInfo> GetList()
        {
            var q = this.ERP_M001_Product_PackInfoRepository.GetMany(i => true);
            return q.ToList();
        }

        public ERP_M001_Product_PackInfo GetById(Guid Id)
        {
            return this.ERP_M001_Product_PackInfoRepository.GetByID(Id);
        }

        public void Create(ERP_M001_Product_PackInfo ERP_M001_Product_PackInfo)
        {
        	ERP_M001_Product_PackInfo.CreateDt = DateTime.Now;
            tb_Sys_User tempUser = appCacheService.GetItem("user") as tb_Sys_User;
            ERP_M001_Product_PackInfo.CreateUser = tempUser.UserName;
            ERP_M001_Product_PackInfo.Validate();
			this.ERP_M001_Product_PackInfoRepository.Add(ERP_M001_Product_PackInfo);
            this.runtimeService.Commit();
        }

        public void Delete(Guid Id)
        {
            var existstb_Sys_Menu = this.GetById(Id);
            this.ERP_M001_Product_PackInfoRepository.Delete(existstb_Sys_Menu);
            this.runtimeService.Commit();
        }

        public void Update(ERP_M001_Product_PackInfo ERP_M001_Product_PackInfo)
        {
        	ERP_M001_Product_PackInfo.ModifyDt = DateTime.Now;
            tb_Sys_User tempUser = appCacheService.GetItem("user") as tb_Sys_User;
            ERP_M001_Product_PackInfo.ModifyUser = tempUser.UserName;
            ERP_M001_Product_PackInfo.Validate();
            var existstb_Sys_Menu = this.GetById(ERP_M001_Product_PackInfo.Id);
            this.ERP_M001_Product_PackInfoRepository.SetValues(ERP_M001_Product_PackInfo, existstb_Sys_Menu);
            this.runtimeService.Commit();
        }

        public List<ERP_M001_Product_PackInfo> GetList(PagingModel pagingModel, DateTime? beginDate, DateTime? endDate)
        {
            var q = this.ERP_M001_Product_PackInfoRepository.GetMany(i => true);
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
	}
}