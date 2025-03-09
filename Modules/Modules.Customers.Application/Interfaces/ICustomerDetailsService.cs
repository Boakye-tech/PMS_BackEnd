using System;
using Modules.Customers.Application.Dtos;

namespace Modules.Customers.Application.Interfaces
{
	public interface ICustomerDetailsService
	{
        Task<GenericResponseDto> AddNewCustomerDetails(CustomerDetailsDto values);
        Task<GenericResponseDto> UpdateCustomerDetails(CustomerDetailsDto values);
        Task<GenericResponseDto> DeleteCustomerDetails(string customerCode);

    }
}

