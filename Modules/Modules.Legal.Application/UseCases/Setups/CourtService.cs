// /**************************************************
// * Company: MindSprings Company Limited
// * Project Name: Modules.Legal.Application
// * Full FileName: /Users/imac5k/Projects/PropertyManagementSolution/pms-api/Modules/Modules.Legal.Application/UseCases/Setups/CourtService.cs
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
    public class CourtService : ICourtService
    {
        private readonly IUnitOfWork _unitOfWork;

        public CourtService(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public async Task<ReturnResponsesDto> CreateCourtAsync(CourtCreateDto values)
        {
            try
            {
                var existing = await _unitOfWork.Courts.Get(x => x.CourtType == values.courtType);
                if (existing != null)
                {
                    return new ReturnResponsesDto
                    {
                        IsSuccess = false,
                        ErrorResponse = new ErrorResponseDto { Code = StatusCodes.Status400BadRequest, Message = "Court already exists." },
                    };
                }

                var entity = new Courts(values.courtType);
                entity.CreatedBy = values.createdBy;
                entity.DateCreated = DateTime.Now;

                _unitOfWork.Courts.Insert(entity);
                await _unitOfWork.Complete();

                return new ReturnResponsesDto
                {
                    IsSuccess = true,
                    SuccessResponse = new SuccessResponseDto { Code = StatusCodes.Status201Created, Message = "Court created successfully." },
                };
            }
            catch (Exception ex)
            {
                return new ReturnResponsesDto { IsSuccess = false, ErrorResponse = new ErrorResponseDto { Code = StatusCodes.Status500InternalServerError, Message = ex.InnerException!.Message ?? ex.Message }, SuccessResponse = null };
            }
        }

        public async Task<ReturnResponsesDto> UpdateCourtAsync(CourtUpdateDto values)
        {
            var entity = await _unitOfWork.Courts.Get(values.courtId);
            if (entity == null)
            {
                return new ReturnResponsesDto
                {
                    IsSuccess = false,
                    ErrorResponse = new ErrorResponseDto { Code = StatusCodes.Status404NotFound, Message = $"Court with ID {values.courtId} not found." },
                };
            }

            if (!string.Equals(values.courtType, entity.CourtType, StringComparison.OrdinalIgnoreCase))
            {
                var existing = await _unitOfWork.Courts.Get(x => x.CourtType == values.courtType);
                if (existing != null)
                {
                    return new ReturnResponsesDto
                    {
                        IsSuccess = false,
                        ErrorResponse = new ErrorResponseDto { Code = StatusCodes.Status400BadRequest, Message = "Court already exists." },
                    };
                }
            }

            entity.UpdateCourtType(values.courtId, values.courtType);
            entity.ModifiedBy = values.modifiedBy;
            entity.DateModified = DateTime.Now;

            _unitOfWork.Courts.Update(entity);
            await _unitOfWork.Complete();

            return new ReturnResponsesDto
            {
                IsSuccess = true,
                ErrorResponse = null,
                SuccessResponse = new SuccessResponseDto { Code = StatusCodes.Status200OK, Message = "Court modified successfully." },
            };
        }

        public async Task<ReturnResponsesDto> DeleteCourt(int courtId)
        {
            try
            {
                var entity = await _unitOfWork.Courts.Get(courtId);
                if (entity == null)
                {
                    return new ReturnResponsesDto
                    {
                        IsSuccess = false,
                        ErrorResponse = new ErrorResponseDto { Code = StatusCodes.Status404NotFound, Message = $"Court with ID {courtId} not found." },
                    };
                }

                _unitOfWork.Courts.Delete(entity);
                await _unitOfWork.Complete();

                return new ReturnResponsesDto
                {
                    IsSuccess = true,
                    SuccessResponse = new SuccessResponseDto { Code = StatusCodes.Status200OK, Message = $"Court with ID {courtId} deleted successfully." }
                };
            }
            catch (Exception ex)
            {
                return new ReturnResponsesDto { IsSuccess = false, ErrorResponse = new ErrorResponseDto { Code = StatusCodes.Status500InternalServerError, Message = ex.InnerException!.Message ?? ex.Message }, SuccessResponse = null };
            }
        }

        public async Task<IEnumerable<CourtRedDto>> GetCourtAsync()
        {
            var entities = await _unitOfWork.Courts.GetAll();
            return entities.Select(x => new CourtRedDto(x.CourtsId, x.CourtType)).ToList();
        }

        public async Task<IEnumerable<CourtRedDto>> GetCourtAsync(int courtId)
        {
            var entity = await _unitOfWork.Courts.Get(courtId);
            if (entity == null)
            {
                return new List<CourtRedDto>();
            }
            return new List<CourtRedDto> { new CourtRedDto(entity.CourtsId, entity.CourtType) };
        }

    }
}



