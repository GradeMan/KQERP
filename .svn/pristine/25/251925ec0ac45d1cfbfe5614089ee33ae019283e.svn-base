using System;
using System.Linq;
using System.Collections.Generic;
using COM.Data;
using ERP.Data;
using ERP.Domain;
using COM.Service;
using ERP.Domain.Supplier;
using System.Text;
namespace ERP.Service
{
	public interface ISUPP_M001_PurPlanService
	{
		SUPP_M001_PurPlan GetById(Guid Id);
        List<SUPP_M001_PurPlan> GetList();
		List<SUPP_M001_PurPlan> GetList(PagingModel pagingModel, DateTime? beginDate, DateTime? endDate);
        void Create(SUPP_M001_PurPlan SUPP_M001_PurPlan);
        void Update(SUPP_M001_PurPlan SUPP_M001_PurPlan);
        void Delete(Guid Id);
        void DelPurAndDetail(Guid id);
        IQueryable<SUPP_M001_PurPlan_Material> GetPurMat();
        IQueryable<SUPP_M001_PurPlan> GetPurPlan();
        IQueryable<SUPP_M001_PurPlan_Detail> GetPurDetail();
        void MarkDelPurMat(SUPP_M001_PurPlan_Material tempData);
        void MarkDelPurDetail(SUPP_M001_PurPlan_Detail tempData);
        void Save(SUPP_M001_PurPlan SUPP_M001_PurPlan, List<SUPP_M001_PurPlan_Material> purMatData);
        void Save(SUPP_M001_PurPlan SUPP_M001_PurPlan, List<SUPP_M001_PurPlan_Detail> purMatData);
        List<PurPlanViewModel> GetPPReortList();
        List<PurPlanMatViewModel> GetPurPlanMatList();
        List<PurPlanHeaderModel> GetPurHeaderList(string purPlNo);
        List<PurPlanHeaderModel> GetPurDetailList(string purPlNo);
        List<PurPlanHeaderModel> GetPurDetailGroupList(string purPlNo);
        List<PurPlanDetailModel> GetPurMaterialList(string purPlNo);
        List<PurPlanHeaderModel> GetPurPlanDetailList();
	}
	public class SUPP_M001_PurPlanService :ISUPP_M001_PurPlanService
	{
		private ISUPP_M001_PurPlanRepository SUPP_M001_PurPlanRepository;
        private ISUPP_M001_PurPlan_MaterialRepository purPlanMatRepository;
        private ISUPP_M001_PurPlan_DetailRepository purDetailRepository;
		private IUnitOfWork runtimeService;
		private ICacheServiceBase appCacheService = Unity.Instance.GetService<ICacheServiceBase>();
		public SUPP_M001_PurPlanService(IDatabaseFactory dbfactory)
		{
			this.runtimeService = new UnitOfWork(dbfactory);
			this.SUPP_M001_PurPlanRepository = new SUPP_M001_PurPlanRepository(dbfactory);
            purPlanMatRepository = new SUPP_M001_PurPlan_MaterialRepository(dbfactory);
            purDetailRepository = new SUPP_M001_PurPlan_DetailRepository(dbfactory);
		}

        
        public List<PurPlanHeaderModel> GetPurPlanDetailList()
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append(" select a.PurPlNo,b.MatClass1,b.MatName,b.MatCode,b.MatClass2,");
            strSql.Append(" b.MatSpec,a.PurQty,a.Remarks,d.TxDt ");
            strSql.Append(" from dbo.SUPP_M001_PurPlan_Detail a");
            strSql.Append(" inner join dbo.ERP_M001_Material b on a.MatCode = b.MatCode");
            strSql.Append(" inner join dbo.SUPP_M001_PurPlan d on a.PurPlNo = d.PurPlNo");
            //strSql.AppendFormat(" where a.PurPlNo = '{0}' ", purPlNo);
            strSql.Append(" order by b.MatClass2,b.MatSpec");
            var dbContext = this.SUPP_M001_PurPlanRepository.GetDbContext();
            return dbContext.Database.SqlQuery<PurPlanHeaderModel>(strSql.ToString()).ToList();
        }
        public List<PurPlanMatViewModel> GetPurPlanMatList()
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append(" select a.PurPlNo,b.MatClass1,b.MatName,b.MatCode,b.MatClass2,");
            strSql.Append(" b.MatSpec,a.PurQty,a.SuppLevel,a.SuppCode,c.Alias,a.SuppPurPer,a.SuppQty,a.Remarks,d.TxDt ");
            strSql.Append(" from dbo.SUPP_M001_PurPlan_Material a");
            strSql.Append(" inner join dbo.ERP_M001_Material b on a.MatCode = b.MatCode");
            strSql.Append(" inner join dbo.ERP_C003_Supplier c on c.SuppCode = a.SuppCode");
            strSql.Append(" inner join dbo.SUPP_M001_PurPlan d on a.PurPlNo = d.PurPlNo");
            //strSql.AppendFormat(" where a.PurPlNo = '{0}' ", purPlNo);
            strSql.Append(" order by b.MatClass2,b.MatSpec");
            var dbContext = this.SUPP_M001_PurPlanRepository.GetDbContext();
            return dbContext.Database.SqlQuery<PurPlanMatViewModel>(strSql.ToString()).ToList();
        }
        public List<PurPlanDetailModel> GetPurMaterialList(string purPlNo)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append(" select a.PurPlNo,b.MatClass1,b.MatName,b.MatCode,b.MatClass2,b.MatSpec,a.PurQty,a.SuppLevel,a.SuppCode,c.Alias,a.SuppPurPer,a.SuppQty,a.Remarks ");
            strSql.Append(" from dbo.SUPP_M001_PurPlan_Material a");
            strSql.Append(" inner join dbo.ERP_M001_Material b on a.MatCode = b.MatCode");
            strSql.Append(" inner join dbo.ERP_C003_Supplier c on c.SuppCode = a.SuppCode");
            strSql.AppendFormat(" where a.PurPlNo = '{0}' ", purPlNo);
            strSql.Append(" order by b.MatClass2,b.MatSpec");
            var dbContext = this.SUPP_M001_PurPlanRepository.GetDbContext();
            return dbContext.Database.SqlQuery<PurPlanDetailModel>(strSql.ToString()).ToList();
        }

        public List<PurPlanHeaderModel> GetPurHeaderList(string purPlNo)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append(" select  a.PurPlNo,b.MatClass1,b.MatClass2,a.SuppLevel,a.SuppCode,c.Alias,sum(a.SuppQty) as SuppQty ");
            strSql.Append(" from dbo.SUPP_M001_PurPlan_Material a");
            strSql.Append(" inner join dbo.ERP_M001_Material b on a.MatCode = b.MatCode ");
            strSql.Append(" inner join dbo.ERP_C003_Supplier c on c.SuppCode = a.SuppCode ");
            strSql.AppendFormat(" where a.PurPlNo = '{0}' ", purPlNo);
            strSql.Append(" group by c.Alias,a.PurPlNo,MatClass1,b.MatClass2,a.SuppLevel,a.SuppCode ");
            strSql.Append(" order by b.MatClass2,c.Alias");
            var dbContext = this.SUPP_M001_PurPlanRepository.GetDbContext();
            var purHeaderData = dbContext.Database.SqlQuery<PurPlanHeaderModel>(strSql.ToString()).ToList();
            foreach (var purHeader in purHeaderData)
            {
                decimal PurQty = purHeaderData.Where(a => a.MatClass2 == purHeader.MatClass2).Sum(a => a.SuppQty);
                purHeader.PurQty = PurQty;
                purHeader.SuppPurPer = purHeader.SuppQty / purHeader.PurQty;
            }
            return purHeaderData;
        }

        public List<PurPlanHeaderModel> GetPurDetailList(string purPlNo)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append(" select  a.PurPlNo,a.MatCode,b.MatClass1,b.MatClass2,b.MatName,b.MatSpec,a.PurQty,a.Remarks ");
            strSql.Append(" from dbo.SUPP_M001_PurPlan_Detail a");
            strSql.Append("  inner join dbo.ERP_M001_Material b on a.MatCode = b.MatCode ");
            strSql.AppendFormat(" where a.PurPlNo = '{0}' ", purPlNo);
            strSql.Append(" order by b.MatCode ");
            var dbContext = this.SUPP_M001_PurPlanRepository.GetDbContext();
            var purHeaderData = dbContext.Database.SqlQuery<PurPlanHeaderModel>(strSql.ToString()).ToList();
            return purHeaderData;
        }

        public List<PurPlanHeaderModel> GetPurDetailGroupList(string purPlNo)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append(" select a.PurPlNo,b.MatClass1,b.MatClass2,Sum(a.PurQty) as PurQty ");
            strSql.Append(" from dbo.SUPP_M001_PurPlan_Detail a");
            strSql.Append(" inner join dbo.ERP_M001_Material b on a.MatCode = b.MatCode");
            strSql.AppendFormat(" where a.PurPlNo = '{0}' ", purPlNo);
            strSql.Append(" group by a.PurPlNo,b.MatClass2,b.MatClass1,a.Remarks");
            strSql.Append(" order by b.MatClass2");
            var dbContext = this.SUPP_M001_PurPlanRepository.GetDbContext();
            return dbContext.Database.SqlQuery<PurPlanHeaderModel>(strSql.ToString()).ToList();
        }
        public List<PurPlanViewModel> GetPPReortList()
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("  SELECT   A.MatCode, A.MatLevel, A.MatClass1, A.MatClass2, A.MatClass3, A.MatName, A.MatSpec,  b.SuppCode, c.Alias, B.Level, B.PurPer, B.Unit, B.UnitPrice, B.PriceRemarks, B.ProdModel, B.DeliveryTerm, B.PayTerm ");
            strSql.Append("  FROM         ERP_M001_Material A, ERP_M001_Material_Supp B , ERP_C003_Supplier C ");
            strSql.Append("  where a.matcode = b.matcode  and b.suppcode = c.suppcode");
            strSql.Append("  order by A.MatClass1, A.MatClass2, A.MatClass3, A.MatLevel, A.MatCode,B.Level,B.SuppCode ");
            var dbContext = this.SUPP_M001_PurPlanRepository.GetDbContext();
            return dbContext.Database.SqlQuery<PurPlanViewModel>(strSql.ToString()).ToList();
        }
        public void Save(SUPP_M001_PurPlan purPlan, List<SUPP_M001_PurPlan_Material> purMatData)
        {
            tb_Sys_User tempUser = appCacheService.GetItem("user") as tb_Sys_User;

            var existsdevice = this.GetById(purPlan.Id);
            if (existsdevice == null)
            {
                purPlan.CompCode = tempUser.CompCode;
                purPlan.CreateDt = DateTime.Now;
                purPlan.CreateUser = tempUser.UserName;
                purPlan.Validate();
                this.SUPP_M001_PurPlanRepository.Add(purPlan);
            }
            else
            {
                purPlan.ModifyDt = DateTime.Now;
                purPlan.ModifyUser = tempUser.UserName;
                purPlan.Validate();
                this.SUPP_M001_PurPlanRepository.SetValues(purPlan, existsdevice);
            }
            foreach (var purMat in purMatData)
            {
                var existspurMat = purPlanMatRepository.GetByID(purMat.Id);
                if (existspurMat == null)
                {
                    purMat.CompCode = tempUser.CompCode;
                    purMat.CreateDt = DateTime.Now;
                    purMat.CreateUser = tempUser.UserName;
                    purMat.Validate();
                    this.purPlanMatRepository.Add(purMat);
                }
                else
                {
                    purMat.ModifyDt = DateTime.Now;
                    purMat.ModifyUser = tempUser.UserName;
                    purMat.Validate();
                    this.purPlanMatRepository.SetValues(purMat, existspurMat);
                }
            }
            this.runtimeService.Commit();
        }
        public void Save(SUPP_M001_PurPlan purPlan, List<SUPP_M001_PurPlan_Detail> purMatData)
        {
            tb_Sys_User tempUser = appCacheService.GetItem("user") as tb_Sys_User;

            var existsdevice = this.GetById(purPlan.Id);
            if (existsdevice == null)
            {
                purPlan.CompCode = tempUser.CompCode;
                purPlan.CreateDt = DateTime.Now;
                purPlan.CreateUser = tempUser.UserName;
                purPlan.Validate();
                this.SUPP_M001_PurPlanRepository.Add(purPlan);
            }
            else
            {
                purPlan.ModifyDt = DateTime.Now;
                purPlan.ModifyUser = tempUser.UserName;
                purPlan.Validate();
                this.SUPP_M001_PurPlanRepository.SetValues(purPlan, existsdevice);
            }
            foreach (var purMat in purMatData)
            {
                var existspurMat = purDetailRepository.GetByID(purMat.Id);
                if (existspurMat == null)
                {
                    purMat.CompCode = tempUser.CompCode;
                    purMat.CreateDt = DateTime.Now;
                    purMat.CreateUser = tempUser.UserName;
                    purMat.Validate();
                    this.purDetailRepository.Add(purMat);
                }
                else
                {
                    purMat.ModifyDt = DateTime.Now;
                    purMat.ModifyUser = tempUser.UserName;
                    purMat.Validate();
                    this.purDetailRepository.SetValues(purMat, existspurMat);
                }
            }
            this.runtimeService.Commit();
        }
        public void MarkDelPurMat(SUPP_M001_PurPlan_Material tempData)
        {
            var existstb_Sys_Menu = purPlanMatRepository.GetByID(tempData.Id);
            if (existstb_Sys_Menu != null)
                this.purPlanMatRepository.Delete(existstb_Sys_Menu);
           // this.runtimeService.Commit();
        }
        public void MarkDelPurDetail(SUPP_M001_PurPlan_Detail tempData)
        {
            var existstb_Sys_Menu = this.purDetailRepository.GetByID(tempData.Id);
            if (existstb_Sys_Menu != null)
                this.purDetailRepository.Delete(existstb_Sys_Menu);
        }
        public IQueryable<SUPP_M001_PurPlan_Detail> GetPurDetail()
        {
            return purDetailRepository.GetMany(i => true);
        }
        public IQueryable<SUPP_M001_PurPlan_Material> GetPurMat()
        {
            return purPlanMatRepository.GetMany(i => true);
            
        }

        public IQueryable<SUPP_M001_PurPlan> GetPurPlan()
        {
            return this.SUPP_M001_PurPlanRepository.GetMany(i => true);

        }
		public List<SUPP_M001_PurPlan> GetList()
        {
            var q = this.SUPP_M001_PurPlanRepository.GetMany(i => true);
            return q.ToList();
        }

        public SUPP_M001_PurPlan GetById(Guid Id)
        {
            return this.SUPP_M001_PurPlanRepository.GetByID(Id);
        }

        public void Create(SUPP_M001_PurPlan SUPP_M001_PurPlan)
        {
        	SUPP_M001_PurPlan.CreateDt = DateTime.Now;
            tb_Sys_User tempUser = appCacheService.GetItem("user") as tb_Sys_User;
            SUPP_M001_PurPlan.CreateUser = tempUser.UserName;
            SUPP_M001_PurPlan.Validate();
			this.SUPP_M001_PurPlanRepository.Add(SUPP_M001_PurPlan);
            this.runtimeService.Commit();
        }

        public void Delete(Guid Id)
        {
            var existstb_Sys_Menu = this.GetById(Id);
            this.SUPP_M001_PurPlanRepository.Delete(existstb_Sys_Menu);
            var purMatData = this.purPlanMatRepository.GetMany(a => a.PurPlNo == existstb_Sys_Menu.PurPlNo).ToList();
            foreach (var purMat in purMatData)
                purPlanMatRepository.Delete(purMat);
            this.runtimeService.Commit();
        }
        public void DelPurAndDetail(Guid id)
        {
            var existstb_Sys_Menu = this.GetById(id);
            this.SUPP_M001_PurPlanRepository.Delete(existstb_Sys_Menu);
            var purMatData = this.purDetailRepository.GetMany(a => a.PurPlNo == existstb_Sys_Menu.PurPlNo).ToList();
            foreach (var purMat in purMatData)
                purDetailRepository.Delete(purMat);
            this.runtimeService.Commit();
        }
        public void Update(SUPP_M001_PurPlan SUPP_M001_PurPlan)
        {
        	SUPP_M001_PurPlan.ModifyDt = DateTime.Now;
            tb_Sys_User tempUser = appCacheService.GetItem("user") as tb_Sys_User;
            SUPP_M001_PurPlan.ModifyUser = tempUser.UserName;
            SUPP_M001_PurPlan.Validate();
            var existstb_Sys_Menu = this.GetById(SUPP_M001_PurPlan.Id);
            this.SUPP_M001_PurPlanRepository.SetValues(SUPP_M001_PurPlan, existstb_Sys_Menu);
            this.runtimeService.Commit();
        }

        public List<SUPP_M001_PurPlan> GetList(PagingModel pagingModel, DateTime? beginDate, DateTime? endDate)
        {
            var q = this.SUPP_M001_PurPlanRepository.GetMany(i => true);
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