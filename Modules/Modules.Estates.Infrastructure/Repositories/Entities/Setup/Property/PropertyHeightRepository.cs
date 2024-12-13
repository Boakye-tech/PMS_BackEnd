using System;
namespace Modules.Estates.Infrastructure.Repositories.Entities.Setup.Property
{
	public class PropertyHeightRepository : Repository<PropertyHeight>, IPropertyHeightRepository
	{
		public PropertyHeightRepository(ApplicationDbContext dbContext) : base(dbContext)
        {
		}
	}
}

