namespace Modules.Estates.Domain.Entities.Setup.Customer;

public class IdentificationType : AuditableEntity
{
    [Key]
    [Required]
    public int IdentificationTypeId { get; set; }

    [Required]
    [StringLength(20)]
    public string? IdentificationTypes { get; set; }

    public IdentificationType(int identificationTypeId, string identificationTypes)
    {
        IdentificationTypeId = identificationTypeId;
        IdentificationTypes = identificationTypes;
    }

    public static IdentificationType Create(int identificationTypeId, string identificationTypes)
    {
        if (string.IsNullOrWhiteSpace(identificationTypes) || identificationTypeId < 0)
        {
            throw new ArgumentException("Invalid Identification Type Data.");
        }

        if (identificationTypeId <= -1)
            throw new ArgumentException("Identification Type Id must be greater than zero.");

        if (string.IsNullOrWhiteSpace(identificationTypes) || identificationTypes.Length > 20)
            throw new ArgumentException("Identification Type must not be null or exceed 20 characters.");

        return new IdentificationType(identificationTypeId, identificationTypes);
    }

    public static IdentificationType Update(int identificationTypeId, string identificationTypes)
    {
        if (string.IsNullOrWhiteSpace(identificationTypes) || identificationTypeId < 0)
        {
            throw new ArgumentException("Invalid Identification Type Data.");
        }

        if (identificationTypeId <= -1)
            throw new ArgumentException("Identification Type Id must be greater than zero.");

        if (string.IsNullOrWhiteSpace(identificationTypes) || identificationTypes.Length > 20)
            throw new ArgumentException("Identification Type must not be null or exceed 20 characters.");

        return new IdentificationType(identificationTypeId, identificationTypes);
    }
}

