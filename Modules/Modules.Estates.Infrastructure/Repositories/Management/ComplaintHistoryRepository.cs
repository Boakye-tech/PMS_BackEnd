using System;
namespace Modules.Estates.Infrastructure.Repositories.Management
{
	public class ComplaintHistoryRepository : Repository<ComplaintHistory>, IComplaintHistoryRepository
    {
		public ComplaintHistoryRepository(ApplicationDbContext dbContext) : base(dbContext)
        {
		}
	}
}

