// /**************************************************
// * Company: MindSprings Company Limited
// * Project Name: Modules.Legal.Application
// * Full FileName: /Users/imac5k/Projects/PropertyManagementSolution/pms-api/Modules/Modules.Legal.Application/UseCases/Setups/CourtDivisionService.cs
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
    public class CourtDivisionService : ICourtDivisionService
    {
        private readonly IUnitOfWork _unitOfWork;

        public CourtDivisionService(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public async Task<ReturnResponsesDto> CreateCourtDivisionAsync(CourtDivisionCreateDto values)
        {
            try
            {
                var existing = await _unitOfWork.CourtDivisions.Get(x => x.CourtDivision == values.courtDivision && x.CourtsId == values.courtsId);
                if (existing != null)
                {
                    return new ReturnResponsesDto
                    {
                        IsSuccess = false,
                        ErrorResponse = new ErrorResponseDto { Code = StatusCodes.Status400BadRequest, Message = "Court Division already exists for selected Court." },
                    };
                }

                var entity = new CourtDivisions(values.courtDivision, values.courtsId);
                entity.CreatedBy = values.createdBy;
                entity.DateCreated = DateTime.Now;

                _unitOfWork.CourtDivisions.Insert(entity);
                await _unitOfWork.Complete();

                return new ReturnResponsesDto
                {
                    IsSuccess = true,
                    SuccessResponse = new SuccessResponseDto { Code = StatusCodes.Status201Created, Message = "Court Division created successfully." },
                };
            }
            catch (Exception ex)
            {
                return new ReturnResponsesDto { IsSuccess = false, ErrorResponse = new ErrorResponseDto { Code = StatusCodes.Status500InternalServerError, Message = ex.InnerException!.Message ?? ex.Message }, SuccessResponse = null };
            }
        }

        public async Task<ReturnResponsesDto> UpdateCourtDivisionAsync(CourtDivisionUpdateDto values)
        {
            var entity = await _unitOfWork.CourtDivisions.Get(values.courtDivisionId);
            if (entity == null)
            {
                return new ReturnResponsesDto
                {
                    IsSuccess = false,
                    ErrorResponse = new ErrorResponseDto { Code = StatusCodes.Status404NotFound, Message = $"Court Division with ID {values.courtDivisionId} not found." },
                };
            }

            if (!string.Equals(values.courtDivision, entity.CourtDivision, StringComparison.OrdinalIgnoreCase) || values.courtsId != entity.CourtsId)
            {
                var existing = await _unitOfWork.CourtDivisions.Get(x => x.CourtDivision == values.courtDivision && x.CourtsId == values.courtsId);
                if (existing != null)
                {
                    return new ReturnResponsesDto
                    {
                        IsSuccess = false,
                        ErrorResponse = new ErrorResponseDto { Code = StatusCodes.Status400BadRequest, Message = "Court Division already exists for selected Court." },
                    };
                }
            }

            entity.UpdateCourtDivision(values.courtDivisionId, values.courtDivision, values.courtsId);
            entity.ModifiedBy = values.modifiedBy;
            entity.DateModified = DateTime.Now;

            _unitOfWork.CourtDivisions.Update(entity);
            await _unitOfWork.Complete();

            return new ReturnResponsesDto
            {
                IsSuccess = true,
                ErrorResponse = null,
                SuccessResponse = new SuccessResponseDto { Code = StatusCodes.Status200OK, Message = "Court Division modified successfully." },
            };
        }

        public async Task<ReturnResponsesDto> DeleteCourtDivision(int courtDivisionId)
        {
            try
            {
                var entity = await _unitOfWork.CourtDivisions.Get(courtDivisionId);
                if (entity == null)
                {
                    return new ReturnResponsesDto
                    {
                        IsSuccess = false,
                        ErrorResponse = new ErrorResponseDto { Code = StatusCodes.Status404NotFound, Message = $"Court Division with ID {courtDivisionId} not found." },
                    };
                }

                _unitOfWork.CourtDivisions.Delete(entity);
                await _unitOfWork.Complete();

                return new ReturnResponsesDto
                {
                    IsSuccess = true,
                    SuccessResponse = new SuccessResponseDto { Code = StatusCodes.Status200OK, Message = $"Court Division with ID {courtDivisionId} deleted successfully." }
                };
            }
            catch (Exception ex)
            {
                return new ReturnResponsesDto { IsSuccess = false, ErrorResponse = new ErrorResponseDto { Code = StatusCodes.Status500InternalServerError, Message = ex.InnerException!.Message ?? ex.Message }, SuccessResponse = null };
            }
        }

        public async Task<IEnumerable<CourtDivisionRedDto>> GetCourtDivisionAsync()
        {
            var entities = await _unitOfWork.CourtDivisions.GetAll();
            return entities.Select(x => new CourtDivisionRedDto(x.CourtDivisionsId, x.CourtDivision, x.CourtsId)).ToList();
        }

        public async Task<IEnumerable<CourtDivisionRedDto>> GetCourtDivisionAsync(int courtDivisionId)
        {
            var entity = await _unitOfWork.CourtDivisions.Get(courtDivisionId);
            if (entity == null)
            {
                return new List<CourtDivisionRedDto>();
            }
            return new List<CourtDivisionRedDto> { new CourtDivisionRedDto(entity.CourtDivisionsId, entity.CourtDivision, entity.CourtsId) };
        }

    }
}



