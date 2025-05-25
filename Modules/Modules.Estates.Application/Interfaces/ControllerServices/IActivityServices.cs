// /**************************************************
// * Company: MindSprings Company Limited
// * Project Name: Modules.Estates.Application
// * Full FileName: /Users/imac5k/Projects/PropertyManagementSolution/pms-api/Modules/Modules.Estates.Application/Interfaces/ControllerServices/IActivityServices.cs
// * Author: Boakye Ofori-Atta
// * Email Address: boakye.ofori-atta@mindsprings-gh.com
// * Copyright: © 2024 MindSprings Company Limited
// * Create Date: 24/05/2025 7:31 PM
// * Version: 1.0.1
// * Description: Property Management System
//  **************************************************/


namespace Modules.Estates.Application.Interfaces.ControllerServices
{
	public interface IActivityServices
	{
		// Activity methods
		Task<IEnumerable<ActivityReadDto>> GetActivitiesAsync();
		Task<ReturnResponsesDto> CreateActivityAsync(ActivityCreateDto values);
		Task<ReturnResponsesDto> UpdateActivityAsync(ActivityUpdateDto values);
		Task<ReturnResponsesDto> DeleteActivity(int activityId);

		// Activity type methods
		Task<IEnumerable<ActivityTypeReadDto>> GetActivityTypeAsync();
		Task<ReturnResponsesDto> CreateActivityTypeAsync(ActivityTypeCreateDto values);
		Task<ReturnResponsesDto> UpdateActivityTypeAsync(ActivityTypeUpdateDto values);
		Task<ReturnResponsesDto> DeleteActivityType(int activityTypeId);

		// Activity and Activity Type methods
		Task<List<ActivityAndActivityTypeReadDto>> GetActivityAndActivityTypeAsync();

		// Property Status methods
		Task<IEnumerable<PropertyStatusReadDto>> GetPropertyStatusAsync();
		Task<ReturnResponsesDto> CreatePropertyStatusAsync(PropertyStatusCreateDto values);
		Task<ReturnResponsesDto> UpdatePropertyStatusAsync(PropertyStatusUpdateDto values);
		Task<ReturnResponsesDto> DeletePropertyStatus(int propertyStatusId);
	}
}

