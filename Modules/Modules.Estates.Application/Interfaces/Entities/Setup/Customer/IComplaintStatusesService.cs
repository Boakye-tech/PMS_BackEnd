using System;
namespace Modules.Estates.Application.Interfaces.Entities.Setup.Customer
{
	public interface IComplaintStatusesService
	{
        Task<ComplaintStatusesReadDto> CreateComplaintStatusAsync(ComplaintStatusesCreateDto values);
        Task<ComplaintStatusesReadDto> UpdateComplaintStatusAsync(ComplaintStatusesUpdateDto values);
        Task<IEnumerable<ComplaintStatusesReadDto>> GetComplaintStatusAsync();

        Task<string> DeleteComplaintStatusAsync(int value);

    }
}

