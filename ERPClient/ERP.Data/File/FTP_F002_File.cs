using System;
using ERP.Domain;
namespace ERP.Data
{
	public interface IFTP_F002_FileRepository : IRepository<FTP_F002_File>
	{
	}
	public class FTP_F002_FileRepository : AnyRepositoryBase<FTP_F002_File>, IFTP_F002_FileRepository
	{
		public FTP_F002_FileRepository(IDatabaseFactory databaseFactory)
			: base(databaseFactory)
		{
		}
	}
}