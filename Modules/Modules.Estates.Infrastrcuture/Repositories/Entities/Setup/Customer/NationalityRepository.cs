using System;
namespace Modules.Estates.Infrastructure.Repositories.Entities.Setup.Customer
{
	public class NationalityRepository : Repository<Nationality>, INationalityRepository
	{
		public NationalityRepository(ApplicationDbContext dbContext) : base(dbContext)
        {
		}
	}
}

