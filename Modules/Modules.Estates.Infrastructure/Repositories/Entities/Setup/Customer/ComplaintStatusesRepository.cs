using System;
namespace Modules.Estates.Infrastructure.Repositories.Entities.Setup.Customer
{
	public class ComplaintStatusesRepository : Repository<ComplaintStatuses>, IComplaintStatusesRepository
	{
		public ComplaintStatusesRepository(ApplicationDbContext dbContext) : base(dbContext)
		{
		}
	}
}

