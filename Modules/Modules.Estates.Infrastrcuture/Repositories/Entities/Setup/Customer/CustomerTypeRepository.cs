namespace Modules.Estates.Infrastructure.Repositories.Entities.Setup.Customer;

public class CustomerTypeRepository : Repository<CustomerType>, ICustomerTypeRepository
{
	public CustomerTypeRepository(ApplicationDbContext dbContext) : base(dbContext)
    {
	}
}

