namespace Modules.Estates.Application.Repositories.Setup.Customer;

public class CustomerTypeService : ICustomerTypeService
{
	public CustomerTypeService()
	{
	}

    public Task<CustomerTypeReadDto> AddCustomerTypeAsync(CustomerTypeCreateDto values)
    {
        throw new NotImplementedException();
    }

    public Task<IEnumerable<CustomerTypeReadDto>> GetCustomerTypeAsync()
    {
        throw new NotImplementedException();
    }

    public Task<CustomerTypeReadDto> GetCustomerTypeAsync(int value)
    {
        throw new NotImplementedException();
    }

    public Task<CustomerTypeReadDto> GetCustomerTypeAsync(string value)
    {
        throw new NotImplementedException();
    }

    public Task<CustomerTypeReadDto> UpdateCustomerTypeAsync(CustomerTypeUpdateDto values)
    {
        throw new NotImplementedException();
    }
}

