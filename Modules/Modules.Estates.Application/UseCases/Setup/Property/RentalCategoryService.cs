// /**************************************************
// * Company: MindSprings Company Limited
// * Project Name: Modules.Estates.Application
// * Full FileName: /Users/imac5k/Projects/PropertyManagementSolution/pms-api/Modules/Modules.Estates.Application/UseCases/Setup/Property/RentalCategoryService.cs
// * Author: Boakye Ofori-Atta
// * Email Address: boakye.ofori-atta@mindsprings-gh.com
// * Copyright: © 2024 MindSprings Company Limited
// * Create Date: 23/05/2025 3:15 PM
// * Version: 1.0.1
// * Description: Property Management System
//  **************************************************/

using Microsoft.AspNetCore.Http;
using Modules.Estates.Application.DTO.Setup.Property;
using Modules.Estates.Application.Interfaces.Entities.Setup.Property;
using Modules.Estates.Domain;

namespace Modules.Estates.Application.UseCases.Setup.Property
{
    public class RentalCategoryService : IRentalCategoryService
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;

        public RentalCategoryService(IUnitOfWork unitOfWork, IMapper mapper)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
        }

        public async Task<IEnumerable<RentalCategoryReadDto>> GetRentalCategoryAsync()
        {
            var rentalCategories = await _unitOfWork.RentalCategory.GetAll();
            return _mapper.Map<IEnumerable<RentalCategoryReadDto>>(rentalCategories);
        }

        public async Task<ReturnResponsesDto> CreateRentalCategoryAsync(RentalCategoryCreateDto values)
        {
            try
            {
                int rentalCategoryId = 0;

                var existingRentalCategory = await _unitOfWork.RentalCategory.Get(r => r.RentalCategories == values.RentalCategories);
                if (existingRentalCategory != null)
                {
                    return new ReturnResponsesDto
                    {
                        IsSuccess = false,
                        ErrorResponse = new ErrorResponseDto { Code = StatusCodes.Status400BadRequest, Message = "Rental Category already exists." },
                        SuccessResponse = null
                    };
                }

                var rentalCategory = RentalCategory.Create(
                    rentalCategoryId,
                    values.RentalCategories!
                );

                rentalCategory.CreatedBy = values.CreatedBy;
                rentalCategory.CreatedOn = DateTime.Now;

                _unitOfWork.RentalCategory.Insert(rentalCategory);
                await _unitOfWork.Complete();

                return new ReturnResponsesDto
                {
                    IsSuccess = true,
                    ErrorResponse = null,
                    SuccessResponse = new SuccessResponseDto { Code = StatusCodes.Status201Created, Message = "Rental Category details created successfully." }
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

        public async Task<ReturnResponsesDto> UpdateRentalCategoryAsync(RentalCategoryUpdateDto values)
        {
            try
            {
                var rentalCategory = await _unitOfWork.RentalCategory.Get(values.RentalCategoryId);
                if (rentalCategory == null)
                {
                    return new ReturnResponsesDto
                    {
                        IsSuccess = false,
                        ErrorResponse = new ErrorResponseDto { Code = StatusCodes.Status404NotFound, Message = $"Rental Category with ID {values.RentalCategoryId} not found." },
                        SuccessResponse = null
                    };
                }

                rentalCategory.Update(
                    values.RentalCategoryId,
                    values.RentalCategories!
                );

                rentalCategory.ModifiedBy = values.ModifiedBy;
                rentalCategory.ModifiedOn = DateTime.Now;

                _unitOfWork.RentalCategory.Update(rentalCategory);
                await _unitOfWork.Complete();

                return new ReturnResponsesDto
                {
                    IsSuccess = true,
                    ErrorResponse = null,
                    SuccessResponse = new SuccessResponseDto { Code = StatusCodes.Status200OK, Message = "Rental Category details modified successfully." }
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

        public async Task<ReturnResponsesDto> DeleteRentalCategory(int rentalCategoryId)
        {
            try
            {
                var rentalCategory = await _unitOfWork.RentalCategory.Get(rentalCategoryId);
                if (rentalCategory == null)
                {
                    return new ReturnResponsesDto
                    {
                        IsSuccess = false,
                        ErrorResponse = new ErrorResponseDto { Code = StatusCodes.Status404NotFound, Message = $"Rental Category with ID {rentalCategoryId} not found." },
                        SuccessResponse = null
                    };
                }

                _unitOfWork.RentalCategory.Delete(rentalCategory);
                await _unitOfWork.Complete();

                return new ReturnResponsesDto
                {
                    IsSuccess = true,
                    ErrorResponse = null,
                    SuccessResponse = new SuccessResponseDto { Code = StatusCodes.Status200OK, Message = $"Rental Category with ID {rentalCategoryId} deleted successfully." }
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

        public async Task<List<RentalCategoryAndRentalTypeReadDto>> GeRentalCategoryAndRentalTypeAsync()
        {
            // Get all rental categories and rental types in a single query using Include
            var rentals = await _unitOfWork.RentalCategory.GetAll(includes: new List<string> { "RentalTypes" });

            // Create a dictionary for quick lookup of rental types by rental ID
            var rentalCategoryAndTypes = rentals.Select(rental =>
            {
                var rentalTypes = _mapper.Map<List<RentalTypeReadDto>>(rental.RentalTypes);
                return new RentalCategoryAndRentalTypeReadDto(
                    new RentalCategoryReadsDto(
                    rental.RentalCategoryId,
                    rental.RentalCategories,
                    false),
                    rentalTypes
                );
            }).ToList();

            return rentalCategoryAndTypes;
        }
    }
}