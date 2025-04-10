using System;
namespace Modules.Estates.Infrastructure.Repositories.Management
{
	public class ComplaintRepository : Repository<Complaint>, IComplaintRepository
	{
		public ComplaintRepository(ApplicationDbContext dbContext) : base(dbContext)
        {
		}
	}
}

