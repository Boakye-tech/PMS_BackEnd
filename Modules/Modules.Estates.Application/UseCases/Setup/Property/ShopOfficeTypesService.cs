// /**************************************************
// * Company: MindSprings Company Limited
// * Project Name: Modules.Estates.Application
// * Full FileName: /Users/imac5k/Projects/PropertyManagementSolution/pms-api/Modules/Modules.Estates.Application/UseCases/Setup/Property/ShopOfficeTypesService.cs
// * Author: Boakye Ofori-Atta
// * Email Address: boakye.ofori-atta@mindsprings-gh.com
// * Copyright: © 2024 MindSprings Company Limited
// * Create Date: 23/05/2025 3:15 PM
// * Version: 1.0.1
// * Description: Property Management System
//  **************************************************/

using Microsoft.AspNetCore.Http;
using Modules.Estates.Domain.Entities.Setup.Property;

namespace Modules.Estates.Application.UseCases.Setup.Property
{
	public class ShopOfficeTypesService : IShopOfficeTypesService
	{
		private readonly IUnitOfWork _unitOfWork;
		private readonly IMapper _mapper;

		public ShopOfficeTypesService(IUnitOfWork unitOfWork, IMapper mapper)
		{
			_unitOfWork = unitOfWork;
			_mapper = mapper;
		}

		public async Task<IEnumerable<ShopOfficeTypesReadDto>> GetShopOfficeTypesAsync()
		{
			var shopOfficeTypes = await _unitOfWork.ShopOfficeTypes.GetAll();
			var rentalCategory = await _unitOfWork.RentalCategory.GetAll();
			var rentalType = await _unitOfWork.RentalType.GetAll();

            var result = from s in shopOfficeTypes
                         join rc in rentalCategory on s.RentalCategoryId equals rc.RentalCategoryId
                         join rt in rentalType on s.RentalTypeId equals rt.RentalTypeId
                         select new ShopOfficeTypesReadDto(
                             s.ShopOfficeTypeId,
                             s.Code,
                             s.TypeName,
                             s.RentalCategoryId,
                             rc.RentalCategories,
                             s.RentalTypeId,
                             rt.RentalTypes,
                             s.Features, // Assuming Features is already a string[]
                             s.Notes
                         );

            return result;
		}

		public async Task<ShopOfficeTypesReadDto> GetShopOfficeTypesAsync(int value)
		{
			var shopOfficeType = await _unitOfWork.ShopOfficeTypes.Get(value);
			return _mapper.Map<ShopOfficeTypesReadDto>(shopOfficeType);
		}

		public async Task<ShopOfficeTypesReadDto> GetShopOfficeTypesAsync(string value)
		{
			var shopOfficeType = await _unitOfWork.ShopOfficeTypes.Get(l => l.TypeName == value);
			return _mapper.Map<ShopOfficeTypesReadDto>(shopOfficeType);
		}

		public async Task<ReturnResponsesDto> CreateShopOfficeTypesAsync(ShopOfficeTypesCreateDto values)
		{
			try
			{
				int shopOfficeTypeId = 0;

				var existingShopOfficeCode = await _unitOfWork.ShopOfficeTypes.Get(s => s.Code == values.Code);
				if (existingShopOfficeCode != null)
				{
					return new ReturnResponsesDto
					{
						IsSuccess = false,
						ErrorResponse = new ErrorResponseDto { Code = StatusCodes.Status400BadRequest, Message = "Shop/Office Type Code already exists." },
						SuccessResponse = null
					};
				}

				var existingShopOfficeType = await _unitOfWork.ShopOfficeTypes.Get(s => s.TypeName == values.TypeName);
				if (existingShopOfficeType != null)
				{
					return new ReturnResponsesDto
					{
						IsSuccess = false,
						ErrorResponse = new ErrorResponseDto { Code = StatusCodes.Status400BadRequest, Message = "Shop/Office Type Name already exists." },
						SuccessResponse = null
					};
				}

				var shopOfficeType = ShopOfficeTypes.Create(
					shopOfficeTypeId,
					values.Code!,
					values.TypeName!,
					values.RentalCategoryId,
					values.RentalTypeId,
					values.Features!,
					values.Notes!
				);

				shopOfficeType.CreatedBy = values.CreatedBy;
				shopOfficeType.CreatedOn = DateTime.Now;

				_unitOfWork.ShopOfficeTypes.Insert(shopOfficeType);
				await _unitOfWork.Complete();

				return new ReturnResponsesDto
				{
					IsSuccess = true,
					ErrorResponse = null,
					SuccessResponse = new SuccessResponseDto { Code = StatusCodes.Status201Created, Message = "Shop/Office Type details created successfully." }
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

		public async Task<ReturnResponsesDto> UpdateShopOfficeTypesAsync(ShopOfficeTypesUpdateDto values)
		{
			try
			{
				var shopOfficeType = await _unitOfWork.ShopOfficeTypes.Get(values.ShopOfficeTypeId);
				if (shopOfficeType == null)
				{
					return new ReturnResponsesDto
					{
						IsSuccess = false,
						ErrorResponse = new ErrorResponseDto { Code = StatusCodes.Status404NotFound, Message = $"Shop/Office Type with ID {values.ShopOfficeTypeId} not found." },
						SuccessResponse = null
					};
				}

				shopOfficeType.Update(
					values.Code!,
					values.TypeName!,
					values.RentalCategoryId,
					values.RentalTypeId,
					values.Features!,
					values.Notes!
				);

				shopOfficeType.ModifiedBy = values.ModifiedBy;
				shopOfficeType.ModifiedOn = DateTime.Now;

				_unitOfWork.ShopOfficeTypes.Update(shopOfficeType);
				await _unitOfWork.Complete();

				return new ReturnResponsesDto
				{
					IsSuccess = true,
					ErrorResponse = null,
					SuccessResponse = new SuccessResponseDto { Code = StatusCodes.Status200OK, Message = "Shop/Office Type details modified successfully." }
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

		public async Task<ReturnResponsesDto> DeleteShopOfficeTypes(int shopOfficeTypesId)
		{
			try
			{
				var shopOfficeType = await _unitOfWork.ShopOfficeTypes.Get(shopOfficeTypesId);
				if (shopOfficeType == null)
				{
					return new ReturnResponsesDto
					{
						IsSuccess = false,
						ErrorResponse = new ErrorResponseDto { Code = StatusCodes.Status404NotFound, Message = $"Shop/Office Type with ID {shopOfficeTypesId} not found." },
						SuccessResponse = null
					};
				}

				_unitOfWork.ShopOfficeTypes.Delete(shopOfficeType);
				await _unitOfWork.Complete();

				return new ReturnResponsesDto
				{
					IsSuccess = true,
					ErrorResponse = null,
					SuccessResponse = new SuccessResponseDto { Code = StatusCodes.Status200OK, Message = $"Shop/Office Type with ID {shopOfficeTypesId} deleted successfully." }
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

