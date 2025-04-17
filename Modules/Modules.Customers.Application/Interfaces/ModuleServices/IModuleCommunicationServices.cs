using System;
namespace Modules.Customers.Application.Interfaces.ModuleServices
{
	public interface ICustomerModuleCommunicationServices
	{
        Task<bool> SendSubmittedComplaintDetailsAsync(ComplaintCreateDto payload);
    }
}

