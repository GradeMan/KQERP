using System;
using ERP.Domain;
namespace ERP.Data
{
	public interface IFTP_F003_RolesRightRepository : IRepository<FTP_F003_RolesRight>
	{
	}
	public class FTP_F003_RolesRightRepository : AnyRepositoryBase<FTP_F003_RolesRight>, IFTP_F003_RolesRightRepository
	{
		public FTP_F003_RolesRightRepository(IDatabaseFactory databaseFactory)
			: base(databaseFactory)
		{
		}
	}
}