using System;
namespace Modules.Estates.Infrastructure.Repositories.Registration
{
	public class PropertyMasterRepository : Repository<PropertyMaster>, IPropertyMasterRepository
    {
		public PropertyMasterRepository(ApplicationDbContext dbContext ) : base(dbContext)
		{
		}
	}
}

