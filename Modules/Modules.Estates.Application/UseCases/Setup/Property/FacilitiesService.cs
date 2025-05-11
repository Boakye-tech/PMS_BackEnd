// /**************************************************
// * Company: MindSprings Company Limited
// * Project Name: Modules.Estates.Application
// * Full FileName: /Users/imac5k/Projects/PropertyManagementSolution/pms-api/Modules/Modules.Estates.Application/UseCases/Setup/Property/FacilitiesService.cs
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

public class FacilitiesService : IFacilitiesService
{
    private readonly IUnitOfWork _unitOfWork;
    private readonly IMapper _mapper;

    public FacilitiesService(IUnitOfWork unitOfWork, IMapper mapper)
    {
        _unitOfWork = unitOfWork;
        _mapper = mapper;
    }

    public async Task<IEnumerable<FacilitiesReadDto>> GetFacilitiesAsync()
    {
        var response = await _unitOfWork.Facilities.GetAll();
        return _mapper.Map<IEnumerable<FacilitiesReadDto>>(response);
    }

    public async Task<FacilitiesReadDto> GetFacilitiesAsync(int value)
    {
        var response = await _unitOfWork.Facilities.Get(value);
        return _mapper.Map<FacilitiesReadDto>(response);
    }

    public async Task<FacilitiesReadDto> GetFacilitiesAsync(string value)
    {
        var response = await _unitOfWork.Facilities.Get(f => f.Facility == value);
        return _mapper.Map<FacilitiesReadDto>(response);
    }

    public async Task<ReturnResponsesDto> CreateFacilitiesAsync(FacilitiesCreateDto values)
    {
        try
        {
            var existingFacility = await _unitOfWork.Facilities.Get(f => f.Facility == values.facility);
            if (existingFacility != null)
            {
                return new ReturnResponsesDto
                {
                    IsSuccess = false,
                    ErrorResponse = new ErrorResponseDto { Code = StatusCodes.Status400BadRequest, Message = "Facility already exists." },
                    SuccessResponse = null
                };
            }

            var facility = Facilities.Create(0, values.facility);
            facility.CreatedBy = values.createdBy;
            facility.CreatedOn = DateTime.Now;

            _unitOfWork.Facilities.Insert(facility);
            await _unitOfWork.Complete();

            var result = _mapper.Map<FacilitiesReadDto>(facility);

            return new ReturnResponsesDto
            {
                IsSuccess = true,
                ErrorResponse = null,
                SuccessResponse = new SuccessResponseDto { Code = StatusCodes.Status201Created, Message = "Facility created successfully.", Data = result },
            };
        }
        catch (Exception ex)
        {
            return new ReturnResponsesDto { IsSuccess = false, ErrorResponse = new ErrorResponseDto { Code = StatusCodes.Status500InternalServerError, Message = ex.Message }, SuccessResponse = null };
        }
    }

    public async Task<ReturnResponsesDto> UpdateFacilitiesAsync(FacilitiesUpdateDto values)
    {
        try
        {
            var facility = await _unitOfWork.Facilities.Get(values.facilityId);
            if (facility == null)
            {
                return new ReturnResponsesDto
                {
                    IsSuccess = false,
                    ErrorResponse = new ErrorResponseDto { Code = StatusCodes.Status404NotFound, Message = $"Facility with ID {values.facilityId} not found." },
                    SuccessResponse = null
                };
            }

            facility.Update(values.facilityId, values.facility);
            facility.ModifiedBy = values.modifiedBy;
            facility.ModifiedOn = DateTime.Now;

            _unitOfWork.Facilities.Update(facility);
            await _unitOfWork.Complete();

            var result = _mapper.Map<FacilitiesReadDto>(facility);

            return new ReturnResponsesDto
            {
                IsSuccess = true,
                ErrorResponse = null,
                SuccessResponse = new SuccessResponseDto { Code = StatusCodes.Status200OK, Message = "Facility modified successfully.", Data = result },
            };
        }
        catch (Exception ex)
        {
            return new ReturnResponsesDto { IsSuccess = false, ErrorResponse = new ErrorResponseDto { Code = StatusCodes.Status500InternalServerError, Message = ex.InnerException!.Message }, SuccessResponse = null };
        }
    }
}

