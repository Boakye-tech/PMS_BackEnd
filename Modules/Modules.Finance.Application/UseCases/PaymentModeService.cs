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
    public class PaymentModeService : IPaymentModeService
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;

        public PaymentModeService(IUnitOfWork unitOfWork, IMapper mapper)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
        }

        public async Task<IEnumerable<PaymentModeReadDto>> GetPaymentModeAsync()
        {
            var modes = await _unitOfWork.PaymentMode.GetAll();
            return _mapper.Map<IEnumerable<PaymentModeReadDto>>(modes);
        }

        public async Task<PaymentModeReadDto> GetPaymentModeAsync(int value)
        {
            var mode = await _unitOfWork.PaymentMode.Get(value);
            return _mapper.Map<PaymentModeReadDto>(mode);
        }

        public async Task<PaymentModeReadDto> GetPaymentModeAsync(string value)
        {
            var mode = await _unitOfWork.PaymentMode.Get(p => p.PaymentModes == value);
            return _mapper.Map<PaymentModeReadDto>(mode);
        }

        public async Task<ReturnResponsesDto> CreatePaymentModeAsync(PaymentModeCreateDto values)
        {
            try
            {
                var existingMode = await _unitOfWork.PaymentMode.Get(p => p.PaymentModes == values.PaymentModes);
                if (existingMode != null)
                {
                    return new ReturnResponsesDto
                    {
                        IsSuccess = false,
                        ErrorResponse = new ErrorResponseDto { Code = StatusCodes.Status400BadRequest, Message = "Payment mode already exists." },
                        SuccessResponse = null
                    };
                }

                var mode = new PaymentMode(values.PaymentModeId, values.PaymentModes!)
                {
                    CreatedBy = values.CreatedBy,
                    CreatedOn = DateTime.Now
                };

                _unitOfWork.PaymentMode.Insert(mode);
                await _unitOfWork.Complete();

                var result = _mapper.Map<PaymentModeReadDto>(mode);

                return new ReturnResponsesDto
                {
                    IsSuccess = true,
                    ErrorResponse = null,
                    SuccessResponse = new SuccessResponseDto { Code = StatusCodes.Status201Created, Message = "Payment mode created successfully.", Data = result }
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

        public async Task<ReturnResponsesDto> UpdatePaymentModeAsync(PaymentModeUpdateDto values)
        {
            try
            {
                var mode = await _unitOfWork.PaymentMode.Get(values.PaymentModeId);
                if (mode == null)
                {
                    return new ReturnResponsesDto
                    {
                        IsSuccess = false,
                        ErrorResponse = new ErrorResponseDto { Code = StatusCodes.Status404NotFound, Message = "Payment mode not found." },
                        SuccessResponse = null
                    };
                }

                var existingMode = await _unitOfWork.PaymentMode.Get(p => p.PaymentModes == values.PaymentModes && p.PaymentModeId != values.PaymentModeId);
                if (existingMode != null)
                {
                    return new ReturnResponsesDto
                    {
                        IsSuccess = false,
                        ErrorResponse = new ErrorResponseDto { Code = StatusCodes.Status400BadRequest, Message = "Payment mode already exists." },
                        SuccessResponse = null
                    };
                }

                mode.Update(values.PaymentModeId, values.PaymentModes!);
                mode.ModifiedBy = values.Modified;
                mode.ModifiedOn = DateTime.Now;

                _unitOfWork.PaymentMode.Update(mode);
                await _unitOfWork.Complete();

                var result = _mapper.Map<PaymentModeReadDto>(mode);

                return new ReturnResponsesDto
                {
                    IsSuccess = true,
                    ErrorResponse = null,
                    SuccessResponse = new SuccessResponseDto { Code = StatusCodes.Status200OK, Message = "Payment mode updated successfully.", Data = result }
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

        public async Task<ReturnResponsesDto> DeletePaymentModeAsync(int paymentModeId)
        {
            try
            {
                var mode = await _unitOfWork.PaymentMode.Get(paymentModeId);
                if (mode == null)
                {
                    return new ReturnResponsesDto
                    {
                        IsSuccess = false,
                        ErrorResponse = new ErrorResponseDto { Code = StatusCodes.Status404NotFound, Message = "Payment mode not found." },
                        SuccessResponse = null
                    };
                }

                _unitOfWork.PaymentMode.Delete(mode);
                await _unitOfWork.Complete();

                return new ReturnResponsesDto
                {
                    IsSuccess = true,
                    ErrorResponse = null,
                    SuccessResponse = new SuccessResponseDto { Code = StatusCodes.Status200OK, Message = "Payment mode deleted successfully.", Data = null }
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

