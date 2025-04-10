using System;
namespace Modules.Estates.Infrastructure.Repositories.Entities.Setup.Customer
{
	public class NatureOfComplaintRepository : Repository<NatureOfComplaint>, INatureOfComplaintRepository
	{
		public NatureOfComplaintRepository(ApplicationDbContext dbContext) : base(dbContext)
        {
		}
	}
}

