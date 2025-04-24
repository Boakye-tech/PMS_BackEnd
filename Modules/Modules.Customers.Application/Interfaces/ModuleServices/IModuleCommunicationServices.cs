using System;
namespace Modules.Customers.Application.Interfaces.ModuleServices
{
	public interface ICustomerModuleCommunicationServices
	{
        Task<bool> SendSubmittedComplaintDetailsAsync(ComplaintCreateDto payload);

        Task<bool> SendComplaintReopenAsync(ComplaintReopenedDto payload);
        Task<bool> SendComplaintClosedAsync(ComplaintClosedDto payload);
        Task<bool> SendComplaintCancelledAsync(ComplaintCancellationDto payload);
    }
}

