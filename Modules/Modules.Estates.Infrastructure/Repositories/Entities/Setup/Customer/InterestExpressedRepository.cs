using System;
namespace Modules.Estates.Infrastructure.Repositories.Entities.Setup.Customer
{
	public class InterestExpressedRepository : Repository<InterestExpressed>, IInterestExpressedRepository
	{
		public InterestExpressedRepository(ApplicationDbContext dbContext) : base(dbContext)
        {
		}
	}
}

