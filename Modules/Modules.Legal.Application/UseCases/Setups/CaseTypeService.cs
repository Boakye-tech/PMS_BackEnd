// /**************************************************
// * Company: MindSprings Company Limited
// * Project Name: Modules.Legal.Application
// * Full FileName: /Users/imac5k/Projects/PropertyManagementSolution/pms-api/Modules/Modules.Legal.Application/UseCases/Setups/CaseTypeService.cs
// * Author: Boakye Ofori-Atta
// * Email Address: boakye.ofori-atta@mindsprings-gh.com
// * Copyright: © 2024 MindSprings Company Limited
// * Create Date: 15/09/2025 2:42 PM
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
	public class CaseTypeService : ICaseTypeService
    {
        private readonly IUnitOfWork _unitOfWork;

        public CaseTypeService(IUnitOfWork unitOfWork)
		{
            _unitOfWork = unitOfWork;
		}

        public async Task<ReturnResponsesDto> CreateCaseTypeAsync(CaseTypeCreateDto values)
        {
            try
            {
                var existingSite = await _unitOfWork.CaseType.Get(ct => ct.CaseTypes == values.caseType);
                if (existingSite != null)
                {
                    return new ReturnResponsesDto
                    {
                        IsSuccess = false,
                        ErrorResponse = new ErrorResponseDto { Code = StatusCodes.Status400BadRequest, Message = "Case type already exists." },
                    };
                }

                var caseTypes = new CaseType(0, values.caseType);
                caseTypes.CreatedBy = values.createdBy;
                caseTypes.DateCreated = DateTime.Now;

                _unitOfWork.CaseType.Insert(caseTypes);
                await _unitOfWork.Complete();

                return new ReturnResponsesDto
                {
                    IsSuccess = true,
                    SuccessResponse = new SuccessResponseDto { Code = StatusCodes.Status201Created, Message = "Case Type created successfully." },
                };
            }
            catch (Exception ex)
            {
                return new ReturnResponsesDto { IsSuccess = false, ErrorResponse = new ErrorResponseDto { Code = StatusCodes.Status500InternalServerError, Message = ex.InnerException!.Message ?? ex.Message }, SuccessResponse = null };
            }

        }

        public async Task<ReturnResponsesDto> DeleteCaseType(int caseTypeId)
        {
            try
            {
                var casetype = await _unitOfWork.CaseType.Get(caseTypeId);
                if (casetype == null)
                {
                    return new ReturnResponsesDto
                    {
                        IsSuccess = false,
                        ErrorResponse = new ErrorResponseDto { Code = StatusCodes.Status404NotFound, Message = $"Site with ID {caseTypeId} not found." },
                    };
                }

                _unitOfWork.CaseType.Delete(casetype); 
                await _unitOfWork.Complete();

                return new ReturnResponsesDto
                {
                    IsSuccess = true,
                    SuccessResponse = new SuccessResponseDto { Code = StatusCodes.Status200OK, Message = $"Case Type with ID {caseTypeId} deleted successfully." }
                };
            }
            catch (Exception ex)
            {
                return new ReturnResponsesDto { IsSuccess = false, ErrorResponse = new ErrorResponseDto { Code = StatusCodes.Status500InternalServerError, Message = ex.InnerException!.Message ?? ex.Message }, SuccessResponse = null };
            }
        }

        public async Task<List<CaseTypeReadDto>> GetCaseTypeAsync()
        {
            var casetypes = await _unitOfWork.CaseType.GetAll();
            var caseTypeReadDto = casetypes.Select(caseType => new CaseTypeReadDto(caseType.CaseTypeId, caseType.CaseTypes)).ToList();
            return caseTypeReadDto;
        }

        public async Task<CaseTypeReadDto> GetCaseTypeAsync(int caseTypeId)
        {
            var casetype = await _unitOfWork.CaseType.Get(caseTypeId);
            var caseTypeReadDto = new CaseTypeReadDto(casetype!.CaseTypeId, casetype.CaseTypes);

            return caseTypeReadDto;

        }

        public async Task<ReturnResponsesDto> UpdateCaseTypeAsync(CaseTypeUpdateDto values)
        {
            var casetype = await _unitOfWork.CaseType.Get(values.caseTypeId);
            if (casetype == null)
            {
                return new ReturnResponsesDto
                {
                    IsSuccess = false,
                    ErrorResponse = new ErrorResponseDto { Code = StatusCodes.Status404NotFound, Message = $"Case Type with ID {values.caseTypeId} not found." },
                };
            }

            if(!string.Equals(values.caseType, casetype.CaseTypes, StringComparison.OrdinalIgnoreCase))
            {
                var existingType = await _unitOfWork.CaseType.Get(ct => ct.CaseTypes == values.caseType);
                if (existingType != null)
                {
                    return new ReturnResponsesDto
                    {
                        IsSuccess = false,
                        ErrorResponse = new ErrorResponseDto { Code = StatusCodes.Status400BadRequest, Message = "Case Type already exists." },
                    };
                }
            }

            casetype.UpdateCaseType( values.caseTypeId, values.caseType!);
            casetype.ModifiedBy = values.modifiedBy;
            casetype.DateModified = DateTime.Now;

            _unitOfWork.CaseType.Update(casetype);
            await _unitOfWork.Complete();

            return new ReturnResponsesDto
            {
                IsSuccess = true,
                ErrorResponse = null,
                SuccessResponse = new SuccessResponseDto { Code = StatusCodes.Status200OK, Message = "Case Type modified successfully." },
            };



        }





    }
}

