using System;
namespace Modules.Customers.Application.Interfaces
{
	public interface ICustomerTransactionsService
	{
        Task<GenericResponseDto> AddNewCustomerTransactionDetails(CustomerTransactionsDto values);

        Task<IEnumerable<CustomerTransactionsReadDto>> CustomerTransactionDetails(string customerCode, string propertyNumber);

        Task<IEnumerable<CustomerTransactionsReadDto>> CustomerStatement(string customerCode, string propertyNumber, string receipt_or_invoiceNumber, string transactionType, int year);

    }
}

