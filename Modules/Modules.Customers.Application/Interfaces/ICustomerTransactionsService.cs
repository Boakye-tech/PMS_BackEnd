using System;
namespace Modules.Customers.Application.Interfaces
{
	public interface ICustomerTransactionsService
	{
        Task<GenericResponseDto> AddNewCustomerTransactionDetails(CustomerTransactionsDto values);

        Task<IEnumerable<CustomerTransactionsReadDto>> CustomerTransactionDetails(string customerCode);

        Task<IEnumerable<CustomerTransactionsReadDto>> CustomerTransactionDetails(string customerCode, string propertyNumber);
    }
}

