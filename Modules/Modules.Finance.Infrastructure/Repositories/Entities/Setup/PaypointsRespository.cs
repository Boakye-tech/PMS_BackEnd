using System;

namespace Modules.Finance.Infrastructure.Repositories.Entities.Setup
{
	public class PaypointsRespository : Repository<Paypoints>, IPaypointsRespository
    {
		public PaypointsRespository(FinanceDbContext dbContext) : base(dbContext)
        {
		}
	}
}

