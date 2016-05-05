using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ERP.Domain;
using COM.Data;
using ERP.Data;
using COM.Service;

namespace ERP.Service
{
    public interface IESOP_DeviceService
    {
        ESOP_Device GetById(Guid Id);
        List<ESOP_Device> GetList();
        List<ESOP_Device> GetList(PagingModel pagingModel, DateTime? beginDate, DateTime? endDate);
        void Create(ESOP_Device DEV_D001_Device);
        void Update(ESOP_Device DEV_D001_Device);
        void Delete(Guid Id);
        void Save(ESOP_Device device);
        IQueryable<ESOP_Device> GetDevice();
        List<Guid> GetDevIdByRoleId(Guid roleId);
        void Create(ESOP_RoleDevice ESOP_RoleDevice);
    }
    public class ESOP_DeviceService : IESOP_DeviceService
    {
        private IESOP_DeviceRepository ESOP_DeviceRepository;
        private IESOP_RoleDeviceRepository roleDeviceRepository;
        private IUnitOfWork runtimeService;
        private ICacheServiceBase appCacheService = Unity.Instance.GetService<ICacheServiceBase>();
        public ESOP_DeviceService(IDatabaseFactory dbfactory)
        {
            this.runtimeService = new UnitOfWork(dbfactory);
            this.ESOP_DeviceRepository = new ESOP_DeviceRepository(dbfactory);
            roleDeviceRepository = new ESOP_RoleDeviceRepository(dbfactory);
        }
        public void Create(ESOP_RoleDevice ESOP_RoleDevice)
        {
            ESOP_RoleDevice.Validate();
            this.roleDeviceRepository.Add(ESOP_RoleDevice);
            this.runtimeService.Commit();
        }
        public List<Guid> GetDevIdByRoleId(Guid roleId)
        {
            return roleDeviceRepository.GetMany(a => a.RoleId == roleId).Select(a => a.DevId).ToList();
        }
        public IQueryable<ESOP_Device> GetDevice()
        {
            return ESOP_DeviceRepository.GetMany(i => true);
        }
        public List<ESOP_Device> GetList()
        {
            var q = this.ESOP_DeviceRepository.GetMany(i => true);
            return q.ToList();
        }

        public ESOP_Device GetById(Guid Id)
        {
            return this.ESOP_DeviceRepository.GetByID(Id);
        }

        public void Create(ESOP_Device ESOP_Device)
        {
            ESOP_Device.CreateDt = DateTime.Now;
            tb_Sys_User tempUser = appCacheService.GetItem("user") as tb_Sys_User;
            ESOP_Device.CreateUser = tempUser.UserName;
            ESOP_Device.Validate();
            this.ESOP_DeviceRepository.Add(ESOP_Device);
            this.runtimeService.Commit();
        }

        public void Delete(Guid Id)
        {
            var existstb_Sys_Menu = this.GetById(Id);
            this.ESOP_DeviceRepository.Delete(existstb_Sys_Menu);
            this.runtimeService.Commit();
        }

        public void Update(ESOP_Device ESOP_Device)
        {
            ESOP_Device.ModifyDt = DateTime.Now;
            tb_Sys_User tempUser = appCacheService.GetItem("user") as tb_Sys_User;
            ESOP_Device.ModifyUser = tempUser.UserName;
            ESOP_Device.Validate();
            var existstb_Sys_Menu = this.GetById(ESOP_Device.Id);
            this.ESOP_DeviceRepository.SetValues(ESOP_Device, existstb_Sys_Menu);
            this.runtimeService.Commit();
        }

        public List<ESOP_Device> GetList(PagingModel pagingModel, DateTime? beginDate, DateTime? endDate)
        {
            var q = this.ESOP_DeviceRepository.GetMany(i => true);
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


        public void Save(ESOP_Device device)
        {
            tb_Sys_User tempUser = appCacheService.GetItem("user") as tb_Sys_User;
            
            var existsdevice = this.GetById(device.Id);
            if (existsdevice == null)
            {
                device.CompCode = tempUser.CompCode;
                device.CreateDt = DateTime.Now;
                device.CreateUser = tempUser.UserName;
                device.Validate();
                this.ESOP_DeviceRepository.Add(device);
            }
            else
            {
                device.ModifyDt = DateTime.Now;
                device.ModifyUser = tempUser.UserName;
                device.Validate();
                this.ESOP_DeviceRepository.SetValues(device, existsdevice);
            }
            
            this.runtimeService.Commit();
        }
    }
}
