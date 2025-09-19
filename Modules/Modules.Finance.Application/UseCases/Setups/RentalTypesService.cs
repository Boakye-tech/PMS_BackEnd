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
    public class RentalTypesService : IRentalTypesService
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;

        public RentalTypesService(IUnitOfWork unitOfWork, IMapper mapper)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
        }


        public async Task<List<RentalAndDebtorTypesDto>> GetRentalAndDebtorTypesAsync()
        {
            var rentalTypes = await _unitOfWork.RentalTypes.GetAll(includes: new List<string> { "DebtorTypes", "DebtorTypes.DebtorGroups" });
            var result = rentalTypes.Select(r => new RentalAndDebtorTypesDto(
                new RentalTypesReadDto(r.RentalTypesId, r.RentalType),
                r.DebtorTypes!.Select(d => new DebtorTypeReadDto(
                    d.DebtorType,
                    d.Description,
                    d.DebtorGroups!.Select(g => new DebtorGroupReadDto(
                        g.GroupName,
                        g.Description
                    )).ToList()
                )).ToList()
            )).ToList();

            return result;
            //return _mapper.Map<List<RentalAndDebtorTypesDto>>(rentalTypes);
        }

        public async Task<IEnumerable<RentalTypesReadDto>> GetRentalTypesAsync()
        {
            var rentalTypes = await _unitOfWork.RentalTypes.GetAll();
            return _mapper.Map<IEnumerable<RentalTypesReadDto>>(rentalTypes);
        }

        public async Task<RentalTypesReadDto> GetRentalTypesAsync(int rentalTypesId)
        {
            var rentalType = await _unitOfWork.RentalTypes.Get(rt => rt.RentalTypesId == rentalTypesId);
            return _mapper.Map<RentalTypesReadDto>(rentalType);
        }

        public async Task<ReturnResponsesDto> CreateRentalTypesAsync(RentalTypesCreateDto values)
        {
            try
            {
                var existingRentalType = await _unitOfWork.RentalTypes.Get(rt => rt.RentalTypesId == values.RentalTypesId);
                if (existingRentalType != null)
                {
                    return new ReturnResponsesDto
                    {
                        IsSuccess = false,
                        ErrorResponse = new ErrorResponseDto { Code = StatusCodes.Status400BadRequest, Message = "Rental Type Id already exists." },
                        SuccessResponse = null
                    };
                }

                existingRentalType = await _unitOfWork.RentalTypes.Get(rt => rt.RentalType == values.RentalType);
                if (existingRentalType != null)
                {
                    return new ReturnResponsesDto
                    {
                        IsSuccess = false,
                        ErrorResponse = new ErrorResponseDto { Code = StatusCodes.Status400BadRequest, Message = "Rental Type already exists." },
                        SuccessResponse = null
                    };
                }

                var rentalType = new RentalTypes(values.RentalTypesId, values.RentalType!)
                {
                    CreatedBy = values.CreatedBy,
                    CreatedOn = DateTime.Now
                };

                _unitOfWork.RentalTypes.Insert(rentalType);
                await _unitOfWork.Complete();

                return new ReturnResponsesDto
                {
                    IsSuccess = true,
                    ErrorResponse = null,
                    SuccessResponse = new SuccessResponseDto { Code = StatusCodes.Status201Created, Message = "Rental Type created successfully." }
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

        public async Task<ReturnResponsesDto> UpdateRentalTypesAsync(RentalTypesUpdateDto values)
        {
            try
            {
                var rentalType = await _unitOfWork.RentalTypes.Get(rt => rt.RentalTypesId == values.RentalTypesId);
                if (rentalType == null)
                {
                    return new ReturnResponsesDto
                    {
                        IsSuccess = false,
                        ErrorResponse = new ErrorResponseDto { Code = StatusCodes.Status404NotFound, Message = "Rental Type not found." },
                        SuccessResponse = null
                    };
                }

                var existingRentalType = await _unitOfWork.RentalTypes.Get(rt => rt.RentalType == values.RentalType && rt.RentalTypesId != values.RentalTypesId);
                if (existingRentalType != null)
                {
                    return new ReturnResponsesDto
                    {
                        IsSuccess = false,
                        ErrorResponse = new ErrorResponseDto { Code = StatusCodes.Status400BadRequest, Message = "Rental Type already exists." },
                        SuccessResponse = null
                    };
                }

                rentalType.Update(values.RentalTypesId, values.RentalType!);
                rentalType.ModifiedBy = values.ModifiedBy;
                rentalType.ModifiedOn = DateTime.Now;

                _unitOfWork.RentalTypes.Update(rentalType);
                await _unitOfWork.Complete();

                return new ReturnResponsesDto
                {
                    IsSuccess = true,
                    ErrorResponse = null,
                    SuccessResponse = new SuccessResponseDto { Code = StatusCodes.Status200OK, Message = "Rental Type updated successfully." }
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

        public async Task<ReturnResponsesDto> DeleteRentalTypesAsync(int rentalTypesId)
        {
            try
            {
                var rentalType = await _unitOfWork.RentalTypes.Get(rt => rt.RentalTypesId == rentalTypesId);
                if (rentalType == null)
                {
                    return new ReturnResponsesDto
                    {
                        IsSuccess = false,
                        ErrorResponse = new ErrorResponseDto { Code = StatusCodes.Status404NotFound, Message = "Rental Type not found." },
                        SuccessResponse = null
                    };
                }

                _unitOfWork.RentalTypes.Delete(rentalType);
                await _unitOfWork.Complete();

                return new ReturnResponsesDto
                {
                    IsSuccess = true,
                    ErrorResponse = null,
                    SuccessResponse = new SuccessResponseDto { Code = StatusCodes.Status200OK, Message = "Rental Type deleted successfully." }
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
