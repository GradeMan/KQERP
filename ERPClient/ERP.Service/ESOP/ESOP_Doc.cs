using System;
using System.Linq;
using System.Collections.Generic;
using COM.Data;
using ERP.Data;
using ERP.Domain;
using COM.Service;
namespace ERP.Service
{
	public interface IESOP_DocService
	{
		ESOP_Doc GetById(Guid Id);
        List<ESOP_Doc> GetList();
		List<ESOP_Doc> GetList(PagingModel pagingModel, DateTime? beginDate, DateTime? endDate);
        void Create(ESOP_Doc ESOP_Doc);
        void Update(ESOP_Doc ESOP_Doc);
        void Delete(Guid Id);
        List<ESOP_Doc> GetDocByDocIndex(Guid DocIndex);
        void Save(ESOP_Doc ESOP_Doc);
        IQueryable<ESOP_Doc> GetDoc();
	}
	public class ESOP_DocService :IESOP_DocService
	{
		private IESOP_DocRepository ESOP_DocRepository;
        private IESOP_DocIndexRepository docIndexRepository;
		private IUnitOfWork runtimeService;
		private ICacheServiceBase appCacheService = Unity.Instance.GetService<ICacheServiceBase>();
		public ESOP_DocService(IDatabaseFactory dbfactory)
		{
			this.runtimeService = new UnitOfWork(dbfactory);
			this.ESOP_DocRepository = new ESOP_DocRepository(dbfactory);
            this.docIndexRepository = new ESOP_DocIndexRepository(dbfactory);
		}
        public IQueryable<ESOP_Doc> GetDoc()
        {
            return ESOP_DocRepository.GetMany(i => true);
        }
        public void Save(ESOP_Doc ESOP_Doc)
        {
            tb_Sys_User tempUser = appCacheService.GetItem("user") as tb_Sys_User;

            var existsdevice = this.GetById(ESOP_Doc.Id);
            if (existsdevice == null)
            {
                ESOP_Doc.CompCode = tempUser.CompCode;
                ESOP_Doc.CreateDt = DateTime.Now;
                ESOP_Doc.CreateUser = tempUser.UserName;
                ESOP_Doc.Validate();
                this.ESOP_DocRepository.Add(ESOP_Doc);
            }
            else
            {
                ESOP_Doc.ModifyDt = DateTime.Now;
                ESOP_Doc.ModifyUser = tempUser.UserName;
                ESOP_Doc.Validate();
                this.ESOP_DocRepository.SetValues(ESOP_Doc, existsdevice);
            }

            this.runtimeService.Commit();
        }
        public List<ESOP_Doc> GetDocByDocIndex(Guid DocIndex)
        {
            return this.ESOP_DocRepository.GetMany(a => a.DocIndexId == DocIndex).ToList();
        }

		public List<ESOP_Doc> GetList()
        {
            var q = this.ESOP_DocRepository.GetMany(i => true);
            return q.ToList();
        }

        public ESOP_Doc GetById(Guid Id)
        {
            return this.ESOP_DocRepository.GetByID(Id);
        }

        public void Create(ESOP_Doc ESOP_Doc)
        {
        	ESOP_Doc.CreateDt = DateTime.Now;
            tb_Sys_User tempUser = appCacheService.GetItem("user") as tb_Sys_User;
            ESOP_Doc.CreateUser = tempUser.UserName;
            ESOP_Doc.Validate();
			this.ESOP_DocRepository.Add(ESOP_Doc);
            this.runtimeService.Commit();
        }

        public void Delete(Guid Id)
        {
            var existstb_Sys_Menu = this.GetById(Id);
            this.ESOP_DocRepository.Delete(existstb_Sys_Menu);
            this.runtimeService.Commit();
        }

        public void Update(ESOP_Doc ESOP_Doc)
        {
        	ESOP_Doc.ModifyDt = DateTime.Now;
            tb_Sys_User tempUser = appCacheService.GetItem("user") as tb_Sys_User;
            ESOP_Doc.ModifyUser = tempUser.UserName;
            ESOP_Doc.Validate();
            var existstb_Sys_Menu = this.GetById(ESOP_Doc.Id);
            this.ESOP_DocRepository.SetValues(ESOP_Doc, existstb_Sys_Menu);
            this.runtimeService.Commit();
        }

        public List<ESOP_Doc> GetList(PagingModel pagingModel, DateTime? beginDate, DateTime? endDate)
        {
            var q = this.ESOP_DocRepository.GetMany(i => true);
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