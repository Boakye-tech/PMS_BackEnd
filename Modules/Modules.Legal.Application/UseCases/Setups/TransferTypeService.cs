// /**************************************************
// * Company: MindSprings Company Limited
// * Project Name: Modules.Legal.Application
// * Full FileName: /Users/imac5k/Projects/PropertyManagementSolution/pms-api/Modules/Modules.Legal.Application/UseCases/Setups/TransferTypeService.cs
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
    public class TransferTypeService : ITransferTypeService
    {
        private readonly IUnitOfWork _unitOfWork;

        public TransferTypeService(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public async Task<ReturnResponsesDto> CreateTransferTypeAsync(TransferTypeCreateDto values)
        {
            try
            {
                var existing = await _unitOfWork.TransferTypes.Get(x => x.TransferType == values.transferType);
                if (existing != null)
                {
                    return new ReturnResponsesDto
                    {
                        IsSuccess = false,
                        ErrorResponse = new ErrorResponseDto { Code = StatusCodes.Status400BadRequest, Message = "Transfer type already exists." },
                    };
                }

                var entity = new TransferTypes(values.transferType);
                entity.CreatedBy = values.createdBy;
                entity.DateCreated = DateTime.Now;

                _unitOfWork.TransferTypes.Insert(entity);
                await _unitOfWork.Complete();

                return new ReturnResponsesDto
                {
                    IsSuccess = true,
                    SuccessResponse = new SuccessResponseDto { Code = StatusCodes.Status201Created, Message = "Transfer Type created successfully." },
                };
            }
            catch (Exception ex)
            {
                return new ReturnResponsesDto { IsSuccess = false, ErrorResponse = new ErrorResponseDto { Code = StatusCodes.Status500InternalServerError, Message = ex.InnerException!.Message ?? ex.Message }, SuccessResponse = null };
            }
        }

        public async Task<ReturnResponsesDto> UpdateTransferTypeAsync(TransferTypeUpdateDto values)
        {
            var entity = await _unitOfWork.TransferTypes.Get(values.transferTypeId);
            if (entity == null)
            {
                return new ReturnResponsesDto
                {
                    IsSuccess = false,
                    ErrorResponse = new ErrorResponseDto { Code = StatusCodes.Status404NotFound, Message = $"Transfer Type with ID {values.transferTypeId} not found." },
                };
            }

            if (!string.Equals(values.transferType, entity.TransferType, StringComparison.OrdinalIgnoreCase))
            {
                var existing = await _unitOfWork.TransferTypes.Get(x => x.TransferType == values.transferType);
                if (existing != null)
                {
                    return new ReturnResponsesDto
                    {
                        IsSuccess = false,
                        ErrorResponse = new ErrorResponseDto { Code = StatusCodes.Status400BadRequest, Message = "Transfer Type already exists." },
                    };
                }
            }

            entity.UpdateTransferType(values.transferTypeId, values.transferType);
            entity.ModifiedBy = values.modifiedBy;
            entity.DateModified = DateTime.Now;

            _unitOfWork.TransferTypes.Update(entity);
            await _unitOfWork.Complete();

            return new ReturnResponsesDto
            {
                IsSuccess = true,
                ErrorResponse = null,
                SuccessResponse = new SuccessResponseDto { Code = StatusCodes.Status200OK, Message = "Transfer Type modified successfully." },
            };
        }

        public async Task<ReturnResponsesDto> DeleteTransferType(int transferTypeId)
        {
            try
            {
                var entity = await _unitOfWork.TransferTypes.Get(transferTypeId);
                if (entity == null)
                {
                    return new ReturnResponsesDto
                    {
                        IsSuccess = false,
                        ErrorResponse = new ErrorResponseDto { Code = StatusCodes.Status404NotFound, Message = $"Transfer Type with ID {transferTypeId} not found." },
                    };
                }

                _unitOfWork.TransferTypes.Delete(entity);
                await _unitOfWork.Complete();

                return new ReturnResponsesDto
                {
                    IsSuccess = true,
                    SuccessResponse = new SuccessResponseDto { Code = StatusCodes.Status200OK, Message = $"Transfer Type with ID {transferTypeId} deleted successfully." }
                };
            }
            catch (Exception ex)
            {
                return new ReturnResponsesDto { IsSuccess = false, ErrorResponse = new ErrorResponseDto { Code = StatusCodes.Status500InternalServerError, Message = ex.InnerException!.Message ?? ex.Message }, SuccessResponse = null };
            }
        }

        public async Task<IEnumerable<TransferTypeRedDto>> GetTransferTypeAsync()
        {
            var entities = await _unitOfWork.TransferTypes.GetAll();
            return entities.Select(x => new TransferTypeRedDto(x.TransferTypesId, x.TransferType)).ToList();
        }

        public async Task<IEnumerable<TransferTypeRedDto>> GetTransferTypeAsync(int transferTypeId)
        {
            var entity = await _unitOfWork.TransferTypes.Get(transferTypeId);
            if (entity == null)
            {
                return new List<TransferTypeRedDto>();
            }
            return new List<TransferTypeRedDto> { new TransferTypeRedDto(entity.TransferTypesId, entity.TransferType) };
        }

    }
}



