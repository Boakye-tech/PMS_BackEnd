// /**************************************************
// * Company: MindSprings Company Limited
// * Project Name: Modules.Estates.Application
// * Full FileName: /Users/imac5k/Projects/PropertyManagementSolution/pms-api/Modules/Modules.Estates.Application/UseCases/Setup/Property/SchemeTypeService.cs
// * Author: Boakye Ofori-Atta
// * Email Address: boakye.ofori-atta@mindsprings-gh.com
// * Copyright: © 2024 MindSprings Company Limited
// * Create Date: 15/06/2025 12:25 PM
// * Version: 1.0.1
// * Description: Property Management System
//  **************************************************/

using Microsoft.AspNetCore.Http;

namespace Modules.Estates.Application.UseCases.Setup.Property
{
    public class SchemeTypeService : ISchemeTypeService
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;

        public SchemeTypeService(IUnitOfWork unitOfWork, IMapper mapper)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
        }

        public async Task<IEnumerable<SchemeTypeReadDto>> GetSchemeTypeAsync()
        {
            var schemeType = await _unitOfWork.SchemeTypes.GetAll();
            return _mapper.Map<IEnumerable<SchemeTypeReadDto>>(schemeType);
        }

        public async Task<ReturnResponsesDto> CreateSchemeTypeAsync(SchemeTypeCreateDto values)
        {
            try
            {
                var existingType = await _unitOfWork.SchemeTypes.Get(p => p.SchemeTypeName == values.SchemeTypeName);
                if (existingType != null)
                {
                    return new ReturnResponsesDto
                    {
                        IsSuccess = false,
                        ErrorResponse = new ErrorResponseDto { Code = StatusCodes.Status400BadRequest, Message = "Scheme Type already exists." },
                        SuccessResponse = null
                    };
                }

                var schemeType = SchemeType.Create(0, values.SchemeTypeName!);
                schemeType.CreatedBy = values.CreatedBy;
                schemeType.CreatedOn = DateTime.Now;

                _unitOfWork.SchemeTypes.Insert(schemeType);
                await _unitOfWork.Complete();

                return new ReturnResponsesDto
                {
                    IsSuccess = true,
                    ErrorResponse = null,
                    SuccessResponse = new SuccessResponseDto { Code = StatusCodes.Status201Created, Message = "Scheme Type created successfully." },
                };
            }
            catch (Exception ex)
            {
                return new ReturnResponsesDto { IsSuccess = false, ErrorResponse = new ErrorResponseDto { Code = StatusCodes.Status500InternalServerError, Message = ex.InnerException?.Message ?? ex.Message }, SuccessResponse = null };
            }
        }

        public async Task<ReturnResponsesDto> UpdateSchemeTypeAsync(SchemeTypeUpdateDto values)
        {
            try
            {
                var schemeType = await _unitOfWork.SchemeTypes.Get(values.SchemeTypeId);
                if (schemeType == null)
                {
                    return new ReturnResponsesDto
                    {
                        IsSuccess = false,
                        ErrorResponse = new ErrorResponseDto { Code = StatusCodes.Status404NotFound, Message = $"Scheme Type with ID {values.SchemeTypeId} not found." },
                        SuccessResponse = null
                    };
                }

                schemeType.Update(values.SchemeTypeId, values.SchemeTypeName!);
                schemeType.ModifiedBy = values.ModifiedBy;
                schemeType.ModifiedOn = DateTime.Now;

                _unitOfWork.SchemeTypes.Update(schemeType);
                await _unitOfWork.Complete();

                return new ReturnResponsesDto
                {
                    IsSuccess = true,
                    ErrorResponse = null,
                    SuccessResponse = new SuccessResponseDto { Code = StatusCodes.Status200OK, Message = "Scheme Type modified successfully." },
                };
            }
            catch (Exception ex)
            {
                return new ReturnResponsesDto { IsSuccess = false, ErrorResponse = new ErrorResponseDto { Code = StatusCodes.Status500InternalServerError, Message = ex.InnerException?.Message ?? ex.Message }, SuccessResponse = null };
            }
        }

        public async Task<ReturnResponsesDto> DeleteSchemeType(int schemeTypeId)
        {
            try
            {
                var schemeType = await _unitOfWork.SchemeTypes.Get(schemeTypeId);
                if (schemeType == null)
                {
                    return new ReturnResponsesDto
                    {
                        IsSuccess = false,
                        ErrorResponse = new ErrorResponseDto { Code = StatusCodes.Status404NotFound, Message = $"Scheme Type with ID {schemeTypeId} not found." },
                        SuccessResponse = null
                    };
                }

                _unitOfWork.SchemeTypes.Delete(schemeType);
                await _unitOfWork.Complete();

                return new ReturnResponsesDto
                {
                    IsSuccess = true,
                    ErrorResponse = null,
                    SuccessResponse = new SuccessResponseDto { Code = StatusCodes.Status200OK, Message = $"Scheme Type with ID {schemeTypeId} deleted successfully." }
                };
            }
            catch (Exception ex)
            {
                return new ReturnResponsesDto { IsSuccess = false, ErrorResponse = new ErrorResponseDto { Code = StatusCodes.Status500InternalServerError, Message = ex.InnerException?.Message ?? ex.Message }, SuccessResponse = null };
            }
        }
    }
}

