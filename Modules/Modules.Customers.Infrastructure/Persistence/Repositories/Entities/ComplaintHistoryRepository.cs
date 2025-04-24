using System;
namespace Modules.Customers.Infrastructure.Persistence.Repositories.Entities
{
	public class ComplaintHistoryRepository : Repository<ComplaintHistory>, IComplaintHistoryRepository
    {
		public ComplaintHistoryRepository(ApplicationDBContext dBContext): base(dBContext)
		{
		}
	}
}

