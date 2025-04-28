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

public class Address
{
    public string? PostalAddress { get; private set; }
    public string? ResidentialAddress { get; private set; }
    public string? DigitalAddress { get; private set; }

    private Address() { }

    public static Address Create(string postalAddress, string residentialAddress, string digitalAddress)
    {
        if (string.IsNullOrWhiteSpace(postalAddress))
            throw new ArgumentException("Postal address cannot be empty");
        if (string.IsNullOrWhiteSpace(residentialAddress))
            throw new ArgumentException("Residential address cannot be empty");

        return new Address
        {
            PostalAddress = postalAddress.Trim(),
            ResidentialAddress = residentialAddress.Trim(),
            DigitalAddress = digitalAddress?.Trim()
        };
    }
}

