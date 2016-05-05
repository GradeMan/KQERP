using System;
using ERP.Domain;
namespace ERP.Data
{
	public interface Itb_Sys_RolesBtnRepository : IRepository<tb_Sys_RolesBtn>
	{
	}
	public class tb_Sys_RolesBtnRepository : AnyRepositoryBase<tb_Sys_RolesBtn>, Itb_Sys_RolesBtnRepository
	{
		public tb_Sys_RolesBtnRepository(IDatabaseFactory databaseFactory)
			: base(databaseFactory)
		{
		}
	}
}