// /**************************************************
// * Company: MindSprings Company Limited
// * Project Name: Modules.Facilities.Application
// * Full FileName: /Users/imac5k/Projects/PropertyManagementSolution/pms-api/Modules/Modules.Facilities.Application/UseCases/Setup/ServiceCategoryService.cs
// * Author: Boakye Ofori-Atta
// * Email Address: boakye.ofori-atta@mindsprings-gh.com
// * Copyright: © 2024 MindSprings Company Limited
// * Create Date: 01/07/2025 10:45 AM
// * Version: 1.0.1
// * Description: Property Management System
//  **************************************************/

namespace Modules.Facilities.Application.UseCases.Setup
{
    public class ServiceCategoryService : IServiceCategoryService
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;

        public ServiceCategoryService(IUnitOfWork unitOfWork, IMapper mapper)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
        }

        public async Task<ReturnResponsesDto> CreateServiceCategoryAsync(ServiceCategoryCreateDto values)
        {
            try
            {
                var existing = await _unitOfWork.ServiceCategory.Get(c => c.CategoryId == values.categoryId && c.ServiceId == values.serviceId);
                if (existing != null)
                {
                    return new ReturnResponsesDto
                    {
                        IsSuccess = false,
                        ErrorResponse = new BaseResponseDto { StatusCode = StatusCodes.Status400BadRequest, StatusMessage = "Service category already exists." },
                        SuccessResponse = null
                    };
                }
                var serviceCategory = ServiceCategory.Create(0, values.categoryId, values.serviceId);
                serviceCategory.CreatedBy = values.createdBy;
                serviceCategory.CreatedOn = DateTime.Now;
                _unitOfWork.ServiceCategory.Insert(serviceCategory);
                await _unitOfWork.Complete();
                return new ReturnResponsesDto
                {
                    IsSuccess = true,
                    ErrorResponse = null,
                    SuccessResponse = new BaseResponseDto { StatusCode = StatusCodes.Status201Created, StatusMessage = "Service category created successfully." }
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

        public async Task<ReturnResponsesDto> UpdateServiceCategoryAsync(ServiceCategoryUpdateDto values)
        {
            try
            {
                var serviceCategory = await _unitOfWork.ServiceCategory.Get(values.serviceCategoryId);
                if (serviceCategory is null)
                {
                    return new ReturnResponsesDto
                    {
                        IsSuccess = false,
                        ErrorResponse = new BaseResponseDto { StatusCode = StatusCodes.Status404NotFound, StatusMessage = $"Service category with ID {values.serviceCategoryId} not found." },
                        SuccessResponse = null
                    };
                }
                serviceCategory.Update(values.serviceCategoryId, values.categoryId, values.serviceId);
                serviceCategory.ModifiedBy = values.modifiedBy;
                serviceCategory.ModifiedOn = DateTime.Now;
                _unitOfWork.ServiceCategory.Update(serviceCategory);
                await _unitOfWork.Complete();
                return new ReturnResponsesDto
                {
                    IsSuccess = true,
                    ErrorResponse = null,
                    SuccessResponse = new BaseResponseDto { StatusCode = StatusCodes.Status200OK, StatusMessage = "Service category updated successfully." }
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

        public async Task<IEnumerable<ServiceCategoryReadDto>> GetServiceCategoryAsync()
        {
            var serviceCategories = await _unitOfWork.ServiceCategory.GetAll();
            return _mapper.Map<IEnumerable<ServiceCategoryReadDto>>(serviceCategories);
        }

        public async Task<ReturnResponsesDto> DeleteServiceCategoryAsync(int serviceCategoryId)
        {
            try
            {
                var serviceCategory = await _unitOfWork.ServiceCategory.Get(serviceCategoryId);
                if (serviceCategory == null)
                {
                    return new ReturnResponsesDto
                    {
                        IsSuccess = false,
                        ErrorResponse = new BaseResponseDto { StatusCode = StatusCodes.Status404NotFound, StatusMessage = $"Service category with ID {serviceCategoryId} not found." },
                        SuccessResponse = null
                    };
                }
                _unitOfWork.ServiceCategory.Delete(serviceCategory);
                await _unitOfWork.Complete();
                return new ReturnResponsesDto
                {
                    IsSuccess = true,
                    ErrorResponse = null,
                    SuccessResponse = new BaseResponseDto { StatusCode = StatusCodes.Status200OK, StatusMessage = $"Service category with ID {serviceCategoryId} deleted successfully." }
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