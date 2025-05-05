// /**************************************************
// * Company: MindSprings Company Limited
// * Author: Boakye Ofori-Atta
// * Email Address: boakye.ofori-atta@mindsprings-gh.com
// * Copyright: © 2024 MindSprings Company Limited
// * Create Date: 01/01/2025 
// * Version: 1.0.1
// * Description: Property Management System
//  **************************************************/


namespace Modules.Customers.Application.Interfaces
{
	public interface ICustomerInvoiceService
	{
        Task<GenericResponseDto> AddCustomerInvoiceDetails(CustomerInvoiceDto values);

        Task<IEnumerable<CustomerInvoiceSummaryReadDto>> CustomerInvoiceSummary(string invoiceNumber, string customerCode, string propertyNumber, string status, int year);

        Task<IEnumerable<CustomerInvoiceDto>> CustomerInvoiceDetails(string invoiceNumber, string customerCode, string propertyNumber, string status, int year);

    }
}

