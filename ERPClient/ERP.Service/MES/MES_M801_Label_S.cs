using System;
using System.Linq;
using System.Collections.Generic;
using COM.Data;
using ERP.Data;
using ERP.Domain;
using COM.Service;
namespace ERP.Service
{
	public interface IMES_M801_Label_SService
	{
		MES_M801_Label_S GetById(Guid Id);
        List<MES_M801_Label_S> GetList();
		List<MES_M801_Label_S> GetList(PagingModel pagingModel, DateTime? beginDate, DateTime? endDate);
        void Create(MES_M801_Label_S MES_M801_Label_S);
        void Update(MES_M801_Label_S MES_M801_Label_S);
        void Delete(Guid Id);
        IQueryable<MES_M801_Label_S> GetLabelSQuery();
        List<MES_M801_Label_S> GetListBySql(string Sql);//CustCode->客户,PartNo->产品，LotNo->
       
	}
	public class MES_M801_Label_SService :IMES_M801_Label_SService
	{
		private IMES_M801_Label_SRepository MES_M801_Label_SRepository;
		private IUnitOfWork runtimeService;
		private ICacheServiceBase appCacheService = Unity.Instance.GetService<ICacheServiceBase>();
		public MES_M801_Label_SService(IDatabaseFactory dbfactory)
		{
			this.runtimeService = new UnitOfWork(dbfactory);
			this.MES_M801_Label_SRepository = new MES_M801_Label_SRepository(dbfactory);
		}
        public IQueryable<MES_M801_Label_S> GetLabelSQuery()
        {
           return this.MES_M801_Label_SRepository.GetMany(i => true);
        }

        public List<MES_M801_Label_S> GetListBySql(string Sql)
        {
            return this.MES_M801_Label_SRepository.GetDbContext().Database.SqlQuery<MES_M801_Label_S>(Sql).ToList();
        }
		public List<MES_M801_Label_S> GetList()
        {
            var q = this.MES_M801_Label_SRepository.GetMany(i => true);
            return q.ToList();
        }

        public MES_M801_Label_S GetById(Guid Id)
        {
            return this.MES_M801_Label_SRepository.GetByID(Id);
        }

        public void Create(MES_M801_Label_S MES_M801_Label_S)
        {
            tb_Sys_User tempUser = appCacheService.GetItem("user") as tb_Sys_User;
            MES_M801_Label_S.Validate();
			this.MES_M801_Label_SRepository.Add(MES_M801_Label_S);
            this.runtimeService.Commit();
        }

        public void Delete(Guid Id)
        {
            var existstb_Sys_Menu = this.GetById(Id);
            this.MES_M801_Label_SRepository.Delete(existstb_Sys_Menu);
            this.runtimeService.Commit();
        }

        public void Update(MES_M801_Label_S MES_M801_Label_S)
        {
            tb_Sys_User tempUser = appCacheService.GetItem("user") as tb_Sys_User;
            MES_M801_Label_S.Validate();
            var existstb_Sys_Menu = this.GetById(MES_M801_Label_S.Id);
            this.MES_M801_Label_SRepository.SetValues(MES_M801_Label_S, existstb_Sys_Menu);
            this.runtimeService.Commit();
        }

        public List<MES_M801_Label_S> GetList(PagingModel pagingModel, DateTime? beginDate, DateTime? endDate)
        {
            var q = this.MES_M801_Label_SRepository.GetMany(i => true);
            q = q.Paging(pagingModel);
            return q.ToList();
        }
	}
}