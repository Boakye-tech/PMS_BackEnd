using System;
namespace Modules.Estates.Infrastructure.Repositories.Entities.Setup.Customer
{
	public class OwnershipTypeRepository : Repository<OwnershipType>, IOwnershipTypeRepository
    {
		public OwnershipTypeRepository(ApplicationDbContext dbContext) : base(dbContext)
        {
		}
	}
}

