// /**************************************************
// * Company: MindSprings Company Limited
// * Project Name: Modules.Customers.Application
// * Full FileName: /Users/imac5k/Projects/PropertyManagementSolution/pms-api/Modules/Modules.Customers.Application/Services/CustomerModuleCommunicationServices.cs
// * Author: Boakye Ofori-Atta
// * Email Address: boakye.ofori-atta@mindsprings-gh.com
// * Copyright: © 2024 MindSprings Company Limited
// * Create Date: 28/01/2025 
// * Version: 1.0.1
// * Description: Property Management System
//  **************************************************/



namespace Modules.Customers.Application.Services
{
	public class CustomerModuleCommunicationServices : ICustomerModuleCommunicationServices
    {
        private readonly IDispatchService _dispatchService;

        public CustomerModuleCommunicationServices(IDispatchService dispatchService)
        {
            _dispatchService = dispatchService;
        }

        public async Task<bool> SendSubmittedComplaintDetailsAsync(ComplaintCreateDto payload)
        {
            return await _dispatchService.SendDataAsync("Customer/SubmitComplaint", payload, "POST");
        }

        public async Task<bool> SendModifiedComplaintDetailsAsync(ComplaintUpdateDto payload)
        {
            return await _dispatchService.SendDataAsync("Customer/ModifyComplaint", payload, "PUT");
        }

        public async Task<bool> SendComplaintCancelledAsync(ComplaintCancellationDto payload)
        {
            return await _dispatchService.SendDataAsync("Customer/CancelComplaint", payload, "PUT");
        }

        public async Task<bool> SendComplaintClosedAsync(ComplaintClosedDto payload)
        {
            return await _dispatchService.SendDataAsync("Customer/CloseComplaint", payload, "PUT");
        }

        public async Task<bool> SendComplaintReopenAsync(ComplaintReopenedDto payload)
        {
            return await _dispatchService.SendDataAsync("Customer/ReopenComplaint", payload, "PUT");
        }


        public async Task<bool> SendComplaintAssignedAsync(ComplaintAssignedDto payload)
        {
            return await _dispatchService.SendDataAsync("Customer/AssignComplaint", payload, "PUT");
        }
    }
}

