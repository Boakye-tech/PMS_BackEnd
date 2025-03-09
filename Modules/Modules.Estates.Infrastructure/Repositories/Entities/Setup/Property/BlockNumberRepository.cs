using System;
namespace Modules.Estates.Infrastructure.Repositories.Entities.Setup.Property
{
	public class BlockNumberRepository : Repository<BlockNumber>, IBlockNumberRepository
	{
		public BlockNumberRepository(ApplicationDbContext dbContext) : base(dbContext)
		{
		}
	}
}

