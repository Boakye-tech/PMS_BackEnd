// /**************************************************
// * Company: MindSprings Company Limited
// * Project Name: Modules.Estates.Application
// * Full FileName: /Users/imac5k/Projects/PropertyManagementSolution/pms-api/Modules/Modules.Estates.Application/UseCases/Setup/Property/PlotSizeService.cs
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

public class PlotSizeService : IPlotSizeService
{
    private readonly IUnitOfWork _unitOfWork;
    private readonly IMapper _mapper;

    public PlotSizeService(IUnitOfWork unitOfWork, IMapper mapper)
    {
        _unitOfWork = unitOfWork;
        _mapper = mapper;
    }

    public async Task<IEnumerable<PlotSizeReadDto>> GetPlotSizeAsync()
    {
        var plotSize = await _unitOfWork.PlotSize.GetAll();
        return _mapper.Map<IEnumerable<PlotSizeReadDto>>(plotSize);
    }

    public async Task<PlotSizeReadDto> GetPlotSizeAsync(int value)
    {
        var plotSize = await _unitOfWork.PlotSize.Get(value);
        return _mapper.Map<PlotSizeReadDto>(plotSize);
    }

    public async Task<PlotSizeReadDto> GetPlotSizeAsync(string value)
    {
        var plotSize = await _unitOfWork.PlotSize.Get(p => p.PlotSizes == value);
        return _mapper.Map<PlotSizeReadDto>(plotSize);
    }

    public async Task<ReturnResponsesDto> CreatePlotSizeAsync(PlotSizeCreateDto values)
    {
        try
        {
            var existingPlotSize = await _unitOfWork.PlotSize.Get(p => p.PlotSizes == values.PlotSizes);
            if (existingPlotSize != null)
            {
                return new ReturnResponsesDto
                {
                    IsSuccess = false,
                    ErrorResponse = new ErrorResponseDto { Code = StatusCodes.Status400BadRequest, Message = "Plot Size already exists." },
                    SuccessResponse = null
                };
            }

            var plotSize = PlotSize.Create(0, values.PlotSizes!);
            plotSize.CreatedBy = values.CreatedBy;
            plotSize.CreatedOn = DateTime.Now;

            _unitOfWork.PlotSize.Insert(plotSize);
            await _unitOfWork.Complete();

            var result = _mapper.Map<PlotSizeReadDto>(plotSize);

            return new ReturnResponsesDto
            {
                IsSuccess = true,
                ErrorResponse = null,
                SuccessResponse = new SuccessResponseDto { Code = StatusCodes.Status201Created, Message = "Plot Size created successfully.", Data = result },
            };
        }
        catch (Exception ex)
        {
            return new ReturnResponsesDto { IsSuccess = false, ErrorResponse = new ErrorResponseDto { Code = StatusCodes.Status500InternalServerError, Message = ex.Message }, SuccessResponse = null };
        }
    }

    public async Task<ReturnResponsesDto> UpdatePlotSizeAsync(PlotSizeUpdateDto values)
    {
        try
        {
            var plotSize = await _unitOfWork.PlotSize.Get(values.PlotSizeId);
            if (plotSize == null)
            {
                return new ReturnResponsesDto
                {
                    IsSuccess = false,
                    ErrorResponse = new ErrorResponseDto { Code = StatusCodes.Status404NotFound, Message = $"Plot Size with ID {values.PlotSizeId} not found." },
                    SuccessResponse = null
                };
            }

            plotSize.Update(values.PlotSizeId, values.PlotSizes!);
            plotSize.ModifiedBy = values.ModifiedBy;
            plotSize.ModifiedOn = DateTime.Now;

            _unitOfWork.PlotSize.Update(plotSize);
            await _unitOfWork.Complete();

            var result = _mapper.Map<PlotSizeReadDto>(plotSize);

            return new ReturnResponsesDto
            {
                IsSuccess = true,
                ErrorResponse = null,
                SuccessResponse = new SuccessResponseDto { Code = StatusCodes.Status200OK, Message = "Plot Size modified successfully.", Data = result },
            };
        }
        catch (Exception ex)
        {
            return new ReturnResponsesDto { IsSuccess = false, ErrorResponse = new ErrorResponseDto { Code = StatusCodes.Status500InternalServerError, Message = ex.InnerException!.Message }, SuccessResponse = null };
        }
    }
}

