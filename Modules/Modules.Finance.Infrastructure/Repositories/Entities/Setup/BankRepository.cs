using System;
namespace Modules.Finance.Infrastructure.Repositories.Entities.Setup
{
	public class BankRepository : Repository<Bank>, IBankRepository
	{
		public BankRepository(FinanceDbContext dbContext) : base(dbContext)
		{
		}
	}
}

