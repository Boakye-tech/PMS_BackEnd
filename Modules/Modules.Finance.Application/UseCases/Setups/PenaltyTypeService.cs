// /**************************************************
// * Company: MindSprings Company Limited
// * Project Name: Modules.Finance.Application
// * Full FileName: /Users/imac5k/Projects/PropertyManagementSolution/pms-api/Modules/Modules.Finance.Application/UseCases/Setups/PenaltyTypeService.cs
// * Author: Boakye Ofori-Atta
// * Email Address: boakye.ofori-atta@mindsprings-gh.com
// * Copyright: © 2024 MindSprings Company Limited
// * Create Date: 22/09/2025 3:15 PM
// * Version: 1.0.1
// * Description: Property Management System
//  **************************************************/
using System;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Http.HttpResults;
using Modules.Finance.Application.Dtos.Setup;

namespace Modules.Finance.Application.UseCases.Setups
{
    public class PenaltyTypeService : IPenaltyTypeService
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;

        public PenaltyTypeService(IUnitOfWork unitOfWork, IMapper mapper)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
        }

        public async Task<IEnumerable<PenaltyTypeReadDto>> GetPenaltyTypesAsync()
        {
            var penaltyTypes = await _unitOfWork.PenaltyTypes.GetAll();
            return penaltyTypes.Select(pt => new PenaltyTypeReadDto(
                pt.PenaltyTypeId, pt.Name, pt.Code, pt.Description, pt.IsActive
            ));
        }

        public async Task<PenaltyTypeReadDto> GetPenaltyTypeAsync(int penaltyTypeId)
        {
            var penaltyType = await _unitOfWork.PenaltyTypes.Get(pt => pt.PenaltyTypeId == penaltyTypeId);
            if (penaltyType == null) return null!;

            return new PenaltyTypeReadDto(
                penaltyType.PenaltyTypeId, penaltyType.Name, penaltyType.Code,
                penaltyType.Description, penaltyType.IsActive
            );
        }

        public async Task<IEnumerable<PenaltyTypeReadDto>> GetActivePenaltyTypesAsync()
        {
            var penaltyTypes = await _unitOfWork.PenaltyTypes.GetAll(pt => pt.IsActive);
            return penaltyTypes.Select(pt => new PenaltyTypeReadDto(
                pt.PenaltyTypeId, pt.Name, pt.Code, pt.Description, pt.IsActive
            ));
        }

        public async Task<ReturnResponsesDto> CreatePenaltyTypeAsync(PenaltyTypeCreateDto values)
        {
            try
            {
                var existingCode = await _unitOfWork.PenaltyTypes.Get(pt => pt.Code == values.Code);
                if (existingCode != null)
                {
                    return new ReturnResponsesDto
                    {
                        IsSuccess = false,
                        ErrorResponse = new ErrorResponseDto { Code = StatusCodes.Status400BadRequest, Message = "Penalty type code already exists." },
                        SuccessResponse = null
                    };
                }

                var existingName = await _unitOfWork.PenaltyTypes.Get(pt => pt.Name == values.Name);
                if (existingName != null)
                {
                    return new ReturnResponsesDto
                    {
                        IsSuccess = false,
                        ErrorResponse = new ErrorResponseDto { Code = StatusCodes.Status400BadRequest, Message = "Penalty type name already exists." },
                        SuccessResponse = null
                    };
                }

                var penaltyType = PenaltyType.Create(values.Name, values.Code, values.Description, values.IsActive);
                penaltyType.CreatedBy = values.CreatedBy;
                penaltyType.CreatedOn = DateTime.Now;

                _unitOfWork.PenaltyTypes.Insert(penaltyType);
                await _unitOfWork.Complete();

                return new ReturnResponsesDto
                {
                    IsSuccess = true,
                    ErrorResponse = null,
                    SuccessResponse = new SuccessResponseDto { Code = StatusCodes.Status201Created, Message = "Penalty type created successfully." }
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

        public async Task<ReturnResponsesDto> UpdatePenaltyTypeAsync(PenaltyTypeUpdateDto values)
        {
            try
            {
                var penaltyType = await _unitOfWork.PenaltyTypes.Get(pt => pt.PenaltyTypeId == values.PenaltyTypeId);
                if (penaltyType == null)
                {
                    return new ReturnResponsesDto
                    {
                        IsSuccess = false,
                        ErrorResponse = new ErrorResponseDto { Code = StatusCodes.Status404NotFound, Message = "Penalty type not found." },
                        SuccessResponse = null
                    };
                }

                var existingCode = await _unitOfWork.PenaltyTypes.Get(pt => pt.Code == values.Code && pt.PenaltyTypeId != values.PenaltyTypeId);
                if (existingCode != null)
                {
                    return new ReturnResponsesDto
                    {
                        IsSuccess = false,
                        ErrorResponse = new ErrorResponseDto { Code = StatusCodes.Status400BadRequest, Message = "Penalty type code already exists." },
                        SuccessResponse = null
                    };
                }

                var existingName = await _unitOfWork.PenaltyTypes.Get(pt => pt.Name == values.Name && pt.PenaltyTypeId != values.PenaltyTypeId);
                if (existingName != null)
                {
                    return new ReturnResponsesDto
                    {
                        IsSuccess = false,
                        ErrorResponse = new ErrorResponseDto { Code = StatusCodes.Status400BadRequest, Message = "Penalty type name already exists." },
                        SuccessResponse = null
                    };
                }

                penaltyType.Update(values.Name, values.Code, values.Description, values.IsActive);
                penaltyType.ModifiedBy = values.ModifiedBy;
                penaltyType.ModifiedOn = DateTime.Now;

                _unitOfWork.PenaltyTypes.Update(penaltyType);
                await _unitOfWork.Complete();

                return new ReturnResponsesDto
                {
                    IsSuccess = true,
                    ErrorResponse = null,
                    SuccessResponse = new SuccessResponseDto { Code = StatusCodes.Status200OK, Message = "Penalty type updated successfully." }
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

        public async Task<ReturnResponsesDto> DeletePenaltyTypeAsync(int penaltyTypeId)
        {
            try
            {
                var penaltyType = await _unitOfWork.PenaltyTypes.Get(pt => pt.PenaltyTypeId == penaltyTypeId);
                if (penaltyType == null)
                {
                    return new ReturnResponsesDto
                    {
                        IsSuccess = false,
                        ErrorResponse = new ErrorResponseDto { Code = StatusCodes.Status404NotFound, Message = "Penalty type not found." },
                        SuccessResponse = null
                    };
                }

                // Check if penalty type has associated rules
                var hasRules = await _unitOfWork.PenaltyRules.Get(pr => pr.PenaltyTypeId == penaltyTypeId);
                if (hasRules != null)
                {
                    return new ReturnResponsesDto
                    {
                        IsSuccess = false,
                        ErrorResponse = new ErrorResponseDto { Code = StatusCodes.Status400BadRequest, Message = "Cannot delete penalty type with associated rules." },
                        SuccessResponse = null
                    };
                }

                _unitOfWork.PenaltyTypes.Delete(penaltyType);
                await _unitOfWork.Complete();

                return new ReturnResponsesDto
                {
                    IsSuccess = true,
                    ErrorResponse = null,
                    SuccessResponse = new SuccessResponseDto { Code = StatusCodes.Status200OK, Message = "Penalty type deleted successfully." }
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

        public async Task<ReturnResponsesDto> TogglePenaltyTypeStatusAsync(int penaltyTypeId, string modifiedBy)
        {
            try
            {
                var penaltyType = await _unitOfWork.PenaltyTypes.Get(pt => pt.PenaltyTypeId == penaltyTypeId);
                if (penaltyType == null)
                {
                    return new ReturnResponsesDto
                    {
                        IsSuccess = false,
                        ErrorResponse = new ErrorResponseDto { Code = StatusCodes.Status404NotFound, Message = "Penalty type not found." },
                        SuccessResponse = null
                    };
                }

                if (penaltyType.IsActive)
                {
                    penaltyType.Deactivate();
                }
                else
                {
                    penaltyType.Activate();
                }

                penaltyType.ModifiedBy = modifiedBy;
                penaltyType.ModifiedOn = DateTime.Now;

                _unitOfWork.PenaltyTypes.Update(penaltyType);
                await _unitOfWork.Complete();

                var status = penaltyType.IsActive ? "activated" : "deactivated";
                return new ReturnResponsesDto
                {
                    IsSuccess = true,
                    ErrorResponse = null,
                    SuccessResponse = new SuccessResponseDto { Code = StatusCodes.Status200OK, Message = $"Penalty type {status} successfully." }
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


        public async Task<IEnumerable<PenaltyTypeWithRulesReadDto>> GetPenaltyTypesWithRulesAsync()
        {
            var penaltyTypes = await _unitOfWork.PenaltyTypes.GetAll(includes: new List<string> { "PenaltyRules" });

            var result = new List<PenaltyTypeWithRulesReadDto>();

            foreach (var penaltyType in penaltyTypes)
            {
                var penaltyRules = penaltyType.PenaltyRules.Select(pr => new PenaltyRuleReadDto(
                    pr.PenaltyRuleId,
                    pr.PenaltyTypeId,
                    penaltyType.Name,
                    pr.CalculationMethod,
                    pr.Rate,
                    pr.GracePeriodDays,
                    pr.CapAmount,
                    pr.EffectiveDate,
                    pr.ExpiryDate,
                    pr.IsActive(),
                    GetCalculationMethodDescription(pr.CalculationMethod, pr.Rate)
                )).ToList();

                result.Add(new PenaltyTypeWithRulesReadDto(
                    penaltyType.PenaltyTypeId,
                    penaltyType.Name,
                    penaltyType.Code,
                    penaltyType.Description,
                    penaltyType.IsActive,
                    penaltyRules
                ));
            }

            return result;
        }

        public async Task<PenaltyTypeWithRulesReadDto> GetPenaltyTypeWithRulesAsync(int penaltyTypeId)
        {
            var penaltyType = await _unitOfWork.PenaltyTypes.Get(pt => pt.PenaltyTypeId == penaltyTypeId, includes: new List<string> { "PenaltyRules" });

            if (penaltyType == null) return null;

            var penaltyRules = penaltyType.PenaltyRules.Select(pr => new PenaltyRuleReadDto(
                pr.PenaltyRuleId,
                pr.PenaltyTypeId,
                penaltyType.Name,
                pr.CalculationMethod,
                pr.Rate,
                pr.GracePeriodDays,
                pr.CapAmount,
                pr.EffectiveDate,
                pr.ExpiryDate,
                pr.IsActive(),
                GetCalculationMethodDescription(pr.CalculationMethod, pr.Rate)
            )).ToList();

            return new PenaltyTypeWithRulesReadDto(
                penaltyType.PenaltyTypeId,
                penaltyType.Name,
                penaltyType.Code,
                penaltyType.Description,
                penaltyType.IsActive,
                penaltyRules
            );
        }

        private static string GetCalculationMethodDescription(PenaltyCalculationMethod method, decimal rate)
        {
            return method switch
            {
                PenaltyCalculationMethod.Percentage => $"{rate}% of principal amount",
                PenaltyCalculationMethod.FlatRate => $"{rate:C} flat fee",
                PenaltyCalculationMethod.DailyRate => $"{rate:C} per day",
                PenaltyCalculationMethod.MonthlyRate => $"{rate:C} per month",
                PenaltyCalculationMethod.YearlyRate => $"{rate:C} per year",
                _ => "Unknown calculation method"
            };
        }





    }
}
