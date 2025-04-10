using System;
namespace Modules.Estates.Infrastructure.Repositories.Entities.Setup.Customer
{
	public class ComplaintTypeRepository : Repository<ComplaintType>, IComplaintTypeRepository
    {
		public ComplaintTypeRepository(ApplicationDbContext dbContext) : base(dbContext)
        {
		}
	}
}

