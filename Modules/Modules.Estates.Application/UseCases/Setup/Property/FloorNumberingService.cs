// /**************************************************
// * Company: MindSprings Company Limited
// * Project Name: Modules.Estates.Application
// * Full FileName: /Users/imac5k/Projects/PropertyManagementSolution/pms-api/Modules/Modules.Estates.Application/UseCases/Setup/Property/FloorNumberingService.cs
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

public class FloorNumberingService : IFloorNumberingService
{
    private readonly IUnitOfWork _unitOfWork;
    private readonly IMapper _mapper;

    public FloorNumberingService(IUnitOfWork unitOfWork, IMapper mapper)
    {
        _unitOfWork = unitOfWork;
        _mapper = mapper;
    }

    public async Task<IEnumerable<FloorNumberingReadDto>> GetFloorNumberingAsync()
    {
        var response = await _unitOfWork.FloorNumbering.GetAll();
        return _mapper.Map<IEnumerable<FloorNumberingReadDto>>(response);
    }

    public async Task<FloorNumberingReadDto> GetFloorNumberingAsync(int value)
    {
        var response = await _unitOfWork.FloorNumbering.Get(value);
        return _mapper.Map<FloorNumberingReadDto>(response);
    }

    public async Task<FloorNumberingReadDto> GetFloorNumberingAsync(string value)
    {
        var response = await _unitOfWork.FloorNumbering.Get(fn => fn.FloorNumber == value);
        return _mapper.Map<FloorNumberingReadDto>(response);
    }

    public async Task<ReturnResponsesDto> CreateFloorNumberingAsync(FloorNumberingCreateDto values)
    {
        try
        {
            var existingFloorNumber = await _unitOfWork.FloorNumbering.Get(fn => fn.FloorNumber == values.floorNumber);
            if (existingFloorNumber != null)
            {
                return new ReturnResponsesDto
                {
                    IsSuccess = false,
                    ErrorResponse = new ErrorResponseDto { Code = StatusCodes.Status400BadRequest, Message = "Floor Number already exists." },
                    SuccessResponse = null
                };
            }

            var floorNumber = FloorNumbering.Create(0, values.floorNumber);
            floorNumber.CreatedBy = values.createdby;
            floorNumber.CreatedOn = DateTime.Now;

            _unitOfWork.FloorNumbering.Insert(floorNumber);
            await _unitOfWork.Complete();

            return new ReturnResponsesDto
            {
                IsSuccess = true,
                ErrorResponse = null,
                SuccessResponse = new SuccessResponseDto { Code = StatusCodes.Status201Created, Message = "Floor Number created successfully." },
            };
        }
        catch (Exception ex)
        {
            return new ReturnResponsesDto { IsSuccess = false, ErrorResponse = new ErrorResponseDto { Code = StatusCodes.Status500InternalServerError, Message = ex.Message }, SuccessResponse = null };
        }
    }

    public async Task<ReturnResponsesDto> UpdateFloorNumberingAsync(FloorNumberingUpdateDto values)
    {
        try
        {
            var floorNumber = await _unitOfWork.FloorNumbering.Get(values.floorNumberId);
            if (floorNumber == null)
            {
                return new ReturnResponsesDto
                {
                    IsSuccess = false,
                    ErrorResponse = new ErrorResponseDto { Code = StatusCodes.Status404NotFound, Message = $"Floor Number with ID {values.floorNumberId} not found." },
                    SuccessResponse = null
                };
            }

            floorNumber.Update(values.floorNumberId, values.floorNumber);
            floorNumber.ModifiedBy = values.modifiedby;
            floorNumber.ModifiedOn = DateTime.Now;

            _unitOfWork.FloorNumbering.Update(floorNumber);
            await _unitOfWork.Complete();

            return new ReturnResponsesDto
            {
                IsSuccess = true,
                ErrorResponse = null,
                SuccessResponse = new SuccessResponseDto { Code = StatusCodes.Status200OK, Message = "Floor Number modified successfully." },
            };
        }
        catch (Exception ex)
        {
            return new ReturnResponsesDto { IsSuccess = false, ErrorResponse = new ErrorResponseDto { Code = StatusCodes.Status500InternalServerError, Message = ex.InnerException!.Message ?? ex.Message }, SuccessResponse = null };
        }
    }

    public async Task<ReturnResponsesDto> DeleteFloorNumbering(int floorNumberId)
    {
        try
        {
            var floorNumbering = await _unitOfWork.FloorNumbering.Get(floorNumberId);
            if (floorNumbering == null)
            {
                return new ReturnResponsesDto
                {
                    IsSuccess = false,
                    ErrorResponse = new ErrorResponseDto { Code = StatusCodes.Status404NotFound, Message = $"Floor Number with ID {floorNumberId} not found." },
                    SuccessResponse = null
                };
            }

            _unitOfWork.FloorNumbering.Delete(floorNumbering);
            await _unitOfWork.Complete();

            return new ReturnResponsesDto
            {
                IsSuccess = true,
                ErrorResponse = null,
                SuccessResponse = new SuccessResponseDto { Code = StatusCodes.Status200OK, Message = $"Floor Number with ID {floorNumberId} deleted successfully." }
            };
        }
        catch (Exception ex)
        {
            return new ReturnResponsesDto { IsSuccess = false, ErrorResponse = new ErrorResponseDto { Code = StatusCodes.Status500InternalServerError, Message = ex.InnerException!.Message ?? ex.Message }, SuccessResponse = null };
        }
    }
}

