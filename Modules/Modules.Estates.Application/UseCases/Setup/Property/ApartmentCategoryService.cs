// /**************************************************
// * Company: MindSprings Company Limited
// * Project Name: Modules.Estates.Application
// * Full FileName: /Users/imac5k/Projects/PropertyManagementSolution/pms-api/Modules/Modules.Estates.Application/UseCases/Setup/Property/ApartmentCategoryService.cs
// * Author: Boakye Ofori-Atta
// * Email Address: boakye.ofori-atta@mindsprings-gh.com
// * Copyright: © 2024 MindSprings Company Limited
// * Create Date: 16/06/2025 5:39 PM
// * Version: 1.0.1
// * Description: Property Management System
//  **************************************************/

using Microsoft.AspNetCore.Http;


namespace Modules.Estates.Application.UseCases.Setup.Property;

public class ApartmentCategoryService : IApartmentCategoryService
{
	private readonly IUnitOfWork _unitOfWork;
	private readonly IMapper _mapper;

	public ApartmentCategoryService(IUnitOfWork unitOfWork, IMapper mapper)
	{
		_unitOfWork = unitOfWork;
		_mapper = mapper;
	}

	public async Task<IEnumerable<ApartmentCategoryReadDto>> GetApartmentCategoryAsync()
	{
		var apartmentCategories = await _unitOfWork.ApartmentCategory.GetAll();
		return _mapper.Map<IEnumerable<ApartmentCategoryReadDto>>(apartmentCategories);
	}

	public async Task<ReturnResponsesDto> CreateApartmentCategoryAsync(ApartmentCategoryCreateDto values)
	{
		try
		{
			int ApartmentCategoryId = 0;

			var apartmentCategory = await _unitOfWork.ApartmentCategory.Get(a => a.ApartmentCategoryName == values.ApartmentCategoryName);
			if (apartmentCategory != null)
			{
				return new ReturnResponsesDto
				{
					IsSuccess = false,
					ErrorResponse = new ErrorResponseDto { Code = StatusCodes.Status400BadRequest, Message = "Apartment Category Name already exists." },
					SuccessResponse = null
				};
			}

			var newApartmentCategory = ApartmentCategory.Create(ApartmentCategoryId, values.ApartmentCategoryName!);
			newApartmentCategory.CreatedBy = values.CreatedBy;
			newApartmentCategory.CreatedOn = DateTime.Now;

			_unitOfWork.ApartmentCategory.Insert(newApartmentCategory);
			await _unitOfWork.Complete();

			return new ReturnResponsesDto
			{
				IsSuccess = true,
				ErrorResponse = null,
				SuccessResponse = new SuccessResponseDto { Code = StatusCodes.Status201Created, Message = "Apartment Category details created successfully." },
			};
		}
		catch (Exception ex)
		{
			return new ReturnResponsesDto { IsSuccess = false, ErrorResponse = new ErrorResponseDto { Code = StatusCodes.Status500InternalServerError, Message = ex.InnerException!.Message ?? ex.Message }, SuccessResponse = null };
		}
	}

	public async Task<ReturnResponsesDto> UpdateApartmentCategoryAsync(ApartmentCategoryUpdateDto values)
	{
		try
		{
			var apartmentCategory = await _unitOfWork.ApartmentCategory.Get(values.ApartmentCategoryId);
			if (apartmentCategory == null)
			{
				return new ReturnResponsesDto
				{
					IsSuccess = false,
					ErrorResponse = new ErrorResponseDto { Code = StatusCodes.Status404NotFound, Message = $"Apartment Category with ID {values.ApartmentCategoryId} not found." },
					SuccessResponse = null
				};
			}

			apartmentCategory.Update(values.ApartmentCategoryId, values.ApartmentCategoryName!);
			apartmentCategory.ModifiedBy = values.ModifiedBy;
			apartmentCategory.ModifiedOn = DateTime.Now;

			_unitOfWork.ApartmentCategory.Update(apartmentCategory);
			await _unitOfWork.Complete();

			return new ReturnResponsesDto
			{
				IsSuccess = true,
				ErrorResponse = null,
				SuccessResponse = new SuccessResponseDto { Code = StatusCodes.Status200OK, Message = "Apartment Category details modified successfully." },
			};
		}
		catch (Exception ex)
		{
			return new ReturnResponsesDto { IsSuccess = false, ErrorResponse = new ErrorResponseDto { Code = StatusCodes.Status500InternalServerError, Message = ex.InnerException!.Message ?? ex.Message }, SuccessResponse = null };
		}
	}

	public async Task<ReturnResponsesDto> DeleteApartmentCategory(int apartmentCategoryId)
	{
		try
		{
			var apartmentCategory = await _unitOfWork.ApartmentCategory.Get(apartmentCategoryId);
			if (apartmentCategory == null)
			{
				return new ReturnResponsesDto
				{
					IsSuccess = false,
					ErrorResponse = new ErrorResponseDto { Code = StatusCodes.Status404NotFound, Message = $"Apartment Category with ID {apartmentCategoryId} not found." },
					SuccessResponse = null
				};
			}

			_unitOfWork.ApartmentCategory.Delete(apartmentCategory);
			await _unitOfWork.Complete();

			return new ReturnResponsesDto
			{
				IsSuccess = true,
				ErrorResponse = null,
				SuccessResponse = new SuccessResponseDto { Code = StatusCodes.Status200OK, Message = $"Apartment Category with ID {apartmentCategoryId} deleted successfully." }
			};
		}
		catch (Exception ex)
		{
			return new ReturnResponsesDto { IsSuccess = false, ErrorResponse = new ErrorResponseDto { Code = StatusCodes.Status500InternalServerError, Message = ex.InnerException!.Message ?? ex.Message }, SuccessResponse = null };
		}
	}

	public async Task<List<ApartmentCategoryAndTypesReadDto>> GetApartmentCategoryAndTypesAsync()
	{
		// Get all apartment categories and their types in a single query using Include
		var apartmentCategories = await _unitOfWork.ApartmentCategory.GetAll(includes: new List<string> { "ApartmentTypes.Currency" });

        //var apartmentCategories = await _unitOfWork.ApartmentCategory.GetAll(includes: new List<string> { "ApartmentTypes" });

        // Map the results to DTOs

        var apartmentCategoryAndTypes = apartmentCategories.Select(category =>
        {
            var apartmentTypes = category.ApartmentTypes.Select(type => new ApartmentTypesReadDto(
                apartmentTypeId: type.ApartmentTypeId,
                apartmentType: type.ApartmentType!,
                sellingPrice: type.SellingPrice,
                currencyId: type.CurrencyId,
                currencyInitial: type.Currency?.CurrencyInitial ?? "",
                currency: type.Currency?.CurrencyName ?? "",
                floorArea: type.FloorArea,
                images: type.Images
            )).ToList();

            return new ApartmentCategoryAndTypesReadDto(
				new ApartmentCategoriesReadDto(
                category.ApartmentCategoryId,
                category.ApartmentCategoryName!,
				false),
                apartmentTypes
            );
        }).ToList();

        return apartmentCategoryAndTypes;
        /*
        var apartmentCategoryAndTypes = apartmentCategories.Select(category =>
		{
			var apartmentTypes = _mapper.Map<List<ApartmentTypesReadDto>>(category.ApartmentTypes);
			return new ApartmentCategoryAndTypesReadDto(
				category.ApartmentCategoryId,
				category.ApartmentCategoryName!,
				apartmentTypes
			);
		}).ToList();

		return apartmentCategoryAndTypes;
		*/
    }
}

