using System;
namespace Modules.Customers.Infrastructure.Persistence.Repositories.Entities
{
	public class PropertyDetailsRepository : Repository<PropertyDetails>, IPropertyDetailsRepository
    {
		public PropertyDetailsRepository(ApplicationDBContext dbContext) : base(dbContext)
        {
		}
	}
}

