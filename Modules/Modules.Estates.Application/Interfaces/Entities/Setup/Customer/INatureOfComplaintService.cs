using System;
namespace Modules.Estates.Application.Interfaces.Entities.Setup.Customer
{
	public interface INatureOfComplaintService
	{
        Task<NatureOfComplaintReadDto> AddNatureOfComplaintAsync(NatureOfComplaintCreateDto values);
        Task<NatureOfComplaintReadDto> UpdateNatureOfComplaintAsync(NatureOfComplaintUpdateDto values);
        Task<string> DeleteNatureOfComplaintAsync(int value);
        Task<IEnumerable<NatureOfComplaintReadDto>> GetNatureOfComplaintAsync();
    }
}

