// /**************************************************
// * Company: MindSprings Company Limited
// * Project Name: Modules.Estates.Application
// * Full FileName: /Users/imac5k/Projects/PropertyManagementSolution/pms-api/Modules/Modules.Estates.Application/UseCases/Setup/Property/PropertyHeightService.cs
// * Author: Boakye Ofori-Atta
// * Email Address: boakye.ofori-atta@mindsprings-gh.com
// * Copyright: © 2024 MindSprings Company Limited
// * Create Date: 01/01/2025 
// * Version: 1.0.1
// * Description: Property Management System
//  **************************************************/

using Microsoft.AspNetCore.Http;

namespace Modules.Estates.Application.UseCases.Setup.Property;

public class PropertyHeightService : IPropertyHeightService
{
    private readonly IUnitOfWork _unitOfWork;
    private readonly IMapper _mapper;

    public PropertyHeightService(IUnitOfWork unitOfWork, IMapper mapper)
    {
        _unitOfWork = unitOfWork;
        _mapper = mapper;
    }

    public async Task<IEnumerable<PropertyHeightReadDto>> GetPropertyHeightAsync()
    {
        var response = await _unitOfWork.PropertyHeight.GetAll();
        return _mapper.Map<IEnumerable<PropertyHeightReadDto>>(response);
    }

    public async Task<PropertyHeightReadDto> GetPropertyHeightAsync(int value)
    {
        var response = await _unitOfWork.PropertyHeight.Get(value);
        return _mapper.Map<PropertyHeightReadDto>(response);
    }

    public async Task<PropertyHeightReadDto> GetPropertyHeightAsync(string value)
    {
        var response = await _unitOfWork.PropertyHeight.Get(ph => ph.PropertyHeights == value);
        return _mapper.Map<PropertyHeightReadDto>(response);
    }

    public async Task<ReturnResponsesDto> CreatePropertyHeightAsync(PropertyHeightCreateDto values)
    {
        try
        {
            var existingHeight = await _unitOfWork.PropertyHeight.Get(ph => ph.PropertyHeights == values.propertyHeights);
            if (existingHeight != null)
            {
                return new ReturnResponsesDto
                {
                    IsSuccess = false,
                    ErrorResponse = new ErrorResponseDto { Code = StatusCodes.Status400BadRequest, Message = "Property Height already exists." },
                    SuccessResponse = null
                };
            }

            var propertyHeight = PropertyHeight.Create(0, values.propertyHeights);
            propertyHeight.CreatedBy = values.createdBy;
            propertyHeight.CreatedOn = DateTime.Now;

            _unitOfWork.PropertyHeight.Insert(propertyHeight);
            await _unitOfWork.Complete();

            return new ReturnResponsesDto
            {
                IsSuccess = true,
                ErrorResponse = null,
                SuccessResponse = new SuccessResponseDto { Code = StatusCodes.Status201Created, Message = "Property Height created successfully." },
            };
        }
        catch (Exception ex)
        {
            return new ReturnResponsesDto { IsSuccess = false, ErrorResponse = new ErrorResponseDto { Code = StatusCodes.Status500InternalServerError, Message = ex.InnerException!.Message ?? ex.Message }, SuccessResponse = null };
        }
    }

    public async Task<ReturnResponsesDto> UpdatePropertyHeightAsync(PropertyHeightUpdateDto values)
    {
        try
        {
            var propertyHeight = await _unitOfWork.PropertyHeight.Get(values.propertyHeightId);
            if (propertyHeight == null)
            {
                return new ReturnResponsesDto
                {
                    IsSuccess = false,
                    ErrorResponse = new ErrorResponseDto { Code = StatusCodes.Status404NotFound, Message = $"Property Height with ID {values.propertyHeightId} not found." },
                    SuccessResponse = null
                };
            }

            propertyHeight.Update(values.propertyHeightId, values.propertyHeights);
            propertyHeight.ModifiedBy = values.modifiedBy;
            propertyHeight.ModifiedOn = DateTime.Now;

            _unitOfWork.PropertyHeight.Update(propertyHeight);
            await _unitOfWork.Complete();

            return new ReturnResponsesDto
            {
                IsSuccess = true,
                ErrorResponse = null,
                SuccessResponse = new SuccessResponseDto { Code = StatusCodes.Status200OK, Message = "Property Height modified successfully." },
            };
        }
        catch (Exception ex)
        {
            return new ReturnResponsesDto { IsSuccess = false, ErrorResponse = new ErrorResponseDto { Code = StatusCodes.Status500InternalServerError, Message = ex.InnerException!.Message ?? ex.Message }, SuccessResponse = null };
        }
    }

    public async Task<ReturnResponsesDto> DeletePropertyHeight(int propertyHeightId)
    {
        try
        {
            var propertyHeight = await _unitOfWork.PropertyHeight.Get(propertyHeightId);
            if (propertyHeight == null)
            {
                return new ReturnResponsesDto
                {
                    IsSuccess = false,
                    ErrorResponse = new ErrorResponseDto { Code = StatusCodes.Status404NotFound, Message = $"Property Height with ID {propertyHeightId} not found." },
                    SuccessResponse = null
                };
            }

            _unitOfWork.PropertyHeight.Delete(propertyHeight);
            await _unitOfWork.Complete();

            return new ReturnResponsesDto
            {
                IsSuccess = true,
                ErrorResponse = null,
                SuccessResponse = new SuccessResponseDto { Code = StatusCodes.Status200OK, Message = $"Property Height with ID {propertyHeightId} deleted successfully." }
            };
        }
        catch (Exception ex)
        {
            return new ReturnResponsesDto { IsSuccess = false, ErrorResponse = new ErrorResponseDto { Code = StatusCodes.Status500InternalServerError, Message = ex.InnerException!.Message ?? ex.Message }, SuccessResponse = null };
        }
    }
}

