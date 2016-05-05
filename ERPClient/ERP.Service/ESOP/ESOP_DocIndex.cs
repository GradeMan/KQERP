using System;
using System.Linq;
using System.Collections.Generic;
using COM.Data;
using ERP.Data;
using ERP.Domain;
using COM.Service;
namespace ERP.Service
{
	public interface IESOP_DocIndexService
	{
		ESOP_DocIndex GetById(Guid Id);
        List<ESOP_DocIndex> GetList();
		List<ESOP_DocIndex> GetList(PagingModel pagingModel, DateTime? beginDate, DateTime? endDate);
        void Create(ESOP_DocIndex ESOP_DocIndex);
        void Update(ESOP_DocIndex ESOP_DocIndex);
        void Delete(Guid Id);
        IQueryable<ESOP_DocIndex_Sec> GetDocIndexSec();
        IQueryable<ESOP_DocIndex> GetDocIndex();
        void Save(ESOP_DocIndex docIndex);
	}
	public class ESOP_DocIndexService :IESOP_DocIndexService
	{
		private IESOP_DocIndexRepository ESOP_DocIndexRepository;
        private IESOP_DocIndex_SecRepository docIndexSecRepository;
		private IUnitOfWork runtimeService;
		private ICacheServiceBase appCacheService = Unity.Instance.GetService<ICacheServiceBase>();
		public ESOP_DocIndexService(IDatabaseFactory dbfactory)
		{
			this.runtimeService = new UnitOfWork(dbfactory);
			this.ESOP_DocIndexRepository = new ESOP_DocIndexRepository(dbfactory);
            this.docIndexSecRepository = new ESOP_DocIndex_SecRepository(dbfactory);
		}
        public IQueryable<ESOP_DocIndex> GetDocIndex()
        {
            return this.ESOP_DocIndexRepository.GetMany(i => true);
        }

        public IQueryable<ESOP_DocIndex_Sec> GetDocIndexSec()
        {
            return this.docIndexSecRepository.GetMany(i => true);
        }
		public List<ESOP_DocIndex> GetList()
        {
            var q = this.ESOP_DocIndexRepository.GetMany(i => true);
            return q.ToList();
        }

        public ESOP_DocIndex GetById(Guid Id)
        {
            return this.ESOP_DocIndexRepository.GetByID(Id);
        }

        public void Create(ESOP_DocIndex ESOP_DocIndex)
        {
        	ESOP_DocIndex.CreateDt = DateTime.Now;
            tb_Sys_User tempUser = appCacheService.GetItem("user") as tb_Sys_User;
            ESOP_DocIndex.CreateUser = tempUser.UserName;
            ESOP_DocIndex.Validate();
			this.ESOP_DocIndexRepository.Add(ESOP_DocIndex);
            this.runtimeService.Commit();
        }

        public void Delete(Guid Id)
        {
            var existstb_Sys_Menu = this.GetById(Id);
            this.ESOP_DocIndexRepository.Delete(existstb_Sys_Menu);
            this.runtimeService.Commit();
        }

        public void Update(ESOP_DocIndex ESOP_DocIndex)
        {
        	ESOP_DocIndex.ModifyDt = DateTime.Now;
            tb_Sys_User tempUser = appCacheService.GetItem("user") as tb_Sys_User;
            ESOP_DocIndex.ModifyUser = tempUser.UserName;
            ESOP_DocIndex.Validate();
            var existstb_Sys_Menu = this.GetById(ESOP_DocIndex.Id);
            this.ESOP_DocIndexRepository.SetValues(ESOP_DocIndex, existstb_Sys_Menu);
            this.runtimeService.Commit();
        }

        public List<ESOP_DocIndex> GetList(PagingModel pagingModel, DateTime? beginDate, DateTime? endDate)
        {
            var q = this.ESOP_DocIndexRepository.GetMany(i => true);
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


        public void Save(ESOP_DocIndex docIndex)
        {
            tb_Sys_User tempUser = appCacheService.GetItem("user") as tb_Sys_User;

            var existsdevice = this.GetById(docIndex.Id);
            if (existsdevice == null)
            {
                docIndex.CompCode = tempUser.CompCode;
                docIndex.CreateDt = DateTime.Now;
                docIndex.CreateUser = tempUser.UserName;
                docIndex.Validate();
                this.ESOP_DocIndexRepository.Add(docIndex);
            }
            else
            {
                docIndex.ModifyDt = DateTime.Now;
                docIndex.ModifyUser = tempUser.UserName;
                docIndex.Validate();
                this.ESOP_DocIndexRepository.SetValues(docIndex, existsdevice);
            }

            this.runtimeService.Commit();
        }
    }
}