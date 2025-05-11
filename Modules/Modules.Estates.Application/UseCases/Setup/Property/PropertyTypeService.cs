// /**************************************************
// * Company: MindSprings Company Limited
// * Project Name: Modules.Estates.Application
// * Full FileName: /Users/imac5k/Projects/PropertyManagementSolution/pms-api/Modules/Modules.Estates.Application/UseCases/Setup/Property/PropertyTypeService.cs
// * Author: Boakye Ofori-Atta
// * Email Address: boakye.ofori-atta@mindsprings-gh.com
// * Copyright: © 2024 MindSprings Company Limited
// * Create Date: 01/01/2025 
// * Version: 1.0.1
// * Description: Property Management System
//  **************************************************/

using Microsoft.AspNetCore.Http;
using AutoMapper;
using Modules.Estates.Application.DTO.Setup;
using Modules.Estates.Application.DTO.Setup.Property;
using Modules.Estates.Application.Interfaces.Entities.Setup.Property;
using Modules.Estates.Domain;
using Modules.Estates.Domain.Entities.Setup.Property;

namespace Modules.Estates.Application.UseCases.Setup.Property;

public class PropertyTypeService : IPropertyTypeService
{
    private readonly IUnitOfWork _unitOfWork;
    private readonly IMapper _mapper;

    public PropertyTypeService(IUnitOfWork unitOfWork, IMapper mapper)
    {
        _unitOfWork = unitOfWork;
        _mapper = mapper;
    }

    public async Task<IEnumerable<PropertyTypeReadDto>> GetPropertyTypeAsync()
    {
        var propertyType = await _unitOfWork.PropertyType.GetAll();
        return _mapper.Map<IEnumerable<PropertyTypeReadDto>>(propertyType);
    }

    public async Task<PropertyTypeReadDto> GetPropertyTypeAsync(int value)
    {
        var propertyType = await _unitOfWork.PropertyType.Get(value);
        return _mapper.Map<PropertyTypeReadDto>(propertyType);
    }

    public async Task<PropertyTypeReadDto> GetPropertyTypeAsync(string value)
    {
        var propertyType = await _unitOfWork.PropertyType.Get(p => p.PropertyTypes == value);
        return _mapper.Map<PropertyTypeReadDto>(propertyType);
    }

    public async Task<ReturnResponsesDto> CreatePropertyTypeAsync(PropertyTypeCreateDto values)
    {
        try
        {
            var existingType = await _unitOfWork.PropertyType.Get(p => p.PropertyTypes == values.PropertyTypes);
            if (existingType != null)
            {
                return new ReturnResponsesDto
                {
                    IsSuccess = false,
                    ErrorResponse = new ErrorResponseDto { Code = StatusCodes.Status400BadRequest, Message = "Property Type already exists." },
                    SuccessResponse = null
                };
            }

            var propertyType = PropertyType.Create(0, values.PropertyTypes!);
            propertyType.CreatedBy = values.CreatedBy;
            propertyType.CreatedOn = DateTime.Now;

            _unitOfWork.PropertyType.Insert(propertyType);
            await _unitOfWork.Complete();

            var result = _mapper.Map<PropertyTypeReadDto>(propertyType);

            return new ReturnResponsesDto
            {
                IsSuccess = true,
                ErrorResponse = null,
                SuccessResponse = new SuccessResponseDto { Code = StatusCodes.Status201Created, Message = "Property Type created successfully.", Data = result },
            };
        }
        catch (Exception ex)
        {
            return new ReturnResponsesDto { IsSuccess = false, ErrorResponse = new ErrorResponseDto { Code = StatusCodes.Status500InternalServerError, Message = ex.Message }, SuccessResponse = null };
        }
    }

    public async Task<ReturnResponsesDto> UpdatePropertyTypeAsync(PropertyTypeUpdateDto values)
    {
        try
        {
            var propertyType = await _unitOfWork.PropertyType.Get(values.PropertyTypeId);
            if (propertyType == null)
            {
                return new ReturnResponsesDto
                {
                    IsSuccess = false,
                    ErrorResponse = new ErrorResponseDto { Code = StatusCodes.Status404NotFound, Message = $"Property Type with ID {values.PropertyTypeId} not found." },
                    SuccessResponse = null
                };
            }

            propertyType.Update(values.PropertyTypeId, values.PropertyTypes!);
            propertyType.ModifiedBy = values.ModifiedBy;
            propertyType.ModifiedOn = DateTime.Now;

            _unitOfWork.PropertyType.Update(propertyType);
            await _unitOfWork.Complete();

            var result = _mapper.Map<PropertyTypeReadDto>(propertyType);

            return new ReturnResponsesDto
            {
                IsSuccess = true,
                ErrorResponse = null,
                SuccessResponse = new SuccessResponseDto { Code = StatusCodes.Status200OK, Message = "Property Type modified successfully.", Data = result },
            };
        }
        catch (Exception ex)
        {
            return new ReturnResponsesDto { IsSuccess = false, ErrorResponse = new ErrorResponseDto { Code = StatusCodes.Status500InternalServerError, Message = ex.InnerException!.Message }, SuccessResponse = null };
        }
    }
}

