// /**************************************************
// * Company: MindSprings Company Limited
// * Author: Boakye Ofori-Atta
// * Email Address: boakye.ofori-atta@mindsprings-gh.com
// * Copyright: © 2024 MindSprings Company Limited
// * Create Date: 01/03/2025 
// * Version: 1.0.1
// * Description: Property Management System
//  **************************************************/

using Microsoft.AspNetCore.Http;

namespace Modules.Finance.Application.UseCases
{
    public class PaymentTypeService : IPaymentTypeService
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;

        public PaymentTypeService(IUnitOfWork unitOfWork, IMapper mapper)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
        }

        public async Task<IEnumerable<PaymentTypeReadDto>> GetPaymentTypeAsync()
        {
            var types = await _unitOfWork.PaymentType.GetAll();
            return _mapper.Map<IEnumerable<PaymentTypeReadDto>>(types);
        }

        public async Task<PaymentTypeReadDto> GetPaymentTypeAsync(int value)
        {
            var type = await _unitOfWork.PaymentType.Get(value);
            return _mapper.Map<PaymentTypeReadDto>(type);
        }

        public async Task<PaymentTypeReadDto> GetPaymentTypeAsync(string value)
        {
            var type = await _unitOfWork.PaymentType.Get(p => p.PaymentTypes == value);
            return _mapper.Map<PaymentTypeReadDto>(type);
        }

        public async Task<ReturnResponsesDto> CreatePaymentTypeAsync(PaymentTypeCreateDto values)
        {
            try
            {
                var existingType = await _unitOfWork.PaymentType.Get(p => p.PaymentTypes == values.PaymentTypes);
                if (existingType != null)
                {
                    return new ReturnResponsesDto
                    {
                        IsSuccess = false,
                        ErrorResponse = new ErrorResponseDto { Code = StatusCodes.Status400BadRequest, Message = "Payment type already exists." },
                        SuccessResponse = null
                    };
                }

                var type = new PaymentType(values.PaymentTypeId, values.PaymentTypes!)
                {
                    CreatedBy = values.CreatedBy,
                    CreatedOn = DateTime.Now
                };

                _unitOfWork.PaymentType.Insert(type);
                await _unitOfWork.Complete();

                var result = _mapper.Map<PaymentTypeReadDto>(type);

                return new ReturnResponsesDto
                {
                    IsSuccess = true,
                    ErrorResponse = null,
                    SuccessResponse = new SuccessResponseDto { Code = StatusCodes.Status201Created, Message = "Payment type created successfully.", Data = result }
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

        public async Task<ReturnResponsesDto> UpdatePaymentTypeAsync(PaymentTypeUpdateDto values)
        {
            try
            {
                var type = await _unitOfWork.PaymentType.Get(values.PaymentTypeId);
                if (type == null)
                {
                    return new ReturnResponsesDto
                    {
                        IsSuccess = false,
                        ErrorResponse = new ErrorResponseDto { Code = StatusCodes.Status404NotFound, Message = $"Payment type with ID {values.PaymentTypeId} not found." },
                        SuccessResponse = null
                    };
                }

                type.Update(values.PaymentTypeId, values.PaymentTypes!);
                type.ModifiedBy = values.ModifiedBy;
                type.ModifiedOn = DateTime.Now;

                _unitOfWork.PaymentType.Update(type);
                await _unitOfWork.Complete();

                var result = _mapper.Map<PaymentTypeReadDto>(type);

                return new ReturnResponsesDto
                {
                    IsSuccess = true,
                    ErrorResponse = null,
                    SuccessResponse = new SuccessResponseDto { Code = StatusCodes.Status200OK, Message = "Payment type updated successfully.", Data = result }
                };
            }
            catch (Exception ex)
            {
                return new ReturnResponsesDto
                {
                    IsSuccess = false,
                    ErrorResponse = new ErrorResponseDto { Code = StatusCodes.Status500InternalServerError, Message = ex.InnerException?.Message ?? ex.Message },
                    SuccessResponse = null
                };
            }
        }

        public async Task<ReturnResponsesDto> DeletePaymentTypeAsync(int paymentTypeId)
        {
            try
            {
                var type = await _unitOfWork.PaymentType.Get(paymentTypeId);
                if (type == null)
                {
                    return new ReturnResponsesDto
                    {
                        IsSuccess = false,
                        ErrorResponse = new ErrorResponseDto { Code = StatusCodes.Status404NotFound, Message = $"Payment type with ID {paymentTypeId} not found." },
                        SuccessResponse = null
                    };
                }

                _unitOfWork.PaymentType.Delete(type);
                await _unitOfWork.Complete();

                return new ReturnResponsesDto
                {
                    IsSuccess = true,
                    ErrorResponse = null,
                    SuccessResponse = new SuccessResponseDto { Code = StatusCodes.Status200OK, Message = $"Payment type with ID {paymentTypeId} deleted successfully." }
                };
            }
            catch (Exception ex)
            {
                return new ReturnResponsesDto
                {
                    IsSuccess = false,
                    ErrorResponse = new ErrorResponseDto { Code = StatusCodes.Status500InternalServerError, Message = ex.InnerException?.Message ?? ex.Message },
                    SuccessResponse = null
                };
            }
        }
    }
}

