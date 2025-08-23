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


using Azure;
using Microsoft.EntityFrameworkCore;
using Modules.Estates.Domain.Entities.Management;
using Modules.Estates.Domain.Entities.Registration.ViewModels;
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

        public async Task<List<CustomerToAssignListDto>> GetCustomersToAssign(string? searchTerm, string? locality, int pageNumber = 1,int pageSize = 50)
        {
            // Normalize search term for case-insensitive matching
            searchTerm = searchTerm?.ToLower().Trim();

            // Base query with LEFT JOINs
            var query =
                from a in _unitOfWork.CustomerMaster.GetQueryable()
                join b in _unitOfWork.Title.GetQueryable()
                    on a.TitleId equals b.TitleId into titleGroup
                from b in titleGroup.DefaultIfEmpty()
                join c in _unitOfWork.Locality.GetQueryable()
                    on a.LocalityId equals c.LocalityId into localityGroup
                from c in localityGroup.DefaultIfEmpty()
                let fullName = ((b.Titles ?? "") + " " +
                                (a.OtherNames ?? "") + " " +
                                (a.SurName ?? "") + " " +
                                (a.CompanyName ?? "")).Trim()
                select new
                {
                    fullName,
                    a.CustomerCode,
                    LocalityName = c.LocalityName ?? ""
                };

            // Apply search filter only if needed
            if (!string.IsNullOrWhiteSpace(searchTerm) || !string.IsNullOrWhiteSpace(locality))
            {
                query = query.Where(c =>
                    c.fullName.ToLower().Contains(searchTerm!) ||
                    c.CustomerCode.ToLower().Contains(searchTerm!) ||
                    c.LocalityName.ToLower().Equals(locality));
            }

            // Apply ordering & paging
            var result = await query
                .OrderBy(c => c.CustomerCode)
                .Skip((pageNumber - 1) * pageSize)
                .Take(pageSize)
                .Select(c => new CustomerToAssignListDto(c.fullName, c.CustomerCode))
                .ToListAsync();

            return result;
        }

        public async Task<PropertyMasterViewDto> GetPropertyMasterDetails(string propertyNumber)
        {
            //check for lease details
            var lease =
                from a in _unitOfWork.PropertyLeaseDetails.GetQueryable()
                join b in _unitOfWork.LeaseTypeAndPeriod.GetQueryable()
                    on a.LeaseTypePeriodId equals b.LeaseTypePeriodId
                where a.PropertyNumber == propertyNumber  
                orderby a.PropertyNumber
                select new PropertyLeaseDetailsReadDto { 
                    PropertyLeaseDetailsId = a.PropertyLeaseDetailsId,
                    PropertyNumber= a.PropertyNumber,
                    CustomerCode = a.CustomerCode,
                    LeaseTypePeriodId = a.LeaseTypePeriodId,
                    LeaseType = b.LeaseType,
                    LeaseStartDate = a.LeaseStartDate,
                    LeaseTerm = a.LeaseTerm,
                    LeaseExpiryDate= a.LeaseExpiryDate,
                    MaxRenewalCount = a.MaxRenewalCount,
                    CurrentRenewalCount = a.CurrentRenewalCount,
                    LastRenewalStartDate = a.LastRenewalStartDate,
                    RenewableTerm = a.RenewableTerm,
                    LastRenewalExpiryDate = a.LastRenewalExpiryDate,
                    LeaseStatus = a.LeaseStatusId.GetEnumDescription(),
                    RenewalStatus = a.RenewalStatusId.GetEnumDescription(),
                };

            var _leaasedetails = await lease.FirstOrDefaultAsync();
            var proertydetails = await _unitOfWork.PropertyMasterView.Get(p => p.PropertyNumber == propertyNumber)!;

            var results = _mapper.Map<PropertyMasterViewDto>(proertydetails);
            results.LeaseDetails = _leaasedetails;

            return results!;
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
                    IsSuccess = true,
                    SuccessResponse = new SuccessResponseDto
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
                        Code = StatusCodes.Status500InternalServerError,
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
                    IsSuccess = true,
                    SuccessResponse = new SuccessResponseDto
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
                        Code = StatusCodes.Status500InternalServerError,
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

        public async Task<ReturnResponsesDto> UnAssignPropertyToCustomerAsync(UnassignPropertyFromCustomerDto values)
        {
            //throw new NotImplementedException();
            try
            {
                //check if property with assigned customer exist
                var property = await _unitOfWork.PropertyMaster.Get(c => c.PropertyNumber!.Value == values.PropertyNumber && c.CustomerCode == values.CustomerCode);
                if (property is null)
                {
                    return new ReturnResponsesDto
                    {
                        IsSuccess = false,
                        ErrorResponse = new ErrorResponseDto
                        {
                            Code = StatusCodes.Status404NotFound,
                            Message = $"Property number '{values.PropertyNumber}' and Customer code '{values.CustomerCode}' provided does not exist."
                        }
                    };
                }

                var result = property.UnAssignToCustomer(values.CustomerCode);

                if (result.IsSuccess == false)
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
                        Message = "Property number '" + values.PropertyNumber + "' unassigned from customer code '" + values.CustomerCode + "' successfully."
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

        public async Task<ReturnResponsesDto> UpdateCadastralAndSitePlan(UpdateCadastralAndSitePlanDto values)
        {
            //throw new NotImplementedException();

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

            property.UpdateCadastralAndSitePlan(values.CadastralPlanNumber!, values.SitePlanNumber!, values.Coordinates);
            _unitOfWork.PropertyMaster.Update(property);

            await _unitOfWork.Complete();

            return new ReturnResponsesDto
            {
                IsSuccess = true,
                SuccessResponse = new SuccessResponseDto
                {
                    Code = StatusCodes.Status404NotFound,
                    Message = $"Cadastral and site plan numbers updated successfully for property number '{values.PropertyNumber}'."
                }
            };

        }

        public async Task<ReturnResponsesDto> UpdateDebtorTypeAndGroupNumber(UpdateDebtorTypeAndGroupNumberDto values)
        {
            //throw new NotImplementedException();
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

            property.UpdateDebtorTypeAndGroupNumber(values.DebtorType, values.GroupNumber);
            _unitOfWork.PropertyMaster.Update(property);

            await _unitOfWork.Complete();

            return new ReturnResponsesDto
            {
                IsSuccess = true,
                SuccessResponse = new SuccessResponseDto
                {
                    Code = StatusCodes.Status404NotFound,
                    Message = $"Debtor type and group number updated successfully for property number '{values.PropertyNumber}'."
                }
            };


        }

        public async Task<ReturnResponsesDto> UpdatePricesFeesAndDates(UpdatePriceFeeAndDatesDto values)
        {
            //throw new NotImplementedException();
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

            property.UpdatePriceFeeAndDates(values.CostPrice, values.SellingPrice, values.RentalFee, values.CurrencyId, values.RightOfEntry, values.DateOfConstruction, values.DateOfTenancy, values.DateTransferedToHos);
            _unitOfWork.PropertyMaster.Update(property);

            await _unitOfWork.Complete();

            return new ReturnResponsesDto
            {
                IsSuccess = true,
                SuccessResponse = new SuccessResponseDto
                {
                    Code = StatusCodes.Status404NotFound,
                    Message = $"Cadastral and site plan numbers updated successfully for property number '{values.PropertyNumber}'."
                }
            };
        }
    }
}

