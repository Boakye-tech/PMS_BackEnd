﻿// /**************************************************
// * Company: MindSprings Company Limited
// * Author: Boakye Ofori-Atta
// * Email Address: boakye.ofori-atta@mindsprings-gh.com
// * Copyright: © 2024 MindSprings Company Limited
// * Create Date: 01/01/2025 
// * Version: 1.0.1
// * Description: Property Management System
//  **************************************************/


namespace Modules.Estates.Application.Interfaces.Management.Complaints
{
	public interface IComplaintMasterService
	{
        Task<BaseResponseDto> DeleteComplaint(string ComplaintNumber);


        Task<IEnumerable<ComplaintStaffReadDto>> GetComplaintsList(string searchParameter, int complaintType, int complaintStatus);

		Task<IEnumerable<ComplaintStaffReadDto>> GetCustomerComplaintsList(string customerCode_OR_propertyNumber);

        Task<ComplaintStaffReadDto> GetComplaintSummary(string complaintNumber);

        Task<ComplaintDto> GetComplaintDetails(string complaintNumber);

        Task<List<ComplainantDetailsDto>> GetComplainantDetails(string customerCode);

        Task<List<ComplainantSearchDto>> GetComplainantSearch(string customerCode_OR_propertyNumber);

        Task<BaseResponseDto> CreateNewComplaint(ComplaintCreateDto values);

        Task<BaseResponseDto> UpdateComplaint(ComplaintUpdateDto values);

        Task<BaseResponseDto> AcknowledgeComplaint(ComplaintAcknowledgmentDto values);

        Task<BaseResponseDto> DispatchComplaint(ComplaintDispatchedDto values);

        Task<BaseResponseDto> ReviewComplaint(ComplaintReviewDto values);

        Task<BaseResponseDto> AssignComplaint(ComplaintAssignDto values);

        Task<BaseResponseDto> ResolveComplaint(ComplaintResolutionDto values);

        Task<BaseResponseDto> ReopenComplaint(ComplaintReopenedDto values);

        Task<BaseResponseDto> CloseComplaint(ComplaintClosedDto values);

        Task<BaseResponseDto> CancelComplaint(ComplaintCancellationDto values);

        Task<BaseResponseDto> InProgressComplaint(ComplaintInProgressDto values);
    }
}

