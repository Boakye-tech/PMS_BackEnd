using System;
namespace Modules.Estates.Infrastructure.Repositories.Entities.Setup.Property
{
	public class FacilitiesRepository : Repository<Facilities>, IFacilitiesRepository
	{
		public FacilitiesRepository(ApplicationDbContext dbContext) : base(dbContext)
        {
		}
	}
}

