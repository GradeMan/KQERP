using System;
using System.Linq;
using System.Collections.Generic;
using COM.Data;
using ERP.Data;
using ERP.Domain;
using COM.Service;
namespace ERP.Service
{
	public interface IMES_M802_Packing_DtlService
	{
		MES_M802_Packing_Dtl GetById(Guid Id);
        List<MES_M802_Packing_Dtl> GetList();
		List<MES_M802_Packing_Dtl> GetList(PagingModel pagingModel, DateTime? beginDate, DateTime? endDate);
        void Create(MES_M802_Packing_Dtl MES_M802_Packing_Dtl);
        void Update(MES_M802_Packing_Dtl MES_M802_Packing_Dtl);
        void Delete(Guid Id);
	}
	public class MES_M802_Packing_DtlService :IMES_M802_Packing_DtlService
	{
		private IMES_M802_Packing_DtlRepository MES_M802_Packing_DtlRepository;
		private IUnitOfWork runtimeService;
		private ICacheServiceBase appCacheService = Unity.Instance.GetService<ICacheServiceBase>();
		public MES_M802_Packing_DtlService(IDatabaseFactory dbfactory)
		{
			this.runtimeService = new UnitOfWork(dbfactory);
			this.MES_M802_Packing_DtlRepository = new MES_M802_Packing_DtlRepository(dbfactory);
		}

		public List<MES_M802_Packing_Dtl> GetList()
        {
            var q = this.MES_M802_Packing_DtlRepository.GetMany(i => true);
            return q.ToList();
        }

        public MES_M802_Packing_Dtl GetById(Guid Id)
        {
            return this.MES_M802_Packing_DtlRepository.GetByID(Id);
        }

        public void Create(MES_M802_Packing_Dtl MES_M802_Packing_Dtl)
        {
        	MES_M802_Packing_Dtl.CreateDt = DateTime.Now;
            tb_Sys_User tempUser = appCacheService.GetItem("user") as tb_Sys_User;
            MES_M802_Packing_Dtl.CreateUser = tempUser.UserName;
            MES_M802_Packing_Dtl.Validate();
			this.MES_M802_Packing_DtlRepository.Add(MES_M802_Packing_Dtl);
            this.runtimeService.Commit();
        }

        public void Delete(Guid Id)
        {
            var existstb_Sys_Menu = this.GetById(Id);
            this.MES_M802_Packing_DtlRepository.Delete(existstb_Sys_Menu);
            this.runtimeService.Commit();
        }

        public void Update(MES_M802_Packing_Dtl MES_M802_Packing_Dtl)
        {
        	MES_M802_Packing_Dtl.ModifyDt = DateTime.Now;
            tb_Sys_User tempUser = appCacheService.GetItem("user") as tb_Sys_User;
            MES_M802_Packing_Dtl.ModifyUser = tempUser.UserName;
            MES_M802_Packing_Dtl.Validate();
            var existstb_Sys_Menu = this.GetById(MES_M802_Packing_Dtl.Id);
            this.MES_M802_Packing_DtlRepository.SetValues(MES_M802_Packing_Dtl, existstb_Sys_Menu);
            this.runtimeService.Commit();
        }

        public List<MES_M802_Packing_Dtl> GetList(PagingModel pagingModel, DateTime? beginDate, DateTime? endDate)
        {
            var q = this.MES_M802_Packing_DtlRepository.GetMany(i => true);
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