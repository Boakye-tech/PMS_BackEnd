// /**************************************************
// * Company: MindSprings Company Limited
// * Project Name: Modules.Estates.Application
// * Full FileName: /Users/imac5k/Projects/PropertyManagementSolution/pms-api/Modules/Modules.Estates.Application/UseCases/Setup/Property/ShopOfficeTypeAndDescriptionService.cs
// * Author: Boakye Ofori-Atta
// * Email Address: boakye.ofori-atta@mindsprings-gh.com
// * Copyright: © 2024 MindSprings Company Limited
// * Create Date: 15/05/2025 9:28 PM
// * Version: 1.0.1
// * Description: Property Management System
//  **************************************************/

using Microsoft.AspNetCore.Http;

namespace Modules.Estates.Application.UseCases.Setup.Property;

public class ShopOfficeTypeAndDescriptionService : IShopOfficeTypeAndDescriptionService
{
	private readonly IUnitOfWork _unitOfWork;
	private readonly IMapper _mapper;

	public ShopOfficeTypeAndDescriptionService(IUnitOfWork unitOfWork, IMapper mapper)
	{
		_unitOfWork = unitOfWork;
		_mapper = mapper;
	}

	public async Task<IEnumerable<ShopOfficeTypeAndDescriptionReadDto>> GetShopOfficeTypeAndDescriptionAsync()
	{
		var shopOfficeTypes = await _unitOfWork.ShopOfficeTypeAndDescription.GetAll();
		return _mapper.Map<IEnumerable<ShopOfficeTypeAndDescriptionReadDto>>(shopOfficeTypes);
	}

	public async Task<ShopOfficeTypeAndDescriptionReadDto> GetShopOfficeTypeAndDescriptionAsync(int value)
	{
		var shopOfficeType = await _unitOfWork.ShopOfficeTypeAndDescription.Get(value);
		return _mapper.Map<ShopOfficeTypeAndDescriptionReadDto>(shopOfficeType);
	}

	public async Task<ShopOfficeTypeAndDescriptionReadDto> GetShopOfficeTypeAndDescriptionAsync(string value)
	{
		var shopOfficeType = await _unitOfWork.ShopOfficeTypeAndDescription.Get(l => l.TypeName == value);
		return _mapper.Map<ShopOfficeTypeAndDescriptionReadDto>(shopOfficeType);
	}

	public async Task<ReturnResponsesDto> CreateShopOfficeTypeAndDescriptionAsync(ShopOfficeTypeAndDescriptionCreateDto values)
	{
		try
		{
			int shopOfficeTypeId = 0;

			var existingShopOfficeType = await _unitOfWork.ShopOfficeTypeAndDescription.Get(l => l.TypeName == values.TypeName);
			if (existingShopOfficeType != null)
			{
				return new ReturnResponsesDto
				{
					IsSuccess = false,
					ErrorResponse = new ErrorResponseDto { Code = StatusCodes.Status400BadRequest, Message = "Shop Office Type already exists." },
					SuccessResponse = null
				};
			}

			var shopOfficeType = ShopOfficeTypeAndDescription.Create(values.shopTypeCategory, shopOfficeTypeId, values.TypeName!, values.Description!);
			shopOfficeType.CreatedBy = values.CreatedBy;
			shopOfficeType.CreatedOn = DateTime.Now;

			_unitOfWork.ShopOfficeTypeAndDescription.Insert(shopOfficeType);
			await _unitOfWork.Complete();

			var result = _mapper.Map<ShopOfficeTypeAndDescriptionReadDto>(shopOfficeType);

			return new ReturnResponsesDto
			{
				IsSuccess = true,
				ErrorResponse = null,
				SuccessResponse = new SuccessResponseDto { Code = StatusCodes.Status201Created, Message = "Shop Office Type and Description details created successfully.", Data = result },
			};
		}
		catch (Exception ex)
		{
			return new ReturnResponsesDto { IsSuccess = false, ErrorResponse = new ErrorResponseDto { Code = StatusCodes.Status500InternalServerError, Message = ex.Message }, SuccessResponse = null };
		}
	}

	public async Task<ReturnResponsesDto> UpdateShopOfficeTypeAndDescriptionAsync(ShopOfficeTypeAndDescriptionUpdateDto values)
	{
		try
		{
			var shopOfficeType = await _unitOfWork.ShopOfficeTypeAndDescription.Get(values.ShopOfficeTypeId);
			if (shopOfficeType == null)
			{
				return new ReturnResponsesDto
				{
					IsSuccess = false,
					ErrorResponse = new ErrorResponseDto { Code = StatusCodes.Status404NotFound, Message = $"Shop Office Type and Description with ID {values.ShopOfficeTypeId} not found." },
					SuccessResponse = null
				};
			}

			shopOfficeType.Update(values.shopTypeCategory, values.ShopOfficeTypeId, values.TypeName!, values.Description!);
			shopOfficeType.ModifiedBy = values.ModifiedBy;
			shopOfficeType.ModifiedOn = DateTime.Now;

			_unitOfWork.ShopOfficeTypeAndDescription.Update(shopOfficeType);
			await _unitOfWork.Complete();

			var result = _mapper.Map<ShopOfficeTypeAndDescriptionReadDto>(shopOfficeType);

			return new ReturnResponsesDto
			{
				IsSuccess = true,
				ErrorResponse = null,
				SuccessResponse = new SuccessResponseDto { Code = StatusCodes.Status200OK, Message = "Shop Office Type and Description details modified successfully.", Data = result },
			};
		}
		catch (Exception ex)
		{
			return new ReturnResponsesDto { IsSuccess = false, ErrorResponse = new ErrorResponseDto { Code = StatusCodes.Status500InternalServerError, Message = ex.InnerException!.Message }, SuccessResponse = null };
		}
	}

	public async Task<ReturnResponsesDto> DeleteShopOfficeTypeAndDescription(int shopOfficeTypeId)
	{
		try
		{
			var shopOfficeType = await _unitOfWork.ShopOfficeTypeAndDescription.Get(shopOfficeTypeId);
			if (shopOfficeType == null)
			{
				return new ReturnResponsesDto
				{
					IsSuccess = false,
					ErrorResponse = new ErrorResponseDto { Code = StatusCodes.Status404NotFound, Message = $"Shop Office Type and Description with ID {shopOfficeTypeId} not found." },
					SuccessResponse = null
				};
			}

			_unitOfWork.ShopOfficeTypeAndDescription.Delete(shopOfficeType);
			await _unitOfWork.Complete();

			return new ReturnResponsesDto
			{
				IsSuccess = true,
				ErrorResponse = null,
				SuccessResponse = new SuccessResponseDto { Code = StatusCodes.Status200OK, Message = $"Shop Office Type and Description with ID {shopOfficeTypeId} deleted successfully." }
			};
		}
		catch (Exception ex)
		{
			return new ReturnResponsesDto { IsSuccess = false, ErrorResponse = new ErrorResponseDto { Code = StatusCodes.Status500InternalServerError, Message = ex.InnerException!.Message }, SuccessResponse = null };
		}
	}
}

