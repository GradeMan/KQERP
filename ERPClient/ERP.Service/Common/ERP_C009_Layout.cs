using System;
using System.Linq;
using System.Collections.Generic;
using COM.Data;
using ERP.Data;
using ERP.Domain;
using COM.Service;
namespace ERP.Service
{
	public interface IERP_C009_LayoutService
	{
		ERP_C009_Layout GetById(Guid Id);
        List<ERP_C009_Layout> GetList();
		List<ERP_C009_Layout> GetList(PagingModel pagingModel, DateTime? beginDate, DateTime? endDate);
        void Create(ERP_C009_Layout ERP_C009_Layout);
        void Update(ERP_C009_Layout ERP_C009_Layout);
        void Delete(Guid Id);
        ERP_C009_Layout GetByType(string frmType, string layType);
	}
	public class ERP_C009_LayoutService :IERP_C009_LayoutService
	{
		private IERP_C009_LayoutRepository ERP_C009_LayoutRepository;
		private IUnitOfWork runtimeService;
		private ICacheServiceBase appCacheService = Unity.Instance.GetService<ICacheServiceBase>();
		public ERP_C009_LayoutService(IDatabaseFactory dbfactory)
		{
			this.runtimeService = new UnitOfWork(dbfactory);
			this.ERP_C009_LayoutRepository = new ERP_C009_LayoutRepository(dbfactory);
		}
        public ERP_C009_Layout GetByType(string frmType, string layType)
        {
            var q = this.ERP_C009_LayoutRepository.GetMany(i => i.FrmType == frmType && i.LayType == layType).FirstOrDefault();
            return q;
        }
		public List<ERP_C009_Layout> GetList()
        {
            var q = this.ERP_C009_LayoutRepository.GetMany(i => true);
            return q.ToList();
        }

        public ERP_C009_Layout GetById(Guid Id)
        {
            return this.ERP_C009_LayoutRepository.GetByID(Id);
        }

        public void Create(ERP_C009_Layout ERP_C009_Layout)
        {
            ERP_C009_Layout.Validate();
			this.ERP_C009_LayoutRepository.Add(ERP_C009_Layout);
            this.runtimeService.Commit();
        }

        public void Delete(Guid Id)
        {
            var existstb_Sys_Menu = this.GetById(Id);
            this.ERP_C009_LayoutRepository.Delete(existstb_Sys_Menu);
            this.runtimeService.Commit();
        }

        public void Update(ERP_C009_Layout ERP_C009_Layout)
        {
        	
            ERP_C009_Layout.Validate();
            var existstb_Sys_Menu = this.GetById(ERP_C009_Layout.Id);
            //existstb_Sys_Menu.LayFiles = ERP_C009_Layout.LayFiles;
            this.ERP_C009_LayoutRepository.SetValues(ERP_C009_Layout, existstb_Sys_Menu);
            this.runtimeService.Commit();
        }

        public List<ERP_C009_Layout> GetList(PagingModel pagingModel, DateTime? beginDate, DateTime? endDate)
        {
            var q = this.ERP_C009_LayoutRepository.GetMany(i => true);
            return q.ToList();
        }
	}
}