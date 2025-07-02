// /**************************************************
// * Company: MindSprings Company Limited
// * Project Name: Modules.Facilities.Application
// * Full FileName: /Users/imac5k/Projects/PropertyManagementSolution/pms-api/Modules/Modules.Facilities.Application/UseCases/Setup/CategoryService.cs
// * Author: Boakye Ofori-Atta
// * Email Address: boakye.ofori-atta@mindsprings-gh.com
// * Copyright: © 2024 MindSprings Company Limited
// * Create Date: 01/07/2025 10:05 AM
// * Version: 1.0.1
// * Description: Property Management System
//  **************************************************/


namespace Modules.Facilities.Application.UseCases.Setup
{
	public class CategoryService : ICategoryService
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;

        public CategoryService(IUnitOfWork unitOfWork, IMapper mapper)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
        }

        public async Task<ReturnResponsesDto> CreateCategoryAsync(CategoryCreateDto values)
        {
            try
            {
                int categoryId = 0;

                var existingCategory = await _unitOfWork.Category.Get(c => c.CategoryName == values.categoryName);
                if (existingCategory != null)
                {
                    return new ReturnResponsesDto
                    {
                        IsSuccess = false,
                        ErrorResponse = new BaseResponseDto { StatusCode = StatusCodes.Status400BadRequest, StatusMessage = "Category Name already exists." },
                        SuccessResponse = null
                    };
                }

                var category = Category.Create(categoryId, values.categoryName!);
                category.CreatedBy = values.createdBy;
                category.CreatedOn = DateTime.Now;

                _unitOfWork.Category.Insert(category);
                await _unitOfWork.Complete();

                return new ReturnResponsesDto
                {
                    IsSuccess = true,
                    ErrorResponse = null,
                    SuccessResponse = new BaseResponseDto { StatusCode = StatusCodes.Status201Created, StatusMessage = "Category created successfully." }
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

        public async Task<ReturnResponsesDto> DeleteCategoryAsync(int categoryId)
        {
            try
            {
                var category = await _unitOfWork.Category.Get(categoryId);
                if (category == null)
                {
                    return new ReturnResponsesDto
                    {
                        IsSuccess = false,
                        ErrorResponse = new BaseResponseDto { StatusCode = StatusCodes.Status404NotFound, StatusMessage = $"Category with ID {categoryId} not found." },
                        SuccessResponse = null
                    };
                }

                _unitOfWork.Category.Delete(category);
                await _unitOfWork.Complete();

                return new ReturnResponsesDto
                {
                    IsSuccess = true,
                    ErrorResponse = null,
                    SuccessResponse = new BaseResponseDto { StatusCode = StatusCodes.Status200OK, StatusMessage = $"Category with ID {categoryId} deleted successfully." }
                };
            }
            catch (Exception ex)
            {
                return new ReturnResponsesDto
                {
                    IsSuccess = false,
                    ErrorResponse = new BaseResponseDto { StatusCode = StatusCodes.Status500InternalServerError, StatusMessage = ex.InnerException?.Message ?? ex.Message },
                    SuccessResponse = null
                };
            }
        }

        public async Task<IEnumerable<CategoryReadDto>> GetCategoryAsync()
        {
            var categories = await _unitOfWork.Category.GetAll();
            return _mapper.Map<IEnumerable<CategoryReadDto>>(categories);

        }

        public async Task<ReturnResponsesDto> UpdateCategoryAsync(CategoryUpdateDto values)
        {
            try
            {
                var category = await _unitOfWork.Category.Get(values.categoryId);
                if (category is null)
                {
                    return new ReturnResponsesDto
                    {
                        IsSuccess = false,
                        ErrorResponse = new BaseResponseDto { StatusCode = StatusCodes.Status404NotFound, StatusMessage = $"Category with ID {values.categoryId} not found." },
                        SuccessResponse = null
                    };
                }

                category.Update(values.categoryId, values.categoryName!);
                category.ModifiedBy = values.modifiedBy;
                category.ModifiedOn = DateTime.Now;

                _unitOfWork.Category.Update(category);
                await _unitOfWork.Complete();

                return new ReturnResponsesDto
                {
                    IsSuccess = true,
                    ErrorResponse = null,
                    SuccessResponse = new BaseResponseDto { StatusCode = StatusCodes.Status200OK, StatusMessage = "Category updated successfully." }
                };
            }
            catch (Exception ex)
            {
                return new ReturnResponsesDto
                {
                    IsSuccess = false,
                    ErrorResponse = new BaseResponseDto { StatusCode = StatusCodes.Status500InternalServerError, StatusMessage = ex.InnerException?.Message ?? ex.Message },
                    SuccessResponse = null
                };
            }
        }




    }
}

