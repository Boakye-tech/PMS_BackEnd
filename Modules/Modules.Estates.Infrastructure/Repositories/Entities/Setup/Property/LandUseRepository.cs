namespace Modules.Estates.Infrastructure.Repositories.Entities.Setup.Property;

public class LandUseRepository : Repository<LandUse>, ILandUseRepository
{
    public LandUseRepository(ApplicationDbContext dbContext) : base(dbContext)
    {
    }
}

