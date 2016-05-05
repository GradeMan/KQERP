using System;
using ERP.Domain;
namespace ERP.Data
{
	public interface Itb_Sys_RolesControlRepository : IRepository<tb_Sys_RolesControl>
	{
	}
	public class tb_Sys_RolesControlRepository : AnyRepositoryBase<tb_Sys_RolesControl>, Itb_Sys_RolesControlRepository
	{
		public tb_Sys_RolesControlRepository(IDatabaseFactory databaseFactory)
			: base(databaseFactory)
		{
		}
	}
}