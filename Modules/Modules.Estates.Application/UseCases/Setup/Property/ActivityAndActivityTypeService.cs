// /**************************************************
// * Company: MindSprings Company Limited
// * Project Name: Modules.Estates.Application
// * Full FileName: /Users/imac5k/Projects/PropertyManagementSolution/pms-api/Modules/Modules.Estates.Application/UseCases/Setup/Property/ActivityAndActivityTypeService.cs
// * Author: Boakye Ofori-Atta
// * Email Address: boakye.ofori-atta@mindsprings-gh.com
// * Copyright: © 2024 MindSprings Company Limited
// * Create Date: 20/05/2025 3:19 PM
// * Version: 1.0.1
// * Description: Property Management System
//  **************************************************/
using System;

namespace Modules.Estates.Application.UseCases.Setup.Property
{
	public class ActivityAndActivityTypeService : IActivityAndActivityTypeService
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;

        public ActivityAndActivityTypeService(IUnitOfWork unitOfWork, IMapper mapper)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
        }

        public async Task<List<ActivityAndActivityTypeReadDto>> GeActivityAndActivityTypeAsync()
        {
            // Get all activities and activity types in a single query using Include
            var activities = await _unitOfWork.Activity.GetAll(includes: new List<string> { "ActivityTypes" });

            // Create a dictionary for quick lookup of activity types by activity ID
            var activityAndactivitiesType = activities.Select(activity =>
            {
                var activityTypes = _mapper.Map<List<ActivityTypeReadDto>>(activity.ActivityTypes);
                return new ActivityAndActivityTypeReadDto(
                    new ActivityReadsDto(
                    activity.ActivityId,
                    activity.ActivityName,
                    activity.ActivityDescription!,
                    false),
                    activityTypes
                );
            }).ToList();

            return activityAndactivitiesType;
        }
    }
}

