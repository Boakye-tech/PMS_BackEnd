// /**************************************************
// * Company: MindSprings Company Limited
// * Project Name: Modules.Facilities.Application
// * Full FileName: /Users/imac5k/Projects/PropertyManagementSolution/pms-api/Modules/Modules.Facilities.Application/UseCases/Setup/ItemsCategoryService.cs
// * Author: Boakye Ofori-Atta
// * Email Address: boakye.ofori-atta@mindsprings-gh.com
// * Copyright: © 2024 MindSprings Company Limited
// * Create Date: 01/07/2025 10:40 AM
// * Version: 1.0.1
// * Description: Property Management System
//  **************************************************/

namespace Modules.Facilities.Application.UseCases.Setup
{
    public class ItemsCategoryService : IItemsCategoryService
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;

        public ItemsCategoryService(IUnitOfWork unitOfWork, IMapper mapper)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
        }

        public async Task<ReturnResponsesDto> CreateItemsCategoryAsync(ItemsCategoryCreateDto values)
        {
            try
            {
                var existing = await _unitOfWork.ItemsCategory.Get(c => c.ItemCategoryName == values.itemCategoryName);
                if (existing != null)
                {
                    return new ReturnResponsesDto
                    {
                        IsSuccess = false,
                        ErrorResponse = new BaseResponseDto { StatusCode = StatusCodes.Status400BadRequest, StatusMessage = "Item category name already exists." },
                        SuccessResponse = null
                    };
                }
                var itemCategory = ItemsCategory.Create(0, values.itemCategoryName!);
                itemCategory.CreatedBy = values.createdBy;
                itemCategory.CreatedOn = DateTime.Now;
                _unitOfWork.ItemsCategory.Insert(itemCategory);
                await _unitOfWork.Complete();
                return new ReturnResponsesDto
                {
                    IsSuccess = true,
                    ErrorResponse = null,
                    SuccessResponse = new BaseResponseDto { StatusCode = StatusCodes.Status201Created, StatusMessage = "Item category created successfully." }
                };
            }
            catch (Exception ex)
            {
                return new ReturnResponsesDto
                {
                    IsSuccess = false,
                    ErrorResponse = new BaseResponseDto { StatusCode = StatusCodes.Status500InternalServerError, StatusMessage = ex.Message },
                    SuccessResponse = null
                };
            }
        }

        public async Task<ReturnResponsesDto> UpdateItemsCategoryAsync(ItemsCategoryUpdateDto values)
        {
            try
            {
                var itemCategory = await _unitOfWork.ItemsCategory.Get(values.itemCategoryId);
                if (itemCategory is null)
                {
                    return new ReturnResponsesDto
                    {
                        IsSuccess = false,
                        ErrorResponse = new BaseResponseDto { StatusCode = StatusCodes.Status404NotFound, StatusMessage = $"Item category with ID {values.itemCategoryId} not found." },
                        SuccessResponse = null
                    };
                }
                itemCategory.Update(values.itemCategoryId, values.itemCategoryName!);
                itemCategory.ModifiedBy = values.modifiedBy;
                itemCategory.ModifiedOn = DateTime.Now;
                _unitOfWork.ItemsCategory.Update(itemCategory);
                await _unitOfWork.Complete();
                return new ReturnResponsesDto
                {
                    IsSuccess = true,
                    ErrorResponse = null,
                    SuccessResponse = new BaseResponseDto { StatusCode = StatusCodes.Status200OK, StatusMessage = "Item category updated successfully." }
                };
            }
            catch (Exception ex)
            {
                return new ReturnResponsesDto
                {
                    IsSuccess = false,
                    ErrorResponse = new BaseResponseDto { StatusCode = StatusCodes.Status500InternalServerError, StatusMessage = ex.Message },
                    SuccessResponse = null
                };
            }
        }

        public async Task<IEnumerable<ItemsCategoryReadDto>> GetItemsCategoryAsync()
        {
            var categories = await _unitOfWork.ItemsCategory.GetAll();
            return _mapper.Map<IEnumerable<ItemsCategoryReadDto>>(categories);
        }

        public async Task<IEnumerable<ItemCategoryAndItemsReadDto>> GetItemCategoryAndItemsAsync()
        {
            var categories = await _unitOfWork.ItemsCategory.GetAll(includes: new List<string> { "Items" });

            var result = categories.Select(c => new ItemCategoryAndItemsReadDto(
                new ItemsCategoryReadDto(c.ItemCategoryId, c.ItemCategoryName),
                c.Items!.Select(i => new ItemReadDto(i.ItemCode, i.ItemName)).ToList()
            ));

            return result;

        }


        public async Task<ReturnResponsesDto> DeleteItemsCategoryAsync(int itemCategoryId)
        {
            try
            {
                var itemCategory = await _unitOfWork.ItemsCategory.Get(itemCategoryId);
                if (itemCategory == null)
                {
                    return new ReturnResponsesDto
                    {
                        IsSuccess = false,
                        ErrorResponse = new BaseResponseDto { StatusCode = StatusCodes.Status404NotFound, StatusMessage = $"Item category with ID {itemCategoryId} not found." },
                        SuccessResponse = null
                    };
                }
                _unitOfWork.ItemsCategory.Delete(itemCategory);
                await _unitOfWork.Complete();
                return new ReturnResponsesDto
                {
                    IsSuccess = true,
                    ErrorResponse = null,
                    SuccessResponse = new BaseResponseDto { StatusCode = StatusCodes.Status200OK, StatusMessage = $"Item category with ID {itemCategoryId} deleted successfully." }
                };
            }
            catch (Exception ex)
            {
                return new ReturnResponsesDto
                {
                    IsSuccess = false,
                    ErrorResponse = new BaseResponseDto { StatusCode = StatusCodes.Status500InternalServerError, StatusMessage = ex.Message },
                    SuccessResponse = null
                };
            }
        }
    }
}