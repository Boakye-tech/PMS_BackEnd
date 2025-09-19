// /**************************************************
// * Company: MindSprings Company Limited
// * Project Name: Modules.Legal.Application
// * Full FileName: /Users/imac5k/Projects/PropertyManagementSolution/pms-api/Modules/Modules.Legal.Application/UseCases/Setups/ConsentTypeService.cs
// * Author: Boakye Ofori-Atta
// * Email Address: boakye.ofori-atta@mindsprings-gh.com
// * Copyright: © 2024 MindSprings Company Limited
// * Create Date: 15/09/2025 6:05 PM
// * Version: 1.0.1
// * Description: Property Management System
//  **************************************************/
using System;
using Modules.Legal.Application.Dtos;
using Modules.Legal.Application.Dtos.Setups;
using Modules.Legal.Application.Interfaces.Setups;
using Modules.Legal.Domain.Entities.Setups;
using Modules.Legal.Domain.Interfaces;
using Microsoft.AspNetCore.Http;

namespace Modules.Legal.Application.UseCases.Setups
{
    public class ConsentTypeService : IConsentTypeService
    {
        private readonly IUnitOfWork _unitOfWork;

        public ConsentTypeService(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public async Task<ReturnResponsesDto> CreateConsentTypeAsync(ConsentTypeCreateDto values)
        {
            try
            {
                var existing = await _unitOfWork.ConsentType.Get(x => x.ConsentTypes == values.consentType);
                if (existing != null)
                {
                    return new ReturnResponsesDto
                    {
                        IsSuccess = false,
                        ErrorResponse = new ErrorResponseDto { Code = StatusCodes.Status400BadRequest, Message = "Consent type already exists." },
                    };
                }

                var entity = new ConsentType(values.consentType);
                entity.CreatedBy = values.createdBy;
                entity.DateCreated = DateTime.Now;

                _unitOfWork.ConsentType.Insert(entity);
                await _unitOfWork.Complete();

                return new ReturnResponsesDto
                {
                    IsSuccess = true,
                    SuccessResponse = new SuccessResponseDto { Code = StatusCodes.Status201Created, Message = "Consent Type created successfully." },
                };
            }
            catch (Exception ex)
            {
                return new ReturnResponsesDto { IsSuccess = false, ErrorResponse = new ErrorResponseDto { Code = StatusCodes.Status500InternalServerError, Message = ex.InnerException!.Message ?? ex.Message }, SuccessResponse = null };
            }
        }

        public async Task<ReturnResponsesDto> UpdateConsentTypeAsync(ConsentTypeUpdateDto values)
        {
            var entity = await _unitOfWork.ConsentType.Get(values.consentTypeId);
            if (entity == null)
            {
                return new ReturnResponsesDto
                {
                    IsSuccess = false,
                    ErrorResponse = new ErrorResponseDto { Code = StatusCodes.Status404NotFound, Message = $"Consent Type with ID {values.consentTypeId} not found." },
                };
            }

            if (!string.Equals(values.consentType, entity.ConsentTypes, StringComparison.OrdinalIgnoreCase))
            {
                var existing = await _unitOfWork.ConsentType.Get(x => x.ConsentTypes == values.consentType);
                if (existing != null)
                {
                    return new ReturnResponsesDto
                    {
                        IsSuccess = false,
                        ErrorResponse = new ErrorResponseDto { Code = StatusCodes.Status400BadRequest, Message = "Consent Type already exists." },
                    };
                }
            }

            entity.UpdateConsentType(values.consentTypeId, values.consentType);
            entity.ModifiedBy = values.modifiedBy;
            entity.DateModified = DateTime.Now;

            _unitOfWork.ConsentType.Update(entity);
            await _unitOfWork.Complete();

            return new ReturnResponsesDto
            {
                IsSuccess = true,
                ErrorResponse = null,
                SuccessResponse = new SuccessResponseDto { Code = StatusCodes.Status200OK, Message = "Consent Type modified successfully." },
            };
        }

        public async Task<ReturnResponsesDto> DeleteConsentType(int consentTypeId)
        {
            try
            {
                var entity = await _unitOfWork.ConsentType.Get(consentTypeId);
                if (entity == null)
                {
                    return new ReturnResponsesDto
                    {
                        IsSuccess = false,
                        ErrorResponse = new ErrorResponseDto { Code = StatusCodes.Status404NotFound, Message = $"Consent Type with ID {consentTypeId} not found." },
                    };
                }

                _unitOfWork.ConsentType.Delete(entity);
                await _unitOfWork.Complete();

                return new ReturnResponsesDto
                {
                    IsSuccess = true,
                    SuccessResponse = new SuccessResponseDto { Code = StatusCodes.Status200OK, Message = $"Consent Type with ID {consentTypeId} deleted successfully." }
                };
            }
            catch (Exception ex)
            {
                return new ReturnResponsesDto { IsSuccess = false, ErrorResponse = new ErrorResponseDto { Code = StatusCodes.Status500InternalServerError, Message = ex.InnerException!.Message ?? ex.Message }, SuccessResponse = null };
            }
        }

        public async Task<IEnumerable<ConsentTypeRedDto>> GetConsentTypeAsync()
        {
            var entities = await _unitOfWork.ConsentType.GetAll();
            return entities.Select(x => new ConsentTypeRedDto(x.ConsentTypeId, x.ConsentTypes)).ToList();
        }

        public async Task<IEnumerable<ConsentTypeRedDto>> GetConsentTypeAsync(int consentTypeId)
        {
            var entity = await _unitOfWork.ConsentType.Get(consentTypeId);
            if (entity == null)
            {
                return new List<ConsentTypeRedDto>();
            }
            return new List<ConsentTypeRedDto> { new ConsentTypeRedDto(entity.ConsentTypeId, entity.ConsentTypes) };
        }

    }
}



