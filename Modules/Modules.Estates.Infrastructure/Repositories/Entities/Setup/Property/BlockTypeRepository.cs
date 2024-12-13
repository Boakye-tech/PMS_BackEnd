using System;
namespace Modules.Estates.Infrastructure.Repositories.Entities.Setup.Property
{
	public class BlockTypeRepository : Repository<BlockTypes>, IBlockTypeRepository
	{
		public BlockTypeRepository(ApplicationDbContext dbContext) : base(dbContext)
        {
		}
	}
}

