// /**************************************************
// * Company: MindSprings Company Limited
// * Project Name: Modules.Legal.Application
// * Full FileName: /Users/imac5k/Projects/PropertyManagementSolution/pms-api/Modules/Modules.Legal.Application/UseCases/Setups/StatusTypeService.cs
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
    public class StatusTypeService : IStatusTypeService
    {
        private readonly IUnitOfWork _unitOfWork;

        public StatusTypeService(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public async Task<ReturnResponsesDto> CreateStatusTypeAsync(StatusTypeCreateDto values)
        {
            try
            {
                var existing = await _unitOfWork.StatusTypes.Get(x => x.StatusType == values.statusType);
                if (existing != null)
                {
                    return new ReturnResponsesDto
                    {
                        IsSuccess = false,
                        ErrorResponse = new ErrorResponseDto { Code = StatusCodes.Status400BadRequest, Message = "Status type already exists." },
                    };
                }

                var entity = new StatusTypes(values.statusType);
                entity.CreatedBy = values.createdBy;
                entity.DateCreated = DateTime.Now;

                _unitOfWork.StatusTypes.Insert(entity);
                await _unitOfWork.Complete();

                return new ReturnResponsesDto
                {
                    IsSuccess = true,
                    SuccessResponse = new SuccessResponseDto { Code = StatusCodes.Status201Created, Message = "Status Type created successfully." },
                };
            }
            catch (Exception ex)
            {
                return new ReturnResponsesDto { IsSuccess = false, ErrorResponse = new ErrorResponseDto { Code = StatusCodes.Status500InternalServerError, Message = ex.InnerException!.Message ?? ex.Message }, SuccessResponse = null };
            }
        }

        public async Task<ReturnResponsesDto> UpdateStatusTypeAsync(StatusTypeUpdateDto values)
        {
            var entity = await _unitOfWork.StatusTypes.Get(values.statusTypeId);
            if (entity == null)
            {
                return new ReturnResponsesDto
                {
                    IsSuccess = false,
                    ErrorResponse = new ErrorResponseDto { Code = StatusCodes.Status404NotFound, Message = $"Status Type with ID {values.statusTypeId} not found." },
                };
            }

            if (!string.Equals(values.statusType, entity.StatusType, StringComparison.OrdinalIgnoreCase))
            {
                var existing = await _unitOfWork.StatusTypes.Get(x => x.StatusType == values.statusType);
                if (existing != null)
                {
                    return new ReturnResponsesDto
                    {
                        IsSuccess = false,
                        ErrorResponse = new ErrorResponseDto { Code = StatusCodes.Status400BadRequest, Message = "Status Type already exists." },
                    };
                }
            }

            entity.UpdateStatusType(values.statusTypeId, values.statusType);
            entity.ModifiedBy = values.modifiedBy;
            entity.DateModified = DateTime.Now;

            _unitOfWork.StatusTypes.Update(entity);
            await _unitOfWork.Complete();

            return new ReturnResponsesDto
            {
                IsSuccess = true,
                ErrorResponse = null,
                SuccessResponse = new SuccessResponseDto { Code = StatusCodes.Status200OK, Message = "Status Type modified successfully." },
            };
        }

        public async Task<ReturnResponsesDto> DeleteStatusType(int statusTypeId)
        {
            try
            {
                var entity = await _unitOfWork.StatusTypes.Get(statusTypeId);
                if (entity == null)
                {
                    return new ReturnResponsesDto
                    {
                        IsSuccess = false,
                        ErrorResponse = new ErrorResponseDto { Code = StatusCodes.Status404NotFound, Message = $"Status Type with ID {statusTypeId} not found." },
                    };
                }

                _unitOfWork.StatusTypes.Delete(entity);
                await _unitOfWork.Complete();

                return new ReturnResponsesDto
                {
                    IsSuccess = true,
                    SuccessResponse = new SuccessResponseDto { Code = StatusCodes.Status200OK, Message = $"Status Type with ID {statusTypeId} deleted successfully." }
                };
            }
            catch (Exception ex)
            {
                return new ReturnResponsesDto { IsSuccess = false, ErrorResponse = new ErrorResponseDto { Code = StatusCodes.Status500InternalServerError, Message = ex.InnerException!.Message ?? ex.Message }, SuccessResponse = null };
            }
        }

        public async Task<IEnumerable<StatusTypeRedDto>> GetStatusTypeAsync()
        {
            var entities = await _unitOfWork.StatusTypes.GetAll();
            return entities.Select(x => new StatusTypeRedDto(x.StatusTypesId, x.StatusType)).ToList();
        }

        public async Task<IEnumerable<StatusTypeRedDto>> GetStatusTypeAsync(int statusTypeId)
        {
            var entity = await _unitOfWork.StatusTypes.Get(statusTypeId);
            if (entity == null)
            {
                return new List<StatusTypeRedDto>();
            }
            return new List<StatusTypeRedDto> { new StatusTypeRedDto(entity.StatusTypesId, entity.StatusType) };
        }

    }
}



