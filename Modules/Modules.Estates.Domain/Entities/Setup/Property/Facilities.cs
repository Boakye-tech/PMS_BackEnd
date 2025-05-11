// /**************************************************
// * Company: MindSprings Company Limited
// * Project Name: Modules.Estates.Domain
// * Full FileName: /Users/imac5k/Projects/PropertyManagementSolution/pms-api/Modules/Modules.Estates.Domain/Entities/Setup/Property/Facilities.cs
// * Author: Boakye Ofori-Atta
// * Email Address: boakye.ofori-atta@mindsprings-gh.com
// * Copyright: © 2024 MindSprings Company Limited
// * Create Date: 11/05/2025 01:07 PM
// * Version: 1.0.1
// * Description: Property Management System
//  **************************************************/

namespace Modules.Estates.Domain.Entities.Setup.Property;

public class Facilities : AuditableEntity
{
    [Key]
    [Required]
    public int FacilityId { get; private set; }

    [Required]
    [StringLength(20)]
    public string Facility { get; private set; }

    public Facilities(int facilityId, string facility)
    {
        FacilityId = facilityId;
        Facility = facility;
    }

    public static Facilities Create(int facilityId, string facility)
    {
        Validate(facilityId, facility);
        return new Facilities(facilityId, facility);
    }

    public void Update(int facilityId, string facility)
    {
        Validate(facilityId, facility);

        FacilityId = facilityId;
        Facility = facility;
    }

    private static void Validate(int facilityId, string facility)
    {
        if (facilityId <= 0)
            throw new ArgumentException("Facility Id must be greater than zero.");

        if (string.IsNullOrWhiteSpace(facility))
            throw new ArgumentException("Facility cannot be empty or exceed 20 characters.");
    }
}

