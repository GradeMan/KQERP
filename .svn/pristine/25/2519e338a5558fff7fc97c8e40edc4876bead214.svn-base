using System;
using System.Linq;
using System.Collections.Generic;
using COM.Data;
using ERP.Data;
using ERP.Domain;
using COM.Service;
namespace ERP.Service
{
	public interface IFileService
	{
		FTP_F002_File GetById(Guid Id);
        List<FTP_F002_File> GetList();
		List<FTP_F002_File> GetList(PagingModel pagingModel, DateTime? beginDate, DateTime? endDate);
        void Create(FTP_F002_File FTP_F002_File);
        void Update(FTP_F002_File FTP_F002_File);
        void Delete(Guid Id);
        List<FTP_F002_File> GetListWithRole(string path);
	}
    public class FileService : IFileService
	{
		private IFTP_F002_FileRepository FTP_F002_FileRepository;
        private IFTP_F003_RolesRightRepository fileRoleRightRepository;
		private IUnitOfWork runtimeService;
		private ICacheServiceBase appCacheService = Unity.Instance.GetService<ICacheServiceBase>();
        public FileService(IDatabaseFactory dbfactory)
		{
			this.runtimeService = new UnitOfWork(dbfactory);
			this.FTP_F002_FileRepository = new FTP_F002_FileRepository(dbfactory);
            fileRoleRightRepository = new FTP_F003_RolesRightRepository(dbfactory);
		}

		public List<FTP_F002_File> GetList()
        {
            var q = this.FTP_F002_FileRepository.GetMany(i => true);
            return q.ToList();
        }

        public FTP_F002_File GetById(Guid Id)
        {
            return this.FTP_F002_FileRepository.GetByID(Id);
        }

        public void Create(FTP_F002_File FTP_F002_File)
        {
        	FTP_F002_File.CreateDt = DateTime.Now;
            tb_Sys_User tempUser = appCacheService.GetItem("user") as tb_Sys_User;
            FTP_F002_File.CreateUser = tempUser.UserName;
            FTP_F002_File.CompCode = tempUser.CompCode;
            FTP_F002_File.Validate();
			this.FTP_F002_FileRepository.Add(FTP_F002_File);
            if (FTP_F002_File.Extension == "Dir")
            {
                var role = appCacheService.GetItem("roles") as tb_Sys_Roles;
                FTP_F003_RolesRight roleright = new FTP_F003_RolesRight();
                roleright.RoleId = role.Id;
                roleright.DirId = FTP_F002_File.Id;
                roleright.CompCode = tempUser.CompCode;
                roleright.CreateUser = tempUser.UserName;
                roleright.CreateDt = DateTime.Now;
                this.fileRoleRightRepository.Add(roleright);
            }
            this.runtimeService.Commit();
        }

        public void Delete(Guid Id)
        {
            var existsTemp = this.GetById(Id);
            this.FTP_F002_FileRepository.Delete(existsTemp);
            this.runtimeService.Commit();
        }

        public void Update(FTP_F002_File FTP_F002_File)
        {
        	FTP_F002_File.ModifyDt = DateTime.Now;
            tb_Sys_User tempUser = appCacheService.GetItem("user") as tb_Sys_User;
            FTP_F002_File.ModifyUser = tempUser.UserName;
            FTP_F002_File.Validate();
            var existstb_Sys_Menu = this.GetById(FTP_F002_File.Id);
            this.FTP_F002_FileRepository.SetValues(FTP_F002_File, existstb_Sys_Menu);
            this.runtimeService.Commit();
        }

        public List<FTP_F002_File> GetList(PagingModel pagingModel, DateTime? beginDate, DateTime? endDate)
        {
            var q = this.FTP_F002_FileRepository.GetMany(i => true);
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


        public List<FTP_F002_File> GetListWithRole(string path)
        {
            var role = appCacheService.GetItem("roles") as tb_Sys_Roles;
            var q1 = this.FTP_F002_FileRepository.GetMany(i => i.Extension !="Dir" && i.Path ==path);//文件

            var DirIdList = this.fileRoleRightRepository.GetMany(i => i.RoleId == role.Id).Select(i => i.DirId).ToList();

            var q2 = this.FTP_F002_FileRepository.GetMany(i => i.Path == path && DirIdList.Contains(i.Id));

            var q = q1.Union(q2);

            return q.ToList();
        }
    }
}