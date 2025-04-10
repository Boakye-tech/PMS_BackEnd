namespace Modules.Estates.Domain.Entities.Setup.Customer;

public class CustomerType : AuditableEntity
{
    [Key]
    [Required]
    public int CustomerTypeId { get; set; }

    [Required]
    [StringLength(50)]
    public string CustomerTypes { get; set; }

    public CustomerType(int customerTypeId, string customerTypes)
    {
        CustomerTypeId = customerTypeId;
        CustomerTypes = customerTypes;
    }

    public static CustomerType Create(int customerTypeId, string customerTypes)
    {
        if (string.IsNullOrWhiteSpace(customerTypes) || customerTypeId < 0)
        {
            throw new ArgumentException("Invalid Customer Type Data.");
        }

        if (customerTypeId < 0)
        {
            throw new ArgumentException("Customer Type Id must be greater than zero.");
        }

        if (string.IsNullOrWhiteSpace(customerTypes) || customerTypes.Length > 50)
        {
            throw new ArgumentException("Customer Type must not be null or exceed 50 characters.");
        }

        return new CustomerType(customerTypeId, customerTypes);
    }

    public static CustomerType Update(int customerTypeId, string customerTypes)
    {
        if (string.IsNullOrWhiteSpace(customerTypes) || customerTypeId < 0)
        {
            throw new ArgumentException("Invalid Customer Type Data.");
        }

        if (customerTypeId < 0)
        {
            throw new ArgumentException("Customer Type Id must be greater than zero.");
        }

        if (string.IsNullOrWhiteSpace(customerTypes) || customerTypes.Length > 50)
        {
            throw new ArgumentException("Customer Type must not be null or exceed 50 characters.");
        }

        return new CustomerType(customerTypeId, customerTypes);
    }
}

