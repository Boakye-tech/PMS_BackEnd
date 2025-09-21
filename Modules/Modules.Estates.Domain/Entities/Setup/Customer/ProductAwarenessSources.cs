namespace Modules.Estates.Domain.Entities.Setup.Customer;

public class ProductAwarenessSources : AuditableEntity
{
    [Key]
    [Required]
    public int ProductAwarenessSourcesId { get; set; }

    [Required]
    [StringLength(50)]
    public string ProductAwarenessSource { get; set; }

    public ProductAwarenessSources(int productAwarenessSourcesId, string productAwarenessSource)
    {
        ProductAwarenessSourcesId = productAwarenessSourcesId;
        ProductAwarenessSource = productAwarenessSource;
    }

    public static ProductAwarenessSources Create(int productAwarenessSourcesId, string productAwarenessSource)
    {
        if (string.IsNullOrWhiteSpace(productAwarenessSource) || productAwarenessSourcesId < 0)
        {
            throw new ArgumentException("Invalid Product Awareness Source Data.");
        }

        if (productAwarenessSourcesId < 0)
        {
            throw new ArgumentException("Product Awareness Source Id must be greater than zero.");
        }

        if (string.IsNullOrWhiteSpace(productAwarenessSource) || productAwarenessSource.Length > 50)
        {
            throw new ArgumentException("Product Awareness Source must not be null or exceed 50 characters.");
        }

        return new ProductAwarenessSources(productAwarenessSourcesId, productAwarenessSource);
    }

    public static ProductAwarenessSources Update(int productAwarenessSourcesId, string productAwarenessSource)
    {
        if (string.IsNullOrWhiteSpace(productAwarenessSource) || productAwarenessSourcesId <= 0)
        {
            throw new ArgumentException("Invalid Product Awareness Source Data.");
        }

        if (productAwarenessSourcesId < 0)
        {
            throw new ArgumentException("Product Awareness Source Id must be greater than zero.");
        }

        if (string.IsNullOrWhiteSpace(productAwarenessSource) || productAwarenessSource.Length > 50)
        {
            throw new ArgumentException("Product Awareness Source must not be null or exceed 50 characters.");
        }

        return new ProductAwarenessSources(productAwarenessSourcesId, productAwarenessSource);
    }
}
