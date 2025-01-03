using System;
namespace Modules.Estates.Application.Interfaces.Entities.Setup.Property
{
	public interface IActivityTypeService
	{
        Task<ActivityTypeReadDto> CreateActivityTypeAsync(ActivityTypeCreateDto values);
        Task<ActivityTypeReadDto> UpdateActivityTypeAsync(ActivityTypeUpdateDto values);
        Task<IEnumerable<ActivityTypeReadDto>> GetActivityTypeAsync();
        Task<ActivityTypeReadDto> GetActivityTypeAsync(int value);
        //Task<ActivityTypeReadDto> GetActivityTypeAsync(string value);
    }
}

