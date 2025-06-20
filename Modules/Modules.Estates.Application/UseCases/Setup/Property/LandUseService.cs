// /**************************************************
// * Company: MindSprings Company Limited
// * Project Name: Modules.Estates.Application
// * Full FileName: /Users/imac5k/Projects/PropertyManagementSolution/pms-api/Modules/Modules.Estates.Application/UseCases/Setup/Property/LandUseService.cs
// * Author: Boakye Ofori-Atta
// * Email Address: boakye.ofori-atta@mindsprings-gh.com
// * Copyright: © 2024 MindSprings Company Limited
// * Create Date: 11/05/2025 1:07 PM
// * Version: 1.0.1
// * Description: Property Management System
//  **************************************************/

using Microsoft.AspNetCore.Http;

namespace Modules.Estates.Application.UseCases.Setup.Property;

public class LandUseService : ILandUseService
{
    private readonly IUnitOfWork _unitOfWork;
    private readonly IMapper _mapper;

    public LandUseService(IUnitOfWork unitOfWork, IMapper mapper)
    {
        _unitOfWork = unitOfWork;
        _mapper = mapper;
    }
    public async Task<IEnumerable<LandUseReadDto>> GetLandUseAsync()
    {
        var landuse = await _unitOfWork.LandUse.GetAll();
        return _mapper.Map<IEnumerable<LandUseReadDto>>(landuse);
    }

    public async Task<LandUseReadDto> GetLandUseAsync(int value)
    {
        var landuse = await _unitOfWork.LandUse.Get(value);
        return _mapper.Map<LandUseReadDto>(landuse);
    }

    public async Task<LandUseReadDto> GetLandUseAsync(string value)
    {
        var landuse = await _unitOfWork.LandUse.Get(l => l.LandUseInitial == value || l.LandUseName == value);
        return _mapper.Map<LandUseReadDto>(landuse);
    }

    public async Task<ReturnResponsesDto> CreateLandUseAsync(LandUseCreateDto values)
    {
        try
        {
            int LandUseId = 0;

            var landUseInitial = await _unitOfWork.LandUse.Get(l => l.LandUseInitial == values.LandUseInitial);
            if (landUseInitial != null)
            {
                return new ReturnResponsesDto
                {
                    IsSuccess = false,
                    ErrorResponse = new ErrorResponseDto { Code = StatusCodes.Status400BadRequest, Message = "Land Use Initial already exists." },
                    SuccessResponse = null
                };
            }

            var landuse = await _unitOfWork.LandUse.Get(l => l.LandUseName == values.LandUseName);
            if (landuse != null)
            {
                return new ReturnResponsesDto
                {
                    IsSuccess = false,
                    ErrorResponse = new ErrorResponseDto { Code = StatusCodes.Status400BadRequest, Message = "Land Use Name already exists." },
                    SuccessResponse = null
                };
            }

            var landUse = LandUse.Create(LandUseId, values.LandUseInitial!, values.LandUseName!);
            landUse.CreatedBy = values.CreatedBy;
            landUse.CreatedOn = DateTime.Now;

            _unitOfWork.LandUse.Insert(landUse);
            await _unitOfWork.Complete();

            var result = _mapper.Map<LandUseReadDto>(landUse);

            return new ReturnResponsesDto
            {
                IsSuccess = true,
                ErrorResponse = null,
                SuccessResponse = new SuccessResponseDto { Code = StatusCodes.Status201Created, Message = "Land Use details created successfully." },
            };

        }
        catch (Exception ex)
        {
            return new ReturnResponsesDto { IsSuccess = false, ErrorResponse = new ErrorResponseDto { Code = StatusCodes.Status500InternalServerError, Message = ex.InnerException!.Message ?? ex.Message }, SuccessResponse = null };
        }

    }

    public async Task<ReturnResponsesDto> UpdateLandUseAsync(LandUseUpdateDto values)
    {
        try
        {
            var landUse = await _unitOfWork.LandUse.Get(values.LandUseId);
            if (landUse == null)
            {
                return new ReturnResponsesDto
                {
                    IsSuccess = false,
                    ErrorResponse = new ErrorResponseDto { Code = StatusCodes.Status404NotFound, Message = $"Land Use with ID {values.LandUseId} not found." },
                    SuccessResponse = null
                };
            }

            landUse.Update(values.LandUseId, values.LandUseInitial!, values.LandUseName!);
            landUse.ModifiedBy = values.ModifiedBy;
            landUse.ModifiedOn = DateTime.Now;

            _unitOfWork.LandUse.Update(landUse);
            await _unitOfWork.Complete();

            return new ReturnResponsesDto
            {
                IsSuccess = true,
                ErrorResponse = null,
                SuccessResponse = new SuccessResponseDto { Code = StatusCodes.Status200OK, Message = "Land Use details modified successfully." },
            };

        }
        catch (Exception ex)
        {
            return new ReturnResponsesDto { IsSuccess = false, ErrorResponse = new ErrorResponseDto { Code = StatusCodes.Status500InternalServerError, Message = ex.InnerException!.Message ?? ex.Message }, SuccessResponse = null };
        }
    }

    public async Task<ReturnResponsesDto> DeleteLandUse(int landUseId)
    {
        try
        {
            var landUse = await _unitOfWork.LandUse.Get(landUseId);
            if (landUse == null)
            {
                return new ReturnResponsesDto
                {
                    IsSuccess = false,
                    ErrorResponse = new ErrorResponseDto { Code = StatusCodes.Status404NotFound, Message = $"Land Use with ID {landUseId} not found." },
                    SuccessResponse = null
                };
            }

            _unitOfWork.LandUse.Delete(landUse);
            await _unitOfWork.Complete();

            return new ReturnResponsesDto
            {
                IsSuccess = true,
                ErrorResponse = null,
                SuccessResponse = new SuccessResponseDto { Code = StatusCodes.Status200OK, Message = $"Land Use with ID {landUseId} deleted successfully." }
            };
        }
        catch (Exception ex)
        {
            return new ReturnResponsesDto { IsSuccess = false, ErrorResponse = new ErrorResponseDto { Code = StatusCodes.Status500InternalServerError, Message = ex.InnerException!.Message ?? ex.Message }, SuccessResponse = null };
        }
    }

    public async Task<List<LandUseAndLandUseTypeReadDto>> GetLandUseAndLandUseTypeAsync()
    {
        // Get all land uses and land use types in a single query using Include
        var landuses = await _unitOfWork.LandUse.GetAll(includes: new List<string> { "LandUseTypes" });

        // Create a dictionary for quick lookup of land use types by land use ID
        var landUseAndLandUseType = landuses.Select(landUse =>
        {
            var landUseTypes = _mapper.Map<List<LandUseTypeReadDto>>(landUse.LandUseTypes);
            return new LandUseAndLandUseTypeReadDto(
                new LandUsesReadDto(
                landUse.LandUseId,
                landUse.LandUseInitial!,
                landUse.LandUseName!,
                false),
                landUseTypes
            );
        }).ToList();

        return landUseAndLandUseType;
    }
}

