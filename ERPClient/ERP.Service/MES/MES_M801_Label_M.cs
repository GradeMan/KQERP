using System;
using System.Linq;
using System.Collections.Generic;
using COM.Data;
using ERP.Data;
using ERP.Domain;
using COM.Service;
namespace ERP.Service
{
	public interface IMES_M801_Label_MService
	{
		MES_M801_Label_M GetById(Guid Id);
        List<MES_M801_Label_M> GetList();
		List<MES_M801_Label_M> GetList(PagingModel pagingModel, DateTime? beginDate, DateTime? endDate);
        void Create(MES_M801_Label_M MES_M801_Label_M);
        void Update(MES_M801_Label_M MES_M801_Label_M);
        void Delete(Guid Id);
	}
	public class MES_M801_Label_MService :IMES_M801_Label_MService
	{
		private IMES_M801_Label_MRepository MES_M801_Label_MRepository;
		private IUnitOfWork runtimeService;
		private ICacheServiceBase appCacheService = Unity.Instance.GetService<ICacheServiceBase>();
		public MES_M801_Label_MService(IDatabaseFactory dbfactory)
		{
			this.runtimeService = new UnitOfWork(dbfactory);
			this.MES_M801_Label_MRepository = new MES_M801_Label_MRepository(dbfactory);
		}

		public List<MES_M801_Label_M> GetList()
        {
            var q = this.MES_M801_Label_MRepository.GetMany(i => true);
            return q.ToList();
        }

        public MES_M801_Label_M GetById(Guid Id)
        {
            return this.MES_M801_Label_MRepository.GetByID(Id);
        }

        public void Create(MES_M801_Label_M MES_M801_Label_M)
        {
        	MES_M801_Label_M.CreateDt = DateTime.Now;
            tb_Sys_User tempUser = appCacheService.GetItem("user") as tb_Sys_User;
            MES_M801_Label_M.CreateUser = tempUser.UserName;
            MES_M801_Label_M.Validate();
			this.MES_M801_Label_MRepository.Add(MES_M801_Label_M);
            this.runtimeService.Commit();
        }

        public void Delete(Guid Id)
        {
            var existstb_Sys_Menu = this.GetById(Id);
            this.MES_M801_Label_MRepository.Delete(existstb_Sys_Menu);
            this.runtimeService.Commit();
        }

        public void Update(MES_M801_Label_M MES_M801_Label_M)
        {
        	MES_M801_Label_M.ModifyDt = DateTime.Now;
            tb_Sys_User tempUser = appCacheService.GetItem("user") as tb_Sys_User;
            MES_M801_Label_M.ModifyUser = tempUser.UserName;
            MES_M801_Label_M.Validate();
            var existstb_Sys_Menu = this.GetById(MES_M801_Label_M.Id);
            this.MES_M801_Label_MRepository.SetValues(MES_M801_Label_M, existstb_Sys_Menu);
            this.runtimeService.Commit();
        }

        public List<MES_M801_Label_M> GetList(PagingModel pagingModel, DateTime? beginDate, DateTime? endDate)
        {
            var q = this.MES_M801_Label_MRepository.GetMany(i => true);
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