using System;
namespace Modules.Customers.Application.Interfaces
{
	public interface ICustomerInvoiceService
	{
        Task<GenericResponseDto> AddCustomerInvoiceDetails(CustomerInvoiceDto values);

    }
}

