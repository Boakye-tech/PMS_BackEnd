using System;
namespace Modules.Estates.Application.Interfaces.Entities.Setup.Property
{
	public interface IActivityService
	{
        Task<ActivityReadDto> CreateActivityAsync(ActivityCreateDto values);
        Task<ActivityReadDto> UpdateActivityAsync(ActivityUpdateDto values);
        Task<IEnumerable<ActivityReadDto>> GetActivitiesAsync();
        Task<ActivityReadDto> GetActivityAsync(int value);
        //Task<ActivityReadDto> GetAllocationTypeAsync(string value);
    }
}

