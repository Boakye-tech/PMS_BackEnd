using System;
using Modules.Estates.Application.DTO.Management.Complaints;

namespace Modules.Estates.Application.Interfaces.Management.Complaints
{
	public interface IComplaintMasterService
	{
        Task<BaseResponseDto> AssignComplaint(ComplaintAssignDto values);

        Task<BaseResponseDto> CancelComplaint(ComplaintCancellationDto values);

        Task<BaseResponseDto> CreateNewComplaint(ComplaintCreateDto values);

        Task<BaseResponseDto> DeleteComplaint(string ComplaintNumber);

        Task<IEnumerable<ComplaintStaffReadDto>> GetComplaintsList();

		Task<IEnumerable<ComplaintStaffReadDto>> GetCustomerComplaintsList(string customerCode_OR_propertyNumber);

        Task<ComplaintStaffReadDto> GetComplaintSummary(string complaintNumber);

        Task<ComplaintDto> GetComplaintDetails(string complaintNumber);


        Task<BaseResponseDto> ReviewComplaint(ComplaintReviewDto values);

        Task<BaseResponseDto> ResolveComplaint(ComplaintResolutionDto values);

        Task<BaseResponseDto> UpdateComplaint(ComplaintUpdateDto values);
    }
}

