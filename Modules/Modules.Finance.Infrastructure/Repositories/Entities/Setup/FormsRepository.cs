using System;
namespace Modules.Finance.Infrastructure.Repositories.Entities.Setup
{
	public class FormsRepository : Repository<Forms>, IFormsRepository
    {
		public FormsRepository(FinanceDbContext dbContext) : base(dbContext)
		{
		}
	}
}

