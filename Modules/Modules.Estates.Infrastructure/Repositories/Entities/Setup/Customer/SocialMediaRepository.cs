using System;
namespace Modules.Estates.Infrastructure.Repositories.Entities.Setup.Customer
{
	public class SocialMediaRepository : Repository<SocialMedia>, ISocialMediaRepository
	{
		public SocialMediaRepository(ApplicationDbContext dbContext) : base(dbContext)
        {
		}
	}
}

