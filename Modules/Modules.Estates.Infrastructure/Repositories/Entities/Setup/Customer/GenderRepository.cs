using System;
namespace Modules.Estates.Infrastructure.Repositories.Entities.Setup.Customer
{
	public class GenderRepository : Repository<Gender>, IGenderRepository
	{
		public GenderRepository(ApplicationDbContext dbContext) : base(dbContext)
        {
		}
	}
}

