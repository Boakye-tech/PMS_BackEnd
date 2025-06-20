// /**************************************************
// * Company: MindSprings Company Limited
// * Project Name: Modules.Estates.Application
// * Full FileName: /Users/imac5k/Projects/PropertyManagementSolution/pms-api/Modules/Modules.Estates.Application/UseCases/Setup/Property/ActivityTypeService.cs
// * Author: Boakye Ofori-Atta
// * Email Address: boakye.ofori-atta@mindsprings-gh.com
// * Copyright: © 2024 MindSprings Company Limited
// * Create Date: 01/01/2025 
// * Version: 1.0.1
// * Description: Property Management System
//  **************************************************/

using Microsoft.AspNetCore.Http;


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

        public async Task<IEnumerable<ActivityTypeReadDto>> GetActivityTypeAsync()
        {
            var activityTypes = await _unitOfWork.ActivityType.GetAll();
            return _mapper.Map<IEnumerable<ActivityTypeReadDto>>(activityTypes);
        }

        public async Task<ActivityTypeReadDto> GetActivityTypeAsync(int value)
        {
            var activityType = await _unitOfWork.ActivityType.Get(value);
            return _mapper.Map<ActivityTypeReadDto>(activityType);
        }

        public async Task<ActivityTypeReadDto> GetActivityTypeAsync(string value)
        {
            var activityType = await _unitOfWork.ActivityType.Get(at => at.ActivityTypeName == value);
            return _mapper.Map<ActivityTypeReadDto>(activityType);
        }

        public async Task<ReturnResponsesDto> CreateActivityTypeAsync(ActivityTypeCreateDto values)
        {
            try
            {
                int activityTypeId = 0;

                var activityType = await _unitOfWork.ActivityType.Get(at => at.ActivityTypeName == values.ActivityTypeName);
                if (activityType != null)
                {
                    return new ReturnResponsesDto
                    {
                        IsSuccess = false,
                        ErrorResponse = new ErrorResponseDto { Code = StatusCodes.Status400BadRequest, Message = "Activity Type Name already exists." },
                        SuccessResponse = null
                    };
                }

                var newActivityType = ActivityType.Create(values.ActivityId, activityTypeId, values.ActivityTypeName!, values.ActivityTypeDescription);
                newActivityType.CreatedBy = values.CreatedBy;
                newActivityType.CreatedOn = DateTime.Now;

                _unitOfWork.ActivityType.Insert(newActivityType);
                await _unitOfWork.Complete();

                return new ReturnResponsesDto
                {
                    IsSuccess = true,
                    ErrorResponse = null,
                    SuccessResponse = new SuccessResponseDto { Code = StatusCodes.Status201Created, Message = "Activity Type details created successfully." },
                };
            }
            catch (Exception ex)
            {
                return new ReturnResponsesDto { IsSuccess = false, ErrorResponse = new ErrorResponseDto { Code = StatusCodes.Status500InternalServerError, Message = ex.InnerException?.Message ?? ex.Message }, SuccessResponse = null };
            }
        }

        public async Task<ReturnResponsesDto> UpdateActivityTypeAsync(ActivityTypeUpdateDto values)
        {
            try
            {
                var activityType = await _unitOfWork.ActivityType.Get(values.ActivityTypeId);
                if (activityType == null)
                {
                    return new ReturnResponsesDto
                    {
                        IsSuccess = false,
                        ErrorResponse = new ErrorResponseDto { Code = StatusCodes.Status404NotFound, Message = $"Activity Type with ID {values.ActivityTypeId} not found." },
                        SuccessResponse = null
                    };
                }

                activityType.Update(values.ActivityId, values.ActivityTypeId, values.ActivityTypeName!, values.ActivityTypeDescription);
                activityType.ModifiedBy = values.ModifiedBy;
                activityType.ModifiedOn = DateTime.Now;

                _unitOfWork.ActivityType.Update(activityType);
                await _unitOfWork.Complete();

                return new ReturnResponsesDto
                {
                    IsSuccess = true,
                    ErrorResponse = null,
                    SuccessResponse = new SuccessResponseDto { Code = StatusCodes.Status200OK, Message = "Activity Type details modified successfully." },
                };
            }
            catch (Exception ex)
            {
                return new ReturnResponsesDto { IsSuccess = false, ErrorResponse = new ErrorResponseDto { Code = StatusCodes.Status500InternalServerError, Message = ex.InnerException?.Message ?? ex.Message }, SuccessResponse = null };
            }
        }

        public async Task<ReturnResponsesDto> DeleteActivityType(int activityTypeId)
        {
            try
            {
                var activityType = await _unitOfWork.ActivityType.Get(activityTypeId);
                if (activityType == null)
                {
                    return new ReturnResponsesDto
                    {
                        IsSuccess = false,
                        ErrorResponse = new ErrorResponseDto { Code = StatusCodes.Status404NotFound, Message = $"Activity Type with ID {activityTypeId} not found." },
                        SuccessResponse = null
                    };
                }

                _unitOfWork.ActivityType.Delete(activityType);
                await _unitOfWork.Complete();

                return new ReturnResponsesDto
                {
                    IsSuccess = true,
                    ErrorResponse = null,
                    SuccessResponse = new SuccessResponseDto { Code = StatusCodes.Status200OK, Message = $"Activity Type with ID {activityTypeId} deleted successfully." }
                };
            }
            catch (Exception ex)
            {
                return new ReturnResponsesDto { IsSuccess = false, ErrorResponse = new ErrorResponseDto { Code = StatusCodes.Status500InternalServerError, Message = ex.InnerException?.Message ?? ex.Message }, SuccessResponse = null };
            }
        }
    }
}

