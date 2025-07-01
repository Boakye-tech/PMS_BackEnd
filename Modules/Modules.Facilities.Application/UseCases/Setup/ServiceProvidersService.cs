// /**************************************************
// * Company: MindSprings Company Limited
// * Project Name: Modules.Facilities.Application
// * Full FileName: /Users/imac5k/Projects/PropertyManagementSolution/pms-api/Modules/Modules.Facilities.Application/UseCases/Setup/ServiceProvidersService.cs
// * Author: Boakye Ofori-Atta
// * Email Address: boakye.ofori-atta@mindsprings-gh.com
// * Copyright: © 2024 MindSprings Company Limited
// * Create Date: 01/07/2025 10:45 AM
// * Version: 1.0.1
// * Description: Property Management System
//  **************************************************/

namespace Modules.Facilities.Application.UseCases.Setup
{
    public class ServiceProvidersService : IServiceProvidersService
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;

        public ServiceProvidersService(IUnitOfWork unitOfWork, IMapper mapper)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
        }

        public async Task<ReturnResponsesDto> CreateServiceProvidersAsync(ServiceProvidersCreateDto values)
        {
            try
            {
                var existing = await _unitOfWork.ServiceProviders.Get(c => c.CompanyName == values.companyName);
                if (existing != null)
                {
                    return new ReturnResponsesDto
                    {
                        IsSuccess = false,
                        ErrorResponse = new BaseResponseDto { StatusCode = StatusCodes.Status400BadRequest, StatusMessage = "Service provider already exists." },
                        SuccessResponse = null
                    };
                }
                var provider = ServiceProviders.Create(
                    0,
                    values.companyName,
                    values.phoneNumber,
                    values.emailAddress,
                    values.companyRegistrationNumber,
                    values.tinNumber,
                    values.companyAddress,
                    values.digitalAddress,
                    values.images,
                    values.listOfServices,
                    values.contactPerson_FirstName,
                    values.contactPerson_MiddleName,
                    values.contactPerson_LastName,
                    values.contactPerson_JobTitle,
                    values.contactPerson_PhoneNumber,
                    values.contactPerson_EmailAddress
                );
                provider.CreatedBy = values.createdBy;
                provider.CreatedOn = DateTime.Now;
                _unitOfWork.ServiceProviders.Insert(provider);
                await _unitOfWork.Complete();
                return new ReturnResponsesDto
                {
                    IsSuccess = true,
                    ErrorResponse = null,
                    SuccessResponse = new BaseResponseDto { StatusCode = StatusCodes.Status201Created, StatusMessage = "Service provider created successfully." }
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

        public async Task<ReturnResponsesDto> UpdateServiceProvidersAsync(ServiceProvidersUpdateDto values)
        {
            try
            {
                var provider = await _unitOfWork.ServiceProviders.Get(values.companyID);
                if (provider is null)
                {
                    return new ReturnResponsesDto
                    {
                        IsSuccess = false,
                        ErrorResponse = new BaseResponseDto { StatusCode = StatusCodes.Status404NotFound, StatusMessage = $"Service provider with ID {values.companyID} not found." },
                        SuccessResponse = null
                    };
                }
                provider.Update(
                    values.companyID,
                    values.companyName,
                    values.phoneNumber,
                    values.emailAddress,
                    values.companyRegistrationNumber,
                    values.tinNumber,
                    values.companyAddress,
                    values.digitalAddress,
                    values.images,
                    values.listOfServices,
                    values.contactPerson_FirstName,
                    values.contactPerson_MiddleName,
                    values.contactPerson_LastName,
                    values.contactPerson_JobTitle,
                    values.contactPerson_PhoneNumber,
                    values.contactPerson_EmailAddress
                );
                provider.ModifiedBy = values.modifiedBy;
                provider.ModifiedOn = DateTime.Now;
                _unitOfWork.ServiceProviders.Update(provider);
                await _unitOfWork.Complete();
                return new ReturnResponsesDto
                {
                    IsSuccess = true,
                    ErrorResponse = null,
                    SuccessResponse = new BaseResponseDto { StatusCode = StatusCodes.Status200OK, StatusMessage = "Service provider updated successfully." }
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

        public async Task<IEnumerable<ServiceProvidersReadDto>> GetServiceProvidersAsync()
        {
            var providers = await _unitOfWork.ServiceProviders.GetAll();
            return _mapper.Map<IEnumerable<ServiceProvidersReadDto>>(providers);
        }

        public async Task<ReturnResponsesDto> DeleteServiceProvidersAsync(int serviceProviderId)
        {
            try
            {
                var provider = await _unitOfWork.ServiceProviders.Get(serviceProviderId);
                if (provider == null)
                {
                    return new ReturnResponsesDto
                    {
                        IsSuccess = false,
                        ErrorResponse = new BaseResponseDto { StatusCode = StatusCodes.Status404NotFound, StatusMessage = $"Service provider with ID {serviceProviderId} not found." },
                        SuccessResponse = null
                    };
                }
                _unitOfWork.ServiceProviders.Delete(provider);
                await _unitOfWork.Complete();
                return new ReturnResponsesDto
                {
                    IsSuccess = true,
                    ErrorResponse = null,
                    SuccessResponse = new BaseResponseDto { StatusCode = StatusCodes.Status200OK, StatusMessage = $"Service provider with ID {serviceProviderId} deleted successfully." }
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