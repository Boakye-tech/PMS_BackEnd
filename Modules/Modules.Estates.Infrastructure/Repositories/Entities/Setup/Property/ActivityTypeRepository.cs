using System;
namespace Modules.Estates.Infrastructure.Repositories.Entities.Setup.Property
{
	public class ActivityTypeRepository : Repository<ActivityType>, IActivityTypeRepository
    {
		public ActivityTypeRepository(ApplicationDbContext dbContext) : base(dbContext)
		{
		}
	}
}

