﻿using ERP.Service;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using ERP.Data;
using ERP.Domain;
using COM.Service;
using ERP.Winform.Service;
using System.Linq;
namespace ERPTest
{
    
    
    /// <summary>
    ///这是 tb_Sys_UserServiceTest 的测试类，旨在
    ///包含所有 tb_Sys_UserServiceTest 单元测试
    ///</summary>
    [TestClass()]
    public class ERPServiceTest
    {
        //Itb_Sys_UserService userservice = Unity.Instance.GetService<Itb_Sys_UserService>();
        //Itb_Sys_RolesService roleservice = Unity.Instance.GetService<Itb_Sys_RolesService>();
        IAppLoginService loginService = Unity.Instance.GetService<IAppLoginService>();
        //IERP_C006_ProcessFlow_ProcessRepository processRepository = Unity.Instance.GetService<IERP_C006_ProcessFlow_ProcessRepository>();
        [TestInitialize]
        public void Init()
        {
            AppStartService.Instance.Start();
            loginService.LoginAsERPUser("admin", "admin","K10","康强电子");
        }

        [TestMethod]
        public void CreateUserTest()
        {
            //tb_Sys_User user = new tb_Sys_User();
            //user.UserCode = "001";
            //user.UserName = "zhangsan";
            //user.UserPassword = "001";
            ////userservice.Createtb_Sys_User(user);
            ////var list = processRepository.GetMany(i => true).ToList();
            //tb_Sys_User user2 = user.Clone() as tb_Sys_User;
            //Assert.AreEqual(user.UserCode, user2.UserCode);
            var supplier = ERP.Winform.ERPCacheHepler.Instance.GetSupplierData();
            Assert.AreNotEqual(supplier.Count,0);
        }
        /// <summary>
        ///Createtb_Sys_User 的测试
        ///</summary>
        [TestMethod()]
        public void Createtb_Sys_UserTest()
        {
            //IRuntimeService runtimeService = null; // TODO: 初始化为适当的值
            //Itb_Sys_UserRepository tb_Sys_UserRepository = null; // TODO: 初始化为适当的值
            //tb_Sys_UserService target = new tb_Sys_UserService(runtimeService, tb_Sys_UserRepository); // TODO: 初始化为适当的值
            //tb_Sys_User tb_Sys_User = null; // TODO: 初始化为适当的值
            //target.Createtb_Sys_User(tb_Sys_User);
            //Assert.Inconclusive("无法验证不返回值的方法。");
        }
    }
}
