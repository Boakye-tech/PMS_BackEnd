// /**************************************************
// * Company: MindSprings Company Limited
// * Project Name: Modules.Estates.Application
// * Full FileName: /Users/imac5k/Projects/PropertyManagementSolution/pms-api/Modules/Modules.Estates.Application/UseCases/Management/Property/PropertyServices.cs
// * Author: Boakye Ofori-Atta
// * Email Address: boakye.ofori-atta@mindsprings-gh.com
// * Copyright: © 2024 MindSprings Company Limited
// * Create Date: 25/07/2025 11:42 PM
// * Version: 1.0.1
// * Description: Property Management System
//  **************************************************/

namespace Modules.Estates.Application.UseCases.Management.Property
{
	public class PropertyServices: IPropertyServices
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly ILogger<CustomerMasterService> _logger;

        public PropertyServices(IUnitOfWork unitOfWork, ILogger<CustomerMasterService> logger)
        {
            _unitOfWork = unitOfWork;
            _logger = logger;
        }

        public async Task<ReturnResponsesDto> AddLeaseDetailsAsync(PropertyLeaseDetailsDto values)
        {
            //throw new NotImplementedException();
            try
            {
                //check if property exist
                var property = await _unitOfWork.PropertyMaster.Get(c => c.PropertyNumber!.Value == values!.PropertyNumber && c.CustomerCode == values.CustomerCode);
                if (property is null)
                {
                    return new ReturnResponsesDto
                    {
                        IsSuccess = false,
                        ErrorResponse = new ErrorResponseDto
                        {
                            Code = StatusCodes.Status404NotFound,
                            Message = $"Property number '{values.PropertyNumber}' and customer code '{values.CustomerCode}' provided does not exist."
                        }
                    };
                }

                return null;
            }
            catch (Exception ex)
            {
                _logger.LogError(ex.ToString());
                return new ReturnResponsesDto
                {
                    IsSuccess = false,
                    ErrorResponse = new ErrorResponseDto
                    {
                        Code = StatusCodes.Status200OK,
                        Message = ex.Message ?? ex.InnerException!.Message
                    }
                };
            }
        }

        public Task<ReturnResponsesDto> AssignPropertyToCustomerAsync(AssignPropertytoCustomerDto values)
        {
            throw new NotImplementedException();
        }

        public Task<ReturnResponsesDto> StartDebitAsync(StopDebitRequestDto values)
        {
            throw new NotImplementedException();
        }

        public async Task<ReturnResponsesDto> StopDebitAsync(StopDebitRequestDto values)
        {
            try
            {
                if (values is null)
                {
                    return new ReturnResponsesDto
                    {
                        IsSuccess = false,
                        ErrorResponse = new ErrorResponseDto
                        {
                            Code = StatusCodes.Status400BadRequest,
                            Message = "Land Use Type Id provided does not exist"
                        }
                    };
                }

                //check if property exist
                var property = await _unitOfWork.PropertyMaster.Get(c => c.PropertyNumber!.Value == values!.PropertyNumber);
                if (property is null)
                {  
                    return new ReturnResponsesDto
                    {
                        IsSuccess = false,
                        ErrorResponse = new ErrorResponseDto
                        {
                            Code = StatusCodes.Status404NotFound,
                            Message = $"Property number '{values.PropertyNumber}' provided does not exist."
                        }
                    };
                }

                var debitDetails = new StopDebit
                {
                    StopDebitId = 0,
                    CustomerCode = values!.CustomerCode,
                    PropertyNumber = values.PropertyNumber,
                    DebtorStatus = 90, //values.DebtorStatus,
                    Reasons = values.Reasons
                };
                debitDetails.CreatedBy = values.ActionBy;
                debitDetails.CreatedOn = DateTime.UtcNow;

                property.StopDebit(values.DebtorStatus);
                
                property.ModifiedBy = values.ActionBy;
                property.ModifiedOn = DateTime.UtcNow;

                _unitOfWork.PropertyMaster.Update(property);
                _unitOfWork.StopDebit.Insert(debitDetails);

                await _unitOfWork.Complete();

                return new ReturnResponsesDto
                {
                    IsSuccess = false,
                    ErrorResponse = new ErrorResponseDto
                    {
                        Code = StatusCodes.Status200OK,
                        Message = $"Stop debit applied to property number '{values.PropertyNumber}' successfully."
                    }
                };

            }
            catch (Exception ex)
            {
                _logger.LogError(ex.ToString());
                return new ReturnResponsesDto
                {
                    IsSuccess = false,
                    ErrorResponse = new ErrorResponseDto
                    {
                        Code = StatusCodes.Status200OK,
                        Message = ex.Message ?? ex.InnerException!.Message
                    }
                };

            }


        }

        public Task<ReturnResponsesDto> SwapAllocationTypeAsync(SwapAllocationTypeDto values)
        {
            throw new NotImplementedException();
        }

        public Task<ReturnResponsesDto> SwapLanUseAndLandUseTypeAsync(SwapLandUseAndLandUseTypeDto values)
        {
            throw new NotImplementedException();
        }

        public Task<ReturnResponsesDto> SwapLocalityAsync(SwapLocalityDto values)
        {
            throw new NotImplementedException();
        }

        public Task<ReturnResponsesDto> UnstopDebitAsync(StopDebitRequestDto values)
        {
            throw new NotImplementedException();
        }
    }
}

