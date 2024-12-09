using System;
namespace Modules.Estates.Infrastructure.Repositories.Entities.Setup.Property
{
	public class FloorNumberingRepository : Repository<FloorNumbering>, IFloorNumberingRepository
	{
		public FloorNumberingRepository(ApplicationDbContext dbContext) : base(dbContext)
        {
		}
	}
}

