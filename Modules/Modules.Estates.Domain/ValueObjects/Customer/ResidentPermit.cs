// /**************************************************
// * Company: MindSprings Company Limited
// * Author: Boakye Ofori-Atta
// * Email Address: boakye.ofori-atta@mindsprings-gh.com
// * Copyright: © 2024 MindSprings Company Limited
// * Create Date: 01/01/2025 
// * Version: 1.0.1
// * Description: Property Management System
//  **************************************************/


namespace Modules.Estates.Domain.ValueObjects.Customer;

public class ResidentPermit
{
    public string? Number { get; private set; }
    public DateTime DateIssued { get; private set; }
    public DateTime ExpiryDate { get; private set; }

    private ResidentPermit() { }

    public static ResidentPermit Create(string number, DateTime dateIssued, DateTime expiryDate)
    {
        if (string.IsNullOrWhiteSpace(number))
            throw new ArgumentException("Permit number cannot be empty");
        if (expiryDate <= dateIssued)
            throw new ArgumentException("Expiry date must be after issue date");

        return new ResidentPermit
        {
            Number = number.Trim(),
            DateIssued = dateIssued,
            ExpiryDate = expiryDate
        };
    }

    public bool IsValid() => DateTime.UtcNow <= ExpiryDate;
}