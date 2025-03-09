namespace Modules.Estates.Application.Interfaces.Entities.Setup.Customer;

public interface ICustomerTypeService
{
    Task<CustomerTypeReadDto> AddCustomerTypeAsync(CustomerTypeCreateDto values);
    Task<CustomerTypeReadDto> UpdateCustomerTypeAsync(CustomerTypeUpdateDto values);
    Task<IEnumerable<CustomerTypeReadDto>> GetCustomerTypeAsync();
    Task<CustomerTypeReadDto> GetCustomerTypeAsync(int value);
    Task<CustomerTypeReadDto> GetCustomerTypeAsync(string value);

    Task<string> DeleteCustomerTyeAsync(int value);
}

