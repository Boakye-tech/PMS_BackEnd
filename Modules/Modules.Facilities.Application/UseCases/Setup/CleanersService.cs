// /**************************************************
// * Company: MindSprings Company Limited
// * Project Name: Modules.Facilities.Application
// * Full FileName: /Users/imac5k/Projects/PropertyManagementSolution/pms-api/Modules/Modules.Facilities.Application/UseCases/Setup/CleanersService.cs
// * Author: Boakye Ofori-Atta
// * Email Address: boakye.ofori-atta@mindsprings-gh.com
// * Copyright: © 2024 MindSprings Company Limited
// * Create Date: 01/07/2025 10:45 AM
// * Version: 1.0.1
// * Description: Property Management System
//  **************************************************/

namespace Modules.Facilities.Application.UseCases.Setup
{
    public class CleanersService : ICleanersService
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;

        public CleanersService(IUnitOfWork unitOfWork, IMapper mapper)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
        }

        public async Task<ReturnResponsesDto> CreateCleanersAsync(CleanersCreateDto values)
        {
            try
            {
                var existing = await _unitOfWork.Cleaners.Get(c => c.FirstName == values.firstName && c.LastName == values.lastName && c.PhoneNumber == values.phoneNumber);
                if (existing != null)
                {
                    return new ReturnResponsesDto
                    {
                        IsSuccess = false,
                        ErrorResponse = new BaseResponseDto { StatusCode = StatusCodes.Status400BadRequest, StatusMessage = $"Cleaner with this StaffID {values.staffID} already exists." },
                        SuccessResponse = null
                    };
                }
                var cleaner = Cleaners.Create(values.staffID, values.profilePhoto, values.firstName, values.middleName, values.lastName, values.phoneNumber, values.emailAddress, values.jobTitle, values.employmentStatus, values.hireDate, values.assignedProperties, values.images);
                cleaner.CreatedBy = values.createdBy;
                cleaner.CreatedOn = DateTime.Now;
                _unitOfWork.Cleaners.Insert(cleaner);
                await _unitOfWork.Complete();
                return new ReturnResponsesDto
                {
                    IsSuccess = true,
                    ErrorResponse = null,
                    SuccessResponse = new BaseResponseDto { StatusCode = StatusCodes.Status201Created, StatusMessage = "Cleaner created successfully." }
                };
            }
            catch (Exception ex)
            {
                return new ReturnResponsesDto
                {
                    IsSuccess = false,
                    ErrorResponse = new BaseResponseDto { StatusCode = StatusCodes.Status500InternalServerError, StatusMessage = ex.Message },
                    SuccessResponse = null
                };
            }
        }

        public async Task<ReturnResponsesDto> UpdateCleanersAsync(CleanersUpdateDto values)
        {
            try
            {
                var cleaner = await _unitOfWork.Cleaners.Get(c => c.StaffID == values.staffID);
                if (cleaner is null)
                {
                    return new ReturnResponsesDto
                    {
                        IsSuccess = false,
                        ErrorResponse = new BaseResponseDto { StatusCode = StatusCodes.Status404NotFound, StatusMessage = $"Cleaner with ID {values.staffID} not found." },
                        SuccessResponse = null
                    };
                }
                cleaner.Update(values.staffID, values.profilePhoto, values.firstName, values.middleName, values.lastName, values.phoneNumber, values.emailAddress, values.jobTitle, values.employmentStatus, values.hireDate, values.assignedProperties, values.images);
                cleaner.ModifiedBy = values.modifiedBy;
                cleaner.ModifiedOn = DateTime.Now;
                _unitOfWork.Cleaners.Update(cleaner);
                await _unitOfWork.Complete();
                return new ReturnResponsesDto
                {
                    IsSuccess = true,
                    ErrorResponse = null,
                    SuccessResponse = new BaseResponseDto { StatusCode = StatusCodes.Status200OK, StatusMessage = "Cleaner updated successfully." }
                };
            }
            catch (Exception ex)
            {
                return new ReturnResponsesDto
                {
                    IsSuccess = false,
                    ErrorResponse = new BaseResponseDto { StatusCode = StatusCodes.Status500InternalServerError, StatusMessage = ex.Message },
                    SuccessResponse = null
                };
            }
        }

        public async Task<IEnumerable<CleanersReadDto>> GetCleanersAsync()
        {
            var cleaners = await _unitOfWork.Cleaners.GetAll();
            return _mapper.Map<IEnumerable<CleanersReadDto>>(cleaners);
        }

        public async Task<ReturnResponsesDto> DeleteCleanersAsync(int cleanerId)
        {
            try
            {
                var cleaner = await _unitOfWork.Cleaners.Get(cleanerId);
                if (cleaner == null)
                {
                    return new ReturnResponsesDto
                    {
                        IsSuccess = false,
                        ErrorResponse = new BaseResponseDto { StatusCode = StatusCodes.Status404NotFound, StatusMessage = $"Cleaner with ID {cleanerId} not found." },
                        SuccessResponse = null
                    };
                }
                _unitOfWork.Cleaners.Delete(cleaner);
                await _unitOfWork.Complete();
                return new ReturnResponsesDto
                {
                    IsSuccess = true,
                    ErrorResponse = null,
                    SuccessResponse = new BaseResponseDto { StatusCode = StatusCodes.Status200OK, StatusMessage = $"Cleaner with ID {cleanerId} deleted successfully." }
                };
            }
            catch (Exception ex)
            {
                return new ReturnResponsesDto
                {
                    IsSuccess = false,
                    ErrorResponse = new BaseResponseDto { StatusCode = StatusCodes.Status500InternalServerError, StatusMessage = ex.Message },
                    SuccessResponse = null
                };
            }
        }
    }
}