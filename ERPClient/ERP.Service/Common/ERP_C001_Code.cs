﻿using System;
using System.Linq;
using System.Collections.Generic;
using COM.Data;
using ERP.Data;
using ERP.Domain;
using COM.Service;
using COM.Domain;
namespace ERP.Service
{
    public interface ICodeService
    {
        ERP_C001_Code GetById(Guid Id);
        IQueryable<ERP_C001_Code> GetList();
        List<ERP_C001_Code> GetList(PagingModel pagingModel, DateTime? beginDate, DateTime? endDate);
        void Create(ERP_C001_Code ERP_C001_Code);
        void Update(ERP_C001_Code ERP_C001_Code);
        void Delete(Guid Id);
        List<ERP_C001_Code> GetListByCodeID(string codeID);
        List<InputItem> GetCodeDataByCodeId(string codeId);

    }
    public class CodeService : ICodeService
    {
        private IERP_C001_CodeRepository ERP_C001_CodeRepository;
        private IUnitOfWork runtimeService;
        private ICacheServiceBase appCacheService = Unity.Instance.GetService<ICacheServiceBase>();
        public CodeService(IDatabaseFactory dbfactory)
        {
            this.runtimeService = new UnitOfWork(dbfactory);
            this.ERP_C001_CodeRepository = new ERP_C001_CodeRepository(dbfactory);
        }

        public IQueryable<ERP_C001_Code> GetList()
        {
            var q = this.ERP_C001_CodeRepository.GetMany(i => true);
            return q;
        }

        public ERP_C001_Code GetById(Guid Id)
        {
            return this.ERP_C001_CodeRepository.GetByID(Id);
        }

        public void Create(ERP_C001_Code ERP_C001_Code)
        {
            ERP_C001_Code.CreateDt = DateTime.Now;
            tb_Sys_User tempUser = appCacheService.GetItem("user") as tb_Sys_User;
            ERP_C001_Code.CreateUser = tempUser.UserName;
            ERP_C001_Code.CompCode = tempUser.CompCode;
            ERP_C001_Code.Validate();
            this.ERP_C001_CodeRepository.Add(ERP_C001_Code);
            this.runtimeService.Commit();
        }

        public void Delete(Guid Id)
        {
            var existstb_Sys_Menu = this.GetById(Id);
            this.ERP_C001_CodeRepository.Delete(existstb_Sys_Menu);
            this.runtimeService.Commit();
        }

        public void Update(ERP_C001_Code ERP_C001_Code)
        {
            ERP_C001_Code.ModifyDt = DateTime.Now;
            tb_Sys_User tempUser = appCacheService.GetItem("user") as tb_Sys_User;
            ERP_C001_Code.ModifyUser = tempUser.UserName;
            ERP_C001_Code.Validate();
            var existstb_Sys_Menu = this.GetById(ERP_C001_Code.Id);
            this.ERP_C001_CodeRepository.SetValues(ERP_C001_Code, existstb_Sys_Menu);
            this.runtimeService.Commit();
        }

        public List<ERP_C001_Code> GetList(PagingModel pagingModel, DateTime? beginDate, DateTime? endDate)
        {
            var q = this.ERP_C001_CodeRepository.GetMany(i => true);
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


        public List<ERP_C001_Code> GetListByCodeID(string codeID)
        {
            tb_Sys_User tempUser = appCacheService.GetItem("user") as tb_Sys_User;
            var q = this.ERP_C001_CodeRepository.GetMany(i => i.CodeID == codeID);
            return q.ToList();
        }
        public List<InputItem> GetCodeDataByCodeId(string codeId)
        {
            var q = this.ERP_C001_CodeRepository.GetMany(i => i.CodeID == codeId).ToList();
            var q2 = q.Select(i => new InputItem { DisPlayName = i.Description, Value = i.Code, InputCode1 = i.Code, InputCode2 = Util.PinYin.GetCodstring(i.Description) });
            return q2.OrderBy(a=>a.Value).ToList();
        }

       
    }
}