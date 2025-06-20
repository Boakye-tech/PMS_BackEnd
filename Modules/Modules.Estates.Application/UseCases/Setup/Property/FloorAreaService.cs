// /**************************************************
// * Company: MindSprings Company Limited
// * Project Name: Modules.Estates.Application
// * Full FileName: /Users/imac5k/Projects/PropertyManagementSolution/pms-api/Modules/Modules.Estates.Application/UseCases/Setup/Property/FloorAreaService.cs
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

public class FloorAreaService : IFloorAreaService
{
    private readonly IUnitOfWork _unitOfWork;
    private readonly IMapper _mapper;

    public FloorAreaService(IUnitOfWork unitOfWork, IMapper mapper)
    {
        _unitOfWork = unitOfWork;
        _mapper = mapper;
    }

    public async Task<IEnumerable<FloorAreaReadDto>> GetFloorAreaAsync()
    {
        var response = await _unitOfWork.FloorArea.GetAll();
        return _mapper.Map<IEnumerable<FloorAreaReadDto>>(response);
    }

    public async Task<FloorAreaReadDto> GetFloorAreaAsync(int value)
    {
        var response = await _unitOfWork.FloorArea.Get(value);
        return _mapper.Map<FloorAreaReadDto>(response);
    }

    public async Task<FloorAreaReadDto> GetFloorAreaAsync(decimal value)
    {
        var response = await _unitOfWork.FloorArea.Get(f => f.Area == value);
        return _mapper.Map<FloorAreaReadDto>(response);
    }

    public async Task<ReturnResponsesDto> CreateFloorAreaAsync(FloorAreaCreateDto values)
    {
        try
        {
            var existingFloorArea = await _unitOfWork.FloorArea.Get(f => f.Area == values.area);
            if (existingFloorArea != null)
            {
                return new ReturnResponsesDto
                {
                    IsSuccess = false,
                    ErrorResponse = new ErrorResponseDto { Code = StatusCodes.Status400BadRequest, Message = "Floor Area already exists." },
                    SuccessResponse = null
                };
            }

            var floorArea = FloorArea.Create(0, values.area);
            floorArea.CreatedBy = values.createdBy;
            floorArea.CreatedOn = DateTime.Now;

            _unitOfWork.FloorArea.Insert(floorArea);
            await _unitOfWork.Complete();

            return new ReturnResponsesDto
            {
                IsSuccess = true,
                ErrorResponse = null,
                SuccessResponse = new SuccessResponseDto { Code = StatusCodes.Status201Created, Message = "Floor Area created successfully." },
            };
        }
        catch (Exception ex)
        {
            return new ReturnResponsesDto { IsSuccess = false, ErrorResponse = new ErrorResponseDto { Code = StatusCodes.Status500InternalServerError, Message = ex.Message }, SuccessResponse = null };
        }
    }

    public async Task<ReturnResponsesDto> UpdateFloorAreaAsync(FloorAreaUpdateDto values)
    {
        try
        {
            var floorArea = await _unitOfWork.FloorArea.Get(values.floorAreaId);
            if (floorArea == null)
            {
                return new ReturnResponsesDto
                {
                    IsSuccess = false,
                    ErrorResponse = new ErrorResponseDto { Code = StatusCodes.Status404NotFound, Message = $"Floor Area with ID {values.floorAreaId} not found." },
                    SuccessResponse = null
                };
            }

            floorArea.Update(values.floorAreaId, values.area);
            floorArea.ModifiedBy = values.modifiedBy;
            floorArea.ModifiedOn = DateTime.Now;

            _unitOfWork.FloorArea.Update(floorArea);
            await _unitOfWork.Complete();

            return new ReturnResponsesDto
            {
                IsSuccess = true,
                ErrorResponse = null,
                SuccessResponse = new SuccessResponseDto { Code = StatusCodes.Status200OK, Message = "Floor Area modified successfully." },
            };
        }
        catch (Exception ex)
        {
            return new ReturnResponsesDto { IsSuccess = false, ErrorResponse = new ErrorResponseDto { Code = StatusCodes.Status500InternalServerError, Message = ex.InnerException!.Message ?? ex.Message }, SuccessResponse = null };
        }
    }

    public async Task<ReturnResponsesDto> DeleteFloorArea(int floorAreaId)
    {
        try
        {
            var facility = await _unitOfWork.FloorArea.Get(floorAreaId);
            if (facility == null)
            {
                return new ReturnResponsesDto
                {
                    IsSuccess = false,
                    ErrorResponse = new ErrorResponseDto { Code = StatusCodes.Status404NotFound, Message = $"Floor Area with ID {floorAreaId} not found." },
                    SuccessResponse = null
                };
            }

            _unitOfWork.FloorArea.Delete(facility);
            await _unitOfWork.Complete();

            return new ReturnResponsesDto
            {
                IsSuccess = true,
                ErrorResponse = null,
                SuccessResponse = new SuccessResponseDto { Code = StatusCodes.Status200OK, Message = $"Floor Area with ID {floorAreaId} deleted successfully." }
            };
        }
        catch (Exception ex)
        {
            return new ReturnResponsesDto { IsSuccess = false, ErrorResponse = new ErrorResponseDto { Code = StatusCodes.Status500InternalServerError, Message = ex.InnerException!.Message ?? ex.Message }, SuccessResponse = null };
        }
    }
}

