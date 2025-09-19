// /**************************************************
// * Company: MindSprings Company Limited
// * Author: Boakye Ofori-Atta
// * Email Address: boakye.ofori-atta@mindsprings-gh.com
// * Copyright: © 2024 MindSprings Company Limited
// * Create Date: 19/09/2025 4:45 PM
// * Version: 1.0.1
// * Description: Property Management System
//  **************************************************/

using Microsoft.AspNetCore.Http;

namespace Modules.Finance.Application.UseCases.Setups
{
    public class DebtorTypesService : IDebtorTypesService
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;

        public DebtorTypesService(IUnitOfWork unitOfWork, IMapper mapper)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
        }

        public async Task<IEnumerable<DebtorTypesReadDto>> GetDebtorTypesAsync()
        {
            var debtorTypes = await _unitOfWork.DebtorTypes.GetAll();
            return _mapper.Map<IEnumerable<DebtorTypesReadDto>>(debtorTypes);
        }

        public async Task<DebtorTypesReadDto> GetDebtorTypesAsync(int debtorTypesId)
        {
            var debtorType = await _unitOfWork.DebtorTypes.Get(dt => dt.DebtorTypesId == debtorTypesId);
            return _mapper.Map<DebtorTypesReadDto>(debtorType);
        }

        public async Task<ReturnResponsesDto> CreateDebtorTypesAsync(DebtorTypesCreateDto values)
        {
            try
            {
                var existingDebtorType = await _unitOfWork.DebtorTypes.Get(dt => dt.DebtorType == values.DebtorType && dt.RentalTypesId == values.RentalTypesId);
                if (existingDebtorType != null)
                {
                    return new ReturnResponsesDto
                    {
                        IsSuccess = false,
                        ErrorResponse = new ErrorResponseDto { Code = StatusCodes.Status400BadRequest, Message = "Debtor Type already exists for this Rental Type." },
                        SuccessResponse = null
                    };
                }

                var debtorType = new DebtorTypes(values.RentalTypesId, 0, values.DebtorType, values.Description ?? string.Empty)
                {
                    CreatedBy = values.CreatedBy,
                    CreatedOn = DateTime.Now
                };

                _unitOfWork.DebtorTypes.Insert(debtorType);
                await _unitOfWork.Complete();

                return new ReturnResponsesDto
                {
                    IsSuccess = true,
                    ErrorResponse = null,
                    SuccessResponse = new SuccessResponseDto { Code = StatusCodes.Status201Created, Message = "Debtor Type created successfully." }
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

        public async Task<ReturnResponsesDto> UpdateDebtorTypesAsync(DebtorTypesUpdateDto values)
        {
            try
            {
                var debtorType = await _unitOfWork.DebtorTypes.Get(dt => dt.DebtorTypesId == values.DebtorTypesId);
                if (debtorType == null)
                {
                    return new ReturnResponsesDto
                    {
                        IsSuccess = false,
                        ErrorResponse = new ErrorResponseDto { Code = StatusCodes.Status404NotFound, Message = "Debtor Type not found." },
                        SuccessResponse = null
                    };
                }

                var existingDebtorType = await _unitOfWork.DebtorTypes.Get(dt => dt.DebtorType == values.DebtorType && dt.RentalTypesId == values.RentalTypesId && dt.DebtorTypesId != values.DebtorTypesId);
                if (existingDebtorType != null)
                {
                    return new ReturnResponsesDto
                    {
                        IsSuccess = false,
                        ErrorResponse = new ErrorResponseDto { Code = StatusCodes.Status400BadRequest, Message = "Debtor Type already exists for this Rental Type." },
                        SuccessResponse = null
                    };
                }

                debtorType.Update(values.RentalTypesId, values.DebtorTypesId, values.DebtorType, values.Description ?? string.Empty);
                debtorType.ModifiedBy = values.ModifiedBy;
                debtorType.ModifiedOn = DateTime.Now;

                _unitOfWork.DebtorTypes.Update(debtorType);
                await _unitOfWork.Complete();

                return new ReturnResponsesDto
                {
                    IsSuccess = true,
                    ErrorResponse = null,
                    SuccessResponse = new SuccessResponseDto { Code = StatusCodes.Status200OK, Message = "Debtor Type updated successfully." }
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

        public async Task<ReturnResponsesDto> DeleteDebtorTypesAsync(int debtorTypesId)
        {
            try
            {
                var debtorType = await _unitOfWork.DebtorTypes.Get(dt => dt.DebtorTypesId == debtorTypesId);
                if (debtorType == null)
                {
                    return new ReturnResponsesDto
                    {
                        IsSuccess = false,
                        ErrorResponse = new ErrorResponseDto { Code = StatusCodes.Status404NotFound, Message = "Debtor Type not found." },
                        SuccessResponse = null
                    };
                }

                _unitOfWork.DebtorTypes.Delete(debtorType);
                await _unitOfWork.Complete();

                return new ReturnResponsesDto
                {
                    IsSuccess = true,
                    ErrorResponse = null,
                    SuccessResponse = new SuccessResponseDto { Code = StatusCodes.Status200OK, Message = "Debtor Type deleted successfully." }
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
