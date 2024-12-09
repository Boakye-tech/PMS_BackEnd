namespace Modules.Estates.Domain.Entities.Setup.Property;

public class AllocationType : AuditableEntity
{
    [Key]
    [Required]
    public int AllocationTypeId { get; private set; }

    [StringLength(5)]
    [Required]
    public string? AllocationTypeInitial { get; private  set; }

    [StringLength(30)]
    [Required]
    public string? AllocationTypes { get; private  set; }


    public AllocationType(int allocationTypeId, string? allocationTypeInitial, string? allocationTypes)
    {
        AllocationTypeId = allocationTypeId;
        AllocationTypeInitial = allocationTypeInitial;
        AllocationTypes = allocationTypes;
    }


    public static AllocationType Create(int allocationTypeId, string allocationTypeInitial, string allocationTypes)
    {
        if (string.IsNullOrWhiteSpace(allocationTypeInitial) || string.IsNullOrWhiteSpace(allocationTypes) || allocationTypeId < 0)
        {
            throw new ArgumentException("Invalid Allocation Type Data.");
        }

        if (allocationTypeId <= -1)
            throw new ArgumentException("Allocation Type Id must be greater than zero.");

        if (string.IsNullOrWhiteSpace(allocationTypeInitial) || allocationTypeInitial.Length > 5)
            throw new ArgumentException("Allocation Type Initial must not be null or exceed 5 characters.");

        if (string.IsNullOrWhiteSpace(allocationTypes) || allocationTypes.Length > 50)
            throw new ArgumentException("Allocation Type must not be null or exceed 50 characters.");

        return new AllocationType(allocationTypeId, allocationTypeInitial, allocationTypes);
    }

    public static AllocationType Update(int allocationTypeId, string allocationTypeInitial, string allocationTypes)
    {
        if (string.IsNullOrWhiteSpace(allocationTypeInitial) || string.IsNullOrWhiteSpace(allocationTypes) || allocationTypeId < 0)
        {
            throw new ArgumentException("Invalid Allocation Type Data.");
        }

        if (allocationTypeId <= -1)
            throw new ArgumentException("Allocation Type Id must be greater than zero.");

        if (string.IsNullOrWhiteSpace(allocationTypeInitial) || allocationTypeInitial.Length > 5)
            throw new ArgumentException("Allocation Type Initial must not be null or exceed 5 characters.");

        if (string.IsNullOrWhiteSpace(allocationTypes) || allocationTypes.Length > 50)
            throw new ArgumentException("Allocation Type must not be null or exceed 50 characters.");

        return new AllocationType(allocationTypeId, allocationTypeInitial, allocationTypes);
    }

}

