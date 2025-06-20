// /**************************************************
// * Company: MindSprings Company Limited
// * Author: Boakye Ofori-Atta
// * Email Address: boakye.ofori-atta@mindsprings-gh.com
// * Copyright: © 2024 MindSprings Company Limited
// * Create Date: 01/01/2025 
// * Version: 1.0.1
// * Description: Property Management System
//  **************************************************/


namespace Modules.Estates.Application.Interfaces.Entities.Setup.Customer;

public interface ICustomerTypeService
{
    Task<CustomerTypeReadDto> AddCustomerTypeAsync(CustomerTypeCreateDto values);
    Task<CustomerTypeReadDto> UpdateCustomerTypeAsync(CustomerTypeUpdateDto values);
    Task<IEnumerable<CustomerTypeReadDto>> GetCustomerTypeAsync();
    Task<CustomerTypeReadDto> GetCustomerTypeAsync(int value);
    Task<CustomerTypeReadDto> GetCustomerTypeAsync(string value);

    Task<CustomerTypeReadDto> DeleteCustomerTyeAsync(int value);
}

