// /**************************************************
// * Company: MindSprings Company Limited
// * Project Name: Modules.Facilities.Application
// * Full FileName: /Users/imac5k/Projects/PropertyManagementSolution/pms-api/Modules/Modules.Facilities.Application/UseCases/Setup/ItemsService.cs
// * Author: Boakye Ofori-Atta
// * Email Address: boakye.ofori-atta@mindsprings-gh.com
// * Copyright: © 2024 MindSprings Company Limited
// * Create Date: 01/07/2025 10:45 AM
// * Version: 1.0.1
// * Description: Property Management System
//  **************************************************/

namespace Modules.Facilities.Application.UseCases.Setup
{
    public class ItemsService : IItemsService
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;

        public ItemsService(IUnitOfWork unitOfWork, IMapper mapper)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
        }

        public async Task<ReturnResponsesDto> CreateItemsAsync(ItemsCreateDto values)
        {
            try
            {
                var existing = await _unitOfWork.Items.Get(c => c.ItemCode == values.itemCode);
                if (existing != null)
                {
                    return new ReturnResponsesDto
                    {
                        IsSuccess = false,
                        ErrorResponse = new BaseResponseDto { StatusCode = StatusCodes.Status400BadRequest, StatusMessage = "Item already exists." },
                        SuccessResponse = null
                    };
                }
                var item = Items.Create(values.itemCategoryId, values.itemCode!, values.itemName!);
                item.CreatedBy = values.createdBy;
                item.CreatedOn = DateTime.Now;
                _unitOfWork.Items.Insert(item);
                await _unitOfWork.Complete();
                return new ReturnResponsesDto
                {
                    IsSuccess = true,
                    ErrorResponse = null,
                    SuccessResponse = new BaseResponseDto { StatusCode = StatusCodes.Status201Created, StatusMessage = "Item created successfully." }
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

        public async Task<ReturnResponsesDto> UpdateItemsAsync(ItemsUpdateDto values)
        {
            try
            {
                var item = await _unitOfWork.Items.Get(c => c.ItemCode == values.itemCode);
                if (item is null)
                {
                    return new ReturnResponsesDto
                    {
                        IsSuccess = false,
                        ErrorResponse = new BaseResponseDto { StatusCode = StatusCodes.Status404NotFound, StatusMessage = $"Item with code {values.itemCode} not found." },
                        SuccessResponse = null
                    };
                }
                item.Update(values.itemCategoryId, values.itemCode!, values.itemName!);
                item.ModifiedBy = values.modifiedBy;
                item.ModifiedOn = DateTime.Now;
                _unitOfWork.Items.Update(item);
                await _unitOfWork.Complete();
                return new ReturnResponsesDto
                {
                    IsSuccess = true,
                    ErrorResponse = null,
                    SuccessResponse = new BaseResponseDto { StatusCode = StatusCodes.Status200OK, StatusMessage = "Item updated successfully." }
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

        public async Task<IEnumerable<ItemsReadDto>> GetItemsAsync()
        {
            var items = await _unitOfWork.Items.GetAll(includes: new List<string> { "ItemCategory" });
            return _mapper.Map<IEnumerable<ItemsReadDto>>(items);
        }

        public async Task<ReturnResponsesDto> DeleteItemsAsync(string itemCode)
        {
            try
            {
                var item = await _unitOfWork.Items.Get(c => c.ItemCode == itemCode);
                if (item == null)
                {
                    return new ReturnResponsesDto
                    {
                        IsSuccess = false,
                        ErrorResponse = new BaseResponseDto { StatusCode = StatusCodes.Status404NotFound, StatusMessage = $"Item with code {itemCode} not found." },
                        SuccessResponse = null
                    };
                }
                _unitOfWork.Items.Delete(item);
                await _unitOfWork.Complete();
                return new ReturnResponsesDto
                {
                    IsSuccess = true,
                    ErrorResponse = null,
                    SuccessResponse = new BaseResponseDto { StatusCode = StatusCodes.Status200OK, StatusMessage = $"Item with code {itemCode} deleted successfully." }
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