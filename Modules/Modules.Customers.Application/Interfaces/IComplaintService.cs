using System;
namespace Modules.Customers.Application.Interfaces
{
	public interface IComplaintService
	{
        Task<IEnumerable<ComplaintReadDto>> GetComplaintsList();
        Task<IEnumerable<ComplaintReadDto>> GetComplaintsList(string customerCode_OR_propertyNumber);
        Task<ComplaintReadDto> GetComplaintDetails(string complaintNumber);

        Task<string> AddNewComplaint(ComplaintCreateDto values);

        Task<GenericResponseDto> UpdateComplaint(ComplaintUpdateDto values);
        Task<GenericResponseDto> DeleteComplaint(string ComplaintNumber);

        //Task<GenericResponseDto> ReviewComplaint(ComplaintReviewDto values);

        Task<GenericResponseDto> ReviewComplaint(ComplaintReviewDto values);

        Task<GenericResponseDto> AssignComplaint(ComplaintAssignDto values);

        Task<GenericResponseDto> ResolveComplaint(ComplaintResolutionDto values);

        Task<GenericResponseDto> CancelComplaint(ComplaintCancellationDto values);

    }
}

