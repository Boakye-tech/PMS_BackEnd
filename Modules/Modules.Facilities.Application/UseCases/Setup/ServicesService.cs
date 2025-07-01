// /**************************************************
// * Company: MindSprings Company Limited
// * Project Name: Modules.Facilities.Application
// * Full FileName: /Users/imac5k/Projects/PropertyManagementSolution/pms-api/Modules/Modules.Facilities.Application/UseCases/Setup/ServicesService.cs
// * Author: Boakye Ofori-Atta
// * Email Address: boakye.ofori-atta@mindsprings-gh.com
// * Copyright: © 2024 MindSprings Company Limited
// * Create Date: 01/07/2025 11:00 AM
// * Version: 1.0.1
// * Description: Property Management System
//  **************************************************/

namespace Modules.Facilities.Application.UseCases.Setup
{
    public class ServicesService : IServicesService
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;

        public ServicesService(IUnitOfWork unitOfWork, IMapper mapper)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
        }

        public async Task<ReturnResponsesDto> CreateServicesAsync(ServicesCreateDto values)
        {
            try
            {
                var existing = await _unitOfWork.Services.Get(c => c.ServiceName == values.serviceName);
                if (existing != null)
                {
                    return new ReturnResponsesDto
                    {
                        IsSuccess = false,
                        ErrorResponse = new BaseResponseDto { StatusCode = StatusCodes.Status400BadRequest, StatusMessage = "Service already exists." },
                        SuccessResponse = null
                    };
                }
                var service = Services.Create(0, values.serviceName!);
                service.CreatedBy = values.createdBy;
                service.CreatedOn = DateTime.Now;
                _unitOfWork.Services.Insert(service);
                await _unitOfWork.Complete();
                return new ReturnResponsesDto
                {
                    IsSuccess = true,
                    ErrorResponse = null,
                    SuccessResponse = new BaseResponseDto { StatusCode = StatusCodes.Status201Created, StatusMessage = "Service created successfully." }
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

        public async Task<ReturnResponsesDto> UpdateServicesAsync(ServicesUpdateDto values)
        {
            try
            {
                var service = await _unitOfWork.Services.Get(values.serviceId);
                if (service is null)
                {
                    return new ReturnResponsesDto
                    {
                        IsSuccess = false,
                        ErrorResponse = new BaseResponseDto { StatusCode = StatusCodes.Status404NotFound, StatusMessage = $"Service with ID {values.serviceId} not found." },
                        SuccessResponse = null
                    };
                }
                service.Update(values.serviceId, values.serviceName!);
                service.ModifiedBy = values.modifiedBy;
                service.ModifiedOn = DateTime.Now;
                _unitOfWork.Services.Update(service);
                await _unitOfWork.Complete();
                return new ReturnResponsesDto
                {
                    IsSuccess = true,
                    ErrorResponse = null,
                    SuccessResponse = new BaseResponseDto { StatusCode = StatusCodes.Status200OK, StatusMessage = "Service updated successfully." }
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

        public async Task<IEnumerable<ServicesReadDto>> GetServicesAsync()
        {
            var services = await _unitOfWork.Services.GetAll();
            return _mapper.Map<IEnumerable<ServicesReadDto>>(services);
        }

        public async Task<ReturnResponsesDto> DeleteServicesAsync(int serviceId)
        {
            try
            {
                var service = await _unitOfWork.Services.Get(serviceId);
                if (service == null)
                {
                    return new ReturnResponsesDto
                    {
                        IsSuccess = false,
                        ErrorResponse = new BaseResponseDto { StatusCode = StatusCodes.Status404NotFound, StatusMessage = $"Service with ID {serviceId} not found." },
                        SuccessResponse = null
                    };
                }
                _unitOfWork.Services.Delete(service);
                await _unitOfWork.Complete();
                return new ReturnResponsesDto
                {
                    IsSuccess = true,
                    ErrorResponse = null,
                    SuccessResponse = new BaseResponseDto { StatusCode = StatusCodes.Status200OK, StatusMessage = $"Service with ID {serviceId} deleted successfully." }
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