using System;
namespace Modules.Estates.Infrastructure.Repositories.Entities.Setup.Property
{
	public class PropertyTypeRepository : Repository<PropertyType>, IPropertyTypeRepository
	{
		public PropertyTypeRepository(ApplicationDbContext dbContext) : base(dbContext)
        {
		}
	}
}

