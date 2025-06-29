// /**************************************************
// * Company: MindSprings Company Limited
// * Project Name: Modules.Estates.Application
// * Full FileName: /Users/imac5k/Projects/PropertyManagementSolution/pms-api/Modules/Modules.Estates.Application/UseCases/Setup/Property/ApartmentTypeService.cs
// * Author: Boakye Ofori-Atta
// * Email Address: boakye.ofori-atta@mindsprings-gh.com
// * Copyright: © 2024 MindSprings Company Limited
// * Create Date: 01/01/2025 
// * Version: 1.0.1
// * Description: Property Management System
//  **************************************************/


using Microsoft.AspNetCore.Http;


namespace Modules.Estates.Application.UseCases.Setup.Property;

public class ApartmentTypeService : IApartmentTypeService
{
    private readonly IUnitOfWork _unitOfWork;
    private readonly IMapper _mapper;

    private readonly IApartmentFeaturesService _apartmentFeaturesService;

    public ApartmentTypeService(IUnitOfWork unitOfWork, IMapper mapper, IApartmentFeaturesService apartmentFeaturesService)
    {
        _unitOfWork = unitOfWork;
        _mapper = mapper;
        _apartmentFeaturesService = apartmentFeaturesService;
    }

    public async Task<IEnumerable<ApartmentTypesReadDto>> GetApartmentTypeAsync()
    {
        var apartmentDetails = await _unitOfWork.ApartmentTypes.GetAll(includes: new List<string> { "ApartmentFeatures.Features", "Currency", "FloorArea" });

        var apartmentFeatureDetails = apartmentDetails.Select(apartment => new ApartmentTypesReadDto(
            apartmentTypeId: apartment.ApartmentTypeId,
            apartmentType: apartment.ApartmentType,
            apartmentfeatures: apartment.ApartmentFeatures.Select(f => new ApartmentFeatureReadDto(
                FeatureId: f.FeaturesId,
                Feature: f.Features!.Feature
                //FloorArea: f.FloorArea
            )).ToList(),
            sellingPrice: apartment.SellingPrice,
            currencyId: apartment.CurrencyId,
            currencyInitial: apartment.Currency?.CurrencyInitial ?? "",
            currency: apartment.Currency?.CurrencyName ?? "",
            floorAreaId: apartment.FloorAreaId,
            floorArea: apartment.FloorArea?.Area ?? 0,
            images: apartment.Images
        ));


        return apartmentFeatureDetails;

    }

    public async Task<ApartmentTypeReadDto> GetApartmentTypeAsync(int value)
    {
        var response = await _unitOfWork.ApartmentTypes.Get(value);
        return _mapper.Map<ApartmentTypeReadDto>(response);
    }

    public async Task<ApartmentTypeReadDto> GetApartmentTypeAsync(string value)
    {
        var response = await _unitOfWork.ApartmentTypes.Get(at => at.ApartmentType == value);
        return _mapper.Map<ApartmentTypeReadDto>(response);
    }

    public async Task<ReturnResponsesDto> CreateApartmentTypeAsync(ApartmentTypeCreateDto values)
    {
        try
        {
            int apartmentTypeId = 0;

            var apartmentType = await _unitOfWork.ApartmentTypes.Get(at => at.ApartmentType == values.apartmentType && at.ApartmentCategoryId == values.apartmentCategoryId);
            if (apartmentType != null)
            {
                return new ReturnResponsesDto
                {
                    IsSuccess = false,
                    ErrorResponse = new ErrorResponseDto { Code = StatusCodes.Status400BadRequest, Message = "Apartment Type already exists." },
                    SuccessResponse = null
                };
            }
            

            var newApartmentType = ApartmentTypes.Create(apartmentTypeId, values.apartmentCategoryId, values.apartmentType!, values.sellingPrice, values.currencyId, values.floorAreaId, values.images!);
            newApartmentType.CreatedBy = values.createdBy;
            newApartmentType.CreatedOn = DateTime.Now;

            _unitOfWork.ApartmentTypes.Insert(newApartmentType);
            await _unitOfWork.Complete();


            var _features = new ApartmentFeaturesCreateDto(values.apartmentCategoryId, newApartmentType.ApartmentTypeId, values.features!, newApartmentType.CreatedBy);
            var result = await _apartmentFeaturesService.CreateApartmentFeaturesAsync(_features);

            return new ReturnResponsesDto
            {
                IsSuccess = true,
                ErrorResponse = null,
                SuccessResponse = new SuccessResponseDto { Code = StatusCodes.Status201Created, Message = "Apartment Type created successfully." },
            };
        }
        catch (Exception ex)
        {
            return new ReturnResponsesDto { IsSuccess = false, ErrorResponse = new ErrorResponseDto { Code = StatusCodes.Status500InternalServerError, Message = ex.Message }, SuccessResponse = null };
        }
    }

