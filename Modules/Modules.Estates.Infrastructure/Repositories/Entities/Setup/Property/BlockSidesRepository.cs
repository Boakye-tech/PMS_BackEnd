using System;
namespace Modules.Estates.Infrastructure.Repositories.Entities.Setup.Property
{
	public class BlockSidesRepository : Repository<BlockSides>, IBlockSidesRepository
	{
		public BlockSidesRepository(ApplicationDbContext dbContext) : base(dbContext)
        {
		}
	}
}

