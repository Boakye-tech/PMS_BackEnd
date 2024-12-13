using System;
namespace Modules.Finance.Infrastructure.Repositories.Entities.Setup
{
	public class ChartOfAccountsRepository : Repository<ChartOfAccounts>, IChartOfAccountsRepository
    {
		public ChartOfAccountsRepository(FinanceDbContext dbContext) : base(dbContext)
		{
		}
	}
}

