using System;
using System.Linq;
using System.Collections.Generic;
using COM.Data;
using ERP.Data;
using ERP.Domain;
using COM.Service;
namespace ERP.Service
{
    public interface ICompanyService
    {
        ERP_C002_Company Gettb_C001_CompanyById(Guid Id);
        List<ERP_C002_Company> GetList();
        List<ERP_C002_Company> GetList(PagingModel pagingModel, DateTime? beginDate, DateTime? endDate);
        void Create(ERP_C002_Company tb_C001_Company);
        void Update(ERP_C002_Company tb_C001_Company);
        void Delete(Guid Id);
    }
    public class CompanyService : ICompanyService
    {
        private IDatabaseFactory dbfactory;
        private Itb_C001_CompanyRepository tb_C001_CompanyRepository;
        private IUnitOfWork runtimeService;
        private ICacheServiceBase appCacheService = Unity.Instance.GetService<ICacheServiceBase>();
        public CompanyService(IDatabaseFactory dbfactory)
        {
            this.dbfactory = dbfactory;
            this.runtimeService = new UnitOfWork(dbfactory);
            this.tb_C001_CompanyRepository = new tb_C001_CompanyRepository(dbfactory);
        }

        public List<ERP_C002_Company> GetList()
        {
            var q = this.tb_C001_CompanyRepository.GetMany(i => true);
            return q.ToList();
        }

        public ERP_C002_Company Gettb_C001_CompanyById(Guid Id)
        {
            return this.tb_C001_CompanyRepository.GetByID(Id);
        }

        public void Create(ERP_C002_Company tb_C001_Company)
        {
            tb_C001_Company.Validate();
            tb_C001_Company.CreateDt = DateTime.Now;
            tb_Sys_User tempUser = appCacheService.GetItem("user") as tb_Sys_User;
            tb_C001_Company.CreateUser = tempUser.UserName;
            this.tb_C001_CompanyRepository.Add(tb_C001_Company);
            this.runtimeService.Commit();
        }

        public void Delete(Guid Id)
        {
            var existstb_Sys_Menu = this.Gettb_C001_CompanyById(Id);
            this.tb_C001_CompanyRepository.Delete(existstb_Sys_Menu);
            this.runtimeService.Commit();
        }

        public void Update(ERP_C002_Company tb_C001_Company)
        {
            tb_C001_Company.ModifyDt = DateTime.Now;
            tb_Sys_User tempUser = appCacheService.GetItem("user") as tb_Sys_User;
            tb_C001_Company.ModifyUser = tempUser.UserName;
            tb_C001_Company.Validate();
            var existstb_Sys_Menu = this.Gettb_C001_CompanyById(tb_C001_Company.Id);
            this.tb_C001_CompanyRepository.SetValues(tb_C001_Company, existstb_Sys_Menu);
            this.runtimeService.Commit();
        }

        public List<ERP_C002_Company> GetList(PagingModel pagingModel, DateTime? beginDate, DateTime? endDate)
        {
            var q = this.tb_C001_CompanyRepository.GetMany(i => true);
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