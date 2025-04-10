
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

        Task<int> Complete();
    }
}

