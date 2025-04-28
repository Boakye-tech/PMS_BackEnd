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
	public interface ICustomerTransactionsService
	{
        Task<GenericResponseDto> AddNewCustomerTransactionDetails(CustomerTransactionsDto values);

        Task<IEnumerable<CustomerTransactionsReadDto>> CustomerTransactionDetails(string customerCode, string propertyNumber);

        Task<IEnumerable<CustomerTransactionsReadDto>> CustomerStatement(string customerCode, string propertyNumber, string receipt_or_invoiceNumber, string transactionType, int year);

    }
}

