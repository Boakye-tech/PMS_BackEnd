// /**************************************************
// * Company: MindSprings Company Limited
// * Project Name: Modules.Estates.Domain
// * Full FileName: /Users/imac5k/Projects/PropertyManagementSolution/pms-api/Modules/Modules.Estates.Domain/Entities/Setup/Property/PlotType.cs
// * Author: Boakye Ofori-Atta
// * Email Address: boakye.ofori-atta@mindsprings-gh.com
// * Copyright: © 2024 MindSprings Company Limited
// * Create Date: 11/05/2025 01:35 PM
// * Version: 1.0.1
// * Description: Property Management System
//  **************************************************/

namespace Modules.Estates.Domain.Entities.Setup.Property;

public class PlotType : AuditableEntity
{
    [Key]
    [Required]
    public int PlotTypeId { get; private set; }

    [Required]
    [StringLength(50)]
    public string PlotTypes { get; private set; }

    public PlotType(int plotTypeId, string plotTypes)
    {
        PlotTypeId = plotTypeId;
        PlotTypes = plotTypes;
    }

    public static PlotType Create(int plotTypeId, string plotTypes)
    {
        Validate(plotTypeId, plotTypes);
        return new PlotType(plotTypeId, plotTypes);
    }

    public void Update(int plotTypeId, string plotTypes)
    {
        Validate(plotTypeId, plotTypes);

        PlotTypeId = plotTypeId;
        PlotTypes = plotTypes;
    }

    private static void Validate(int plotTypeId, string plotTypes)
    {
        if (plotTypeId < 0)
            throw new ArgumentException("Plot Type Id must be greater than zero.");

        if (string.IsNullOrWhiteSpace(plotTypes))
            throw new ArgumentException("Plot Type cannot be empty or exceed 50 characters.");
    }
}

