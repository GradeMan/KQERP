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
	public interface IMES_M201_Plan_DetailService
	{
		MES_M201_Plan_Detail GetById(Guid Id);
        List<MES_M201_Plan_Detail> GetList();
        IQueryable<MES_M201_Plan_Detail> GetQuery();
		List<MES_M201_Plan_Detail> GetList(PagingModel pagingModel, DateTime? beginDate, DateTime? endDate);
        void Create(MES_M201_Plan_Detail MES_M201_Plan_Detail);
        void Update(MES_M201_Plan_Detail MES_M201_Plan_Detail);
        void Delete(Guid Id);
        List<InputItem> GetInputList();
	}
	public class MES_M201_Plan_DetailService :IMES_M201_Plan_DetailService
	{
		private IMES_M201_Plan_DetailRepository MES_M201_Plan_DetailRepository;
		private IUnitOfWork runtimeService;
		private ICacheServiceBase appCacheService = Unity.Instance.GetService<ICacheServiceBase>();
		public MES_M201_Plan_DetailService(IDatabaseFactory dbfactory)
		{
			this.runtimeService = new UnitOfWork(dbfactory);
			this.MES_M201_Plan_DetailRepository = new MES_M201_Plan_DetailRepository(dbfactory);
		}
        public List<InputItem> GetInputList()
        {
            var list = this.MES_M201_Plan_DetailRepository.GetMany(i=>true).Select(a => new { a.PLNo, a.PartNo, a.PartName, a.CustCode, a.SONo, a.SumQty,a.Id,a.FQty }).ToList().Select(a => new InputItem() { DisPlayName = a.PLNo, Value = a.Id.ToString(), InputCode1 = a.SONo, InputCode2 = a.PartNo, InputCode3 = a.PartName, InputCode4 = a.SumQty.ToString("00"),InputCode5 = a.FQty.ToString("00") }).OrderBy(a=>a.Value).ToList();
            return list;
        }
		public List<MES_M201_Plan_Detail> GetList()
        {
            var q = this.MES_M201_Plan_DetailRepository.GetMany(i => true);
            return q.ToList();
        }
        
		public IQueryable<MES_M201_Plan_Detail> GetQuery()
        {
            var q = this.MES_M201_Plan_DetailRepository.GetMany(i => true);
            return q;
        }
        
        public MES_M201_Plan_Detail GetById(Guid Id)
        {
            return this.MES_M201_Plan_DetailRepository.GetByID(Id);
        }

        public void Create(MES_M201_Plan_Detail MES_M201_Plan_Detail)
        {
        	MES_M201_Plan_Detail.CreateDt = DateTime.Now;
            tb_Sys_User tempUser = appCacheService.GetItem("user") as tb_Sys_User;
            MES_M201_Plan_Detail.CreateUser = tempUser.UserName;
            MES_M201_Plan_Detail.Validate();
			this.MES_M201_Plan_DetailRepository.Add(MES_M201_Plan_Detail);
            this.runtimeService.Commit();
        }

        public void Delete(Guid Id)
        {
            var existstb_Sys_Menu = this.GetById(Id);
            this.MES_M201_Plan_DetailRepository.Delete(existstb_Sys_Menu);
            this.runtimeService.Commit();
        }

        public void Update(MES_M201_Plan_Detail MES_M201_Plan_Detail)
        {
        	MES_M201_Plan_Detail.ModifyDt = DateTime.Now;
            tb_Sys_User tempUser = appCacheService.GetItem("user") as tb_Sys_User;
            MES_M201_Plan_Detail.ModifyUser = tempUser.UserName;
            MES_M201_Plan_Detail.Validate();
            var existstb_Sys_Menu = this.GetById(MES_M201_Plan_Detail.Id);
            this.MES_M201_Plan_DetailRepository.SetValues(MES_M201_Plan_Detail, existstb_Sys_Menu);
            this.runtimeService.Commit();
        }

        public List<MES_M201_Plan_Detail> GetList(PagingModel pagingModel, DateTime? beginDate, DateTime? endDate)
        {
            var q = this.MES_M201_Plan_DetailRepository.GetMany(i => true);
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