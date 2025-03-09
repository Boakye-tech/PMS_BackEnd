using System;
namespace Modules.Finance.Infrastructure.Repositories.Entities.Setup
{
	public class PaymentModeRepository : Repository<PaymentMode>, IPaymentModeRepository
    {
		public PaymentModeRepository(FinanceDbContext dbContext) : base(dbContext)
		{
		}
	}
}

