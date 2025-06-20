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
    public class PayPointsService : IPayPointsService
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;

        public PayPointsService(IUnitOfWork unitOfWork, IMapper mapper)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
        }

        public async Task<IEnumerable<PaypointsReadDto>> GetPaypointsAsync()
        {
            var paypoints = await _unitOfWork.Paypoints.GetAll();
            return _mapper.Map<IEnumerable<PaypointsReadDto>>(paypoints);
        }

        public async Task<PaypointsReadDto> GetPaypointsAsync(int value)
        {
            var paypoint = await _unitOfWork.Paypoints.Get(value);
            return _mapper.Map<PaypointsReadDto>(paypoint);
        }

        public async Task<PaypointsReadDto> GetPaypointsAsync(string value)
        {
            var paypoint = await _unitOfWork.Paypoints.Get(p => p.Paypoint == value);
            return _mapper.Map<PaypointsReadDto>(paypoint);
        }

        public async Task<ReturnResponsesDto> CreatePaypointsAsync(PaypointsCreateDto values)
        {
            try
            {
                var existingPaypoint = await _unitOfWork.Paypoints.Get(p => p.Paypoint == values.Paypoint);
                if (existingPaypoint != null)
                {
                    return new ReturnResponsesDto
                    {
                        IsSuccess = false,
                        ErrorResponse = new ErrorResponseDto { Code = StatusCodes.Status400BadRequest, Message = "Paypoint already exists." },
                        SuccessResponse = null
                    };
                }

                var paypoint = new Paypoints(values.PaypointId, values.Paypoint!)
                {
                    CreatedBy = values.CreatedBy,
                    CreatedOn = DateTime.Now
                };

                _unitOfWork.Paypoints.Insert(paypoint);
                await _unitOfWork.Complete();

                var result = _mapper.Map<PaypointsReadDto>(paypoint);

                return new ReturnResponsesDto
                {
                    IsSuccess = true,
                    ErrorResponse = null,
                    SuccessResponse = new SuccessResponseDto { Code = StatusCodes.Status201Created, Message = "Paypoint created successfully.", Data = result }
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

        public async Task<ReturnResponsesDto> UpdatePaypointsAsync(PaypointsUpdateDto values)
        {
            try
            {
                var paypoint = await _unitOfWork.Paypoints.Get(values.PaypointId);
                if (paypoint == null)
                {
                    return new ReturnResponsesDto
                    {
                        IsSuccess = false,
                        ErrorResponse = new ErrorResponseDto { Code = StatusCodes.Status404NotFound, Message = $"Paypoint with ID {values.PaypointId} not found." },
                        SuccessResponse = null
                    };
                }

                paypoint.Update(values.PaypointId, values.Paypoint!);
                paypoint.ModifiedBy = values.ModifiedBy;
                paypoint.ModifiedOn = DateTime.Now;

                _unitOfWork.Paypoints.Update(paypoint);
                await _unitOfWork.Complete();

                var result = _mapper.Map<PaypointsReadDto>(paypoint);

                return new ReturnResponsesDto
                {
                    IsSuccess = true,
                    ErrorResponse = null,
                    SuccessResponse = new SuccessResponseDto { Code = StatusCodes.Status200OK, Message = "Paypoint updated successfully.", Data = result }
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

        public async Task<ReturnResponsesDto> DeletePaypointsAsync(int paypointId)
        {
            try
            {
                var paypoint = await _unitOfWork.Paypoints.Get(paypointId);
                if (paypoint == null)
                {
                    return new ReturnResponsesDto
                    {
                        IsSuccess = false,
                        ErrorResponse = new ErrorResponseDto { Code = StatusCodes.Status404NotFound, Message = $"Paypoint with ID {paypointId} not found." },
                        SuccessResponse = null
                    };
                }

                _unitOfWork.Paypoints.Delete(paypoint);
                await _unitOfWork.Complete();

                return new ReturnResponsesDto
                {
                    IsSuccess = true,
                    ErrorResponse = null,
                    SuccessResponse = new SuccessResponseDto { Code = StatusCodes.Status200OK, Message = $"Paypoint with ID {paypointId} deleted successfully." }
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

