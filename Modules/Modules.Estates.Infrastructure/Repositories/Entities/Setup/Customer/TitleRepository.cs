using System;
namespace Modules.Estates.Infrastructure.Repositories.Entities.Setup.Customer
{
	public class TitleRepository : Repository<Title>, ITitleRepository
	{
		public TitleRepository(ApplicationDbContext dbContext) : base(dbContext)
        {
		}
	}
}

