using System;
namespace Modules.Estates.Application.Interfaces.Entities.Setup.Customer
{
	public interface IComplaintTypeService
	{
        Task<ComplaintTypeReadDto> AddComplaintTypeAsync(ComplaintTypeCreateDto values);
        Task<string> DeleteComplaintTypeAsync(int value);
        Task<IEnumerable<ComplaintTypeReadDto>> GetComplaintTypeAsync();
        Task<ComplaintTypeReadDto> UpdateComplaintTypeAsync(ComplaintTypeUpdateDto values);
    }
}

