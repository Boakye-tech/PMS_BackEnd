// /**************************************************
// * Company: MindSprings Company Limited
// * Project Name: Modules.Estates.Application
// * Full FileName: /Users/imac5k/Projects/PropertyManagementSolution/pms-api/Modules/Modules.Estates.Application/UseCases/Setup/Property/PropertyStatus.cs
// * Author: Boakye Ofori-Atta
// * Email Address: boakye.ofori-atta@mindsprings-gh.com
// * Copyright: © 2024 MindSprings Company Limited
// * Create Date: 14/05/2025 5:47 PM
// * Version: 1.0.1
// * Description: Property Management System
//  **************************************************/

using Microsoft.AspNetCore.Http;

namespace Modules.Estates.Application.UseCases.Setup.Property;

public class PropertyStatusService : IPropertyStatusService
{
	private readonly IUnitOfWork _unitOfWork;
	private readonly IMapper _mapper;

	public PropertyStatusService(IUnitOfWork unitOfWork, IMapper mapper)
	{
		_unitOfWork = unitOfWork;
		_mapper = mapper;
	}

	public async Task<IEnumerable<PropertyStatusReadDto>> GetPropertyStatusAsync()
	{
		var propertyStatuses = await _unitOfWork.PropertyStatus.GetAll();
		return _mapper.Map<IEnumerable<PropertyStatusReadDto>>(propertyStatuses);
	}

	public async Task<PropertyStatusReadDto> GetPropertyStatusAsync(int value)
	{
		var propertyStatus = await _unitOfWork.PropertyStatus.Get(value);
		return _mapper.Map<PropertyStatusReadDto>(propertyStatus);
	}

	public async Task<PropertyStatusReadDto> GetPropertyStatusAsync(string value)
	{
		var propertyStatus = await _unitOfWork.PropertyStatus.Get(l => l.PropertyStatusName == value);
		return _mapper.Map<PropertyStatusReadDto>(propertyStatus);
	}

	public async Task<ReturnResponsesDto> CreatePropertyStatusAsync(PropertyStatusCreateDto values)
	{
		try
		{
			int propertyStatusId = 0;

			var existingPropertyStatus = await _unitOfWork.PropertyStatus.Get(l => l.PropertyStatusName == values.PropertyStatusName);
			if (existingPropertyStatus != null)
			{
				return new ReturnResponsesDto
				{
					IsSuccess = false,
					ErrorResponse = new ErrorResponseDto { Code = StatusCodes.Status400BadRequest, Message = "Property Status already exists." },
					SuccessResponse = null
				};
			}

			var propertyStatus = PropertyStatus.Create(propertyStatusId, values.PropertyStatusName!);
			propertyStatus.CreatedBy = values.CreatedBy;
			propertyStatus.CreatedOn = DateTime.Now;

			_unitOfWork.PropertyStatus.Insert(propertyStatus);
			await _unitOfWork.Complete();

			return new ReturnResponsesDto
			{
				IsSuccess = true,
				ErrorResponse = null,
				SuccessResponse = new SuccessResponseDto { Code = StatusCodes.Status201Created, Message = "Property Status details created successfully." },
			};
		}
		catch (Exception ex)
		{
			return new ReturnResponsesDto { IsSuccess = false, ErrorResponse = new ErrorResponseDto { Code = StatusCodes.Status500InternalServerError, Message = ex.InnerException?.Message ?? ex.Message }, SuccessResponse = null };
		}
	}

	public async Task<ReturnResponsesDto> UpdatePropertyStatusAsync(PropertyStatusUpdateDto values)
	{
		try
		{
			var propertyStatus = await _unitOfWork.PropertyStatus.Get(values.PropertyStatusId);
			if (propertyStatus == null)
			{
				return new ReturnResponsesDto
				{
					IsSuccess = false,
					ErrorResponse = new ErrorResponseDto { Code = StatusCodes.Status404NotFound, Message = $"Property Status with ID {values.PropertyStatusId} not found." },
					SuccessResponse = null
				};
			}

			propertyStatus.Update(values.PropertyStatusId, values.PropertyStatusName!);
			propertyStatus.ModifiedBy = values.ModifiedBy;
			propertyStatus.ModifiedOn = DateTime.Now;

			_unitOfWork.PropertyStatus.Update(propertyStatus);
			await _unitOfWork.Complete();

			return new ReturnResponsesDto
			{
				IsSuccess = true,
				ErrorResponse = null,
				SuccessResponse = new SuccessResponseDto { Code = StatusCodes.Status200OK, Message = "Property Status details modified successfully." },
			};
		}
		catch (Exception ex)
		{
			return new ReturnResponsesDto { IsSuccess = false, ErrorResponse = new ErrorResponseDto { Code = StatusCodes.Status500InternalServerError, Message = ex.InnerException?.Message ?? ex.Message }, SuccessResponse = null };
		}
	}

	public async Task<ReturnResponsesDto> DeletePropertyStatus(int propertyStatusId)
	{
		try
		{
			var propertyStatus = await _unitOfWork.PropertyStatus.Get(propertyStatusId);
			if (propertyStatus == null)
			{
				return new ReturnResponsesDto
				{
					IsSuccess = false,
					ErrorResponse = new ErrorResponseDto { Code = StatusCodes.Status404NotFound, Message = $"Property Status with ID {propertyStatusId} not found." },
					SuccessResponse = null
				};
			}

			_unitOfWork.PropertyStatus.Delete(propertyStatus);
			await _unitOfWork.Complete();

			return new ReturnResponsesDto
			{
				IsSuccess = true,
				ErrorResponse = null,
				SuccessResponse = new SuccessResponseDto { Code = StatusCodes.Status200OK, Message = $"Property Status with ID {propertyStatusId} deleted successfully." }
			};
		}
		catch (Exception ex)
		{
			return new ReturnResponsesDto { IsSuccess = false, ErrorResponse = new ErrorResponseDto { Code = StatusCodes.Status500InternalServerError, Message = ex.InnerException?.Message ?? ex.Message }, SuccessResponse = null };
		}
	}
}

