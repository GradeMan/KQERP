using System;
using ERP.Domain;
namespace ERP.Data
{
	public interface Itb_Sys_ControlsRepository : IRepository<tb_Sys_Controls>
	{
	}
	public class tb_Sys_ControlsRepository : AnyRepositoryBase<tb_Sys_Controls>, Itb_Sys_ControlsRepository
	{
		public tb_Sys_ControlsRepository(IDatabaseFactory databaseFactory)
			: base(databaseFactory)
		{
		}
	}
}