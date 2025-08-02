// /**************************************************
// * Company: MindSprings Company Limited
// * Project Name: Modules.Estates.Application
// * Full FileName: /Users/imac5k/Projects/PropertyManagementSolution/pms-api/Modules/Modules.Estates.Application/UseCases/Management/Customer/CustomerServices.cs
// * Author: Boakye Ofori-Atta
// * Email Address: boakye.ofori-atta@mindsprings-gh.com
// * Copyright: © 2024 MindSprings Company Limited
// * Create Date: 25/07/2025 11:42 PM
// * Version: 1.0.1
// * Description: Property Management System
//  **************************************************/

namespace Modules.Estates.Application.UseCases.Management.Customer
{
	public class CustomerServices: ICustomerServices
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly ILogger<CustomerServices> _logger;

        public CustomerServices(IUnitOfWork unitOfWork, ILogger<CustomerServices> logger)
		{
            _unitOfWork = unitOfWork;
            _logger = logger;
        }

        public async Task<ReturnResponsesDto> AssignCustomerToPropertyAsync(AssignCustomertoPropertyDto values)
        {
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
                        Message = $"Property number '" + values.PropertyNumber + "' provided has already been assigned to customer code '" + property.CustomerCode + "'."
                    }
                };
            }

            property.AssignToCustomer(values.CustomerCode);

            _unitOfWork.PropertyMaster.Update(property);
            await _unitOfWork.Complete();

            return new ReturnResponsesDto
            {
                IsSuccess = true,
                SuccessResponse = new SuccessResponseDto
                {
                    Code = StatusCodes.Status200OK,
                    Message = $"Customer code '" + property.CustomerCode + "' assigned to property number '" + values.PropertyNumber + "' successfully."
                }
            };
        }

        public async Task<ReturnResponsesDto> StartCustomerDebitAsync(StopDebitRequestDto values)
        {
            try
            {
                //check if customer exist
                var customer = await _unitOfWork.CustomerMaster.Get(c => c.CustomerCode == values!.CustomerCode);
                if (customer is null)
                {
                    return new ReturnResponsesDto
                    {
                        IsSuccess = false,
                        ErrorResponse = new ErrorResponseDto
                        {
                            Code = StatusCodes.Status404NotFound,
                            Message = $"Customer Code '{values.CustomerCode}' provided does not exist."
                        }
                    };
                }

                if (customer.DebtorStatus == 90)
                {
                    return new ReturnResponsesDto
                    {
                        IsSuccess = false,
                        ErrorResponse = new ErrorResponseDto
                        {
                            Code = StatusCodes.Status409Conflict,
                            Message = $"Stop debit already applied to customer Code '{values.CustomerCode}' provided."
                        }
                    };

                }

                //var debitDetails = new StopDebit
                //{
                //    StopDebitId = 0,
                //    CustomerCode = values!.CustomerCode,
                //    PropertyNumber = values.PropertyNumber,
                //    Reasons = values.Reasons,
                //};

                //update customer master
                customer!.DebtorStatus = 0;
                customer.ModifiedBy = values.CreatedBy;
                customer.ModifiedOn = DateTime.UtcNow;

                _unitOfWork.CustomerMaster.Update(customer);
                //_unitOfWork.StopDebit.Insert(debitDetails);

                await _unitOfWork.Complete();

                return new ReturnResponsesDto
                {
                    IsSuccess = false,
                    ErrorResponse = new ErrorResponseDto
                    {
                        Code = StatusCodes.Status200OK,
                        Message = $"Stop debit applied to customer code '{values.CustomerCode}' successfully."
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

        public async Task<ReturnResponsesDto> StopCustomerDebitAsync(StopDebitRequestDto values)
        {
            try
            {
                //check if customer exist
                var customer = await _unitOfWork.CustomerMaster.Get(c => c.CustomerCode == values!.CustomerCode);
                if (customer is null)
                {
                    return new ReturnResponsesDto
                    {
                        IsSuccess = false,
                        ErrorResponse = new ErrorResponseDto
                        {
                            Code = StatusCodes.Status404NotFound,
                            Message = $"Customer Code '{values.CustomerCode}' provided does not exist."
                        }
                    };
                }

                if(customer.DebtorStatus == 90)
                {
                    return new ReturnResponsesDto
                    {
                        IsSuccess = false,
                        ErrorResponse = new ErrorResponseDto
                        {
                            Code = StatusCodes.Status409Conflict,
                            Message = $"Stop debit already applied to customer Code '{values.CustomerCode}' provided."
                        }
                    };

                }

                var debitDetails = new StopDebit
                {
                    StopDebitId = 0,
                    CustomerCode = values!.CustomerCode,
                    PropertyNumber = values.PropertyNumber,
                    Reasons = values.Reasons,
                };

                //update customer master
                customer!.DebtorStatus = 90; 
                customer.ModifiedBy = values.CreatedBy;
                customer.ModifiedOn = DateTime.UtcNow;

                _unitOfWork.CustomerMaster.Update(customer);
                _unitOfWork.StopDebit.Insert(debitDetails);

                await _unitOfWork.Complete();

                return new ReturnResponsesDto
                {
                    IsSuccess = false,
                    ErrorResponse = new ErrorResponseDto
                    {
                        Code = StatusCodes.Status200OK,
                        Message = $"Stop debit applied to customer code '{values.CustomerCode}' successfully."
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
    }
}

