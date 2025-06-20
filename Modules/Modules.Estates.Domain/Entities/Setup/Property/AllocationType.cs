// /**************************************************
// * Company: MindSprings Company Limited
// * Project Name: Modules.Estates.Domain
// * Full FileName: /Users/imac5k/Projects/PropertyManagementSolution/pms-api/Modules/Modules.Estates.Domain/Entities/Setup/Property/AllocationType.cs
// * Author: Boakye Ofori-Atta
// * Email Address: boakye.ofori-atta@mindsprings-gh.com
// * Copyright: © 2024 MindSprings Company Limited
// * Create Date: 11/05/2025 01:03 PM
// * Version: 1.0.1
// * Description: Property Management System
//  **************************************************/

namespace Modules.Estates.Domain.Entities.Setup.Property;

public class AllocationType : AuditableEntity
{
    [Key]
    [Required]
    public int AllocationTypeId { get; private set; }

    [StringLength(5)]
    [Required]
    public string AllocationTypeInitial { get; private set; }

    [StringLength(30)]
    [Required]
    public string AllocationTypes { get; private set; }

    public AllocationType(int allocationTypeId, string allocationTypeInitial, string allocationTypes)
    {
        AllocationTypeId = allocationTypeId;
        AllocationTypeInitial = allocationTypeInitial;
        AllocationTypes = allocationTypes;
    }

    public static AllocationType Create(int allocationTypeId, string allocationTypeInitial, string allocationTypes)
    {
        Validate(allocationTypeId, allocationTypeInitial, allocationTypes);
        return new AllocationType(allocationTypeId, allocationTypeInitial, allocationTypes);
    }

    public void Update(int allocationTypeId, string allocationTypeInitial, string allocationTypes)
    {
        Validate(allocationTypeId, allocationTypeInitial, allocationTypes);

        AllocationTypeId = allocationTypeId;
        AllocationTypeInitial = allocationTypeInitial;
        AllocationTypes = allocationTypes;
    }

    private static void Validate(int allocationTypeId, string allocationTypeInitial, string allocationTypes)
    {
        if (allocationTypeId < 0)
            throw new ArgumentException("Allocation Type Id must be greater than zero.");

        if (string.IsNullOrWhiteSpace(allocationTypeInitial))
            throw new ArgumentException("Allocation Type Initial cannot be empty or exceed 5 characters.");

        if (string.IsNullOrWhiteSpace(allocationTypes))
            throw new ArgumentException("Allocation Type cannot be empty or exceed 30 characters.");
    }
}

