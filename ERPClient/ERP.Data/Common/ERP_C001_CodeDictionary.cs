using System;
using ERP.Domain;
using COM.Service;
namespace ERP.Data
{
	public interface IERP_C001_CodeDictionaryRepository : IRepository<ERP_C001_CodeDictionary>
	{
	}
	public class ERP_C001_CodeDictionaryRepository : AnyRepositoryBase<ERP_C001_CodeDictionary>, IERP_C001_CodeDictionaryRepository
	{
		public ERP_C001_CodeDictionaryRepository(IDatabaseFactory databaseFactory)
			: base(databaseFactory)
		{
		}
        protected override System.Linq.Expressions.Expression<Func<ERP_C001_CodeDictionary, bool>> ReadExpression()
        {
            ICacheServiceBase appCacheService = Unity.Instance.GetService<ICacheServiceBase>();
            tb_Sys_User tempUser = appCacheService.GetItem("user") as tb_Sys_User;
            return (i => i.CompCode == tempUser.CompCode);
        }
	}
}