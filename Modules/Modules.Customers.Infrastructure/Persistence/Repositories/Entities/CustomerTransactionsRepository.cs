using System;
namespace Modules.Customers.Infrastructure.Persistence.Repositories.Entities
{
	public class CustomerTransactionsRepository : Repository<CustomerTransactions>, ICustomerTransactionsRepository
    {
		public CustomerTransactionsRepository(ApplicationDBContext dbContext) : base(dbContext)
        {
		}
	}
}

