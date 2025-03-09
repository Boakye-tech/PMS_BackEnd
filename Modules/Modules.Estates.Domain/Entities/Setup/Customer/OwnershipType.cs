namespace Modules.Estates.Domain.Entities.Setup.Customer;

public class OwnershipType : AuditableEntity
{
    [Key]
    [Required]
    public int OwnershipTypeId { get; set; }

    [Required]
    [StringLength(50)]
    public string OwnershipTypes { get; set; }

    public OwnershipType(int ownershipTypeId, string ownershipTypes)
    {
        OwnershipTypeId = ownershipTypeId;
        OwnershipTypes = ownershipTypes;
    }

    public static OwnershipType Create(int ownershipTypeId, string ownershipTypes)
    {
        if (string.IsNullOrWhiteSpace(ownershipTypes) || ownershipTypeId < 0)
        {
            throw new ArgumentException("Invalid Ownership Type Data.");
        }

        if (ownershipTypeId <= -1)
        {
            throw new ArgumentException("Ownership Type Id must be greater than zero.");
        }

        if (string.IsNullOrWhiteSpace(ownershipTypes) || ownershipTypes.Length > 50)
        {
            throw new ArgumentException("Ownership Type must not be null or exceed 50 characters.");
        }

        return new OwnershipType(ownershipTypeId, ownershipTypes);
    }

    public static OwnershipType Update(int ownershipTypeId, string ownershipTypes)
    {
        if (string.IsNullOrWhiteSpace(ownershipTypes) || ownershipTypeId < 0)
        {
            throw new ArgumentException("Invalid Ownership Type Data.");
        }

        if (ownershipTypeId <= -1)
        {
            throw new ArgumentException("Ownership Type Id must be greater than zero.");
        }

        if (string.IsNullOrWhiteSpace(ownershipTypes) || ownershipTypes.Length > 50)
        {
            throw new ArgumentException("Ownership Type must not be null or exceed 50 characters.");
        }

        return new OwnershipType(ownershipTypeId, ownershipTypes);
    }
}

