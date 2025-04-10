using System;

namespace Modules.Estates.Infrastructure.Repositories.Management
{
	public class StopDebitRepository: Repository<StopDebit>, IStopDebitRepository
    {
		public StopDebitRepository(ApplicationDbContext dbContext) : base(dbContext)
        {
		}
	}
}

