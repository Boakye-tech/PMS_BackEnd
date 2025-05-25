// /**************************************************
// * Company: MindSprings Company Limited
// * Project Name: Modules.Estates.Application
// * Full FileName: /Users/imac5k/Projects/PropertyManagementSolution/pms-api/Modules/Modules.Estates.Application/UseCases/Setup/Property/LandUseTypeService.cs
// * Author: Boakye Ofori-Atta
// * Email Address: boakye.ofori-atta@mindsprings-gh.com
// * Copyright: © 2024 MindSprings Company Limited
// * Create Date: 01/01/2025 
// * Version: 1.0.1
// * Description: Property Management System
//  **************************************************/

using Microsoft.AspNetCore.Http;

namespace Modules.Estates.Application.UseCases.Setup.Property;

public class LandUseTypeService : ILandUseTypeService
{
    private readonly IUnitOfWork _unitOfWork;
    private readonly IMapper _mapper;

    public LandUseTypeService(IUnitOfWork unitOfWork, IMapper mapper)
    {
        _unitOfWork = unitOfWork;
        _mapper = mapper;
    }

    //public async Task<List<LandUseAndLandUseTypeReadDto>> GetLandUseTypeAsync()
    //{
    //    // Get all land uses and land use types in a single query using Include
    //    var landuses = await _unitOfWork.LandUse.GetAll(includes: new List<string> { "LandUseTypes" });

    //    // Create a dictionary for quick lookup of land use types by land use ID
    //    var landUseAndLandUseType = landuses.Select(landUse =>
    //    {
    //        var landUseTypes = _mapper.Map<List<LandUseTypeReadDto>>(landUse.LandUseTypes);
    //        return new LandUseAndLandUseTypeReadDto(
    //            landUse.LandUseId,
    //            landUse.LandUseInitial!,
    //            landUse.LandUseName!,
    //            landUseTypes
    //        );
    //    }).ToList();

    //    return landUseAndLandUseType;
    //}

    public async Task<IEnumerable<LandUseTypeReadDto>> GetLandUseTypeAsync()
    {
        var landuseType = await _unitOfWork.LandUseType.GetAll();
        return _mapper.Map<IEnumerable<LandUseTypeReadDto>>(landuseType);
    }

    public async Task<LandUseTypeReadDto> GetLandUseTypeAsync(int value)
    {
        var landuseType = await _unitOfWork.LandUseType.Get(value);
        return _mapper.Map<LandUseTypeReadDto>(landuseType);
    }

    public async Task<LandUseTypeReadDto> GetLandUseTypeAsync(string value)
    {
        var landuseType = await _unitOfWork.LandUseType.Get(lt => lt.LandUseTypeInitial == value || lt.LandUseTypeName == value);
        return _mapper.Map<LandUseTypeReadDto>(landuseType);
    }

    public async Task<ReturnResponsesDto> CreateLandUseTypeAsync(LandUseTypeCreateDto values)
    {
        try
        {
            int landUseTypeId = 0;

            var landUseTypeInitial = await _unitOfWork.LandUseType.Get(lt => lt.LandUseTypeInitial == values.LandUseTypeInitial);
            if (landUseTypeInitial != null)
            {
                return new ReturnResponsesDto
                {
                    IsSuccess = false,
                    ErrorResponse = new ErrorResponseDto { Code = StatusCodes.Status400BadRequest, Message = "Land Use Type Initial already exists." },
                    SuccessResponse = null
                };
            }

            var landUseType = await _unitOfWork.LandUseType.Get(lt => lt.LandUseTypeName == values.LandUseTypeName);
            if (landUseType != null)
            {
                return new ReturnResponsesDto
                {
                    IsSuccess = false,
                    ErrorResponse = new ErrorResponseDto { Code = StatusCodes.Status400BadRequest, Message = "Land Use Type Name already exists." },
                    SuccessResponse = null
                };
            }

            var newLandUseType = LandUseType.Create(values.LandUseId, landUseTypeId, values.LandUseTypeInitial!, values.LandUseTypeName!, values.LandUseTypeDescription);
            newLandUseType.CreatedBy = values.CreatedBy;
            newLandUseType.CreatedOn = DateTime.Now;

            _unitOfWork.LandUseType.Insert(newLandUseType);
            await _unitOfWork.Complete();

            return new ReturnResponsesDto
            {
                IsSuccess = true,
                ErrorResponse = null,
                SuccessResponse = new SuccessResponseDto { Code = StatusCodes.Status201Created, Message = "Land Use Type created successfully." },
            };
        }
        catch (Exception ex)
        {
            return new ReturnResponsesDto { IsSuccess = false, ErrorResponse = new ErrorResponseDto { Code = StatusCodes.Status500InternalServerError, Message = ex.InnerException!.Message ?? ex.Message }, SuccessResponse = null };
        }
    }

    public async Task<ReturnResponsesDto> UpdateLandUseTypeAsync(LandUseTypeUpdateDto values)
    {
        try
        {
            var landUseType = await _unitOfWork.LandUseType.Get(values.LandUseTypeId);
            if (landUseType == null)
            {
                return new ReturnResponsesDto
                {
                    IsSuccess = false,
                    ErrorResponse = new ErrorResponseDto { Code = StatusCodes.Status404NotFound, Message = $"Land Use Type with ID {values.LandUseTypeId} not found." },
                    SuccessResponse = null
                };
            }

            landUseType.Update(values.LandUseId, values.LandUseTypeId, values.LandUseTypeInitial!, values.LandUseTypeName!, values.LandUseTypeDescription);
            landUseType.ModifiedBy = values.ModifiedBy;
            landUseType.ModifiedOn = DateTime.Now;

            _unitOfWork.LandUseType.Update(landUseType);
            await _unitOfWork.Complete();

            return new ReturnResponsesDto
            {
                IsSuccess = true,
                ErrorResponse = null,
                SuccessResponse = new SuccessResponseDto { Code = StatusCodes.Status200OK, Message = "Land Use Type modified successfully." },
            };
        }
        catch (Exception ex)
        {
            return new ReturnResponsesDto { IsSuccess = false, ErrorResponse = new ErrorResponseDto { Code = StatusCodes.Status500InternalServerError, Message = ex.InnerException!.Message ?? ex.Message }, SuccessResponse = null };
        }
    }

    public async Task<ReturnResponsesDto> DeleteLandUseType(int landUseTypeId)
    {
        try
        {
            var landUseType = await _unitOfWork.LandUseType.Get(landUseTypeId);
            if (landUseType == null)
            {
                return new ReturnResponsesDto
                {
                    IsSuccess = false,
                    ErrorResponse = new ErrorResponseDto { Code = StatusCodes.Status404NotFound, Message = $"Land Use Type with ID {landUseTypeId} not found." },
                    SuccessResponse = null
                };
            }

            _unitOfWork.LandUseType.Delete(landUseType);
            await _unitOfWork.Complete();

            return new ReturnResponsesDto
            {
                IsSuccess = true,
                ErrorResponse = null,
                SuccessResponse = new SuccessResponseDto { Code = StatusCodes.Status200OK, Message = $"Land Use Type with ID {landUseTypeId} deleted successfully." }
            };
        }
        catch (Exception ex)
        {
            return new ReturnResponsesDto { IsSuccess = false, ErrorResponse = new ErrorResponseDto { Code = StatusCodes.Status500InternalServerError, Message = ex.InnerException!.Message ?? ex.Message }, SuccessResponse = null };
        }
    }
}

