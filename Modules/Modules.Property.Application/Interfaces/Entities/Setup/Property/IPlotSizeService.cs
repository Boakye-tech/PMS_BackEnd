using System;
namespace Modules.Estates.Application.Interfaces.Entities.Setup.Property;

public interface IPlotSizeService
{
    Task<PlotSizeReadDto> AddPlotSizeAsync(PlotSizeCreateDto values);
    Task<PlotSizeReadDto> UpdatePlotSizeAsync(PlotSizeUpdateDto values);
    Task<IEnumerable<PlotSizeReadDto>> GetPlotSizeAsync();
    Task<PlotSizeReadDto> GetPlotSizeAsync(int value);
    Task<PlotSizeReadDto> GetPlotSizeAsync(string value);
}

