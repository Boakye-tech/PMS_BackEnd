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

using Modules.Estates.Domain.ValueObjects.Property;

namespace Modules.Estates.Application.UseCases.Management.Property
{
	public class PropertyServices: IPropertyServices
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly ILogger<PropertyServices> _logger;
        private readonly IMapper _mapper;

        public PropertyServices(IUnitOfWork unitOfWork, ILogger<PropertyServices> logger, IMapper mapper)
        {
            _unitOfWork = unitOfWork;
            _logger = logger;
            _mapper = mapper;
        }

        public async Task<ReturnResponsesDto> AddLeaseDetailsAsync(PropertyLeaseDetailsCreateDto values)
        {
            try
            {
                //check if property exist
                var result = await _unitOfWork.PropertyMaster.Get(c => c.PropertyNumber!.Value == values!.PropertyNumber && c.CustomerCode == values.CustomerCode);
                if (result is null)
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

                var property = await _unitOfWork.PropertyMaster.Get(result.PropertyMasterId);

                //check if lease type exist
                var leasetype = await _unitOfWork.LeaseTypeAndPeriod.Get(values.LeaseTypePeriodId);
                if (leasetype is null)
                {
                    return new ReturnResponsesDto
                    {
                        IsSuccess = false,
                        ErrorResponse = new ErrorResponseDto
                        {
                            Code = StatusCodes.Status404NotFound,
                            Message = $"Lease type and period id '{values.LeaseTypePeriodId}' provided does not exist."
                        }
                    };
                }


                //update property master table with lease details
                var leaseResult = property!.UpdateLease(values.LeaseStartDate, values.LeaseTerm);
                if (!leaseResult.IsSuccess)
                {
                    return new ReturnResponsesDto
                    {
                        IsSuccess = false,
                        ErrorResponse = new ErrorResponseDto
                        {
                            Code = StatusCodes.Status400BadRequest,
                            Message = leaseResult.Error
                        }
                    };
                }

                _unitOfWork.PropertyMaster.Update(property);

                //insert into lease details table
                //var leasedetails = _mapper.Map<PropertyLeaseDetails>(values);
                var leasedetails = PropertyLeaseDetails.CreateLeaseDetails(values.PropertyNumber!, values.CustomerCode!, values.LeaseTypePeriodId, values.LeaseStartDate, values.LeaseTerm,
                                                                           values.RenewableTerm, values.MaximumRenewalCount, values.LastRenewalStartDate, values.LeaseStatusId, values.RenewalStatusId);

                if (!leasedetails.IsSuccess)
                {
                    return new ReturnResponsesDto
                    {
                        IsSuccess = false,
                        ErrorResponse = new ErrorResponseDto
                        {
                            Code = StatusCodes.Status400BadRequest,
                            Message = leasedetails.Error
                        }
                    };

                }

                leasedetails.Value.CreatedBy = values.CreatedBy;
                leasedetails.Value.CreatedOn = DateTime.UtcNow;

                _unitOfWork.PropertyLeaseDetails.Insert(leasedetails.Value);

                await _unitOfWork.Complete();

                return new ReturnResponsesDto
                {
                    IsSuccess = true,
                    SuccessResponse = new SuccessResponseDto
                    {
                        Code = StatusCodes.Status200OK,
                        Message = $"Property lease details added successfully."
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
                        Code = StatusCodes.Status500InternalServerError,
                        Message = ex.Message ?? ex.InnerException!.Message
                    }
                };
            }
        }

