// /**************************************************
// * Company: MindSprings Company Limited
// * Project Name: Modules.Estates.Domain
// * Full FileName: /Users/imac5k/Projects/PropertyManagementSolution/pms-api/Modules/Modules.Estates.Domain/Entities/Setup/Property/PlotSize.cs
// * Author: Boakye Ofori-Atta
// * Email Address: boakye.ofori-atta@mindsprings-gh.com
// * Copyright: © 2024 MindSprings Company Limited
// * Create Date: 11/05/2025 01:35 PM
// * Version: 1.0.1
// * Description: Property Management System
//  **************************************************/

namespace Modules.Estates.Domain.Entities.Setup.Property;

public class PlotSize : AuditableEntity
{
    [Key]
    [Required]
    public int PlotSizeId { get; private set; }

    [Required]
    [StringLength(10)]
    public string PlotSizes { get; private set; }

    public PlotSize(int plotSizeId, string plotSizes)
    {
        PlotSizeId = plotSizeId;
        PlotSizes = plotSizes;
    }

    public static PlotSize Create(int plotSizeId, string plotSizes)
    {
        Validate(plotSizeId, plotSizes);
        return new PlotSize(plotSizeId, plotSizes);
    }

    public void Update(int plotSizeId, string plotSizes)
    {
        Validate(plotSizeId, plotSizes);

        PlotSizeId = plotSizeId;
        PlotSizes = plotSizes;
    }

    private static void Validate(int plotSizeId, string plotSizes)
    {
        if (plotSizeId <= 0)
            throw new ArgumentException("Plot Size Id must be greater than zero.");

        if (string.IsNullOrWhiteSpace(plotSizes))
            throw new ArgumentException("Plot Sizes cannot be empty or exceed 10 characters.");
    }
}

