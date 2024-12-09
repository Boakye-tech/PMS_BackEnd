namespace Modules.Estates.Domain.Entities.Setup.Property;

public class PlotSize : AuditableEntity
{
    [Key]
    public int PlotSizeId { get; set; }

    [Required]
    [MaxLength(10)]
    public string? PlotSizes { get; set; }

    public PlotSize(int plotSizeId, string? plotSizes)
	{
        PlotSizeId = plotSizeId;
        PlotSizes = plotSizes;
	}

    public static PlotSize Create(int plotSizeId, string plotSizes)
    {
        if (string.IsNullOrWhiteSpace(plotSizes) || plotSizeId < 0)
        {
            throw new ArgumentException("Invalid Plot Size Data.");
        }

        if (plotSizeId <= -1)
            throw new ArgumentException("Plot Size Id must be greater than zero.");

        if (string.IsNullOrWhiteSpace(plotSizes) || plotSizes.Length > 10)
            throw new ArgumentException("Plot Sizes must not be null or exceed 10 characters.");


        return new PlotSize(plotSizeId, plotSizes);
    }

    public static PlotSize Update(int plotSizeId, string PlotSizes)
    {
        if (string.IsNullOrWhiteSpace(PlotSizes) || plotSizeId < 0)
        {
            throw new ArgumentException("Invalid Plot Size Data.");
        }

        if (plotSizeId <= -1)
            throw new ArgumentException("Plot Size Id must be greater than zero.");

        if (string.IsNullOrWhiteSpace(PlotSizes) || PlotSizes.Length > 10)
            throw new ArgumentException("Plot Sizes must not be null or exceed 10 characters.");


        return new PlotSize(plotSizeId, PlotSizes);
    }

}

