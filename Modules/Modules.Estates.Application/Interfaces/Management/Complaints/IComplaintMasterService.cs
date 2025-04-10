using System;
using Modules.Estates.Application.DTO.Management.Complaints;

namespace Modules.Estates.Application.Interfaces.Management.Complaints
{
	public interface IComplaintMasterService
	{
		Task<BaseResponseDto> CreateNewComplaint(ComplaintCreateDto values);

		Task<IEnumerable<ComplaintStaffReadDto>> GetComplaintsList();

		Task<IEnumerable<ComplaintReadDto>> GetCustomerComplaintsList(string customerCode_OR_propertyNumber);

        //Task<ComplaintReadDto> GetComplaint(string complaintNumber);

        Task<BaseResponseDto> UpdateComplaint(ComplaintUpdateDto values);
        Task<BaseResponseDto> DeleteComplaint(string ComplaintNumber);


        Task<BaseResponseDto> ReviewComplaint(ComplaintReviewDto values);

        Task<BaseResponseDto> AssignComplaint(ComplaintAssignDto values);

        Task<BaseResponseDto> ResolveComplaint(ComplaintResolutionDto values);

        Task<BaseResponseDto> CancelComplaint(ComplaintCancellationDto values);


    }
}

