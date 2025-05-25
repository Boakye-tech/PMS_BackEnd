// /**************************************************
// * Company: MindSprings Company Limited
// * Project Name: Modules.Estates.Application
// * Full FileName: /Users/imac5k/Projects/PropertyManagementSolution/pms-api/Modules/Modules.Estates.Application/UseCases/Setup/Property/PlotDimensionService.cs
// * Author: Boakye Ofori-Atta
// * Email Address: boakye.ofori-atta@mindsprings-gh.com
// * Copyright: © 2024 MindSprings Company Limited
// * Create Date: 01/01/2025 
// * Version: 1.0.1
// * Description: Property Management System
//  **************************************************/

using Microsoft.AspNetCore.Http;


namespace Modules.Estates.Application.UseCases.Setup.Property;

public class PlotDimensionService : IPlotDimensionService
{
    private readonly IUnitOfWork _unitOfWork;
    private readonly IMapper _mapper;

    public PlotDimensionService(IUnitOfWork unitOfWork, IMapper mapper)
    {
        _unitOfWork = unitOfWork;
        _mapper = mapper;
    }

    public async Task<IEnumerable<PlotDimensionReadDto>> GetPlotDimensionAsync()
    {
        var plotDimension = await _unitOfWork.PlotDimension.GetAll();
        return _mapper.Map<IEnumerable<PlotDimensionReadDto>>(plotDimension);
    }

    public async Task<PlotDimensionReadDto> GetPlotDimensionAsync(int value)
    {
        var plotDimension = await _unitOfWork.PlotDimension.Get(value);
        return _mapper.Map<PlotDimensionReadDto>(plotDimension);
    }

    public async Task<PlotDimensionReadDto> GetPlotDimensionAsync(string value)
    {
        var plotDimension = await _unitOfWork.PlotDimension.Get(p => p.PlotDimensions == value);
        return _mapper.Map<PlotDimensionReadDto>(plotDimension);
    }

    public async Task<ReturnResponsesDto> CreatePlotDimensionAsync(PlotDimensionCreateDto values)
    {
        try
        {
            var existingPlotDimension = await _unitOfWork.PlotDimension.Get(p => p.PlotDimensions == values.PlotDimensions);
            if (existingPlotDimension != null)
            {
                return new ReturnResponsesDto
                {
                    IsSuccess = false,
                    ErrorResponse = new ErrorResponseDto { Code = StatusCodes.Status400BadRequest, Message = "Plot Dimension already exists." },
                    SuccessResponse = null
                };
            }

            var plotDimension = PlotDimension.Create(0, values.PlotDimensions!);
            plotDimension.CreatedBy = values.CreatedBy;
            plotDimension.CreatedOn = DateTime.Now;

            _unitOfWork.PlotDimension.Insert(plotDimension);
            await _unitOfWork.Complete();

            return new ReturnResponsesDto
            {
                IsSuccess = true,
                ErrorResponse = null,
                SuccessResponse = new SuccessResponseDto { Code = StatusCodes.Status201Created, Message = "Plot Dimension created successfully." },
            };
        }
        catch (Exception ex)
        {
            return new ReturnResponsesDto { IsSuccess = false, ErrorResponse = new ErrorResponseDto { Code = StatusCodes.Status500InternalServerError, Message = ex.Message }, SuccessResponse = null };
        }
    }

    public async Task<ReturnResponsesDto> UpdatePlotDimensionAsync(PlotDimensionUpdateDto values)
    {
        try
        {
            var plotDimension = await _unitOfWork.PlotDimension.Get(values.PlotDimensionId);
            if (plotDimension == null)
            {
                return new ReturnResponsesDto
                {
                    IsSuccess = false,
                    ErrorResponse = new ErrorResponseDto { Code = StatusCodes.Status404NotFound, Message = $"Plot Dimension with ID {values.PlotDimensionId} not found." },
                    SuccessResponse = null
                };
            }

            plotDimension.Update(values.PlotDimensionId, values.PlotDimensions!);
            plotDimension.ModifiedBy = values.ModifiedBy;
            plotDimension.ModifiedOn = DateTime.Now;

            _unitOfWork.PlotDimension.Update(plotDimension);
            await _unitOfWork.Complete();

            return new ReturnResponsesDto
            {
                IsSuccess = true,
                ErrorResponse = null,
                SuccessResponse = new SuccessResponseDto { Code = StatusCodes.Status200OK, Message = "Plot Dimension modified successfully." },
            };
        }
        catch (Exception ex)
        {
            return new ReturnResponsesDto { IsSuccess = false, ErrorResponse = new ErrorResponseDto { Code = StatusCodes.Status500InternalServerError, Message = ex.Message }, SuccessResponse = null };
        }
    }

    public async Task<ReturnResponsesDto> DeletePlotDimension(int plotDimensionId)
    {
        try
        {
            var plotDimension = await _unitOfWork.PlotDimension.Get(plotDimensionId);
            if (plotDimension == null)
            {
                return new ReturnResponsesDto
                {
                    IsSuccess = false,
                    ErrorResponse = new ErrorResponseDto { Code = StatusCodes.Status404NotFound, Message = $"Plot Dimension with ID {plotDimensionId} not found." },
                    SuccessResponse = null
                };
            }

            _unitOfWork.PlotDimension.Delete(plotDimension);
            await _unitOfWork.Complete();

            return new ReturnResponsesDto
            {
                IsSuccess = true,
                ErrorResponse = null,
                SuccessResponse = new SuccessResponseDto { Code = StatusCodes.Status200OK, Message = $"Plot Dimension with ID {plotDimensionId} deleted successfully." }
            };
        }
        catch (Exception ex)
        {
            return new ReturnResponsesDto { IsSuccess = false, ErrorResponse = new ErrorResponseDto { Code = StatusCodes.Status500InternalServerError, Message = ex.Message }, SuccessResponse = null };
        }
    }
}

