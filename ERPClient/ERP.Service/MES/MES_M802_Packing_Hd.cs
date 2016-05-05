using System;
using System.Linq;
using System.Collections.Generic;
using COM.Data;
using ERP.Data;
using ERP.Domain;
using COM.Service;
using System.Data.Entity;
namespace ERP.Service
{
	public interface IMES_M802_Packing_HdService
	{
		MES_M802_Packing_Hd GetById(Guid Id);
        List<MES_M802_Packing_Hd> GetList();
		List<MES_M802_Packing_Hd> GetList(PagingModel pagingModel, DateTime? beginDate, DateTime? endDate);
        void Create(MES_M802_Packing_Hd MES_M802_Packing_Hd);
        void Update(MES_M802_Packing_Hd MES_M802_Packing_Hd);
        void Delete(Guid Id);
        IQueryable<MES_M802_Packing_Hd> GetPackingHdQuery();
        void Save(MES_M802_Packing_Hd packingHd, List<MES_M802_Packing_Dtl> packingDtlLst);
        
	}
	public class MES_M802_Packing_HdService :IMES_M802_Packing_HdService
	{
		private IMES_M802_Packing_HdRepository MES_M802_Packing_HdRepository;
        private IMES_M802_Packing_DtlRepository packingDtlRepository;
		private IUnitOfWork runtimeService;
		private ICacheServiceBase appCacheService = Unity.Instance.GetService<ICacheServiceBase>();
		public MES_M802_Packing_HdService(IDatabaseFactory dbfactory)
		{
			this.runtimeService = new UnitOfWork(dbfactory);
			this.MES_M802_Packing_HdRepository = new MES_M802_Packing_HdRepository(dbfactory);
            packingDtlRepository = new MES_M802_Packing_DtlRepository(dbfactory);
		}
        public void Save(MES_M802_Packing_Hd packingHd, List<MES_M802_Packing_Dtl> packingDtlLst)
        {
            packingHd.CreateDt = DateTime.Now;
            tb_Sys_User tempUser = appCacheService.GetItem("user") as tb_Sys_User;
            packingHd.CreateUser = tempUser.UserName;
            packingHd.CompCode = tempUser.CompCode;
            packingHd.Validate();
            this.MES_M802_Packing_HdRepository.Add(packingHd);
            foreach (var packingDtl in packingDtlLst)
            {
                packingDtl.CreateDt = DateTime.Now;
                packingDtl.CreateUser = tempUser.UserName;
                packingDtl.CompCode = tempUser.CompCode;
                packingDtl.Validate();
                this.packingDtlRepository.Add(packingDtl);
            }
            this.runtimeService.Commit();
        }
        public IQueryable<MES_M802_Packing_Hd> GetPackingHdQuery()
        {
            return this.MES_M802_Packing_HdRepository.GetMany(i => true);
        }
		public List<MES_M802_Packing_Hd> GetList()
        {
            var q = this.MES_M802_Packing_HdRepository.GetMany(i => true);
            return q.ToList();
        }

        public MES_M802_Packing_Hd GetById(Guid Id)
        {
            return this.MES_M802_Packing_HdRepository.GetByID(Id);
        }

        public void Create(MES_M802_Packing_Hd MES_M802_Packing_Hd)
        {
        	MES_M802_Packing_Hd.CreateDt = DateTime.Now;
            tb_Sys_User tempUser = appCacheService.GetItem("user") as tb_Sys_User;
            MES_M802_Packing_Hd.CreateUser = tempUser.UserName;
            MES_M802_Packing_Hd.Validate();
			this.MES_M802_Packing_HdRepository.Add(MES_M802_Packing_Hd);
            this.runtimeService.Commit();
        }

        public void Delete(Guid Id)
        {
            var existstb_Sys_Menu = this.GetById(Id);
            this.MES_M802_Packing_HdRepository.Delete(existstb_Sys_Menu);
            this.runtimeService.Commit();
        }

        public void Update(MES_M802_Packing_Hd MES_M802_Packing_Hd)
        {
        	MES_M802_Packing_Hd.ModifyDt = DateTime.Now;
            tb_Sys_User tempUser = appCacheService.GetItem("user") as tb_Sys_User;
            MES_M802_Packing_Hd.ModifyUser = tempUser.UserName;
            MES_M802_Packing_Hd.Validate();
            var existstb_Sys_Menu = this.GetById(MES_M802_Packing_Hd.Id);
            this.MES_M802_Packing_HdRepository.SetValues(MES_M802_Packing_Hd, existstb_Sys_Menu);
            this.runtimeService.Commit();
        }

        public List<MES_M802_Packing_Hd> GetList(PagingModel pagingModel, DateTime? beginDate, DateTime? endDate)
        {
            var q = this.MES_M802_Packing_HdRepository.GetMany(i => true);
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