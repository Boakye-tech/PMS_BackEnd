// /**************************************************
// * Company: MindSprings Company Limited
// * Project Name: Modules.Estates.Application
// * Full FileName: /Users/imac5k/Projects/PropertyManagementSolution/pms-api/Modules/Modules.Estates.Application/Interfaces/Entities/Setup/Property/IActivityTypeService.cs
// * Author: Boakye Ofori-Atta
// * Email Address: boakye.ofori-atta@mindsprings-gh.com
// * Copyright: © 2024 MindSprings Company Limited
// * Create Date: 01/01/2025 
// * Version: 1.0.1
// * Description: Property Management System
//  **************************************************/

namespace Modules.Estates.Application.Interfaces.Entities.Setup.Property
{
    public interface IActivityTypeService
    {
        Task<ReturnResponsesDto> CreateActivityTypeAsync(ActivityTypeCreateDto values);
        Task<ReturnResponsesDto> UpdateActivityTypeAsync(ActivityTypeUpdateDto values);
        Task<IEnumerable<ActivityTypeReadDto>> GetActivityTypeAsync();
        Task<ActivityTypeReadDto> GetActivityTypeAsync(int value);
        Task<ActivityTypeReadDto> GetActivityTypeAsync(string value);
        Task<ReturnResponsesDto> DeleteActivityType(int activityTypeId);
    }
}

