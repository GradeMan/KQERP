using System;
using System.Linq;
using System.Collections.Generic;
using COM.Data;
using ERP.Data;
using ERP.Domain;
using COM.Service;
namespace ERP.Service
{
	public interface IFileRolesRightService
	{
		FTP_F003_RolesRight GetById(Guid Id);
        List<FTP_F003_RolesRight> GetList();
		List<FTP_F003_RolesRight> GetList(PagingModel pagingModel, DateTime? beginDate, DateTime? endDate);
        void Create(FTP_F003_RolesRight FTP_F003_RolesRight);
        void Update(FTP_F003_RolesRight FTP_F003_RolesRight);
        void Delete(Guid Id);
	}
    public class FileRolesRightService : IFileRolesRightService
	{
		private IFTP_F003_RolesRightRepository FTP_F003_RolesRightRepository;
		private IUnitOfWork runtimeService;
		private ICacheServiceBase appCacheService = Unity.Instance.GetService<ICacheServiceBase>();
        public FileRolesRightService(IDatabaseFactory dbfactory)
		{
			this.runtimeService = new UnitOfWork(dbfactory);
			this.FTP_F003_RolesRightRepository = new FTP_F003_RolesRightRepository(dbfactory);
		}

		public List<FTP_F003_RolesRight> GetList()
        {
            var q = this.FTP_F003_RolesRightRepository.GetMany(i => true);
            return q.ToList();
        }

        public FTP_F003_RolesRight GetById(Guid Id)
        {
            return this.FTP_F003_RolesRightRepository.GetByID(Id);
        }

        public void Create(FTP_F003_RolesRight FTP_F003_RolesRight)
        {
        	FTP_F003_RolesRight.CreateDt = DateTime.Now;
            tb_Sys_User tempUser = appCacheService.GetItem("user") as tb_Sys_User;
            FTP_F003_RolesRight.CreateUser = tempUser.UserName;
            FTP_F003_RolesRight.CompCode = tempUser.CompCode;
            FTP_F003_RolesRight.Validate();
			this.FTP_F003_RolesRightRepository.Add(FTP_F003_RolesRight);
            this.runtimeService.Commit();
        }

        public void Delete(Guid Id)
        {
            var existsTemp = this.GetById(Id);
            this.FTP_F003_RolesRightRepository.Delete(existsTemp);
            this.runtimeService.Commit();
        }

        public void Update(FTP_F003_RolesRight FTP_F003_RolesRight)
        {
        	FTP_F003_RolesRight.ModifyDt = DateTime.Now;
            tb_Sys_User tempUser = appCacheService.GetItem("user") as tb_Sys_User;
            FTP_F003_RolesRight.ModifyUser = tempUser.UserName;
            FTP_F003_RolesRight.Validate();
            var existstb_Sys_Menu = this.GetById(FTP_F003_RolesRight.Id);
            this.FTP_F003_RolesRightRepository.SetValues(FTP_F003_RolesRight, existstb_Sys_Menu);
            this.runtimeService.Commit();
        }

        public List<FTP_F003_RolesRight> GetList(PagingModel pagingModel, DateTime? beginDate, DateTime? endDate)
        {
            var q = this.FTP_F003_RolesRightRepository.GetMany(i => true);
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