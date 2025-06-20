// /**************************************************
// * Company: MindSprings Company Limited
// * Project Name: Modules.Estates.Application
// * Full FileName: /Users/imac5k/Projects/PropertyManagementSolution/pms-api/Modules/Modules.Estates.Application/UseCases/Setup/Property/PlotTypeService.cs
// * Author: Boakye Ofori-Atta
// * Email Address: boakye.ofori-atta@mindsprings-gh.com
// * Copyright: © 2024 MindSprings Company Limited
// * Create Date: 01/01/2025 
// * Version: 1.0.1
// * Description: Property Management System
//  **************************************************/

using Microsoft.AspNetCore.Http;


namespace Modules.Estates.Application.UseCases.Setup.Property;

public class PlotTypeService : IPlotTypeService
{
    private readonly IUnitOfWork _unitOfWork;
    private readonly IMapper _mapper;

    public PlotTypeService(IUnitOfWork unitOfWork, IMapper mapper)
    {
        _unitOfWork = unitOfWork;
        _mapper = mapper;
    }

    public async Task<IEnumerable<PlotTypeReadDto>> GetPlotTypeAsync()
    {
        var PlotType = await _unitOfWork.PlotType.GetAll();
        return _mapper.Map<IEnumerable<PlotTypeReadDto>>(PlotType);
    }


    public async Task<ReturnResponsesDto> CreatePlotTypeAsync(PlotTypeCreateDto values)
    {
        try
        {
            var existingType = await _unitOfWork.PlotType.Get(p => p.PlotTypes == values.PlotTypes);
            if (existingType != null)
            {
                return new ReturnResponsesDto
                {
                    IsSuccess = false,
                    ErrorResponse = new ErrorResponseDto { Code = StatusCodes.Status400BadRequest, Message = "Property Type already exists." },
                    SuccessResponse = null
                };
            }

            var plotType = PlotType.Create(0, values.PlotTypes!);
            plotType.CreatedBy = values.CreatedBy;
            plotType.CreatedOn = DateTime.Now;

            _unitOfWork.PlotType.Insert(plotType);
            await _unitOfWork.Complete();

            return new ReturnResponsesDto
            {
                IsSuccess = true,
                ErrorResponse = null,
                SuccessResponse = new SuccessResponseDto { Code = StatusCodes.Status201Created, Message = "Property Type created successfully." },
            };
        }
        catch (Exception ex)
        {
            return new ReturnResponsesDto { IsSuccess = false, ErrorResponse = new ErrorResponseDto { Code = StatusCodes.Status500InternalServerError, Message = ex.InnerException?.Message ?? ex.Message }, SuccessResponse = null };
        }
    }

    public async Task<ReturnResponsesDto> UpdatePlotTypeAsync(PlotTypeUpdateDto values)
    {
        try
        {
            var PlotType = await _unitOfWork.PlotType.Get(values.PlotTypeId);
            if (PlotType == null)
            {
                return new ReturnResponsesDto
                {
                    IsSuccess = false,
                    ErrorResponse = new ErrorResponseDto { Code = StatusCodes.Status404NotFound, Message = $"Property Type with ID {values.PlotTypeId} not found." },
                    SuccessResponse = null
                };
            }

            PlotType.Update(values.PlotTypeId, values.PlotTypes!);
            PlotType.ModifiedBy = values.ModifiedBy;
            PlotType.ModifiedOn = DateTime.Now;

            _unitOfWork.PlotType.Update(PlotType);
            await _unitOfWork.Complete();

            return new ReturnResponsesDto
            {
                IsSuccess = true,
                ErrorResponse = null,
                SuccessResponse = new SuccessResponseDto { Code = StatusCodes.Status200OK, Message = "Property Type modified successfully." },
            };
        }
        catch (Exception ex)
        {
            return new ReturnResponsesDto { IsSuccess = false, ErrorResponse = new ErrorResponseDto { Code = StatusCodes.Status500InternalServerError, Message = ex.InnerException?.Message ?? ex.Message }, SuccessResponse = null };
        }
    }

    public async Task<ReturnResponsesDto> DeletePlotType(int PlotTypeId)
    {
        try
        {
            var PlotType = await _unitOfWork.PlotType.Get(PlotTypeId);
            if (PlotType == null)
            {
                return new ReturnResponsesDto
                {
                    IsSuccess = false,
                    ErrorResponse = new ErrorResponseDto { Code = StatusCodes.Status404NotFound, Message = $"Property Type with ID {PlotTypeId} not found." },
                    SuccessResponse = null
                };
            }

            _unitOfWork.PlotType.Delete(PlotType);
            await _unitOfWork.Complete();

            return new ReturnResponsesDto
            {
                IsSuccess = true,
                ErrorResponse = null,
                SuccessResponse = new SuccessResponseDto { Code = StatusCodes.Status200OK, Message = $"Property Type with ID {PlotTypeId} deleted successfully." }
            };
        }
        catch (Exception ex)
        {
            return new ReturnResponsesDto { IsSuccess = false, ErrorResponse = new ErrorResponseDto { Code = StatusCodes.Status500InternalServerError, Message = ex.InnerException?.Message ?? ex.Message }, SuccessResponse = null };
        }
    }
}

