// /**************************************************
// * Company: MindSprings Company Limited
// * Author: Boakye Ofori-Atta
// * Email Address: boakye.ofori-atta@mindsprings-gh.com
// * Copyright: © 2024 MindSprings Company Limited
// * Create Date: 01/01/2025 
// * Version: 1.0.1
// * Description: Property Management System
//  **************************************************/


namespace Modules.Estates.Application.UseCases.Setup.Property
{
	public class ActivityTypeService : IActivityTypeService
	{
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;

        public ActivityTypeService(IUnitOfWork unitOfWork, IMapper mapper)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
        }

        public async Task<ActivityTypeReadDto> CreateActivityTypeAsync(ActivityTypeCreateDto values)
        {
            ActivityType activityType = ActivityType.Create(values.ActivityId, values.ActivityTypeId, values.ActivityTypeName, values.ActivityTypeDescription);
            activityType.CreatedBy = values.CreatedBy;
            activityType.CreatedOn = DateTime.Now;

            _unitOfWork.ActivityType.Insert(activityType);
            await _unitOfWork.Complete();

            return new ActivityTypeReadDto(activityType.ActivityId, activityType.ActivityTypeId, activityType.ActivityTypeName!, activityType.ActivityTypeDescription!);

        }

        public async Task<IEnumerable<ActivityTypeReadDto>> GetActivityTypeAsync()
        {
            var activityTypes = await _unitOfWork.ActivityType.GetAll();
            return _mapper.Map<IEnumerable<ActivityTypeReadDto>>(activityTypes);

        }

        public async Task<ActivityTypeReadDto> GetActivityTypeAsync(int value)
        {
            var activityTypes = await _unitOfWork.ActivityType.Get(value);
            return _mapper.Map<ActivityTypeReadDto>(activityTypes);
        }

        public Task<ActivityTypeReadDto> UpdateActivityTypeAsync(ActivityTypeUpdateDto values)
        {
            throw new NotImplementedException();
        }
    }
}

