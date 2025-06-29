// /**************************************************
// * Company: MindSprings Company Limited
// * Project Name: Modules.Customers.Domain
// * Full FileName: /Users/imac5k/Projects/PropertyManagementSolution/pms-api/Modules/Modules.Customers.Domain/Interfaces/IUnitOfWork.cs
// * Author: Boakye Ofori-Atta
// * Email Address: boakye.ofori-atta@mindsprings-gh.com
// * Copyright: © 2024 MindSprings Company Limited
// * Create Date: 01/01/2025 
// * Version: 1.0.1
// * Description: Property Management System
//  **************************************************/


namespace Modules.Customers.Domain.Interfaces
{
	public interface IUnitOfWork : IDisposable
    {
        ICustomerDetailsRepository CustomerDetails { get; }
        ICustomerInvoiceRepository CustomerInvoice { get; }
        ICustomerInvoiceItemsRepository CustomerInvoiceItems { get; }
        ICustomerPaymentsRepository CustomerPayment { get; }
        ICustomerTransactionsRepository CustomerTransaction { get; }
        IPropertyDetailsRepository PropertyDetails { get; }

        IComplaintRepository Complaint { get; }
        IComplaintTypeRepository ComplaintType { get; }
        INatureOfComplaintRepository NatureOfComplaint { get; }
        IComplaintHistoryRepository ComplaintHistory { get; }
        IComplaintStatusesRepository ComplaintStatuses { get; }

        //june 28, 2025
        ICustomerOpeningBalancesRepository CustomerOpeningBalances { get; }

        Task<int> Complete();
    }
}

