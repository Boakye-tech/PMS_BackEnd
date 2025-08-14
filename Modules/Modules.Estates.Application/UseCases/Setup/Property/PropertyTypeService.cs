// /**************************************************
// * Company: MindSprings Company Limited
// * Project Name: Modules.Estates.Application
// * Full FileName: /Users/imac5k/Projects/PropertyManagementSolution/pms-api/Modules/Modules.Estates.Application/UseCases/Setup/Property/PropertyTypeService.cs
// * Author: Boakye Ofori-Atta
// * Email Address: boakye.ofori-atta@mindsprings-gh.com
// * Copyright: © 2024 MindSprings Company Limited
// * Create Date: 24/07/2025 6:10 PM
// * Version: 1.0.1
// * Description: Property Management System
//  **************************************************/


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

	public async Task<List<PropertyTypeReadDto>> GetPropertyTypesAsync()
	{
		var propertyTypes = await _unitOfWork.PropertyType.GetAll();
		return _mapper.Map<List<PropertyTypeReadDto>>(propertyTypes);
	}


	public async Task<ReturnResponsesDto> CreatePropertyTypeAsync(PropertyTypeCreateDto values)
	{
		try
		{
			int propertyTypeId = 0;

			var propertyTypeInitial = await _unitOfWork.PropertyType.Get(pt => pt.PropertyTypeInitial == values.PropertyTypeInitial);
			if (propertyTypeInitial != null)
			{
				return new ReturnResponsesDto
				{
					IsSuccess = false,
					ErrorResponse = new ErrorResponseDto { Code = StatusCodes.Status400BadRequest, Message = "Property Type Initial already exists." },
					SuccessResponse = null
				};
			}

			var propertyTypeName = await _unitOfWork.PropertyType.Get(pt => pt.PropertyTypeName == values.PropertyTypeName);
			if (propertyTypeName != null)
			{
				return new ReturnResponsesDto
				{
					IsSuccess = false,
					ErrorResponse = new ErrorResponseDto { Code = StatusCodes.Status400BadRequest, Message = "Property Type Name already exists." },
					SuccessResponse = null
				};
			}

			var propertyType = PropertyType.Create(propertyTypeId, values.PropertyTypeInitial!, values.PropertyTypeName!);
			propertyType.CreatedBy = values.CreatedBy;
			propertyType.CreatedOn = DateTime.Now;

			_unitOfWork.PropertyType.Insert(propertyType);
			await _unitOfWork.Complete();

			var result = _mapper.Map<PropertyTypeReadDto>(propertyType);

			return new ReturnResponsesDto
			{
				IsSuccess = true,
				ErrorResponse = null,
				SuccessResponse = new SuccessResponseDto { Code = StatusCodes.Status201Created, Message = "Property Type details created successfully." },
			};
		}
		catch (Exception ex)
		{
			return new ReturnResponsesDto { IsSuccess = false, ErrorResponse = new ErrorResponseDto { Code = StatusCodes.Status500InternalServerError, Message = ex.InnerException?.Message ?? ex.Message }, SuccessResponse = null };
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

            var propertyTypeInitial = await _unitOfWork.PropertyType.Get(pt => pt.PropertyTypeInitial == values.PropertyTypeInitial);
            if (propertyTypeInitial != null)
            {
                return new ReturnResponsesDto
                {
                    IsSuccess = false,
                    ErrorResponse = new ErrorResponseDto { Code = StatusCodes.Status400BadRequest, Message = "Property Type Initial already exists." },
                    SuccessResponse = null
                };
            }

            var propertyTypeName = await _unitOfWork.PropertyType.Get(pt => pt.PropertyTypeName == values.PropertyTypeName);
            if (propertyTypeName != null)
            {
                return new ReturnResponsesDto
                {
                    IsSuccess = false,
                    ErrorResponse = new ErrorResponseDto { Code = StatusCodes.Status400BadRequest, Message = "Property Type Name already exists." },
                    SuccessResponse = null
                };
            }

            propertyType.Update(values.PropertyTypeId, values.PropertyTypeInitial!, values.PropertyTypeName!);
			propertyType.ModifiedBy = values.ModifiedBy;
			propertyType.ModifiedOn = DateTime.Now;

			_unitOfWork.PropertyType.Update(propertyType);
			await _unitOfWork.Complete();

			return new ReturnResponsesDto
			{
				IsSuccess = true,
				ErrorResponse = null,
				SuccessResponse = new SuccessResponseDto { Code = StatusCodes.Status200OK, Message = "Property Type details modified successfully." },
			};
		}
		catch (Exception ex)
		{
			return new ReturnResponsesDto { IsSuccess = false, ErrorResponse = new ErrorResponseDto { Code = StatusCodes.Status500InternalServerError, Message = ex.InnerException?.Message ?? ex.Message }, SuccessResponse = null };
		}
	}

	public async Task<ReturnResponsesDto> DeletePropertyType(int propertyTypeId)
	{
		try
		{
			var propertyType = await _unitOfWork.PropertyType.Get(propertyTypeId);
			if (propertyType == null)
			{
				return new ReturnResponsesDto
				{
					IsSuccess = false,
					ErrorResponse = new ErrorResponseDto { Code = StatusCodes.Status404NotFound, Message = $"Property Type with ID {propertyTypeId} not found." },
					SuccessResponse = null
				};
			}

			_unitOfWork.PropertyType.Delete(propertyType);
			await _unitOfWork.Complete();

			return new ReturnResponsesDto
			{
				IsSuccess = true,
				ErrorResponse = null,
				SuccessResponse = new SuccessResponseDto { Code = StatusCodes.Status200OK, Message = $"Property Type with ID {propertyTypeId} deleted successfully." }
			};
		}
		catch (Exception ex)
		{
			return new ReturnResponsesDto { IsSuccess = false, ErrorResponse = new ErrorResponseDto { Code = StatusCodes.Status500InternalServerError, Message = ex.InnerException?.Message ?? ex.Message }, SuccessResponse = null };
		}
	}


}

