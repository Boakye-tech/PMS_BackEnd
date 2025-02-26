using System;
namespace Modules.Customers.Application.Interfaces
{
	public interface ICustomerInvoiceService
	{
        Task<GenericResponseDto> AddCustomerInvoiceDetails(CustomerInvoiceDto values);

        Task<IEnumerable<CustomerInvoiceSummaryReadDto>> CustomerInvoiceSummary(string invoiceNumber, string customerCode, string propertyNumber, string status, int year);

        Task<IEnumerable<CustomerInvoiceDto>> CustomerInvoiceDetails(string invoiceNumber, string customerCode, string propertyNumber, string status, int year);

    }
}

