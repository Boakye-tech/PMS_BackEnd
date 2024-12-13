using System;
namespace Modules.Finance.Infrastructure.Repositories.Entities.Setup
{
	public class CurrencyAndExchangeRateRepository : Repository<CurrencyAndExchangeRate>, ICurrencyAndExchangeRateRepository
    {
		public CurrencyAndExchangeRateRepository(FinanceDbContext dbContext) : base(dbContext)
		{
		}
	}
}

