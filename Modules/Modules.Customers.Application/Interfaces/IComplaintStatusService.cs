using System;
namespace Modules.Customers.Application.Interfaces
{
	public interface IComplaintStatusService
	{
        Task<ComplaintStatusesReadDto> CreateComplaintStatusAsync(ComplaintStatusesCreateDto values);
        Task<ComplaintStatusesReadDto> UpdateComplaintStatusAsync(ComplaintStatusesUpdateDto values);
        Task<IEnumerable<ComplaintStatusesReadDto>> GetComplaintStatusAsync();

        Task<string> DeleteComplaintStatusAsync(int value);
    }
}

