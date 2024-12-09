namespace Modules.Estates.Infrastructure.Repositories.Entities.Setup.Property;

public class LocalityRepository: Repository<Locality>, ILocalityRepository
{
	public LocalityRepository(ApplicationDbContext dbContext) : base(dbContext)
    {
	}
}

