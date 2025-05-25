// /**************************************************
// * Company: MindSprings Company Limited
// * Project Name: Modules.Estates.Application
// * Full FileName: /Users/imac5k/Projects/PropertyManagementSolution/pms-api/Modules/Modules.Estates.Application/UseCases/Setup/Property/RentalTypeService.cs
// * Author: Boakye Ofori-Atta
// * Email Address: boakye.ofori-atta@mindsprings-gh.com
// * Copyright: © 2024 MindSprings Company Limited
// * Create Date: 23/05/2025 3:15 PM
// * Version: 1.0.1
// * Description: Property Management System
//  **************************************************/

using Microsoft.AspNetCore.Http;


namespace Modules.Estates.Application.UseCases.Setup.Property
{
    public class RentalTypeService : IRentalTypeService
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;

        public RentalTypeService(IUnitOfWork unitOfWork, IMapper mapper)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
        }

        public async Task<IEnumerable<RentalTypeReadDto>> GetRentalTypeAsync(int rentalCategoryId)
        {
            var rentalTypes = await _unitOfWork.RentalType.GetAll(rt => rt.RentalCategoryId == rentalCategoryId);
            return _mapper.Map<IEnumerable<RentalTypeReadDto>>(rentalTypes);
        }

        public async Task<ReturnResponsesDto> CreateRentalTypeAsync(RentalTypeCreateDto values)
        {
            try
            {
                int rentalTypeId = 0;

                var existingRentalType = await _unitOfWork.RentalType.Get(r => r.RentalTypes == values.RentalTypes);
                if (existingRentalType != null)
                {
                    return new ReturnResponsesDto
                    {
                        IsSuccess = false,
                        ErrorResponse = new ErrorResponseDto { Code = StatusCodes.Status400BadRequest, Message = "Rental Type already exists." },
                        SuccessResponse = null
                    };
                }

                var rentalType = RentalType.Create(
                    values.RentalCategoryId,
                    rentalTypeId,
                    values.RentalTypes!
                );

                rentalType.CreatedBy = values.CreatedBy;
                rentalType.CreatedOn = DateTime.Now;

                _unitOfWork.RentalType.Insert(rentalType);
                await _unitOfWork.Complete();

                return new ReturnResponsesDto
                {
                    IsSuccess = true,
                    ErrorResponse = null,
                    SuccessResponse = new SuccessResponseDto { Code = StatusCodes.Status201Created, Message = "Rental Type details created successfully." }
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

        public async Task<ReturnResponsesDto> UpdateRentalTypeAsync(RentalTypeUpdateDto values)
        {
            try
            {
                var rentalType = await _unitOfWork.RentalType.Get(values.RentalTypeId);
                if (rentalType == null)
                {
                    return new ReturnResponsesDto
                    {
                        IsSuccess = false,
                        ErrorResponse = new ErrorResponseDto { Code = StatusCodes.Status404NotFound, Message = $"Rental Type with ID {values.RentalTypeId} not found." },
                        SuccessResponse = null
                    };
                }

                rentalType.Update(
                    values.RentalCategoryId,
                    values.RentalTypeId,
                    values.RentalTypes!
                );

                rentalType.ModifiedBy = values.ModifiedBy;
                rentalType.ModifiedOn = DateTime.Now;

                _unitOfWork.RentalType.Update(rentalType);
                await _unitOfWork.Complete();


                return new ReturnResponsesDto
                {
                    IsSuccess = true,
                    ErrorResponse = null,
                    SuccessResponse = new SuccessResponseDto { Code = StatusCodes.Status200OK, Message = "Rental Type details modified successfully." }
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

        public async Task<ReturnResponsesDto> DeleteRentalType(int rentalTypeId)
        {
            try
            {
                var rentalType = await _unitOfWork.RentalType.Get(rentalTypeId);
                if (rentalType == null)
                {
                    return new ReturnResponsesDto
                    {
                        IsSuccess = false,
                        ErrorResponse = new ErrorResponseDto { Code = StatusCodes.Status404NotFound, Message = $"Rental Type with ID {rentalTypeId} not found." },
                        SuccessResponse = null
                    };
                }

                _unitOfWork.RentalType.Delete(rentalType);
                await _unitOfWork.Complete();

                return new ReturnResponsesDto
                {
                    IsSuccess = true,
                    ErrorResponse = null,
                    SuccessResponse = new SuccessResponseDto { Code = StatusCodes.Status200OK, Message = $"Rental Type with ID {rentalTypeId} deleted successfully." }
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