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

                List<string> featureNames = new List<string>();

                foreach (var featureId in values.Features)
                {
                    var feature = await _unitOfWork.Features.Get(featureId); 
                    if (feature != null)
                    {
                        featureNames.Add(string.Concat(featureId," - ", feature.Feature)); 
                    }
                }

                string[] features = featureNames.ToArray();

                var types = Types.Create(
                    typeId,
                    values.Code!,
                    values.TypeName!,
                    values.RentalCategoryId,
                    values.RentalTypeId,
                    features!,
                    values.Price,
                    values.CurrencyId,
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


        public async Task<List<AllTypesRentalCategoryDto>> GetAllTypesAsync(string? searchTerm)
        {
            var types = await _unitOfWork.Types.GetAll(includes: new List<string> { "RentalCategory", "RentalType", "Currency" });

            if (string.IsNullOrWhiteSpace(searchTerm))
            {
                // No search — return all data
                return types
                    .GroupBy(t => new { t.RentalCategoryId, t.RentalCategory!.RentalCategories })
                    .Select(categoryGroup =>
                    {
                        var rentalTypesPerCategory = categoryGroup
                            .GroupBy(t => new { t.RentalTypeId, t.RentalType!.RentalTypes })
                            .Select(typeGroup =>
                            {
                                var typesPerRentalType = typeGroup.Select(t =>
                                    new AllTypesReadDto(
                                        t.TypeId,
                                        t.Code,
                                        t.TypeName,
                                        ParseFeatures(t.Features),
                                        t.Price,
                                        t.CurrencyId,
                                        t.Currency!.CurrencyInitial!,
                                        t.Currency!.CurrencyName!,
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
            }

            var term = searchTerm.Trim();

            var results = types
                .GroupBy(t => new { t.RentalCategoryId, t.RentalCategory!.RentalCategories })
                .Select(categoryGroup =>
                {
                    bool categoryMatch = categoryGroup.Key.RentalCategories?
                        .IndexOf(term, StringComparison.OrdinalIgnoreCase) >= 0;

                    if (categoryMatch)
                    {
                        // Whole category matched → return all rental types
                        var allRentalTypes = categoryGroup
                            .GroupBy(t => new { t.RentalTypeId, t.RentalType!.RentalTypes })
                            .Select(typeGroup => new AllRentalTypesReadDto(
                                typeGroup.Key.RentalTypeId,
                                typeGroup.Key.RentalTypes,
                                typeGroup.Select(t => new AllTypesReadDto(
                                    t.TypeId,
                                    t.Code,
                                    t.TypeName,
                                    ParseFeatures(t.Features),
                                    t.Price,
                                    t.CurrencyId,
                                    t.Currency!.CurrencyInitial!,
                                    t.Currency!.CurrencyName!,
                                    t.Notes
                                )).ToList()
                            )).ToList();

                        return new AllTypesRentalCategoryDto(
                            categoryGroup.Key.RentalCategoryId,
                            categoryGroup.Key.RentalCategories!,
                            allRentalTypes
                        );
                    }

                    // Filter by rental type or type properties
                    var filteredRentalTypes = categoryGroup
                        .GroupBy(t => new { t.RentalTypeId, t.RentalType!.RentalTypes })
                        .Select(typeGroup =>
                        {
                            bool rentalTypeMatch = typeGroup.Key.RentalTypes?
                                .IndexOf(term, StringComparison.OrdinalIgnoreCase) >= 0;

                            if (rentalTypeMatch)
                            {
                                // Rental type matched → return all types
                                return new AllRentalTypesReadDto(
                                    typeGroup.Key.RentalTypeId,
                                    typeGroup.Key.RentalTypes!,
                                    typeGroup.Select(t => new AllTypesReadDto(
                                        t.TypeId,
                                        t.Code,
                                        t.TypeName,
                                        ParseFeatures(t.Features),
                                        t.Price,
                                        t.CurrencyId,
                                        t.Currency!.CurrencyInitial!,
                                        t.Currency!.CurrencyName!,
                                        t.Notes
                                    )).ToList()
                                );
                            }

                            // Match individual types
                            var matchingTypes = typeGroup
                                .Where(t =>
                                    (t.TypeName?.IndexOf(term, StringComparison.OrdinalIgnoreCase) ?? -1) >= 0 ||
                                    (t.Code?.IndexOf(term, StringComparison.OrdinalIgnoreCase) ?? -1) >= 0 ||
                                    (t.Notes?.IndexOf(term, StringComparison.OrdinalIgnoreCase) ?? -1) >= 0 ||
                                    (t.Features != null && t.Features.Any(f =>
                                        f?.IndexOf(term, StringComparison.OrdinalIgnoreCase) >= 0))
                                )
                                .Select(t => new AllTypesReadDto(
                                    t.TypeId,
                                    t.Code,
                                    t.TypeName,
                                    ParseFeatures(t.Features),
                                    t.Price,
                                    t.CurrencyId,
                                    t.Currency!.CurrencyInitial!,
                                    t.Currency!.CurrencyName!,
                                    t.Notes
                                ))
                                .ToList();

                            if (matchingTypes.Any())
                            {
                                return new AllRentalTypesReadDto(
                                    typeGroup.Key.RentalTypeId,
                                    typeGroup.Key.RentalTypes!,
                                    matchingTypes
                                );
                            }

                            return null;
                        })
                        .Where(rt => rt != null)
                        .ToList()!;

                    if (filteredRentalTypes.Any())
                    {
                        return new AllTypesRentalCategoryDto(
                            categoryGroup.Key.RentalCategoryId,
                            categoryGroup.Key.RentalCategories!,
                            filteredRentalTypes!
                        );
                    }

                    return null;
                })
                .Where(c => c != null)
                .ToList()!;

            return results!;
        }

        // Helper to parse features into DTOs
        private List<AllTypesFeaturesReadDto> ParseFeatures(IEnumerable<string>? features)
        {
            var featureDtos = new List<AllTypesFeaturesReadDto>();

            if (features != null)
            {
                foreach (var f in features)
                {
                    if (string.IsNullOrWhiteSpace(f))
                        continue;

                    var parts = f.Split(" - ", 2, StringSplitOptions.TrimEntries);

                    if (parts.Length == 2 && int.TryParse(parts[0], out int featureId))
                    {
                        featureDtos.Add(new AllTypesFeaturesReadDto(featureId, parts[1]));
                    }
                    else
                    {
                        featureDtos.Add(new AllTypesFeaturesReadDto(0, f.Trim()));
                    }
                }
            }

            return featureDtos;
        }


        public async Task<List<AllTypesReadDto>> GetAllTypesAsync(int rentalTypeId)
        {
            try
            {
                // Step 1: Fetch all Types only (no includes for RentalCategory or RentalType)
                var types = await _unitOfWork.Types.GetAll(t => t.RentalTypeId == rentalTypeId);

                // Step 2: Project directly into AllTypesReadDto
                var result = types.Select(t =>
                {
                    var featureDtos = new List<AllTypesFeaturesReadDto>();

                    if (t.Features != null)
                    {
                        foreach (var f in t.Features)
                        {
                            if (string.IsNullOrWhiteSpace(f))
                                continue;

                            var parts = f.Split(" - ", 2, StringSplitOptions.TrimEntries);

                            if (parts.Length == 2 && int.TryParse(parts[0], out int featureId))
                            {
                                // Format: "9 - BEDROOM 1"
                                featureDtos.Add(new AllTypesFeaturesReadDto(featureId, parts[1]));
                            }
                            else
                            {
                                // Format: "BEDROOM 1" — no ID
                                featureDtos.Add(new AllTypesFeaturesReadDto(0, f.Trim()));
                            }
                        }
                    }

                    return new AllTypesReadDto(
                        t.TypeId,
                        t.Code,
                        t.TypeName,
                        featureDtos,
                        t.Price,
                        t.CurrencyId,
                        t.Currency!.CurrencyInitial!,
                        t.Currency.CurrencyName!,
                        t.Notes
                    );
                }).ToList();

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

                List<string> featureNames = new List<string>();

                foreach (var featureId in values.Features)
                {
                    var feature = await _unitOfWork.Features.Get(featureId);
                    if (feature != null)
                    {
                        featureNames.Add(string.Concat(featureId, " - ", feature.Feature));
                    }
                }

                string[] features = featureNames.ToArray();

                types.Update(
                    values.TypeId,
                    values.Code!,
                    values.TypeName!,
                    types.RentalCategoryId,
                    types.RentalTypeId,
                    features!,
                    values.Price,
                    values.CurrencyId,
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

