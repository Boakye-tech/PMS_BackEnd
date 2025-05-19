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
using Microsoft.EntityFrameworkCore;


namespace Modules.Estates.Application.UseCases.Setup.Property;

public class ApartmentTypeService : IApartmentTypeService
{
    private readonly IUnitOfWork _unitOfWork;
    private readonly IMapper _mapper;

    public ApartmentTypeService(IUnitOfWork unitOfWork, IMapper mapper)
    {
        _unitOfWork = unitOfWork;
        _mapper = mapper;
    }

    public async Task<IEnumerable<ApartmentTypeReadDto>> GetApartmentTypeAsync()
    {
        //var response = await _unitOfWork.ApartmentTypes.GetAll();

        var apartmentDetails = (from at in await _unitOfWork.ApartmentTypes.GetAll()
                                join cer in await _unitOfWork.CurrencyExchangeRate.GetAll()
                                on at.CurrencyId equals cer.CurrencyId
                                select new ApartmentTypeReadDto
                                (
                                    ApartmentCategoryEnumDescription.GetApartmentCategoryEnumDescription(at.ApartmentCategory),
                                    at.ApartmentTypeId,
                                    at.ApartmentType,
                                    at.SellingPrice,
                                    at.CurrencyId,
                                    cer.CurrencyInitial!,
                                    cer.CurrencyName!,
                                    at.FloorArea
                                )).ToList();


        return _mapper.Map<IEnumerable<ApartmentTypeReadDto>>(apartmentDetails);
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

            var apartmentType = await _unitOfWork.ApartmentTypes.Get(at => at.ApartmentType == values.apartmentType);
            if (apartmentType != null)
            {
                return new ReturnResponsesDto
                {
                    IsSuccess = false,
                    ErrorResponse = new ErrorResponseDto { Code = StatusCodes.Status400BadRequest, Message = "Apartment Type already exists." },
                    SuccessResponse = null
                };
            }

            var newApartmentType = ApartmentTypes.Create(values.apartmentCategory, apartmentTypeId, values.apartmentType!, values.sellingPrice, values.currencyId, values.floorArea);
            newApartmentType.CreatedBy = values.createdBy;
            newApartmentType.CreatedOn = DateTime.Now;

            _unitOfWork.ApartmentTypes.Insert(newApartmentType);
            await _unitOfWork.Complete();

            var result = _mapper.Map<ApartmentTypeReadDto>(newApartmentType);

            return new ReturnResponsesDto
            {
                IsSuccess = true,
                ErrorResponse = null,
                SuccessResponse = new SuccessResponseDto { Code = StatusCodes.Status201Created, Message = "Apartment Type created successfully.", Data = result },
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

            apartmentType.Update(values.apartmentCategory, values.apartmentTypeId, values.apartmentType!, values.sellingPrice, values.currencyId, values.floorArea);
            apartmentType.ModifiedBy = values.modifiedBy;
            apartmentType.ModifiedOn = DateTime.Now;

            _unitOfWork.ApartmentTypes.Update(apartmentType);
            await _unitOfWork.Complete();

            var result = _mapper.Map<ApartmentTypeReadDto>(apartmentType);

            return new ReturnResponsesDto
            {
                IsSuccess = true,
                ErrorResponse = null,
                SuccessResponse = new SuccessResponseDto { Code = StatusCodes.Status200OK, Message = "Apartment Type modified successfully.", Data = result },
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

