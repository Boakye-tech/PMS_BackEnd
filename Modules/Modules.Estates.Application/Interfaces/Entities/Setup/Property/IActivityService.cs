// /**************************************************
// * Company: MindSprings Company Limited
// * Author: Boakye Ofori-Atta
// * Email Address: boakye.ofori-atta@mindsprings-gh.com
// * Copyright: © 2024 MindSprings Company Limited
// * Create Date: 01/01/2025 
// * Version: 1.0.1
// * Description: Property Management System
//  **************************************************/


namespace Modules.Estates.Application.Interfaces.Entities.Setup.Property
{
    public interface IActivityService
    {
        Task<ReturnResponsesDto> CreateActivityAsync(ActivityCreateDto values);
        Task<ReturnResponsesDto> UpdateActivityAsync(ActivityUpdateDto values);
        Task<IEnumerable<ActivityReadDto>> GetActivitiesAsync();
        Task<ActivityReadDto> GetActivityAsync(int value);
        Task<ActivityReadDto> GetActivityAsync(string value);
        Task<ReturnResponsesDto> DeleteActivity(int activityId);

        Task<List<ActivityAndActivityTypeReadDto>> GeActivityAndActivityTypeAsync();
    }
}

