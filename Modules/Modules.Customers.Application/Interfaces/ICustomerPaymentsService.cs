using System;
namespace Modules.Customers.Application.Interfaces
{
	public interface ICustomerPaymentsService
	{
        Task<GenericResponseDto> AddNewCustomerPaymentDetails(CustomerPaymentsDto values);

        //Task<IEnumerable<CustomerPaymentsSummaryDto>> CustomerPaymentSummary(string customerCode);
        //Task<IEnumerable<CustomerPaymentsDto>> CustomerPaymentDetails(string customerCode);

        //Task<IEnumerable<CustomerPaymentsSummaryDto>> CustomerPropertyPaymentSummary(string propertyNumber);
        //Task<IEnumerable<CustomerPaymentsDto>> CustomerPropertyPaymentDetails(string propertyNumber);

        //Task<CustomerPaymentsSummaryDto> CustomerPaymentSearchByReceiptNumber(string receiptNumber);
        //Task<CustomerPaymentsDto> CustomerPaymentDetailsSearchByReceiptNumber(string receiptNumber);


        //Task<IEnumerable<CustomerPaymentsSummaryDto>> CustomerPaymentSummarySearch(string propertyNumber, string paymentMode, DateTime? startDate, DateTime? endDate);
        //Task<IEnumerable<CustomerPaymentsDto>> CustomerPaymentDetailsSearch(string propertyNumber, string paymentMode, DateTime? startDate, DateTime? endDate);

        Task<IEnumerable<CustomerPaymentsDto>> CustomerPaymentDetails(string? customerCode, string propertyNumber, string? receiptNumber, string paymentMode, int? paymentYear);
        Task<IEnumerable<CustomerPaymentsSummaryDto>> CustomerPaymentSummary(string? customerCode, string? propertyNumber, string? receiptNumber, string paymentMode, int? paymentYear);
    }
}

