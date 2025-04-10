using System;
namespace Modules.Estates.Infrastructure.Repositories.Entities.Setup.Customer
{
	public class ComplaintsRepository : Repository<Complaint>, IComplaintRepository
	{
		public ComplaintsRepository(ApplicationDbContext dbContext) : base(dbContext)
        {
		}
	}
}

