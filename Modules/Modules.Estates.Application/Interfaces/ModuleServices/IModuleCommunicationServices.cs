// /**************************************************
// * Company: MindSprings Company Limited
// * Author: Boakye Ofori-Atta
// * Email Address: boakye.ofori-atta@mindsprings-gh.com
// * Copyright: © 2024 MindSprings Company Limited
// * Create Date: 01/01/2025 
// * Version: 1.0.1
// * Description: Property Management System
//  **************************************************/

namespace Modules.Estates.Application.Interfaces.ModuleServices
{
	public interface IModuleCommunicationServices
	{
        Task<bool> SendIdentificationTypeAsync(IdentificationTypeDto payload);

        Task<bool> SendCustomerDetailsAsync(OnlineCustomerDetailsDto payload);
        Task<bool> SendPropertyDetailsAsync(OnlinePropertyDetailsDto payload);

        Task<bool> SendComplaintTypeDetailsAsync(ComplaintTypeDto payload);
        Task<bool> SendNatureOfComplaintDetailsAsync(NatureOfComplaintDto payload);

        Task<bool> SendComplaintTypeDetailsUpdateAsync(ComplaintTypeDto payload);
        Task<bool> SendNatureOfComplaintDetailsUpdateAsync(NatureOfComplaintDto payload);

        Task<bool> SendSubmittedComplaintDetailsAsync(ComplaintCreateDto payload);
        Task<bool> SendModifiedComplaintDetailsAsync(ComplaintUpdateDto payload);

        Task<bool> SendComplaintAcknowledgmentAsync(ComplaintAcknowledgmentDto payload);


        Task<bool> SendComplaintDispatchAsync(ComplaintDispatchedDto payload);
        Task<bool> SendComplaintAssignedAsync(ComplaintAssignDto payload);
        Task<bool> SendComplaintReviewAsync(ComplaintReviewDto payload);
        Task<bool> SendComplaintResolvedAsync(ComplaintResolutionDto payload);
        Task<bool> SendComplaintReopenAsync(ComplaintReopenedDto payload);
        Task<bool> SendComplaintClosedAsync(ComplaintClosedDto payload);
        Task<bool> SendComplaintCancelledAsync(ComplaintCancellationDto payload);
        Task<bool> SendComplaintInProgressAsync(ComplaintInProgressDto payload);
    }
}

