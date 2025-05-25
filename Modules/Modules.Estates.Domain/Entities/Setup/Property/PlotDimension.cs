// /**************************************************
// * Company: MindSprings Company Limited
// * Project Name: Modules.Estates.Domain
// * Full FileName: /Users/imac5k/Projects/PropertyManagementSolution/pms-api/Modules/Modules.Estates.Domain/Entities/Setup/Property/PlotDimension.cs
// * Author: Boakye Ofori-Atta
// * Email Address: boakye.ofori-atta@mindsprings-gh.com
// * Copyright: © 2024 MindSprings Company Limited
// * Create Date: 11/05/2025 01:35 PM
// * Version: 1.0.1
// * Description: Property Management System
//  **************************************************/

namespace Modules.Estates.Domain.Entities.Setup.Property;

public class PlotDimension : AuditableEntity
{
    [Key]
    [Required]
    public int PlotDimensionId { get; private set; }

    [Required]
    [StringLength(20)]
    public string PlotDimensions { get; private set; }

    public PlotDimension(int plotDimensionId, string plotDimensions)
    {
        PlotDimensionId = plotDimensionId;
        PlotDimensions = plotDimensions;
    }

    public static PlotDimension Create(int plotDimensionId, string plotDimensions)
    {
        Validate(plotDimensionId, plotDimensions);
        return new PlotDimension(plotDimensionId, plotDimensions);
    }

    public void Update(int plotDimensionId, string plotDimensions)
    {
        Validate(plotDimensionId, plotDimensions);

        PlotDimensionId = plotDimensionId;
        PlotDimensions = plotDimensions;
    }

    private static void Validate(int plotDimensionId, string plotDimensions)
    {
        if (plotDimensionId < 0)
            throw new ArgumentException("Plot Dimension Id must be greater than zero.");

        if (string.IsNullOrWhiteSpace(plotDimensions) || plotDimensions.Length > 20)
            throw new ArgumentException("Plot Dimensions cannot be empty or exceed 20 characters.");
    }
}

