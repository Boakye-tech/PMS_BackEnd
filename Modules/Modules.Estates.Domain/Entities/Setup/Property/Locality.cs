// /**************************************************
// * Company: MindSprings Company Limited
// * Project Name: Modules.Estates.Domain
// * Full FileName: /Users/imac5k/Projects/PropertyManagementSolution/pms-api/Modules/Modules.Estates.Domain/Entities/Setup/Property/Locality.cs
// * Author: Boakye Ofori-Atta
// * Email Address: boakye.ofori-atta@mindsprings-gh.com
// * Copyright: © 2024 MindSprings Company Limited
// * Create Date: 11/05/2025 01:35 PM
// * Version: 1.0.1
// * Description: Property Management System
//  **************************************************/

namespace Modules.Estates.Domain.Entities.Setup.Property;

public class Locality : AuditableEntity
{
    [Key]
    [Required]
    public int LocalityId { get; private set; }

    [Required]
    [StringLength(10)]
    public string LocalityInitial { get; private set; }

    [Required]
    [StringLength(20)]
    public string LocalityName { get; private set; }

    [Required]
    [StringLength(5)]
    public string CustomerCode { get; private set; }

    [Required]
    public int CustomerCodeCounter { get; set; }

    // Navigation property for sites
    public virtual ICollection<Sites> Sites { get; private set; }


    public Locality(int localityId, string localityInitial, string localityName, string customerCode, int customerCodeCounter)
    {
        LocalityId = localityId;
        LocalityInitial = localityInitial;
        LocalityName = localityName;
        CustomerCode = customerCode;
        CustomerCodeCounter = customerCodeCounter;
        Sites = new List<Sites>();
    }

    public static Locality Create(int localityId, string localityInitial, string localityName, string customerCode, int customerCodeCounter)
    {
        Validate(localityId, localityInitial, localityName, customerCode, customerCodeCounter);
        return new Locality(localityId, localityInitial, localityName, customerCode, customerCodeCounter);
    }

    public void Update(int localityId, string localityInitial, string localityName, string customerCode, int customerCodeCounter)
    {
        Validate(localityId, localityInitial, localityName, customerCode, customerCodeCounter);

        LocalityId = localityId;
        LocalityInitial = localityInitial;
        LocalityName = localityName;
        CustomerCode = customerCode;
        CustomerCodeCounter = customerCodeCounter;
    }

    private static void Validate(int localityId, string localityInitial, string localityName, string customerCode, int customerCodeCounter)
    {
        if (localityId < 0)
            throw new ArgumentException("Locality Id must be greater than zero.");

        if (string.IsNullOrWhiteSpace(localityInitial) || localityInitial.Length > 10)
            throw new ArgumentException("Locality Initial cannot be empty or exceed 10 characters.");

        if (string.IsNullOrWhiteSpace(localityName) || localityName.Length > 20)
            throw new ArgumentException("Locality Name cannot be empty or exceed 20 characters.");

        if (string.IsNullOrWhiteSpace(customerCode) || customerCode.Length > 5)
            throw new ArgumentException("Customer Code cannot be empty or exceed 5 characters.");

        if (customerCodeCounter < 0)
            throw new ArgumentException("Customer Code Counter must be greater than or equal to zero.");
    }
}

