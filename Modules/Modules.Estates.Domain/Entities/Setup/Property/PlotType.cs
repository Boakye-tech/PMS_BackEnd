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

    [Required]
    public float SellingPrice { get; private set; }

    [Required]
    public int CurrencyId { get; private set; }

    public virtual CurrencyExchangeRate? Currency { get; private set; }


    public PlotType(int plotTypeId, string plotTypes, float sellingPrice, int currencyId)
    {
        PlotTypeId = plotTypeId;
        PlotTypes = plotTypes;
        SellingPrice = sellingPrice;
        CurrencyId = currencyId;
    }

    public static PlotType Create(int plotTypeId, string plotTypes, float sellingPrice, int currencyId)
    {
        Validate(plotTypeId, plotTypes, sellingPrice, currencyId);
        return new PlotType(plotTypeId, plotTypes, sellingPrice, currencyId);
    }

    public void Update(int plotTypeId, string plotTypes, float sellingPrice, int currencyId)
    {
        Validate(plotTypeId, plotTypes, sellingPrice, currencyId);

        PlotTypeId = plotTypeId;
        PlotTypes = plotTypes;
        SellingPrice = sellingPrice;
        CurrencyId = currencyId;
    }

    private static void Validate(int plotTypeId, string plotTypes, float sellingPrice, int currencyId)
    {
        if (plotTypeId < 0)
            throw new ArgumentException("Plot Type Id must be greater than zero.");

        if (string.IsNullOrWhiteSpace(plotTypes))
            throw new ArgumentException("Plot Type cannot be empty or exceed 50 characters.");

        if (sellingPrice <= 0)
            throw new ArgumentException("Selling price must be greater than zero.");

        if (currencyId <= 0)
            throw new ArgumentException("Currency Id must be greater than zero.");

    }
}

