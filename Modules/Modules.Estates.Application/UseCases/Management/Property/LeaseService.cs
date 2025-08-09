// /**************************************************
// * Company: MindSprings Company Limited
// * Project Name: Modules.Estates.Application
// * Full FileName: /Users/imac5k/Projects/PropertyManagementSolution/pms-api/Modules/Modules.Estates.Application/UseCases/Management/Property/LeaseService.cs
// * Author: Boakye Ofori-Atta
// * Email Address: boakye.ofori-atta@mindsprings-gh.com
// * Copyright: © 2024 MindSprings Company Limited
// * Create Date: 09/08/2025 7:19 AM
// * Version: 1.0.1
// * Description: Property Management System
//  **************************************************/
using System;
using Modules.Estates.Domain.ValueObjects.Property;

namespace Modules.Estates.Application.UseCases.Management.Property
{
	public class LeaseService: ILeaseService
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly ILogger<LeaseService> _logger;
        //private readonly IMapper _mapper;

        public LeaseService(IUnitOfWork unitOfWork, ILogger<LeaseService> logger) //, IMapper mapper
        {
            _unitOfWork = unitOfWork;
            _logger = logger;
            //_mapper = mapper;
        }

        private bool IsEligibleForRenewal(PropertyLeaseDetailsReadDto lease)
        {
            return lease.CurrentRenewalCount < lease.MaxRenewalCount;
        }

        //private DateTime GetLastLeaseEndDate(PropertyLeaseDetailsReadDto lease)
        //{
        //    if (lease.CurrentRenewalCount == 0)
        //        return lease.LeaseExpiryDate;
        //    else
        //        return lease.LastRenewalExpiryDate ?? lease.LeaseExpiryDate;
        //}

        //public async Task<Result> ApproveLeaseRenewalAsync(Guid leaseId)
        //{
        //    var lease = await _leaseRepository.GetByIdAsync(leaseId);
        //    if (!IsEligibleForRenewal(lease))
        //        return Result.Failure("Lease has exceeded max renewals.");

        //    lease.CurrentRenewalCount++;
        //    lease.LastRenewalStartDate = GetLastLeaseEndDate(lease);
        //    lease.LeaseStatus = LeaseStatus.Active;
        //    lease.RenewalStatus = RenewalStatus.Approved;

        //    await _unitOfWork.SaveChangesAsync();
        //    return Result.Success("Renewal approved.");
        //}

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
                                                                           values.RenewableTerm, values.MaximumRenewalCount, values.LeaseStatusId, values.RenewalStatusId);

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


            lease.UpdateLeaseDetails(values.LeaseTypePeriodId, values.LeaseStartDate, values.LeaseTerm, values.RenewableTerm, values.MaximumRenewalCount, values.LeaseStatusId, values.RenewalStatusId);
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

