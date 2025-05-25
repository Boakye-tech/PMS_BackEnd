// /**************************************************
// * Company: MindSprings Company Limited
// * Project Name: Modules.Estates.Domain
// * Full FileName: /Users/imac5k/Projects/PropertyManagementSolution/pms-api/Modules/Modules.Estates.Domain/Entities/Setup/Property/LandUse.cs
// * Author: Boakye Ofori-Atta
// * Email Address: boakye.ofori-atta@mindsprings-gh.com
// * Copyright: © 2024 MindSprings Company Limited
// * Create Date: 11/05/2025 01:28 PM
// * Version: 1.0.1
// * Description: Property Management System
//  **************************************************/

namespace Modules.Estates.Domain.Entities.Setup.Property;

public class LandUse : AuditableEntity
{
    [Key]
    [Required]
    public int LandUseId { get; private set; }

    [Required]
    [StringLength(5)]
    public string? LandUseInitial { get; private set; }

    [Required]
    [StringLength(30)]
    public string? LandUseName { get; private set; }

    // Navigation property for LandUseTypes
    public virtual ICollection<LandUseType> LandUseTypes { get; private set; }

    public LandUse(int landUseId, string? landUseInitial, string? landUseName)
    {
        LandUseId = landUseId;
        LandUseInitial = landUseInitial;
        LandUseName = landUseName;
        LandUseTypes = new List<LandUseType>();
    }


    public static LandUse Create(int landUseId, string landUseInitial, string landUseName)
    {
        Validate(landUseId, landUseInitial, landUseName);
        return new LandUse(landUseId, landUseInitial, landUseName);
    }

    public void Update(int landUseId, string landUseInitial, string landUseName)
    {
        Validate(landUseId, landUseInitial!, landUseName!);

        LandUseInitial = landUseInitial;
        LandUseName = landUseName;
    }

    private static void Validate(int landUseId, string landUseInitial, string landUseName)
    {
        if ((landUseId < 0 || string.IsNullOrWhiteSpace(landUseInitial) || string.IsNullOrWhiteSpace(landUseName)))
        {
            throw new ArgumentException("Land Use Data.");
        }

        if (landUseId < 0)
            throw new ArgumentException("Land Use Id must be greater than zero.");

        if (string.IsNullOrWhiteSpace(landUseInitial) || landUseInitial.Length > 5)
            throw new ArgumentException("Land Use Initial cannot be empty or exceed 5 characters.");

        if (string.IsNullOrWhiteSpace(landUseName) || landUseName.Length > 30)
            throw new ArgumentException("Land Use Name cannot be empty or exceed 30 characters.");
    }
}

