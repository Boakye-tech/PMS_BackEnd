using System;
namespace Modules.Finance.Infrastructure.Repositories.Entities.Setup
{
	public class BankSortCodesRepository : Repository<BankSortCodes>, IBankSortCodesRepository
	{
		public BankSortCodesRepository(FinanceDbContext dbContext) : base(dbContext)
		{
		}
	}
}

