// /**************************************************
// * Company: MindSprings Company Limited
// * Project Name: Modules.Estates.Application
// * Full FileName: /Users/imac5k/Projects/PropertyManagementSolution/pms-api/Modules/Modules.Estates.Application/UseCases/Setup/Property/TypesService.cs
// * Author: Boakye Ofori-Atta
// * Email Address: boakye.ofori-atta@mindsprings-gh.com
// * Copyright: © 2024 MindSprings Company Limited
// * Create Date: 15/06/2025 9:33 AM
// * Version: 1.0.1
// * Description: Property Management System
//  **************************************************/
using System;
using Microsoft.AspNetCore.Http;

namespace Modules.Estates.Application.UseCases.Setup.Property
{
	public class TypesService : ITypesService
    {
        private readonly IUnitOfWork _unitOfWork;

        public TypesService(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public async Task<ReturnResponsesDto> CreateTypesAsync(TypesCreateDto values)
        {
            try
            {
                int typeId = 0;

                var existingCode = await _unitOfWork.Types.Get(h => h.Code == values.Code);
                if (existingCode != null)
                {
                    return new ReturnResponsesDto
                    {
                        IsSuccess = false,
                        ErrorResponse = new ErrorResponseDto { Code = StatusCodes.Status400BadRequest, Message = "Type Code already exists." },
                        SuccessResponse = null
                    };
                }

                var existingType = await _unitOfWork.Types.Get(h => h.TypeName == values.TypeName);
                if (existingType != null)
                {
                    return new ReturnResponsesDto
                    {
                        IsSuccess = false,
                        ErrorResponse = new ErrorResponseDto { Code = StatusCodes.Status400BadRequest, Message = "Type Name already exists." },
                        SuccessResponse = null
                    };
                }

                var types = Types.Create(
                    typeId,
                    values.Code!,
                    values.TypeName!,
                    values.RentalCategoryId,
                    values.RentalTypeId,
                    values.Features!,
                    values.Notes!
                );

                types.CreatedBy = values.CreatedBy;
                types.CreatedOn = DateTime.Now;

                _unitOfWork.Types.Insert(types);
                await _unitOfWork.Complete();

                return new ReturnResponsesDto
                {
                    IsSuccess = true,
                    ErrorResponse = null,
                    SuccessResponse = new SuccessResponseDto { Code = StatusCodes.Status201Created, Message = "House Type details created successfully." }
                };
            }
            catch (Exception ex)
            {
                return new ReturnResponsesDto
                {
                    IsSuccess = false,
                    ErrorResponse = new ErrorResponseDto { Code = StatusCodes.Status500InternalServerError, Message = ex.Message },
                    SuccessResponse = null
                };
            }
        }

        public async Task<ReturnResponsesDto> DeleteTypes(int typesId)
        {
            try
            {
                var types = await _unitOfWork.Types.Get(typesId);
                if (types == null)
                {
                    return new ReturnResponsesDto
                    {
                        IsSuccess = false,
                        ErrorResponse = new ErrorResponseDto { Code = StatusCodes.Status404NotFound, Message = $"Type with ID {typesId} not found." },
                        SuccessResponse = null
                    };
                }

                _unitOfWork.Types.Delete(types);
                await _unitOfWork.Complete();

                return new ReturnResponsesDto
                {
                    IsSuccess = true,
                    ErrorResponse = null,
                    SuccessResponse = new SuccessResponseDto { Code = StatusCodes.Status200OK, Message = $"Type with ID {typesId} deleted successfully." }
                };
            }
            catch (Exception ex)
            {
                return new ReturnResponsesDto
                {
                    IsSuccess = false,
                    ErrorResponse = new ErrorResponseDto { Code = StatusCodes.Status500InternalServerError, Message = ex.InnerException!.Message ?? ex.Message },
                    SuccessResponse = null
                };
            }
        }

        public async Task<List<AllTypesRentalCategoryDto>> GetAllTypesAsync()
        {
            try
            {
                // Step 1: Fetch all Types with RentalCategory and RentalType included
                var types = await _unitOfWork.Types.GetAll(includes: new List<string> { "RentalCategory", "RentalType" });

                // Step 2: Group and project into nested DTOs
                var result = types
                    .GroupBy(t => new { t.RentalCategoryId, t.RentalCategory!.RentalCategories })
                    .Select(categoryGroup =>
                    {
                        var rentalTypesPerCategory = categoryGroup
                            .GroupBy(t => new { t.RentalTypeId, t.RentalType!.RentalTypes })
                            .Select(typeGroup =>
                            {
                                var typesPerRentalType = typeGroup.Select(t => new AllTypesReadDto(
                                    t.TypeId,
                                    t.Code,
                                    t.TypeName,
                                    t.Features,
                                    t.Notes
                                )).ToList();

                                return new AllRentalTypesReadDto(
                                    typeGroup.Key.RentalTypeId,
                                    typeGroup.Key.RentalTypes,
                                    typesPerRentalType
                                );
                            }).ToList();

                        return new AllTypesRentalCategoryDto(
                            categoryGroup.Key.RentalCategoryId,
                            categoryGroup.Key.RentalCategories,
                            rentalTypesPerCategory
                        );
                    }).ToList();

                // Step 3: Return the nested DTO result
                return result;

            }
            catch (Exception ex)
            {
                return null!;
            }

        }

        public async Task<ReturnResponsesDto> UpdateTypesAsync(TypesUpdateDto values)
        {
            try
            {
                var types = await _unitOfWork.Types.Get(values.TypeId);
                if (types == null)
                {
                    return new ReturnResponsesDto
                    {
                        IsSuccess = false,
                        ErrorResponse = new ErrorResponseDto { Code = StatusCodes.Status404NotFound, Message = $"Type with ID {values.TypeId} not found." },
                        SuccessResponse = null
                    };
                }

                types.Update(
                    values.TypeId,
                    values.Code!,
                    values.TypeName!,
                    values.RentalCategoryId,
                    values.RentalTypeId,
                    values.Features!,
                    values.Notes!
                );

                types.ModifiedBy = values.ModifiedBy;
                types.ModifiedOn = DateTime.Now;

                _unitOfWork.Types.Update(types);
                await _unitOfWork.Complete();

                return new ReturnResponsesDto
                {
                    IsSuccess = true,
                    ErrorResponse = null,
                    SuccessResponse = new SuccessResponseDto { Code = StatusCodes.Status200OK, Message = "Type details modified successfully." }
                };
            }
            catch (Exception ex)
            {
                return new ReturnResponsesDto
                {
                    IsSuccess = false,
                    ErrorResponse = new ErrorResponseDto { Code = StatusCodes.Status500InternalServerError, Message = ex.InnerException!.Message ?? ex.Message },
                    SuccessResponse = null
                };
            }
        }
    }
}

