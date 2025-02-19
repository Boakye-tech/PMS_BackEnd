using System;
namespace Modules.Customers.Application.Interfaces
{
	public interface ICustomerPaymentsService
	{
        Task<GenericResponseDto> AddNewCustomerPaymentDetails(CustomerPaymentsDto values);

    }
}

