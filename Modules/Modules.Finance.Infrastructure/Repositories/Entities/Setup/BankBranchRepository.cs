using System;
namespace Modules.Finance.Infrastructure.Repositories.Entities.Setup
{
	public class BankBranchRepository : Repository<BankBranch>, IBankBranchRepository
	{
		public BankBranchRepository(FinanceDbContext dbContext) : base(dbContext)
		{
		}
	}
}