        public async Task<ReturnResponsesDto> AssignPropertyToCustomerAsync(AssignPropertytoCustomerDto values)
        {
            try
            {
                //check if property exist
                var property = await _unitOfWork.PropertyMaster.Get(c => c.PropertyNumber!.Value == values.PropertyNumber);
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

                if (!string.IsNullOrWhiteSpace(property.CustomerCode))
                {
                    return new ReturnResponsesDto
                    {
                        IsSuccess = false,
                        ErrorResponse = new ErrorResponseDto
                        {
                            Code = StatusCodes.Status409Conflict,
                            Message = "Property number '" + values.PropertyNumber + "' provided has already been assigned to customer code '" + property.CustomerCode + "'."
                        }
                    };
                }


                //check if customer exist
                var customer = await _unitOfWork.CustomerMaster.Get(c => c.CustomerCode == values.CustomerCode);
                if (customer is null)
                {
                    return new ReturnResponsesDto
                    {
                        IsSuccess = false,
                        ErrorResponse = new ErrorResponseDto
                        {
                            Code = StatusCodes.Status404NotFound,
                            Message = $"Customer code '{values.CustomerCode}' provided does not exist."
                        }
                    };
                }

                var result = property.AssignToCustomer(values.CustomerCode);
                if(result.IsSuccess == false)
                {
                    return new ReturnResponsesDto
                    {
                        IsSuccess = false,
                        ErrorResponse = new ErrorResponseDto
                        {
                            Code = StatusCodes.Status204NoContent,
                            Message = result.Error
                        }
                    };
                }

                _unitOfWork.PropertyMaster.Update(property);
                await _unitOfWork.Complete();


                return new ReturnResponsesDto
                {
                    IsSuccess = true,
                    SuccessResponse = new SuccessResponseDto
                    {
                        Code = StatusCodes.Status200OK,
                        Message = "Property number '" + values.PropertyNumber + "' assigned to customer code '" + values.CustomerCode + "' successfully."
                    }
                };
            }
            catch (Exception ex)
            {
                return new ReturnResponsesDto
                {
                    IsSuccess = false,
                    ErrorResponse = new ErrorResponseDto
                    {
                        Code = StatusCodes.Status500InternalServerError,
                        Message = ex.Message ?? ex.InnerException!.Message
                    }
                };

            }
        }

        public async Task<ReturnResponsesDto> RenewLeaseAsync(PropertyLeaseDetailsRenewDto values)
        {
            //check if lease details exist
            var lease = await _unitOfWork.PropertyLeaseDetails.Get(values.PropertyLeaseDetailsId);
            if (lease is null)
            {
                return new ReturnResponsesDto
                {
                    IsSuccess = false,
                    ErrorResponse = new ErrorResponseDto
                    {
                        Code = StatusCodes.Status404NotFound,
                        Message = $"There are no lease details for the lease id provided."
                    }
                };
            }

            //check if initial(main) lease has expired



            //update lease detals
            lease.RenewLease(values.RenewableTerm, values.LastRenewalStartDate, values.LeaseStatusId, values.RenewalStatusId);
            lease.ModifiedBy = values.ModifiedBy;
            lease.ModifiedOn = DateTime.UtcNow;

            _unitOfWork.PropertyLeaseDetails.Update(lease);

            return null!;
        }

