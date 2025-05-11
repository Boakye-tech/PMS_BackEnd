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
using AutoMapper;
using Modules.Estates.Application.DTO.Setup;
using Modules.Estates.Application.DTO.Setup.Property;
using Modules.Estates.Application.Interfaces.Entities.Setup.Property;
using Modules.Estates.Domain;
using Modules.Estates.Domain.Entities.Setup.Property;

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

            var newLandUseType = LandUseType.Create(values.LandUseTypeId, values.LandUseTypeId, values.LandUseTypeInitial!, values.LandUseTypeName!);
            newLandUseType.CreatedBy = values.CreatedBy;
            newLandUseType.CreatedOn = DateTime.Now;

            _unitOfWork.LandUseType.Insert(newLandUseType);
            await _unitOfWork.Complete();

            var result = _mapper.Map<LandUseTypeReadDto>(newLandUseType);

            return new ReturnResponsesDto
            {
                IsSuccess = true,
                ErrorResponse = null,
                SuccessResponse = new SuccessResponseDto { Code = StatusCodes.Status201Created, Message = "Land Use Type details created successfully.", Data = result },
            };
        }
        catch (Exception ex)
        {
            return new ReturnResponsesDto { IsSuccess = false, ErrorResponse = new ErrorResponseDto { Code = StatusCodes.Status500InternalServerError, Message = ex.Message }, SuccessResponse = null };
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

            landUseType.Update(values.LandUseId, values.LandUseTypeId, values.LandUseTypeInitial!, values.LandUseTypeName!);
            landUseType.ModifiedBy = values.ModifiedBy;
            landUseType.ModifiedOn = DateTime.Now;

            _unitOfWork.LandUseType.Update(landUseType);
            await _unitOfWork.Complete();

            var result = _mapper.Map<LandUseTypeReadDto>(landUseType);

            return new ReturnResponsesDto
            {
                IsSuccess = true,
                ErrorResponse = null,
                SuccessResponse = new SuccessResponseDto { Code = StatusCodes.Status200OK, Message = "Land Use Type details modified successfully.", Data = result },
            };
        }
        catch (Exception ex)
        {
            return new ReturnResponsesDto { IsSuccess = false, ErrorResponse = new ErrorResponseDto { Code = StatusCodes.Status500InternalServerError, Message = ex.InnerException!.Message }, SuccessResponse = null };
        }
    }
}

