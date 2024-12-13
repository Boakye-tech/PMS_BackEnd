using System;
namespace Modules.Estates.Infrastructure.Repositories.Entities.Setup.Customer
{
	public class ResidentTypeRepository : Repository<ResidentType>, IResidentTypeRepository
	{
		public ResidentTypeRepository(ApplicationDbContext dbContext) : base(dbContext)
        {
		}
	}
}

