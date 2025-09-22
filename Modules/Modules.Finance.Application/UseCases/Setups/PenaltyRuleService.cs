// /**************************************************
// * Company: MindSprings Company Limited
// * Project Name: Modules.Finance.Application
// * Full FileName: /Users/imac5k/Projects/PropertyManagementSolution/pms-api/Modules/Modules.Finance.Application/UseCases/Setups/PenaltyRuleService.cs
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
using Modules.Finance.Domain.Entities.Setup;

namespace Modules.Finance.Application.UseCases.Setups
{
    public class PenaltyRuleService : IPenaltyRuleService
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;

        public PenaltyRuleService(IUnitOfWork unitOfWork, IMapper mapper)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
        }

        public async Task<IEnumerable<PenaltyRuleReadDto>> GetPenaltyRulesAsync()
        {
            var penaltyRules = await _unitOfWork.PenaltyRules.GetAll(includes: new List<string> { "PenaltyType" });
            return penaltyRules.Select(pr => new PenaltyRuleReadDto(
                pr.PenaltyRuleId, pr.PenaltyTypeId, pr.PenaltyType.Name, pr.CalculationMethod,
                pr.Rate, pr.GracePeriodDays, pr.CapAmount, pr.EffectiveDate, pr.ExpiryDate, pr.IsActive(),
                GetCalculationMethodDescription(pr.CalculationMethod, pr.Rate)
            ));
        }

        public async Task<PenaltyRuleReadDto> GetPenaltyRuleAsync(int penaltyRuleId)
        {
            var penaltyRule = await _unitOfWork.PenaltyRules.Get(
                pr => pr.PenaltyRuleId == penaltyRuleId,
                includes: new List<string> { "PenaltyType" });

            if (penaltyRule == null) return null!;

            return new PenaltyRuleReadDto(
                penaltyRule.PenaltyRuleId, penaltyRule.PenaltyTypeId, penaltyRule.PenaltyType.Name,
                penaltyRule.CalculationMethod, penaltyRule.Rate, penaltyRule.GracePeriodDays,
                penaltyRule.CapAmount, penaltyRule.EffectiveDate, penaltyRule.ExpiryDate, penaltyRule.IsActive(),
                GetCalculationMethodDescription(penaltyRule.CalculationMethod, penaltyRule.Rate)
            );
        }

        public async Task<IEnumerable<PenaltyRuleReadDto>> GetActivePenaltyRulesAsync()
        {
            var penaltyRules = await _unitOfWork.PenaltyRules.GetAll(includes: new List<string> { "PenaltyType" });
            var activeRules = penaltyRules.Where(pr => pr.IsActive());

            return activeRules.Select(pr => new PenaltyRuleReadDto(
                pr.PenaltyRuleId, pr.PenaltyTypeId, pr.PenaltyType.Name, pr.CalculationMethod,
                pr.Rate, pr.GracePeriodDays, pr.CapAmount, pr.EffectiveDate, pr.ExpiryDate, true,
                GetCalculationMethodDescription(pr.CalculationMethod, pr.Rate)
            ));
        }

        public async Task<IEnumerable<PenaltyRuleReadDto>> GetPenaltyRulesByTypeAsync(int penaltyTypeId)
        {
            var penaltyRules = await _unitOfWork.PenaltyRules.GetAll(
                pr => pr.PenaltyTypeId == penaltyTypeId,
                includes: new List<string> { "PenaltyType" });

            return penaltyRules.Select(pr => new PenaltyRuleReadDto(
                pr.PenaltyRuleId, pr.PenaltyTypeId, pr.PenaltyType.Name, pr.CalculationMethod,
                pr.Rate, pr.GracePeriodDays, pr.CapAmount, pr.EffectiveDate, pr.ExpiryDate, pr.IsActive(),
                GetCalculationMethodDescription(pr.CalculationMethod, pr.Rate)
            ));
        }

        public async Task<PenaltyRuleReadDto> GetCurrentPenaltyRuleAsync(int penaltyTypeId)
        {
            var now = DateTime.Now;
            var penaltyRule = await _unitOfWork.PenaltyRules.Get(
                pr => pr.PenaltyTypeId == penaltyTypeId &&
                      pr.EffectiveDate <= now &&
                      (pr.ExpiryDate == null || now <= pr.ExpiryDate),
                includes: new List<string> { "PenaltyType" });

            if (penaltyRule == null) return null!;

            return new PenaltyRuleReadDto(
                penaltyRule.PenaltyRuleId, penaltyRule.PenaltyTypeId, penaltyRule.PenaltyType.Name,
                penaltyRule.CalculationMethod, penaltyRule.Rate, penaltyRule.GracePeriodDays,
                penaltyRule.CapAmount, penaltyRule.EffectiveDate, penaltyRule.ExpiryDate, true,
                GetCalculationMethodDescription(penaltyRule.CalculationMethod, penaltyRule.Rate)
            );
        }

        public async Task<ReturnResponsesDto> CreatePenaltyRuleAsync(PenaltyRuleCreateDto values)
        {
            try
            {
                // Validate penalty type exists
                var penaltyType = await _unitOfWork.PenaltyTypes.Get(pt => pt.PenaltyTypeId == values.PenaltyTypeId);
                if (penaltyType == null)
                {
                    return new ReturnResponsesDto
                    {
                        IsSuccess = false,
                        ErrorResponse = new ErrorResponseDto { Code = StatusCodes.Status400BadRequest, Message = "Penalty type does not exist." },
                        SuccessResponse = null
                    };
                }

                // Check for overlapping effective dates
                var overlappingRule = await _unitOfWork.PenaltyRules.Get(
                    pr => pr.PenaltyTypeId == values.PenaltyTypeId &&
                          pr.EffectiveDate <= values.ExpiryDate &&
                          (pr.ExpiryDate == null || pr.ExpiryDate >= values.EffectiveDate));

                if (overlappingRule != null)
                {
                    return new ReturnResponsesDto
                    {
                        IsSuccess = false,
                        ErrorResponse = new ErrorResponseDto { Code = StatusCodes.Status400BadRequest, Message = "Penalty rule dates overlap with existing rule." },
                        SuccessResponse = null
                    };
                }

                var penaltyRule = PenaltyRule.Create(values.PenaltyTypeId, values.CalculationMethod, values.Rate,values.GracePeriodDays, values.CapAmount, values.EffectiveDate, values.ExpiryDate);
                penaltyRule.CreatedBy = values.CreatedBy;
                penaltyRule.CreatedOn = DateTime.Now;

                _unitOfWork.PenaltyRules.Insert(penaltyRule);
                await _unitOfWork.Complete();

                return new ReturnResponsesDto
                {
                    IsSuccess = true,
                    ErrorResponse = null,
                    SuccessResponse = new SuccessResponseDto { Code = StatusCodes.Status201Created, Message = "Penalty rule created successfully." }
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

        public async Task<ReturnResponsesDto> UpdatePenaltyRuleAsync(PenaltyRuleUpdateDto values)
        {
            try
            {
                var penaltyRule = await _unitOfWork.PenaltyRules.Get(pr => pr.PenaltyRuleId == values.PenaltyRuleId);
                if (penaltyRule == null)
                {
                    return new ReturnResponsesDto
                    {
                        IsSuccess = false,
                        ErrorResponse = new ErrorResponseDto { Code = StatusCodes.Status404NotFound, Message = "Penalty rule not found." },
                        SuccessResponse = null
                    };
                }

                // Check for overlapping effective dates (excluding current rule)
                var overlappingRule = await _unitOfWork.PenaltyRules.Get(
                    pr => pr.PenaltyTypeId == penaltyRule.PenaltyTypeId &&
                          pr.PenaltyRuleId != values.PenaltyRuleId &&
                          pr.EffectiveDate <= values.ExpiryDate &&
                          (pr.ExpiryDate == null || pr.ExpiryDate >= values.EffectiveDate));

                if (overlappingRule != null)
                {
                    return new ReturnResponsesDto
                    {
                        IsSuccess = false,
                        ErrorResponse = new ErrorResponseDto { Code = StatusCodes.Status400BadRequest, Message = "Penalty rule dates overlap with existing rule." },
                        SuccessResponse = null
                    };
                }

                penaltyRule.Update(values.CalculationMethod, values.Rate, values.GracePeriodDays,
                                 values.CapAmount, values.EffectiveDate, values.ExpiryDate);
                penaltyRule.ModifiedBy = values.ModifiedBy;
                penaltyRule.ModifiedOn = DateTime.Now;

                _unitOfWork.PenaltyRules.Update(penaltyRule);
                await _unitOfWork.Complete();

                return new ReturnResponsesDto
                {
                    IsSuccess = true,
                    ErrorResponse = null,
                    SuccessResponse = new SuccessResponseDto { Code = StatusCodes.Status200OK, Message = "Penalty rule updated successfully." }
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

        public async Task<ReturnResponsesDto> DeletePenaltyRuleAsync(int penaltyRuleId)
        {
            try
            {
                var penaltyRule = await _unitOfWork.PenaltyRules.Get(pr => pr.PenaltyRuleId == penaltyRuleId);
                if (penaltyRule == null)
                {
                    return new ReturnResponsesDto
                    {
                        IsSuccess = false,
                        ErrorResponse = new ErrorResponseDto { Code = StatusCodes.Status404NotFound, Message = "Penalty rule not found." },
                        SuccessResponse = null
                    };
                }

                _unitOfWork.PenaltyRules.Delete(penaltyRule);
                await _unitOfWork.Complete();

                return new ReturnResponsesDto
                {
                    IsSuccess = true,
                    ErrorResponse = null,
                    SuccessResponse = new SuccessResponseDto { Code = StatusCodes.Status200OK, Message = "Penalty rule deleted successfully." }
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

        public async Task<decimal> CalculatePenaltyAsync(int penaltyRuleId, decimal principalAmount, int daysLate)
        {
            var penaltyRule = await _unitOfWork.PenaltyRules.Get(pr => pr.PenaltyRuleId == penaltyRuleId);
            if (penaltyRule == null)
                throw new ArgumentException("Penalty rule not found.");

            if (!penaltyRule.IsActive())
                throw new InvalidOperationException("Penalty rule is not active.");

            return penaltyRule.CalculatePenalty(principalAmount, daysLate);
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

