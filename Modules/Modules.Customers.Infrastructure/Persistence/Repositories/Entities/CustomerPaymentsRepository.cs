using System;
namespace Modules.Customers.Infrastructure.Persistence.Repositories.Entities
{
	public class CustomerPaymentsRepository : Repository<CustomerPayments>, ICustomerPaymentsRepository
    {
		public CustomerPaymentsRepository(ApplicationDBContext dbContext) : base(dbContext)
        {
		}
	}
}

