// /**************************************************
// * Company: MindSprings Company Limited
// * Author: Boakye Ofori-Atta
// * Email Address: boakye.ofori-atta@mindsprings-gh.com
// * Copyright: © 2024 MindSprings Company Limited
// * Create Date: 20/09/2025 4:55 PM
// * Version: 1.0.1
// * Description: Property Management System
//  **************************************************/

using Microsoft.AspNetCore.Http;
using Modules.Finance.Application.Dtos.Setup;
using Modules.Finance.Application.Interfaces.Setup;
using Modules.Finance.Domain.Entities.Setup;
using Modules.Finance.Domain.Interfaces;

namespace Modules.Finance.Application.UseCases.Setups
{
    public class PaymentTermsService : IPaymentTermsService
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;

        public PaymentTermsService(IUnitOfWork unitOfWork, IMapper mapper)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
        }

        public async Task<IEnumerable<PaymentTermsReadDto>> GetPaymentTermsAsync()
        {
            var paymentTerms = await _unitOfWork.PaymentTerms.GetAll();
            return _mapper.Map<IEnumerable<PaymentTermsReadDto>>(paymentTerms);
        }

        public async Task<PaymentTermsReadDto> GetPaymentTermsAsync(int value)
        {
            var paymentTerm = await _unitOfWork.PaymentTerms.Get(value);
            return _mapper.Map<PaymentTermsReadDto>(paymentTerm);
        }

        public async Task<PaymentTermsReadDto> GetPaymentTermsByTermAsync(int paymentTerm)
        {
            var paymentTermEntity = await _unitOfWork.PaymentTerms.Get(pt => pt.PaymentTerm == paymentTerm);
            return _mapper.Map<PaymentTermsReadDto>(paymentTermEntity);
        }

        public async Task<ReturnResponsesDto> CreatePaymentTermsAsync(PaymentTermsCreateDto values)
        {
            try
            {
                var existingPaymentTerm = await _unitOfWork.PaymentTerms.Get(pt => pt.PaymentTerm == values.PaymentTerm);
                if (existingPaymentTerm != null)
                {
                    return new ReturnResponsesDto
                    {
                        IsSuccess = false,
                        ErrorResponse = new ErrorResponseDto { Code = StatusCodes.Status400BadRequest, Message = "Payment term already exists." },
                        SuccessResponse = null
                    };
                }

                var paymentTerm = new PaymentTerms(values.PaymentTerm)
                {
                    CreatedBy = values.CreatedBy,
                    CreatedOn = DateTime.Now
                };

                _unitOfWork.PaymentTerms.Insert(paymentTerm);
                await _unitOfWork.Complete();

                return new ReturnResponsesDto
                {
                    IsSuccess = true,
                    ErrorResponse = null,
                    SuccessResponse = new SuccessResponseDto { Code = StatusCodes.Status201Created, Message = "Payment term created successfully." }
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

        public async Task<ReturnResponsesDto> UpdatePaymentTermsAsync(PaymentTermsUpdateDto values)
        {
            try
            {
                var paymentTerm = await _unitOfWork.PaymentTerms.Get(values.PaymentTermsId);
                if (paymentTerm == null)
                {
                    return new ReturnResponsesDto
                    {
                        IsSuccess = false,
                        ErrorResponse = new ErrorResponseDto { Code = StatusCodes.Status404NotFound, Message = $"Payment term with ID {values.PaymentTermsId} not found." },
                        SuccessResponse = null
                    };
                }

                var existingPaymentTerm = await _unitOfWork.PaymentTerms.Get(pt => pt.PaymentTerm == values.PaymentTerm && pt.PaymentTermsId != values.PaymentTermsId);
                if (existingPaymentTerm != null)
                {
                    return new ReturnResponsesDto
                    {
                        IsSuccess = false,
                        ErrorResponse = new ErrorResponseDto { Code = StatusCodes.Status400BadRequest, Message = "Payment term already exists." },
                        SuccessResponse = null
                    };
                }

                paymentTerm.Update(values.PaymentTermsId, values.PaymentTerm);
                paymentTerm.ModifiedBy = values.ModifiedBy;
                paymentTerm.ModifiedOn = DateTime.Now;

                _unitOfWork.PaymentTerms.Update(paymentTerm);
                await _unitOfWork.Complete();

                return new ReturnResponsesDto
                {
                    IsSuccess = true,
                    ErrorResponse = null,
                    SuccessResponse = new SuccessResponseDto { Code = StatusCodes.Status200OK, Message = "Payment term updated successfully." }
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

        public async Task<ReturnResponsesDto> DeletePaymentTermsAsync(int paymentTermsId)
        {
            try
            {
                var paymentTerm = await _unitOfWork.PaymentTerms.Get(paymentTermsId);
                if (paymentTerm == null)
                {
                    return new ReturnResponsesDto
                    {
                        IsSuccess = false,
                        ErrorResponse = new ErrorResponseDto { Code = StatusCodes.Status404NotFound, Message = $"Payment term with ID {paymentTermsId} not found." },
                        SuccessResponse = null
                    };
                }

                _unitOfWork.PaymentTerms.Delete(paymentTerm);
                await _unitOfWork.Complete();

                return new ReturnResponsesDto
                {
                    IsSuccess = true,
                    ErrorResponse = null,
                    SuccessResponse = new SuccessResponseDto { Code = StatusCodes.Status200OK, Message = $"Payment term with ID {paymentTermsId} deleted successfully." }
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
