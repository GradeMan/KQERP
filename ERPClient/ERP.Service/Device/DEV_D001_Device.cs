using System;
using System.Linq;
using System.Collections.Generic;
using COM.Data;
using ERP.Data;
using ERP.Domain;
using COM.Service;
namespace ERP.Service
{
	public interface IDEV_D001_DeviceService
	{
		DEV_D001_Device GetById(Guid Id);
        List<DEV_D001_Device> GetList();
		List<DEV_D001_Device> GetList(PagingModel pagingModel, DateTime? beginDate, DateTime? endDate);
        void Create(DEV_D001_Device DEV_D001_Device);
        void Update(DEV_D001_Device DEV_D001_Device);
        void Delete(Guid Id);
        List<DEV_D001_Device_File> GetDevFileList(Guid devId);
        List<DEV_D001_Device_Appurten> GetDevAppList(Guid devId);
        void MarkDevFile(Guid fileId);
        void MarkDevAppurten(Guid AppId);
        void Save(DEV_D001_Device device, List<DEV_D001_Device_File> devFileList, List<DEV_D001_Device_Appurten> devAppList);
	}
	public class DEV_D001_DeviceService :IDEV_D001_DeviceService
	{
		private IDEV_D001_DeviceRepository DEV_D001_DeviceRepository;
		private IUnitOfWork runtimeService;
		private ICacheServiceBase appCacheService = Unity.Instance.GetService<ICacheServiceBase>();
        private IDEV_D001_Device_FileRepository devFileRepository;
        private IDEV_D001_Device_AppurtenRepository appurtenrepository;
		public DEV_D001_DeviceService(IDatabaseFactory dbfactory)
		{
			this.runtimeService = new UnitOfWork(dbfactory);
			this.DEV_D001_DeviceRepository = new DEV_D001_DeviceRepository(dbfactory);
            this.devFileRepository = new DEV_D001_Device_FileRepository(dbfactory);
            this.appurtenrepository = new DEV_D001_Device_AppurtenRepository(dbfactory);
		}

		public List<DEV_D001_Device> GetList()
        {
            var q = this.DEV_D001_DeviceRepository.GetMany(i => true);
            return q.ToList();
        }

        public DEV_D001_Device GetById(Guid Id)
        {
            return this.DEV_D001_DeviceRepository.GetByID(Id);
        }

        public void Create(DEV_D001_Device DEV_D001_Device)
        {
        	DEV_D001_Device.CreateDt = DateTime.Now;
            tb_Sys_User tempUser = appCacheService.GetItem("user") as tb_Sys_User;
            DEV_D001_Device.CreateUser = tempUser.UserName;
            DEV_D001_Device.Validate();
			this.DEV_D001_DeviceRepository.Add(DEV_D001_Device);
            this.runtimeService.Commit();
        }

        public void Delete(Guid Id)
        {
            var existstb_Sys_Menu = this.GetById(Id);
            this.DEV_D001_DeviceRepository.Delete(existstb_Sys_Menu);
            this.runtimeService.Commit();
        }

        public void Update(DEV_D001_Device DEV_D001_Device)
        {
        	DEV_D001_Device.ModifyDt = DateTime.Now;
            tb_Sys_User tempUser = appCacheService.GetItem("user") as tb_Sys_User;
            DEV_D001_Device.ModifyUser = tempUser.UserName;
            DEV_D001_Device.Validate();
            var existstb_Sys_Menu = this.GetById(DEV_D001_Device.Id);
            this.DEV_D001_DeviceRepository.SetValues(DEV_D001_Device, existstb_Sys_Menu);
            this.runtimeService.Commit();
        }

        public List<DEV_D001_Device> GetList(PagingModel pagingModel, DateTime? beginDate, DateTime? endDate)
        {
            var q = this.DEV_D001_DeviceRepository.GetMany(i => true);
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


        public List<DEV_D001_Device_File> GetDevFileList(Guid devId)
        {
            var q = this.devFileRepository.GetMany(i => i.DevId == devId);
            return q.ToList();
        }

        public List<DEV_D001_Device_Appurten> GetDevAppList(Guid devId)
        {
            var q = this.appurtenrepository.GetMany(i => i.DevId == devId);
            return q.ToList();
        }

        public void MarkDevFile(Guid fileId)
        {
            var existstb_Sys_Menu = this.devFileRepository.GetByID(fileId);
            if (existstb_Sys_Menu != null)
                this.devFileRepository.Delete(existstb_Sys_Menu);
        }
        public void MarkDevAppurten(Guid AppId)
        {
            var existsapp = this.appurtenrepository.GetByID(AppId);
            if (existsapp != null)
                this.appurtenrepository.Delete(existsapp);
        }

        public void Save(DEV_D001_Device device, List<DEV_D001_Device_File> devFileList, List<DEV_D001_Device_Appurten> devAppList)
        {
            tb_Sys_User tempUser = appCacheService.GetItem("user") as tb_Sys_User;
            var existsdevice = this.GetById(device.Id);
            if (existsdevice == null)
            {
                device.CompCode = tempUser.CompCode;
                device.CreateDt = DateTime.Now;
                device.CreateUser = tempUser.UserName;
                device.Validate();
                this.DEV_D001_DeviceRepository.Add(device);
            }
            else
            {
                device.ModifyDt = DateTime.Now;
                device.ModifyUser = tempUser.UserName;
                device.Validate();
                this.DEV_D001_DeviceRepository.SetValues(device, existsdevice);
            }
            if (devFileList != null)
            {
                foreach (var file in devFileList)
                {
                    var existstfile = this.devFileRepository.GetByID(file.Id);
                    if (existstfile == null)
                    {
                        file.CompCode = tempUser.CompCode;
                        this.devFileRepository.Add(file);
                    }
                    else
                    {
                        this.devFileRepository.SetValues(file, existstfile);
                    }
                }
            }
            if (devAppList != null)
            {
                foreach (var app in devAppList)
                {
                    var existstapp = this.appurtenrepository.GetByID(app.Id);
                    if (existstapp == null)
                    {
                        this.appurtenrepository.Add(app);
                    }
                    else
                    {
                        this.appurtenrepository.SetValues(app, existstapp);
                    }
                }
            }
            this.runtimeService.Commit();
        }





     
    }
}