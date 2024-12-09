namespace Modules.Estates.Infrastructure.Repositories.Entities.Setup.Property;

public class LandUseTypeRepository : Repository<LandUseType>, ILandUseTypeRepository
{
	public LandUseTypeRepository(ApplicationDbContext dbContext) : base(dbContext)
	{
	}
}

