using System;
namespace Modules.Estates.Infrastructure.Repositories.Entities.Setup.Customer
{
	public class IdentificationTypeRepository : Repository<IdentificationType>, IIdentificationTypeRepository
	{
		public IdentificationTypeRepository(ApplicationDbContext dbContext) : base(dbContext)
        {
		}
	}
}

