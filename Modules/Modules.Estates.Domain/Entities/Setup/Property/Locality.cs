namespace Modules.Estates.Domain.Entities.Setup.Property;

public class Locality : AuditableEntity
{
    [Key]
    [Required]
    public int LocalityId { get; private set; }

    [Required]
    [StringLength(10)]
    public string? LocalityInitial { get; private set; }

    [Required]
    [StringLength(20)]
    public string? LocalityName { get; private set; }

    [Required]
    [StringLength(5)]
    public string? CustomerCode { get; private set; }

    public int CustomerCodeCounter { get; set; }


    public Locality(int localityId, string? localityInitial, string? localityName, string? customerCode, int customerCodeCounter)
    {
        LocalityId = localityId;
        LocalityInitial = localityInitial;
        LocalityName = localityName;
        CustomerCode = customerCode;
        CustomerCodeCounter = customerCodeCounter;
    }

    public static Locality Create(int localityId, string localityInitial, string localityName, string customerCode, int customerCodeCounter)
    {
        if (string.IsNullOrWhiteSpace(localityInitial) || string.IsNullOrWhiteSpace(localityName) || string.IsNullOrWhiteSpace(customerCode) || localityId < 0)
        {
            throw new ArgumentException("Invalid Locality Data.");
        }

        if (localityId <= -1)
        {
            throw new ArgumentException("Locality Id must be greater than zero.");
        }

        if (string.IsNullOrWhiteSpace(localityInitial) || localityInitial.Length > 5)
        {
            throw new ArgumentException("Locality Initial must not be null or exceed 5 characters.");
        }

        if (string.IsNullOrWhiteSpace(localityName) || localityName.Length > 50)
        {
            throw new ArgumentException("Locality Name must not be null or exceed 50 characters.");
        }

        if (string.IsNullOrWhiteSpace(localityInitial) || localityInitial.Length > 5)
        {
            throw new ArgumentException("Locality Initial must not be null or exceed 5 characters.");
        }

        if (string.IsNullOrWhiteSpace(customerCode) || customerCode.Length > 5)
        {
            throw new ArgumentException("Customer Code must not be null or exceed 5 characters.");
        }

        return new Locality(localityId, localityInitial, localityName, customerCode, customerCodeCounter);
    }

    public static Locality Update(int localityId, string localityInitial, string localityName, string customerCode,int customerCodeCounter)
    {
        if (string.IsNullOrWhiteSpace(localityInitial) || string.IsNullOrWhiteSpace(localityName) || string.IsNullOrWhiteSpace(customerCode) || localityId < 0 || customerCodeCounter < 0)
        {
            throw new ArgumentException("Invalid Locality Data.");
        }

        if (localityId <= -1)
        {
            throw new ArgumentException("Locality Id must be greater than zero.");
        }

        if (string.IsNullOrWhiteSpace(localityInitial) || localityInitial.Length > 5)
        {
            throw new ArgumentException("Locality Initial must not be null or exceed 5 characters.");
        }

        if (string.IsNullOrWhiteSpace(localityName) || localityName.Length > 50)
        {
            throw new ArgumentException("Locality Name must not be null or exceed 50 characters.");
        }

        if (string.IsNullOrWhiteSpace(customerCode) || customerCode.Length > 5)
        {
            throw new ArgumentException("Customer Code must not be null or exceed 5 characters.");
        }

        if (customerCodeCounter <= -1)
        {
            throw new ArgumentException("Customer Code counter must be greater than zero.");
        }

        return new Locality(localityId, localityInitial, localityName, customerCode, customerCodeCounter);
    }

}

