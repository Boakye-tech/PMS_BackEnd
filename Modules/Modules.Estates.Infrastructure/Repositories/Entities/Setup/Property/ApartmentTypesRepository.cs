using System;
namespace Modules.Estates.Infrastructure.Repositories.Entities.Setup.Property;

public class ApartmentTypesRepository : Repository<ApartmentTypes>, IApartmentTypesRepository
{
	public ApartmentTypesRepository(ApplicationDbContext dbContext) : base(dbContext)
	{
	}
}

