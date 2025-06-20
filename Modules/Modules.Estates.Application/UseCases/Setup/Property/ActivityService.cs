// /**************************************************
// * Company: MindSprings Company Limited
// * Project Name: Modules.Estates.Application
// * Full FileName: /Users/imac5k/Projects/PropertyManagementSolution/pms-api/Modules/Modules.Estates.Application/UseCases/Setup/Property/ActivityService.cs
// * Author: Boakye Ofori-Atta
// * Email Address: boakye.ofori-atta@mindsprings-gh.com
// * Copyright: © 2024 MindSprings Company Limited
// * Create Date: 01/01/2025 
// * Version: 1.0.1
// * Description: Property Management System
//  **************************************************/

using Microsoft.AspNetCore.Http;


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

    public async Task<ActivityReadDto> GetActivityAsync(string value)
    {
        var activity = await _unitOfWork.Activity.Get(a => a.ActivityName == value);
        return _mapper.Map<ActivityReadDto>(activity);
    }

    public async Task<ReturnResponsesDto> CreateActivityAsync(ActivityCreateDto values)
    {
        try
        {
            int activityId = 0;

            var activity = await _unitOfWork.Activity.Get(a => a.ActivityName == values.ActivityName);
            if (activity != null)
            {
                return new ReturnResponsesDto
                {
                    IsSuccess = false,
                    ErrorResponse = new ErrorResponseDto { Code = StatusCodes.Status400BadRequest, Message = "Activity Name already exists." },
                    SuccessResponse = null
                };
            }

            var newActivity = Activity.Create(activityId, values.ActivityName!, values.ActivityDescription);
            newActivity.CreatedBy = values.CreatedBy;
            newActivity.CreatedOn = DateTime.Now;

            _unitOfWork.Activity.Insert(newActivity);
            await _unitOfWork.Complete();

            return new ReturnResponsesDto
            {
                IsSuccess = true,
                ErrorResponse = null,
                SuccessResponse = new SuccessResponseDto { Code = StatusCodes.Status201Created, Message = "Activity details created successfully." },
            };
        }
        catch (Exception ex)
        {
            return new ReturnResponsesDto { IsSuccess = false, ErrorResponse = new ErrorResponseDto { Code = StatusCodes.Status500InternalServerError, Message = ex.InnerException?.Message ?? ex.Message }, SuccessResponse = null };
        }
    }

    public async Task<ReturnResponsesDto> UpdateActivityAsync(ActivityUpdateDto values)
    {
        try
        {
            var activity = await _unitOfWork.Activity.Get(values.ActivityId);
            if (activity == null)
            {
                throw new Exception($"Activity with ID {values.ActivityId} not found.");
            }

            activity.Update(values.ActivityId, values.ActivityName!, values.ActivityDescription);
            activity.ModifiedBy = values.ModifiedBy;
            activity.ModifiedOn = DateTime.Now;

            _unitOfWork.Activity.Update(activity);
            await _unitOfWork.Complete();

            return new ReturnResponsesDto
            {
                IsSuccess = true,
                ErrorResponse = null,
                SuccessResponse = new SuccessResponseDto { Code = StatusCodes.Status200OK, Message = "Activity details modified successfully." },
            };

        }
        catch (Exception ex)
        {
            return new ReturnResponsesDto { IsSuccess = false, ErrorResponse = new ErrorResponseDto { Code = StatusCodes.Status500InternalServerError, Message = ex.InnerException?.Message ?? ex.Message }, SuccessResponse = null };
        }
    }

    public async Task<ReturnResponsesDto> DeleteActivity(int activityId)
    {
        try
        {
            var activity = await _unitOfWork.Activity.Get(activityId);
            if (activity == null)
            {
                return new ReturnResponsesDto
                {
                    IsSuccess = false,
                    ErrorResponse = new ErrorResponseDto { Code = StatusCodes.Status404NotFound, Message = $"Activity with ID {activityId} not found." },
                    SuccessResponse = null
                };
            }

            _unitOfWork.Activity.Delete(activity);
            await _unitOfWork.Complete();

            return new ReturnResponsesDto
            {
                IsSuccess = true,
                ErrorResponse = null,
                SuccessResponse = new SuccessResponseDto { Code = StatusCodes.Status200OK, Message = $"Activity with ID {activityId} deleted successfully." }
            };
        }
        catch (Exception ex)
        {
            return new ReturnResponsesDto { IsSuccess = false, ErrorResponse = new ErrorResponseDto { Code = StatusCodes.Status500InternalServerError, Message = ex.InnerException?.Message ?? ex.Message }, SuccessResponse = null };
        }
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