        public async Task<ReturnResponsesDto> StartDebitAsync(StopDebitRequestDto values)
        {
            try
            {
                //check if property exist
                var stopdebit = await _unitOfWork.StopDebit.Get(c => c.PropertyNumber == values!.PropertyNumber);
                if (stopdebit is null)
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


                var property = await _unitOfWork.PropertyMaster.Get(c => c.PropertyNumber!.Value == values!.PropertyNumber);
                if (property!.GroupNumber != 90)
                {
                    return new ReturnResponsesDto
                    {
                        IsSuccess = false,
                        ErrorResponse = new ErrorResponseDto
                        {
                            Code = StatusCodes.Status400BadRequest,
                            Message = $"Property number '{values.PropertyNumber}' does not have a stop debit."
                        }
                    };
                }

                property.UpdateDebtorTypeAndGroupNumber(property.DebtorType, stopdebit.PreviousGroupNumber);
                stopdebit.UpdateStopDebit(values.PropertyNumber!, values.CustomerCode!, property.DebtorType, stopdebit.PreviousGroupNumber, values.Reasons!);

                _unitOfWork.PropertyMaster.Update(property);
                _unitOfWork.StopDebit.Update(stopdebit);

                await _unitOfWork.Complete();

                return new ReturnResponsesDto
                {
                    IsSuccess = false,
                    ErrorResponse = new ErrorResponseDto
                    {
                        Code = StatusCodes.Status200OK,
                        Message = $"Start debit applied to property number '{values.PropertyNumber}' successfully."
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

        public async Task<ReturnResponsesDto> StopDebitAsync(StopDebitRequestDto values)
        {
            try
            {
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

                if(property.GroupNumber == 90)
                {
                    return new ReturnResponsesDto
                    {
                        IsSuccess = false,
                        ErrorResponse = new ErrorResponseDto
                        {
                            Code = StatusCodes.Status400BadRequest,
                            Message = $"Property number '{values.PropertyNumber}' already has a stop debit."
                        }
                    };
                }

                var debitDetails = new StopDebit
                {
                    StopDebitId = 0,
                    CustomerCode = values!.CustomerCode,
                    PropertyNumber = values.PropertyNumber,
                    PreviousGroupNumber = property.GroupNumber,
                    GroupNumber = 90,
                    Reasons = values.Reasons
                };
                debitDetails.CreatedBy = values.CreatedBy;
                debitDetails.CreatedOn = DateTime.UtcNow;

                property.StopDebit();
                
                property.ModifiedBy = values.CreatedBy;
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

        public async Task<ReturnResponsesDto> UpdateLeaseDetailsAsync(PropertyLeaseDetailsUpdateDto values)
        {
            //check if lease details exist
            var lease = await _unitOfWork.PropertyLeaseDetails.Get(values!.PropertyLeaseDetailsId);
            if (lease is null)
            {
                return new ReturnResponsesDto
                {
                    IsSuccess = false,
                    ErrorResponse = new ErrorResponseDto
                    {
                        Code = StatusCodes.Status404NotFound,
                        Message = $"No lease details found."
                    }
                };
            }


            //check if property exist
            var result = await _unitOfWork.PropertyMaster.Get(c => c.PropertyNumber!.Value == lease!.PropertyNumber && c.CustomerCode == lease.CustomerCode);
            if (result is null)
            {
                return new ReturnResponsesDto
                {
                    IsSuccess = false,
                    ErrorResponse = new ErrorResponseDto
                    {
                        Code = StatusCodes.Status404NotFound,
                        Message = "Property number and customer code does not exist."
                    }
                };
            }


            var property = await _unitOfWork.PropertyMaster.Get(result.PropertyMasterId);

            //check if lease type exist
            var leasetype = await _unitOfWork.LeaseTypeAndPeriod.Get(values.LeaseTypePeriodId);
            if (leasetype is null)
            {
                return new ReturnResponsesDto
                {
                    IsSuccess = false,
                    ErrorResponse = new ErrorResponseDto
                    {
                        Code = StatusCodes.Status404NotFound,
                        Message = $"Lease type and period id '{values.LeaseTypePeriodId}' provided does not exist."
                    }
                };
            }


            //update property master table with lease details
            var leaseResult = property!.UpdateLease(values.LeaseStartDate, values.LeaseTerm);
            if (!leaseResult.IsSuccess)
            {
                return new ReturnResponsesDto
                {
                    IsSuccess = false,
                    ErrorResponse = new ErrorResponseDto
                    {
                        Code = StatusCodes.Status400BadRequest,
                        Message = leaseResult.Error
                    }
                };
            }

            property.ModifiedBy = values.ModifiedBy;
            property.ModifiedOn = DateTime.UtcNow;
            _unitOfWork.PropertyMaster.Update(property);


            lease.UpdateLeaseDetails(values.LeaseTypePeriodId, values.LeaseStartDate, values.LeaseTerm, values.RenewableTerm, values.MaximumRenewalCount, values.LastRenewalStartDate, values.LeaseStatusId, values.RenewalStatusId);
            lease.ModifiedBy = values.ModifiedBy;
            lease.ModifiedOn = DateTime.UtcNow;

            _unitOfWork.PropertyLeaseDetails.Update(lease);
            await _unitOfWork.Complete();

            return new ReturnResponsesDto
            {
                IsSuccess = true,
                ErrorResponse = new ErrorResponseDto
                {
                    Code = StatusCodes.Status200OK,
                    Message = "Lease details updated successfully."
                }
            };
        }


    }
}