    public async Task<ReturnResponsesDto> UpdateApartmentTypeAsync(ApartmentTypeUpdateDto values)
    {
        try
        {
            var apartmentType = await _unitOfWork.ApartmentTypes.Get(values.apartmentTypeId);
            if (apartmentType == null)
            {
                return new ReturnResponsesDto
                {
                    IsSuccess = false,
                    ErrorResponse = new ErrorResponseDto { Code = StatusCodes.Status404NotFound, Message = $"Apartment Type with ID {values.apartmentTypeId} not found." },
                    SuccessResponse = null
                };
            }

            apartmentType.Update(values.apartmentTypeId, values.apartmentCategoryId, values.apartmentType!, values.sellingPrice, values.currencyId, values.floorAreaId, values.images!);
            apartmentType.ModifiedBy = values.modifiedBy;
            apartmentType.ModifiedOn = DateTime.Now;

            _unitOfWork.ApartmentTypes.Update(apartmentType);
            await _unitOfWork.Complete();


            var _features = new ApartmentFeaturesUpdateDto(values.apartmentCategoryId, apartmentType.ApartmentTypeId, values.features!, apartmentType.ModifiedBy);
            await _apartmentFeaturesService.UpdateApartmentFeaturesAsync(_features);

            return new ReturnResponsesDto
            {
                IsSuccess = true,
                ErrorResponse = null,
                SuccessResponse = new SuccessResponseDto { Code = StatusCodes.Status200OK, Message = "Apartment Type modified successfully." },
            };
        }
        catch (Exception ex)
        {
            return new ReturnResponsesDto { IsSuccess = false, ErrorResponse = new ErrorResponseDto { Code = StatusCodes.Status500InternalServerError, Message = ex.InnerException!.Message }, SuccessResponse = null };
        }
    }

    public async Task<ReturnResponsesDto> DeleteApartmentType(int apartmentTypeId)
    {
        try
        {
            var apartmentType = await _unitOfWork.ApartmentTypes.Get(apartmentTypeId);
            if (apartmentType == null)
            {
                return new ReturnResponsesDto
                {
                    IsSuccess = false,
                    ErrorResponse = new ErrorResponseDto { Code = StatusCodes.Status404NotFound, Message = $"Apartment Type with ID {apartmentTypeId} not found." },
                    SuccessResponse = null
                };
            }

            _unitOfWork.ApartmentTypes.Delete(apartmentType);
            await _unitOfWork.Complete();

            return new ReturnResponsesDto
            {
                IsSuccess = true,
                ErrorResponse = null,
                SuccessResponse = new SuccessResponseDto { Code = StatusCodes.Status200OK, Message = $"Apartment Type with ID {apartmentTypeId} deleted successfully." }
            };
        }
        catch (Exception ex)
        {
            return new ReturnResponsesDto { IsSuccess = false, ErrorResponse = new ErrorResponseDto { Code = StatusCodes.Status500InternalServerError, Message = ex.InnerException!.Message }, SuccessResponse = null };
        }
    }
}

