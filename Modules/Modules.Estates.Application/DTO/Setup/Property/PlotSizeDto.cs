namespace Modules.Estates.Application.DTO.Setup.Property;

public record PlotSizeReadDto(int PlotSizeId, string PlotSizes);
public record PlotSizeCreateDto(int PlotSizeId, string PlotSizes, string CreatedBy);
public record PlotSizeUpdateDto(int PlotSizeId, string PlotSizes, string ModifiedBy);
public record PlotSizDeleteDto(int PlotSizeId);
