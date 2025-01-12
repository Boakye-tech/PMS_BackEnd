using System;
namespace Modules.Customers.Infrastructure.Persistence.Repositories.Entities
{
	public class CustomerInvoiceItemsRepository : Repository<CustomerInvoiceItems>, ICustomerInvoiceItemsRepository
    {
		public CustomerInvoiceItemsRepository(ApplicationDBContext dbContext) : base(dbContext)
        {
		}
	}
}

