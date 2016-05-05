using System;
using System.Linq;
using System.Collections.Generic;
using COM.Data;
using ERP.Data;
using ERP.Domain;
using COM.Service;
namespace ERP.Service
{
	public interface IERP_C001_CodeDictionaryService
	{
		ERP_C001_CodeDictionary GetById(Guid Id);
        List<ERP_C001_CodeDictionary> GetList();
        IQueryable<ERP_C001_CodeDictionary> GetQuery();
		List<ERP_C001_CodeDictionary> GetList(PagingModel pagingModel, DateTime? beginDate, DateTime? endDate);
        void Create(ERP_C001_CodeDictionary ERP_C001_CodeDictionary);
        void Update(ERP_C001_CodeDictionary ERP_C001_CodeDictionary);
        void Delete(Guid Id);
	}
	public class ERP_C001_CodeDictionaryService :IERP_C001_CodeDictionaryService
	{
		private IERP_C001_CodeDictionaryRepository ERP_C001_CodeDictionaryRepository;
		private IUnitOfWork runtimeService;
		private ICacheServiceBase appCacheService = Unity.Instance.GetService<ICacheServiceBase>();
		public ERP_C001_CodeDictionaryService(IDatabaseFactory dbfactory)
		{
			this.runtimeService = new UnitOfWork(dbfactory);
			this.ERP_C001_CodeDictionaryRepository = new ERP_C001_CodeDictionaryRepository(dbfactory);
		}

		public List<ERP_C001_CodeDictionary> GetList()
        {
            var q = this.ERP_C001_CodeDictionaryRepository.GetMany(i => true);
            return q.ToList();
        }
        
		public IQueryable<ERP_C001_CodeDictionary> GetQuery()
        {
            var q = this.ERP_C001_CodeDictionaryRepository.GetMany(i => true);
            return q;
        }
        
        public ERP_C001_CodeDictionary GetById(Guid Id)
        {
            return this.ERP_C001_CodeDictionaryRepository.GetByID(Id);
        }

        public void Create(ERP_C001_CodeDictionary ERP_C001_CodeDictionary)
        {
        	ERP_C001_CodeDictionary.CreateDt = DateTime.Now;
            tb_Sys_User tempUser = appCacheService.GetItem("user") as tb_Sys_User;
            ERP_C001_CodeDictionary.CreateUser = tempUser.UserName;
            ERP_C001_CodeDictionary.CompCode = tempUser.CompCode;
            ERP_C001_CodeDictionary.Validate();
			this.ERP_C001_CodeDictionaryRepository.Add(ERP_C001_CodeDictionary);
            this.runtimeService.Commit();
        }

        public void Delete(Guid Id)
        {
            var existstb_Sys_Menu = this.GetById(Id);
            this.ERP_C001_CodeDictionaryRepository.Delete(existstb_Sys_Menu);
            this.runtimeService.Commit();
        }

        public void Update(ERP_C001_CodeDictionary ERP_C001_CodeDictionary)
        {
        	ERP_C001_CodeDictionary.ModifyDt = DateTime.Now;
            tb_Sys_User tempUser = appCacheService.GetItem("user") as tb_Sys_User;
            ERP_C001_CodeDictionary.ModifyUser = tempUser.UserName;
            ERP_C001_CodeDictionary.Validate();
            var existstb_Sys_Menu = this.GetById(ERP_C001_CodeDictionary.Id);
            this.ERP_C001_CodeDictionaryRepository.SetValues(ERP_C001_CodeDictionary, existstb_Sys_Menu);
            this.runtimeService.Commit();
        }

        public List<ERP_C001_CodeDictionary> GetList(PagingModel pagingModel, DateTime? beginDate, DateTime? endDate)
        {
            var q = this.ERP_C001_CodeDictionaryRepository.GetMany(i => true);
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