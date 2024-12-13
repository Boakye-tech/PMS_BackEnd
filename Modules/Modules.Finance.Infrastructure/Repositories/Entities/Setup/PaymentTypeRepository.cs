using System;
namespace Modules.Finance.Infrastructure.Repositories.Entities.Setup
{
	public class PaymentTypeRepository : Repository<PaymentType>, IPaymentTypeRepository
    {
		public PaymentTypeRepository(FinanceDbContext dbContext) : base(dbContext)
		{
		}
	}
}

