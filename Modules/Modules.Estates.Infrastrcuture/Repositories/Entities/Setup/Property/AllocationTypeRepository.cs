namespace Modules.Estates.Infrastructure.Repositories.Entities.Setup.Property;

public class AllocationTypeRepository: Repository<AllocationType>, IAllocationTypeRepository
{
	public AllocationTypeRepository(ApplicationDbContext dbContext) : base(dbContext)
    {
	}
}

