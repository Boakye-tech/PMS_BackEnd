namespace Modules.Estates.Application.UseCases.Setup.Property;

public class ActivityService : IActivityService
{
    private readonly IUnitOfWork _unitOfWork;
    private readonly IMapper _mapper;

    public ActivityService(IUnitOfWork unitOfWork, IMapper mapper)
    {
        _unitOfWork = unitOfWork;
        _mapper = mapper;
    }

    public async Task<ActivityReadDto> CreateActivityAsync(ActivityCreateDto values)
    {
        Activity activity = Activity.Create(values.ActivityId, values.ActivityName, values.ActivityDescription);
        activity.CreatedBy = values.CreatedBy;
        activity.CreatedOn = DateTime.Now;

        _unitOfWork.Activity.Insert(activity);
        await _unitOfWork.Complete();

        return new ActivityReadDto(activity.ActivityId, activity.ActivityName!, activity.ActivityDescription!);

    }

    public async Task<IEnumerable<ActivityReadDto>> GetActivitiesAsync()
    {
        var activities = await _unitOfWork.Activity.GetAll();
        return _mapper.Map<IEnumerable<ActivityReadDto>>(activities);

    }

    public async Task<ActivityReadDto> GetActivityAsync(int value)
    {
        var activity = await _unitOfWork.Activity.Get(value);
        return _mapper.Map<ActivityReadDto>(activity);
    }

    public Task<ActivityReadDto> UpdateActivityAsync(ActivityUpdateDto values)
    {
        throw new NotImplementedException();
    }
}

