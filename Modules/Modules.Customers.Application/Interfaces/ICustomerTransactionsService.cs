using System;
namespace Modules.Customers.Application.Interfaces
{
	public interface ICustomerTransactionsService
	{
        Task<GenericResponseDto> AddNewCustomerTransactionDetails(CustomerTransactionsDto values);

        Task<IEnumerable<CustomerTransactionsReadDto>> CustomerTransactionDetails(string customerCode);

        Task<IEnumerable<CustomerTransactionsReadDto>> CustomerTransactionDetails(string customerCode, string propertyNumber);



        Task<IEnumerable<CustomerTransactionsReadDto>> CustomerStatementDetails(string customerCode);

        Task<IEnumerable<CustomerTransactionsReadDto>> CustomerStatementDetails(string customerCode, string propertyNumber);

        Task<IEnumerable<CustomerTransactionsReadDto>> CustomerStatementVoucherSearchDetails(string voucherNumber);

        Task<IEnumerable<CustomerTransactionsReadDto>> CustomerStatementSearchDetails(string customerCode, string propertyNumber, string transactionType, DateTime startDate, DateTime endDate);
    }
}

