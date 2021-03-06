﻿using System;
using System.Linq;
using System.Collections.Generic;
using COM.Data;
using ERP.Data;
using ERP.Domain;
using Util;
using COM.Service;
namespace ERP.Service
{
	public interface Itb_Sys_UserService
	{
		tb_Sys_User Gettb_Sys_UserById(Guid Id);
        List<tb_Sys_User> Gettb_Sys_UserList();
		List<tb_Sys_User> Gettb_Sys_UserList(PagingModel pagingModel);
        void Createtb_Sys_User(tb_Sys_User tb_Sys_User);
        void Updatetb_Sys_User(tb_Sys_User tb_Sys_User);
        void Deletetb_Sys_User(Guid Id);
        void CheckUserPassword(string userCode, string password);
        tb_Sys_User GetUserByUserCode(string userCode);
        List<tb_Sys_User> GetUserByRoleId(Guid id);
	}
	public class tb_Sys_UserService :Itb_Sys_UserService
	{
        private IDatabaseFactory dbfactory;
		private Itb_Sys_UserRepository tb_Sys_UserRepository;
		private IUnitOfWork runtimeService;
        private Itb_Sys_UserRoleRepository userRoleRepository;
        private ICacheServiceBase appCacheService = Unity.Instance.GetService<ICacheServiceBase>();
        public tb_Sys_UserService(IDatabaseFactory dbfactory)
		{
            this.dbfactory = dbfactory;
            this.runtimeService = new UnitOfWork(dbfactory);
            this.tb_Sys_UserRepository = new tb_Sys_UserRepository(dbfactory);
            this.userRoleRepository = new tb_Sys_UserRoleRepository(dbfactory);
		}

		public List<tb_Sys_User> Gettb_Sys_UserList()
        {
            var q = this.tb_Sys_UserRepository.GetMany(i => true);
            
            return q.ToList();
        }

        public tb_Sys_User Gettb_Sys_UserById(Guid Id)
        {
            return this.tb_Sys_UserRepository.GetByID(Id);
        }

        public void Createtb_Sys_User(tb_Sys_User tb_Sys_User)
        {
            tb_Sys_User.Validate();
            tb_Sys_User.CreateTime = DateTime.Now;
            tb_Sys_User tempUser = appCacheService.GetItem("user") as tb_Sys_User;
            tb_Sys_User.Createuser = tempUser.UserName;
            tb_Sys_User.Validate();
			this.tb_Sys_UserRepository.Add(tb_Sys_User);
            this.runtimeService.Commit();
        }

        public void Deletetb_Sys_User(Guid Id)
        {
            var existstb_Sys_Menu = this.Gettb_Sys_UserById(Id);
            this.tb_Sys_UserRepository.Delete(existstb_Sys_Menu);
            this.runtimeService.Commit();
        }

        public void Updatetb_Sys_User(tb_Sys_User tb_Sys_User)
        {
            tb_Sys_User.ModifyTime = DateTime.Now;
            tb_Sys_User tempUser = appCacheService.GetItem("user") as tb_Sys_User;
            tb_Sys_User.ModifyUser = tempUser.UserName;
            var existstb_Sys_Menu = this.Gettb_Sys_UserById(tb_Sys_User.Id);
            tb_Sys_User.Validate();
            this.tb_Sys_UserRepository.SetValues(tb_Sys_User, existstb_Sys_Menu);
            this.runtimeService.Commit();
        }

        public List<tb_Sys_User> Gettb_Sys_UserList(PagingModel pagingModel)
        {
            var q = this.tb_Sys_UserRepository.GetMany(i => true);
            q = q.OrderByDescending(i => i.CreateTime);
            q = q.Paging(pagingModel);
            return q.ToList();
        }

        /// <summary>
        /// 验证用户名密码
        /// </summary>
        /// <param name="userCode"></param>
        /// <param name="password"></param>
        /// <returns></returns>
        public void CheckUserPassword(string userCode, string password)
        {
            var user = this.tb_Sys_UserRepository.GetMany(u => u.UserCode == userCode).FirstOrDefault();
            if (user == null)
                throw new AppException("用户名不存在");
            if (user.UserCode.ToStr() != userCode.ToStr() || user.UserPassword.ToStr() != password.ToStr())
                throw new AppException("用户名或密码错误");
        }


        public tb_Sys_User GetUserByUserCode(string userCode)
        {
            var user = this.tb_Sys_UserRepository.GetMany(u => u.UserCode == userCode).FirstOrDefault();
            if (user == null)
                throw new AppException("账号不存在");
            return user;
        }


        public List<tb_Sys_User> GetUserByRoleId(Guid id)
        {
            var userIdList = this.userRoleRepository.GetMany(i => i.RoleId == id).Select(i => i.UserId).ToList();
            var q = this.tb_Sys_UserRepository.GetMany(i => userIdList.Contains(i.Id));
            return q.ToList();
        }
    }
}