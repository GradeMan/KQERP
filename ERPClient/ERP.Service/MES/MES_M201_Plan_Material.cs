using System;
using System.Linq;
using System.Collections.Generic;
using COM.Data;
using ERP.Data;
using ERP.Domain;
using COM.Service;
using System.Text;
namespace ERP.Service
{
	public interface IMES_M201_Plan_MaterialService
	{
		MES_M201_Plan_Material GetById(Guid Id);
        List<MES_M201_Plan_Material> GetList(string PlanDetailId);
        IQueryable<MES_M201_Plan_Material> GetQuery();
		List<MES_M201_Plan_Material> GetList(PagingModel pagingModel, DateTime? beginDate, DateTime? endDate);
        void Create(MES_M201_Plan_Material MES_M201_Plan_Material);
        void Save(List<MES_M201_Plan_Material> materialList);
        void Update(MES_M201_Plan_Material MES_M201_Plan_Material);
        void Delete(Guid Id);
	}
	public class MES_M201_Plan_MaterialService :IMES_M201_Plan_MaterialService
	{
		private IMES_M201_Plan_MaterialRepository MES_M201_Plan_MaterialRepository;
		private IUnitOfWork runtimeService;
		private ICacheServiceBase appCacheService = Unity.Instance.GetService<ICacheServiceBase>();
		public MES_M201_Plan_MaterialService(IDatabaseFactory dbfactory)
		{
			this.runtimeService = new UnitOfWork(dbfactory);
			this.MES_M201_Plan_MaterialRepository = new MES_M201_Plan_MaterialRepository(dbfactory);
		}

        public List<MES_M201_Plan_Material> GetList(string PlanDetailId)
        {
            StringBuilder sqlStr = new StringBuilder();
            sqlStr.Append(@" select * from (select a.Id, a.CompCode, a.PlanDetailId, a.PLNo, a.PartNo, a.MatCode,b.MatName,b.MatSpec, a.SuppCode, a.Unit, a.UnitPrice, a.UnitConsume, a.Qty, a.Remarks, a.ModifyDt, 
                                                    a.ModifyUser, a.CreateDt, a.CreateUser
                                                from MES_M201_Plan_Material a
                                                left join ERP_M001_Material b on a.MatCode = b.MatCode ) as T
                                                where 1= 1");
            sqlStr.AppendFormat(" AND PlanDetailId = '{0}'", PlanDetailId);
            var q = this.MES_M201_Plan_MaterialRepository.GetDbContext().Database.SqlQuery<MES_M201_Plan_Material>(sqlStr.ToString());
            return q.ToList();
        }
        
		public IQueryable<MES_M201_Plan_Material> GetQuery()
        {
            var q = this.MES_M201_Plan_MaterialRepository.GetMany(i => true);
            return q;
        }
        
        public MES_M201_Plan_Material GetById(Guid Id)
        {
            return this.MES_M201_Plan_MaterialRepository.GetByID(Id);
        }

        public void Create(MES_M201_Plan_Material MES_M201_Plan_Material)
        {
        	MES_M201_Plan_Material.CreateDt = DateTime.Now;
            tb_Sys_User tempUser = appCacheService.GetItem("user") as tb_Sys_User;
            MES_M201_Plan_Material.CreateUser = tempUser.UserName;
            MES_M201_Plan_Material.Validate();
			this.MES_M201_Plan_MaterialRepository.Add(MES_M201_Plan_Material);
            this.runtimeService.Commit();
        }
        public void Save(List<MES_M201_Plan_Material> materialList)
        {
            if (materialList.Count > 0)
            {
                Guid planDetailId = materialList[0].PlanDetailId;
                var existList = MES_M201_Plan_MaterialRepository.GetMany(i => i.PlanDetailId == planDetailId).ToList();
                foreach (var exist in existList)
                    MES_M201_Plan_MaterialRepository.Delete(exist);
            }
            tb_Sys_User tempUser = appCacheService.GetItem("user") as tb_Sys_User;
            foreach (var model in materialList)
            {
                model.CreateDt = DateTime.Now;
                model.CreateUser = tempUser.UserName;
                model.CompCode = tempUser.CompCode;
                model.Validate();
                this.MES_M201_Plan_MaterialRepository.Add(model);
            }
            this.runtimeService.Commit();
        }
        public void Delete(Guid Id)
        {
            var existstb_Sys_Menu = this.GetById(Id);
            this.MES_M201_Plan_MaterialRepository.Delete(existstb_Sys_Menu);
            this.runtimeService.Commit();
        }

        public void Update(MES_M201_Plan_Material MES_M201_Plan_Material)
        {
        	MES_M201_Plan_Material.ModifyDt = DateTime.Now;
            tb_Sys_User tempUser = appCacheService.GetItem("user") as tb_Sys_User;
            MES_M201_Plan_Material.ModifyUser = tempUser.UserName;
            MES_M201_Plan_Material.Validate();
            var existstb_Sys_Menu = this.GetById(MES_M201_Plan_Material.Id);
            this.MES_M201_Plan_MaterialRepository.SetValues(MES_M201_Plan_Material, existstb_Sys_Menu);
            this.runtimeService.Commit();
        }

        public List<MES_M201_Plan_Material> GetList(PagingModel pagingModel, DateTime? beginDate, DateTime? endDate)
        {
            var q = this.MES_M201_Plan_MaterialRepository.GetMany(i => true);
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