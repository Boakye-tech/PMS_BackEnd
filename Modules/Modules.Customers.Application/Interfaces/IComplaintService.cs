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
	public interface IComplaintService
	{
        Task<IEnumerable<ComplaintReadDto>> GetComplaintsList();

        Task<IEnumerable<ComplaintReadDto>> GetComplaintsList(string customerCode_OR_propertyNumber);

        Task<ComplaintDto> GetComplaintDetails(string complaintNumber);

        Task<ComplaintReadDto> GetComplaintSummary(string complaintNumber);

        Task<GenericResponseDto> AddNewComplaint(ComplaintCreateDto values);

        Task<GenericResponseDto> UpdateComplaint(ComplaintUpdateDto values);

        Task<GenericResponseDto> AcknowledgeComplaint(ComplaintAcknowledgmentDto values);

        Task<GenericResponseDto> DispatchComplaint(ComplaintDispatchedDto values);

        Task<GenericResponseDto> ReviewComplaint(ComplaintReviewDto values);

        Task<GenericResponseDto> AssignComplaint(ComplaintAssignDto values);

        Task<GenericResponseDto> ResolveComplaint(ComplaintResolutionDto values);

        Task<GenericResponseDto> ReopenComplaint(ComplaintReopenedDto values);

        Task<GenericResponseDto> CloseComplaint(ComplaintClosedDto values);

        Task<GenericResponseDto> CancelComplaint(ComplaintCancellationDto values);

        Task<GenericResponseDto> InProgressComplaint(ComplaintInProgressDto values);

    }
}

