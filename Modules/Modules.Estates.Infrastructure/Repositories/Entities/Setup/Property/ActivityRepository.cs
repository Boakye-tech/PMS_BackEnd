using System;
namespace Modules.Estates.Infrastructure.Repositories.Entities.Setup.Property
{
	public class ActivityRepository : Repository<Activity>, IActivityRepository
    {
		public ActivityRepository(ApplicationDbContext dbContext) : base(dbContext)
		{
		}
	}
}

