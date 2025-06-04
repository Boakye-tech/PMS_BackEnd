// /**************************************************
// * Company: MindSprings Company Limited
// * Author: Boakye Ofori-Atta
// * Email Address: boakye.ofori-atta@mindsprings-gh.com
// * Copyright: © 2024 MindSprings Company Limited
// * Create Date: 01/01/2025 
// * Version: 1.0.1
// * Description: Property Management System
//  **************************************************/


namespace Modules.Customers.Application.Interfaces.ModuleServices
{
    public interface ICustomerModuleCommunicationServices
    {
        //Task SendComplaintCreatedAsync(ComplaintCreatedDto complaintCreatedDto);
        Task<bool> SendComplaintAssignedAsync(ComplaintAssignedDto payload);

        Task<bool> SendSubmittedComplaintDetailsAsync(ComplaintCreateDto payload);
        Task<bool> SendModifiedComplaintDetailsAsync(ComplaintUpdateDto payload);

        Task<bool> SendComplaintReopenAsync(ComplaintReopenedDto payload);
        Task<bool> SendComplaintClosedAsync(ComplaintClosedDto payload);
        Task<bool> SendComplaintCancelledAsync(ComplaintCancellationDto payload);
    }
}

