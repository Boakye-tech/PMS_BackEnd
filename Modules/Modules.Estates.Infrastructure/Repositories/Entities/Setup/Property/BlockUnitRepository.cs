using System;
namespace Modules.Estates.Infrastructure.Repositories.Entities.Setup.Property
{
	public class BlockUnitRepository : Repository<BlockUnit>, IBlockUnitRepository
	{
		public BlockUnitRepository(ApplicationDbContext dbContext) : base(dbContext)
        {
		}
	}
}

