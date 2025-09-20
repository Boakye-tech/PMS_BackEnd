// /**************************************************
// * Company: MindSprings Company Limited
// * Author: Boakye Ofori-Atta
// * Email Address: boakye.ofori-atta@mindsprings-gh.com
// * Copyright: © 2024 MindSprings Company Limited
// * Create Date: 19/09/2025 5:00 PM
// * Version: 1.0.1
// * Description: Property Management System
//  **************************************************/

using Microsoft.AspNetCore.Http;


namespace Modules.Finance.Application.UseCases.Setups
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

        public async Task<IEnumerable<ServicesReadDto>> GetServicesAsync()
        {
            var services = await _unitOfWork.Services.GetAll();
            return _mapper.Map<IEnumerable<ServicesReadDto>>(services);
        }

        public async Task<ServicesReadDto> GetServicesAsync(int servicesId)
        {
            var service = await _unitOfWork.Services.Get(s => s.ServicesId == servicesId);
            return _mapper.Map<ServicesReadDto>(service);
        }

        public async Task<ReturnResponsesDto> CreateServicesAsync(ServicesCreateDto values)
        {
            try
            {
                var existingService = await _unitOfWork.Services.Get(s => s.ServiceName == values.ServiceName);
                if (existingService != null)
                {
                    return new ReturnResponsesDto
                    {
                        IsSuccess = false,
                        ErrorResponse = new ErrorResponseDto { Code = StatusCodes.Status400BadRequest, Message = "Service already exists." },
                        SuccessResponse = null
                    };
                }

                var service = new Services(values.ServiceName!, values.Description, values.HasFee, values.Amount, values.AccountCode)
                {
                    CreatedBy = values.CreatedBy,
                    CreatedOn = DateTime.Now
                };

                _unitOfWork.Services.Insert(service);
                await _unitOfWork.Complete();

                return new ReturnResponsesDto
                {
                    IsSuccess = true,
                    ErrorResponse = null,
                    SuccessResponse = new SuccessResponseDto { Code = StatusCodes.Status201Created, Message = "Service created successfully." }
                };
            }
            catch (Exception ex)
            {
                return new ReturnResponsesDto
                {
                    IsSuccess = false,
                    ErrorResponse = new ErrorResponseDto { Code = StatusCodes.Status500InternalServerError, Message = ex.Message },
                    SuccessResponse = null
                };
            }
        }

        public async Task<ReturnResponsesDto> UpdateServicesAsync(ServicesUpdateDto values)
        {
            try
            {
                var service = await _unitOfWork.Services.Get(s => s.ServicesId == values.ServicesId);
                if (service == null)
                {
                    return new ReturnResponsesDto
                    {
                        IsSuccess = false,
                        ErrorResponse = new ErrorResponseDto { Code = StatusCodes.Status404NotFound, Message = "Service not found." },
                        SuccessResponse = null
                    };
                }

                var existingService = await _unitOfWork.Services.Get(s => s.ServiceName == values.ServiceName && s.ServicesId != values.ServicesId);
                if (existingService != null)
                {
                    return new ReturnResponsesDto
                    {
                        IsSuccess = false,
                        ErrorResponse = new ErrorResponseDto { Code = StatusCodes.Status400BadRequest, Message = "Service already exists for this department and room." },
                        SuccessResponse = null
                    };
                }

                service.Update(values.ServiceName!, values.Description, values.HasFee, values.Amount, values.AccountCode);
                service.ModifiedBy = values.ModifiedBy;
                service.ModifiedOn = DateTime.Now;

                _unitOfWork.Services.Update(service);
                await _unitOfWork.Complete();

                return new ReturnResponsesDto
                {
                    IsSuccess = true,
                    ErrorResponse = null,
                    SuccessResponse = new SuccessResponseDto { Code = StatusCodes.Status200OK, Message = "Service updated successfully." }
                };
            }
            catch (Exception ex)
            {
                return new ReturnResponsesDto
                {
                    IsSuccess = false,
                    ErrorResponse = new ErrorResponseDto { Code = StatusCodes.Status500InternalServerError, Message = ex.Message },
                    SuccessResponse = null
                };
            }
        }

        public async Task<ReturnResponsesDto> DeleteServicesAsync(int servicesId)
        {
            try
            {
                var service = await _unitOfWork.Services.Get(s => s.ServicesId == servicesId);
                if (service == null)
                {
                    return new ReturnResponsesDto
                    {
                        IsSuccess = false,
                        ErrorResponse = new ErrorResponseDto { Code = StatusCodes.Status404NotFound, Message = "Service not found." },
                        SuccessResponse = null
                    };
                }

                _unitOfWork.Services.Delete(service);
                await _unitOfWork.Complete();

                return new ReturnResponsesDto
                {
                    IsSuccess = true,
                    ErrorResponse = null,
                    SuccessResponse = new SuccessResponseDto { Code = StatusCodes.Status200OK, Message = "Service deleted successfully." }
                };
            }
            catch (Exception ex)
            {
                return new ReturnResponsesDto
                {
                    IsSuccess = false,
                    ErrorResponse = new ErrorResponseDto { Code = StatusCodes.Status500InternalServerError, Message = ex.Message },
                    SuccessResponse = null
                };
            }
        }
    }
}
